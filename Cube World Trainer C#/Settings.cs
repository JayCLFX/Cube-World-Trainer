using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cube_World_Trainer_C_
{
    public partial class Settings : Form
    {

        public Settings()
        {
            InitializeComponent();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
        }

        private void PreGoldCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (Cube_World_Trainer_C_.MainWindow.Keep_Pre_Gold_Level == false)
            {
                Cube_World_Trainer_C_.MainWindow.Keep_Pre_Gold_Level = true;

            }
            else
            {
                Cube_World_Trainer_C_.MainWindow.Keep_Pre_Gold_Level = false;
            }
        }

        private void SettingsSaveButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
