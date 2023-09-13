
namespace PokemonUsuario
{
    partial class ConversacionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConversacionForm));
            this.bunifuMensaje = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.buttonComenzar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelInicio = new System.Windows.Forms.Panel();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelInicio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuMensaje
            // 
            this.bunifuMensaje.AutoSize = true;
            this.bunifuMensaje.BackColor = System.Drawing.Color.Transparent;
            this.bunifuMensaje.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bunifuMensaje.Font = new System.Drawing.Font("Papyrus", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuMensaje.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bunifuMensaje.Location = new System.Drawing.Point(165, 142);
            this.bunifuMensaje.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bunifuMensaje.Name = "bunifuMensaje";
            this.bunifuMensaje.Size = new System.Drawing.Size(772, 64);
            this.bunifuMensaje.TabIndex = 14;
            this.bunifuMensaje.Text = "Presione el boton para comenzar la pelea.";
            this.bunifuMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonComenzar
            // 
            this.buttonComenzar.ActiveBorderThickness = 1;
            this.buttonComenzar.ActiveCornerRadius = 20;
            this.buttonComenzar.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.buttonComenzar.ActiveForecolor = System.Drawing.Color.WhiteSmoke;
            this.buttonComenzar.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.buttonComenzar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.buttonComenzar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonComenzar.BackgroundImage")));
            this.buttonComenzar.ButtonText = "Comenzar";
            this.buttonComenzar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonComenzar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonComenzar.ForeColor = System.Drawing.Color.SeaGreen;
            this.buttonComenzar.IdleBorderThickness = 2;
            this.buttonComenzar.IdleCornerRadius = 20;
            this.buttonComenzar.IdleFillColor = System.Drawing.Color.Transparent;
            this.buttonComenzar.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.buttonComenzar.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.buttonComenzar.Location = new System.Drawing.Point(455, 468);
            this.buttonComenzar.Margin = new System.Windows.Forms.Padding(5);
            this.buttonComenzar.Name = "buttonComenzar";
            this.buttonComenzar.Size = new System.Drawing.Size(221, 90);
            this.buttonComenzar.TabIndex = 13;
            this.buttonComenzar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonComenzar.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(861, 239);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(133, 274);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-41, 190);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(384, 368);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // panelInicio
            // 
            this.panelInicio.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelInicio.Controls.Add(this.bunifuImageButton1);
            this.panelInicio.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelInicio.Location = new System.Drawing.Point(0, 0);
            this.panelInicio.Margin = new System.Windows.Forms.Padding(4);
            this.panelInicio.Name = "panelInicio";
            this.panelInicio.Size = new System.Drawing.Size(1058, 40);
            this.panelInicio.TabIndex = 15;
            this.panelInicio.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelInicio_MouseMove);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(1014, 0);
            this.bunifuImageButton1.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(41, 34);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 2;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this;
            // 
            // ConversacionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.ClientSize = new System.Drawing.Size(1058, 683);
            this.Controls.Add(this.panelInicio);
            this.Controls.Add(this.bunifuMensaje);
            this.Controls.Add(this.buttonComenzar);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConversacionForm";
            this.Text = "ConversacionForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelInicio.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomLabel bunifuMensaje;
        private Bunifu.Framework.UI.BunifuThinButton2 buttonComenzar;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelInicio;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}