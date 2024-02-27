// <auto-generated/>
using C4InterFlow.Structures;
using C4InterFlow.Structures.Interfaces;

namespace dotnet.eShop.Architecture.SoftwareSystems
{
    public partial class BasketApi
    {
        public partial class Containers
        {
            public partial class Data
            {
                public partial class Components
                {
                    public partial class RedisBasketRepository
                    {
                        public partial class Interfaces
                        {
                            public partial class UpdateBasketAsync : IInterfaceInstance
                            {
                                private static readonly string ALIAS = "dotnet.eShop.Architecture.SoftwareSystems.BasketApi.Containers.Data.Components.RedisBasketRepository.Interfaces.UpdateBasketAsync";
                                public static Interface Instance => new Interface(dotnet.eShop.Architecture.SoftwareSystems.BasketApi.Containers.Data.Components.RedisBasketRepository.ALIAS, ALIAS, "Update Basket Async")
                                {
                                    Description = "",
                                    Path = "",
                                    IsPrivate = false,
                                    Protocol = "",
                                    Flow = new Flow(ALIAS)
                                    	.Use("dotnet.eShop.Architecture.SoftwareSystems.BasketApi.Containers.Data.Components.RedisDatabase.Interfaces.StringSetAsync")
                                    	.Use("dotnet.eShop.Architecture.SoftwareSystems.BasketApi.Containers.Data.Components.RedisBasketRepository.Interfaces.GetBasketKey")
                                    	.Use("dotnet.eShop.Architecture.SoftwareSystems.BasketApi.Containers.Data.Components.RedisBasketRepository.Interfaces.GetBasketAsync"),
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