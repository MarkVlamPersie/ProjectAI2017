﻿namespace SteeringCS
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
            this.dbPanel1 = new SteeringCS.DBPanel();
            this.label_DecelerationSpeed = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_CurrentBehaviour = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dbPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dbPanel1
            // 
            this.dbPanel1.BackColor = System.Drawing.Color.White;
            this.dbPanel1.Controls.Add(this.label_DecelerationSpeed);
            this.dbPanel1.Controls.Add(this.label2);
            this.dbPanel1.Controls.Add(this.label_CurrentBehaviour);
            this.dbPanel1.Controls.Add(this.label1);
            this.dbPanel1.Location = new System.Drawing.Point(0, 0);
            this.dbPanel1.Name = "dbPanel1";
            this.dbPanel1.Size = new System.Drawing.Size(611, 436);
            this.dbPanel1.TabIndex = 0;
            this.dbPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.dbPanel1_Paint);
            this.dbPanel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dbPanel1_MouseClick);
            // 
            // label_DecelerationSpeed
            // 
            this.label_DecelerationSpeed.AutoSize = true;
            this.label_DecelerationSpeed.Location = new System.Drawing.Point(168, 35);
            this.label_DecelerationSpeed.Name = "label_DecelerationSpeed";
            this.label_DecelerationSpeed.Size = new System.Drawing.Size(30, 13);
            this.label_DecelerationSpeed.TabIndex = 3;
            this.label_DecelerationSpeed.Text = "Slow";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Current deceleration speed:";
            // 
            // label_CurrentBehaviour
            // 
            this.label_CurrentBehaviour.AutoSize = true;
            this.label_CurrentBehaviour.Location = new System.Drawing.Point(168, 9);
            this.label_CurrentBehaviour.Name = "label_CurrentBehaviour";
            this.label_CurrentBehaviour.Size = new System.Drawing.Size(32, 13);
            this.label_CurrentBehaviour.TabIndex = 1;
            this.label_CurrentBehaviour.Text = "Seek";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Current behaviour: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 436);
            this.Controls.Add(this.dbPanel1);
            this.Name = "Form1";
            this.Text = "Steering";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.dbPanel1.ResumeLayout(false);
            this.dbPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DBPanel dbPanel1;
        private System.Windows.Forms.Label label_CurrentBehaviour;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_DecelerationSpeed;
        private System.Windows.Forms.Label label2;
    }
}

