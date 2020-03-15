using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LifetimesOfObjects.Logic {
    class Bike : IBike {
        public Bike() {
            Text = "New instance of Bike has created";
        }
        private string Text { get; set; }
        private string Go() {
            var res = Text;
            Text = "";
            return res;
        }

        #region Interface
        string IBike.Go() => Go();
        #endregion
    }

    public interface IBike {
        string Go();
    }
}
