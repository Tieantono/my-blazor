using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBlazor.Shared.Tabs
{
    /// <summary>
    /// Originally will be used as the state container between tab components.
    /// </summary>
    public class TabNavState
    {
        public event Action OnChange;

        public TabItem<object> ActiveTab { get; set; }

        public void SetTitle(string title)
        {
            ActiveTab.Title = title;

            NotifyStateChanged();
        }

        private void NotifyStateChanged() => OnChange?.Invoke();
    }
}
