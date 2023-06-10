using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class SortableBindingList<T> : BindingList<T>
    {
        

        public SortableBindingList() { }

        public SortableBindingList(IEnumerable<T> list)
        {
            // O(n)
            foreach (T i in list)
            {
                this.Add(i);
            }
        }
        
    }
}
