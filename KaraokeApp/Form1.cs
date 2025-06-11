using AxWMPLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KaraokeApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Initial volume level
            trackBar1.Value = 50;
            lbl_volume.Text = trackBar1.Value.ToString() + "%";

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Artist and song info
            lbl_songInfo.Text = "Artist\nSong";


            // Controls menu hide on WMP
            player.uiMode = "none";
            player.enableContextMenu = false;


            // Check for the end of the song **
            // player.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(player_PlayStateChange);
        }


        string[] paths, files;

        // Adding tracks to array
        /*
        private void btn_open_Click(object sender, EventArgs e) {
             OpenFileDialog ofd = new OpenFileDialog();
             ofd.Multiselect = true;

             if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
             {
                 files = ofd.SafeFileNames;
                 paths = ofd.FileNames;

                 for (int x = 0; x < files.Length; x++)
                 {
                     track_list.Items.Add(files[x]);
                 }
             }
         }
        */


        // Adding tracks to list
        private void btn_open_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Audio Files (*.mp3;*.wav;*.wma)|*.mp3;*.wav;*.wma";
            ofd.Multiselect = true;

            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                // Check for duplicates before adding
                foreach (string file in ofd.SafeFileNames)
                {
                    if (!track_list.Items.Contains(file))
                    {
                        track_list.Items.Add(file);
                    }
                    else
                    {
                        MessageBox.Show($"The song '{file}' is already in the list.", "Duplicate Song", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }

                // Update paths and files arrays
                // Create a new list to avoid duplicates
                List<string> tempPaths = new List<string>(paths ?? Array.Empty<string>());
                List<string> tempFiles = new List<string>(files ?? Array.Empty<string>());

                foreach (string path in ofd.FileNames)
                {
                    if (!tempPaths.Contains(path))
                    {
                        tempPaths.Add(path);
                    }
                }

                foreach (string file in ofd.SafeFileNames)
                {
                    if (!tempFiles.Contains(file))
                    {
                        tempFiles.Add(file);
                    }
                }

                // Update the original arrays with unique paths and files
                paths = tempPaths.ToArray();
                files = tempFiles.ToArray();
            }
        }

        // Track list
        private void track_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Reset repeat when changing song
            isRepeatEnabled = false;
            btn_repeat.BackColor = Color.Black;

            // Ensure that a valid item is selected
            if (track_list.SelectedIndex < 0)
                return;

            // The selected song should start playing if it's clicked in the track list
            player.URL = paths[track_list.SelectedIndex]; 
            player.Ctlcontrols.play();
            lbl_msg.Text = "Playing...";


            // Reset lyrics before playback
            lyrics.Clear();
            //lbl_lyrics.Text = "";

            // Start the timer for the song
            timer1.Start();

            // Returns the volume to 20% whenever the song is changed
            // trackBar1.Value = 20;
            // lbl_volume.Text = trackBar1.Value.ToString() + "%";

            // Extract and display artist and song title
            string fileName = files[track_list.SelectedIndex];
            string[] songInfo = fileName.Split(new string[] { " - " }, StringSplitOptions.None);

            if (songInfo.Length == 2)
            {
                lbl_songInfo.Text = $"{songInfo[0]}\n{songInfo[1].Replace(".mp3", "").Trim()}";
            }
            else
            {
                lbl_songInfo.Text = "Unknown Artist\nUnknown Title";
            }

            // Clears lyrics when a new song is played
            lbl_lyrics.Text = "";

            // Check if lyrics exist for this song, otherwise clear
            if (lyrics.Count == 0)
            {
                lbl_lyrics.Text = "";
            }
        }


        // Buttons
        // Play button
        private void btn_play_Click(object sender, EventArgs e)
        {
            player.Ctlcontrols.play();
            lbl_msg.Text = "Playing...";

        }

        // Repeat button
        private bool isRepeatEnabled = false;
        private void btn_repeat_Click(object sender, EventArgs e)
        {
            // Toggle repeat mode
            isRepeatEnabled = !isRepeatEnabled;

            if (isRepeatEnabled)
            {
                // Change color if repeat is pressed (Repeat: On)
                btn_repeat.BackColor = Color.Gray;

            }
            else
            {
                // Reset color (Repeat: Off)
                btn_repeat.BackColor = Color.Black; 
            }
        }

        // Pause button
        private void btn_pause_Click(object sender, EventArgs e)
        {
            player.Ctlcontrols.pause();
            lbl_msg.Text = "Pause";
        }

        // Stop button
        private void btn_stop_Click(object sender, EventArgs e)
        {
            player.Ctlcontrols.stop();
            lbl_msg.Text = "Stop";
        }

        // Next button
        private void btn_next_Click(object sender, EventArgs e)
        {
            // If it there is a next songs switch to the next
            if (track_list.SelectedIndex < track_list.Items.Count - 1)
            {
                track_list.SelectedIndex = track_list.SelectedIndex + 1;
            }

            // When changing next song disable repeat
            isRepeatEnabled = false;
            btn_repeat.BackColor = Color.Black;

            // Whenever you switch to the next song the volume bar goes to 20%
            // player.settings.volume = trackBar1.Value;

        }

        // Previous button
        private void btn_prev_Click(object sender, EventArgs e)
        {
            // If there is a previous song, switch to previous
            if (track_list.SelectedIndex > 0)
            {
                track_list.SelectedIndex = track_list.SelectedIndex - 1;
            }

            // Disable repeat button when going to previous song
            isRepeatEnabled = false;
            btn_repeat.BackColor = Color.Black;

            // Whenever you switch to the previous song the volume bar goes to 20%
            // player.settings.volume = trackBar1.Value;
        }

        // Timer
        private void timer1_Tick(object sender, EventArgs e)
        {
            //  Progress bar
            if (player.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                // Progress bar duration and position are based on the selected(played) song
                progressBar1.Maximum = (int)player.Ctlcontrols.currentItem.duration;
                progressBar1.Value = (int)player.Ctlcontrols.currentPosition;

                // The current time, and ending time of the song are updated 
                lbl_track_start.Text = player.Ctlcontrols.currentPositionString;
                lbl_track_end.Text = player.Ctlcontrols.currentItem.durationString.ToString();

                // If the position is at the end and the repeat button is pressed than repeat the song
                if (player.Ctlcontrols.currentPosition >= player.Ctlcontrols.currentItem.duration - 1 && isRepeatEnabled)
                {
                    // Restart from the beginning
                    player.Ctlcontrols.currentPosition = 0;
                    // Replay the song
                    player.Ctlcontrols.play();
                }

                // Update lyrics display
                UpdateLyrics(player.Ctlcontrols.currentPosition);
            }
            else if (player.playState == WMPLib.WMPPlayState.wmppsStopped)
            {
                // Clear lyrics when song ends
                lbl_lyrics.Text = "";
                lyrics.Clear();
            }
            else
            {
                lbl_lyrics.Text = ""; // Hide lyrics when song stops
            }
        }

        // Update the lyrics based on the song time
        private void UpdateLyrics(double currentTime)
        {
            string currentLyric = "";

            for (int i = 0; i < lyrics.Count; i++)
            {
                if (currentTime >= lyrics[i].Time)
                {
                    currentLyric = lyrics[i].Line;
                }
                else
                {
                    break; // Stop searching once past the current time
                }
            }

            lbl_lyrics.Text = currentLyric;
        }

        // Volume bar scroll
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            player.settings.volume = trackBar1.Value;
            lbl_volume.Text = trackBar1.Value.ToString() + "%";
        }

        //Prorgess bar
        private void progressBar1_MouseDown(object sender, MouseEventArgs e)
        {
            // Prevent seeking if no song is loaded or playing
            if (player.currentMedia == null || player.playState != WMPLib.WMPPlayState.wmppsPlaying)
            {
                return;
            }

            // Move around the song on the progress bar
            player.Ctlcontrols.currentPosition = player.currentMedia.duration * e.X / progressBar1.Width;
        }


        //Lyrics
        //Lyrics list
        private List<(double Time, string Line)> lyrics = new List<(double Time, string Line)>();
        //Lyrics path and file array
        private string[] lrc_paths, lrc_files;
        private void btn_loadLyrics_Click(object sender, EventArgs e) {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "LRC Files (*.lrc)|*.lrc|Text Files (*.txt)|*.txt";
            ofd.Multiselect = true;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                // Iterate through each selected file
                foreach (string lrc_file in ofd.FileNames)
                {
                    // Get only the file name from the full path
                    string fileName = System.IO.Path.GetFileName(lrc_file);

                    // Check for duplicates before adding
                    if (!lyrics_list.Items.Contains(fileName))
                    {
                        lyrics_list.Items.Add(fileName); // Add only the file name
                    }
                    else
                    {
                        MessageBox.Show($"The lyrics '{fileName}' are already in the list.", "Duplicate Lyrics", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        continue; // Skip to the next file if duplicate found
                    }

                    // Read the lyrics text from the file
                    string lyricsText = System.IO.File.ReadAllText(lrc_file);

                    if (lrc_file.EndsWith(".lrc"))
                    {
                        ParseLrcFile(lyricsText); // Parse LRC files
                    }
                    else
                    {
                        ParseTextFile(lyricsText); // Handle other text files
                    }

                    // Update paths and files arrays
                    // Create a new list to avoid duplicates
                    List<string> tmpPaths = new List<string>(lrc_paths ?? Array.Empty<string>());
                    List<string> tmpFiles = new List<string>(lrc_files ?? Array.Empty<string>());

                    foreach (string path in ofd.FileNames)
                    {
                        if (!tmpPaths.Contains(path))
                        {
                            tmpPaths.Add(path);
                        }
                    }

                    foreach (string file in ofd.SafeFileNames)
                    {
                        if (!tmpFiles.Contains(file))
                        {
                            tmpFiles.Add(file);
                        }
                    }

                    // Update the original arrays with unique paths and files
                    lrc_paths = tmpPaths.ToArray();
                    lrc_files = tmpFiles.ToArray();

                    // Clear existing lyrics if you want to reset for each file, or handle them separately
                    // lyrics.Clear(); // Uncomment if you want to clear for each file added
                    // lbl_lyrics.Text = ""; // Reset lyrics display
                }

                // Optionally, display the first line of the lyrics immediately from the last added file
                /*if (lyrics.Count > 0)
                {
                    lbl_lyrics.Text = lyrics[0].Line; // Display the first lyric line
                }*/
            }









            /*
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "LRC Files (*.lrc)|*.lrc|Text Files (*.txt)|*.txt";

            if (ofd.ShowDialog() == DialogResult.OK)
            {

                // Check for duplicates before adding
                foreach (string file in ofd.SafeFileNames)
                {
                    if (!lyrics_list.Items.Contains(file))
                    {
                        lyrics_list.Items.Add(file);
                    }
                    else
                    {
                        MessageBox.Show($"The lyrics '{file}' is already in the list.", "Duplicate Lyrics", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }

                // Update paths and files arrays
                // Create a new list to avoid duplicates
                List<string> tempPaths = new List<string>(paths ?? Array.Empty<string>());
                List<string> tempFiles = new List<string>(files ?? Array.Empty<string>());

                foreach (string path in ofd.FileNames)
                {
                    if (!tempPaths.Contains(path))
                    {
                        tempPaths.Add(path);
                    }
                }

                foreach (string file in ofd.SafeFileNames)
                {
                    if (!tempFiles.Contains(file))
                    {
                        tempFiles.Add(file);
                    }
                }

                // Update the original arrays with unique paths and files
                paths = tempPaths.ToArray();
                files = tempFiles.ToArray();
             
                // This is if I want the selected lyrics file to be directly displayed in the lyrics label

                string lyricsText = System.IO.File.ReadAllText(ofd.FileName);

                // lbl_lyrics.Text = lyricsText; // Display raw lyrics in the text box

                lbl_lyrics.Text = ""; // Clear the existing lyrics before displaying new lyrics

                lyrics.Clear(); // Clear existing lyrics

                if (ofd.FileName.EndsWith(".lrc"))
                {
                    ParseLrcFile(lyricsText); // Parse LRC files
                }
                else
                {
                    ParseTextFile(lyricsText); // Handle other text files
                }

                lbl_lyrics.Text = ""; // Ensure lyrics are hidden when loaded

            }
            */
        }

        // Parsing the lyrics file 
        private void ParseLrcFile(string lrcText)
        {
            string[] lines = lrcText.Split(new[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var line in lines)
            {
                // Regex to extract time and line
                var match = System.Text.RegularExpressions.Regex.Match(line, @"\[(\d+):(\d+\.\d+)\](.*)");
                if (match.Success)
                {
                    double minutes = double.Parse(match.Groups[1].Value);
                    double seconds = double.Parse(match.Groups[2].Value);
                    string lyricLine = match.Groups[3].Value;

                    // Calculate time in seconds
                    double timeInSeconds = minutes * 60 + seconds;
                    lyrics.Add((timeInSeconds, lyricLine)); // Add to the lyrics list
                }
            }
        }

        private void lyrics_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Ensure that a valid item is selected
            if (lyrics_list.SelectedIndex < 0)
                return;

            // Get the selected lyrics file path
            string selectedFileName = lyrics_list.SelectedItem.ToString();
            string lyricsFolderPath = lrc_paths[lyrics_list.SelectedIndex];
            //string selectedFilePath = System.IO.Path.Combine(lyricsFolderPath, selectedFileName);

            // Read the lyrics text from the file
            string lyricsText = System.IO.File.ReadAllText(lyricsFolderPath);//selectedFilePath);

            // Clear the existing lyrics before displaying new lyrics
            lbl_lyrics.Text = "";
            lyrics.Clear(); // Clear existing lyrics

            // Parse the lyrics based on the file type
            if (selectedFileName.EndsWith(".lrc"))
            {
                ParseLrcFile(lyricsText); // Parse LRC files
            }
            else
            {
                ParseTextFile(lyricsText); // Handle other text files
            }

            // Optionally, display the first line of the lyrics immediately
            if (lyrics.Count > 0)
            {
                lbl_lyrics.Text = lyrics[0].Line; // Display the first lyric line
            }
        }

        private void ParseTextFile(string text)
        {
            string[] lines = text.Split(new[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            double timeIncrement = 5; // Assuming each line is displayed for 5 seconds

            for (int i = 0; i < lines.Length; i++)
            {
                lyrics.Add((i * timeIncrement, lines[i].Trim())); // Adding lines with incremental timing
            }
        }










        //Another way to implement repeat **
        /*private void player_PlayStateChange(object sender, _WMPOCXEvents_PlayStateChangeEvent e)
        {
            //Console.WriteLine($"PlayState changed to: {e.newState}");

            if (e.newState == (int)WMPLib.WMPPlayState.wmppsMediaEnded)
            {
                if (isRepeatEnabled)
                {
                    player.Ctlcontrols.currentPosition = 0; // Restart from the beginning
                    player.Ctlcontrols.play();
                    lbl_msg.Text = "Playing again (Repeat)"; // You can show a message when it repeats
                }
            }
        }*/




    }
}