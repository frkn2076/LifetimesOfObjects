using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LifetimesOfObjects.Logic;
using Microsoft.AspNetCore.Mvc;

namespace LifetimesOfObjects.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase {
        private readonly ICar car; 
        private readonly ITruck truck;
        private readonly IBike bike;
        private readonly ICar car2;
        private readonly ITruck truck2;
        private readonly IBike bike2;
        public ValuesController(ICar car, ITruck truck, IBike bike, ICar car2, ITruck truck2, IBike bike2) { 
            this.car = car;
            this.truck = truck;
            this.bike = bike;
            this.car2 = car2;
            this.truck2 = truck2;
            this.bike2 = bike2; }

        [HttpGet("singletonCar")]
        public ActionResult<string> GoCar() {
            string firstInstanceMessage = car.Go();
            string secondInstanceMessage = car2.Go();
            return string.Concat("First: ", firstInstanceMessage, ", Second: ", secondInstanceMessage);
        }

        [HttpGet("scopedTruck")]
        public ActionResult<string> GoTruck() {
            string firstInstanceMessage = truck.Go();
            string secondInstanceMessage = truck2.Go();
            return string.Concat("First: ", firstInstanceMessage, ", Second: ", secondInstanceMessage);
        }

        [HttpGet("transientBike")]
        public ActionResult<string> GoBike() {
            string firstInstanceMessage = bike.Go();
            string secondInstanceMessage = bike2.Go();
            return string.Concat("First: ", firstInstanceMessage, ", Second: ", secondInstanceMessage);
        }
    }
}
