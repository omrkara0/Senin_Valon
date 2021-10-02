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




namespace Senin_Valon


{
    
    public partial class pencere : Form

    {
        int saniye = 45;
        public pencere()
        {
            InitializeComponent();
            countdown.Interval = 1000;
        }



        private void pencere_Load(object sender, EventArgs e)
        {

        }




        private void spike_Click(object sender, EventArgs e)
        {
            

            countdown.Enabled = true;
            
            
            SoundPlayer splayer = new SoundPlayer(Application.StartupPath + "/sounds/plantedtr.wav");
            splayer.Play();
            
           

            
            
            

        }
        private void spike_DoubleClick(object sender, EventArgs e)

        {
            countdown.Enabled = false;
            saniye = 45;
            label1.Text = "45";
            progressBar1.Value = 0;
            SoundPlayer splayer = new SoundPlayer(Application.StartupPath + "/sounds/imha.wav");
            splayer.Play();
        }
        

        
        

        private void countdown_Tick(object sender, EventArgs e)
        {
            progressBar1.Step = 1;
            progressBar1.PerformStep();

            if (progressBar1.Value == 46)
            {
                progressBar1.Value = 0;
            }
            


            label1.Text =Convert.ToString(saniye);
            
            if (saniye == 20)
            {
                SoundPlayer splayer = new SoundPlayer(Application.StartupPath + "/sounds/sn20.wav");
                splayer.Play();


            }
            if (saniye == 10)
            {
                SoundPlayer splayer = new SoundPlayer(Application.StartupPath + "/sounds/sn10.wav");
                splayer.Play();


            }
            if (saniye == 5)
            {
                SoundPlayer splayer = new SoundPlayer(Application.StartupPath + "/sounds/sn5.wav");
                splayer.Play();


            }
            if (saniye == 0)
            {
                label1.Text = "45";
                saniye = 45;
                countdown.Enabled = false;
               
                
            }
            saniye -= 1;

        }

       
    }
}
