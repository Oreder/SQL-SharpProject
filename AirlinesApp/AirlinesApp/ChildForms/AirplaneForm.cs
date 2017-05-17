using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirlinesApp.ChildForms
{
    public partial class AirplaneForm : Form
    {
        private AppForm parent;
        private AppLibraries app;
        private string dboSource;
        private string cmd;
        
        public AirplaneForm(AppForm appForm)
        {
            InitializeComponent();
            parent = appForm;
            parent.Enabled = false;

            app = new AppLibraries();
            app.iData = 1;
            dboSource = app.dboSource;

            display();
        }

        private void ClearAll()
        {
            edtID.Clear();
            edtType.Clear();
            edtNseats.Clear();
        }

        private void display()
        {
            app.executeRequest("select * from " + app.dboSource);
            dataTable.DataSource = app.DataTable;
        }

        private void insertRequest()
        {
            //app.executeRequest("SET IDENTITY_INSERT " + dboSource + " ON");
            cmd = "insert into " + dboSource + " values(N'" + edtType.Text + "', " + edtNseats.Text + ")";
            app.executeRequest(cmd);
            //app.executeRequest("SET IDENTITY_INSERT " + dboSource + " OFF");
        }

        private void insertBtn_Click(object sender, EventArgs e)
        {
            if (edtNseats.Text == "" || edtType.Text == "")
            {
                MessageBox.Show("Some cells are not filled. Try again!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
 
            if (!isExisted())
            {
                insertRequest();
                ClearAll();
                display();
                MessageBox.Show("New record is inserted successfully", "Message");
            }
            else
                MessageBox.Show("Fail to insert given record", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            cmd = "delete from " + dboSource + "where ";
            
        }

        private void AirplaneForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            parent.Enabled = true;
        }

        private bool isExisted()
        {
            app.executeRequest("Select * from " + dboSource + " where AirplaneType = N'" + edtType.Text
                                                + "' and NumberOfSeats = " + edtNseats.Text);
            if (app.DataTable.Rows.Count > 0)
                return true;
            return false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //if (edtID.Text != "")
            //    app.executeRequest("Select * from " + dboSource + " where AirplaneID = " + edtID.Text);
            //if (edtType.Text != "")
            //     app.executeRequest("Select * from " + dboSource + " where AirplaneType = N'" + edtType.Text
        }

        private void dataTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataTable.Rows[e.RowIndex];

                edtID.Text = row.Cells["AirplaneID"].Value.ToString();
                edtType.Text = row.Cells["AirplaneType"].Value.ToString();
                edtNseats.Text = row.Cells["NumberOfSeats"].Value.ToString();
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            //cmd = "update " + dboSource + "set"
        }
    }
}
