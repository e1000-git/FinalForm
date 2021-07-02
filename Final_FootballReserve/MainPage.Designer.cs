
namespace Final_FootballReserve
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnnewres = new System.Windows.Forms.Button();
            this.btnrsrvtns = new System.Windows.Forms.Button();
            this.btnaddcustomer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnnewres
            // 
            this.btnnewres.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnnewres.Location = new System.Drawing.Point(412, 173);
            this.btnnewres.Name = "btnnewres";
            this.btnnewres.Size = new System.Drawing.Size(157, 56);
            this.btnnewres.TabIndex = 6;
            this.btnnewres.Text = "New Reserve";
            this.btnnewres.UseVisualStyleBackColor = true;
            // 
            // btnrsrvtns
            // 
            this.btnrsrvtns.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnrsrvtns.Location = new System.Drawing.Point(283, 74);
            this.btnrsrvtns.Name = "btnrsrvtns";
            this.btnrsrvtns.Size = new System.Drawing.Size(157, 56);
            this.btnrsrvtns.TabIndex = 5;
            this.btnrsrvtns.Text = "Reservations";
            this.btnrsrvtns.UseVisualStyleBackColor = true;
            // 
            // btnaddcustomer
            // 
            this.btnaddcustomer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnaddcustomer.Location = new System.Drawing.Point(151, 173);
            this.btnaddcustomer.Name = "btnaddcustomer";
            this.btnaddcustomer.Size = new System.Drawing.Size(157, 56);
            this.btnaddcustomer.TabIndex = 4;
            this.btnaddcustomer.Text = "Add Customer";
            this.btnaddcustomer.UseVisualStyleBackColor = true;
            this.btnaddcustomer.Click += new System.EventHandler(this.btnaddcustomer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnnewres);
            this.Controls.Add(this.btnrsrvtns);
            this.Controls.Add(this.btnaddcustomer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnnewres;
        private System.Windows.Forms.Button btnrsrvtns;
        private System.Windows.Forms.Button btnaddcustomer;
    }
}

