using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinRestClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRunRESTmethod_Click(object sender, EventArgs e)
        {

            RestClient restClient = new RestClient();
            restClient.endPoint = TBReqURI.Text;            

            TBResponse.Text = "rest client ready";

            string APIkey = TBApiKey.Text;
            string respStr = "";

            try
            {
                respStr = restClient.RunRequest(APIkey);
            }
            catch (Exception ex)
            {
                respStr = ex.Message;
            }
            
            TBResponse.Text += Environment.NewLine + respStr;

        }
    }
}
