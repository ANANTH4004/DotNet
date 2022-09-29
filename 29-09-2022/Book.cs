using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Library
{
    public class Book
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Book_No { get; set; }
       
        public string Book_Name { get; set; }
        public string Author { get; set; }
        public double Cost { get; set; }
        public string Category { get; set; }
        public virtual Issue issue { get; set; }
    }
    
}
