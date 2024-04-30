using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DISA.Model
{
    public class COFinalRepo
    {
        public List<COAnalyze> coFinalAnalyze = new List<COAnalyze>();

        public COFinalRepo()
        {
            InitializeRepo();
        }


        public void InitializeRepo()
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

                        coFinalAnalyze.Add(new COAnalyze()
                        {
                            TimeStamp = DateTime.ParseExact(timeStampString,date,CultureInfo.CurrentCulture),
                            COFinal = double.Parse(values[9])
                        });
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("There orrured an error: " + e);
            }
        }

        public List<COAnalyze> GetAllCOSP()
        {
            return coFinalAnalyze;
        }
  

    }
}
