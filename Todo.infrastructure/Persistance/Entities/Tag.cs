using System;
using System.Collections.Generic;
using System.Text;

namespace Todo.infrastructure.Persistance.Entities
{
    public class Tag 
    {

        public string Name { get; set; }
        public string ColorCode { get; set; }

        public ICollection<TodoItemTag> TodoItemTags { get; set; }
    }
}
