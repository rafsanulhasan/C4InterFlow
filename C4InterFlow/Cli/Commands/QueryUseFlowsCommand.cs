using System.CommandLine;
using C4InterFlow.Elements;
using C4InterFlow.Elements.Interfaces;
using C4InterFlow.Cli.Commands.Options;
using System.Reflection;

namespace C4InterFlow.Cli.Commands;

public class QueryUseFlowsCommand : Command
{
    private const string COMMAND_NAME = "query-use-flows";
    public QueryUseFlowsCommand() : base(COMMAND_NAME,
        "Given interface(s), finds other interface(s) that given interface(s) are used by.")
    {
        var interfacesOption = InterfacesOption.Get();
        var isRecursiveOption = QueryIsRecursiveOption.Get();
        var queryOutputFileOption = QueryOutputFileOption.Get();
        var queryAppendOption = QueryAppendOption.Get();

        AddOption(interfacesOption);
        AddOption(isRecursiveOption);
        AddOption(queryOutputFileOption);
        AddOption(queryAppendOption);

        this.SetHandler(async (interfaceAliases, isRecursive, queryOutputFile, append) =>
        {
            await Execute(interfaceAliases, isRecursive, queryOutputFile, append);
        },
        interfacesOption, isRecursiveOption, queryOutputFileOption, queryAppendOption);
    }

    public static async Task<int> Execute(string[] interfaceAliases, bool isRecursive, string queryOutputFile, bool append)
    {
        try
        {
            Console.WriteLine($"{COMMAND_NAME} command is executing...");

            var resolvedInterfaceAliases = Utils.ResolveWildcardStructures(interfaceAliases);
            var result = new List<string>();
            var interfaceTypes = Utils.GetAllTypesOfInterface<IInterfaceInstance>();

            foreach (var interfaceAlias in resolvedInterfaceAliases)
            {
                GetUsedBy(interfaceTypes, interfaceAlias, isRecursive, result);        
            }

            if(!string.IsNullOrEmpty(queryOutputFile))
            {
                Utils.WriteLines(result, queryOutputFile, append);
                Console.WriteLine($"{COMMAND_NAME} command completed. See query results in '{queryOutputFile}'.");
            }
            else
            {
                Console.WriteLine($"{COMMAND_NAME} command completed. See query results below.");
                Console.Write($"{string.Join(Environment.NewLine, result.Distinct().ToArray())}");
            }

            return 0;
        }
        catch (Exception e)
        {
            Console.WriteLine($"Querying interfaces failed with exception '{e.Message}'");
            return 1;
        }
    }

    //TODO: Add includePrivateInterfaces parameter (default is false)
    //TODO: Move GetUsedBy into Utils
    //TODO: Add support for queries to DrawDiagramsCommand
    private static IEnumerable<string> GetUsedBy(IEnumerable<Type> interfaceTypes, string interfaceAlias, bool isRecursive, List<string> usedByResult)
    {
        var result = new List<string>();

        if (C4InterFlow.Utils.GetInstance<Interface>(interfaceAlias)?.IsPrivate == true)
        {
            return result;
        }

        foreach (var interfaceType in interfaceTypes)
        {
            var interfaceInstance = interfaceType?.GetProperty("Instance", BindingFlags.Public | BindingFlags.Static)?.GetValue(null, null) as Interface;

            if (interfaceInstance?.Flow.GetUsesInterfaces().Select(x => x.Alias).Contains(interfaceAlias) == true)
            {
                if (isRecursive)
                {
                    var tempResult = GetUsedBy(interfaceTypes, interfaceInstance.Alias, isRecursive, usedByResult);
                    if(!tempResult.Any())
                    { 
                        result.Add(interfaceInstance.Alias);
                    }
                }
                else
                {
                    result.Add(interfaceInstance.Alias);
                }

            }
        }

        usedByResult.AddRange(result);
        return result;
    }
}
