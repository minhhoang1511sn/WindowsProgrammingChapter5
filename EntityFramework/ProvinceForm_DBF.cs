using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFramework
{
    public partial class ProvinceForm_DBF : Form
    {
        public ProvinceForm_DBF()
        {
            InitializeComponent();
        }
        SalesDBMF db = null;
        
        private void MySetProvince()
        {
            db = new SalesDBMF();
            var ProvinceQ = from ProvList in db.provinces
                            select ProvList;
            DataTable dt = new DataTable();
            dt.Columns.Add("Province_ID");
            dt.Columns.Add("Province_Name");
            foreach (var p in ProvinceQ)
            {
                dt.Rows.Add(p.province_id, p.province_name );
            }
            dtGridView.DataSource = dt;
        }
        private void Province_Load(object sender, EventArgs e)
        {
            MySetProvince();
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
            province DTQuery = db.provinces.Single(x => x.province_id ==
           tempDID);
            if (DTQuery != null)
            {
                var PrQuery2 = (from DT in db.provinces
                                where
DT.province_id == txtPID.Text
                                select DT).SingleOrDefault();

                if (DTQuery.province_id == txtPID.Text)
                {
                    //DTQuery.district_id = txtDID.Text;
                    DTQuery.province_name = txtPName.Text;
                    db.SaveChanges();
                }
                else
                {
                    if (PrQuery2 != null)
                    {
                        MessageBox.Show("Province_ID đã tồn tại trong Bảng  Province không sửa được!", "Lỗi khóa!");
                        return;
                    }
                    try
                    {
                        db.provinces.Remove(DTQuery);
                        db.SaveChanges(); province DT = new province();
                        DT.province_id = txtPID.Text;
                        DT.province_name = txtPName.Text;
                        db.provinces.Add(DT);
                        db.SaveChanges();
                    }
                    catch
                    {
                        MessageBox.Show("Province_ID đã tồn tại khóa ngoại trong bảng District, Vui lòng cập nhật Province_ID trong bảng District trước!", "Lỗi khóa ngoại!");
                    }
                }
            }
            MySetProvince();
        }
        private void dtGridView_CellContentClick(object sender,
       DataGridViewCellEventArgs e)
        {
            int r = dtGridView.CurrentCell.RowIndex;
            // Chuyển thông tin từ Gridview lên các textbox ở panel
            txtPID.Text = dtGridView.Rows[r].Cells[0].Value.ToString();
            txtPName.Text = dtGridView.Rows[r].Cells[1].Value.ToString();
        }
        private void btDelete_Click(object sender, EventArgs e)
        {
            int r = dtGridView.CurrentCell.RowIndex;
            string tempDID = dtGridView.Rows[r].Cells[0].Value.ToString();
            province PrQ = db.provinces.Single(x => x.province_id ==
           tempDID);
            //db.districts.DeleteOnSubmit(DistQ);
            //db.SubmitChanges();
            db.provinces.Remove(PrQ);
            db.SaveChanges();
            MySetProvince();
        }
        private void btAdd_Click(object sender, EventArgs e)
        {
            var DTQuery = (from DT in db.provinces
                           where DT.province_id == txtPID.Text
                           select DT).SingleOrDefault();
            if (DTQuery != null)
            {
                MessageBox.Show("Province ID is already existed", "Lỗi!");
            }
            else
            {

                    province DT = new province();
                    DT.province_id = txtPID.Text;
                    DT.province_name = txtPName.Text;
                 db.provinces.Add(DT);
                    db.SaveChanges();
                
                MySetProvince();
            }
        }
        private void btReload_Click(object sender, EventArgs e)
        {
            MySetProvince();
        }
        private void txtPID_Leave(object sender, EventArgs e)
        {
            txtPID.Text = txtPID.Text.Trim().ToUpper();
        }
        private void txtPName_Leave(object sender, EventArgs e)
        {
            txtPName.Text = txtPName.Text.Trim();

        }
    }
}
