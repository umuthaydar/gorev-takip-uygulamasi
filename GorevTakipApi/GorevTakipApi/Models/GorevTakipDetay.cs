using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
namespace GorevTakipApi.Models
{
    public class GorevTakipDetay
    {
        [Key]
        public int RecId { get; set; }
        
        [Column(TypeName = "nchar(10)")]
        public string KullaniciAdi { get; set; }
        
        [Column(TypeName = "nvarchar(50)")]
        public string GorevBasligi { get; set; }
        
        [Column(TypeName = "nvarchar(MAX)")]
        public string Gorev { get; set; }
        
        [Column(TypeName = "nvarchar(10)")]
        public string KayitTarihi { get; set; }
        
        [Column(TypeName = "nvarchar(10)")]
        public string TerminTarihi { get; set; }
        
        [Column(TypeName = "nvarchar(10)")]
        public string YapilmaTarihi { get; set; }
}
}
