using System.ComponentModel.DataAnnotations;
using System.Xml;

namespace AdventureWork_CAAC.Model
{
    public class ProductModel
    {
        [Key]
        public required int ProductModelID { get; set; }
        public required string Name { get; set; }
        public string CatalogDescription { get; set; } = string.Empty;
        public string Instructions { get; set; } = string.Empty;
        public required Guid rowguid { get; set; }
        public required DateTime ModifiedDate { get; set; }

    }
}
