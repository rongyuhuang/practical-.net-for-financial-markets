using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIThreadUpdate
{

    public delegate void SetProgressBar(int value);

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            //Starts the bulk order upload on worker thread
            System.Threading.ThreadPool.QueueUserWorkItem(
                new System.Threading.WaitCallback(BulkOrderUpload));
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void UpdateProgressBar(int current)
        {
            //update the progress bar control
            uploadProgressBar.Value = current;
        }

        private void BulkOrderUpload(object state)
        {
            int ctr = 0;
            int totalRecord = 10500;
            //Read bulk order imort file and initialize the values
            //such as total numeber of orders to import
            while (ctr < totalRecord)
            {
                //update progress bar control value
                //this needs to be done on UI thread
                uploadProgressBar.Invoke(new SetProgressBar(UpdateProgressBar), new object[] { ctr });
                ++ctr;
            }
        }
    }
}
