using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LifetimesOfObjects.Logic {
    class Truck : ITruck {
        public Truck() {
            Text = "New instance of Truck has created";
        }
        private string Text { get; set; }
        private string Go() {
            var res = Text;
            Text = "";
            return res;
        }

        #region Interface
        string ITruck.Go() => Go();
        #endregion
    }

    public interface ITruck {
        string Go();
    }
}
