using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ToDoList.Models
{
    public class ToDo
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Rating { get; set; }
        public string PhotoURL { get; set; }
        public DateTime CreatedOn { get; set; }
        public bool isDone { get; set; }
        public virtual ApplicationUser User { get; set; }
    }
}