
using System.Drawing;
using System.Windows.Forms;

namespace MainApplication.Main
{
    partial class MainForm
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
        private System.Windows.Forms.Button openCircleButton;
        private System.Windows.Forms.Button openBresenhamButton;
        private System.Windows.Forms.Button openElipseButton;
        private System.Windows.Forms.Button openTrans2dButton;

        private void InitializeComponent()
        {
            this.openCircleButton = new System.Windows.Forms.Button();
            this.openBresenhamButton = new System.Windows.Forms.Button();
            this.openElipseButton = new System.Windows.Forms.Button();
            this.openTrans2dButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openCircleButton
            // 
            this.openCircleButton.BackColor = System.Drawing.Color.PowderBlue;
            this.openCircleButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkViolet;
            this.openCircleButton.FlatAppearance.BorderSize = 2;
            this.openCircleButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGreen;
            this.openCircleButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGreen;
            this.openCircleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openCircleButton.Location = new System.Drawing.Point(132, 54);
            this.openCircleButton.Name = "openCircleButton";
            this.openCircleButton.Size = new System.Drawing.Size(146, 43);
            this.openCircleButton.TabIndex = 0;
            this.openCircleButton.Text = "Open Circle Panel";
            this.openCircleButton.UseVisualStyleBackColor = false;
            this.openCircleButton.Click += new System.EventHandler(this.openCircleButton_Click);
            // 
            // openBresenhamButton
            // 
            this.openBresenhamButton.BackColor = System.Drawing.Color.PowderBlue;
            this.openBresenhamButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkViolet;
            this.openBresenhamButton.FlatAppearance.BorderSize = 2;
            this.openBresenhamButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGreen;
            this.openBresenhamButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGreen;
            this.openBresenhamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openBresenhamButton.Location = new System.Drawing.Point(132, 172);
            this.openBresenhamButton.Name = "openBresenhamButton";
            this.openBresenhamButton.Size = new System.Drawing.Size(146, 64);
            this.openBresenhamButton.TabIndex = 1;
            this.openBresenhamButton.Text = "Open Bresenham & DDA Panel";
            this.openBresenhamButton.UseVisualStyleBackColor = false;
            this.openBresenhamButton.Click += new System.EventHandler(this.openBresenhamButton_Click);
            // 
            // openElipseButton
            // 
            this.openElipseButton.BackColor = System.Drawing.Color.PowderBlue;
            this.openElipseButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkViolet;
            this.openElipseButton.FlatAppearance.BorderSize = 2;
            this.openElipseButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGreen;
            this.openElipseButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGreen;
            this.openElipseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openElipseButton.Location = new System.Drawing.Point(132, 304);
            this.openElipseButton.Name = "openElipseButton";
            this.openElipseButton.Size = new System.Drawing.Size(146, 45);
            this.openElipseButton.TabIndex = 2;
            this.openElipseButton.Text = "Open Elipse Panel";
            this.openElipseButton.UseVisualStyleBackColor = false;
            this.openElipseButton.Click += new System.EventHandler(this.openElipseButton_Click);
            // 
            // openTrans2dButton
            // 
            this.openTrans2dButton.BackColor = System.Drawing.Color.PowderBlue;
            this.openTrans2dButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkViolet;
            this.openTrans2dButton.FlatAppearance.BorderSize = 2;
            this.openTrans2dButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGreen;
            this.openTrans2dButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGreen;
            this.openTrans2dButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openTrans2dButton.Location = new System.Drawing.Point(501, 172);
            this.openTrans2dButton.Name = "openTrans2dButton";
            this.openTrans2dButton.Size = new System.Drawing.Size(146, 45);
            this.openTrans2dButton.TabIndex = 3;
            this.openTrans2dButton.Text = "Open trans 2d Panel";
            this.openTrans2dButton.UseVisualStyleBackColor = false;
            this.openTrans2dButton.Click += new System.EventHandler(this.openTransformationButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.openElipseButton);
            this.Controls.Add(this.openCircleButton);
            this.Controls.Add(this.openBresenhamButton);
            this.Controls.Add(this.openTrans2dButton);
            this.Name = "MainForm";
            this.Text = "Graphics Package";
            this.ResumeLayout(false);




        }

        #endregion
    }
}