using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace DeceptionPalace
{
    partial class mainGameForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainGameForm));
            this.eventLog1 = new System.Diagnostics.EventLog();
            this.boxPlayer1 = new System.Windows.Forms.GroupBox();
            this.btnToTarget1 = new System.Windows.Forms.Button();
            this.playerSprite1 = new System.Windows.Forms.PictureBox();
            this.boxPlayer2 = new System.Windows.Forms.GroupBox();
            this.btnToTarget2 = new System.Windows.Forms.Button();
            this.playerSprite2 = new System.Windows.Forms.PictureBox();
            this.boxPlayer3 = new System.Windows.Forms.GroupBox();
            this.btnToTarget3 = new System.Windows.Forms.Button();
            this.playerSprite3 = new System.Windows.Forms.PictureBox();
            this.boxPlayer6 = new System.Windows.Forms.GroupBox();
            this.btnToTarget6 = new System.Windows.Forms.Button();
            this.playerSprite6 = new System.Windows.Forms.PictureBox();
            this.boxPlayer5 = new System.Windows.Forms.GroupBox();
            this.btnToTarget5 = new System.Windows.Forms.Button();
            this.playerSprite5 = new System.Windows.Forms.PictureBox();
            this.boxPlayer4 = new System.Windows.Forms.GroupBox();
            this.btnToTarget4 = new System.Windows.Forms.Button();
            this.playerSprite4 = new System.Windows.Forms.PictureBox();
            this.boxPlayer9 = new System.Windows.Forms.GroupBox();
            this.btnToTarget9 = new System.Windows.Forms.Button();
            this.playerSprite9 = new System.Windows.Forms.PictureBox();
            this.boxPlayer8 = new System.Windows.Forms.GroupBox();
            this.btnToTarget8 = new System.Windows.Forms.Button();
            this.playerSprite8 = new System.Windows.Forms.PictureBox();
            this.boxPlayer7 = new System.Windows.Forms.GroupBox();
            this.btnToTarget7 = new System.Windows.Forms.Button();
            this.playerSprite7 = new System.Windows.Forms.PictureBox();
            this.roleTextbox = new System.Windows.Forms.RichTextBox();
            this.eventTextbox = new System.Windows.Forms.RichTextBox();
            this.stageLabel = new System.Windows.Forms.Label();
            this.stageNumLabel = new System.Windows.Forms.Label();
            this.stageIcon = new System.Windows.Forms.PictureBox();
            this.btn1stRole = new System.Windows.Forms.Button();
            this.btn2ndRole = new System.Windows.Forms.Button();
            this.btn3rdRole = new System.Windows.Forms.Button();
            this.btnViewedKingsChoice = new System.Windows.Forms.Button();
            this.btnViewedPrelimResults = new System.Windows.Forms.Button();
            this.btnBeginPrelim = new System.Windows.Forms.Button();
            this.btnViewedSwitchResults = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            this.boxPlayer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playerSprite1)).BeginInit();
            this.boxPlayer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playerSprite2)).BeginInit();
            this.boxPlayer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playerSprite3)).BeginInit();
            this.boxPlayer6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playerSprite6)).BeginInit();
            this.boxPlayer5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playerSprite5)).BeginInit();
            this.boxPlayer4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playerSprite4)).BeginInit();
            this.boxPlayer9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playerSprite9)).BeginInit();
            this.boxPlayer8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playerSprite8)).BeginInit();
            this.boxPlayer7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playerSprite7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stageIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            // 
            // boxPlayer1
            // 
            this.boxPlayer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.boxPlayer1.Controls.Add(this.btnToTarget1);
            this.boxPlayer1.Controls.Add(this.playerSprite1);
            this.boxPlayer1.ForeColor = System.Drawing.SystemColors.Control;
            this.boxPlayer1.Location = new System.Drawing.Point(355, 12);
            this.boxPlayer1.Name = "boxPlayer1";
            this.boxPlayer1.Size = new System.Drawing.Size(163, 193);
            this.boxPlayer1.TabIndex = 0;
            this.boxPlayer1.TabStop = false;
            this.boxPlayer1.Text = "Player 1";
            // 
            // btnToTarget1
            // 
            this.btnToTarget1.BackColor = System.Drawing.Color.Black;
            this.btnToTarget1.Location = new System.Drawing.Point(6, 164);
            this.btnToTarget1.Name = "btnToTarget1";
            this.btnToTarget1.Size = new System.Drawing.Size(150, 23);
            this.btnToTarget1.TabIndex = 1;
            this.btnToTarget1.Text = "Use Ability ";
            this.btnToTarget1.UseVisualStyleBackColor = false;
            this.btnToTarget1.Click += new System.EventHandler(this.btnToTarget1_Click);
            // 
            // playerSprite1
            // 
            this.playerSprite1.Location = new System.Drawing.Point(6, 19);
            this.playerSprite1.Name = "playerSprite1";
            this.playerSprite1.Size = new System.Drawing.Size(150, 150);
            this.playerSprite1.TabIndex = 0;
            this.playerSprite1.TabStop = false;
            // 
            // boxPlayer2
            // 
            this.boxPlayer2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.boxPlayer2.Controls.Add(this.btnToTarget2);
            this.boxPlayer2.Controls.Add(this.playerSprite2);
            this.boxPlayer2.ForeColor = System.Drawing.Color.White;
            this.boxPlayer2.Location = new System.Drawing.Point(524, 12);
            this.boxPlayer2.Name = "boxPlayer2";
            this.boxPlayer2.Size = new System.Drawing.Size(165, 193);
            this.boxPlayer2.TabIndex = 2;
            this.boxPlayer2.TabStop = false;
            this.boxPlayer2.Text = "Player 2";
            // 
            // btnToTarget2
            // 
            this.btnToTarget2.BackColor = System.Drawing.Color.Black;
            this.btnToTarget2.Location = new System.Drawing.Point(6, 164);
            this.btnToTarget2.Name = "btnToTarget2";
            this.btnToTarget2.Size = new System.Drawing.Size(150, 23);
            this.btnToTarget2.TabIndex = 1;
            this.btnToTarget2.Text = "Use Ability ";
            this.btnToTarget2.UseVisualStyleBackColor = false;
            this.btnToTarget2.Click += new System.EventHandler(this.btnToTarget2_Click);
            // 
            // playerSprite2
            // 
            this.playerSprite2.Location = new System.Drawing.Point(6, 19);
            this.playerSprite2.Name = "playerSprite2";
            this.playerSprite2.Size = new System.Drawing.Size(150, 150);
            this.playerSprite2.TabIndex = 0;
            this.playerSprite2.TabStop = false;
            // 
            // boxPlayer3
            // 
            this.boxPlayer3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.boxPlayer3.Controls.Add(this.btnToTarget3);
            this.boxPlayer3.Controls.Add(this.playerSprite3);
            this.boxPlayer3.ForeColor = System.Drawing.Color.White;
            this.boxPlayer3.Location = new System.Drawing.Point(695, 12);
            this.boxPlayer3.Name = "boxPlayer3";
            this.boxPlayer3.Size = new System.Drawing.Size(165, 193);
            this.boxPlayer3.TabIndex = 2;
            this.boxPlayer3.TabStop = false;
            this.boxPlayer3.Text = "Player 3";
            // 
            // btnToTarget3
            // 
            this.btnToTarget3.BackColor = System.Drawing.Color.Black;
            this.btnToTarget3.Location = new System.Drawing.Point(6, 164);
            this.btnToTarget3.Name = "btnToTarget3";
            this.btnToTarget3.Size = new System.Drawing.Size(150, 23);
            this.btnToTarget3.TabIndex = 1;
            this.btnToTarget3.Text = "Use Ability ";
            this.btnToTarget3.UseVisualStyleBackColor = false;
            this.btnToTarget3.Click += new System.EventHandler(this.btnToTarget3_Click);
            // 
            // playerSprite3
            // 
            this.playerSprite3.Location = new System.Drawing.Point(6, 19);
            this.playerSprite3.Name = "playerSprite3";
            this.playerSprite3.Size = new System.Drawing.Size(150, 150);
            this.playerSprite3.TabIndex = 0;
            this.playerSprite3.TabStop = false;
            // 
            // boxPlayer6
            // 
            this.boxPlayer6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.boxPlayer6.Controls.Add(this.btnToTarget6);
            this.boxPlayer6.Controls.Add(this.playerSprite6);
            this.boxPlayer6.ForeColor = System.Drawing.Color.White;
            this.boxPlayer6.Location = new System.Drawing.Point(695, 211);
            this.boxPlayer6.Name = "boxPlayer6";
            this.boxPlayer6.Size = new System.Drawing.Size(165, 193);
            this.boxPlayer6.TabIndex = 5;
            this.boxPlayer6.TabStop = false;
            this.boxPlayer6.Text = "Player 6";
            // 
            // btnToTarget6
            // 
            this.btnToTarget6.BackColor = System.Drawing.Color.Black;
            this.btnToTarget6.Location = new System.Drawing.Point(6, 164);
            this.btnToTarget6.Name = "btnToTarget6";
            this.btnToTarget6.Size = new System.Drawing.Size(150, 23);
            this.btnToTarget6.TabIndex = 1;
            this.btnToTarget6.Text = "Use Ability ";
            this.btnToTarget6.UseVisualStyleBackColor = false;
            this.btnToTarget6.Click += new System.EventHandler(this.btnToTarget6_Click);
            // 
            // playerSprite6
            // 
            this.playerSprite6.Location = new System.Drawing.Point(6, 19);
            this.playerSprite6.Name = "playerSprite6";
            this.playerSprite6.Size = new System.Drawing.Size(150, 150);
            this.playerSprite6.TabIndex = 0;
            this.playerSprite6.TabStop = false;
            // 
            // boxPlayer5
            // 
            this.boxPlayer5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.boxPlayer5.Controls.Add(this.btnToTarget5);
            this.boxPlayer5.Controls.Add(this.playerSprite5);
            this.boxPlayer5.ForeColor = System.Drawing.Color.White;
            this.boxPlayer5.Location = new System.Drawing.Point(524, 211);
            this.boxPlayer5.Name = "boxPlayer5";
            this.boxPlayer5.Size = new System.Drawing.Size(165, 193);
            this.boxPlayer5.TabIndex = 4;
            this.boxPlayer5.TabStop = false;
            this.boxPlayer5.Text = "Player 5";
            // 
            // btnToTarget5
            // 
            this.btnToTarget5.BackColor = System.Drawing.Color.Black;
            this.btnToTarget5.Location = new System.Drawing.Point(6, 164);
            this.btnToTarget5.Name = "btnToTarget5";
            this.btnToTarget5.Size = new System.Drawing.Size(150, 23);
            this.btnToTarget5.TabIndex = 1;
            this.btnToTarget5.Text = "Use Ability ";
            this.btnToTarget5.UseVisualStyleBackColor = false;
            this.btnToTarget5.Click += new System.EventHandler(this.btnToTarget5_Click);
            // 
            // playerSprite5
            // 
            this.playerSprite5.Location = new System.Drawing.Point(6, 19);
            this.playerSprite5.Name = "playerSprite5";
            this.playerSprite5.Size = new System.Drawing.Size(150, 150);
            this.playerSprite5.TabIndex = 0;
            this.playerSprite5.TabStop = false;
            // 
            // boxPlayer4
            // 
            this.boxPlayer4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.boxPlayer4.Controls.Add(this.btnToTarget4);
            this.boxPlayer4.Controls.Add(this.playerSprite4);
            this.boxPlayer4.ForeColor = System.Drawing.Color.White;
            this.boxPlayer4.Location = new System.Drawing.Point(355, 211);
            this.boxPlayer4.Name = "boxPlayer4";
            this.boxPlayer4.Size = new System.Drawing.Size(163, 193);
            this.boxPlayer4.TabIndex = 3;
            this.boxPlayer4.TabStop = false;
            this.boxPlayer4.Text = "Player 4";
            // 
            // btnToTarget4
            // 
            this.btnToTarget4.BackColor = System.Drawing.Color.Black;
            this.btnToTarget4.Location = new System.Drawing.Point(6, 164);
            this.btnToTarget4.Name = "btnToTarget4";
            this.btnToTarget4.Size = new System.Drawing.Size(151, 23);
            this.btnToTarget4.TabIndex = 1;
            this.btnToTarget4.Text = "Use Ability ";
            this.btnToTarget4.UseVisualStyleBackColor = false;
            this.btnToTarget4.Click += new System.EventHandler(this.btnToTarget4_Click);
            // 
            // playerSprite4
            // 
            this.playerSprite4.Location = new System.Drawing.Point(6, 19);
            this.playerSprite4.Name = "playerSprite4";
            this.playerSprite4.Size = new System.Drawing.Size(150, 150);
            this.playerSprite4.TabIndex = 0;
            this.playerSprite4.TabStop = false;
            // 
            // boxPlayer9
            // 
            this.boxPlayer9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.boxPlayer9.Controls.Add(this.btnToTarget9);
            this.boxPlayer9.Controls.Add(this.playerSprite9);
            this.boxPlayer9.ForeColor = System.Drawing.Color.White;
            this.boxPlayer9.Location = new System.Drawing.Point(695, 410);
            this.boxPlayer9.Name = "boxPlayer9";
            this.boxPlayer9.Size = new System.Drawing.Size(165, 193);
            this.boxPlayer9.TabIndex = 5;
            this.boxPlayer9.TabStop = false;
            this.boxPlayer9.Text = "Player 9";
            // 
            // btnToTarget9
            // 
            this.btnToTarget9.BackColor = System.Drawing.Color.Black;
            this.btnToTarget9.Location = new System.Drawing.Point(6, 164);
            this.btnToTarget9.Name = "btnToTarget9";
            this.btnToTarget9.Size = new System.Drawing.Size(150, 23);
            this.btnToTarget9.TabIndex = 1;
            this.btnToTarget9.Text = "Use Ability ";
            this.btnToTarget9.UseVisualStyleBackColor = false;
            this.btnToTarget9.Click += new System.EventHandler(this.btnToTarget9_Click);
            // 
            // playerSprite9
            // 
            this.playerSprite9.Location = new System.Drawing.Point(6, 19);
            this.playerSprite9.Name = "playerSprite9";
            this.playerSprite9.Size = new System.Drawing.Size(150, 150);
            this.playerSprite9.TabIndex = 0;
            this.playerSprite9.TabStop = false;
            // 
            // boxPlayer8
            // 
            this.boxPlayer8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.boxPlayer8.Controls.Add(this.btnToTarget8);
            this.boxPlayer8.Controls.Add(this.playerSprite8);
            this.boxPlayer8.ForeColor = System.Drawing.Color.White;
            this.boxPlayer8.Location = new System.Drawing.Point(524, 410);
            this.boxPlayer8.Name = "boxPlayer8";
            this.boxPlayer8.Size = new System.Drawing.Size(165, 193);
            this.boxPlayer8.TabIndex = 4;
            this.boxPlayer8.TabStop = false;
            this.boxPlayer8.Text = "Player 8";
            // 
            // btnToTarget8
            // 
            this.btnToTarget8.BackColor = System.Drawing.Color.Black;
            this.btnToTarget8.Location = new System.Drawing.Point(6, 164);
            this.btnToTarget8.Name = "btnToTarget8";
            this.btnToTarget8.Size = new System.Drawing.Size(150, 23);
            this.btnToTarget8.TabIndex = 1;
            this.btnToTarget8.Text = "Use Ability ";
            this.btnToTarget8.UseVisualStyleBackColor = false;
            this.btnToTarget8.Click += new System.EventHandler(this.btnToTarget8_Click);
            // 
            // playerSprite8
            // 
            this.playerSprite8.Location = new System.Drawing.Point(6, 19);
            this.playerSprite8.Name = "playerSprite8";
            this.playerSprite8.Size = new System.Drawing.Size(150, 150);
            this.playerSprite8.TabIndex = 0;
            this.playerSprite8.TabStop = false;
            // 
            // boxPlayer7
            // 
            this.boxPlayer7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.boxPlayer7.Controls.Add(this.btnToTarget7);
            this.boxPlayer7.Controls.Add(this.playerSprite7);
            this.boxPlayer7.ForeColor = System.Drawing.Color.White;
            this.boxPlayer7.Location = new System.Drawing.Point(355, 410);
            this.boxPlayer7.Name = "boxPlayer7";
            this.boxPlayer7.Size = new System.Drawing.Size(163, 193);
            this.boxPlayer7.TabIndex = 3;
            this.boxPlayer7.TabStop = false;
            this.boxPlayer7.Text = "Player 7";
            // 
            // btnToTarget7
            // 
            this.btnToTarget7.BackColor = System.Drawing.Color.Black;
            this.btnToTarget7.Location = new System.Drawing.Point(6, 164);
            this.btnToTarget7.Name = "btnToTarget7";
            this.btnToTarget7.Size = new System.Drawing.Size(150, 23);
            this.btnToTarget7.TabIndex = 1;
            this.btnToTarget7.Text = "Use Ability ";
            this.btnToTarget7.UseVisualStyleBackColor = false;
            this.btnToTarget7.Click += new System.EventHandler(this.btnToTarget7_Click);
            // 
            // playerSprite7
            // 
            this.playerSprite7.Location = new System.Drawing.Point(6, 19);
            this.playerSprite7.Name = "playerSprite7";
            this.playerSprite7.Size = new System.Drawing.Size(150, 150);
            this.playerSprite7.TabIndex = 0;
            this.playerSprite7.TabStop = false;
            // 
            // roleTextbox
            // 
            this.roleTextbox.Location = new System.Drawing.Point(12, 283);
            this.roleTextbox.Name = "roleTextbox";
            this.roleTextbox.ReadOnly = true;
            this.roleTextbox.Size = new System.Drawing.Size(337, 320);
            this.roleTextbox.TabIndex = 6;
            this.roleTextbox.Text = resources.GetString("roleTextbox.Text");
            // 
            // eventTextbox
            // 
            this.eventTextbox.Location = new System.Drawing.Point(12, 85);
            this.eventTextbox.Name = "eventTextbox";
            this.eventTextbox.ReadOnly = true;
            this.eventTextbox.Size = new System.Drawing.Size(337, 96);
            this.eventTextbox.TabIndex = 7;
            this.eventTextbox.Text = "";
            // 
            // stageLabel
            // 
            this.stageLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.stageLabel.AutoSize = true;
            this.stageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stageLabel.Location = new System.Drawing.Point(146, 17);
            this.stageLabel.Name = "stageLabel";
            this.stageLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.stageLabel.Size = new System.Drawing.Size(70, 29);
            this.stageLabel.TabIndex = 8;
            this.stageLabel.Text = "Night";
            this.stageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // stageNumLabel
            // 
            this.stageNumLabel.AutoSize = true;
            this.stageNumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stageNumLabel.Location = new System.Drawing.Point(146, 46);
            this.stageNumLabel.Name = "stageNumLabel";
            this.stageNumLabel.Size = new System.Drawing.Size(26, 29);
            this.stageNumLabel.TabIndex = 9;
            this.stageNumLabel.Text = "1";
            // 
            // stageIcon
            // 
            this.stageIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.stageIcon.Image = global::DeceptionPalace.Properties.Resources.nightIcon;
            this.stageIcon.Location = new System.Drawing.Point(172, 50);
            this.stageIcon.Name = "stageIcon";
            this.stageIcon.Size = new System.Drawing.Size(38, 29);
            this.stageIcon.TabIndex = 10;
            this.stageIcon.TabStop = false;
            // 
            // btn1stRole
            // 
            this.btn1stRole.Location = new System.Drawing.Point(54, 211);
            this.btn1stRole.Name = "btn1stRole";
            this.btn1stRole.Size = new System.Drawing.Size(75, 36);
            this.btn1stRole.TabIndex = 11;
            this.btn1stRole.Text = "Choose Role 1";
            this.btn1stRole.UseVisualStyleBackColor = true;
            this.btn1stRole.Click += new System.EventHandler(this.btn1stRole_Click);
            // 
            // btn2ndRole
            // 
            this.btn2ndRole.Location = new System.Drawing.Point(135, 211);
            this.btn2ndRole.Name = "btn2ndRole";
            this.btn2ndRole.Size = new System.Drawing.Size(75, 36);
            this.btn2ndRole.TabIndex = 12;
            this.btn2ndRole.Text = "Choose Role 2";
            this.btn2ndRole.UseVisualStyleBackColor = true;
            this.btn2ndRole.Click += new System.EventHandler(this.btn2ndRole_Click);
            // 
            // btn3rdRole
            // 
            this.btn3rdRole.Location = new System.Drawing.Point(216, 211);
            this.btn3rdRole.Name = "btn3rdRole";
            this.btn3rdRole.Size = new System.Drawing.Size(75, 36);
            this.btn3rdRole.TabIndex = 13;
            this.btn3rdRole.Text = "Choose Role 3";
            this.btn3rdRole.UseVisualStyleBackColor = true;
            this.btn3rdRole.Click += new System.EventHandler(this.btn3rdRole_Click);
            // 
            // btnViewedKingsChoice
            // 
            this.btnViewedKingsChoice.Location = new System.Drawing.Point(112, 211);
            this.btnViewedKingsChoice.Name = "btnViewedKingsChoice";
            this.btnViewedKingsChoice.Size = new System.Drawing.Size(120, 39);
            this.btnViewedKingsChoice.TabIndex = 14;
            this.btnViewedKingsChoice.Text = "I have seen these results";
            this.btnViewedKingsChoice.UseVisualStyleBackColor = true;
            this.btnViewedKingsChoice.Click += new System.EventHandler(this.btnViewedKingsChoice_Click);
            // 
            // btnViewedPrelimResults
            // 
            this.btnViewedPrelimResults.Location = new System.Drawing.Point(112, 224);
            this.btnViewedPrelimResults.Name = "btnViewedPrelimResults";
            this.btnViewedPrelimResults.Size = new System.Drawing.Size(120, 23);
            this.btnViewedPrelimResults.TabIndex = 15;
            this.btnViewedPrelimResults.Text = "Proceed to execution";
            this.btnViewedPrelimResults.UseVisualStyleBackColor = true;
            this.btnViewedPrelimResults.Click += new System.EventHandler(this.btnViewedPrelimResults_Click);
            // 
            // btnBeginPrelim
            // 
            this.btnBeginPrelim.Location = new System.Drawing.Point(112, 218);
            this.btnBeginPrelim.Name = "btnBeginPrelim";
            this.btnBeginPrelim.Size = new System.Drawing.Size(120, 23);
            this.btnBeginPrelim.TabIndex = 16;
            this.btnBeginPrelim.Text = "Begin Preliminary Vote";
            this.btnBeginPrelim.UseVisualStyleBackColor = true;
            this.btnBeginPrelim.Click += new System.EventHandler(this.btnBeginPrelim_Click);
            // 
            // btnViewedSwitchResults
            // 
            this.btnViewedSwitchResults.Location = new System.Drawing.Point(112, 210);
            this.btnViewedSwitchResults.Name = "btnViewedSwitchResults";
            this.btnViewedSwitchResults.Size = new System.Drawing.Size(120, 39);
            this.btnViewedSwitchResults.TabIndex = 17;
            this.btnViewedSwitchResults.Text = "Proceed to Night";
            this.btnViewedSwitchResults.UseVisualStyleBackColor = true;
            this.btnViewedSwitchResults.Click += new System.EventHandler(this.btnViewedSwitchResults_Click);
            // 
            // mainGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(874, 617);
            this.Controls.Add(this.btnViewedSwitchResults);
            this.Controls.Add(this.btnBeginPrelim);
            this.Controls.Add(this.btnViewedPrelimResults);
            this.Controls.Add(this.btnViewedKingsChoice);
            this.Controls.Add(this.btn3rdRole);
            this.Controls.Add(this.btn2ndRole);
            this.Controls.Add(this.btn1stRole);
            this.Controls.Add(this.stageIcon);
            this.Controls.Add(this.stageNumLabel);
            this.Controls.Add(this.stageLabel);
            this.Controls.Add(this.eventTextbox);
            this.Controls.Add(this.roleTextbox);
            this.Controls.Add(this.boxPlayer9);
            this.Controls.Add(this.boxPlayer6);
            this.Controls.Add(this.boxPlayer8);
            this.Controls.Add(this.boxPlayer7);
            this.Controls.Add(this.boxPlayer3);
            this.Controls.Add(this.boxPlayer5);
            this.Controls.Add(this.boxPlayer2);
            this.Controls.Add(this.boxPlayer4);
            this.Controls.Add(this.boxPlayer1);
            this.Name = "mainGameForm";
            this.Text = "The Deception Palace";
            this.Load += new System.EventHandler(this.mainGameForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            this.boxPlayer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.playerSprite1)).EndInit();
            this.boxPlayer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.playerSprite2)).EndInit();
            this.boxPlayer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.playerSprite3)).EndInit();
            this.boxPlayer6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.playerSprite6)).EndInit();
            this.boxPlayer5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.playerSprite5)).EndInit();
            this.boxPlayer4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.playerSprite4)).EndInit();
            this.boxPlayer9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.playerSprite9)).EndInit();
            this.boxPlayer8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.playerSprite8)).EndInit();
            this.boxPlayer7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.playerSprite7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stageIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Diagnostics.EventLog eventLog1;
        public System.Windows.Forms.PictureBox stageIcon;
        public System.Windows.Forms.Label stageNumLabel;
        public System.Windows.Forms.Label stageLabel;
        public System.Windows.Forms.RichTextBox eventTextbox;
        private System.Windows.Forms.RichTextBox roleTextbox;
        private System.Windows.Forms.GroupBox boxPlayer9;
        private System.Windows.Forms.Button btnToTarget9;
        private System.Windows.Forms.PictureBox playerSprite9;
        private System.Windows.Forms.GroupBox boxPlayer6;
        private System.Windows.Forms.Button btnToTarget6;
        private System.Windows.Forms.PictureBox playerSprite6;
        private System.Windows.Forms.GroupBox boxPlayer8;
        private System.Windows.Forms.Button btnToTarget8;
        private System.Windows.Forms.PictureBox playerSprite8;
        private System.Windows.Forms.GroupBox boxPlayer7;
        private System.Windows.Forms.Button btnToTarget7;
        private System.Windows.Forms.PictureBox playerSprite7;
        private System.Windows.Forms.GroupBox boxPlayer3;
        private System.Windows.Forms.Button btnToTarget3;
        private System.Windows.Forms.PictureBox playerSprite3;
        private System.Windows.Forms.GroupBox boxPlayer5;
        private System.Windows.Forms.Button btnToTarget5;
        private System.Windows.Forms.PictureBox playerSprite5;
        private System.Windows.Forms.GroupBox boxPlayer2;
        private System.Windows.Forms.Button btnToTarget2;
        private System.Windows.Forms.PictureBox playerSprite2;
        private System.Windows.Forms.GroupBox boxPlayer4;
        private System.Windows.Forms.Button btnToTarget4;
        private System.Windows.Forms.PictureBox playerSprite4;
        private System.Windows.Forms.GroupBox boxPlayer1;
        private System.Windows.Forms.Button btnToTarget1;
        private System.Windows.Forms.PictureBox playerSprite1;
        private System.Windows.Forms.Button btn3rdRole;
        private System.Windows.Forms.Button btn2ndRole;
        private System.Windows.Forms.Button btn1stRole;
        public Button btnViewedPrelimResults;
        private Button btnViewedKingsChoice;
        public Button btnBeginPrelim;

        public System.Windows.Forms.GroupBox[] groupBoxArray = new System.Windows.Forms.GroupBox[9];//array holding the 9 group boxes for players so they can be referenced efficiently without using selection
        public System.Windows.Forms.PictureBox[] picBoxArray = new System.Windows.Forms.PictureBox[9];//array holding the 9 picture boxes for players so they can be referenced efficiently without using selection
        public System.Windows.Forms.Button[] buttonArray = new System.Windows.Forms.Button[9];//array holding the 9 buttons for players so they can be referenced efficiently without using selection
        private Game gamePlayed = new Game("Filler Host", "Filler Code");//iteration 1&2 instance of Game that is initialised immediately
        private Button btnViewedSwitchResults;
    }
}
