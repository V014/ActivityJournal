using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ActivityJournal
{
    public partial class Home : Form
    {
        // declare variables
        private readonly Connection con = new Connection();
        private readonly Style style = new Style();

        public Home()
        {
            InitializeComponent();
            Load_Activity(dataGrid);
            Load_counters();
            // theme datagrid
            style.styleDataGrid(dataGrid);
        }
        // load counters
        private void Load_counters()
        {
            count_activity.Text = con.ReadString("SELECT COUNT(ID) FROM Activity");
            count_tasks.Text = con.ReadString("SELECT COUNT(ID) FROM Tasks");
            count_attendence.Text = con.ReadString("SELECT COUNT(ID) FROM Attendence");
            count_research.Text = con.ReadString("SELECT COUNT(ID) FROM Research");
            count_stages.Text = con.ReadString("SELECT COUNT(ID) FROM Stages");
        }
        // load activity page
        private void Load_Activity(DataGridView datagrid)
        {
            // load list of activities and drop them in a datagrid
            con.LoadData("SELECT * FROM Activity", datagrid);
            dataGrid.Columns[0].Visible = false;
            dataGrid.Columns[6].Visible = false;
        }
        // load tasks
        private void Load_Tasks(DataGridView dataGrid)
        {
            con.LoadData("SELECT * FROM Tasks", dataGrid);
            dataGrid.Columns[0].Visible = false;
        }
        // load attendence
        private void Load_Attendence(DataGridView dataGrid)
        {
            con.LoadData("SELECT * FROM Attendence", dataGrid);
            dataGrid.Columns[0].Visible = false;
        }
        // load research
        private void Load_Research(DataGridView dataGrid)
        {
            con.LoadData("SELECT * FROM Research", dataGrid);
            dataGrid.Columns[0].Visible = false;
        }
        // load stages
        private void Load_Stages(DataGridView dataGrid)
        {
            con.LoadData("SELECT * FROM Stages", dataGrid);
            dataGrid.Columns[0].Visible = false;
        }
        // loads tasks after user click
        private void Btn_task_Click(object sender, EventArgs e)
        {
            Load_Tasks(dataGrid);
            lbl_page.Text = "Tasks";
        }
        // loads activity after user click
        private void Btn_activity_Click(object sender, EventArgs e)
        {
            Load_Activity(dataGrid);
            lbl_page.Text = "Activity";
        }
        // loads attendence after user click
        private void Btn_attendence_Click(object sender, EventArgs e)
        {
            Load_Attendence(dataGrid);
            lbl_page.Text = "Attendence";
        }
        // loads research after user click
        private void Btn_research_Click(object sender, EventArgs e)
        {
            Load_Research(dataGrid);
            lbl_page.Text = "Research";
        }
        // loads stages after user click
        private void Btn_stages_Click(object sender, EventArgs e)
        {
            Load_Stages(dataGrid);
            lbl_page.Text = "Stages";
        }
        // adds a new row into the datagrid
        private void Add_Click(object sender, EventArgs e)
        {
            try
            {
                switch (lbl_page.Text)
                {
                    case "Activity":
                        con.ExecuteQuery("INSERT INTO Activity(Name, Stages, Completed, Starting, Ending, Date) VALUES('enter title', 0, 0, 'Date', 'Date', strftime('%Y-%m-%d', 'now'))");
                        Load_Activity(dataGrid);
                        break;
                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }

        private void Btn_apply_Click(object sender, EventArgs e)
        {
            try
            {
                // collect the ID and declare variables one time
                DataGridViewRow selectedRow = dataGrid.SelectedRows[0];
                string id = selectedRow.Cells[0].Value.ToString();
                string name;
                string stages;
                string completed;
                string starting;
                string ending;
                string activityID;
                string description;
                string due;
                string response;

                // swtich between page title to see which block should run
                switch (lbl_page.Text){
                    case "Activity":
                        name = selectedRow.Cells[1].Value.ToString();
                        stages = selectedRow.Cells[2].Value.ToString();
                        completed = selectedRow.Cells[3].Value.ToString();
                        starting = selectedRow.Cells[4].Value.ToString();
                        ending = selectedRow.Cells[5].Value.ToString();
                        con.ExecuteQuery($"UPDATE Activity SET Name = '{name}', Stages = '{stages}', Completed = '{completed}', Starting = '{starting}', Ending = '{ending}' WHERE ID = {id}");
                        Load_Activity(dataGrid);
                        break;

                    case "Tasks":
                        activityID = selectedRow.Cells[1].Value.ToString();
                        name = selectedRow.Cells[2].Value.ToString();
                        description = selectedRow.Cells[3].Value.ToString();
                        due = selectedRow.Cells[4].Value.ToString();
                        completed = selectedRow.Cells[5].Value.ToString();
                        con.ExecuteQuery($"UPDATE Tasks SET Name = '{name}', Description = '{description}', Completed = '{completed}' WHERE ID = {id}");
                        Load_Tasks(dataGrid);
                        break;

                    case "Attendence":
                        activityID = selectedRow.Cells[1].Value.ToString();
                        name = selectedRow.Cells[2].Value.ToString();
                        description = selectedRow.Cells[3].Value.ToString();
                        starting = selectedRow.Cells[4].Value.ToString();
                        ending = selectedRow.Cells[5].Value.ToString();
                        con.ExecuteQuery($"UPDATE Attendence SET Name = '{name}', Description = '{description}', Starting = '{starting}', Ending = '{ending}' WHERE ID = {id}");
                        Load_Attendence(dataGrid);
                        break;

                    case "Research":
                        activityID = selectedRow.Cells[1].Value.ToString();
                        name = selectedRow.Cells[2].Value.ToString();
                        description = selectedRow.Cells[3].Value.ToString();
                        response = selectedRow.Cells[4].Value.ToString();
                        con.ExecuteQuery($"UPDATE Research SET Name = '{name}', Description = '{description}', Response = '{response}' WHERE ID = {id}");
                        Load_Research(dataGrid);
                        break;

                    case "Stages":
                        activityID = selectedRow.Cells[1].Value.ToString();
                        name = selectedRow.Cells[2].Value.ToString();
                        description = selectedRow.Cells[3].Value.ToString();
                        completed = selectedRow.Cells[4].Value.ToString();
                        con.ExecuteQuery($"UPDATE Stages SET Name = '{name}', Description = '{description}', Completed = '{completed}' WHERE ID = {id}");
                        Load_Stages(dataGrid);
                        break;

                    default:
                        MessageBox.Show("App experiencing a navigation problem");
                        break;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
