using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PicoPlaca
{
    public partial class Evaluate : Form
    {
        public Evaluate()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (new clsCheck().validatePicoPlaca(Convert.ToDateTime(dtaDate.Text + " " + timTime.Text), txtPlateNumber.Text))
                lblResult.Text = "You can drive";
            else
                lblResult.Text = "You can't drive";
        }

        #region Test

        public bool ValidateTest(string plateNumber, DateTime day)
        {
            return new clsCheck().validatePicoPlaca(day, plateNumber);
        }

        #endregion Test
    }
}
