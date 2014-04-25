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
            this.submitRemoveSong = new System.Windows.Forms.Button();
            this.removeSongName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.navMenu.SuspendLayout();
            this.tabView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewSongsGrid)).BeginInit();
            this.tabAdd.SuspendLayout();
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
            this.tabAdd.Controls.Add(this.button2);
            this.tabAdd.Controls.Add(this.button1);
            this.tabAdd.Controls.Add(this.label9);
            this.tabAdd.Controls.Add(this.label8);
            this.tabAdd.Controls.Add(this.label7);
            this.tabAdd.Controls.Add(this.label6);
            this.tabAdd.Controls.Add(this.label5);
            this.tabAdd.Controls.Add(this.label4);
            this.tabAdd.Controls.Add(this.label3);
            this.tabAdd.Controls.Add(this.label2);
            this.tabAdd.Controls.Add(this.textBox8);
            this.tabAdd.Controls.Add(this.textBox7);
            this.tabAdd.Controls.Add(this.textBox6);
            this.tabAdd.Controls.Add(this.textBox5);
            this.tabAdd.Controls.Add(this.textBox4);
            this.tabAdd.Controls.Add(this.textBox3);
            this.tabAdd.Controls.Add(this.textBox2);
            this.tabAdd.Controls.Add(this.textBox1);
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
            // removeSongName
            // 
            this.removeSongName.Location = new System.Drawing.Point(77, 7);
            this.removeSongName.Name = "removeSongName";
            this.removeSongName.Size = new System.Drawing.Size(100, 20);
            this.removeSongName.TabIndex = 1;
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(83, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(161, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(83, 58);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(161, 20);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(83, 84);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(161, 20);
            this.textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(83, 110);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(161, 20);
            this.textBox4.TabIndex = 3;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(83, 136);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(161, 20);
            this.textBox5.TabIndex = 4;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(83, 162);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(161, 20);
            this.textBox6.TabIndex = 5;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(83, 188);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(161, 20);
            this.textBox7.TabIndex = 6;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(83, 214);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(161, 20);
            this.textBox8.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "ArtistID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "ComposerID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "GenreID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 162);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Year";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 188);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "PriceID";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(240, 24);
            this.label9.TabIndex = 15;
            this.label9.Text = "Enter information for song...";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 240);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 21);
            this.button1.TabIndex = 16;
            this.button1.Text = "Add New Song";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(139, 240);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 21);
            this.button2.TabIndex = 17;
            this.button2.Text = "Update Song";
            this.button2.UseVisualStyleBackColor = true;
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
            this.tabAdd.ResumeLayout(false);
            this.tabAdd.PerformLayout();
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}

