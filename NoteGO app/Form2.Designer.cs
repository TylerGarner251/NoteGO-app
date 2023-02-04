namespace NoteGO_app
{
    partial class Settings
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
            this.DarkmodeButton = new System.Windows.Forms.Button();
            this.LightModeButton = new System.Windows.Forms.Button();
            this.PostitNoteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DarkmodeButton
            // 
            this.DarkmodeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DarkmodeButton.Location = new System.Drawing.Point(12, 12);
            this.DarkmodeButton.Name = "DarkmodeButton";
            this.DarkmodeButton.Size = new System.Drawing.Size(133, 36);
            this.DarkmodeButton.TabIndex = 0;
            this.DarkmodeButton.Text = "Darkmode";
            this.DarkmodeButton.UseVisualStyleBackColor = true;
            this.DarkmodeButton.Click += new System.EventHandler(this.DarkmodeButton_Click);
            // 
            // LightModeButton
            // 
            this.LightModeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LightModeButton.Location = new System.Drawing.Point(12, 54);
            this.LightModeButton.Name = "LightModeButton";
            this.LightModeButton.Size = new System.Drawing.Size(133, 36);
            this.LightModeButton.TabIndex = 1;
            this.LightModeButton.Text = "LightMode";
            this.LightModeButton.UseVisualStyleBackColor = true;
            this.LightModeButton.Click += new System.EventHandler(this.LightModeButton_Click);
            // 
            // PostitNoteButton
            // 
            this.PostitNoteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PostitNoteButton.Location = new System.Drawing.Point(12, 96);
            this.PostitNoteButton.Name = "PostitNoteButton";
            this.PostitNoteButton.Size = new System.Drawing.Size(133, 36);
            this.PostitNoteButton.TabIndex = 2;
            this.PostitNoteButton.Text = "Post-it Note";
            this.PostitNoteButton.UseVisualStyleBackColor = true;
            this.PostitNoteButton.Click += new System.EventHandler(this.PostitNoteButton_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(159, 142);
            this.Controls.Add(this.PostitNoteButton);
            this.Controls.Add(this.LightModeButton);
            this.Controls.Add(this.DarkmodeButton);
            this.Name = "Settings";
            this.Text = "Settings";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button DarkmodeButton;
        private System.Windows.Forms.Button LightModeButton;
        private System.Windows.Forms.Button PostitNoteButton;
    }
}