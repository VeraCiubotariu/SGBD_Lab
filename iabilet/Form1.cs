using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iabilet.domain;
using iabilet.service;

namespace iabilet
{
    public partial class Form1 : Form, IObserver
    {
        private Service _service;
        public Form1()
        {
            InitializeComponent();
        }

        public void SetService(Service service)
        {
            this._service = service;
            _service.AddObserver(this);
            InitModel();
        }

        private void InitModel()
        {
            try
            {
                genresListBox.DataSource = _service.GetAllGenres();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
            
            
            List<String> bandOptions = new List<string>();
            bandOptions.Add("Yes");
            bandOptions.Add("No");
            bandComboBox.DataSource = bandOptions;
        }

        private void UpdateArtists()
        {
            Genre selected = (Genre)genresListBox.SelectedItem;

            if (selected != null)
            {
                try
                {
                    artistsListBox.DataSource = _service.GetAllArtistsByGenre(selected.Id);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void genresListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateArtists();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            Artist selectedArtist = (Artist)artistsListBox.SelectedItem;
            
            try
            {
                Console.WriteLine(selectedArtist.Id);
                if (_service.DeleteArtist(selectedArtist) != null)
                {
                    /*MessageBox.Show("Artist deleted successfully", "Information", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);*/
                }

                else
                {
                    MessageBox.Show("Error deleting artist", "Error", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }    
            
        }

        public new void Update()
        {
            UpdateArtists();
        }

        private Artist GetNewArtist()
        {
            String name = nameTextBox.Text;
            bool band = (bandComboBox.Text == "Yes");
            int genreId = ((Genre)genresListBox.SelectedItem).Id;
            int artistId = ((Artist)artistsListBox.SelectedItem).Id;

            return new Artist()
            {
                Id = artistId,
                Name = name,
                Band = band,
                GenreId = genreId
            };
        }

        private void modifyButton_Click(object sender, EventArgs e)
        {
            try
            {
                _service.UpdateArtist(GetNewArtist());
                /*MessageBox.Show("Artist modified successfully", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);*/
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                _service.AddArtist(GetNewArtist());
                /*MessageBox.Show("Artist added successfully", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);*/
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}