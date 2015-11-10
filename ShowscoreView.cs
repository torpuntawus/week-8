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
    public partial class ShowscoreView : Form,View
    {
        public ShowscoreView() 
        {
            InitializeComponent();         
        }
        public void Notify(Model m)
        {
            ScoreV2(((TwoZeroFourEightModel)m).GetScore()); 
        }
        private void ScoreV2(int score)
        {
            lblScore2.Text = Convert.ToString(score);
        } 
    }
}
