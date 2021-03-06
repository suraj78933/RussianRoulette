using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Reflection;
using System.IO;

namespace RussianRoulette
{
    public partial class RussianRoulette : Form
    {
        Game myGame = new Game();
        public RussianRoulette()
        {
            InitializeComponent();
        }
        private void RussianRoulette_Load(object sender, EventArgs e)
        {
            //Enables only load button and disables rest.
            btnLoad.Enabled = true;
            btnSpin.Enabled = false;
            btnShoot.Enabled = false;
            btnShootAway.Enabled = false;
        }
        private void btnLoad_Click(object sender, EventArgs e)
        {
            myGame.load();
            //code to display image in picture box on load button 
            Assembly myAssembly = Assembly.GetExecutingAssembly();
            Stream myStream = myAssembly.GetManifestResourceStream("RussianRoulette.Resources.gun2.jpg");
            Bitmap bmp = new Bitmap(myStream);
            PicBox_Gun.Image = bmp;
            //Enables spin button. Disables load.
            btnLoad.Enabled = false;
            btnSpin.Enabled = true;
            btnShoot.Enabled = false;
            btnShootAway.Enabled = false;
        }

        private void btnSpin_Click(object sender, EventArgs e)
        {
            //code to play sound on button click 
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.spin);
            player.Play();

            //runs spinner class.  
            myGame.spinner();
            //code to display image in picture box on spin
            Assembly myAssembly = Assembly.GetExecutingAssembly();
            Stream myStream = myAssembly.GetManifestResourceStream("RussianRoulette.Resources._2.gif");
            Bitmap bmp = new Bitmap(myStream);
            PicBox_Gun.Image = bmp;

            lblRandom.Text = myGame.Rnd.ToString();
            lblBulletsFired.Text = myGame.BulletsFired.ToString();
            lblAway.Text = myGame.Away.ToString();

            //Enables shoot and point away. Disables spin.

            btnShoot.Enabled = true;
            btnShootAway.Enabled = true;
            btnSpin.Enabled = false;

        }

        private void btnShoot_Click(object sender, EventArgs e)
        {
            //code to display image in picture box on spin
            Assembly myAssembly = Assembly.GetExecutingAssembly();
            Stream myStream = myAssembly.GetManifestResourceStream("RussianRoulette.Resources._3.gif");
            Bitmap bmp = new Bitmap(myStream);
            PicBox_Gun.Image = bmp;

            //Sound play
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.fire);
            player.Play();

            myGame.shoot();
            //runs calculate method in class
            winloss();
        }

        private void btnShootAway_Click(object sender, EventArgs e)
        {
            //code to display image in picture box on spin
            Assembly myAssembly = Assembly.GetExecutingAssembly();
            Stream myStream = myAssembly.GetManifestResourceStream("RussianRoulette.Resources._3.gif");
            Bitmap bmp = new Bitmap(myStream);
            PicBox_Gun.Image = bmp;
            //Sound play
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.Revolver1);
            player.Play();

            myGame.shootAway();
            //runs calculate method in class
            winloss();
        }

        public void winloss()
        {
            //changes whether you can shoot, point away, or spin as necessary depending on variables in class
            btnLoad.Enabled = myGame.btn_load_var;
            btnSpin.Enabled = myGame.btnSpin;
            btnShoot.Enabled = myGame.btnShoot;
            btnShootAway.Enabled = myGame.btnShootAway;


            //shows the number of bullets you have fired and times you have pointed away
            lblBulletsFired.Text = myGame.BulletsFired.ToString();
            lblAway.Text = myGame.Away.ToString();

            //displays winners, losers, and total on the form
            lblWins.Text = myGame.TotalWins.ToString();
            lblLosses.Text = myGame.TotalLosses.ToString();
            lblTotal.Text = myGame.Total.ToString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit(); // to close the application
        }


    }
}
