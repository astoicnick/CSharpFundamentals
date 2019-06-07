using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1150_RepositoryPattern
{
    public class MenuRepository
    {
        private List<Menu> _menuItemList = new List<Menu>();

        //C
        public bool AddContentToList(Menu menu)
        {
            int initialCount = _menuItemList.Count;
            _menuItemList.Add(menu);
            if ( initialCount < _menuItemList.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //R
        public List<Menu> GetMenus()
        {
            return _menuItemList;
        }
    }
}
