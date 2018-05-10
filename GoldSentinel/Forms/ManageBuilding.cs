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

namespace GoldSentinel
{
    public partial class ManageBuildingForm : Form
    {
        string connectionString = "server=.\\SQLEXPRESS;database=GSDB;integrated security=SSPI;connection timeout=2";

        public ManageBuildingForm()
        {
            this.StartPosition = FormStartPosition.CenterScreen;

            InitializeComponent();
            PopulateListBox();
            UpdateRoomTypeListBox();
            PopulateBuildingListBox1();
            PopulateBuiltingListBox2();
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // =================== MANAGE BUILDING ===================

        //Inserting Data to GSDB Buildings
        public void AddBuildingToDB()
        {
            string buildingName = Convert.ToString(Building_textBox.Text);
            string buildGUID = Guid.NewGuid().ToString().ToUpper();

            SqlConnection mySqlConnection = new SqlConnection(connectionString);
            mySqlConnection.Open();

            SqlCommand mySqlCommand = mySqlConnection.CreateCommand();
            mySqlCommand.CommandText = "INSERT INTO Buildings(buildingGUID,buildingName) VALUES('" + buildGUID +"','"+ buildingName + "')";
            mySqlCommand.ExecuteNonQuery();

            mySqlConnection.Close();
            Building_textBox.Text = "";

            PopulateListBox();
        }

        //updates the ListBox Buildings
        public void PopulateListBox()
        {
            SqlConnection mySqlConnection = new SqlConnection(connectionString);

            SqlDataAdapter adapter;
            DataTable table = new DataTable();

            adapter = new SqlDataAdapter("SELECT * FROM Buildings ORDER BY buildingName", mySqlConnection);
            adapter.Fill(table);
            BuildingListBox.DataSource = table;
            BuildingListBox.DisplayMember = "buildingName";
            BuildingListBox.ValueMember = "buildingGUID";

        }
        
        //Deletes data from GSDB Buildings
        public void DeleteBuilding()
        {
            string IDtoDelete = BuildingListBox.SelectedValue.ToString();
            SqlConnection mySqlConnection = new SqlConnection(connectionString);

            mySqlConnection.Open();

            SqlCommand mySqlCommand = mySqlConnection.CreateCommand();
            mySqlCommand.CommandText = "DELETE FROM Buildings WHERE buildingGUID = '" + IDtoDelete + "'";
            mySqlCommand.ExecuteNonQuery();

            mySqlConnection.Close();

            PopulateListBox();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            AddBuildingToDB();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                DeleteBuilding();
            }
            catch (Exception)
            {

                MessageBox.Show("something");
            }
            
        }

        // =================== MANAGE FLOORS ===================

        // Populate ComboBox with Building Information



        //Populate ListBox with Building Information
        public void PopulateBuildingListBox1()
        {
            SqlConnection mySqlConnection = new SqlConnection(connectionString);
            SqlDataAdapter adapter;
            DataTable table = new DataTable();

            adapter = new SqlDataAdapter("SELECT * FROM Buildings ORDER BY buildingName", mySqlConnection);
            adapter.Fill(table);
            BuildingListBox1.DataSource = table;
            BuildingListBox1.DisplayMember = "buildingName";
            BuildingListBox1.ValueMember = "buildingGUID";
        }


        //Inserting Data to GSDB Floors
        public void AddFloorToDB()
        {

            string floorGUID = Guid.NewGuid().ToString().ToUpper();
            string buildingGUID_fk = BuildingListBox1.SelectedValue.ToString();
            string floorNumber = Convert.ToString(FloorNumberTextBox.Text);

            SqlConnection mySqlConnection = new SqlConnection(connectionString);
            mySqlConnection.Open();

            SqlCommand mySqlCommand = mySqlConnection.CreateCommand();
            mySqlCommand.CommandText = "INSERT INTO Floors(floorGUID,buildingGUID_fk,floorNumber) VALUES('" + floorGUID + "','" + buildingGUID_fk + "','" + floorNumber + "')";
            mySqlCommand.ExecuteNonQuery();

            mySqlConnection.Close();
            FloorNumberTextBox.Text = "";
            PopulateListBox();
        }
        private void AddFloorButton_Click(object sender, EventArgs e)
        {
            AddFloorToDB();
            PopulateFloorListBox();
        }

        // Populate Remove Floor ComboBox with Building Information

        public void PopulateBuildingRemoveFloorComboBox()
        {
            SqlConnection mySqlConnection = new SqlConnection(connectionString);
            SqlDataAdapter adapter;
            DataTable table = new DataTable();

            adapter = new SqlDataAdapter("SELECT * FROM Buildings ORDER BY buildingName", mySqlConnection);
            adapter.Fill(table);
            BuildingRemoveFloorComboBox.DataSource = table;
            BuildingRemoveFloorComboBox.DisplayMember = "buildingName";
            BuildingRemoveFloorComboBox.ValueMember = "buildingGUID";

        }

        // Populate Remove Floor ListBox with Floors from the selected building
        public void PopulateFloorListBox()
        {
            string buildingGUID_fk = BuildingRemoveFloorComboBox.SelectedValue.ToString();

            SqlConnection mySqlConnection = new SqlConnection(connectionString);
            SqlDataAdapter adapter;
            DataTable table = new DataTable();

            adapter = new SqlDataAdapter("SELECT * FROM Floors WHERE buildingGUID_fk='" + buildingGUID_fk + "' ORDER BY floorNumber", mySqlConnection);
            adapter.Fill(table);
            FloorListBox.DataSource = table;
            FloorListBox.DisplayMember = "floorNumber";
            FloorListBox.ValueMember = "floorGUID";

        }
        private void BuildingRemoveFloorComboBox_DropDown(object sender, EventArgs e)
        {
            PopulateBuildingRemoveFloorComboBox();
        }

        //Delete Floor from Building
        public void DeleteFloorFromBuilding()
        {
            string floorIDtoDelete = FloorListBox.SelectedValue.ToString();

            SqlConnection mySqlConnection = new SqlConnection(connectionString);

            mySqlConnection.Open();

            SqlCommand mySqlCommand = mySqlConnection.CreateCommand();
            mySqlCommand.CommandText = "DELETE FROM Floors WHERE floorGUID = '" + floorIDtoDelete + "'";
            mySqlCommand.ExecuteNonQuery();

            mySqlConnection.Close();

            PopulateFloorListBox();




        }
        private void BuildingRemoveFloorComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            PopulateFloorListBox();
        }
        private void RemoveFloorButton_Click(object sender, EventArgs e)
        {
            DeleteFloorFromBuilding();
        }

        // =================== MANAGE ROOM TYPES ===================
        //include number of patient per room
        public void AddRoomType()
        {
            string roomTypeName = Convert.ToString(RoomTypeTextBox.Text);
            string roomTypeGUID = Guid.NewGuid().ToString().ToUpper();

            SqlConnection mySqlConnection = new SqlConnection(connectionString);
            mySqlConnection.Open();

            SqlCommand mySqlCommand = mySqlConnection.CreateCommand();
            mySqlCommand.CommandText = "INSERT INTO RoomTypes(roomTypeGUID,roomType) VALUES('" + roomTypeGUID + "','" + roomTypeName + "')";
            mySqlCommand.ExecuteNonQuery();

            mySqlConnection.Close();
            RoomTypeTextBox.Text = "";
            UpdateRoomTypeListBox();
        }
        public void UpdateRoomTypeListBox()
        {
            SqlConnection mySqlConnection = new SqlConnection(connectionString);
            SqlDataAdapter adapter;
            DataTable table = new DataTable();

            adapter = new SqlDataAdapter("SELECT * FROM RoomTypes ORDER BY roomType", mySqlConnection);
            adapter.Fill(table);
            RoomTypeDeleteListBox.DataSource = table;
            RoomTypeDeleteListBox.DisplayMember = "roomType";
            RoomTypeDeleteListBox.ValueMember = "roomTypeGUID";
        }
        private void AddRoomTypeButton_Click(object sender, EventArgs e)
        {
            if (RoomTypeTextBox.Text == "")
            {

            }
            else
            {
                AddRoomType();
            }

            
        }
        public void DeleteRoomTypeFromListBox()
        {
            string roomTypeIDtoDelete = RoomTypeDeleteListBox.SelectedValue.ToString();

            SqlConnection mySqlConnection = new SqlConnection(connectionString);

            mySqlConnection.Open();

            SqlCommand mySqlCommand = mySqlConnection.CreateCommand();
            mySqlCommand.CommandText = "DELETE FROM RoomTypes WHERE roomTypeGUID = '" + roomTypeIDtoDelete + "'";
            mySqlCommand.ExecuteNonQuery();

            mySqlConnection.Close();

            UpdateRoomTypeListBox();
        }
        private void DeleteRoomTypeButton_Click(object sender, EventArgs e)
        {
            DeleteRoomTypeFromListBox();
        }

        // =================== MANAGE ROOMS ===================

        private void PopulateBuiltingListBox2()
        {
            SqlConnection mySqlConnection = new SqlConnection(connectionString);
            SqlDataAdapter adapter;
            DataTable table = new DataTable();

            adapter = new SqlDataAdapter("SELECT * FROM Buildings ORDER BY buildingName", mySqlConnection);
            adapter.Fill(table);
            BuildingListBox2.DataSource = table;
            BuildingListBox2.DisplayMember = "buildingName";
            BuildingListBox2.ValueMember = "buildingGUID";

        }
        private void PopulateFloorListBox2()
        {
            string buildingGUID = BuildingListBox2.SelectedValue.ToString();

            SqlConnection mySqlConnection = new SqlConnection(connectionString);
            SqlDataAdapter adapter;
            DataTable table = new DataTable();

            adapter = new SqlDataAdapter("SELECT * FROM Floors WHERE buildingGUID_fk ='" + buildingGUID + "' ORDER BY floorNumber", mySqlConnection);
            adapter.Fill(table);
            FloorListBox2.DataSource = table;
            FloorListBox2.DisplayMember = "floorNumber";
            FloorListBox2.ValueMember = "floorGUID";
        }
        private void PopulateRoomListBox()
        {
            try
            {
                string floorGUID = FloorListBox2.SelectedValue.ToString();

                SqlConnection mySqlConnection = new SqlConnection(connectionString);
                SqlDataAdapter adapter;
                DataTable table = new DataTable();

                adapter = new SqlDataAdapter("SELECT roomNumber + ' (' + (SELECT roomType FROM RoomTypes WHERE roomTypeGUID = roomTypeGUID_fk ) + ')' as roomNumber, roomGUID from Rooms where floorGUID_fk = '" + floorGUID + "' ORDER BY roomNumber", mySqlConnection);

                //"SELECT * FROM Rooms WHERE floorGUID_fk ='" + floorGUID + "' ORDER BY roomNumber", mySqlConnection);

                adapter.Fill(table);
                RoomListBox.DataSource = table;
                RoomListBox.DisplayMember = "roomNumber";
                RoomListBox.ValueMember = "roomGUID";
            }
            catch (Exception)
            {
                RoomListBox.DisplayMember = "";
                RoomListBox.ValueMember = "";
            }
        }
        private void PopulateRoomTypeListBox2()
        {
            SqlConnection mySqlConnection = new SqlConnection(connectionString);
            SqlDataAdapter adapter;
            DataTable table = new DataTable();

            adapter = new SqlDataAdapter("SELECT * FROM RoomTypes ORDER BY roomType", mySqlConnection);
            adapter.Fill(table);
            RoomTypeListBox2.DataSource = table;
            RoomTypeListBox2.DisplayMember = "roomType";
            RoomTypeListBox2.ValueMember = "roomTypeGUID";
        }
        private void BuildingListBox2_SelectedValueChanged(object sender, EventArgs e)
        {
            PopulateFloorListBox2();
            PopulateRoomTypeListBox2();
            PopulateRoomListBox();
        }
        private void FloorListBox2_SelectedValueChanged(object sender, EventArgs e)
        {
            PopulateRoomListBox();
        }
        private void AddRoomButton_Click(object sender, EventArgs e)
        {
            string roomGUID = Guid.NewGuid().ToString().ToUpper();
            string floorGUID_fk = FloorListBox2.SelectedValue.ToString();
            string roomTypeGUID = RoomTypeListBox2.SelectedValue.ToString();
            string roomNumber = Convert.ToString(RoomNumberTextBox.Text);

            SqlConnection mySqlConnection = new SqlConnection(connectionString);
            mySqlConnection.Open();

            SqlCommand mySqlCommand = mySqlConnection.CreateCommand();
            mySqlCommand.CommandText = "INSERT INTO Rooms(roomGUID,floorGUID_fk,roomTypeGUID_fk,roomNumber) VALUES('" +
                roomGUID +"','" +
                floorGUID_fk + "','" +
                roomTypeGUID + "','" +
                roomNumber + "')";

            mySqlCommand.ExecuteNonQuery();
            mySqlConnection.Close();

            PopulateRoomListBox();

            RoomNumberTextBox.Text = "";
            RoomNumberTextBox.Focus();
        }
        private void RemoveRoomBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string roomGUID = RoomListBox.SelectedValue.ToString();

                SqlConnection mySqlConnection = new SqlConnection(connectionString);

                mySqlConnection.Open();

                SqlCommand mySqlCommand = mySqlConnection.CreateCommand();
                mySqlCommand.CommandText = "DELETE FROM Rooms WHERE roomGUID = '" + roomGUID + "'";
                mySqlCommand.ExecuteNonQuery();

                mySqlConnection.Close();

                PopulateRoomListBox();
            }
            catch (Exception)
            {

            }
        }






        private Timer timer1;
        public void InitTimer()
        {
            timer1 = new Timer();
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = 1000; // in miliseconds
            timer1.Start();
        }
        public void StopTimer()
        {
            timer1.Stop();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            string buildingName = Guid.NewGuid().ToString().ToUpper();
            string buildGUID = Guid.NewGuid().ToString().ToUpper();

            SqlConnection mySqlConnection = new SqlConnection(connectionString);
            mySqlConnection.Open();

            SqlCommand mySqlCommand = mySqlConnection.CreateCommand();
            mySqlCommand.CommandText = "INSERT INTO Buildings(buildingGUID,buildingName) VALUES('" + buildGUID + "','" + buildingName + "')";
            mySqlCommand.ExecuteNonQuery();

            mySqlConnection.Close();
            Building_textBox.Text = "";

            PopulateListBox();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            InitTimer();
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            StopTimer();
        }
    }
    
}
