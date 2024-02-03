using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    public abstract class Collectable : Displayable
    {
        protected Collectable(string description)
        {
            Description = description;
        }

        public string Description { get; set; }
        internal CollectionBoard Board { get; set; }

        public virtual void AddMe(List<Collectable> list) { }

        public virtual void Display() { }

    }
}
