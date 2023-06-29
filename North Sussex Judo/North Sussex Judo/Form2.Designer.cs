namespace North_Sussex_Judo
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnlogOut = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnathlete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(25)))), ((int)(((byte)(45)))));
            this.panel6.BackgroundImage = global::North_Sussex_Judo.Properties.Resources.Ui1;
            this.panel6.Controls.Add(this.btnlogOut);
            this.panel6.Controls.Add(this.button1);
            this.panel6.Controls.Add(this.btnathlete);
            this.panel6.Controls.Add(this.label1);
            this.panel6.Location = new System.Drawing.Point(0, -2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1149, 611);
            this.panel6.TabIndex = 16;
            this.panel6.Paint += new System.Windows.Forms.PaintEventHandler(this.panel6_Paint);
            // 
            // btnlogOut
            // 
            this.btnlogOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnlogOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnlogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlogOut.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogOut.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnlogOut.Image = ((System.Drawing.Image)(resources.GetObject("btnlogOut.Image")));
            this.btnlogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnlogOut.Location = new System.Drawing.Point(975, 17);
            this.btnlogOut.Name = "btnlogOut";
            this.btnlogOut.Size = new System.Drawing.Size(148, 53);
            this.btnlogOut.TabIndex = 128;
            this.btnlogOut.Text = "Logout";
            this.btnlogOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnlogOut.UseVisualStyleBackColor = false;
            this.btnlogOut.Click += new System.EventHandler(this.btnlogOut_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::North_Sussex_Judo.Properties.Resources.button;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(635, 218);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(223, 219);
            this.button1.TabIndex = 6;
            this.button1.Text = "Payment";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnathlete
            // 
            this.btnathlete.BackColor = System.Drawing.Color.Transparent;
            this.btnathlete.BackgroundImage = global::North_Sussex_Judo.Properties.Resources.button;
            this.btnathlete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnathlete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnathlete.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnathlete.ForeColor = System.Drawing.Color.White;
            this.btnathlete.Image = ((System.Drawing.Image)(resources.GetObject("btnathlete.Image")));
            this.btnathlete.Location = new System.Drawing.Point(326, 218);
            this.btnathlete.Name = "btnathlete";
            this.btnathlete.Size = new System.Drawing.Size(223, 219);
            this.btnathlete.TabIndex = 3;
            this.btnathlete.Text = "Athlete";
            this.btnathlete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnathlete.UseVisualStyleBackColor = false;
            this.btnathlete.Click += new System.EventHandler(this.btnathlete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(480, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dashboard";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1147, 607);
            this.Controls.Add(this.panel6);
            this.Name = "Form2";
            this.Text = "Form2";
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnathlete;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnlogOut;
    }
}