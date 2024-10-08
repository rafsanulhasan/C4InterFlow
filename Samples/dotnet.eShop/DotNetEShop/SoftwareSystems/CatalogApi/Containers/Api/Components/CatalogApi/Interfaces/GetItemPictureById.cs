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
                            public partial class GetItemPictureById : IInterfaceInstance
                            {
                                public Interface Instance => new Interface(GetType(), "Get Item Picture By Id")
                                {
                                    Description = "",
                                    Path = "",
                                    IsPrivate = false,
                                    Protocol = "",
                                    Flow = new Flow(Interface.GetAlias(GetType()))
                                    	.If(@"item is null")
                                    		.Return(@"TypedResults.NotFound")
                                    	.EndIf()
                                    	.Use<DotNetEShop.SoftwareSystems.CatalogApi.Containers.Api.Components.CatalogApi.Interfaces.GetFullPath>()
                                    	.Use<DotNetEShop.SoftwareSystems.CatalogApi.Containers.Api.Components.CatalogApi.Interfaces.GetImageMimeTypeFromImageFileExtension>()
                                    	.Return(@"TypedResults.PhysicalFile"),
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