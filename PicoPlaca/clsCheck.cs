using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PicoPlaca
{
    // claas of logical for validate 
    public class clsCheck
    {
        string beginTimeMorning = "07:00", endTimeMorning = "09:30"; 
        string beginTimeAfternoon = "16:00", endTimeAfternoon = "19:30";
        List<clsNumber> lstObjNumber;

        public clsCheck ()
        {
            lstObjNumber = new List<clsNumber>();
            lstObjNumber.Add(new clsNumber(DayOfWeek.Monday, "1,2"));
            lstObjNumber.Add(new clsNumber(DayOfWeek.Tuesday, "3,4"));
            lstObjNumber.Add(new clsNumber(DayOfWeek.Wednesday, "5,6"));
            lstObjNumber.Add(new clsNumber(DayOfWeek.Thursday, "7,8"));
            lstObjNumber.Add(new clsNumber(DayOfWeek.Friday, "9,0"));
        }

        /// <summary>
        /// Validete de date and time
        /// </summary>
        /// <param name="dateNow">date</param>
        /// <param name="plateNumber">plate number</param>
        /// <returns>true or false</returns>
        public bool validatePicoPlaca(DateTime dateNow, string plateNumber)
        {
            try
            {
                bool result = false;
                int number = Convert.ToInt32(plateNumber.Substring(plateNumber.Length - 1, 1));  //last digit of Licence Place Number
                DayOfWeek day = dateNow.DayOfWeek;  // day of de week
                clsNumber objNumber = lstObjNumber.Where(l => l.day == day).First(); //seek day
                if (objNumber != null)
                {
                    string[] numberOfDay = objNumber.numbers.Split(',');
                    if (number == Convert.ToInt32(numberOfDay[0]) || number == Convert.ToInt32(numberOfDay[1]))
                    {
                        DateTime morningBeginTime = Convert.ToDateTime(dateNow.ToShortDateString() + " " + beginTimeMorning);
                        DateTime morningEndTime = Convert.ToDateTime(dateNow.ToShortDateString() + " " + endTimeMorning);
                        if (dateNow >= morningBeginTime && dateNow <= morningEndTime)
                            result = false;
                        else
                        {
                            DateTime afternoonBeginTime = Convert.ToDateTime(dateNow.ToShortDateString() + " " + beginTimeAfternoon);
                            DateTime afternoonEndTime = Convert.ToDateTime(dateNow.ToShortDateString() + " " + endTimeAfternoon);
                            if (dateNow >= afternoonBeginTime && dateNow <= afternoonEndTime)
                                result = false;
                            else
                                result = true;
                        }
                    }
                    else
                        result = true;
                }
                else
                    result = true;
                return result;
            }
            catch(System.Exception)
            {
                return false;
            }
        }
    }
}
