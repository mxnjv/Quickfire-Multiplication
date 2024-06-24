namespace Quickfire_Multiplication
{
    partial class frm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm));
            timer = new System.Windows.Forms.Timer(components);
            btn_multiplication = new Button();
            btn_division = new Button();
            btn_addition = new Button();
            btn_subtraction = new Button();
            btn_settings = new Button();
            x = new Button();
            socials = new Label();
            dashboardPanel = new Panel();
            multiplicationN1 = new Label();
            multiplicationN2 = new Label();
            sign = new Label();
            scoreIndication = new Label();
            scoretextlabelthingy = new Label();
            label5 = new Label();
            answerM = new TextBox();
            answerbuttonM = new Button();
            statusM = new Label();
            panelSettings = new Panel();
            negativeNumbers = new CheckBox();
            label2 = new Label();
            settingStatus = new Label();
            comboDifficulty = new ComboBox();
            btnSave = new Button();
            label1 = new Label();
            comboColour = new ComboBox();
            gameplayPanel = new Panel();
            timericon = new PictureBox();
            timedisplay = new Label();
            hacks = new Label();
            congratsPanel = new Panel();
            label7 = new Label();
            flawlessText = new Label();
            congratsmessage = new Label();
            difficultyLabel = new Label();
            label4 = new Label();
            scoreNumber = new Label();
            button1 = new Button();
            dashboardPanel.SuspendLayout();
            panelSettings.SuspendLayout();
            gameplayPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)timericon).BeginInit();
            congratsPanel.SuspendLayout();
            SuspendLayout();
            // 
            // timer
            // 
            timer.Enabled = true;
            timer.Interval = 1000;
            timer.Tick += timer_Tick;
            // 
            // btn_multiplication
            // 
            btn_multiplication.BackColor = Color.Transparent;
            btn_multiplication.FlatAppearance.BorderColor = Color.Maroon;
            btn_multiplication.FlatAppearance.BorderSize = 2;
            btn_multiplication.FlatAppearance.MouseDownBackColor = Color.LightCoral;
            btn_multiplication.FlatAppearance.MouseOverBackColor = Color.LightCoral;
            btn_multiplication.FlatStyle = FlatStyle.Flat;
            btn_multiplication.Font = new Font("Bahnschrift SemiLight", 9.81F, FontStyle.Regular, GraphicsUnit.Point);
            btn_multiplication.ForeColor = Color.Azure;
            btn_multiplication.Location = new Point(4, 166);
            btn_multiplication.Name = "btn_multiplication";
            btn_multiplication.RightToLeft = RightToLeft.Yes;
            btn_multiplication.Size = new Size(108, 39);
            btn_multiplication.TabIndex = 0;
            btn_multiplication.Text = "Multiplication";
            btn_multiplication.TextImageRelation = TextImageRelation.ImageAboveText;
            btn_multiplication.UseVisualStyleBackColor = false;
            btn_multiplication.Click += btn_multiplication_Click;
            // 
            // btn_division
            // 
            btn_division.BackColor = Color.Transparent;
            btn_division.FlatAppearance.BorderColor = Color.Maroon;
            btn_division.FlatAppearance.BorderSize = 2;
            btn_division.FlatAppearance.MouseDownBackColor = Color.LightCoral;
            btn_division.FlatAppearance.MouseOverBackColor = Color.LightCoral;
            btn_division.FlatStyle = FlatStyle.Flat;
            btn_division.Font = new Font("Bahnschrift SemiLight", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btn_division.ForeColor = Color.Azure;
            btn_division.Location = new Point(3, 211);
            btn_division.Name = "btn_division";
            btn_division.RightToLeft = RightToLeft.Yes;
            btn_division.Size = new Size(108, 39);
            btn_division.TabIndex = 1;
            btn_division.Text = "Division";
            btn_division.TextImageRelation = TextImageRelation.ImageAboveText;
            btn_division.UseVisualStyleBackColor = false;
            btn_division.Click += btn_division_Click;
            // 
            // btn_addition
            // 
            btn_addition.BackColor = Color.Transparent;
            btn_addition.FlatAppearance.BorderColor = Color.Maroon;
            btn_addition.FlatAppearance.BorderSize = 2;
            btn_addition.FlatAppearance.MouseDownBackColor = Color.LightCoral;
            btn_addition.FlatAppearance.MouseOverBackColor = Color.LightCoral;
            btn_addition.FlatStyle = FlatStyle.Flat;
            btn_addition.Font = new Font("Bahnschrift SemiLight", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btn_addition.ForeColor = Color.Azure;
            btn_addition.Location = new Point(3, 256);
            btn_addition.Name = "btn_addition";
            btn_addition.RightToLeft = RightToLeft.Yes;
            btn_addition.Size = new Size(108, 39);
            btn_addition.TabIndex = 2;
            btn_addition.Text = "Addition";
            btn_addition.TextImageRelation = TextImageRelation.ImageAboveText;
            btn_addition.UseVisualStyleBackColor = false;
            btn_addition.Click += btn_addition_Click;
            // 
            // btn_subtraction
            // 
            btn_subtraction.BackColor = Color.Transparent;
            btn_subtraction.FlatAppearance.BorderColor = Color.Maroon;
            btn_subtraction.FlatAppearance.BorderSize = 2;
            btn_subtraction.FlatAppearance.MouseDownBackColor = Color.LightCoral;
            btn_subtraction.FlatAppearance.MouseOverBackColor = Color.LightCoral;
            btn_subtraction.FlatStyle = FlatStyle.Flat;
            btn_subtraction.Font = new Font("Bahnschrift SemiLight", 9.81F, FontStyle.Regular, GraphicsUnit.Point);
            btn_subtraction.ForeColor = Color.Azure;
            btn_subtraction.Location = new Point(3, 303);
            btn_subtraction.Name = "btn_subtraction";
            btn_subtraction.RightToLeft = RightToLeft.Yes;
            btn_subtraction.Size = new Size(108, 39);
            btn_subtraction.TabIndex = 3;
            btn_subtraction.Text = "Subtraction";
            btn_subtraction.TextImageRelation = TextImageRelation.ImageAboveText;
            btn_subtraction.UseVisualStyleBackColor = false;
            btn_subtraction.Click += btn_subtraction_Click;
            // 
            // btn_settings
            // 
            btn_settings.BackColor = Color.Transparent;
            btn_settings.FlatAppearance.BorderColor = Color.RosyBrown;
            btn_settings.FlatAppearance.BorderSize = 2;
            btn_settings.FlatAppearance.MouseDownBackColor = Color.LightCoral;
            btn_settings.FlatAppearance.MouseOverBackColor = Color.LightCoral;
            btn_settings.FlatStyle = FlatStyle.Flat;
            btn_settings.Font = new Font("Bahnschrift SemiLight", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_settings.ForeColor = Color.Azure;
            btn_settings.Location = new Point(20, 362);
            btn_settings.Name = "btn_settings";
            btn_settings.RightToLeft = RightToLeft.Yes;
            btn_settings.Size = new Size(72, 38);
            btn_settings.TabIndex = 4;
            btn_settings.Text = "Settings";
            btn_settings.TextImageRelation = TextImageRelation.ImageAboveText;
            btn_settings.UseVisualStyleBackColor = false;
            btn_settings.Click += btn_settings_Click;
            // 
            // x
            // 
            x.BackColor = Color.Red;
            x.FlatAppearance.BorderColor = Color.Snow;
            x.FlatAppearance.BorderSize = 4;
            x.FlatAppearance.MouseDownBackColor = Color.LightCoral;
            x.FlatAppearance.MouseOverBackColor = Color.LightCoral;
            x.FlatStyle = FlatStyle.Flat;
            x.Font = new Font("Book Antiqua", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            x.ForeColor = Color.LavenderBlush;
            x.Location = new Point(40, 406);
            x.Name = "x";
            x.RightToLeft = RightToLeft.Yes;
            x.Size = new Size(32, 39);
            x.TabIndex = 6;
            x.Text = "X";
            x.TextImageRelation = TextImageRelation.ImageAboveText;
            x.UseVisualStyleBackColor = false;
            x.Click += x_Click;
            // 
            // socials
            // 
            socials.AutoSize = true;
            socials.Font = new Font("Bahnschrift Light", 9F, FontStyle.Regular, GraphicsUnit.Point);
            socials.ForeColor = Color.Transparent;
            socials.Location = new Point(31, 51);
            socials.Name = "socials";
            socials.Size = new Size(50, 14);
            socials.TabIndex = 7;
            socials.Text = "@m7anj";
            socials.Click += label7_Click;
            // 
            // dashboardPanel
            // 
            dashboardPanel.BackColor = Color.Brown;
            dashboardPanel.Controls.Add(socials);
            dashboardPanel.Controls.Add(x);
            dashboardPanel.Controls.Add(btn_settings);
            dashboardPanel.Controls.Add(btn_subtraction);
            dashboardPanel.Controls.Add(btn_addition);
            dashboardPanel.Controls.Add(btn_division);
            dashboardPanel.Controls.Add(btn_multiplication);
            dashboardPanel.Location = new Point(-1, -9);
            dashboardPanel.Name = "dashboardPanel";
            dashboardPanel.Size = new Size(114, 478);
            dashboardPanel.TabIndex = 0;
            // 
            // multiplicationN1
            // 
            multiplicationN1.AutoSize = true;
            multiplicationN1.Font = new Font("Rockwell", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            multiplicationN1.ForeColor = Color.Transparent;
            multiplicationN1.Location = new Point(116, 137);
            multiplicationN1.Name = "multiplicationN1";
            multiplicationN1.Size = new Size(66, 43);
            multiplicationN1.TabIndex = 0;
            multiplicationN1.Text = "N1";
            // 
            // multiplicationN2
            // 
            multiplicationN2.AutoSize = true;
            multiplicationN2.Font = new Font("Rockwell", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            multiplicationN2.ForeColor = Color.Transparent;
            multiplicationN2.Location = new Point(231, 138);
            multiplicationN2.Name = "multiplicationN2";
            multiplicationN2.Size = new Size(66, 43);
            multiplicationN2.TabIndex = 1;
            multiplicationN2.Text = "N2";
            // 
            // sign
            // 
            sign.AccessibleName = "sign";
            sign.AutoSize = true;
            sign.Font = new Font("Tempus Sans ITC", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            sign.ForeColor = Color.Transparent;
            sign.Location = new Point(188, 134);
            sign.Name = "sign";
            sign.Size = new Size(37, 46);
            sign.TabIndex = 2;
            sign.Text = "x";
            sign.Click += label3_Click;
            // 
            // scoreIndication
            // 
            scoreIndication.AutoSize = true;
            scoreIndication.Font = new Font("Cascadia Mono SemiBold", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            scoreIndication.ForeColor = Color.Transparent;
            scoreIndication.Location = new Point(141, 19);
            scoreIndication.Name = "scoreIndication";
            scoreIndication.Size = new Size(41, 46);
            scoreIndication.TabIndex = 3;
            scoreIndication.Text = "0";
            scoreIndication.Click += scoreIndication_Click;
            // 
            // scoretextlabelthingy
            // 
            scoretextlabelthingy.AutoSize = true;
            scoretextlabelthingy.Font = new Font("Bahnschrift Light", 24F, FontStyle.Regular, GraphicsUnit.Point);
            scoretextlabelthingy.ForeColor = Color.Transparent;
            scoretextlabelthingy.Location = new Point(42, 22);
            scoretextlabelthingy.Name = "scoretextlabelthingy";
            scoretextlabelthingy.Size = new Size(107, 39);
            scoretextlabelthingy.TabIndex = 4;
            scoretextlabelthingy.Text = "Score:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tempus Sans ITC", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Transparent;
            label5.Location = new Point(303, 138);
            label5.Name = "label5";
            label5.Size = new Size(39, 46);
            label5.TabIndex = 5;
            label5.Text = "=";
            // 
            // answerM
            // 
            answerM.Font = new Font("Cascadia Code", 24F, FontStyle.Regular, GraphicsUnit.Point);
            answerM.Location = new Point(417, 137);
            answerM.Name = "answerM";
            answerM.Size = new Size(159, 45);
            answerM.TabIndex = 6;
            answerM.TextChanged += textBox1_TextChanged;
            // 
            // answerbuttonM
            // 
            answerbuttonM.BackColor = Color.Transparent;
            answerbuttonM.FlatAppearance.BorderColor = SystemColors.Menu;
            answerbuttonM.FlatAppearance.BorderSize = 5;
            answerbuttonM.FlatAppearance.MouseDownBackColor = Color.IndianRed;
            answerbuttonM.FlatAppearance.MouseOverBackColor = Color.IndianRed;
            answerbuttonM.FlatStyle = FlatStyle.Flat;
            answerbuttonM.Font = new Font("Bahnschrift SemiLight", 9.81F, FontStyle.Regular, GraphicsUnit.Point);
            answerbuttonM.ForeColor = Color.Azure;
            answerbuttonM.Location = new Point(222, 241);
            answerbuttonM.Name = "answerbuttonM";
            answerbuttonM.RightToLeft = RightToLeft.Yes;
            answerbuttonM.Size = new Size(113, 58);
            answerbuttonM.TabIndex = 7;
            answerbuttonM.Text = "Answer";
            answerbuttonM.TextImageRelation = TextImageRelation.ImageAboveText;
            answerbuttonM.UseVisualStyleBackColor = false;
            answerbuttonM.Click += answerbuttonM_Click;
            // 
            // statusM
            // 
            statusM.AutoSize = true;
            statusM.Font = new Font("Bahnschrift Light", 18F, FontStyle.Regular, GraphicsUnit.Point);
            statusM.ForeColor = Color.Transparent;
            statusM.Location = new Point(342, 251);
            statusM.Name = "statusM";
            statusM.Size = new Size(0, 29);
            statusM.TabIndex = 8;
            // 
            // panelSettings
            // 
            panelSettings.Controls.Add(negativeNumbers);
            panelSettings.Controls.Add(label2);
            panelSettings.Controls.Add(settingStatus);
            panelSettings.Controls.Add(comboDifficulty);
            panelSettings.Controls.Add(btnSave);
            panelSettings.Controls.Add(label1);
            panelSettings.Controls.Add(comboColour);
            panelSettings.Location = new Point(192, 42);
            panelSettings.Name = "panelSettings";
            panelSettings.Size = new Size(437, 367);
            panelSettings.TabIndex = 6;
            // 
            // negativeNumbers
            // 
            negativeNumbers.AutoSize = true;
            negativeNumbers.ForeColor = SystemColors.ButtonHighlight;
            negativeNumbers.Location = new Point(150, 225);
            negativeNumbers.Name = "negativeNumbers";
            negativeNumbers.Size = new Size(125, 19);
            negativeNumbers.TabIndex = 9;
            negativeNumbers.Text = "Negative Numbers";
            negativeNumbers.UseVisualStyleBackColor = true;
            negativeNumbers.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Azure;
            label2.Location = new Point(89, 161);
            label2.Name = "label2";
            label2.Size = new Size(76, 21);
            label2.TabIndex = 8;
            label2.Text = "Difficulty";
            label2.Click += label2_Click;
            // 
            // settingStatus
            // 
            settingStatus.AutoSize = true;
            settingStatus.Font = new Font("Bahnschrift Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            settingStatus.ForeColor = Color.Transparent;
            settingStatus.Location = new Point(144, 336);
            settingStatus.Name = "settingStatus";
            settingStatus.Size = new Size(0, 19);
            settingStatus.TabIndex = 4;
            // 
            // comboDifficulty
            // 
            comboDifficulty.FormattingEnabled = true;
            comboDifficulty.Items.AddRange(new object[] { "Low", "Medium", "High", "Insane" });
            comboDifficulty.Location = new Point(171, 163);
            comboDifficulty.Name = "comboDifficulty";
            comboDifficulty.Size = new Size(146, 23);
            comboDifficulty.TabIndex = 7;
            comboDifficulty.Text = "Medium";
            comboDifficulty.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Transparent;
            btnSave.FlatAppearance.BorderColor = Color.White;
            btnSave.FlatAppearance.BorderSize = 3;
            btnSave.FlatAppearance.MouseDownBackColor = Color.LightCoral;
            btnSave.FlatAppearance.MouseOverBackColor = Color.LightCoral;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Bahnschrift SemiLight", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnSave.ForeColor = Color.Azure;
            btnSave.Location = new Point(153, 292);
            btnSave.Name = "btnSave";
            btnSave.RightToLeft = RightToLeft.Yes;
            btnSave.Size = new Size(113, 39);
            btnSave.TabIndex = 6;
            btnSave.Text = "Apply Settings";
            btnSave.TextImageRelation = TextImageRelation.ImageAboveText;
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Azure;
            label1.Location = new Point(106, 104);
            label1.Name = "label1";
            label1.Size = new Size(59, 21);
            label1.TabIndex = 1;
            label1.Text = "Colour";
            // 
            // comboColour
            // 
            comboColour.FormattingEnabled = true;
            comboColour.Items.AddRange(new object[] { "Red", "Yellow", "Green", "Blue", "Purple", "Light", "Dark" });
            comboColour.Location = new Point(171, 104);
            comboColour.Name = "comboColour";
            comboColour.Size = new Size(146, 23);
            comboColour.TabIndex = 0;
            comboColour.Text = "Red";
            comboColour.SelectedIndexChanged += comboColour_SelectedIndexChanged;
            // 
            // gameplayPanel
            // 
            gameplayPanel.Controls.Add(timericon);
            gameplayPanel.Controls.Add(statusM);
            gameplayPanel.Controls.Add(answerbuttonM);
            gameplayPanel.Controls.Add(answerM);
            gameplayPanel.Controls.Add(label5);
            gameplayPanel.Controls.Add(timedisplay);
            gameplayPanel.Controls.Add(scoretextlabelthingy);
            gameplayPanel.Controls.Add(scoreIndication);
            gameplayPanel.Controls.Add(sign);
            gameplayPanel.Controls.Add(multiplicationN2);
            gameplayPanel.Controls.Add(multiplicationN1);
            gameplayPanel.Location = new Point(132, 67);
            gameplayPanel.Name = "gameplayPanel";
            gameplayPanel.Size = new Size(625, 339);
            gameplayPanel.TabIndex = 11;
            gameplayPanel.Paint += gameplayPanel_Paint;
            // 
            // timericon
            // 
            timericon.BackColor = Color.Transparent;
            timericon.Image = (Image)resources.GetObject("timericon.Image");
            timericon.Location = new Point(564, 3);
            timericon.Name = "timericon";
            timericon.Size = new Size(58, 65);
            timericon.TabIndex = 9;
            timericon.TabStop = false;
            // 
            // timedisplay
            // 
            timedisplay.AutoSize = true;
            timedisplay.Font = new Font("Bahnschrift", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            timedisplay.ForeColor = Color.Transparent;
            timedisplay.Location = new Point(516, 22);
            timedisplay.Name = "timedisplay";
            timedisplay.Size = new Size(24, 18);
            timedisplay.TabIndex = 4;
            timedisplay.Text = "30";
            // 
            // hacks
            // 
            hacks.AutoSize = true;
            hacks.ForeColor = SystemColors.ActiveCaption;
            hacks.Location = new Point(719, 9);
            hacks.Name = "hacks";
            hacks.Size = new Size(7, 15);
            hacks.TabIndex = 12;
            hacks.Text = "\u001f ";
            hacks.Click += hacks_Click;
            // 
            // congratsPanel
            // 
            congratsPanel.Controls.Add(label7);
            congratsPanel.Controls.Add(flawlessText);
            congratsPanel.Controls.Add(congratsmessage);
            congratsPanel.Controls.Add(difficultyLabel);
            congratsPanel.Controls.Add(label4);
            congratsPanel.Controls.Add(scoreNumber);
            congratsPanel.Controls.Add(button1);
            congratsPanel.Location = new Point(220, 5);
            congratsPanel.Name = "congratsPanel";
            congratsPanel.Size = new Size(452, 440);
            congratsPanel.TabIndex = 13;
            congratsPanel.Paint += congratsPanel_Paint;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Bahnschrift Light", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(128, 255, 128);
            label7.Location = new Point(259, 197);
            label7.Name = "label7";
            label7.RightToLeft = RightToLeft.No;
            label7.Size = new Size(0, 14);
            label7.TabIndex = 8;
            label7.Click += label7_Click_1;
            // 
            // flawlessText
            // 
            flawlessText.AutoSize = true;
            flawlessText.Font = new Font("Bahnschrift Light", 9F, FontStyle.Regular, GraphicsUnit.Point);
            flawlessText.ForeColor = Color.FromArgb(128, 255, 128);
            flawlessText.Location = new Point(290, 116);
            flawlessText.Name = "flawlessText";
            flawlessText.RightToLeft = RightToLeft.No;
            flawlessText.Size = new Size(56, 14);
            flawlessText.TabIndex = 7;
            flawlessText.Text = "Flawless!";
            flawlessText.Click += label7_Click;
            // 
            // congratsmessage
            // 
            congratsmessage.AutoSize = true;
            congratsmessage.Font = new Font("Bahnschrift Light", 9F, FontStyle.Regular, GraphicsUnit.Point);
            congratsmessage.ForeColor = Color.Transparent;
            congratsmessage.Location = new Point(199, 272);
            congratsmessage.Name = "congratsmessage";
            congratsmessage.Size = new Size(60, 14);
            congratsmessage.TabIndex = 7;
            congratsmessage.Text = "Well done.";
            congratsmessage.TextAlign = ContentAlignment.TopCenter;
            congratsmessage.Click += label7_Click;
            // 
            // difficultyLabel
            // 
            difficultyLabel.AutoSize = true;
            difficultyLabel.Font = new Font("Bahnschrift Light", 24F, FontStyle.Regular, GraphicsUnit.Point);
            difficultyLabel.ForeColor = Color.Transparent;
            difficultyLabel.Location = new Point(253, 184);
            difficultyLabel.Name = "difficultyLabel";
            difficultyLabel.Size = new Size(0, 39);
            difficultyLabel.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bahnschrift Light", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Transparent;
            label4.Location = new Point(134, 107);
            label4.Name = "label4";
            label4.Size = new Size(113, 39);
            label4.TabIndex = 4;
            label4.Text = "Score:";
            // 
            // scoreNumber
            // 
            scoreNumber.AutoSize = true;
            scoreNumber.Font = new Font("Cascadia Mono SemiBold", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            scoreNumber.ForeColor = Color.Transparent;
            scoreNumber.Location = new Point(243, 100);
            scoreNumber.Name = "scoreNumber";
            scoreNumber.Size = new Size(41, 46);
            scoreNumber.TabIndex = 3;
            scoreNumber.Text = "0";
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatAppearance.BorderColor = Color.Maroon;
            button1.FlatAppearance.BorderSize = 2;
            button1.FlatAppearance.MouseDownBackColor = Color.LightCoral;
            button1.FlatAppearance.MouseOverBackColor = Color.LightCoral;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Bahnschrift SemiLight", 9.81F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.Azure;
            button1.Location = new Point(173, 334);
            button1.Name = "button1";
            button1.RightToLeft = RightToLeft.Yes;
            button1.Size = new Size(107, 41);
            button1.TabIndex = 0;
            button1.Text = "Again";
            button1.TextImageRelation = TextImageRelation.ImageAboveText;
            button1.UseVisualStyleBackColor = false;
            button1.Click += btn_multiplication_Click;
            // 
            // frm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(46, 51, 55);
            ClientSize = new Size(769, 457);
            Controls.Add(gameplayPanel);
            Controls.Add(congratsPanel);
            Controls.Add(panelSettings);
            Controls.Add(dashboardPanel);
            Controls.Add(hacks);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "form";
            Load += Form1_Load;
            dashboardPanel.ResumeLayout(false);
            dashboardPanel.PerformLayout();
            panelSettings.ResumeLayout(false);
            panelSettings.PerformLayout();
            gameplayPanel.ResumeLayout(false);
            gameplayPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)timericon).EndInit();
            congratsPanel.ResumeLayout(false);
            congratsPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panelSettings;
        private Button btnSave;
        private Label label1;
        private ComboBox comboColour;
        private Label label2;
        private ComboBox comboDifficulty;
        private CheckBox negativenumbers;
        private Label multiplicationN1;
        private Label multiplicationN2;
        private Label sign;
        private Panel gameplayPanel;
        private TextBox answerM;
        private Label label5;
        private Label scoretextlabelthingy;
        private Label scoreIndication;
        private Button answerbuttonM;
        private Label statusM;
        private System.Windows.Forms.Timer timer;
        private Button btn_multiplication;
        private Button btn_division;
        private Button btn_addition;
        private Button btn_subtraction;
        private Button btn_settings;
        private Button x;
        private Label socials;
        private Panel dashboardPanel;
        private Label settingStatus;
        private Label hacks;
        private Label timedisplay;
        private PictureBox timericon;
        private Panel congratsPanel;
        private Label label4;
        private Label scoreNumber;
        private Label congratsmessage;
        private Label difficultyLabel;
        private Button button1;
        private Label flawlessText;
        private Label label7;
        private CheckBox decimalnumbers;
        private CheckBox negativeNumbers;
    }
}