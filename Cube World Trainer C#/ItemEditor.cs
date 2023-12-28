using Memory;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cube_World_Trainer_C_
{
    public partial class ItemEditor : Form
    {
        //Hook
        public Mem meme = new Mem();
        public bool Found_PID;

        //Item Offsets
        string ironAddress = "base+00551E80,2E0,1E8,0,48,0";

        string emeraldAddress = "base+00551E80,2E0,10,10,1E8,0,48,520";

        string fiberAddress = "base+00551E80,2E0,220,78,1E8,0,48,A4";

        string cobwebAddress = "base+00551E80,2E0,10,10,1E8,0,48,148";

        string healthflowerAddress = "base+00551E80,2E0,1E8,0,48,3D8";

        string mushroomAddress = "base+00551E80,2E0,1E8,0,48,334";

        string sugarAddress = "base+00551E80,2E0,10,10,1E8,0,48,70C";

        string lemonAddress = "base+00551E80,2E0,10,10,1E8,0,48,7B0";

        string bombAddress = "base+00551E80,2E0,1E8,0,30,148";

        //string appleAddress = "base+00551E80,2E0,1E8,0,30,148";

        string MashAddress = "base+00551E80,2E0,220,78,1E8,0,30,A4";

        string flaskAddress = "base+00551E80,2E0,218,78,1E8,0,48,1EC";

        string rubyAddress = "base+00551E80,2E0,10,10,1E8,0,48,70C";

        string sapphireAddress = "base+00551E80,2E0,198,10,1E8,0,48,668";

        string diamondAddress = "base+00551E80,2E0,178,70,1E8,0,48,7B0";


        //Potion Offset
        string lifepotionAddress = "base+00551E80,2E0,10,10,1E8,0,30,0";


        public ItemEditor()
        {
            InitializeComponent();
        }

        private void ItemEditor_Load(object sender, EventArgs e)
        {
        }

        private void MainItemTimer_Tick(object sender, EventArgs e)
        {
            //Hook
            if (Found_PID == false)
            {
                int PID = meme.GetProcIdFromName("cubeworld");
                if (PID > 0)
                {
                    //Open Process + Timer Initialize
                    meme.OpenProcess(PID);
                    MainItemTimer.Start();

                    //Base
                    Found_PID = true;
                }

            }
        }

        //Iron
        private void AddIronButton_Click(object sender, EventArgs e)
        {
            int OrigIron  = meme.ReadInt(ironAddress) + 1;
            meme.WriteMemory(ironAddress, "int", OrigIron.ToString());
        }

        private void RemoveIronButton_Click(object sender, EventArgs e)
        {
            int OrigIron = meme.ReadInt(ironAddress) - 1;
            meme.WriteMemory(ironAddress, "int", OrigIron.ToString());
        }


        //Emerald
        private void AddEmeraldButton_Click(object sender, EventArgs e)
        {
            int OrigEmeralt = meme.ReadInt(emeraldAddress) + 1;
            meme.WriteMemory(emeraldAddress, "int", OrigEmeralt.ToString());
        }

        private void RemoveEmeraldButton_Click(object sender, EventArgs e)
        {
            int OrigEmeralt = meme.ReadInt(emeraldAddress) - 1;
            meme.WriteMemory(emeraldAddress, "int", OrigEmeralt.ToString());
        }



        //Plant Fiber
        private void AddFiberButton_Click(object sender, EventArgs e)
        {
            int OrigFiber = meme.ReadInt(emeraldAddress) + 1;
            meme.WriteMemory(fiberAddress, "int", OrigFiber.ToString());
        }

        private void RemoveFiberButton_Click(object sender, EventArgs e)
        {
            int OrigFiber = meme.ReadInt(fiberAddress) - 1;
            meme.WriteMemory(fiberAddress, "int", OrigFiber.ToString());
        }


        //Cobweb
        private void AddCobwebButton_Click(object sender, EventArgs e)
        {
            int OrigWeb = meme.ReadInt(cobwebAddress) + 1;
            meme.WriteMemory(cobwebAddress, "int", OrigWeb.ToString());
        }

        private void RemoveCobwebButton_Click(object sender, EventArgs e)
        {
            int OrigWeb = meme.ReadInt(cobwebAddress) - 1;
            meme.WriteMemory(cobwebAddress, "int", OrigWeb.ToString());
        }



        //Healthflower
        private void AddHeartFlowerButton_Click(object sender, EventArgs e)
        {
            int Origflower = meme.ReadInt(healthflowerAddress) + 1;
            meme.WriteMemory(healthflowerAddress, "int", Origflower.ToString());
        }

        private void RemoveHeartFlowerButton_Click(object sender, EventArgs e)
        {
            int Origflower = meme.ReadInt(healthflowerAddress) - 1;
            meme.WriteMemory(healthflowerAddress, "int", Origflower.ToString());
        }



        //Mushroom
        private void AddMushroomButton_Click(object sender, EventArgs e)
        {
            int OrigMushroom = meme.ReadInt(mushroomAddress) + 1;
            meme.WriteMemory(mushroomAddress, "int", OrigMushroom.ToString());
        }

        private void RemoveMushroomButton_Click(object sender, EventArgs e)
        {
            int OrigMushroom = meme.ReadInt(mushroomAddress) - 1;
            meme.WriteMemory(mushroomAddress, "int", OrigMushroom.ToString());
        }




        //Sugar
        private void AddSugarCube_Click(object sender, EventArgs e)
        {
            int OrigSugar = meme.ReadInt(sugarAddress) + 1;
            meme.WriteMemory(sugarAddress, "int", OrigSugar.ToString());
        }

        private void RemoveSugarCube_Click(object sender, EventArgs e)
        {
            int OrigSugar = meme.ReadInt(sugarAddress) - 1;
            meme.WriteMemory(sugarAddress, "int", OrigSugar.ToString());
        }




        //Lemon
        private void AddLemonButton_Click(object sender, EventArgs e)
        {
            int OrigLemon = meme.ReadInt(lemonAddress) + 1;
            meme.WriteMemory(lemonAddress, "int", OrigLemon.ToString());
        }

        private void RemoveLemonButton_Click(object sender, EventArgs e)
        {
            int OrigLemon = meme.ReadInt(lemonAddress) - 1;
            meme.WriteMemory(lemonAddress, "int", OrigLemon.ToString());
        }


        

        //Apple
        private void AddAppleButton_Click(object sender, EventArgs e)
        {
        //    int OrigApple = meme.ReadInt(appleAddress) + 1;
        //    meme.WriteMemory(MashAddress, "int", OrigApple.ToString());
        }

        private void RemoveAppleButton_Click(object sender, EventArgs e)
        {
        //    int OrigApple = meme.ReadInt(appleAddress) - 1;
        //    meme.WriteMemory(MashAddress, "int", OrigApple.ToString());
        }




        //Mash
        private void AddMashButton_Click(object sender, EventArgs e)
        {
            int OrigMash = meme.ReadInt(MashAddress) + 1;
            meme.WriteMemory(MashAddress, "int", OrigMash.ToString());
        }

        private void RemoveMashButton_Click(object sender, EventArgs e)
        {
            int OrigMash = meme.ReadInt(MashAddress) - 1;
            meme.WriteMemory(MashAddress, "int", OrigMash.ToString());
        }




        //Bomb
        private void AddBombButton_Click(object sender, EventArgs e)
        {
            int OrigBomb = meme.ReadInt(bombAddress) + 1;
            meme.WriteMemory(bombAddress, "int", OrigBomb.ToString());
        }

        private void RemoveBombButton_Click(object sender, EventArgs e)
        {
            int OrigBomb = meme.ReadInt(bombAddress) - 1;
            meme.WriteMemory(bombAddress, "int", OrigBomb.ToString());
        }




        //Flask
        private void AddFlaskButton_Click(object sender, EventArgs e)
        {
            int OrigFlask = meme.ReadInt(flaskAddress) + 1;
            meme.WriteMemory(flaskAddress, "int", OrigFlask.ToString());
        }

        private void RemoveFlaskButton_Click(object sender, EventArgs e)
        {
            int OrigFlask = meme.ReadInt(flaskAddress) - 1;
            meme.WriteMemory(flaskAddress, "int", OrigFlask.ToString());
        }





        //Cactus Potion
        private void AddCactusFlaskButton_Click(object sender, EventArgs e)
        {

        }

        private void RemoveCactusFlaskButton_Click(object sender, EventArgs e)
        {

        }






        //Life Potion
        private void AddLifeFlaskButton_Click(object sender, EventArgs e)
        {
            int OrigLifePotion = meme.ReadInt(lifepotionAddress) + 1;
            meme.WriteMemory(lifepotionAddress, "int", OrigLifePotion.ToString());
        }

        private void RemoveLifeFlaskButton_Click(object sender, EventArgs e)
        {
            int OrigLifePotion = meme.ReadInt(lifepotionAddress) - 1;
            meme.WriteMemory(lifepotionAddress, "int", OrigLifePotion.ToString());
        }




        //Ruby
        private void AddRubyButton_Click(object sender, EventArgs e)
        {
            int OrigRuby = meme.ReadInt(rubyAddress) + 1;
            meme.WriteMemory(rubyAddress, "int", OrigRuby.ToString());
        }

        private void RemoveRubyButton_Click(object sender, EventArgs e)
        {
            int OrigRuby = meme.ReadInt(rubyAddress) - 1;
            meme.WriteMemory(rubyAddress, "int", OrigRuby.ToString());
        }






        //Diamond
        private void AddDiamondButtton_Click(object sender, EventArgs e)
        {
            int OrigDiamond = meme.ReadInt(diamondAddress) + 1;
            meme.WriteMemory(diamondAddress, "int", OrigDiamond.ToString());
        }

        private void RemoveDiamondButton_Click(object sender, EventArgs e)
        {
            int OrigDiamond = meme.ReadInt(diamondAddress) - 1;
            meme.WriteMemory(diamondAddress, "int", OrigDiamond.ToString());
        }





        //Sapphire
        private void AddSapphireButton_Click(object sender, EventArgs e)
        {
            int OrigSapphire = meme.ReadInt(sapphireAddress) + 1;
            meme.WriteMemory(sapphireAddress, "int", OrigSapphire.ToString());
        }

        private void RemoveSapphireButton_Click(object sender, EventArgs e)
        {
            int OrigSapphire = meme.ReadInt(sapphireAddress) - 1;
            meme.WriteMemory(sapphireAddress, "int", OrigSapphire.ToString());
        }
    }
}
