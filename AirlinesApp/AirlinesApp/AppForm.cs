using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AirlinesApp.ChildForms;
using System.Data.SqlClient;

namespace AirlinesApp
{
    public partial class AppForm : Form
    {
        private AppLibraries app;
        private AirplaneForm airplaneForm;

        public AppForm()
        {
            InitializeComponent();
            app = new AppLibraries();
            dataGrid.Visible = false;
            checkRadioBtn(1);
        }

        #region RadioButton Editor

        private void checkRadioBtn(int index)
        {
            app.iData = index;
            airplaneBtn.Checked = false;
            airlineBtn.Checked = false;
            airportBtn.Checked = false;
            flightBtn.Checked = false;
            userBtn.Checked = false;

            switch (index)
            {
                case 1: airplaneBtn.Checked = true; break;
                case 2: airlineBtn.Checked = true; break;
                case 3: airportBtn.Checked = true; break;
                case 4: flightBtn.Checked = true; break;
                case 5: userBtn.Checked = true; break;
            }
        }

        private void airplaneBtn_Click(object sender, EventArgs e)
        {
            checkRadioBtn(1);
        }

        private void airlineBtn_Click(object sender, EventArgs e)
        {
            checkRadioBtn(2);
        }

        private void airportBtn_Click(object sender, EventArgs e)
        {
            checkRadioBtn(3);
        }

        private void flightBtn_Click(object sender, EventArgs e)
        {
            checkRadioBtn(4);
        }

        private void userBtn_Click(object sender, EventArgs e)
        {
            checkRadioBtn(5);
        } 

        #endregion

        private void displayBtn_Click(object sender, EventArgs e)
        {
            dataGrid.Refresh();
            if (!dataGrid.Visible)
                dataGrid.Visible = true;
            
            app.executeRequest("select * from " + app.dboSource);
            dataGrid.DataSource = app.DataTable;
            MessageBox.Show("Datatable is loaded successfully", "Message");
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            switch (app.iData)
            {
                case 1:
                    airplaneForm = new AirplaneForm(this);
                    airplaneForm.Show();
                    break;
            }
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            
        }
    }
}
