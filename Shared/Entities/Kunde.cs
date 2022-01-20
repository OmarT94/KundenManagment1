using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KundenManagment1.Shared
{
    public class Kunde
    {
        [Key]
        public int KdId { get; set; }
        public string KdName { get; set; }
        public string KdAdresse { get; set; }
        public string KdImgPath { get; set; }
        public int KdAlter { get; set; }

        [ForeignKey("DeptId")]
        //[ForeignKey("Id")]

        public Dept Dept { get; set; }          //All DeptId werden angezeigt 

        //public virtual ICollection<Dept> Dept { get; set; }

    }
}
