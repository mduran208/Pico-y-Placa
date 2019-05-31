using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace PicoPlaca
{
    // entity of days and numbers of de last Licence Place Number
    [DataContract]
    public class clsNumber
    {
        #region Propiedades

        [DataMember]
        public DayOfWeek day { get; set; }
        [DataMember]
        public string numbers { get; set; }

        #endregion Propiedades

        #region Constructor

        public clsNumber()
        { }

        public clsNumber(DayOfWeek day, string numbers)
        {
            this.day = day;
            this.numbers = numbers;
        }

        #endregion Constructor
    }
}
