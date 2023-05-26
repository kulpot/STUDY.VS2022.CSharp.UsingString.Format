using System;
using System.Windows.Forms;

namespace UsingString.Format__
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SetFormText();
        }

        private void SetFormText()
        {
            //Product name, version then size
            const string FORMAT = "{0,50} v{1} Size={2}"; // format information = "{0,50:NO}....."; ref: MSDN documentation
            this.Text = string.Format(FORMAT, Application.ProductName, 
                Application.ProductVersion, this.Size);
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);  
            SetFormText();
        }
    }
}
