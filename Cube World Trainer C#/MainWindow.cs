using System;
using System.Windows.Forms;
using Memory;

namespace Cube_World_Trainer_C_
{
    public partial class MainWindow : Form
    {
        //Base
        static bool Health_Check;
        static bool Mana_Check;
        static bool Gold_Check;
        static bool Stamina_Check;
        static bool BlockPower_Check;
        static bool Stealth_Check;
        static bool Force_Time_Check;

        static long X_Cordinates;
        static long Y_Cordinates;
        static long Z_Cordinates;

        static bool Found_PID;


        //Save 01
        static long Save_1_X_Cordinates;
        static long Save_1_Y_Cordinates;
        static long Save_1_Z_Cordinates;

        //Teleport 01
        static string TempXCords;
        static string TempYCords;
        static string TempZCords;

        //Save 02
        static long Save_2_X_Cordinates;
        static long Save_2_Y_Cordinates;
        static long Save_2_Z_Cordinates;

        //Teleport 02
        static string TempXCords_02;
        static string TempYCords_02;
        static string TempZCords_02;


        //About MessageBox
        string Message01 = "This Programm got developed By JayC#3820";
        string Title01 = "About";

        //Save01 MessageBox
        string Message02 = "The following Cordinates have been Saved";
        string Title02 = "Save 01";

        //Save02 MessageBox
        string Message03 = "The following Cordinates have been Saved";
        string Title03 = "Save 02";

        //No Saved Teleport 01
        string Message05 = "No Saved Teleports for Save 1";
        string Title05 = "Save 01";

        //No Saved Teleport 02
        string Message06 = "No Saved Teleports for Save 2";
        string Title06 = "Save 02";

        //Broken Item Feature MessageBox
        string Message07 = "WARNING: This Feature can be quiet broken!";
        string Title07 = "Warning!";

        //Reset Teleportation Stuff
        string Message04 = "Reset all Teleport Saves";
        string Title04 = "Teleportation Reset";


        //Hook
        public Mem meme = new Mem();

        string healthAddress = "base+00551A80,8,3C8,8,28,8,58,180";

        string manaAdress = "base+00551A80,8,3C8,8,28,8,58,188";

        string goldAddress = "base+00551A80,8,3C8,8,28,8,58,AAC";

        string staminaAddress = "base+00551A80,8,78,40,0,10,9A0";

        string blockpowerAddress = "base+00551A80,10,8,78,40,0,10,184";

        string stealthAddress = "base+00551A80,10,8,1B0,40,0,10,18C";

        string XcordinateAddress = "base+00551A80,8,40,0,0,8,10,10";

        string YcordinateAddress = "base+00551A80,8,3C8,8,28,8,58,18";

        string ZcordinateAddress = "base+00551A80,10,8,1B0,40,0,10,20";

        string timeAddress = "base+00551A80,6D8,650,300,40,78,200,6FC";


        //Confort Features
        public static bool Keep_Pre_Gold_Level;
        public int Pre_Gold_Level;



        public MainWindow()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Base
            Health_Check = false;
            Mana_Check = false;
            Gold_Check = false;

            HealthCheckbox.Checked = false;
            ManaCheckbox.Checked = false;
            GoldCheckbox.Checked = false;

            Keep_Pre_Gold_Level = true;
            Found_PID = false;

            //Save 01
            Save_1_X_Cordinates = 0;
            Save_1_Y_Cordinates = 0;
            Save_1_Z_Cordinates = 0;

            //Save 02
            Save_2_X_Cordinates = 0;
            Save_2_Y_Cordinates = 0;
            Save_2_Z_Cordinates = 0;
        }




        private void MainTimer_Tick(object sender, EventArgs e)
        {


            //Test
            //Console.WriteLine("Read Value:" + Pre_Gold_Level + Keep_Pre_Gold_Level);

            //Hook
            if (Found_PID == false)
            {
                int PID = meme.GetProcIdFromName("cubeworld");
                if (PID > 0)
                {
                    //Open Process + Timer Initialize
                    meme.OpenProcess(PID);
                    MainTimer.Start();

                    //Confort
                    Pre_Gold_Level = meme.ReadInt(goldAddress);

                    //Base
                    Found_PID = true;
                }

            }


            if (Found_PID == true)
            {
                //Health
                if (Health_Check == true)
                {
                    meme.WriteMemory(healthAddress, "float", "2000");
                }

                //Mana
                if (Mana_Check == true)
                {
                    meme.WriteMemory(manaAdress, "float", "1");
                }

                //Gold
                if (Gold_Check == true)
                {
                    meme.WriteMemory(goldAddress, "int", "99999");
                }

                //Stamina
                if (Stamina_Check == true)
                {
                    meme.WriteMemory(staminaAddress, "float", "1");
                }

                //Block Power
                if (BlockPower_Check == true)
                {
                    meme.WriteMemory(blockpowerAddress, "float", "1");
                }

                //Stelath
                if (Stealth_Check == true)
                {
                    meme.WriteMemory(stealthAddress, "float", "1");
                }

                //Force 10AM
                if (Force_Time_Check == true)
                {
                    meme.WriteMemory(timeAddress, "float", "36000000");
                }

                // X, Y, Z
                X_Cordinates = meme.ReadLong(XcordinateAddress);
                XLabel.Text = X_Cordinates.ToString();

                Y_Cordinates = meme.ReadLong(YcordinateAddress);
                YLabel.Text = Y_Cordinates.ToString();

                Z_Cordinates = meme.ReadLong(ZcordinateAddress);
                ZLabel.Text = Z_Cordinates.ToString();
            }
        }






        private void QuitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AboutButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Message01, Title01, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }



        private void HealthCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (Health_Check == false)
            {
                Health_Check = true;
            }
            else
            {
                Health_Check = false;
            }
        }

        private void ManaCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (Mana_Check == false)
            {
                Mana_Check = true;
            }
            else
            {
                Mana_Check = false;
            }
        }

        private void GoldCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (Gold_Check == false)
            {
                Gold_Check = true;
            }
            else
            {    
                if (Found_PID == true)
                {
                    if (Keep_Pre_Gold_Level == true)
                    {
                        meme.WriteMemory(goldAddress, "int", Pre_Gold_Level.ToString());
                    }
                }

                Gold_Check = false;
            }
        }

        private void KeepGoldCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (Keep_Pre_Gold_Level == false)
            {
                Keep_Pre_Gold_Level = true;
            }
            else
            {
                Keep_Pre_Gold_Level = false;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (Stamina_Check == false)
            {
                Stamina_Check = true;
            }
            else
            {
                Stamina_Check = false;
            }
        }

        private void BlockPowerCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (BlockPower_Check == false)
            {
                BlockPower_Check = true;
            }
            else
            {
                BlockPower_Check = false;
            }
        }

        private void StalthCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (Stealth_Check == false)
            {
                Stealth_Check = true;
            }
            else
            {
                Stealth_Check = false;
            }
        }

        private void Save1Button_Click(object sender, EventArgs e)
        {
            if (Found_PID == true)
            {
                Save_1_X_Cordinates = X_Cordinates;
                Save_1_Y_Cordinates = Y_Cordinates;
                Save_1_Z_Cordinates = Z_Cordinates;

                MessageBox.Show(Message02 + "X:" + Save_1_X_Cordinates + "Y:" + Save_1_Y_Cordinates + "Z:" + Save_1_Z_Cordinates, Title02, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Save2Button_Click(object sender, EventArgs e)
        {
            if (Found_PID == true)
            {
                Save_2_X_Cordinates = X_Cordinates;
                Save_2_Y_Cordinates = Y_Cordinates;
                Save_2_Z_Cordinates = Z_Cordinates;

                MessageBox.Show(Message03 + "X:" + Save_2_X_Cordinates + "Y:" + Save_2_Y_Cordinates + "Z:" + Save_2_Z_Cordinates, Title03, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Teleport1Button_Click(object sender, EventArgs e)
        {
            TempXCords = Save_1_X_Cordinates.ToString();
            TempYCords = Save_1_Y_Cordinates.ToString();
            TempZCords = Save_1_Z_Cordinates.ToString();

            if (Found_PID == true)
            {
                if (Save_1_X_Cordinates > 0 | Save_1_X_Cordinates < 0)
                {
                    meme.WriteMemory(XcordinateAddress, "long", TempXCords);
                    meme.WriteMemory(YcordinateAddress, "long", TempYCords);
                    meme.WriteMemory(ZcordinateAddress, "long", TempZCords);
                }
                else
                {
                    MessageBox.Show(Message05, Title05, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void Teleport2Button_Click(object sender, EventArgs e)
        {
            TempXCords_02 = Save_2_X_Cordinates.ToString();
            TempYCords_02 = Save_2_Y_Cordinates.ToString();
            TempZCords_02 = Save_2_Z_Cordinates.ToString();

            if (Found_PID == true)
            {
                if (Save_2_X_Cordinates > 0 | Save_2_X_Cordinates < 0)
                {
                    meme.WriteMemory(XcordinateAddress, "long", TempXCords_02);
                    meme.WriteMemory(YcordinateAddress, "long", TempYCords_02);
                    meme.WriteMemory(ZcordinateAddress, "long", TempZCords_02);
                }
                else
                {
                    MessageBox.Show(Message06, Title06, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void ResetTPButton_Click(object sender, EventArgs e)
        {
            //Save 01
            Save_1_X_Cordinates = 0;
            Save_1_Y_Cordinates = 0;
            Save_1_Z_Cordinates = 0;

            //Teleport 01
            TempXCords = "";
            TempYCords = "";
            TempZCords = "";



            //Save 02
            Save_2_X_Cordinates = 0;
            Save_2_Y_Cordinates = 0;
            Save_2_Z_Cordinates = 0;

            //Teleport 02
            TempXCords_02 = "";
            TempYCords_02 = "";
            TempZCords_02 = "";

            if (Found_PID == true)
            {
                MessageBox.Show(Message04, Title04, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void TimeCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (Force_Time_Check == false)
            {
                Force_Time_Check = true;
            }
            else
            {
                Force_Time_Check = false;
            }
        }

        private void ItemEditorButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Message07, Title07, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            ItemEditor f2 = new ItemEditor();
            f2.ShowDialog();
        }
    }
}
