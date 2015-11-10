using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace twozerofoureight
{
    public partial class ShowScoreRealtime : Form, View
    {
        public ShowScoreRealtime()
        {
            InitializeComponent();
        }
        public void Notify(Model m)
        {
            UpdateScore(((TwoZeroFourEightModel)m).getSum());
        }

        private void UpdateScore(int sum)
        {
            lblScore.Text = Convert.ToString(sum);
        }
    }
}
