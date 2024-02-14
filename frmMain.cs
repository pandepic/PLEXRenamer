using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace PLEXRenamer
{
    public partial class frmMain : Form
    {
        public List<Season> seasonList = new List<Season>();

        public frmMain()
        {
            InitializeComponent();

            txtFolderPath.Text = "E:\\_Plex";
        }

        private void BtnSelectFolder_Click(object sender, EventArgs e)
        {
            if (txtFolderPath.Text.Length > 0)
            {
                dlgOpenFolder.SelectedPath = txtFolderPath.Text;
            }

            var result = dlgOpenFolder.ShowDialog();

            if (result == DialogResult.OK)
            {
                seasonList.Clear();
                lstEpisodes.Items.Clear();

                txtFolderPath.Text = dlgOpenFolder.SelectedPath;
                txtShowName.Text = dlgOpenFolder.SelectedPath.Split('\\').Last();

                var seasons = Directory.GetDirectories(txtFolderPath.Text);
                int seasonNumber = 1;

                foreach (var s in seasons)
                {
                    var episodes = Directory.GetFiles(s);
                    var episodeNumber = 1;

                    var newSeason = new Season()
                    {
                        Name = "s" + (seasonNumber < 10 ? "0" : "") + seasonNumber.ToString(),
                        Path = s,
                        Number = seasonNumber,
                        Episodes = new List<Episode>(),
                    };

                    foreach (var ep in episodes)
                    {
                        newSeason.Episodes.Add(new Episode()
                        {
                            Name = "e" + (episodeNumber < 10 ? "0" : "") + episodeNumber.ToString(),
                            Path = ep,
                            Extension = ep.Split('.').Last(),
                            Number = episodeNumber,
                        });

                        episodeNumber += 1;
                    }

                    seasonList.Add(newSeason);
                    seasonNumber += 1;
                }

                foreach (var s in seasonList)
                {
                    foreach (var ep in s.Episodes)
                    {
                        lstEpisodes.Items.Add(s.Name + ep.Name + "." + ep.Extension + " - " + ep.Path);
                    }
                }
            }
        }

        private void BtnRename_Click(object sender, EventArgs e)
        {
            prgRenaming.Maximum = lstEpisodes.Items.Count;
            prgRenaming.Value = 0;
            prgRenaming.Step = 1;

            foreach (var s in seasonList)
            {
                foreach (var ep in s.Episodes)
                {
                    var file = new FileInfo(ep.Path);
                    var newDir = txtFolderPath.Text + "\\Season " + (s.Number < 10 ? "0" : "") + s.Number.ToString();

                    if (!Directory.Exists(newDir))
                        Directory.CreateDirectory(newDir);

                    File.Move(file.FullName, newDir + "\\" + s.Name + ep.Name + "." + ep.Extension);
                    prgRenaming.PerformStep();
                }
            }

            MessageBox.Show("Renaming Finished.");
        }
    }
}
