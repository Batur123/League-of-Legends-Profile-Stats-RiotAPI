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

        public class Summoner
        {
            public int id { get; set; }
            public string key { get; set; }
            public string name { get; set; }
            public string title { get; set; }
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(SummonerNameText.Text))
            {
                MessageBox.Show("Please do not leave it blank.");
            }
            else
            {
                try
                {
                    var api = RiotApi.GetDevelopmentInstance("RGAPI-61910994-57c8-49b3-8fd4-44b5d6604573", 5, 5);
                    var summoner = api.Summoner.GetSummonerByNameAsync(RiotSharp.Misc.Region.Tr, SummonerNameText.Text).Result;
                    SumIDText.Text = summoner.Id.ToString();
                    SumLevelText.Text = summoner.Level.ToString();
                    SumNameText.Text = summoner.Name.ToString();
                    SumRegionText.Text = summoner.Region.ToString();
                    MessageBox.Show(summoner.ProfileIconId.ToString());

                }
                catch (RiotSharpException ex)
                {
                    MessageBox.Show("Error. \n" + ex.Message);
                }
            }
           
        }
    }
}
