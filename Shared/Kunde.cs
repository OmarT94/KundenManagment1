using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KundenManagment1.Shared
{
    public class Kunde
    {
        [Key]
        public int KdId { get; set; }
        [Required]
        public string KdName { get; set; }
        public string KdAdresse { get; set; }
        public string KdImgPath { get; set; }
        public int KdAlter { get; set; }
    }
}
