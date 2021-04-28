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
    public partial class BrandForm_DBF : Form
    {
        public BrandForm_DBF()
        {
            InitializeComponent();
        }
        SalesDBMF db = null;

        private void MySetBrand()
        {
            db = new SalesDBMF();
            var BrandQ = from BraList in db.brands
                            select BraList;
            DataTable dt = new DataTable();
            dt.Columns.Add("Brand_ID");
            dt.Columns.Add("Brand_Name");
            foreach (var p in BrandQ)
            {
                dt.Rows.Add(p.brand_id, p.brand_name);
            }
            dtGridView.DataSource = dt;
        }
        private void BrandForm_DBF_Load(object sender, EventArgs e)
        {
            MySetBrand();
        }
        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btSave_Click(object sender, EventArgs e)
        {
            //db = new SalesDBMF();
                int r = dtGridView.CurrentCell.RowIndex;
                string tempDID = dtGridView.Rows[r].Cells[1].Value.ToString();
                brand BrandQuery = db.brands.Single(x => x.brand_name ==
              tempDID);
                if (BrandQuery != null)
                {
                    var BrandQuery2 = (from DT in db.brands
                                       where
                           DT.brand_name == txtBrandname.Text
                                       select DT).SingleOrDefault();

                    if (BrandQuery.brand_name == txtBrandname.Text)
                    {
                        //BrandQuery.district_id = txtDID.Text;
                        BrandQuery.brand_name = txtBrandname.Text;
                        db.SaveChanges();
                    }
                    else
                    {
                        if (BrandQuery2 != null)
                        {
                            MessageBox.Show("Brand_name đã tồn tại trong Bảng  Brand không sửa được!", "Lỗi khóa!");
                            return;
                        }
                        try
                        {
                            db.brands.Remove(BrandQuery);
                            db.SaveChanges(); brand DT = new brand();
                            DT.brand_name = txtBrandname.Text;
                            db.brands.Add(DT);
                            db.SaveChanges();
                        }
                        catch
                        {
                            MessageBox.Show("Brand_ID đã tồn tại khóa ngoại trong bảng Product, Vui lòng cập nhật Brand_ID trong bảng Product trước!", "Lỗi khóa ngoại!");
                        }
                    }
                 MySetBrand();
            }
        }
        private void dtGridView_CellContentClick(object sender,
       DataGridViewCellEventArgs e)
        {
            int r = dtGridView.CurrentCell.RowIndex;
            // Chuyển thông tin từ Gridview lên các textbox ở panel
            txtID.Text = dtGridView.Rows[r].Cells[0].Value.ToString();
            txtBrandname.Text = dtGridView.Rows[r].Cells[1].Value.ToString();
        }
        private void btDelete_Click(object sender, EventArgs e)
        {
            int r = dtGridView.CurrentCell.RowIndex;
            string tempDID = dtGridView.Rows[r].Cells[1].Value.ToString();
            brand BraQ = db.brands.Single(x => x.brand_name ==
           tempDID);
            //db.districts.DeleteOnSubmit(DistQ);
            //db.SubmitChanges();
            db.brands.Remove(BraQ);
            db.SaveChanges();
            MySetBrand();
        }
        private void btAdd_Click(object sender, EventArgs e)
        {
            var BrandQuery = (from DT in db.brands
                           where DT.brand_name ==txtBrandname.Text
                           select DT).SingleOrDefault();
            if (BrandQuery != null)
            {
                MessageBox.Show("Brand name is already existed", "Lỗi!");
            }
            else
            {

                brand DT = new brand();
                DT.brand_name = txtBrandname.Text;
                db.brands.Add(DT);
                db.SaveChanges();

                MySetBrand();
            }
        }
        private void btReload_Click(object sender, EventArgs e)
        {
            MySetBrand();
        }
        private void txtID_Leave(object sender, EventArgs e)
        {
            txtID.Text = txtID.Text.Trim().ToUpper();
        }
        private void txtBrandname_Leave(object sender, EventArgs e)
        {
            txtBrandname.Text = txtBrandname.Text.Trim();

        }
    
    }
}
