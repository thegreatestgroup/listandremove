
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Finale
{
    public partial class Form1 : Form
    {
        private static Operations mHandle;
        public System.Data.DataTable searchResults = new DataTable();

        /**
         * Constructor for the form
         */
        public Form1()
        {
            InitializeComponent();

            mHandle = new Operations();

            #region Display All Songs

            viewSongsGrid.ReadOnly = true;
            viewSongsGrid.DataSource = mHandle.viewSongs();

            #endregion

            #region Search

            SearchGrid.ReadOnly = true;
            SearchGrid.DataSource = searchResults;




            #endregion
        }

        /**
         * Method invoked by the user clicking the remove song button
         *
         * @param object sender
         * @param EventArgs e
         */
        private void submitRemoveSong_Click(object sender, EventArgs e)
        {
            #region Remove Song

            if (removeSongName.Text.ToString() == "")
            {
                MessageBox.Show("Error: You must enter a song name!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                mHandle.removeSong(removeSongName.Text.ToString());

                MessageBox.Show("The song " + removeSongName.Text.ToString() + " has been successfully removed.", "Song Removed", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }

            #endregion

            #region Update Display All Songs

            viewSongsGrid.ReadOnly = true;
            viewSongsGrid.DataSource = mHandle.viewSongs();

            #endregion
        }


        /*private void searchButton_Click(object sender, EventArgs e)
        {

           
        }*/

        private void searchButton_Click_1(object sender, EventArgs e)
        {
            var tempSong = new Song();

            #region Populate tempSong w/ Text Box Info
            if (songSearchTextBox.Text != "")
            {
                tempSong.Title.Value = songSearchTextBox.Text;
            }

            if (artistSearchTextBox.Text != "")
            {
                tempSong.Artist.Value = artistSearchTextBox.Text;
            }

            if (albumSearchTextBox.Text != "")
            {
                tempSong.Album.Value = albumSearchTextBox.Text;
            }
            #endregion

            searchResults = mHandle.searchSongs(tempSong);
            SearchGrid.DataSource = searchResults;
        }
    }
}
