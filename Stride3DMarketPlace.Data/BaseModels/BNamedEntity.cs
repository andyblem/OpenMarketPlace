
namespace Stride3DMarketPlace.Database.BaseModels
{
    public class BNamedEntity<T> : BEntity<T>
    {
        public string Name { get; set; }
    }
}
