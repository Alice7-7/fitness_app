namespace fitness_app
{
    partial class fitness_goal
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
            this.label2 = new System.Windows.Forms.Label();
            this.calorie_goal_input = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.err_msg = new System.Windows.Forms.Label();
            this.back_home = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PictureBox3 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.close_btn = new Guna.UI2.WinForms.Guna2PictureBox();
            this.next_btn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.set_goal_btn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.update_btn = new Guna.UI2.WinForms.Guna2GradientButton();
            ((System.ComponentModel.ISupportInitialize)(this.back_home)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.close_btn)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(157)))), ((int)(((byte)(167)))));
            this.label1.Location = new System.Drawing.Point(509, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(645, 62);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to Fitness Goal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(157)))), ((int)(((byte)(167)))));
            this.label2.Location = new System.Drawing.Point(477, 379);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(707, 40);
            this.label2.TabIndex = 1;
            this.label2.Text = "Please set your \'Fitness Goal for one week\'";
            // 
            // calorie_goal_input
            // 
            this.calorie_goal_input.Animated = true;
            this.calorie_goal_input.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.calorie_goal_input.DefaultText = "";
            this.calorie_goal_input.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.calorie_goal_input.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.calorie_goal_input.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.calorie_goal_input.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.calorie_goal_input.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.calorie_goal_input.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.calorie_goal_input.ForeColor = System.Drawing.Color.Black;
            this.calorie_goal_input.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.calorie_goal_input.Location = new System.Drawing.Point(705, 528);
            this.calorie_goal_input.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.calorie_goal_input.Name = "calorie_goal_input";
            this.calorie_goal_input.PasswordChar = '\0';
            this.calorie_goal_input.PlaceholderText = "Enter your goal\r\n\r\n";
            this.calorie_goal_input.SelectedText = "";
            this.calorie_goal_input.Size = new System.Drawing.Size(571, 115);
            this.calorie_goal_input.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(157)))), ((int)(((byte)(167)))));
            this.label3.Location = new System.Drawing.Point(379, 563);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(285, 46);
            this.label3.TabIndex = 4;
            this.label3.Text = "Calories Goal :";
            // 
            // err_msg
            // 
            this.err_msg.AutoSize = true;
            this.err_msg.ForeColor = System.Drawing.Color.IndianRed;
            this.err_msg.Location = new System.Drawing.Point(731, 672);
            this.err_msg.Name = "err_msg";
            this.err_msg.Size = new System.Drawing.Size(0, 37);
            this.err_msg.TabIndex = 7;
            // 
            // back_home
            // 
            this.back_home.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.back_home.Image = global::fitness_app.Properties.Resources.back_g;
            this.back_home.ImageRotate = 0F;
            this.back_home.Location = new System.Drawing.Point(0, -1);
            this.back_home.Name = "back_home";
            this.back_home.Size = new System.Drawing.Size(109, 112);
            this.back_home.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.back_home.TabIndex = 8;
            this.back_home.TabStop = false;
            this.back_home.Click += new System.EventHandler(this.back_home_Click);
            // 
            // guna2PictureBox3
            // 
            this.guna2PictureBox3.Image = global::fitness_app.Properties.Resources.goals;
            this.guna2PictureBox3.ImageRotate = 0F;
            this.guna2PictureBox3.Location = new System.Drawing.Point(286, 539);
            this.guna2PictureBox3.Name = "guna2PictureBox3";
            this.guna2PictureBox3.Size = new System.Drawing.Size(87, 85);
            this.guna2PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox3.TabIndex = 6;
            this.guna2PictureBox3.TabStop = false;
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.ImageRotate = 0F;
            this.guna2PictureBox2.Location = new System.Drawing.Point(0, 0);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.Size = new System.Drawing.Size(300, 200);
            this.guna2PictureBox2.TabIndex = 0;
            this.guna2PictureBox2.TabStop = false;
            // 
            // close_btn
            // 
            this.close_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close_btn.Image = global::fitness_app.Properties.Resources.close;
            this.close_btn.ImageRotate = 0F;
            this.close_btn.Location = new System.Drawing.Point(1532, -1);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(129, 112);
            this.close_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.close_btn.TabIndex = 5;
            this.close_btn.TabStop = false;
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click);
            // 
            // next_btn
            // 
            this.next_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.next_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.next_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.next_btn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.next_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.next_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(210)))), ((int)(((byte)(255)))));
            this.next_btn.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(141)))), ((int)(((byte)(171)))));
            this.next_btn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.next_btn.ForeColor = System.Drawing.Color.White;
            this.next_btn.Image = global::fitness_app.Properties.Resources.next_i;
            this.next_btn.Location = new System.Drawing.Point(1190, 867);
            this.next_btn.Name = "next_btn";
            this.next_btn.Size = new System.Drawing.Size(327, 173);
            this.next_btn.TabIndex = 3;
            this.next_btn.Text = "Next";
            this.next_btn.Click += new System.EventHandler(this.next_btn_Click);
            // 
            // set_goal_btn
            // 
            this.set_goal_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.set_goal_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.set_goal_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.set_goal_btn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.set_goal_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.set_goal_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(210)))), ((int)(((byte)(255)))));
            this.set_goal_btn.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(141)))), ((int)(((byte)(171)))));
            this.set_goal_btn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.set_goal_btn.ForeColor = System.Drawing.Color.White;
            this.set_goal_btn.Image = global::fitness_app.Properties.Resources.set_goal;
            this.set_goal_btn.Location = new System.Drawing.Point(629, 867);
            this.set_goal_btn.Name = "set_goal_btn";
            this.set_goal_btn.Size = new System.Drawing.Size(327, 173);
            this.set_goal_btn.TabIndex = 3;
            this.set_goal_btn.Text = "Set Goal";
            this.set_goal_btn.Click += new System.EventHandler(this.set_goal_btn_Click);
            // 
            // update_btn
            // 
            this.update_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.update_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.update_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.update_btn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.update_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.update_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(210)))), ((int)(((byte)(255)))));
            this.update_btn.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(141)))), ((int)(((byte)(171)))));
            this.update_btn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.update_btn.ForeColor = System.Drawing.Color.White;
            this.update_btn.Image = global::fitness_app.Properties.Resources.update;
            this.update_btn.Location = new System.Drawing.Point(106, 867);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(327, 173);
            this.update_btn.TabIndex = 3;
            this.update_btn.Text = "Update";
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
            // 
            // fitness_goal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1659, 1155);
            this.Controls.Add(this.back_home);
            this.Controls.Add(this.err_msg);
            this.Controls.Add(this.guna2PictureBox3);
            this.Controls.Add(this.guna2PictureBox2);
            this.Controls.Add(this.close_btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.next_btn);
            this.Controls.Add(this.set_goal_btn);
            this.Controls.Add(this.update_btn);
            this.Controls.Add(this.calorie_goal_input);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fitness_goal";
            this.Text = "fitness_goal";
            this.Load += new System.EventHandler(this.fitness_goal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.back_home)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.close_btn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox calorie_goal_input;
        private Guna.UI2.WinForms.Guna2GradientButton update_btn;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2GradientButton set_goal_btn;
        private Guna.UI2.WinForms.Guna2GradientButton next_btn;
        private Guna.UI2.WinForms.Guna2PictureBox close_btn;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox3;
        private System.Windows.Forms.Label err_msg;
        private Guna.UI2.WinForms.Guna2PictureBox back_home;
    }
}