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
using System.Net.Http;

using System.Data.OleDb;
using System.IO;
using System.Web;
using System.Web.Script.Serialization;
using Flurl.Http;

namespace GoldSentinel
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            //this.WindowState = FormWindowState.Maximized;

            InitializeComponent();

        }

        string applicationName = "Gold Sentinel";

        ManageBuildingForm ManageBuildingForm;
        public void ManageBuilding()
        {
            if (ManageBuildingForm == null || ManageBuildingForm.IsDisposed)
            {
                ManageBuildingForm = null;
                ManageBuildingForm = new ManageBuildingForm();
                ManageBuildingForm.Show();
            }
            else if (ManageBuildingForm != null)
            {
                ManageBuildingForm.WindowState = FormWindowState.Normal; ;
                ManageBuildingForm.BringToFront();
            }
        }

        Forms.ManageStaff ManageStaffForm;
        public void ManageStaff()
        {
            if (ManageStaffForm == null || ManageStaffForm.IsDisposed)
            {
                ManageStaffForm = null;
                ManageStaffForm = new Forms.ManageStaff();
                ManageStaffForm.Show();
            }
            else if (ManageStaffForm != null)
            {
                ManageStaffForm.WindowState = FormWindowState.Normal; ;
                ManageStaffForm.BringToFront();
            }
        }

        ManagePatient ManagePatientForm;
        public void ManagePatient()
        {
            if (ManagePatientForm == null || ManagePatientForm.IsDisposed)
            {
                ManagePatientForm = null;
                ManagePatientForm = new ManagePatient();
                ManagePatientForm.Show();
            }
            else if (ManagePatientForm != null)
            {
                ManagePatientForm.WindowState = FormWindowState.Normal; ;
                ManagePatientForm.BringToFront();
            }
        }

        Forms.ManageVisitors ManageVisitorsForm;
        public void ManageVisitors()
        {
            if (ManageVisitorsForm == null || ManageVisitorsForm.IsDisposed)
            {
                ManageVisitorsForm = null;
                ManageVisitorsForm = new Forms.ManageVisitors();
                ManageVisitorsForm.Show();
            }
            else if (ManageVisitorsForm != null)
            {
                ManageVisitorsForm.WindowState = FormWindowState.Normal; ;
                ManageVisitorsForm.BringToFront();
            }
        }

        Forms.SignOutVisitors SignOutVisitorForm;
        public void SignOutVisitor()
        {
            if (SignOutVisitorForm == null || SignOutVisitorForm.IsDisposed)
            {
                SignOutVisitorForm = null;
                SignOutVisitorForm = new Forms.SignOutVisitors();
                SignOutVisitorForm.Show();
            }
            else if (SignOutVisitorForm != null)
            {
                SignOutVisitorForm.WindowState = FormWindowState.Normal; ;
                SignOutVisitorForm.BringToFront();
            }
        }

        //button actions
        private void manageBuildingBtn_Click(object sender, EventArgs e)
        {
            ManageBuilding();
        }
        private void manageStaffBtn_Click(object sender, EventArgs e)
        {
            ManageStaff();
        }
        private void managePatientBtn_Click(object sender, EventArgs e)
        {
            ManagePatient();
        }
        private void manageVisitorBtn_Click(object sender, EventArgs e)
        {
            ManageVisitors();
        }
        private void signOutVisitorBtn_Click(object sender, EventArgs e)
        {
            SignOutVisitor();
        }

        //Menu Strip Buttons
        private void manageBuildingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageBuilding();
        }
        private void manageStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageStaff();
        }
        private void managePatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManagePatient();
        }
        private void manageVisitorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageVisitors();
        }
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }






        //check before closing the applications
        //commented because it is annoying during development
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
                {
                    //if (MessageBox.Show("Do you really want to close this application?", applicationName,
                    //         MessageBoxButtons.YesNo) == DialogResult.Yes)
                    //{
                    //    // Cancel the Closing event from closing the form.
                    //    e.Cancel = false;
                    //}
                    //else
                    //{
                    //    e.Cancel = true;

                    //}
                }

        //Webhooks
        private static  Task<HttpResponseMessage> MakeRequest()
        {
            var httpClient = new HttpClient();
            return  httpClient.GetAsync(new Uri("http://webhook.site/cc9cf9d7-e76a-44c4-8d6b-c444327b80f5"));
        }

        void WebHook_button_Click(object sender, EventArgs e)
        {
            Run().Wait();

            //var task = MakeRequest();
            //task.Wait();

            //var response = task.Result;
            //var body1 = task.Result.Headers.Date.ToString();
            //var body2 = response.Content.ReadAsStringAsync().Result;
            //WebHook_label.Text = Convert.ToString(body1+"     "+body2);
        }








        private static readonly HttpClient _Client = new HttpClient();
        private static JavaScriptSerializer _Serializer = new JavaScriptSerializer();



        static async Task Run()
        {
            string url = "http://webhook.site/cc9cf9d7-e76a-44c4-8d6b-c444327b80f5";
            Customer cust = new Customer();
            var json = _Serializer.Serialize(cust);
            var response = await Request(HttpMethod.Post, url, json, new Dictionary<string, string>());
            string responseText = await response.Content.ReadAsStringAsync();


            Console.WriteLine(responseText);
            Console.ReadLine();
        }

        /// <summary>
        /// Makes an async HTTP Request
        /// </summary>
        /// <param name="pMethod">Those methods you know: GET, POST, HEAD, etc...</param>
        /// <param name="pUrl">Very predictable...</param>
        /// <param name="pJsonContent">String data to POST on the server</param>
        /// <param name="pHeaders">If you use some kind of Authorization you should use this</param>
        /// <returns></returns>
        static async Task<HttpResponseMessage> Request(HttpMethod pMethod, string pUrl, string pJsonContent, Dictionary<string, string> pHeaders)
        {
            var httpRequestMessage = new HttpRequestMessage();
            httpRequestMessage.Method = pMethod;
            httpRequestMessage.RequestUri = new Uri(pUrl);
            foreach (var head in pHeaders)
            {
                httpRequestMessage.Headers.Add(head.Key, head.Value);
            }
            switch (pMethod.Method)
            {
                case "POST":
                    HttpContent httpContent = new StringContent(pJsonContent, Encoding.UTF8, "application/json");
                    httpRequestMessage.Content = httpContent;
                    break;

            }

            return await _Client.SendAsync(httpRequestMessage);
        }



        class Customer
        {
            public string AdapterId { get; set; }
            public string Id { get; set; }
            public string Major { get; set; }
            public string MeasuredPower { get; set; }
            public string Minor { get; set; }
            public string PacketType { get; set; }
            public string ProjectId { get; set; }
            public string Rssi { get; set; }
            public string Time { get; set; }
            public string Timestamp { get; set; }
            public string Uuid { get; set; }
            public string Version { get; set; }
            public string Gid { get; set; }
        }






        class BeaconResponse
        {
            public string AdapterId { get; set; }
            public string Id { get; set; }
            public string Major { get; set; }
            public string MeasuredPower { get; set; }
            public string Minor { get; set; }
            public string PacketType { get; set; }
            public string ProjectId { get; set; }
            public string Rssi { get; set; }
            public string Time { get; set; }
            public string Timestamp { get; set; }
            public string Uuid { get; set; }
            public string Version { get; set; }
            public string Gid { get; set; }
        }


        private static readonly HttpClient client = new HttpClient();

      

        public async Task GetMethoodAsync()
        {
            var responseString = await client.GetStringAsync("http://webhook.site/cc9cf9d7-e76a-44c4-8d6b-c444327b80f5");
        }

        public async Task PostMethod()
        {
            var values = new Dictionary<string, string>
            {
                { "thing1", "hello" },
                { "thing2", "world" }
            };

            var content = new FormUrlEncodedContent(values);

            var response = await client.PostAsync("http://webhook.site/cc9cf9d7-e76a-44c4-8d6b-c444327b80f5", content);

            var responseString = await response.Content.ReadAsStringAsync();
        }

        public async Task GetMethoodAsync2()
        {
            var responseString = await "http://webhook.site/cc9cf9d7-e76a-44c4-8d6b-c444327b80f5".GetStringAsync();
        }



        private void Update_Click(object sender, EventArgs e)
        {
            InitTimer();
        }



        private Timer timer1;
        public void InitTimer()
        {
            timer1 = new Timer();
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = 1000; // in miliseconds
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string connectionString = "server=.\\SQLEXPRESS;database=GSDB;integrated security=SSPI;connection timeout=2";


            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(
                //"SELECT	(SELECT buildingName     From Buildings where buildingGUID in (SELECT  buildingGUID_fk FROM    Floors  WHERE   floorGUID = R.floorGUID_fk)) as Building,(SELECT floorNumber FROM    Floors  WHERE   floorGUID = R.floorGUID_fk) as Floors,roomNumber as RoomNumbers FROM Rooms R ORDER BY Building, Floors, RoomNumbers", conn);
                "Select buildingName,floorNumber,roomNumber From Rooms R full outer join Floors F ON r.floorGUID_fk = F.floorGUID full outer join Buildings B ON F.buildingGUID_fk = B.buildingGUID", conn);
            try
            {
                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = cmd;
                DataTable dta = new DataTable();
                sda.Fill(dta);
                BindingSource bdsour = new BindingSource();

                bdsour.DataSource = dta;
                dataGridView1.DataSource = bdsour;
                sda.Update(dta);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


    }

}
