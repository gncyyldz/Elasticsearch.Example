using Elasticsearch.Example.Modals.Common;

namespace Elasticsearch.Example.Modals
{
    public class Product : IElasticsearchModal
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }
}
