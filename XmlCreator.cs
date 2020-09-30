using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;

namespace XMLSerializer
{
    public class XmlCreator
    {
        private XmlSerializer _xmlSerializer;
        FileStream _fs;

        public XmlCreator(string filePath)
        {
            try
            {
                _fs = new FileStream(filePath, FileMode.OpenOrCreate);
                _xmlSerializer = new XmlSerializer(typeof(Cars));
            }
            catch (Exception)
            {

                throw new Exception();
            }
        }
        public void Serialize(List<Car> cars)
        {
            Cars carsList = new Cars();
            carsList.CarList.AddRange(cars);

            _xmlSerializer.Serialize(_fs, carsList);
        }
        public void Close()
        {
            _fs.Close();
        }

        internal Cars Deserialize()
        {
            Cars desCar = new Cars();
            try
            {
                XmlReader xmlReader = XmlReader.Create(_fs);
                desCar = ((Cars)_xmlSerializer.Deserialize(xmlReader));
            }
            catch (Exception)
            {
                throw;
            }

            return desCar;
        }
    }
}
