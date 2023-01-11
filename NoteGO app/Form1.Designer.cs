
namespace NoteGO_app
{
    partial class NoteForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NoteForm));
            this.TitleLabel = new System.Windows.Forms.Label();
            this.TitleBox = new System.Windows.Forms.TextBox();
            this.NotesLabel = new System.Windows.Forms.Label();
            this.NotesBox = new System.Windows.Forms.RichTextBox();
            this.Table = new System.Windows.Forms.DataGridView();
            this.MenuBar = new System.Windows.Forms.StatusStrip();
            this.Newbutton = new System.Windows.Forms.ToolStripSplitButton();
            this.SaveButton = new System.Windows.Forms.ToolStripSplitButton();
            this.ReadButton = new System.Windows.Forms.ToolStripSplitButton();
            this.DeleteButton = new System.Windows.Forms.ToolStripSplitButton();
            this.VisualButton = new System.Windows.Forms.ToolStripSplitButton();
            this.darkModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lightModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.positnoteModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.BackgroundWhite = new System.Windows.Forms.PictureBox();
            this.BackgroundCream = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Table)).BeginInit();
            this.MenuBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BackgroundWhite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackgroundCream)).BeginInit();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.TitleLabel.ForeColor = System.Drawing.Color.White;
            this.TitleLabel.Location = new System.Drawing.Point(12, 45);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(84, 17);
            this.TitleLabel.TabIndex = 1;
            this.TitleLabel.Text = "Note Title:";
            // 
            // TitleBox
            // 
            this.TitleBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.TitleBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleBox.ForeColor = System.Drawing.Color.White;
            this.TitleBox.Location = new System.Drawing.Point(102, 38);
            this.TitleBox.Name = "TitleBox";
            this.TitleBox.Size = new System.Drawing.Size(345, 29);
            this.TitleBox.TabIndex = 2;
            this.TitleBox.TextChanged += new System.EventHandler(this.TitleBox_TextChanged);
            // 
            // NotesLabel
            // 
            this.NotesLabel.AutoSize = true;
            this.NotesLabel.BackColor = System.Drawing.Color.Transparent;
            this.NotesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.NotesLabel.ForeColor = System.Drawing.Color.White;
            this.NotesLabel.Location = new System.Drawing.Point(12, 87);
            this.NotesLabel.Name = "NotesLabel";
            this.NotesLabel.Size = new System.Drawing.Size(141, 17);
            this.NotesLabel.TabIndex = 3;
            this.NotesLabel.Text = "Insert Notes Here:";
            this.NotesLabel.Click += new System.EventHandler(this.NotesLabel_Click);
            // 
            // NotesBox
            // 
            this.NotesBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.NotesBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NotesBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NotesBox.ForeColor = System.Drawing.Color.White;
            this.NotesBox.Location = new System.Drawing.Point(12, 107);
            this.NotesBox.Name = "NotesBox";
            this.NotesBox.Size = new System.Drawing.Size(435, 321);
            this.NotesBox.TabIndex = 4;
            this.NotesBox.Text = "";
            this.NotesBox.TextChanged += new System.EventHandler(this.NotesBox_TextChanged);
            // 
            // Table
            // 
            this.Table.AllowUserToAddRows = false;
            this.Table.AllowUserToDeleteRows = false;
            this.Table.AllowUserToResizeColumns = false;
            this.Table.AllowUserToResizeRows = false;
            this.Table.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Table.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Table.ColumnHeadersVisible = false;
            this.Table.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Table.Location = new System.Drawing.Point(456, 58);
            this.Table.MultiSelect = false;
            this.Table.Name = "Table";
            this.Table.ReadOnly = true;
            this.Table.RowHeadersVisible = false;
            this.Table.Size = new System.Drawing.Size(172, 370);
            this.Table.TabIndex = 5;
            this.Table.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Table_CellContentClick);
            // 
            // MenuBar
            // 
            this.MenuBar.BackColor = System.Drawing.Color.Gray;
            this.MenuBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.MenuBar.ImageScalingSize = new System.Drawing.Size(25, 25);
            this.MenuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Newbutton,
            this.SaveButton,
            this.ReadButton,
            this.DeleteButton,
            this.VisualButton});
            this.MenuBar.Location = new System.Drawing.Point(0, 0);
            this.MenuBar.Name = "MenuBar";
            this.MenuBar.Size = new System.Drawing.Size(635, 29);
            this.MenuBar.Stretch = false;
            this.MenuBar.TabIndex = 7;
            this.MenuBar.Text = "statusStrip1";
            this.MenuBar.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.MenuBar_ItemClicked);
            // 
            // Newbutton
            // 
            this.Newbutton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Newbutton.DropDownButtonWidth = 0;
            this.Newbutton.Image = global::NoteGO_app.Properties.Resources.icons8_note_96;
            this.Newbutton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Newbutton.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Newbutton.Name = "Newbutton";
            this.Newbutton.Size = new System.Drawing.Size(30, 29);
            this.Newbutton.Text = "toolStripSplitButton1";
            this.Newbutton.ButtonClick += new System.EventHandler(this.Newbutton_ButtonClick);
            // 
            // SaveButton
            // 
            this.SaveButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SaveButton.DropDownButtonWidth = 0;
            this.SaveButton.Image = global::NoteGO_app.Properties.Resources.icons8_floppy_disk_68;
            this.SaveButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SaveButton.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(30, 29);
            this.SaveButton.Text = "toolStripSplitButton2";
            this.SaveButton.ButtonClick += new System.EventHandler(this.SaveButton_ButtonClick);
            // 
            // ReadButton
            // 
            this.ReadButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ReadButton.DropDownButtonWidth = 0;
            this.ReadButton.Image = global::NoteGO_app.Properties.Resources.icons8_binocular_64;
            this.ReadButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ReadButton.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.ReadButton.Name = "ReadButton";
            this.ReadButton.Size = new System.Drawing.Size(30, 29);
            this.ReadButton.Text = "toolStripSplitButton1";
            this.ReadButton.ButtonClick += new System.EventHandler(this.ReadButton_ButtonClick);
            // 
            // DeleteButton
            // 
            this.DeleteButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DeleteButton.DropDownButtonWidth = 0;
            this.DeleteButton.Image = global::NoteGO_app.Properties.Resources.icons8_bin_62;
            this.DeleteButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DeleteButton.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(30, 29);
            this.DeleteButton.Text = "toolStripSplitButton1";
            this.DeleteButton.ButtonClick += new System.EventHandler(this.DeleteButton_ButtonClick);
            // 
            // VisualButton
            // 
            this.VisualButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.VisualButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.darkModeToolStripMenuItem,
            this.lightModeToolStripMenuItem,
            this.positnoteModeToolStripMenuItem});
            this.VisualButton.Image = global::NoteGO_app.Properties.Resources.icons8_gear_48;
            this.VisualButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.VisualButton.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.VisualButton.Name = "VisualButton";
            this.VisualButton.Size = new System.Drawing.Size(41, 29);
            this.VisualButton.Text = "VisualButton";
            this.VisualButton.ButtonClick += new System.EventHandler(this.VisualButton_ButtonClick);
            // 
            // darkModeToolStripMenuItem
            // 
            this.darkModeToolStripMenuItem.Name = "darkModeToolStripMenuItem";
            this.darkModeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.darkModeToolStripMenuItem.Text = "DarkMode";
            this.darkModeToolStripMenuItem.Click += new System.EventHandler(this.darkModeToolStripMenuItem_Click);
            // 
            // lightModeToolStripMenuItem
            // 
            this.lightModeToolStripMenuItem.Name = "lightModeToolStripMenuItem";
            this.lightModeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.lightModeToolStripMenuItem.Text = "LightMode";
            this.lightModeToolStripMenuItem.Click += new System.EventHandler(this.lightModeToolStripMenuItem_Click);
            // 
            // positnoteModeToolStripMenuItem
            // 
            this.positnoteModeToolStripMenuItem.Name = "positnoteModeToolStripMenuItem";
            this.positnoteModeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.positnoteModeToolStripMenuItem.Text = "Post-it Note Mode";
            this.positnoteModeToolStripMenuItem.Click += new System.EventHandler(this.positnoteModeToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(457, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Previous Notes:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // BackgroundWhite
            // 
            this.BackgroundWhite.Cursor = System.Windows.Forms.Cursors.Default;
            this.BackgroundWhite.Image = global::NoteGO_app.Properties.Resources.backgroundwhite;
            this.BackgroundWhite.Location = new System.Drawing.Point(-1, 30);
            this.BackgroundWhite.Name = "BackgroundWhite";
            this.BackgroundWhite.Size = new System.Drawing.Size(645, 412);
            this.BackgroundWhite.TabIndex = 9;
            this.BackgroundWhite.TabStop = false;
            this.BackgroundWhite.Visible = false;
            // 
            // BackgroundCream
            // 
            this.BackgroundCream.Cursor = System.Windows.Forms.Cursors.Default;
            this.BackgroundCream.Image = global::NoteGO_app.Properties.Resources.backgroundcream;
            this.BackgroundCream.Location = new System.Drawing.Point(-1, 30);
            this.BackgroundCream.Name = "BackgroundCream";
            this.BackgroundCream.Size = new System.Drawing.Size(645, 412);
            this.BackgroundCream.TabIndex = 10;
            this.BackgroundCream.TabStop = false;
            this.BackgroundCream.Visible = false;
            // 
            // NoteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImage = global::NoteGO_app.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(635, 438);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MenuBar);
            this.Controls.Add(this.Table);
            this.Controls.Add(this.NotesBox);
            this.Controls.Add(this.NotesLabel);
            this.Controls.Add(this.TitleBox);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.BackgroundWhite);
            this.Controls.Add(this.BackgroundCream);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(651, 477);
            this.MinimumSize = new System.Drawing.Size(651, 477);
            this.Name = "NoteForm";
            this.Text = "Notes";
            this.Load += new System.EventHandler(this.NoteForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Table)).EndInit();
            this.MenuBar.ResumeLayout(false);
            this.MenuBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BackgroundWhite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackgroundCream)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.TextBox TitleBox;
        private System.Windows.Forms.Label NotesLabel;
        private System.Windows.Forms.RichTextBox NotesBox;
        private System.Windows.Forms.DataGridView Table;
        private System.Windows.Forms.StatusStrip MenuBar;
        private System.Windows.Forms.ToolStripSplitButton Newbutton;
        private System.Windows.Forms.ToolStripSplitButton SaveButton;
        private System.Windows.Forms.ToolStripSplitButton DeleteButton;
        private System.Windows.Forms.ToolStripSplitButton ReadButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripSplitButton VisualButton;
        private System.Windows.Forms.ToolStripMenuItem darkModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lightModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem positnoteModeToolStripMenuItem;
        private System.Windows.Forms.PictureBox BackgroundWhite;
        private System.Windows.Forms.PictureBox BackgroundCream;
    }
}

