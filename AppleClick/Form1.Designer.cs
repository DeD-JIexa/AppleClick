namespace AppleClick
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.numbers = new System.Windows.Forms.Label();
            this.apples = new System.Windows.Forms.Label();
            this.Click1 = new System.Windows.Forms.PictureBox();
            this.Click2 = new System.Windows.Forms.PictureBox();
            this.Trade = new System.Windows.Forms.Button();
            this.Forochka = new System.Windows.Forms.Button();
            this.Oleg = new System.Windows.Forms.PictureBox();
            this.Prank = new System.Windows.Forms.Button();
            this.Gop = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Click1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Click2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Oleg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gop)).BeginInit();
            this.SuspendLayout();
            // 
            // numbers
            // 
            this.numbers.AutoSize = true;
            this.numbers.Location = new System.Drawing.Point(705, 9);
            this.numbers.Name = "numbers";
            this.numbers.Size = new System.Drawing.Size(51, 13);
            this.numbers.TabIndex = 0;
            this.numbers.Text = "Монет: 0";
            // 
            // apples
            // 
            this.apples.AutoSize = true;
            this.apples.Location = new System.Drawing.Point(705, 22);
            this.apples.Name = "apples";
            this.apples.Size = new System.Drawing.Size(72, 13);
            this.apples.TabIndex = 1;
            this.apples.Text = "Загубонов: 0";
            // 
            // Click1
            // 
            this.Click1.Image = ((System.Drawing.Image)(resources.GetObject("Click1.Image")));
            this.Click1.Location = new System.Drawing.Point(297, 96);
            this.Click1.Name = "Click1";
            this.Click1.Size = new System.Drawing.Size(195, 201);
            this.Click1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Click1.TabIndex = 2;
            this.Click1.TabStop = false;
            this.Click1.Click += new System.EventHandler(this.Click1_Click);
            // 
            // Click2
            // 
            this.Click2.Image = ((System.Drawing.Image)(resources.GetObject("Click2.Image")));
            this.Click2.Location = new System.Drawing.Point(297, 96);
            this.Click2.Name = "Click2";
            this.Click2.Size = new System.Drawing.Size(194, 200);
            this.Click2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Click2.TabIndex = 3;
            this.Click2.TabStop = false;
            this.Click2.Visible = false;
            this.Click2.Click += new System.EventHandler(this.Click2_Click);
            // 
            // Trade
            // 
            this.Trade.Location = new System.Drawing.Point(12, 12);
            this.Trade.Name = "Trade";
            this.Trade.Size = new System.Drawing.Size(94, 23);
            this.Trade.TabIndex = 4;
            this.Trade.Text = "Купить Загубон";
            this.Trade.UseVisualStyleBackColor = true;
            this.Trade.Click += new System.EventHandler(this.Trade_Click);
            // 
            // Forochka
            // 
            this.Forochka.Location = new System.Drawing.Point(12, 65);
            this.Forochka.Name = "Forochka";
            this.Forochka.Size = new System.Drawing.Size(94, 25);
            this.Forochka.TabIndex = 5;
            this.Forochka.Text = "Сделать фото";
            this.Forochka.UseVisualStyleBackColor = true;
            this.Forochka.Click += new System.EventHandler(this.Forochka_Click);
            // 
            // Oleg
            // 
            this.Oleg.Image = ((System.Drawing.Image)(resources.GetObject("Oleg.Image")));
            this.Oleg.Location = new System.Drawing.Point(12, 96);
            this.Oleg.Name = "Oleg";
            this.Oleg.Size = new System.Drawing.Size(207, 200);
            this.Oleg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Oleg.TabIndex = 6;
            this.Oleg.TabStop = false;
            this.Oleg.Visible = false;
            // 
            // Prank
            // 
            this.Prank.Location = new System.Drawing.Point(12, 36);
            this.Prank.Name = "Prank";
            this.Prank.Size = new System.Drawing.Size(94, 23);
            this.Prank.TabIndex = 7;
            this.Prank.Text = "Крутой?";
            this.Prank.UseVisualStyleBackColor = true;
            this.Prank.Click += new System.EventHandler(this.Prank_Click);
            // 
            // Gop
            // 
            this.Gop.Image = ((System.Drawing.Image)(resources.GetObject("Gop.Image")));
            this.Gop.Location = new System.Drawing.Point(3, 1);
            this.Gop.Name = "Gop";
            this.Gop.Size = new System.Drawing.Size(794, 445);
            this.Gop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Gop.TabIndex = 8;
            this.Gop.TabStop = false;
            this.Gop.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Gop);
            this.Controls.Add(this.Prank);
            this.Controls.Add(this.Oleg);
            this.Controls.Add(this.Forochka);
            this.Controls.Add(this.Trade);
            this.Controls.Add(this.Click2);
            this.Controls.Add(this.Click1);
            this.Controls.Add(this.apples);
            this.Controls.Add(this.numbers);
            this.Name = "Form1";
            this.Text = "label";
            ((System.ComponentModel.ISupportInitialize)(this.Click1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Click2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Oleg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label numbers;
        private System.Windows.Forms.Label apples;
        private System.Windows.Forms.PictureBox Click1;
        private System.Windows.Forms.PictureBox Click2;
        private System.Windows.Forms.Button Trade;
        private System.Windows.Forms.Button Forochka;
        private System.Windows.Forms.PictureBox Oleg;
        private System.Windows.Forms.Button Prank;
        private System.Windows.Forms.PictureBox Gop;
    }
}

