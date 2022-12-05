namespace Przyjecie
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
            this.label1 = new System.Windows.Forms.Label();
            this.numeric_people = new System.Windows.Forms.NumericUpDown();
            this.checkBox_decorations = new System.Windows.Forms.CheckBox();
            this.checkBox_healthy = new System.Windows.Forms.CheckBox();
            this.label_cost = new System.Windows.Forms.Label();
            this.label_empty = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_people)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ilosc ludzi";
            // 
            // numeric_people
            // 
            this.numeric_people.Location = new System.Drawing.Point(49, 86);
            this.numeric_people.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numeric_people.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numeric_people.Name = "numeric_people";
            this.numeric_people.Size = new System.Drawing.Size(100, 20);
            this.numeric_people.TabIndex = 1;
            this.numeric_people.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numeric_people.ValueChanged += new System.EventHandler(this.numeric_people_ValueChanged);
            // 
            // checkBox_decorations
            // 
            this.checkBox_decorations.AutoSize = true;
            this.checkBox_decorations.Checked = true;
            this.checkBox_decorations.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_decorations.Location = new System.Drawing.Point(49, 121);
            this.checkBox_decorations.Name = "checkBox_decorations";
            this.checkBox_decorations.Size = new System.Drawing.Size(126, 17);
            this.checkBox_decorations.TabIndex = 2;
            this.checkBox_decorations.Text = "Dekoracje fantazyjne";
            this.checkBox_decorations.UseVisualStyleBackColor = true;
            this.checkBox_decorations.CheckedChanged += new System.EventHandler(this.checkBox_decorations_CheckedChanged);
            // 
            // checkBox_healthy
            // 
            this.checkBox_healthy.AutoSize = true;
            this.checkBox_healthy.Location = new System.Drawing.Point(49, 155);
            this.checkBox_healthy.Name = "checkBox_healthy";
            this.checkBox_healthy.Size = new System.Drawing.Size(91, 17);
            this.checkBox_healthy.TabIndex = 3;
            this.checkBox_healthy.Text = "Opcja zdrowa";
            this.checkBox_healthy.UseVisualStyleBackColor = true;
            this.checkBox_healthy.CheckedChanged += new System.EventHandler(this.checkBox_healthy_CheckedChanged);
            // 
            // label_cost
            // 
            this.label_cost.AutoSize = true;
            this.label_cost.Font = new System.Drawing.Font("Segoe Print", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_cost.Location = new System.Drawing.Point(45, 189);
            this.label_cost.Name = "label_cost";
            this.label_cost.Size = new System.Drawing.Size(43, 21);
            this.label_cost.TabIndex = 4;
            this.label_cost.Text = "Koszt";
            // 
            // label_empty
            // 
            this.label_empty.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_empty.Location = new System.Drawing.Point(103, 189);
            this.label_empty.Name = "label_empty";
            this.label_empty.Size = new System.Drawing.Size(72, 19);
            this.label_empty.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(249, 246);
            this.Controls.Add(this.label_empty);
            this.Controls.Add(this.label_cost);
            this.Controls.Add(this.checkBox_healthy);
            this.Controls.Add(this.checkBox_decorations);
            this.Controls.Add(this.numeric_people);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Planner przyjec";            
            ((System.ComponentModel.ISupportInitialize)(this.numeric_people)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numeric_people;
        private System.Windows.Forms.CheckBox checkBox_decorations;
        private System.Windows.Forms.CheckBox checkBox_healthy;
        private System.Windows.Forms.Label label_cost;
        private System.Windows.Forms.Label label_empty;
    }
}

