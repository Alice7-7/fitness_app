namespace fitness_app
{
    partial class home
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
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.result_btn = new Guna.UI2.WinForms.Guna2Button();
            this.sign_out_btn = new Guna.UI2.WinForms.Guna2Button();
            this.calculate_btn = new Guna.UI2.WinForms.Guna2Button();
            this.goal_btn = new Guna.UI2.WinForms.Guna2Button();
            this.dashboard_btn = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.username_inp = new Guna.UI2.WinForms.Guna2TextBox();
            this.calorie_goal_inp = new Guna.UI2.WinForms.Guna2TextBox();
            this.day_used = new Guna.UI2.WinForms.Guna2TextBox();
            this.current_calorie_burned = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.close_btn = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.close_btn)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.label5);
            this.guna2Panel1.Controls.Add(this.guna2Separator1);
            this.guna2Panel1.Controls.Add(this.result_btn);
            this.guna2Panel1.Controls.Add(this.sign_out_btn);
            this.guna2Panel1.Controls.Add(this.calculate_btn);
            this.guna2Panel1.Controls.Add(this.goal_btn);
            this.guna2Panel1.Controls.Add(this.dashboard_btn);
            this.guna2Panel1.Controls.Add(this.pictureBox1);
            this.guna2Panel1.Location = new System.Drawing.Point(-3, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(627, 1710);
            this.guna2Panel1.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(157)))), ((int)(((byte)(167)))));
            this.label5.Location = new System.Drawing.Point(83, 414);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(447, 40);
            this.label5.TabIndex = 8;
            this.label5.Text = "Calories Burned Calculator";
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Location = new System.Drawing.Point(108, 486);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(394, 10);
            this.guna2Separator1.TabIndex = 2;
            // 
            // result_btn
            // 
            this.result_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.result_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.result_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.result_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.result_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.result_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(157)))), ((int)(((byte)(167)))));
            this.result_btn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.result_btn.ForeColor = System.Drawing.Color.White;
            this.result_btn.Image = global::fitness_app.Properties.Resources.result_i;
            this.result_btn.Location = new System.Drawing.Point(49, 1198);
            this.result_btn.Name = "result_btn";
            this.result_btn.Size = new System.Drawing.Size(481, 139);
            this.result_btn.TabIndex = 2;
            this.result_btn.Text = "Result";
            this.result_btn.Click += new System.EventHandler(this.result_btn_Click);
            // 
            // sign_out_btn
            // 
            this.sign_out_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sign_out_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.sign_out_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.sign_out_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.sign_out_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.sign_out_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(157)))), ((int)(((byte)(167)))));
            this.sign_out_btn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.sign_out_btn.ForeColor = System.Drawing.Color.White;
            this.sign_out_btn.Image = global::fitness_app.Properties.Resources.log_out;
            this.sign_out_btn.Location = new System.Drawing.Point(49, 1530);
            this.sign_out_btn.Name = "sign_out_btn";
            this.sign_out_btn.Size = new System.Drawing.Size(481, 139);
            this.sign_out_btn.TabIndex = 2;
            this.sign_out_btn.Text = "Sign Out";
            this.sign_out_btn.Click += new System.EventHandler(this.sign_out_btn_Click);
            // 
            // calculate_btn
            // 
            this.calculate_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.calculate_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.calculate_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.calculate_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.calculate_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.calculate_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(157)))), ((int)(((byte)(167)))));
            this.calculate_btn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.calculate_btn.ForeColor = System.Drawing.Color.White;
            this.calculate_btn.Image = global::fitness_app.Properties.Resources.calculate_i;
            this.calculate_btn.Location = new System.Drawing.Point(49, 982);
            this.calculate_btn.Name = "calculate_btn";
            this.calculate_btn.Size = new System.Drawing.Size(481, 139);
            this.calculate_btn.TabIndex = 2;
            this.calculate_btn.Text = "Calculator";
            this.calculate_btn.Click += new System.EventHandler(this.calculate_btn_Click);
            // 
            // goal_btn
            // 
            this.goal_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.goal_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.goal_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.goal_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.goal_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.goal_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(157)))), ((int)(((byte)(167)))));
            this.goal_btn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.goal_btn.ForeColor = System.Drawing.Color.White;
            this.goal_btn.Image = global::fitness_app.Properties.Resources.target;
            this.goal_btn.Location = new System.Drawing.Point(49, 772);
            this.goal_btn.Name = "goal_btn";
            this.goal_btn.Size = new System.Drawing.Size(481, 139);
            this.goal_btn.TabIndex = 2;
            this.goal_btn.Text = "Goal";
            this.goal_btn.Click += new System.EventHandler(this.goal_btn_Click);
            // 
            // dashboard_btn
            // 
            this.dashboard_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dashboard_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.dashboard_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.dashboard_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.dashboard_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.dashboard_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(157)))), ((int)(((byte)(167)))));
            this.dashboard_btn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.dashboard_btn.ForeColor = System.Drawing.Color.White;
            this.dashboard_btn.Image = global::fitness_app.Properties.Resources.dashboard;
            this.dashboard_btn.Location = new System.Drawing.Point(49, 553);
            this.dashboard_btn.Name = "dashboard_btn";
            this.dashboard_btn.Size = new System.Drawing.Size(481, 139);
            this.dashboard_btn.TabIndex = 2;
            this.dashboard_btn.Text = "Dashboard";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::fitness_app.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(198, 154);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(212, 205);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // username_inp
            // 
            this.username_inp.BorderColor = System.Drawing.Color.White;
            this.username_inp.BorderThickness = 0;
            this.username_inp.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.username_inp.DefaultText = "";
            this.username_inp.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.username_inp.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.username_inp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.username_inp.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.username_inp.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.username_inp.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.username_inp.ForeColor = System.Drawing.Color.Black;
            this.username_inp.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.username_inp.Location = new System.Drawing.Point(1306, 728);
            this.username_inp.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.username_inp.Name = "username_inp";
            this.username_inp.PasswordChar = '\0';
            this.username_inp.PlaceholderForeColor = System.Drawing.Color.Black;
            this.username_inp.PlaceholderText = "";
            this.username_inp.SelectedText = "";
            this.username_inp.Size = new System.Drawing.Size(390, 73);
            this.username_inp.TabIndex = 2;
            // 
            // calorie_goal_inp
            // 
            this.calorie_goal_inp.BorderColor = System.Drawing.Color.White;
            this.calorie_goal_inp.BorderThickness = 0;
            this.calorie_goal_inp.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.calorie_goal_inp.DefaultText = "";
            this.calorie_goal_inp.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.calorie_goal_inp.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.calorie_goal_inp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.calorie_goal_inp.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.calorie_goal_inp.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.calorie_goal_inp.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.calorie_goal_inp.ForeColor = System.Drawing.Color.Black;
            this.calorie_goal_inp.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.calorie_goal_inp.Location = new System.Drawing.Point(734, 1077);
            this.calorie_goal_inp.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.calorie_goal_inp.Name = "calorie_goal_inp";
            this.calorie_goal_inp.PasswordChar = '\0';
            this.calorie_goal_inp.PlaceholderForeColor = System.Drawing.Color.Black;
            this.calorie_goal_inp.PlaceholderText = "";
            this.calorie_goal_inp.SelectedText = "";
            this.calorie_goal_inp.Size = new System.Drawing.Size(390, 73);
            this.calorie_goal_inp.TabIndex = 2;
            // 
            // day_used
            // 
            this.day_used.BorderThickness = 0;
            this.day_used.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.day_used.DefaultText = "";
            this.day_used.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.day_used.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.day_used.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.day_used.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.day_used.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.day_used.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.day_used.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.day_used.Location = new System.Drawing.Point(734, 1425);
            this.day_used.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.day_used.Name = "day_used";
            this.day_used.PasswordChar = '\0';
            this.day_used.PlaceholderText = "";
            this.day_used.SelectedText = "";
            this.day_used.Size = new System.Drawing.Size(390, 73);
            this.day_used.TabIndex = 2;
            // 
            // current_calorie_burned
            // 
            this.current_calorie_burned.BorderThickness = 0;
            this.current_calorie_burned.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.current_calorie_burned.DefaultText = "";
            this.current_calorie_burned.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.current_calorie_burned.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.current_calorie_burned.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.current_calorie_burned.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.current_calorie_burned.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.current_calorie_burned.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.current_calorie_burned.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.current_calorie_burned.Location = new System.Drawing.Point(1363, 1077);
            this.current_calorie_burned.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.current_calorie_burned.Name = "current_calorie_burned";
            this.current_calorie_burned.PasswordChar = '\0';
            this.current_calorie_burned.PlaceholderText = "";
            this.current_calorie_burned.SelectedText = "";
            this.current_calorie_burned.Size = new System.Drawing.Size(390, 73);
            this.current_calorie_burned.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(157)))), ((int)(((byte)(167)))));
            this.label1.Location = new System.Drawing.Point(1098, 742);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 40);
            this.label1.TabIndex = 7;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(157)))), ((int)(((byte)(167)))));
            this.label2.Location = new System.Drawing.Point(727, 992);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(304, 40);
            this.label2.TabIndex = 7;
            this.label2.Text = "Your calories goal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(157)))), ((int)(((byte)(167)))));
            this.label3.Location = new System.Drawing.Point(768, 1329);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 40);
            this.label3.TabIndex = 7;
            this.label3.Text = "Days Used";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(157)))), ((int)(((byte)(167)))));
            this.label4.Location = new System.Drawing.Point(1356, 992);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(275, 40);
            this.label4.TabIndex = 7;
            this.label4.Text = "Calories Burned";
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2CirclePictureBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2CirclePictureBox1.Image = global::fitness_app.Properties.Resources.bad_cat;
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(735, 604);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(226, 232);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBox1.TabIndex = 8;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::fitness_app.Properties.Resources.fitness_bg;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(625, 126);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(1190, 589);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.guna2PictureBox1.TabIndex = 0;
            this.guna2PictureBox1.TabStop = false;
            // 
            // close_btn
            // 
            this.close_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close_btn.Image = global::fitness_app.Properties.Resources.close;
            this.close_btn.ImageRotate = 0F;
            this.close_btn.Location = new System.Drawing.Point(1688, 0);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(127, 102);
            this.close_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.close_btn.TabIndex = 3;
            this.close_btn.TabStop = false;
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click);
            // 
            // home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1815, 1707);
            this.Controls.Add(this.guna2CirclePictureBox1);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.close_btn);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.day_used);
            this.Controls.Add(this.current_calorie_burned);
            this.Controls.Add(this.calorie_goal_inp);
            this.Controls.Add(this.username_inp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "home";
            this.Text = "home";
            this.Load += new System.EventHandler(this.home_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.close_btn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2TextBox username_inp;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2Button dashboard_btn;
        private Guna.UI2.WinForms.Guna2Button goal_btn;
        private Guna.UI2.WinForms.Guna2Button result_btn;
        private Guna.UI2.WinForms.Guna2Button sign_out_btn;
        private Guna.UI2.WinForms.Guna2Button calculate_btn;
        private Guna.UI2.WinForms.Guna2PictureBox close_btn;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2TextBox calorie_goal_inp;
        private Guna.UI2.WinForms.Guna2TextBox day_used;
        private Guna.UI2.WinForms.Guna2TextBox current_calorie_burned;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
    }
}