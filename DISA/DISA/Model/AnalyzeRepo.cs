using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Xml.Linq;
using System.Reflection.PortableExecutable;
//using CsvHelper;

namespace DISA.Model
{
    public class AnalyzeRepo
    {
        public double MaxValue { get; set; }
        public double MinValue { get; set; }

        private List<COAnalyze> COA = new List<COAnalyze>();

        public void GetData() { }

        public AnalyzeRepo()
        {
            InitializeRepository();
        }

        public void InitializeRepository()
        {
            //Her bruger jeg User der gør at den lukker automatisk Streamreaderen når den hentet fra filen

            try
            {   // Open the text file using a stream reader.
                using (StreamReader sr = new StreamReader("DisaCSV.csv"))
                {
                    //Skips the header of the CSV file
                    string header = sr.ReadLine();

                    string date = "yyyy-MM-dd HH:mm:ss";
                    string timeStampString;
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        string[] values = line.Split(",");
                        timeStampString = values[0];

                        COA.Add(new COAnalyze()
                        {
                            TimeStamp = DateTime.ParseExact(timeStampString, date, CultureInfo.CurrentCulture),
                            COSP = int.Parse(values[6]),
                            COFinal = double.Parse(values[9],CultureInfo.InvariantCulture)
                        });
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine( "There orrured an error: " + e);
            }
        }

        public List<COAnalyze> GetAll()
        {
            return COA;
        }

    }
}
