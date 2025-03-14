using System.CommandLine;
using System.CommandLine.Parsing;

namespace C4InterFlow.Cli.Commands.Options;

public static class ViewInputPathsOption
{
    public static Option<string[]> Get()
    {
        const string description =
            "The paths to the Architecture Views input.";

        var option = new Option<string[]>(new[] { "--view-input-paths", "-v-inp" }, description)
        {
            AllowMultipleArgumentsPerToken = true,
            IsRequired = true
        };

        return option;
    }
}
