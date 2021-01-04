namespace RocketModUploader
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLineTextBox1 = new Guna.UI.WinForms.GunaLineTextBox();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLineTextBox2 = new Guna.UI.WinForms.GunaLineTextBox();
            this.gunaGradientButton1 = new Guna.UI.WinForms.GunaGradientButton();
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.gunaGradientButton2 = new Guna.UI.WinForms.GunaGradientButton();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLineTextBox3 = new Guna.UI.WinForms.GunaLineTextBox();
            this.gunaGradientButton4 = new Guna.UI.WinForms.GunaGradientButton();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gunaLabel1.Location = new System.Drawing.Point(12, 9);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(278, 28);
            this.gunaLabel1.TabIndex = 0;
            this.gunaLabel1.Text = "Eklenecek Eklentinin Adresi:";
            this.gunaLabel1.Click += new System.EventHandler(this.gunaLabel1_Click_1);
            // 
            // gunaLineTextBox1
            // 
            this.gunaLineTextBox1.Animated = true;
            this.gunaLineTextBox1.BackColor = System.Drawing.SystemColors.Control;
            this.gunaLineTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaLineTextBox1.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaLineTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLineTextBox1.LineColor = System.Drawing.Color.Blue;
            this.gunaLineTextBox1.Location = new System.Drawing.Point(293, 11);
            this.gunaLineTextBox1.Name = "gunaLineTextBox1";
            this.gunaLineTextBox1.PasswordChar = '\0';
            this.gunaLineTextBox1.SelectedText = "";
            this.gunaLineTextBox1.Size = new System.Drawing.Size(457, 26);
            this.gunaLineTextBox1.TabIndex = 1;
            this.gunaLineTextBox1.Text = "Eklenti Seç Butonuna Tıklayın";
            this.gunaLineTextBox1.TextChanged += new System.EventHandler(this.gunaLineTextBox1_TextChanged);
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gunaLabel2.Location = new System.Drawing.Point(12, 62);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(174, 28);
            this.gunaLabel2.TabIndex = 0;
            this.gunaLabel2.Text = "Eklenecek Lisans:";
            this.gunaLabel2.Click += new System.EventHandler(this.gunaLabel1_Click);
            // 
            // gunaLineTextBox2
            // 
            this.gunaLineTextBox2.Animated = true;
            this.gunaLineTextBox2.BackColor = System.Drawing.SystemColors.Control;
            this.gunaLineTextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaLineTextBox2.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaLineTextBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLineTextBox2.LineColor = System.Drawing.Color.Blue;
            this.gunaLineTextBox2.Location = new System.Drawing.Point(192, 62);
            this.gunaLineTextBox2.Name = "gunaLineTextBox2";
            this.gunaLineTextBox2.PasswordChar = '\0';
            this.gunaLineTextBox2.SelectedText = "";
            this.gunaLineTextBox2.Size = new System.Drawing.Size(457, 26);
            this.gunaLineTextBox2.TabIndex = 1;
            this.gunaLineTextBox2.TextChanged += new System.EventHandler(this.gunaLineTextBox2_TextChanged);
            // 
            // gunaGradientButton1
            // 
            this.gunaGradientButton1.AnimationHoverSpeed = 0.07F;
            this.gunaGradientButton1.AnimationSpeed = 0.03F;
            this.gunaGradientButton1.BaseColor1 = System.Drawing.Color.SlateBlue;
            this.gunaGradientButton1.BaseColor2 = System.Drawing.Color.Fuchsia;
            this.gunaGradientButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaGradientButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaGradientButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaGradientButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaGradientButton1.ForeColor = System.Drawing.Color.White;
            this.gunaGradientButton1.Image = ((System.Drawing.Image)(resources.GetObject("gunaGradientButton1.Image")));
            this.gunaGradientButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaGradientButton1.Location = new System.Drawing.Point(17, 110);
            this.gunaGradientButton1.Name = "gunaGradientButton1";
            this.gunaGradientButton1.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.gunaGradientButton1.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.gunaGradientButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaGradientButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaGradientButton1.OnHoverImage = null;
            this.gunaGradientButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaGradientButton1.Size = new System.Drawing.Size(160, 42);
            this.gunaGradientButton1.TabIndex = 2;
            this.gunaGradientButton1.Text = "Lisans Ekle";
            this.gunaGradientButton1.Click += new System.EventHandler(this.gunaGradientButton1_Click_1);
            // 
            // gunaButton1
            // 
            this.gunaButton1.AnimationHoverSpeed = 0.07F;
            this.gunaButton1.AnimationSpeed = 0.03F;
            this.gunaButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaButton1.ForeColor = System.Drawing.Color.White;
            this.gunaButton1.Image = ((System.Drawing.Image)(resources.GetObject("gunaButton1.Image")));
            this.gunaButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton1.Location = new System.Drawing.Point(628, 234);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Size = new System.Drawing.Size(160, 42);
            this.gunaButton1.TabIndex = 3;
            this.gunaButton1.Text = "Kapat";
            this.gunaButton1.Click += new System.EventHandler(this.gunaButton1_Click);
            // 
            // gunaGradientButton2
            // 
            this.gunaGradientButton2.AnimationHoverSpeed = 0.07F;
            this.gunaGradientButton2.AnimationSpeed = 0.03F;
            this.gunaGradientButton2.BaseColor1 = System.Drawing.Color.SlateBlue;
            this.gunaGradientButton2.BaseColor2 = System.Drawing.Color.Fuchsia;
            this.gunaGradientButton2.BorderColor = System.Drawing.Color.Black;
            this.gunaGradientButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaGradientButton2.FocusedColor = System.Drawing.Color.Empty;
            this.gunaGradientButton2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaGradientButton2.ForeColor = System.Drawing.Color.White;
            this.gunaGradientButton2.Image = ((System.Drawing.Image)(resources.GetObject("gunaGradientButton2.Image")));
            this.gunaGradientButton2.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaGradientButton2.Location = new System.Drawing.Point(192, 110);
            this.gunaGradientButton2.Name = "gunaGradientButton2";
            this.gunaGradientButton2.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.gunaGradientButton2.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.gunaGradientButton2.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaGradientButton2.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaGradientButton2.OnHoverImage = null;
            this.gunaGradientButton2.OnPressedColor = System.Drawing.Color.Black;
            this.gunaGradientButton2.Size = new System.Drawing.Size(160, 42);
            this.gunaGradientButton2.TabIndex = 2;
            this.gunaGradientButton2.Text = "Eklenti Seç";
            this.gunaGradientButton2.Click += new System.EventHandler(this.gunaGradientButton2_Click);
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel3.Location = new System.Drawing.Point(403, 99);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(385, 15);
            this.gunaLabel3.TabIndex = 4;
            this.gunaLabel3.Text = "Eklenti seç butonu, lisansın hangi eklentiye ait olduğunu bulmak içindir.";
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gunaLabel4.Location = new System.Drawing.Point(12, 187);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(247, 28);
            this.gunaLabel4.TabIndex = 0;
            this.gunaLabel4.Text = "Silmek İstediğiniz Lisans:";
            this.gunaLabel4.Click += new System.EventHandler(this.gunaLabel1_Click_1);
            // 
            // gunaLineTextBox3
            // 
            this.gunaLineTextBox3.Animated = true;
            this.gunaLineTextBox3.BackColor = System.Drawing.SystemColors.Control;
            this.gunaLineTextBox3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaLineTextBox3.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaLineTextBox3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLineTextBox3.LineColor = System.Drawing.Color.Blue;
            this.gunaLineTextBox3.Location = new System.Drawing.Point(265, 189);
            this.gunaLineTextBox3.Name = "gunaLineTextBox3";
            this.gunaLineTextBox3.PasswordChar = '\0';
            this.gunaLineTextBox3.SelectedText = "";
            this.gunaLineTextBox3.Size = new System.Drawing.Size(457, 26);
            this.gunaLineTextBox3.TabIndex = 1;
            this.gunaLineTextBox3.TextChanged += new System.EventHandler(this.gunaLineTextBox1_TextChanged);
            // 
            // gunaGradientButton4
            // 
            this.gunaGradientButton4.AnimationHoverSpeed = 0.07F;
            this.gunaGradientButton4.AnimationSpeed = 0.03F;
            this.gunaGradientButton4.BaseColor1 = System.Drawing.Color.SlateBlue;
            this.gunaGradientButton4.BaseColor2 = System.Drawing.Color.Fuchsia;
            this.gunaGradientButton4.BorderColor = System.Drawing.Color.Black;
            this.gunaGradientButton4.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaGradientButton4.FocusedColor = System.Drawing.Color.Empty;
            this.gunaGradientButton4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaGradientButton4.ForeColor = System.Drawing.Color.White;
            this.gunaGradientButton4.Image = ((System.Drawing.Image)(resources.GetObject("gunaGradientButton4.Image")));
            this.gunaGradientButton4.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaGradientButton4.Location = new System.Drawing.Point(17, 234);
            this.gunaGradientButton4.Name = "gunaGradientButton4";
            this.gunaGradientButton4.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.gunaGradientButton4.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.gunaGradientButton4.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaGradientButton4.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaGradientButton4.OnHoverImage = null;
            this.gunaGradientButton4.OnPressedColor = System.Drawing.Color.Black;
            this.gunaGradientButton4.Size = new System.Drawing.Size(160, 42);
            this.gunaGradientButton4.TabIndex = 2;
            this.gunaGradientButton4.Text = "Lisans Sil";
            this.gunaGradientButton4.Click += new System.EventHandler(this.gunaGradientButton4_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = null;
            this.bunifuDragControl1.Vertical = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 290);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.gunaButton1);
            this.Controls.Add(this.gunaGradientButton2);
            this.Controls.Add(this.gunaGradientButton4);
            this.Controls.Add(this.gunaGradientButton1);
            this.Controls.Add(this.gunaLineTextBox2);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.gunaLineTextBox3);
            this.Controls.Add(this.gunaLineTextBox1);
            this.Controls.Add(this.gunaLabel4);
            this.Controls.Add(this.gunaLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaButton gunaButton1;
        private Guna.UI.WinForms.GunaGradientButton gunaGradientButton1;
        private Guna.UI.WinForms.GunaLineTextBox gunaLineTextBox2;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLineTextBox gunaLineTextBox1;
        private Guna.UI.WinForms.GunaGradientButton gunaGradientButton2;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaGradientButton gunaGradientButton4;
        private Guna.UI.WinForms.GunaLineTextBox gunaLineTextBox3;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
    }
}

