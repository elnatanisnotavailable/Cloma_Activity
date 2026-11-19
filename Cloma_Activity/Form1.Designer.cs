namespace Cloma_Activity
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
            this.lbl_header = new System.Windows.Forms.Label();
            this.lbl_salesperson = new System.Windows.Forms.Label();
            this.textbox_initial = new System.Windows.Forms.TextBox();
            this.lbl_amountofsales = new System.Windows.Forms.Label();
            this.textbox_amountofsale = new System.Windows.Forms.TextBox();
            this.btn_submit = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_print = new System.Windows.Forms.Button();
            this.lbl_output = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_header
            // 
            this.lbl_header.AutoSize = true;
            this.lbl_header.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_header.Location = new System.Drawing.Point(256, 129);
            this.lbl_header.Name = "lbl_header";
            this.lbl_header.Size = new System.Drawing.Size(239, 24);
            this.lbl_header.TabIndex = 0;
            this.lbl_header.Text = "Sales Monitoring System";
            // 
            // lbl_salesperson
            // 
            this.lbl_salesperson.AutoSize = true;
            this.lbl_salesperson.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_salesperson.Location = new System.Drawing.Point(262, 160);
            this.lbl_salesperson.Name = "lbl_salesperson";
            this.lbl_salesperson.Size = new System.Drawing.Size(140, 16);
            this.lbl_salesperson.TabIndex = 1;
            this.lbl_salesperson.Text = "Salesperson Initial:";
            this.lbl_salesperson.Click += new System.EventHandler(this.lbl_salesperson_Click);
            // 
            // textbox_initial
            // 
            this.textbox_initial.Location = new System.Drawing.Point(404, 156);
            this.textbox_initial.Name = "textbox_initial";
            this.textbox_initial.Size = new System.Drawing.Size(133, 20);
            this.textbox_initial.TabIndex = 2;
            this.textbox_initial.TextChanged += new System.EventHandler(this.textbox_initial_TextChanged);
            // 
            // lbl_amountofsales
            // 
            this.lbl_amountofsales.AutoSize = true;
            this.lbl_amountofsales.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_amountofsales.Location = new System.Drawing.Point(283, 186);
            this.lbl_amountofsales.Name = "lbl_amountofsales";
            this.lbl_amountofsales.Size = new System.Drawing.Size(115, 16);
            this.lbl_amountofsales.TabIndex = 1;
            this.lbl_amountofsales.Text = "Amount of Sale:";
            this.lbl_amountofsales.Click += new System.EventHandler(this.lbl_amountofsales_Click);
            // 
            // textbox_amountofsale
            // 
            this.textbox_amountofsale.Location = new System.Drawing.Point(404, 182);
            this.textbox_amountofsale.Name = "textbox_amountofsale";
            this.textbox_amountofsale.Size = new System.Drawing.Size(133, 20);
            this.textbox_amountofsale.TabIndex = 2;
            this.textbox_amountofsale.TextChanged += new System.EventHandler(this.textbox_amountofsale_TextChanged);
            // 
            // btn_submit
            // 
            this.btn_submit.Location = new System.Drawing.Point(300, 212);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(75, 23);
            this.btn_submit.TabIndex = 3;
            this.btn_submit.Text = "Submit";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(381, 212);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(75, 23);
            this.btn_clear.TabIndex = 3;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_print
            // 
            this.btn_print.Location = new System.Drawing.Point(462, 212);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(75, 23);
            this.btn_print.TabIndex = 3;
            this.btn_print.Text = "Print";
            this.btn_print.UseVisualStyleBackColor = true;
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // lbl_output
            // 
            this.lbl_output.AutoSize = true;
            this.lbl_output.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_output.Location = new System.Drawing.Point(297, 243);
            this.lbl_output.Name = "lbl_output";
            this.lbl_output.Size = new System.Drawing.Size(51, 17);
            this.lbl_output.TabIndex = 4;
            this.lbl_output.Text = "Output";
            this.lbl_output.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(257, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 39);
            this.label1.TabIndex = 5;
            this.label1.Text = "D - Danielle\r\nE - Edward\r\nF - Fatima";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_output);
            this.Controls.Add(this.btn_print);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.textbox_amountofsale);
            this.Controls.Add(this.lbl_amountofsales);
            this.Controls.Add(this.textbox_initial);
            this.Controls.Add(this.lbl_salesperson);
            this.Controls.Add(this.lbl_header);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_header;
        private System.Windows.Forms.Label lbl_salesperson;
        private System.Windows.Forms.TextBox textbox_initial;
        private System.Windows.Forms.Label lbl_amountofsales;
        private System.Windows.Forms.TextBox textbox_amountofsale;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_print;
        private System.Windows.Forms.Label lbl_output;
        private System.Windows.Forms.Label label1;
    }
}

