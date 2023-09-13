
namespace PokemonUsuario
{
    partial class SeleccionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SeleccionForm));
            this.bunifuMensaje = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panelInicio = new System.Windows.Forms.Panel();
            this.buttonClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.labelPersonaje = new System.Windows.Forms.Label();
            this.buttonCharizard = new Bunifu.Framework.UI.BunifuThinButton2();
            this.buttonTreecko = new Bunifu.Framework.UI.BunifuThinButton2();
            this.buttonPikachu = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuImageButton4 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton3 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panelInicio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuMensaje
            // 
            this.bunifuMensaje.AutoSize = true;
            this.bunifuMensaje.BackColor = System.Drawing.Color.Transparent;
            this.bunifuMensaje.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bunifuMensaje.Font = new System.Drawing.Font("Papyrus", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuMensaje.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bunifuMensaje.Location = new System.Drawing.Point(181, 158);
            this.bunifuMensaje.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bunifuMensaje.Name = "bunifuMensaje";
            this.bunifuMensaje.Size = new System.Drawing.Size(606, 64);
            this.bunifuMensaje.TabIndex = 10;
            this.bunifuMensaje.Text = "Seleccione a su primer pokemon";
            // 
            // panelInicio
            // 
            this.panelInicio.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelInicio.Controls.Add(this.buttonClose);
            this.panelInicio.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelInicio.Location = new System.Drawing.Point(0, 0);
            this.panelInicio.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.panelInicio.Name = "panelInicio";
            this.panelInicio.Size = new System.Drawing.Size(974, 40);
            this.panelInicio.TabIndex = 11;
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.Transparent;
            this.buttonClose.Image = ((System.Drawing.Image)(resources.GetObject("buttonClose.Image")));
            this.buttonClose.ImageActive = null;
            this.buttonClose.Location = new System.Drawing.Point(937, 0);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(35, 40);
            this.buttonClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.buttonClose.TabIndex = 1;
            this.buttonClose.TabStop = false;
            this.buttonClose.Zoom = 10;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // labelPersonaje
            // 
            this.labelPersonaje.AutoSize = true;
            this.labelPersonaje.Font = new System.Drawing.Font("Papyrus", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPersonaje.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelPersonaje.Location = new System.Drawing.Point(464, 97);
            this.labelPersonaje.Name = "labelPersonaje";
            this.labelPersonaje.Size = new System.Drawing.Size(0, 38);
            this.labelPersonaje.TabIndex = 17;
            this.labelPersonaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonCharizard
            // 
            this.buttonCharizard.ActiveBorderThickness = 1;
            this.buttonCharizard.ActiveCornerRadius = 20;
            this.buttonCharizard.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.buttonCharizard.ActiveForecolor = System.Drawing.Color.White;
            this.buttonCharizard.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.buttonCharizard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.buttonCharizard.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonCharizard.BackgroundImage")));
            this.buttonCharizard.ButtonText = "Seleccionar";
            this.buttonCharizard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCharizard.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCharizard.ForeColor = System.Drawing.Color.SeaGreen;
            this.buttonCharizard.IdleBorderThickness = 1;
            this.buttonCharizard.IdleCornerRadius = 4;
            this.buttonCharizard.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.buttonCharizard.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.buttonCharizard.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.buttonCharizard.Location = new System.Drawing.Point(654, 501);
            this.buttonCharizard.Margin = new System.Windows.Forms.Padding(5);
            this.buttonCharizard.Name = "buttonCharizard";
            this.buttonCharizard.Size = new System.Drawing.Size(181, 67);
            this.buttonCharizard.TabIndex = 23;
            this.buttonCharizard.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonCharizard.Click += new System.EventHandler(this.buttonCharizard_Click);
            // 
            // buttonTreecko
            // 
            this.buttonTreecko.ActiveBorderThickness = 1;
            this.buttonTreecko.ActiveCornerRadius = 20;
            this.buttonTreecko.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.buttonTreecko.ActiveForecolor = System.Drawing.Color.White;
            this.buttonTreecko.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.buttonTreecko.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.buttonTreecko.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonTreecko.BackgroundImage")));
            this.buttonTreecko.ButtonText = "Seleccionar";
            this.buttonTreecko.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonTreecko.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTreecko.ForeColor = System.Drawing.Color.SeaGreen;
            this.buttonTreecko.IdleBorderThickness = 1;
            this.buttonTreecko.IdleCornerRadius = 4;
            this.buttonTreecko.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.buttonTreecko.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.buttonTreecko.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.buttonTreecko.Location = new System.Drawing.Point(375, 501);
            this.buttonTreecko.Margin = new System.Windows.Forms.Padding(5);
            this.buttonTreecko.Name = "buttonTreecko";
            this.buttonTreecko.Size = new System.Drawing.Size(181, 67);
            this.buttonTreecko.TabIndex = 22;
            this.buttonTreecko.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonTreecko.Click += new System.EventHandler(this.buttonTreecko_Click);
            // 
            // buttonPikachu
            // 
            this.buttonPikachu.ActiveBorderThickness = 1;
            this.buttonPikachu.ActiveCornerRadius = 20;
            this.buttonPikachu.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.buttonPikachu.ActiveForecolor = System.Drawing.Color.White;
            this.buttonPikachu.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.buttonPikachu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.buttonPikachu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonPikachu.BackgroundImage")));
            this.buttonPikachu.ButtonText = "Seleccionar";
            this.buttonPikachu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPikachu.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPikachu.ForeColor = System.Drawing.Color.SeaGreen;
            this.buttonPikachu.IdleBorderThickness = 1;
            this.buttonPikachu.IdleCornerRadius = 4;
            this.buttonPikachu.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.buttonPikachu.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.buttonPikachu.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.buttonPikachu.Location = new System.Drawing.Point(67, 501);
            this.buttonPikachu.Margin = new System.Windows.Forms.Padding(5);
            this.buttonPikachu.Name = "buttonPikachu";
            this.buttonPikachu.Size = new System.Drawing.Size(181, 67);
            this.buttonPikachu.TabIndex = 21;
            this.buttonPikachu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonPikachu.Click += new System.EventHandler(this.buttonPikachu_Click);
            // 
            // bunifuImageButton4
            // 
            this.bunifuImageButton4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton4.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton4.Image")));
            this.bunifuImageButton4.ImageActive = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton4.ImageActive")));
            this.bunifuImageButton4.Location = new System.Drawing.Point(654, 279);
            this.bunifuImageButton4.Name = "bunifuImageButton4";
            this.bunifuImageButton4.Size = new System.Drawing.Size(202, 200);
            this.bunifuImageButton4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton4.TabIndex = 20;
            this.bunifuImageButton4.TabStop = false;
            this.bunifuImageButton4.Zoom = 10;
            // 
            // bunifuImageButton3
            // 
            this.bunifuImageButton3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton3.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton3.Image")));
            this.bunifuImageButton3.ImageActive = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton3.ImageActive")));
            this.bunifuImageButton3.Location = new System.Drawing.Point(364, 279);
            this.bunifuImageButton3.Name = "bunifuImageButton3";
            this.bunifuImageButton3.Size = new System.Drawing.Size(202, 200);
            this.bunifuImageButton3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton3.TabIndex = 19;
            this.bunifuImageButton3.TabStop = false;
            this.bunifuImageButton3.Zoom = 10;
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.Image")));
            this.bunifuImageButton2.ImageActive = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.ImageActive")));
            this.bunifuImageButton2.Location = new System.Drawing.Point(57, 279);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(202, 200);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 18;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 10;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this;
            // 
            // SeleccionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.ClientSize = new System.Drawing.Size(974, 746);
            this.Controls.Add(this.buttonCharizard);
            this.Controls.Add(this.buttonTreecko);
            this.Controls.Add(this.buttonPikachu);
            this.Controls.Add(this.bunifuImageButton4);
            this.Controls.Add(this.bunifuImageButton3);
            this.Controls.Add(this.bunifuImageButton2);
            this.Controls.Add(this.labelPersonaje);
            this.Controls.Add(this.panelInicio);
            this.Controls.Add(this.bunifuMensaje);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SeleccionForm";
            this.Text = "SeleccionForm";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelInicio_MouseMove);
            this.panelInicio.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.buttonClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomLabel bunifuMensaje;
        private System.Windows.Forms.Panel panelInicio;
        private Bunifu.Framework.UI.BunifuImageButton buttonClose;
        private System.Windows.Forms.Label labelPersonaje;
        private Bunifu.Framework.UI.BunifuThinButton2 buttonCharizard;
        private Bunifu.Framework.UI.BunifuThinButton2 buttonTreecko;
        private Bunifu.Framework.UI.BunifuThinButton2 buttonPikachu;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton4;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton3;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}