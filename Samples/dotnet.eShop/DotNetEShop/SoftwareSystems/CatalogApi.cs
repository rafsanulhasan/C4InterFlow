// <auto-generated/>
using C4InterFlow;
using C4InterFlow.Structures;
using C4InterFlow.Structures.Interfaces;

namespace DotNetEShop.SoftwareSystems
{
    public partial class CatalogApi : ISoftwareSystemInstance
    {
        public SoftwareSystem Instance => new SoftwareSystem(GetType(), "Catalog Api")
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