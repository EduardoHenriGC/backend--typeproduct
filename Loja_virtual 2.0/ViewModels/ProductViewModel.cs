using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace LojaVirtual.ViewModels
{
    public class ProductViewModel
    {
        // Propriedades existentes
        [Key]

        public int Id { get; set; }


        public string? name { get; set; }
        public string? type { get; set; }
        public string? description { get; set; }
        public double? price { get; set; }
        public string? urlImg { get; set; }


    }
}



       
