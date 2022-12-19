namespace Robot
{
    partial class Robot_Form
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
            this.Robot_Panel = new System.Windows.Forms.Panel();
            this.Robot_Label = new System.Windows.Forms.Label();
            this.Coordinates_Label = new System.Windows.Forms.Label();
            this.North_Button = new System.Windows.Forms.Button();
            this.South_Button = new System.Windows.Forms.Button();
            this.East_Button = new System.Windows.Forms.Button();
            this.West_Button = new System.Windows.Forms.Button();
            this.MoveOne_Button = new System.Windows.Forms.Button();
            this.MoveTen_Button = new System.Windows.Forms.Button();
            this.Exit_Button = new System.Windows.Forms.Button();
            this.Robot_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Robot_Panel
            // 
            this.Robot_Panel.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Robot_Panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Robot_Panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Robot_Panel.Controls.Add(this.Robot_Label);
            this.Robot_Panel.Location = new System.Drawing.Point(40, 40);
            this.Robot_Panel.Name = "Robot_Panel";
            this.Robot_Panel.Size = new System.Drawing.Size(300, 300);
            this.Robot_Panel.TabIndex = 0;
            // 
            // Robot_Label
            // 
            this.Robot_Label.AutoSize = true;
            this.Robot_Label.Font = new System.Drawing.Font("Wingdings", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.Robot_Label.Location = new System.Drawing.Point(131, 135);
            this.Robot_Label.Name = "Robot_Label";
            this.Robot_Label.Size = new System.Drawing.Size(19, 15);
            this.Robot_Label.TabIndex = 0;
            this.Robot_Label.Text = "é";
            // 
            // Coordinates_Label
            // 
            this.Coordinates_Label.AutoSize = true;
            this.Coordinates_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Coordinates_Label.Location = new System.Drawing.Point(37, 9);
            this.Coordinates_Label.Name = "Coordinates_Label";
            this.Coordinates_Label.Size = new System.Drawing.Size(64, 15);
            this.Coordinates_Label.TabIndex = 1;
            this.Coordinates_Label.Text = "{X=0, Y=0}";
            // 
            // North_Button
            // 
            this.North_Button.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.North_Button.Location = new System.Drawing.Point(176, 356);
            this.North_Button.Name = "North_Button";
            this.North_Button.Size = new System.Drawing.Size(30, 30);
            this.North_Button.TabIndex = 2;
            this.North_Button.Text = "N";
            this.North_Button.UseVisualStyleBackColor = true;
            this.North_Button.Click += new System.EventHandler(this.North_Button_Click);
            // 
            // South_Button
            // 
            this.South_Button.Location = new System.Drawing.Point(176, 435);
            this.South_Button.Name = "South_Button";
            this.South_Button.Size = new System.Drawing.Size(30, 30);
            this.South_Button.TabIndex = 3;
            this.South_Button.Text = "S";
            this.South_Button.UseVisualStyleBackColor = true;
            this.South_Button.Click += new System.EventHandler(this.South_Button_Click);
            // 
            // East_Button
            // 
            this.East_Button.Location = new System.Drawing.Point(216, 395);
            this.East_Button.Name = "East_Button";
            this.East_Button.Size = new System.Drawing.Size(30, 30);
            this.East_Button.TabIndex = 4;
            this.East_Button.Text = "E";
            this.East_Button.UseVisualStyleBackColor = true;
            this.East_Button.Click += new System.EventHandler(this.East_Button_Click);
            // 
            // West_Button
            // 
            this.West_Button.Location = new System.Drawing.Point(137, 395);
            this.West_Button.Name = "West_Button";
            this.West_Button.Size = new System.Drawing.Size(30, 30);
            this.West_Button.TabIndex = 5;
            this.West_Button.Text = "W";
            this.West_Button.UseVisualStyleBackColor = true;
            this.West_Button.Click += new System.EventHandler(this.West_Button_Click);
            // 
            // MoveOne_Button
            // 
            this.MoveOne_Button.Location = new System.Drawing.Point(40, 395);
            this.MoveOne_Button.Name = "MoveOne_Button";
            this.MoveOne_Button.Size = new System.Drawing.Size(63, 30);
            this.MoveOne_Button.TabIndex = 6;
            this.MoveOne_Button.Text = "Go 1";
            this.MoveOne_Button.UseVisualStyleBackColor = true;
            this.MoveOne_Button.Click += new System.EventHandler(this.MoveOne_Button_Click);
            // 
            // MoveTen_Button
            // 
            this.MoveTen_Button.Location = new System.Drawing.Point(277, 395);
            this.MoveTen_Button.Name = "MoveTen_Button";
            this.MoveTen_Button.Size = new System.Drawing.Size(63, 30);
            this.MoveTen_Button.TabIndex = 7;
            this.MoveTen_Button.Text = "Go 10";
            this.MoveTen_Button.UseVisualStyleBackColor = true;
            this.MoveTen_Button.Click += new System.EventHandler(this.MoveTen_Button_Click);
            // 
            // Exit_Button
            // 
            this.Exit_Button.Location = new System.Drawing.Point(277, 467);
            this.Exit_Button.Name = "Exit_Button";
            this.Exit_Button.Size = new System.Drawing.Size(63, 27);
            this.Exit_Button.TabIndex = 8;
            this.Exit_Button.Text = "Exit";
            this.Exit_Button.UseVisualStyleBackColor = true;
            this.Exit_Button.Click += new System.EventHandler(this.Exit_Button_Click);
            // 
            // Robot_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 506);
            this.Controls.Add(this.Exit_Button);
            this.Controls.Add(this.MoveTen_Button);
            this.Controls.Add(this.MoveOne_Button);
            this.Controls.Add(this.West_Button);
            this.Controls.Add(this.East_Button);
            this.Controls.Add(this.South_Button);
            this.Controls.Add(this.North_Button);
            this.Controls.Add(this.Coordinates_Label);
            this.Controls.Add(this.Robot_Panel);
            this.Name = "Robot_Form";
            this.Text = "Robot";
            this.Robot_Panel.ResumeLayout(false);
            this.Robot_Panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Robot_Panel;
        private System.Windows.Forms.Label Coordinates_Label;
        private System.Windows.Forms.Label Robot_Label;
        private System.Windows.Forms.Button North_Button;
        private System.Windows.Forms.Button South_Button;
        private System.Windows.Forms.Button East_Button;
        private System.Windows.Forms.Button West_Button;
        private System.Windows.Forms.Button MoveOne_Button;
        private System.Windows.Forms.Button MoveTen_Button;
        private System.Windows.Forms.Button Exit_Button;
    }
}

