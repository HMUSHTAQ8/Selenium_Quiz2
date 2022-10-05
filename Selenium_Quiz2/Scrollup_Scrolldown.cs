using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_Quiz2
{
    public class Scrollup_Scrolldown
    {
        Verify_Subscription subscrip =new Verify_Subscription();
        public void scrolldown_assert()
        {
            subscrip.Assert_subscriptiontext();
        }
    }
}
