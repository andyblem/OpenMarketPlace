
namespace Stride3DMarketPlace.Persistance.BaseModels
{
    public class BNamedEntity<T> : BEntity<T>
    {
        public string Name { get; set; }
    }
}
