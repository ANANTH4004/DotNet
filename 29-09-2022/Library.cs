using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Library : DbContext
    {
       public Library() : base()
        {
            //createdatabase if not exists
            //drop create always
            //drop create if model changes
            Database.SetInitializer<Library>(new DropCreateDatabaseIfModelChanges<Library>());
        }
        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<Member> Members { get; set; }
        public virtual DbSet<Issue> Issues { get; set; }
    }
}
