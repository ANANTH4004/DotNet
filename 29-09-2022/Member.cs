using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Member
    {
       
        public int Member_Id { get; set; }
        [Key,ForeignKey("Issue")]
        public int IssueId { get; set; }
        // [ ForeignKey("IssueId")]
       
        
        public string Member_Name { get; set; }
        public DateTime Acc_Open_Date { get; set; }
        public double Penalty_Amount { get; set; }
       public virtual Issue Issue { get; set; }



    }
}
