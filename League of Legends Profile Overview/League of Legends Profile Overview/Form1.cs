using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using RiotSharp;

namespace League_of_Legends_Profile_Overview
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
          //  JsonConvert.DeserializeObject<Summoner>(string json);

        }

        //public class Summoner
        //{
        //    public int id { get; set; }
        //    public string key { get; set; }
        //    public string name { get; set; }
        //    public string title { get; set; }
        //}

        public string Icon;

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(SummonerNameText.Text))
            {
                MessageBox.Show("Please do not leave it blank.");
            }
            else
            {
                try
                {
                    var api = RiotApi.GetDevelopmentInstance("YOUR API KEY", 5, 5);
                    var summoner = api.Summoner.GetSummonerByNameAsync(RiotSharp.Misc.Region.Tr, SummonerNameText.Text).Result;
                    SumIDText.Text = summoner.Id.ToString();
                    SumLevelText.Text = summoner.Level.ToString();
                    SumNameText.Text = summoner.Name.ToString();
                    SumRegionText.Text = summoner.Region.ToString();
                    SummonerIconPicBox.Image = Image.FromFile(@"C:\Users\badgo\Desktop\League of Legends Profile Overview\League of Legends Profile Overview\League of Legends Profile Overview\Images\profileicon\" + summoner.ProfileIconId.ToString()+".png");
                   // Icon = "@Images/profileicon/"+summoner.ProfileIconId.ToString() + ".png";
                    //SummonerIconPicBox.ImageLocation = Icon;

                    //string filename = dirname + "pic" + i.ToString() + ".png";
                    //using (Bitmap bm = new Bitmap(filename))
                    //{
                    //    pics[i].Image = (Bitmap)bm.Clone();
                    //}

                }
                catch (RiotSharpException ex)
                {
                    MessageBox.Show("Error. \n" + ex.Message);
                    
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Summoner cannot be found.");
                }
            }
           
        }
    }
}
