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

namespace PLEXRenamer
{
    public partial class frmMain : Form
    {
        public List<Season> seasonList = new List<Season>();

        public frmMain()
        {
            InitializeComponent();

            txtFolderPath.Text = "D:\\PLEX Media";
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
                        name = "s" + (seasonNumber < 10 ? "0" : "") + seasonNumber.ToString(),
                        path = s,
                        number = seasonNumber,
                        episodes = new List<Episode>(),
                    };

                    foreach (var ep in episodes)
                    {
                        newSeason.episodes.Add(new Episode()
                        {
                            name = "e" + (episodeNumber < 10 ? "0" : "") + episodeNumber.ToString(),
                            path = ep,
                            extension = ep.Split('.').Last(),
                            number = episodeNumber,
                        });

                        episodeNumber += 1;
                    }

                    seasonList.Add(newSeason);
                    seasonNumber += 1;
                }

                foreach (var s in seasonList)
                {
                    foreach (var ep in s.episodes)
                    {
                        lstEpisodes.Items.Add(s.name + ep.name + "." + ep.extension + " - " + ep.path);
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
                foreach (var ep in s.episodes)
                {
                    var file = new FileInfo(ep.path);

                    File.Move(file.FullName, file.Directory.FullName + "\\" + s.name + ep.name + "." + ep.extension);
                    prgRenaming.PerformStep();
                }
            }

            MessageBox.Show("Renaming Finished.");
        }

    }

    public class Season
    {
        public string name { get; set; }
        public string path { get; set; }
        public int number { get; set; }
        public List<Episode> episodes { get; set; }
    }

    public class Episode
    {
        public string name { get; set; }
        public string path { get; set; }
        public string extension { get; set; }
        public int number { get; set; }
    }
}
