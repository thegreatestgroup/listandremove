
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finale
{
	class Operations
	{
		private SQLConnection mDB;

		/**
		 * Constructor for the operations manager
		 */
		public Operations()
		{
			// connect to the database
			mDB = new SQLConnection();
        }

		/**
		 * Display all songs in the database
		 * 
		 * @return DataTable
		 */
		public System.Data.DataTable viewSongs()
        {
			// query for feteching all songs
			string query = "SELECT Song.Name AS song, Album.Name AS album, Artist.Name AS artist, Composer.Name AS composer, Genre.Name AS genre, Song.Year AS year " +
						   "FROM Song " +
						   "INNER JOIN AlbumSong ON AlbumSong.SongID = Song.ID " +
						   "INNER JOIN Album ON Album.ID = AlbumSong.AlbumID " +
						   "INNER JOIN Artist ON Artist.ArtistID = Song.ArtistID " +
						   "INNER JOIN Composer ON Composer.ID = Song.ComposerID " +
						   "INNER JOIN Genre ON Genre.ID = Song.GenreID " +
						   "ORDER BY artist ASC";

			return mDB.execute("Song", query);
        }

		public System.Data.DataTable searchSongs()
		{
			// backend code for searching songs goes here

			return new System.Data.DataTable();
		}

		public void addSong()
		{
			// backend code for adding/updating a song goes here
		}

		/**
		 * Remove a song from the database
		 * 
		 * @param string songName
		 */
		public void removeSong(string songName)
		{
			// escape single quotes
			string temp = songName.Replace("'", "''");

			// query for fetching a song's id
			string getSongId = "SELECT Song.ID " +
							   "FROM Song " +
							   "WHERE Song.Name LIKE '" + temp + "'";

			System.Data.DataTable songID = mDB.execute("Song", getSongId);

			// query for removing a song
			string removeSong = "BEGIN TRY " +
								"BEGIN TRANSACTION " +

								"DELETE FROM AlbumSong " +
								"WHERE AlbumSong.SongID = " + songID.Rows[0]["ID"] + " " +

								"DELETE FROM Song " +
								"WHERE Song.ID = " + songID.Rows[0]["ID"] + " " +

								"COMMIT " +
								"END TRY " +
								"BEGIN CATCH " +
								"IF @@TRANCOUNT > 0 " +
								"ROLLBACK " +
								"END CATCH";

			System.Data.DataTable result = mDB.execute("null", removeSong);
		}
    }
}
