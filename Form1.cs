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

namespace soundboard
{
    public partial class Form1 : Form
    {
        SoundPlayer Sesci = new SoundPlayer();
        public Form1()
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            InitializeComponent();

            #region pics
            this.BackColor = Color.BlueViolet;
            ssCat.BackgroundImage = Properties.Resources.sovietKedi;
            ssCat.BackgroundImageLayout=ImageLayout.Stretch;
            mep.BackgroundImage = Properties.Resources.meep_meep;
            mep.BackgroundImageLayout = ImageLayout.Stretch;
            shrek.BackgroundImage = Properties.Resources.somebodya;
            shrek.BackgroundImageLayout = ImageLayout.Stretch;
            bugs.BackgroundImage = Properties.Resources.bugs;
            bugs.BackgroundImageLayout = ImageLayout.Stretch;
            rayray.BackgroundImage = Properties.Resources.ray_ray_kazım;
            rayray.BackgroundImageLayout=ImageLayout.Stretch;
            ravecat.BackgroundImage = Properties.Resources.rave_cat;
            ravecat.BackgroundImageLayout = ImageLayout.Stretch;
            dio.BackgroundImage = Properties.Resources.dio;
            dio.BackgroundImageLayout = ImageLayout.Stretch;
            roblox.BackgroundImage=Properties.Resources.roblox;
            roblox.BackgroundImageLayout = ImageLayout.Stretch;
            yirmi1.BackgroundImage = Properties.Resources._21;
            yirmi1.BackgroundImageLayout = ImageLayout.Stretch;
            shaq.BackgroundImage = Properties.Resources._7180fb8b9c8a708db23f2b3b775fb6a6__secret_meme_fresh_memes;
            shaq.BackgroundImageLayout = ImageLayout.Stretch;
            amogus.BackgroundImage = Properties.Resources.amogus;
            amogus.BackgroundImageLayout= ImageLayout.Stretch;
            euro.BackgroundImage = Properties.Resources.euro;
           euro.BackgroundImageLayout= ImageLayout.Stretch;
            mayonez.BackgroundImage = Properties.Resources.mayonnaise;
            mayonez.BackgroundImageLayout = ImageLayout.Stretch;
            moai.BackgroundImage = Properties.Resources.moai;  
        moai.BackgroundImageLayout= ImageLayout.Stretch;
            virus.BackgroundImage = Properties.Resources.virus;
              virus.BackgroundImageLayout= ImageLayout.Stretch;
            anya.BackgroundImage = Properties.Resources.waku_waku;
            anya.BackgroundImageLayout= ImageLayout.Stretch;
           // Dur.BackgroundImage = Properties.Resources.stop;
            //Dur.BackgroundImageLayout= ImageLayout.Stretch;
            #endregion

        }

        private void button4_Click(object sender, EventArgs e)
        {
            secilenResim.BackgroundImage = Properties.Resources.bugs;
            secilenResim.BackgroundImageLayout = ImageLayout.Stretch;
            Sesci.SoundLocation = "scream.wav";
            Sesci.Play();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            secilenResim.BackgroundImage = Properties.Resources.sovietKedi;
            secilenResim.BackgroundImageLayout = ImageLayout.Stretch;
            Sesci.SoundLocation = "ssmarch.wav";
            Sesci.Play();

        }

        private void mep_Click(object sender, EventArgs e)
        {
            secilenResim.BackgroundImage = Properties.Resources.meep_meep;
            secilenResim.BackgroundImageLayout = ImageLayout.Stretch;
            Sesci.SoundLocation = "noot.wav";
            Sesci.Play();
        }

        private void shrek_Click(object sender, EventArgs e)
        {
            secilenResim.BackgroundImage = Properties.Resources.somebodya;
            secilenResim.BackgroundImageLayout = ImageLayout.Stretch;
            Sesci.SoundLocation = "some.wav";
            Sesci.Play();
        }

        private void rayray_Click(object sender, EventArgs e)
        {
            secilenResim.BackgroundImage = Properties.Resources.ray_ray_kazım;
            secilenResim.BackgroundImageLayout = ImageLayout.Stretch;
            Sesci.SoundLocation = "ray.wav";
            Sesci.Play();
        }

        private void ravecat_Click(object sender, EventArgs e)
        {
            secilenResim.BackgroundImage = Properties.Resources.rave_cat;
            secilenResim.BackgroundImageLayout = ImageLayout.Stretch;
            Sesci.SoundLocation = "caramellla.wav";
            Sesci.Play();
        }

        private void dio_Click(object sender, EventArgs e)
        {
            secilenResim.BackgroundImage = Properties.Resources.dio;
            secilenResim.BackgroundImageLayout = ImageLayout.Stretch;
            Sesci.SoundLocation = "zaward.wav";
            Sesci.Play();
        }

        private void roblox_Click(object sender, EventArgs e)
        {
            secilenResim.BackgroundImage = Properties.Resources.roblox;
            secilenResim.BackgroundImageLayout = ImageLayout.Stretch;
            Sesci.SoundLocation = "roblox.wav";
            Sesci.Play();
        }

        private void yirmi1_Click(object sender, EventArgs e)
        {
            secilenResim.BackgroundImage = Properties.Resources._21;
            secilenResim.BackgroundImageLayout = ImageLayout.Stretch;
            Sesci.SoundLocation = "a21.wav";
            Sesci.Play();
        }

        private void shaq_Click(object sender, EventArgs e)
        {
            secilenResim.BackgroundImage = Properties.Resources._7180fb8b9c8a708db23f2b3b775fb6a6__secret_meme_fresh_memes;
            secilenResim.BackgroundImageLayout = ImageLayout.Stretch;
            Sesci.SoundLocation = "shaq.wav";
            Sesci.Play();
        }

        private void amogus_Click(object sender, EventArgs e)
        {
            secilenResim.BackgroundImage = Properties.Resources.amogus;
            secilenResim.BackgroundImageLayout = ImageLayout.Stretch;
            Sesci.SoundLocation = "amogus.wav";
            Sesci.Play();
        }

        private void euro_Click(object sender, EventArgs e)
        {
            secilenResim.BackgroundImage = Properties.Resources.euro;
            secilenResim.BackgroundImageLayout = ImageLayout.Stretch;
            Sesci.SoundLocation = "euro.wav";
            Sesci.Play();
        }

        private void mayonez_Click(object sender, EventArgs e)
        {
            secilenResim.BackgroundImage = Properties.Resources.mayonnaise;
            secilenResim.BackgroundImageLayout = ImageLayout.Stretch;
            Sesci.SoundLocation = "mayonez.wav";
            Sesci.Play();
        }

        private void moai_Click(object sender, EventArgs e)
        {
            secilenResim.BackgroundImage = Properties.Resources.moai;
            secilenResim.BackgroundImageLayout = ImageLayout.Stretch;
            Sesci.SoundLocation = "moai.wav";
            Sesci.Play();
        }

        private void virus_Click(object sender, EventArgs e)
        {
            secilenResim.BackgroundImage = Properties.Resources.virus;
            secilenResim.BackgroundImageLayout = ImageLayout.Stretch;
            Sesci.SoundLocation = "virus.wav";
            Sesci.Play();
        }

        private void anya_Click(object sender, EventArgs e)
        {
            secilenResim.BackgroundImage = Properties.Resources.waku_waku;
            secilenResim.BackgroundImageLayout = ImageLayout.Stretch;
            Sesci.SoundLocation = "waku.wav";
            Sesci.Play();
        }

       private void secilenResim_Click(object sender,EventArgs e)
        {

        }

        private void Dur_Click(object sender, EventArgs e)
        {  
            Sesci.Stop();
        }

        private void ravecat_MouseHover(object sender, EventArgs e)
        {
            
        }
    }
}
