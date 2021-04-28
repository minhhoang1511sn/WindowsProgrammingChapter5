using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFramework
{
    public partial class DistrictForm_DBF : Form
    {
        public DistrictForm_DBF()
        {
            InitializeComponent();
        }
        SalesDBMF db = null;
        private void MySetProvince()
        {
            db = new SalesDBMF();
            var ProvQ = from ProvList in db.provinces
                        select
            ProvList.province_name;
            foreach (string ProvName in ProvQ)
            {
                cbProv.Items.Add(ProvName);
            }
            cbProv.SelectedIndex = 0;
        }
        private void MySetDistrict()
        {
            var DistQ = from DistList in db.districts
                        join ProvList in db.provinces on
                       DistList.province_id equals ProvList.province_id
                        where (ProvList.province_name == cbProv.Text)
                        select DistList;
            DataTable dt = new DataTable();
            dt.Columns.Add("District_ID");
            dt.Columns.Add("District_Name");
            dt.Columns.Add("Province_ID");
            foreach (var p in DistQ)
            {
                dt.Rows.Add(p.district_id, p.district_name, p.province_id);
            }
            dtGridView.DataSource = dt;
        }
        private void DistrictForm_Load(object sender, EventArgs e)
        {
            MySetProvince();
        }
        private void cbProv_SelectedValueChanged(object sender, EventArgs
       e)
        {
            MySetDistrict();
        }
        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btSave_Click(object sender, EventArgs e)
        {
            //db = new SalesDBMF();
            int r = dtGridView.CurrentCell.RowIndex;
            string tempDID = dtGridView.Rows[r].Cells[0].Value.ToString();
            district DTQuery = db.districts.Single(x => x.district_id ==
           tempDID);
            if (DTQuery != null)
            {
                province PRQuery2 = db.provinces.Single(x => x.province_id
               == txtPID.Text);
                var DTQuery2 = (from DT in db.districts
                                where
DT.district_id == txtDID.Text
                                select DT).SingleOrDefault();
                if (PRQuery2 == null)
                {
                    MessageBox.Show("Province_id chưa tồn tại trong Bảng  Province, Vui lòng cập nhật Province_id trong bảngProvince trước!", "Lỗi khóa ngoại!");
                return;
                }
                if (DTQuery.district_id == txtDID.Text)
                {
                    //DTQuery.district_id = txtDID.Text;
                    DTQuery.district_name = txtDName.Text;
                    DTQuery.province_id = txtPID.Text;
                    db.SaveChanges();
                }
                else
                {
                    if (DTQuery2 != null)
                    {
                        MessageBox.Show("District_ID đã tồn tại trong Bảng  District không sửa được!", "Lỗi khóa!");
                    return;
                    }
                    try
                    {
                        db.districts.Remove(DTQuery);
                        db.SaveChanges(); district DT = new district();
                        DT.district_id = txtDID.Text;
                        DT.district_name = txtDName.Text;
                        DT.province_id = txtPID.Text;
                        db.districts.Add(DT);
                        db.SaveChanges();
                    }
                    catch
                    {
                        MessageBox.Show("District_ID đã tồn tại khóa ngoại trong bảng Commune, Vui lòng cập nhật District_ID trong bảng Commune trước!", "Lỗi khóa ngoại!");
                   }
                }
            }
            MySetDistrict();
        }
        private void dtGridView_CellContentClick(object sender,
       DataGridViewCellEventArgs e)
        {
            int r = dtGridView.CurrentCell.RowIndex;
            // Chuyển thông tin từ Gridview lên các textbox ở panel
            txtDID.Text = dtGridView.Rows[r].Cells[0].Value.ToString();
            txtDName.Text = dtGridView.Rows[r].Cells[1].Value.ToString();
            txtPID.Text = dtGridView.Rows[r].Cells[2].Value.ToString();
        }
        private void btDelete_Click(object sender, EventArgs e)
        {
            int r = dtGridView.CurrentCell.RowIndex;
            string tempDID = dtGridView.Rows[r].Cells[0].Value.ToString();
            district DistQ = db.districts.Single(x => x.district_id ==
           tempDID);
            //db.districts.DeleteOnSubmit(DistQ);
            //db.SubmitChanges();
            db.districts.Remove(DistQ);
            db.SaveChanges();
            MySetDistrict();
        }
        private void btAdd_Click(object sender, EventArgs e)
        {
            var DTQuery = (from DT in db.districts
                           where DT.district_id == txtDID.Text
                           select DT).SingleOrDefault();
            if (DTQuery != null)
            {
                MessageBox.Show("District ID is already existed", "Lỗi!");
            }
            else
            {
                try
                {
                    district DT = new district();
                    DT.district_id = txtDID.Text;
                    DT.district_name = txtDName.Text;
                    DT.province_id = txtPID.Text; db.districts.Add(DT);
                    db.SaveChanges();
                }
                catch
                {
                    MessageBox.Show("Province_id chưa tồn tại trong Bảng   Province.Vui lòng cập nhật Province_id trong bảng Province trước!", "Lỗi khóa ngoại!");
                }
                MySetDistrict();
            }
        }
        private void btReload_Click(object sender, EventArgs e)
        {
            MySetProvince();
        }
        private void txtDID_Leave(object sender, EventArgs e)
        {
            txtDID.Text = txtDID.Text.Trim().ToUpper();
        }
        private void txtDName_Leave(object sender, EventArgs e)
        {
            txtDName.Text = txtDName.Text.Trim();

        }
        private void txtPID_Leave(object sender, EventArgs e)
        {
            txtPID.Text = txtPID.Text.Trim().ToUpper();
        }
    }
}
