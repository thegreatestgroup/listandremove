namespace Finale
{
    partial class Form1
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
			this.navMenu = new System.Windows.Forms.TabControl();
			this.tabView = new System.Windows.Forms.TabPage();
			this.viewSongsGrid = new System.Windows.Forms.DataGridView();
			this.tabSearch = new System.Windows.Forms.TabPage();
			this.tabAdd = new System.Windows.Forms.TabPage();
			this.tabRemove = new System.Windows.Forms.TabPage();
			this.label1 = new System.Windows.Forms.Label();
			this.removeSongName = new System.Windows.Forms.TextBox();
			this.submitRemoveSong = new System.Windows.Forms.Button();
			this.navMenu.SuspendLayout();
			this.tabView.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.viewSongsGrid)).BeginInit();
			this.tabRemove.SuspendLayout();
			this.SuspendLayout();
			// 
			// navMenu
			// 
			this.navMenu.Controls.Add(this.tabView);
			this.navMenu.Controls.Add(this.tabSearch);
			this.navMenu.Controls.Add(this.tabAdd);
			this.navMenu.Controls.Add(this.tabRemove);
			this.navMenu.Location = new System.Drawing.Point(13, 13);
			this.navMenu.Name = "navMenu";
			this.navMenu.SelectedIndex = 0;
			this.navMenu.Size = new System.Drawing.Size(1267, 619);
			this.navMenu.TabIndex = 0;
			// 
			// tabView
			// 
			this.tabView.Controls.Add(this.viewSongsGrid);
			this.tabView.Location = new System.Drawing.Point(4, 22);
			this.tabView.Name = "tabView";
			this.tabView.Padding = new System.Windows.Forms.Padding(3);
			this.tabView.Size = new System.Drawing.Size(1259, 593);
			this.tabView.TabIndex = 0;
			this.tabView.Text = "View Songs";
			this.tabView.UseVisualStyleBackColor = true;
			// 
			// viewSongsGrid
			// 
			this.viewSongsGrid.BackgroundColor = System.Drawing.SystemColors.ControlLight;
			this.viewSongsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.viewSongsGrid.Location = new System.Drawing.Point(7, 7);
			this.viewSongsGrid.Name = "viewSongsGrid";
			this.viewSongsGrid.Size = new System.Drawing.Size(1246, 580);
			this.viewSongsGrid.TabIndex = 0;
			// 
			// tabSearch
			// 
			this.tabSearch.Location = new System.Drawing.Point(4, 22);
			this.tabSearch.Name = "tabSearch";
			this.tabSearch.Padding = new System.Windows.Forms.Padding(3);
			this.tabSearch.Size = new System.Drawing.Size(1259, 593);
			this.tabSearch.TabIndex = 1;
			this.tabSearch.Text = "Search Songs";
			this.tabSearch.UseVisualStyleBackColor = true;
			// 
			// tabAdd
			// 
			this.tabAdd.Location = new System.Drawing.Point(4, 22);
			this.tabAdd.Name = "tabAdd";
			this.tabAdd.Padding = new System.Windows.Forms.Padding(3);
			this.tabAdd.Size = new System.Drawing.Size(1259, 593);
			this.tabAdd.TabIndex = 2;
			this.tabAdd.Text = "Add/Update Song";
			this.tabAdd.UseVisualStyleBackColor = true;
			// 
			// tabRemove
			// 
			this.tabRemove.Controls.Add(this.submitRemoveSong);
			this.tabRemove.Controls.Add(this.removeSongName);
			this.tabRemove.Controls.Add(this.label1);
			this.tabRemove.Location = new System.Drawing.Point(4, 22);
			this.tabRemove.Name = "tabRemove";
			this.tabRemove.Padding = new System.Windows.Forms.Padding(3);
			this.tabRemove.Size = new System.Drawing.Size(1259, 593);
			this.tabRemove.TabIndex = 3;
			this.tabRemove.Text = "Remove Song";
			this.tabRemove.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(7, 7);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(63, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Song Name";
			// 
			// removeSongName
			// 
			this.removeSongName.Location = new System.Drawing.Point(77, 7);
			this.removeSongName.Name = "removeSongName";
			this.removeSongName.Size = new System.Drawing.Size(100, 20);
			this.removeSongName.TabIndex = 1;
			// 
			// submitRemoveSong
			// 
			this.submitRemoveSong.Location = new System.Drawing.Point(42, 47);
			this.submitRemoveSong.Name = "submitRemoveSong";
			this.submitRemoveSong.Size = new System.Drawing.Size(75, 23);
			this.submitRemoveSong.TabIndex = 2;
			this.submitRemoveSong.Text = "Remove";
			this.submitRemoveSong.UseVisualStyleBackColor = true;
			this.submitRemoveSong.Click += new System.EventHandler(this.submitRemoveSong_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1292, 644);
			this.Controls.Add(this.navMenu);
			this.Name = "Form1";
			this.Text = "Form1";
			this.navMenu.ResumeLayout(false);
			this.tabView.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.viewSongsGrid)).EndInit();
			this.tabRemove.ResumeLayout(false);
			this.tabRemove.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl navMenu;
        private System.Windows.Forms.TabPage tabView;
        private System.Windows.Forms.TabPage tabSearch;
        private System.Windows.Forms.TabPage tabAdd;
        private System.Windows.Forms.TabPage tabRemove;
        private System.Windows.Forms.DataGridView viewSongsGrid;
		private System.Windows.Forms.Button submitRemoveSong;
		private System.Windows.Forms.TextBox removeSongName;
		private System.Windows.Forms.Label label1;
    }
}

