namespace ReproductorMP
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Reproductor = new AxWMPLib.AxWindowsMediaPlayer();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.macTrackBar1 = new XComponent.SliderBar.MACTrackBar();
            this.macTrackVolumen = new XComponent.SliderBar.MACTrackBar();
            this.panel2 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPrimera = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnUltima = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnSiguiente = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAnterior = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnPlay = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAdjuntar = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.Reproductor)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Reproductor
            // 
            this.Reproductor.Enabled = true;
            this.Reproductor.Location = new System.Drawing.Point(161, 1);
            this.Reproductor.Name = "Reproductor";
            this.Reproductor.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Reproductor.OcxState")));
            this.Reproductor.Size = new System.Drawing.Size(625, 373);
            this.Reproductor.TabIndex = 0;
            this.Reproductor.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.Reproductor_PlayStateChange);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.InfoText;
            this.listBox1.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.ForeColor = System.Drawing.SystemColors.Info;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 19;
            this.listBox1.Location = new System.Drawing.Point(0, 54);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(162, 365);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // macTrackBar1
            // 
            this.macTrackBar1.BackColor = System.Drawing.Color.Black;
            this.macTrackBar1.BorderColor = System.Drawing.Color.Lime;
            this.macTrackBar1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.macTrackBar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(125)))), ((int)(((byte)(123)))));
            this.macTrackBar1.IndentHeight = 6;
            this.macTrackBar1.Location = new System.Drawing.Point(198, 3);
            this.macTrackBar1.Maximum = 10;
            this.macTrackBar1.Minimum = 0;
            this.macTrackBar1.Name = "macTrackBar1";
            this.macTrackBar1.Size = new System.Drawing.Size(551, 22);
            this.macTrackBar1.TabIndex = 11;
            this.macTrackBar1.TextTickStyle = System.Windows.Forms.TickStyle.None;
            this.macTrackBar1.TickColor = System.Drawing.Color.Lime;
            this.macTrackBar1.TickHeight = 4;
            this.macTrackBar1.TickStyle = System.Windows.Forms.TickStyle.None;
            this.macTrackBar1.TrackerColor = System.Drawing.Color.Lime;
            this.macTrackBar1.TrackerSize = new System.Drawing.Size(10, 10);
            this.macTrackBar1.TrackLineColor = System.Drawing.Color.Silver;
            this.macTrackBar1.TrackLineHeight = 7;
            this.macTrackBar1.TrackLineSelectedColor = System.Drawing.Color.Silver;
            this.macTrackBar1.Value = 0;
            // 
            // macTrackVolumen
            // 
            this.macTrackVolumen.BackColor = System.Drawing.Color.Transparent;
            this.macTrackVolumen.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.macTrackVolumen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.macTrackVolumen.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.macTrackVolumen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(125)))), ((int)(((byte)(123)))));
            this.macTrackVolumen.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.macTrackVolumen.IndentHeight = 6;
            this.macTrackVolumen.IndentWidth = 2;
            this.macTrackVolumen.Location = new System.Drawing.Point(638, 46);
            this.macTrackVolumen.Maximum = 100;
            this.macTrackVolumen.Minimum = 0;
            this.macTrackVolumen.Name = "macTrackVolumen";
            this.macTrackVolumen.Size = new System.Drawing.Size(133, 29);
            this.macTrackVolumen.TabIndex = 12;
            this.macTrackVolumen.TextTickStyle = System.Windows.Forms.TickStyle.None;
            this.macTrackVolumen.TickColor = System.Drawing.Color.Lime;
            this.macTrackVolumen.TickHeight = 4;
            this.macTrackVolumen.TrackerColor = System.Drawing.Color.Black;
            this.macTrackVolumen.TrackerSize = new System.Drawing.Size(11, 12);
            this.macTrackVolumen.TrackLineColor = System.Drawing.Color.DarkGray;
            this.macTrackVolumen.TrackLineHeight = 6;
            this.macTrackVolumen.TrackLineSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(93)))), ((int)(((byte)(90)))));
            this.macTrackVolumen.Value = 0;
            this.macTrackVolumen.ValueChanged += new XComponent.SliderBar.ValueChangedHandler(this.macTrackVolumen_ValueChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.btnPrimera);
            this.panel2.Controls.Add(this.btnUltima);
            this.panel2.Controls.Add(this.btnSiguiente);
            this.panel2.Controls.Add(this.btnAnterior);
            this.panel2.Controls.Add(this.macTrackBar1);
            this.panel2.Controls.Add(this.macTrackVolumen);
            this.panel2.Controls.Add(this.btnPlay);
            this.panel2.Location = new System.Drawing.Point(0, 328);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(786, 91);
            this.panel2.TabIndex = 13;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnAdjuntar);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(162, 52);
            this.panel1.TabIndex = 14;
            // 
            // btnPrimera
            // 
            this.btnPrimera.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnPrimera.BackColor = System.Drawing.Color.Transparent;
            this.btnPrimera.BackgroundImage = global::ReproductorMP.Properties.Resources.primera;
            this.btnPrimera.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPrimera.BorderRadius = 0;
            this.btnPrimera.ButtonText = "";
            this.btnPrimera.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrimera.DisabledColor = System.Drawing.Color.DarkGray;
            this.btnPrimera.Iconcolor = System.Drawing.Color.Transparent;
            this.btnPrimera.Iconimage = null;
            this.btnPrimera.Iconimage_right = null;
            this.btnPrimera.Iconimage_right_Selected = null;
            this.btnPrimera.Iconimage_Selected = null;
            this.btnPrimera.IconMarginLeft = 0;
            this.btnPrimera.IconMarginRight = 0;
            this.btnPrimera.IconRightVisible = true;
            this.btnPrimera.IconRightZoom = 0D;
            this.btnPrimera.IconVisible = true;
            this.btnPrimera.IconZoom = 80D;
            this.btnPrimera.IsTab = false;
            this.btnPrimera.Location = new System.Drawing.Point(313, 32);
            this.btnPrimera.Name = "btnPrimera";
            this.btnPrimera.Normalcolor = System.Drawing.Color.Transparent;
            this.btnPrimera.OnHovercolor = System.Drawing.Color.Lime;
            this.btnPrimera.OnHoverTextColor = System.Drawing.Color.White;
            this.btnPrimera.selected = false;
            this.btnPrimera.Size = new System.Drawing.Size(47, 44);
            this.btnPrimera.TabIndex = 16;
            this.btnPrimera.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPrimera.Textcolor = System.Drawing.Color.White;
            this.btnPrimera.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnUltima
            // 
            this.btnUltima.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnUltima.BackColor = System.Drawing.Color.Transparent;
            this.btnUltima.BackgroundImage = global::ReproductorMP.Properties.Resources.ultima;
            this.btnUltima.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUltima.BorderRadius = 0;
            this.btnUltima.ButtonText = "";
            this.btnUltima.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUltima.DisabledColor = System.Drawing.Color.DarkGray;
            this.btnUltima.Iconcolor = System.Drawing.Color.Transparent;
            this.btnUltima.Iconimage = null;
            this.btnUltima.Iconimage_right = null;
            this.btnUltima.Iconimage_right_Selected = null;
            this.btnUltima.Iconimage_Selected = null;
            this.btnUltima.IconMarginLeft = 0;
            this.btnUltima.IconMarginRight = 0;
            this.btnUltima.IconRightVisible = true;
            this.btnUltima.IconRightZoom = 0D;
            this.btnUltima.IconVisible = true;
            this.btnUltima.IconZoom = 80D;
            this.btnUltima.IsTab = false;
            this.btnUltima.Location = new System.Drawing.Point(519, 31);
            this.btnUltima.Name = "btnUltima";
            this.btnUltima.Normalcolor = System.Drawing.Color.Transparent;
            this.btnUltima.OnHovercolor = System.Drawing.Color.Lime;
            this.btnUltima.OnHoverTextColor = System.Drawing.Color.White;
            this.btnUltima.selected = false;
            this.btnUltima.Size = new System.Drawing.Size(47, 44);
            this.btnUltima.TabIndex = 15;
            this.btnUltima.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnUltima.Textcolor = System.Drawing.Color.White;
            this.btnUltima.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSiguiente.BackColor = System.Drawing.Color.Transparent;
            this.btnSiguiente.BackgroundImage = global::ReproductorMP.Properties.Resources.siguiente;
            this.btnSiguiente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSiguiente.BorderRadius = 0;
            this.btnSiguiente.ButtonText = "";
            this.btnSiguiente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSiguiente.DisabledColor = System.Drawing.Color.DarkGray;
            this.btnSiguiente.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSiguiente.Iconimage = null;
            this.btnSiguiente.Iconimage_right = null;
            this.btnSiguiente.Iconimage_right_Selected = null;
            this.btnSiguiente.Iconimage_Selected = null;
            this.btnSiguiente.IconMarginLeft = 0;
            this.btnSiguiente.IconMarginRight = 0;
            this.btnSiguiente.IconRightVisible = true;
            this.btnSiguiente.IconRightZoom = 0D;
            this.btnSiguiente.IconVisible = true;
            this.btnSiguiente.IconZoom = 80D;
            this.btnSiguiente.IsTab = false;
            this.btnSiguiente.Location = new System.Drawing.Point(468, 32);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Normalcolor = System.Drawing.Color.Transparent;
            this.btnSiguiente.OnHovercolor = System.Drawing.Color.Lime;
            this.btnSiguiente.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSiguiente.selected = false;
            this.btnSiguiente.Size = new System.Drawing.Size(47, 44);
            this.btnSiguiente.TabIndex = 14;
            this.btnSiguiente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSiguiente.Textcolor = System.Drawing.Color.White;
            this.btnSiguiente.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnAnterior
            // 
            this.btnAnterior.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAnterior.BackColor = System.Drawing.Color.Transparent;
            this.btnAnterior.BackgroundImage = global::ReproductorMP.Properties.Resources.anterior;
            this.btnAnterior.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAnterior.BorderRadius = 0;
            this.btnAnterior.ButtonText = "";
            this.btnAnterior.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnterior.DisabledColor = System.Drawing.Color.DarkGray;
            this.btnAnterior.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAnterior.Iconimage = null;
            this.btnAnterior.Iconimage_right = null;
            this.btnAnterior.Iconimage_right_Selected = null;
            this.btnAnterior.Iconimage_Selected = null;
            this.btnAnterior.IconMarginLeft = 0;
            this.btnAnterior.IconMarginRight = 0;
            this.btnAnterior.IconRightVisible = true;
            this.btnAnterior.IconRightZoom = 0D;
            this.btnAnterior.IconVisible = true;
            this.btnAnterior.IconZoom = 80D;
            this.btnAnterior.IsTab = false;
            this.btnAnterior.Location = new System.Drawing.Point(366, 32);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Normalcolor = System.Drawing.Color.Transparent;
            this.btnAnterior.OnHovercolor = System.Drawing.Color.Lime;
            this.btnAnterior.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAnterior.selected = false;
            this.btnAnterior.Size = new System.Drawing.Size(47, 44);
            this.btnAnterior.TabIndex = 13;
            this.btnAnterior.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAnterior.Textcolor = System.Drawing.Color.White;
            this.btnAnterior.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnPlay
            // 
            this.btnPlay.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnPlay.BackColor = System.Drawing.Color.Transparent;
            this.btnPlay.BackgroundImage = global::ReproductorMP.Properties.Resources.play;
            this.btnPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPlay.BorderRadius = 0;
            this.btnPlay.ButtonText = "";
            this.btnPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlay.DisabledColor = System.Drawing.Color.DarkGray;
            this.btnPlay.Iconcolor = System.Drawing.Color.Transparent;
            this.btnPlay.Iconimage = null;
            this.btnPlay.Iconimage_right = null;
            this.btnPlay.Iconimage_right_Selected = null;
            this.btnPlay.Iconimage_Selected = null;
            this.btnPlay.IconMarginLeft = 0;
            this.btnPlay.IconMarginRight = 0;
            this.btnPlay.IconRightVisible = true;
            this.btnPlay.IconRightZoom = 0D;
            this.btnPlay.IconVisible = true;
            this.btnPlay.IconZoom = 80D;
            this.btnPlay.IsTab = false;
            this.btnPlay.Location = new System.Drawing.Point(417, 32);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Normalcolor = System.Drawing.Color.Transparent;
            this.btnPlay.OnHovercolor = System.Drawing.Color.Lime;
            this.btnPlay.OnHoverTextColor = System.Drawing.Color.White;
            this.btnPlay.selected = false;
            this.btnPlay.Size = new System.Drawing.Size(47, 44);
            this.btnPlay.TabIndex = 3;
            this.btnPlay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPlay.Textcolor = System.Drawing.Color.White;
            this.btnPlay.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnAdjuntar
            // 
            this.btnAdjuntar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnAdjuntar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAdjuntar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAdjuntar.BorderRadius = 0;
            this.btnAdjuntar.ButtonText = "";
            this.btnAdjuntar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdjuntar.DisabledColor = System.Drawing.Color.Gray;
            this.btnAdjuntar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdjuntar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAdjuntar.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAdjuntar.Iconimage")));
            this.btnAdjuntar.Iconimage_right = null;
            this.btnAdjuntar.Iconimage_right_Selected = null;
            this.btnAdjuntar.Iconimage_Selected = null;
            this.btnAdjuntar.IconMarginLeft = 0;
            this.btnAdjuntar.IconMarginRight = 0;
            this.btnAdjuntar.IconRightVisible = true;
            this.btnAdjuntar.IconRightZoom = 0D;
            this.btnAdjuntar.IconVisible = true;
            this.btnAdjuntar.IconZoom = 90D;
            this.btnAdjuntar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAdjuntar.IsTab = false;
            this.btnAdjuntar.Location = new System.Drawing.Point(53, -2);
            this.btnAdjuntar.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnAdjuntar.Name = "btnAdjuntar";
            this.btnAdjuntar.Normalcolor = System.Drawing.SystemColors.ButtonFace;
            this.btnAdjuntar.OnHovercolor = System.Drawing.Color.Lime;
            this.btnAdjuntar.OnHoverTextColor = System.Drawing.Color.Beige;
            this.btnAdjuntar.selected = false;
            this.btnAdjuntar.Size = new System.Drawing.Size(53, 52);
            this.btnAdjuntar.TabIndex = 9;
            this.btnAdjuntar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAdjuntar.Textcolor = System.Drawing.Color.White;
            this.btnAdjuntar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdjuntar.Click += new System.EventHandler(this.btnAdjuntar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(783, 418);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Reproductor);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reproductor MP3";
            ((System.ComponentModel.ISupportInitialize)(this.Reproductor)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer Reproductor;
        private System.Windows.Forms.ListBox listBox1;
        private Bunifu.Framework.UI.BunifuFlatButton btnAdjuntar;
        private XComponent.SliderBar.MACTrackBar macTrackBar1;
        private XComponent.SliderBar.MACTrackBar macTrackVolumen;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuFlatButton btnPlay;
        private Bunifu.Framework.UI.BunifuFlatButton btnAnterior;
        private Bunifu.Framework.UI.BunifuFlatButton btnSiguiente;
        private Bunifu.Framework.UI.BunifuFlatButton btnUltima;
        private Bunifu.Framework.UI.BunifuFlatButton btnPrimera;
    }
}

