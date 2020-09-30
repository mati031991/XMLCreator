using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XMLSerializer
{
    public class Cars
    {
        [XmlArray("CarList"), XmlArrayItem(typeof(Car), ElementName = "Car")]
        public List<Car> CarList { get; set; }
        public Cars()
        {
            CarList = new List<Car>();
        }
    }
}
