using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Issue
    {
        [Key]
        public int IssueId { get; set; }
        public DateTime IssueDate { get; set; }
        
        //navigation 
        
        public virtual  Member member { get; set; }

        public virtual ICollection<Book> books { get; set; }






    }
}
