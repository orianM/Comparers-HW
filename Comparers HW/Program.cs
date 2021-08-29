using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comparers_HW
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            #region question 1

            var s1 = new Student("Buddy", "Jesper", 30);
            var s2 = new Student("Asaf", "Pepper", 70);
            var s3 = new Student("Uriel", "Calvin", 65);
            var s4 = new Student("Buddy", "Pepper", 80);

            List<Student> students = new()
            {
                s1,
                s2,
                s3,
                s4
            };

            students.Sort();

            #endregion

            #region question 2

            TempMeasure t1 = new("London",  3, 36.7F, 15);
            TempMeasure t2 = new("New York",  13, 34.4F, 17);
            TempMeasure t3 = new("London",  8, 33.2F, 30);
            TempMeasure t4 = new("Texas",  18, 23.2F, 25);

            List<TempMeasure> tempMeasures = new List<TempMeasure>() 
            { 
                t1,
                t2,
                t3,
                t4
            };

            tempMeasures.Sort();


            #endregion

            //Application.SetHighDpiMode(HighDpiMode.SystemAware);
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());

        }
    }
}
