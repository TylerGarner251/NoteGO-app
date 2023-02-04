
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NoteForm));
            this.TitleLabel = new System.Windows.Forms.Label();
            this.TitleBox = new System.Windows.Forms.TextBox();
            this.NotesLabel = new System.Windows.Forms.Label();
            this.NotesBox = new System.Windows.Forms.RichTextBox();
            this.Table = new System.Windows.Forms.DataGridView();
            this.ReadButton = new System.Windows.Forms.ToolStripSplitButton();
            this.DeleteButton = new System.Windows.Forms.ToolStripSplitButton();
            this.VisualButton = new System.Windows.Forms.ToolStripSplitButton();
            this.visualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.darkModeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.lightModeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.postitNoteModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.Searchbar = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SearchPicture = new System.Windows.Forms.PictureBox();
            this.FontControl = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SettingButton = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.Newbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Table)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FontControl)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.TitleLabel.Font = new System.Drawing.Font("MV Boli", 14.25F);
            this.TitleLabel.ForeColor = System.Drawing.Color.White;
            this.TitleLabel.Location = new System.Drawing.Point(179, 1);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(113, 25);
            this.TitleLabel.TabIndex = 1;
            this.TitleLabel.Text = "Note Title:";
            // 
            // TitleBox
            // 
            this.TitleBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TitleBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TitleBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TitleBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleBox.ForeColor = System.Drawing.Color.White;
            this.TitleBox.Location = new System.Drawing.Point(292, 1);
            this.TitleBox.Name = "TitleBox";
            this.TitleBox.Size = new System.Drawing.Size(513, 25);
            this.TitleBox.TabIndex = 2;
            this.TitleBox.TextChanged += new System.EventHandler(this.TitleBox_TextChanged);
            // 
            // NotesLabel
            // 
            this.NotesLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NotesLabel.AutoSize = true;
            this.NotesLabel.BackColor = System.Drawing.Color.Transparent;
            this.NotesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.NotesLabel.ForeColor = System.Drawing.Color.White;
            this.NotesLabel.Location = new System.Drawing.Point(188, 29);
            this.NotesLabel.Name = "NotesLabel";
            this.NotesLabel.Size = new System.Drawing.Size(141, 17);
            this.NotesLabel.TabIndex = 3;
            this.NotesLabel.Text = "Insert Notes Here:";
            this.NotesLabel.Click += new System.EventHandler(this.NotesLabel_Click);
            // 
            // NotesBox
            // 
            this.NotesBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NotesBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.NotesBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NotesBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NotesBox.ForeColor = System.Drawing.Color.White;
            this.NotesBox.Location = new System.Drawing.Point(184, 45);
            this.NotesBox.Name = "NotesBox";
            this.NotesBox.Size = new System.Drawing.Size(621, 493);
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
            this.Table.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Table.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Table.ColumnHeadersVisible = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Table.DefaultCellStyle = dataGridViewCellStyle1;
            this.Table.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Table.Location = new System.Drawing.Point(7, 252);
            this.Table.MultiSelect = false;
            this.Table.Name = "Table";
            this.Table.ReadOnly = true;
            this.Table.RowHeadersVisible = false;
            this.Table.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.Table.Size = new System.Drawing.Size(172, 283);
            this.Table.TabIndex = 5;
            this.Table.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Table_CellContentClick);
            // 
            // ReadButton
            // 
            this.ReadButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ReadButton.DropDownButtonWidth = 0;
            this.ReadButton.Image = ((System.Drawing.Image)(resources.GetObject("ReadButton.Image")));
            this.ReadButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ReadButton.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.ReadButton.Name = "ReadButton";
            this.ReadButton.Size = new System.Drawing.Size(35, 34);
            this.ReadButton.Text = "ReadMenu";
            this.ReadButton.ToolTipText = "Read";
            this.ReadButton.ButtonClick += new System.EventHandler(this.ReadButton_ButtonClick);
            // 
            // DeleteButton
            // 
            this.DeleteButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DeleteButton.DropDownButtonWidth = 0;
            this.DeleteButton.Image = ((System.Drawing.Image)(resources.GetObject("DeleteButton.Image")));
            this.DeleteButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DeleteButton.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(35, 34);
            this.DeleteButton.Text = "BinMenu";
            this.DeleteButton.ToolTipText = "Bin";
            // 
            // VisualButton
            // 
            this.VisualButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.VisualButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.visualToolStripMenuItem,
            this.exportToolStripMenuItem,
            this.importToolStripMenuItem});
            this.VisualButton.Image = ((System.Drawing.Image)(resources.GetObject("VisualButton.Image")));
            this.VisualButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.VisualButton.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.VisualButton.Name = "VisualButton";
            this.VisualButton.Size = new System.Drawing.Size(46, 34);
            this.VisualButton.Text = "SettingsMenu";
            this.VisualButton.ToolTipText = "Settings";
            this.VisualButton.ButtonClick += new System.EventHandler(this.VisualButton_ButtonClick);
            // 
            // visualToolStripMenuItem
            // 
            this.visualToolStripMenuItem.Name = "visualToolStripMenuItem";
            this.visualToolStripMenuItem.Size = new System.Drawing.Size(67, 22);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(67, 22);
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(67, 22);
            // 
            // darkModeToolStripMenuItem1
            // 
            this.darkModeToolStripMenuItem1.Name = "darkModeToolStripMenuItem1";
            this.darkModeToolStripMenuItem1.Size = new System.Drawing.Size(32, 19);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // lightModeToolStripMenuItem1
            // 
            this.lightModeToolStripMenuItem1.Name = "lightModeToolStripMenuItem1";
            this.lightModeToolStripMenuItem1.Size = new System.Drawing.Size(32, 19);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // postitNoteModeToolStripMenuItem
            // 
            this.postitNoteModeToolStripMenuItem.Name = "postitNoteModeToolStripMenuItem";
            this.postitNoteModeToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(4, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Previous Notes:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Searchbar
            // 
            this.Searchbar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Searchbar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Searchbar.Location = new System.Drawing.Point(35, 198);
            this.Searchbar.Name = "Searchbar";
            this.Searchbar.Size = new System.Drawing.Size(144, 29);
            this.Searchbar.TabIndex = 11;
            this.Searchbar.TextChanged += new System.EventHandler(this.Searchbar_TextChanged);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // SearchPicture
            // 
            this.SearchPicture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchPicture.BackColor = System.Drawing.Color.White;
            this.SearchPicture.BackgroundImage = global::NoteGO_app.Properties.Resources.magnifying_glass1;
            this.SearchPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.SearchPicture.Location = new System.Drawing.Point(7, 198);
            this.SearchPicture.Name = "SearchPicture";
            this.SearchPicture.Size = new System.Drawing.Size(33, 28);
            this.SearchPicture.TabIndex = 12;
            this.SearchPicture.TabStop = false;
            // 
            // FontControl
            // 
            this.FontControl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FontControl.AutoSize = true;
            this.FontControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FontControl.Location = new System.Drawing.Point(132, 160);
            this.FontControl.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.FontControl.Minimum = new decimal(new int[] {
            14,
            0,
            0,
            0});
            this.FontControl.Name = "FontControl";
            this.FontControl.Size = new System.Drawing.Size(46, 29);
            this.FontControl.TabIndex = 13;
            this.FontControl.Value = new decimal(new int[] {
            14,
            0,
            0,
            0});
            this.FontControl.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Font = new System.Drawing.Font("MV Boli", 14.25F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(27, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 25);
            this.label2.TabIndex = 14;
            this.label2.Text = "Font Size";
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.SettingButton);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.RemoveButton);
            this.panel1.Controls.Add(this.FontControl);
            this.panel1.Controls.Add(this.SearchPicture);
            this.panel1.Controls.Add(this.SaveButton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Newbutton);
            this.panel1.Controls.Add(this.Table);
            this.panel1.Controls.Add(this.Searchbar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(182, 538);
            this.panel1.TabIndex = 15;
            // 
            // SettingButton
            // 
            this.SettingButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SettingButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SettingButton.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.SettingButton.FlatAppearance.BorderSize = 0;
            this.SettingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingButton.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingButton.ForeColor = System.Drawing.Color.White;
            this.SettingButton.Image = global::NoteGO_app.Properties.Resources.icons8_gear_48_resized;
            this.SettingButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SettingButton.Location = new System.Drawing.Point(3, 120);
            this.SettingButton.Name = "SettingButton";
            this.SettingButton.Size = new System.Drawing.Size(176, 34);
            this.SettingButton.TabIndex = 19;
            this.SettingButton.Text = "Settings";
            this.SettingButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SettingButton.UseVisualStyleBackColor = false;
            this.SettingButton.Click += new System.EventHandler(this.SettingButton_Click);
            // 
            // RemoveButton
            // 
            this.RemoveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.RemoveButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.RemoveButton.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.RemoveButton.FlatAppearance.BorderSize = 0;
            this.RemoveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveButton.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveButton.ForeColor = System.Drawing.Color.White;
            this.RemoveButton.Image = ((System.Drawing.Image)(resources.GetObject("RemoveButton.Image")));
            this.RemoveButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RemoveButton.Location = new System.Drawing.Point(3, 80);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(176, 34);
            this.RemoveButton.TabIndex = 18;
            this.RemoveButton.Text = "Remove Note";
            this.RemoveButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RemoveButton.UseVisualStyleBackColor = false;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SaveButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SaveButton.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.SaveButton.FlatAppearance.BorderSize = 0;
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveButton.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.ForeColor = System.Drawing.Color.White;
            this.SaveButton.Image = ((System.Drawing.Image)(resources.GetObject("SaveButton.Image")));
            this.SaveButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SaveButton.Location = new System.Drawing.Point(3, 40);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(176, 34);
            this.SaveButton.TabIndex = 17;
            this.SaveButton.Text = "Save Note";
            this.SaveButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // Newbutton
            // 
            this.Newbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Newbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Newbutton.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.Newbutton.FlatAppearance.BorderSize = 0;
            this.Newbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Newbutton.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Newbutton.ForeColor = System.Drawing.Color.White;
            this.Newbutton.Image = ((System.Drawing.Image)(resources.GetObject("Newbutton.Image")));
            this.Newbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Newbutton.Location = new System.Drawing.Point(3, 3);
            this.Newbutton.Name = "Newbutton";
            this.Newbutton.Size = new System.Drawing.Size(176, 34);
            this.Newbutton.TabIndex = 16;
            this.Newbutton.Text = "New Note";
            this.Newbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Newbutton.UseVisualStyleBackColor = false;
            this.Newbutton.Click += new System.EventHandler(this.Newbutton_Click);
            // 
            // NoteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(804, 538);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.NotesBox);
            this.Controls.Add(this.NotesLabel);
            this.Controls.Add(this.TitleBox);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimumSize = new System.Drawing.Size(820, 577);
            this.Name = "NoteForm";
            this.Text = " ";
            this.Load += new System.EventHandler(this.NoteForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Table)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FontControl)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.TextBox TitleBox;
        private System.Windows.Forms.Label NotesLabel;
        private System.Windows.Forms.RichTextBox NotesBox;
        private System.Windows.Forms.DataGridView Table;
        private System.Windows.Forms.ToolStripSplitButton DeleteButton;
        private System.Windows.Forms.ToolStripSplitButton ReadButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripSplitButton VisualButton;
        private System.Windows.Forms.TextBox Searchbar;
        private System.Windows.Forms.ToolStripMenuItem visualToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem darkModeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem lightModeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem postitNoteModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox SearchPicture;
        private System.Windows.Forms.NumericUpDown FontControl;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Newbutton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Button SettingButton;
    }
}

