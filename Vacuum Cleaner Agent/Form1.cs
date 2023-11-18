using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vacuum_agent
{

    public partial class Form1 : Form
    {
        string[] rooms = new string[] { "A", "B", "C", "D" };
        string[] rooms_status = new string[] { "Dirty", "Dirty", "Dirty", "Dirty" };
        int Current_Room = 0;
        Dictionary<string, Label> status_label = new Dictionary<string, Label>();
        Dictionary<string, PictureBox> imagebox = new Dictionary<string, PictureBox>();
        Dictionary<string, Image> imagebox_normal = new Dictionary<string, Image>();
        Dictionary<string, Image> imagebox_suck = new Dictionary<string, Image>();
        bool end_loop = false;
        private bool isProcessing = false;

        public Form1()
        {
            InitializeComponent();
            pictureBox_Room_A.Image = null;
            pictureBox_Room_B.Image = null;
            pictureBox_Room_B.Image = null;
            pictureBox_Room_C.Image = null;
            pictureBox_Room_D.Image = null;

            textBox_ProcessInformation.Text = "Initial state: All Rooms are dirty. Randomize start state.\r\nGoal: All rooms are clean.\r\n";
            textBox_ProcessInformation.ForeColor = Color.Black;
            textBox_ProcessInformation.Select(0, 0);

            status_label.Add("A", label_RoomState_A);
            status_label.Add("B", label_RoomState_B);
            status_label.Add("C", label_RoomState_C);
            status_label.Add("D", label_RoomState_D);

            imagebox.Add("A", pictureBox_Room_A);
            imagebox.Add("B", pictureBox_Room_B);
            imagebox.Add("C", pictureBox_Room_C);
            imagebox.Add("D", pictureBox_Room_D);

            imagebox_normal.Add("A", Vaccum_agent.Properties.Resources.v1_r);
            imagebox_normal.Add("B", Vaccum_agent.Properties.Resources.v1_l);
            imagebox_normal.Add("C", Vaccum_agent.Properties.Resources.v1_r);
            imagebox_normal.Add("D", Vaccum_agent.Properties.Resources.v1_l);

            imagebox_suck.Add("A", Vaccum_agent.Properties.Resources.v1_rs);
            imagebox_suck.Add("B", Vaccum_agent.Properties.Resources.v1_ls);
            imagebox_suck.Add("C", Vaccum_agent.Properties.Resources.v1_rs);
            imagebox_suck.Add("D", Vaccum_agent.Properties.Resources.v1_ls);
        }

        private void AgentOperation(object sender, DoWorkEventArgs e)
        {
            this.Invoke(new MethodInvoker(delegate
            {
                textBox_ProcessInformation.AppendText("Agent started!\r\n" +
                    "Current Room " + rooms[Current_Room] + "\r\n");
            }));
            System.Threading.Thread.Sleep(1000);

            while (isProcessing)
            {
                end_loop = false;
                this.Invoke(new MethodInvoker(delegate
                {
                    textBox_ProcessInformation.AppendText("Percept!\r\n");
                }));
                System.Threading.Thread.Sleep(1000);

                if (rooms_status[Current_Room] == "Dirty")
                {
                    this.Invoke(new MethodInvoker(delegate
                    {
                        textBox_ProcessInformation.AppendText("Dirt found.\r\n");
                    }));
                    System.Threading.Thread.Sleep(1000);

                    this.Invoke(new MethodInvoker(delegate
                    {
                        Suck();
                    }));
                }
                else
                {
                    this.Invoke(new MethodInvoker(delegate
                    {
                        textBox_ProcessInformation.AppendText("Room is clean.\r\n");
                    }));
                }
                System.Threading.Thread.Sleep(1000);
                this.Invoke(new MethodInvoker(delegate
                {
                    MoveAgent();
                }));
                System.Threading.Thread.Sleep(1000);
                end_loop = true;
            }
        }

        void Suck()
        {
            if (isProcessing)
            {
                imagebox[rooms[Current_Room]].Image = imagebox_suck[rooms[Current_Room]];
                textBox_ProcessInformation.AppendText("Suck!\r\n");
                rooms_status[Current_Room] = "Clean";
                status_label[rooms[Current_Room]].Text = rooms_status[Current_Room];
                status_label[rooms[Current_Room]].ForeColor = Color.Green;
            }
        }

        void MoveAgent()
        {
            if (isProcessing)
            {
                imagebox[rooms[Current_Room]].Image = null;
                int nextRoom = FindNextRoom();
                Current_Room = nextRoom;
                textBox_ProcessInformation.AppendText("Move to room " + rooms[Current_Room] + "\r\n");
                imagebox[rooms[Current_Room]].Image = imagebox_normal[rooms[Current_Room]];
            }
        }

        int FindNextRoom()
        {
            Random random = new Random();
            int nextRoom = random.Next(rooms.Length);
            if (isProcessing)
            {
                do
                {
                    nextRoom = random.Next(rooms.Length);
                } while (nextRoom == Current_Room);
            }

            return nextRoom;
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            if (!isProcessing)
            {
                isProcessing = true;
                Random random = new Random();
                Current_Room = random.Next(rooms.Length);

                imagebox[rooms[Current_Room]].Image = imagebox_normal[rooms[Current_Room]];

                BackgroundWorker bw = new BackgroundWorker();
                bw.DoWork += new DoWorkEventHandler(AgentOperation);

                if (bw.IsBusy != true)
                {
                    bw.RunWorkerAsync();
                }
            }
        }

        private void btnNoOperation_Click(object sender, EventArgs e)
        {
            isProcessing = false;
            imagebox[rooms[Current_Room]].Image = null;
            textBox_ProcessInformation.AppendText("Operation stopped. " + "\r\n");
        }

        private void btnResetToInitialState_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < rooms_status.Length; i++)
            {
                rooms_status[i] = "Dirty";
                status_label[rooms[i]].Text = rooms_status[i];
                status_label[rooms[i]].ForeColor = Color.Red;
            }
            textBox_ProcessInformation.AppendText("Room states reset to dirty. " + "\r\n");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox_Room_B_Click(object sender, EventArgs e)
        {

        }
    }
    public class Variable
    {
        public object Value { get; set; }
    }
}
