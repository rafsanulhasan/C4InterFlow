// <auto-generated/>
using C4InterFlow;
using C4InterFlow.Structures;
using C4InterFlow.Structures.Interfaces;

namespace DotNetEShop.SoftwareSystems
{
    public partial class CatalogApi
    {
        public partial class Containers
        {
            public partial class Api
            {
                public partial class Components
                {
                    public partial class CatalogApi
                    {
                        public partial class Interfaces
                        {
                            public partial class GetItemsBySemanticRelevance : IInterfaceInstance
                            {
                                public Interface Instance => new Interface(GetType(), "Get Items By Semantic Relevance")
                                {
                                    Description = "",
                                    Path = "",
                                    IsPrivate = false,
                                    Protocol = "",
                                    Flow = new Flow(Interface.GetAlias(GetType()))
                                    	.If(@"!services.CatalogAI.IsEnabled")
                                    		.Use<DotNetEShop.SoftwareSystems.CatalogApi.Containers.Api.Components.CatalogApi.Interfaces.GetItemsByName>()
                                    	.EndIf()
                                    	.If(@"services.Logger.IsEnabled(LogLevel.Debug)")
                                    		.Use<DotNetEShop.SoftwareSystems.CatalogApi.Containers.Infrastructure.Components.CatalogContext.Interfaces.CatalogItemsToListAsync>()
                                    		.Else()
                                    		.Use<DotNetEShop.SoftwareSystems.CatalogApi.Containers.Infrastructure.Components.CatalogContext.Interfaces.CatalogItemsToListAsync>()
                                    	.EndIf()
                                    	.Return(@"TypedResults.Ok"),
                                    Input = "",
                                    InputTemplate = "",
                                    Output = "",
                                    OutputTemplate = ""
                                };
                            }
                        }
                    }
                }
            }
        }
    }
}