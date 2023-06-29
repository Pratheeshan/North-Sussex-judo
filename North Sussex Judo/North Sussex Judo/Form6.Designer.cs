namespace North_Sussex_Judo
{
    partial class Form6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            this.lblContact = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.gridviewPayment = new System.Windows.Forms.DataGridView();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btndashBoard = new System.Windows.Forms.Button();
            this.lblpayment = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewPayment)).BeginInit();
            this.SuspendLayout();
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.BackColor = System.Drawing.Color.Transparent;
            this.lblContact.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContact.ForeColor = System.Drawing.Color.White;
            this.lblContact.Location = new System.Drawing.Point(185, 135);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(126, 29);
            this.lblContact.TabIndex = 160;
            this.lblContact.Text = "Athlete ID";
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtId.Location = new System.Drawing.Point(336, 128);
            this.txtId.Multiline = true;
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(220, 36);
            this.txtId.TabIndex = 159;
            // 
            // gridviewPayment
            // 
            this.gridviewPayment.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.gridviewPayment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridviewPayment.Location = new System.Drawing.Point(21, 202);
            this.gridviewPayment.Name = "gridviewPayment";
            this.gridviewPayment.RowTemplate.Height = 24;
            this.gridviewPayment.Size = new System.Drawing.Size(985, 526);
            this.gridviewPayment.TabIndex = 161;
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnCalculate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculate.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCalculate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCalculate.Location = new System.Drawing.Point(718, 123);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(143, 52);
            this.btnCalculate.TabIndex = 172;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.button1_Click);
            // 
            // btndashBoard
            // 
            this.btndashBoard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btndashBoard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btndashBoard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndashBoard.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndashBoard.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btndashBoard.Image = ((System.Drawing.Image)(resources.GetObject("btndashBoard.Image")));
            this.btndashBoard.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btndashBoard.Location = new System.Drawing.Point(829, 25);
            this.btndashBoard.Name = "btndashBoard";
            this.btndashBoard.Size = new System.Drawing.Size(177, 53);
            this.btndashBoard.TabIndex = 173;
            this.btndashBoard.Text = "Dashboard";
            this.btndashBoard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btndashBoard.UseVisualStyleBackColor = false;
            this.btndashBoard.Click += new System.EventHandler(this.btndashBoard_Click);
            // 
            // lblpayment
            // 
            this.lblpayment.AutoSize = true;
            this.lblpayment.BackColor = System.Drawing.Color.Transparent;
            this.lblpayment.Font = new System.Drawing.Font("Times New Roman", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblpayment.ForeColor = System.Drawing.Color.White;
            this.lblpayment.Location = new System.Drawing.Point(387, 29);
            this.lblpayment.Name = "lblpayment";
            this.lblpayment.Size = new System.Drawing.Size(313, 49);
            this.lblpayment.TabIndex = 174;
            this.lblpayment.Text = "Payment Details";
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::North_Sussex_Judo.Properties.Resources.Ui1;
            this.ClientSize = new System.Drawing.Size(1024, 755);
            this.Controls.Add(this.lblpayment);
            this.Controls.Add(this.btndashBoard);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.gridviewPayment);
            this.Controls.Add(this.lblContact);
            this.Controls.Add(this.txtId);
            this.Name = "Form6";
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridviewPayment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.DataGridView gridviewPayment;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btndashBoard;
        private System.Windows.Forms.Label lblpayment;
    }
}