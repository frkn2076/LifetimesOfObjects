using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LifetimesOfObjects.Logic {
    class Car : ICar {
        public Car() {
            Text = "New instance of car has created";
        }
        private string Text { get; set; }
        private string Go() {
            var res = Text;
            Text = "";
            return res;
        }

        #region Interface
        string ICar.Go() => Go();
        #endregion
    }

    public interface ICar {
        string Go();
    }
}
