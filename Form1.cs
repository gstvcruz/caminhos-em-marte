// 23513 - Diogo Lourenço
// 23521 - Gustavo Cruz

using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace apMartianPathways
{
    public partial class FrmPaths : Form
    {
        public FrmPaths()
        {
            InitializeComponent();
        }

        // ##### Beginning of Cities tab page #####
        string citiesFile = null;
        IHashTable<City> table;
        private void btnOpenCitiesFile_Click(object sender, EventArgs e)
        {
            if (dlgOpenCitiesFile.ShowDialog() == DialogResult.Cancel)
                return;

            if (rbBucketHashing.Checked)
                table = new BucketHashing<City>();
            else
                if (rbLinearProbing.Checked)
                    table = new LinearProbing<City>();
                else
                    if (rbQuadraticProbing.Checked)
                        table = new QuadraticProbing<City>();
                    else
                        if (rbDoubleHashing.Checked)
                            table = new DoubleHashing<City>();

            citiesFile = dlgOpenCitiesFile.FileName;
            var file = new StreamReader(citiesFile);
            while (!file.EndOfStream)
            {
                City city = new City();
                city.ReadRegistry(file);
                table.Insert(city);
            }
            ShowCities();
            file.Close();
        }

        private void SaveCitiesFile()
        {
            if (citiesFile == null)
                return;

            var file = new StreamWriter(citiesFile);
            List<City> cities = table.Content();
            foreach (City c in cities)
                c.WriteData(file);
            file.Close();
        }

        private void FrmPaths_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveCitiesFile();
            SaveRoutesFile();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string cap = "Add city";
            try
            {
                if (txtCity.Text.Trim() == string.Empty)
                    throw new ArgumentException();
                City city = new City(txtCity.Text, (double)udX.Value, (double)udY.Value);
                if (table.Insert(city))
                {
                    string msg = "City added.";
                    MessageBoxButtons btn = MessageBoxButtons.OK;
                    MessageBoxIcon ico = MessageBoxIcon.Information;
                    MessageBox.Show(msg, cap, btn, ico);
                }
                else
                {
                    string msg = "City already added.";
                    MessageBoxButtons btn = MessageBoxButtons.OK;
                    MessageBoxIcon ico = MessageBoxIcon.Exclamation;
                    MessageBox.Show(msg, cap, btn, ico);
                }
            }
            catch (NullReferenceException)
            {
                string msg = "No opened file to add a city. Open a file first.";
                MessageBoxButtons btn = MessageBoxButtons.OK;
                MessageBoxIcon ico = MessageBoxIcon.Error;
                MessageBox.Show(msg, cap, btn, ico);
            }
            catch (ArgumentOutOfRangeException f)
            {
                string msg = f.Message;
                MessageBoxButtons btn = MessageBoxButtons.OK;
                MessageBoxIcon ico = MessageBoxIcon.Exclamation;
                MessageBox.Show(msg, cap, btn, ico);
            }
            catch (ArgumentException)
            {
                string msg = "City name can't be empty.";
                MessageBoxButtons btn = MessageBoxButtons.OK;
                MessageBoxIcon ico = MessageBoxIcon.Exclamation;
                MessageBox.Show(msg, cap, btn, ico);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            string cap = "Remove city";
            try
            {
                City city = new City(txtCity.Text, (double)udX.Value, (double)udY.Value);
                if (table.Remove(city))
                {
                    string msg = "City removed.";
                    MessageBoxButtons btn = MessageBoxButtons.OK;
                    MessageBoxIcon ico = MessageBoxIcon.Information;
                    MessageBox.Show(msg, cap, btn, ico);
                }
                else
                {
                    string msg = "City not found.";
                    MessageBoxButtons btn = MessageBoxButtons.OK;
                    MessageBoxIcon ico = MessageBoxIcon.Exclamation;
                    MessageBox.Show(msg, cap, btn, ico);
                }
            } 
            catch (NullReferenceException)
            {
                string msg = "No opened file to remove a city. Open a file first.";
                MessageBoxButtons btn = MessageBoxButtons.OK;
                MessageBoxIcon ico = MessageBoxIcon.Error;
                MessageBox.Show(msg, cap, btn, ico);
            }
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string cap = "Search city";
            try
            {
                City city = new City(txtCity.Text, (double)udX.Value, (double)udY.Value);
                if (table.Exists(city, out _))
                {
                    string msg = "City found.";
                    MessageBoxButtons btn = MessageBoxButtons.OK;
                    MessageBoxIcon ico = MessageBoxIcon.Information;
                    MessageBox.Show(msg, cap, btn, ico);
                }
                else
                {
                    string msg = "City not found.";
                    MessageBoxButtons btn = MessageBoxButtons.OK;
                    MessageBoxIcon ico = MessageBoxIcon.Exclamation;
                    MessageBox.Show(msg, cap, btn, ico);
                }
            }
            catch (NullReferenceException)
            {
                string msg = "No opened file to search for a city. Open a file first.";
                MessageBoxButtons btn = MessageBoxButtons.OK;
                MessageBoxIcon ico = MessageBoxIcon.Error;
                MessageBox.Show(msg, cap, btn, ico);
            }
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            string cap = "List cities";
            try
            {
                ShowCities();

            }
            catch (NullReferenceException)
            {
                string msg = "No opened file to list cities. Open a file first.";
                MessageBoxButtons btn = MessageBoxButtons.OK;
                MessageBoxIcon ico = MessageBoxIcon.Error;
                MessageBox.Show(msg, cap, btn, ico);
            }
        }

        private void ShowCities()
        {
            lsbCities.Items.Clear();
            var cities = table.Content();
            foreach (City c in cities)
                lsbCities.Items.Add(c);
        }
        // ##### End of Cities tab page #####

        // ##### Beginning of Routes tab page #####
        string routesFile = null;
        City[] cities; // Array of ordered cities from cities file
        int[,] citiesAdjacency; // Matrix of distances between adjacent cities from routes file
        private void tpRoutes_Enter(object sender, EventArgs e)
        {
            SaveCitiesFile();
            // Add cities to an array of cities
            // Order array by name

            /*
             * Based on the ordered array of cities:
             * Update cbxOrigin
             * Update cbxDestiny
             */
        }

        private void SaveRoutesFile()
        {
            throw new NotImplementedException();

            // Save routes matrix state to the routes file
        }

        private void ShowRoutes()
        {
            throw new NotImplementedException();

            // Update dgvRoutes with all the routes found for cities A and B
        }

        private void ShowBestRoute()
        {
            throw new NotImplementedException();

            // Update dgvBestRoute with the best route found for cities A and B
        }

        private void btnOpenRoutesFile_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();

            routesFile = dlgOpenRoutesFile.FileName;
            var file = new StreamReader(routesFile);
            /*
             * Read file line by line
             * Save distances to routes array
             */
        }

        private void btnAddConnection_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();

            // Add connection between two cities selected from cbxOrigin and cbxDestiny
            // Addition should be made to the routes matrix
        }

        private void btnRemoveConnection_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();

            // Remove connection between two cities selected from cbxOrigin and cbxDestiny
            // Deletion should be made to the routes matrix
        }

        private void btnUpdateConnection_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();

            // Update connection between two cities selected from cbxOrigin and cbxDestiny
        }

        private void btnSearchRoute_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();

            // Search for all the routes between two cities selected from cbxOrigin and cbxDestiny
            // Get the best route
            ShowRoutes();
            ShowBestRoute();
        }
        // ##### End of Routes tab page #####
    }
}
