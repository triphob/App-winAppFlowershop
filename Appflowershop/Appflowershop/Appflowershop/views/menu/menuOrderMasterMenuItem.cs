using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appflowershop.views.menu
{

    public class menuOrderMasterMenuItem
    {
        public menuOrderMasterMenuItem()
        {
            TargetType = typeof(menuOrderMasterMenuItem);
        }
        public int Id { get; set; }
        public string Title { get; set; }

        public Type TargetType { get; set; }
    }
}