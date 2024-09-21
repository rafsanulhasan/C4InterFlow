// <auto-generated/>
using C4InterFlow.Structures;
using C4InterFlow.Structures.Interfaces;

namespace DotNetEShop.SoftwareSystems
{
    public partial class CatalogApi : ISoftwareSystemInstance
    {
        private static readonly string ALIAS = "DotNetEShop.SoftwareSystems.CatalogApi";
        public static SoftwareSystem Instance => new SoftwareSystem(ALIAS, "Catalog Api")
        {
            Description = "",
            Boundary = Boundary.Internal
        };

        public partial class Containers
        {
        }

        public partial class Interfaces
        {
        }
    }
}