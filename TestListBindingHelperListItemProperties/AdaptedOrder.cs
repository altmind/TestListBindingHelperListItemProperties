using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestListBindingHelperListItemProperties
{
    public class AdaptedOrder : IComparable<AdaptedOrder>
    {

        [Browsable(false)]
        public DateTime DateTime { get; private set; }

        public string BuysPrice { get; private set; }

        public int CompareTo(AdaptedOrder other)
        {
            return BuysPrice.CompareTo(other.BuysPrice);
        }
    }

}
