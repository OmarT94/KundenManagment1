﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KundenManagment1.Shared
{
    public class Dept
    {


        [Key]
        public int Id { get; set; }
        public string DeptName { get; set; }
        
       
        


       

    }
}
