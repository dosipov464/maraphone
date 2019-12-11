namespace Maraphon_Skills_2019
{
    partial class Wantobegun
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
            this.btn_uch_new = new System.Windows.Forms.Button();
            this.btn_uch_ranee = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.time2 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_uch_new
            // 
            this.btn_uch_new.Location = new System.Drawing.Point(98, 205);
            this.btn_uch_new.Name = "btn_uch_new";
            this.btn_uch_new.Size = new System.Drawing.Size(333, 65);
            this.btn_uch_new.TabIndex = 11;
            this.btn_uch_new.Text = "Я новый участник";
            this.btn_uch_new.UseVisualStyleBackColor = true;
            this.btn_uch_new.Click += new System.EventHandler(this.btn_uch_new_Click);
            // 
            // btn_uch_ranee
            // 
            this.btn_uch_ranee.Location = new System.Drawing.Point(98, 122);
            this.btn_uch_ranee.Name = "btn_uch_ranee";
            this.btn_uch_ranee.Size = new System.Drawing.Size(333, 65);
            this.btn_uch_ranee.TabIndex = 10;
            this.btn_uch_ranee.Text = "Я участвовал ранее";
            this.btn_uch_ranee.UseVisualStyleBackColor = true;
            this.btn_uch_ranee.Click += new System.EventHandler(this.btn_uch_ranee_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button6.Location = new System.Drawing.Point(17, 14);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(92, 37);
            this.button6.TabIndex = 68;
            this.button6.Text = "Назад";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(129, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(302, 29);
            this.label3.TabIndex = 67;
            this.label3.Text = "MARATHON SKILLS 2019";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pictureBox1.Location = new System.Drawing.Point(-5, -12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(770, 81);
            this.pictureBox1.TabIndex = 66;
            this.pictureBox1.TabStop = false;
            // 
            // time2
            // 
            this.time2.AutoSize = true;
            this.time2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.time2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.time2.ForeColor = System.Drawing.SystemColors.Control;
            this.time2.Location = new System.Drawing.Point(107, 351);
            this.time2.Name = "time2";
            this.time2.Size = new System.Drawing.Size(0, 20);
            this.time2.TabIndex = 70;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pictureBox3.Location = new System.Drawing.Point(-99, 338);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(749, 44);
            this.pictureBox3.TabIndex = 69;
            this.pictureBox3.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Wantobegun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 378);
            this.Controls.Add(this.time2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_uch_new);
            this.Controls.Add(this.btn_uch_ranee);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Wantobegun";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wantobegun";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Wantobegun_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_uch_new;
        private System.Windows.Forms.Button btn_uch_ranee;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label time2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Timer timer1;
    }
}