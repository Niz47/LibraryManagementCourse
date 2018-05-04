using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagementCourse.Data.Model
{
    public class Author
    {
        public int AuthorId { get; set; }

        public String Name { get; set; }

        public virtual ICollection<Book> Books { get; set; }
    }
}
