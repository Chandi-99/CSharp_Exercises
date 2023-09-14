namespace Milage_Calculator
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
            this.btn_calculate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_fuel = new System.Windows.Forms.TextBox();
            this.txt_distance = new System.Windows.Forms.TextBox();
            this.txt_milage = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_calculate
            // 
            this.btn_calculate.Location = new System.Drawing.Point(99, 188);
            this.btn_calculate.Name = "btn_calculate";
            this.btn_calculate.Size = new System.Drawing.Size(75, 23);
            this.btn_calculate.TabIndex = 3;
            this.btn_calculate.Text = "Calculate";
            this.btn_calculate.UseVisualStyleBackColor = true;
            this.btn_calculate.Click += new System.EventHandler(this.btn_calculate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fuel (L)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Distance (Km)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Milage (Km/L)";
            // 
            // txt_fuel
            // 
            this.txt_fuel.Location = new System.Drawing.Point(144, 42);
            this.txt_fuel.Name = "txt_fuel";
            this.txt_fuel.Size = new System.Drawing.Size(100, 20);
            this.txt_fuel.TabIndex = 1;
            this.txt_fuel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_distance
            // 
            this.txt_distance.Location = new System.Drawing.Point(144, 83);
            this.txt_distance.Name = "txt_distance";
            this.txt_distance.Size = new System.Drawing.Size(100, 20);
            this.txt_distance.TabIndex = 2;
            this.txt_distance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_milage
            // 
            this.txt_milage.Location = new System.Drawing.Point(144, 141);
            this.txt_milage.Name = "txt_milage";
            this.txt_milage.ReadOnly = true;
            this.txt_milage.Size = new System.Drawing.Size(100, 20);
            this.txt_milage.TabIndex = 4;
            this.txt_milage.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 232);
            this.Controls.Add(this.txt_milage);
            this.Controls.Add(this.txt_distance);
            this.Controls.Add(this.txt_fuel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_calculate);
            this.Name = "Form1";
            this.Text = "Milage Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_calculate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_fuel;
        private System.Windows.Forms.TextBox txt_distance;
        private System.Windows.Forms.TextBox txt_milage;
    }
}

