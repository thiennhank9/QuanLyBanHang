using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHang
{
    //Class declare all form
    class ControllerForms : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        //Fields
        private static frmLapHDBH _frmLapHDBH = null;
        private static frmHoaDonBanHang _frmHoaDonBanHang = null;

        //Properties with get and set
        public frmLapHDBH frmLapHDBH
        {
            get { return _frmLapHDBH; }
            set { _frmLapHDBH = value; }
        }

        public frmHoaDonBanHang frmHoaDonBanHang
        {
            get { return _frmHoaDonBanHang; }
            set { _frmHoaDonBanHang = value; }
        }

        //this function should be shorter --- any ideas???
        public void showForm(int indexForm, Form frmMain)
        {
            switch(indexForm)
            {
                case 0:
                    if (this.frmLapHDBH != null)
                        this.frmLapHDBH.Activate();
                    else
                    {
                        this.frmLapHDBH = new frmLapHDBH();
                        this.frmLapHDBH.MdiParent = frmMain;
                        this.frmLapHDBH.Show();
                    }
                    break;
                case 1:
                    if (this.frmHoaDonBanHang != null)
                        this.frmHoaDonBanHang.Activate();
                    else
                    {
                        this.frmHoaDonBanHang = new frmHoaDonBanHang();
                        this.frmHoaDonBanHang.MdiParent = frmMain;
                        this.frmHoaDonBanHang.Show();
                    }
                    break;
                default:
                    return;
            }
           
        }
    }
}
