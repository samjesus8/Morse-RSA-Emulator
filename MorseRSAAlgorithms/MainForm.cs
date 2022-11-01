using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MorseRSAAlgorithms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void morseButton_Click(object sender, EventArgs e)
        {
            MorseCodeEmulator morseEmulator = new MorseCodeEmulator();
            morseEmulator.Show();
        }

        private void rsaButton_Click(object sender, EventArgs e)
        {
            RSAEmulator rsaEmulator = new RSAEmulator();
            rsaEmulator.Show();
        }
    }
}
