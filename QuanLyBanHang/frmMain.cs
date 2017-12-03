using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace QuanLyBanHang
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        //Fields
        private ControllerForms controllerForms = new ControllerForms();

        public frmMain()
        {
            InitializeComponent();
        }

        //Properties
        //Function click button to show/active form
        private void btnLapHDBH_ItemClick(object sender, ItemClickEventArgs e)
        {
            controllerForms.showForm(0, this);
        }

        private void btnXemHDBH_ItemClick(object sender, ItemClickEventArgs e)
        {
            controllerForms.showForm(1,this);
        }
    }

}