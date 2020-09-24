using System.Collections.Generic;
using System.IO;

namespace XMLSerializer
{
    public class FillCreator
    {
        private FileStream _fs;
        public FillCreator()
        {
            try
            {
                _fs = new FileStream(".samochody.txt", FileMode.OpenOrCreate);
            }
            catch (System.Exception)
            {
                throw;
            }
        }
        public void Write(IEnumerable<XMLSerializer.Car> cars)
        {
            StreamWriter sw = new StreamWriter(_fs);
            foreach (var item in cars)
            {
                sw.WriteLine("[SAMOCHOD]");
                sw.WriteLine("[nr_rejestracyjny]");
                sw.WriteLine(item.registrationNumber.ToString());
                sw.WriteLine("[marka]");
                sw.WriteLine(item.brand.ToString());
                sw.WriteLine("[rok_produkcji]");
                sw.WriteLine(item.manufacturerYear.ToString());
                sw.WriteLine("[kolor]");
                sw.WriteLine(item.color.ToString());
                sw.WriteLine("[ilosc_pasazerow]");
                sw.WriteLine(item.passangerCount.ToString());
                sw.WriteLine("[END_SAMOCHOD]");
            }
            sw.Close();
        }
    }
}
