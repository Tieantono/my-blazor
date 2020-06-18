using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBlazor.Shared.Tabs
{
    public class TabItem<T>
    {
        public string Title { get; set; }

        public T Item { get; set; }
    }
}
