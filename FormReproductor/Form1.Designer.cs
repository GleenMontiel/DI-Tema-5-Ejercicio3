
namespace FormReproductor
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnBuscarDirectorios = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.reproductor1 = new Tema5Ejercicio3.Reproductor();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(81, 172);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(210, 185);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnBuscarDirectorios
            // 
            this.btnBuscarDirectorios.Location = new System.Drawing.Point(81, 46);
            this.btnBuscarDirectorios.Name = "btnBuscarDirectorios";
            this.btnBuscarDirectorios.Size = new System.Drawing.Size(130, 55);
            this.btnBuscarDirectorios.TabIndex = 2;
            this.btnBuscarDirectorios.Text = "Buscar";
            this.btnBuscarDirectorios.UseVisualStyleBackColor = true;
            this.btnBuscarDirectorios.Click += new System.EventHandler(this.btnBuscarDirectorios_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // reproductor1
            // 
            this.reproductor1.Location = new System.Drawing.Point(516, 12);
            this.reproductor1.Name = "reproductor1";
            this.reproductor1.Size = new System.Drawing.Size(272, 195);
            this.reproductor1.TabIndex = 0;
            this.reproductor1.XX = 0;
            this.reproductor1.YY = 0;
            this.reproductor1.DesbordaTiempo += new System.EventHandler(this.reproductor1_DesbordaTiempo);
            this.reproductor1.PlayPause += new System.EventHandler(this.reproductor1_PlayPause);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBuscarDirectorios);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.reproductor1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Tema5Ejercicio3.Reproductor reproductor1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnBuscarDirectorios;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}

