using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebR.Models.Body
{
    public class Project
    {
        public List<Projects> projects { get; set; }
    }
    public class Projects
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public string stage { get; set; }
        public ICollection<Categories> categories { get; set; }
        public object created_at { get; set; }
        public object modified_at { get; set; }
        public int[] CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public virtual Categories Categories { get; set; }
    }
    public class Categories
    {
        public int categoryId { get; set; }
    }
}
