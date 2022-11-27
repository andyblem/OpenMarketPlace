
namespace Stride3dMarketplace.Persistance.BaseModels
{
    public class BNamedEntity<T1, T2> : BEntity<T1, T2>
    {
        public string? Name { get; set; }
    }
}
