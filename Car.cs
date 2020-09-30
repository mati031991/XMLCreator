using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMLSerializer
{
    [System.Xml.Serialization.XmlRoot("Cars")]
    public class Car
    {
        public string registrationNumber { get; set; }
        public string brand { get; set; }
        public int manufacturerYear { get; set; }
        public string color { get; set; }
        public int passangerCount { get; set; }

        public Car()
        {

        }
        /// <summary>
        /// Declaration new Car object
        /// </summary>
        /// <param name="registrationNumber"></param>
        /// <param name="brand"></param>
        /// <param name="manufacturerYear"></param>
        /// <param name="color"></param>
        /// <param name="passangerCount"></param>
        public Car(string registrationNumber, string brand, int manufacturerYear, string color, int passangerCount)
        {
            this.registrationNumber = registrationNumber;
            this.brand = brand;
            this.manufacturerYear = manufacturerYear;
            this.color = color;
            this.passangerCount = passangerCount;
        }
    }
}
