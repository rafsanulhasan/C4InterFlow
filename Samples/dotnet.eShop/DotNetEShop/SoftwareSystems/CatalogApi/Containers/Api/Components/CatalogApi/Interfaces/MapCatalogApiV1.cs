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
                            public partial class MapCatalogApiV1 : IInterfaceInstance
                            {
                                public Interface Instance => new Interface(GetType(), "Map Catalog Api V 1")
                                {
                                    Description = "",
                                    Path = "",
                                    IsPrivate = false,
                                    Protocol = "",
                                    Flow = new Flow(Interface.GetAlias(GetType()))
                                    	.Return(@"app"),
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