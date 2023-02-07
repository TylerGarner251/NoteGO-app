namespace NoteGO_app
{
    partial class settingsForm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Themelabel = new System.Windows.Forms.Label();
            this.DarkmodeButton = new System.Windows.Forms.RadioButton();
            this.LightmodeButton = new System.Windows.Forms.RadioButton();
            this.Postitnotebutton = new System.Windows.Forms.RadioButton();
            this.ApplyButtonS = new System.Windows.Forms.Button();
            this.CancelButtonS = new System.Windows.Forms.Button();
            this.SettingLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Themelabel
            // 
            this.Themelabel.AutoSize = true;
            this.Themelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Themelabel.Location = new System.Drawing.Point(3, 33);
            this.Themelabel.Name = "Themelabel";
            this.Themelabel.Size = new System.Drawing.Size(110, 20);
            this.Themelabel.TabIndex = 0;
            this.Themelabel.Text = "Theme option:";
            // 
            // DarkmodeButton
            // 
            this.DarkmodeButton.AutoSize = true;
            this.DarkmodeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DarkmodeButton.Location = new System.Drawing.Point(7, 56);
            this.DarkmodeButton.Name = "DarkmodeButton";
            this.DarkmodeButton.Size = new System.Drawing.Size(83, 19);
            this.DarkmodeButton.TabIndex = 1;
            this.DarkmodeButton.TabStop = true;
            this.DarkmodeButton.Text = "Darkmode";
            this.DarkmodeButton.UseVisualStyleBackColor = true;
            this.DarkmodeButton.CheckedChanged += new System.EventHandler(this.DarkmodeButton_CheckedChanged);
            // 
            // LightmodeButton
            // 
            this.LightmodeButton.AutoSize = true;
            this.LightmodeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LightmodeButton.Location = new System.Drawing.Point(7, 81);
            this.LightmodeButton.Name = "LightmodeButton";
            this.LightmodeButton.Size = new System.Drawing.Size(84, 19);
            this.LightmodeButton.TabIndex = 2;
            this.LightmodeButton.TabStop = true;
            this.LightmodeButton.Text = "Lightmode";
            this.LightmodeButton.UseVisualStyleBackColor = true;
            this.LightmodeButton.CheckedChanged += new System.EventHandler(this.LightmodeButton_CheckedChanged);
            // 
            // Postitnotebutton
            // 
            this.Postitnotebutton.AutoSize = true;
            this.Postitnotebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Postitnotebutton.Location = new System.Drawing.Point(7, 106);
            this.Postitnotebutton.Name = "Postitnotebutton";
            this.Postitnotebutton.Size = new System.Drawing.Size(88, 19);
            this.Postitnotebutton.TabIndex = 3;
            this.Postitnotebutton.TabStop = true;
            this.Postitnotebutton.Text = "Post-It Note";
            this.Postitnotebutton.UseVisualStyleBackColor = true;
            this.Postitnotebutton.CheckedChanged += new System.EventHandler(this.Postitnotebutton_CheckedChanged);
            // 
            // ApplyButtonS
            // 
            this.ApplyButtonS.Location = new System.Drawing.Point(7, 512);
            this.ApplyButtonS.Name = "ApplyButtonS";
            this.ApplyButtonS.Size = new System.Drawing.Size(75, 23);
            this.ApplyButtonS.TabIndex = 4;
            this.ApplyButtonS.Text = "Apply";
            this.ApplyButtonS.UseVisualStyleBackColor = true;
            this.ApplyButtonS.Click += new System.EventHandler(this.ApplyButtonS_Click);
            // 
            // CancelButtonS
            // 
            this.CancelButtonS.Location = new System.Drawing.Point(88, 512);
            this.CancelButtonS.Name = "CancelButtonS";
            this.CancelButtonS.Size = new System.Drawing.Size(75, 23);
            this.CancelButtonS.TabIndex = 5;
            this.CancelButtonS.Text = "Cancel";
            this.CancelButtonS.UseVisualStyleBackColor = true;
            this.CancelButtonS.Click += new System.EventHandler(this.CancelButtonS_Click);
            // 
            // SettingLabel
            // 
            this.SettingLabel.AutoSize = true;
            this.SettingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingLabel.Location = new System.Drawing.Point(38, 4);
            this.SettingLabel.Name = "SettingLabel";
            this.SettingLabel.Size = new System.Drawing.Size(89, 25);
            this.SettingLabel.TabIndex = 6;
            this.SettingLabel.Text = "Settings:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::NoteGO_app.Properties.Resources.icons8_gear_48_resized;
            this.pictureBox1.Location = new System.Drawing.Point(7, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 26);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // settingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.SettingLabel);
            this.Controls.Add(this.CancelButtonS);
            this.Controls.Add(this.ApplyButtonS);
            this.Controls.Add(this.Postitnotebutton);
            this.Controls.Add(this.LightmodeButton);
            this.Controls.Add(this.DarkmodeButton);
            this.Controls.Add(this.Themelabel);
            this.Name = "settingsForm";
            this.Size = new System.Drawing.Size(845, 538);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Themelabel;
        private System.Windows.Forms.RadioButton DarkmodeButton;
        private System.Windows.Forms.RadioButton LightmodeButton;
        private System.Windows.Forms.RadioButton Postitnotebutton;
        private System.Windows.Forms.Button ApplyButtonS;
        private System.Windows.Forms.Button CancelButtonS;
        private System.Windows.Forms.Label SettingLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
