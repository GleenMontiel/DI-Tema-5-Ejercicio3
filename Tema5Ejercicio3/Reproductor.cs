using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tema5Ejercicio3
{
    [
       DefaultProperty("Reproductor"),
       DefaultEvent("Load")
   ]
    public partial class Reproductor : UserControl
    {
        bool Running;
        public Reproductor()
        {
            InitializeComponent();
            lbl.Text = "00:00";
            btnPlayPause.Image = Properties.Resources.play_button;
            xx = 0;
            yy = 0;
            Running = false;
        }

        private int xx;
        [Category("Ejercicio3")]
        [Description("Propiedad Minutos")]
        public int XX
        {
            set
            {
                if (value > 99)
                {
                    xx = 0;
                    DesbordaTiempo?.Invoke(this, EventArgs.Empty);

                }
                else
                {
                    xx = value;
                }
                lbl.Text = string.Format("{0,2:00}:{1,2:00}", xx, yy);
            }
            get
            {
                return xx;
            }
        }

        private int yy;
        [Category("Ejercicio3")]
        [Description("Propiedad Minutos")]
        public int YY
        {
            set
            {
                if (value > 59)
                {
                    yy = value % 60;

                }
                else
                {
                    yy = value;
                }
                lbl.Text = string.Format("{0,2:00}:{1,2:00}", xx, yy);
            }
            get
            {
                return yy;
            }
        }

        [Category("Ejercicio3")]
        [Description("Se lanza cada vez que se YY supera 59")]
        public event System.EventHandler DesbordaTiempo;
        [Category("Ejercicio3")]
        [Description("Se lanza cada vez que se pulsa el boton")]
        public event System.EventHandler PlayPause;


        private void btnPlayPause_Click_1(object sender, EventArgs e)
        {
            this.OnClick(e);
            Running = !Running;
            btnPlayPause.Image = Running ? Properties.Resources.pause_button : Properties.Resources.play_button;
            PlayPause?.Invoke(this, EventArgs.Empty);

        }
    }
}
