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
    public partial class CategoryForm_DBF : Form
    {
        public CategoryForm_DBF()
        {
            InitializeComponent();
        }
        SalesDBMF db = null;

        private void MySetCategory()
        {
            db = new SalesDBMF();
            var CateQ = from CateList in db.categories
                            select CateList;
            DataTable dt = new DataTable();
            dt.Columns.Add("Category_ID");
            dt.Columns.Add("Category_Name");
            foreach (var p in CateQ)
            {
                dt.Rows.Add(p.category_id, p.category_name);
            }
            dtGridView.DataSource = dt;
        }
        private void Category_Load(object sender, EventArgs e)
        {
            MySetCategory();
        }
        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btSave_Click(object sender, EventArgs e)
        {
            //db = new SalesDBMF();
            int r = dtGridView.CurrentCell.RowIndex;
            string tempID = dtGridView.Rows[r].Cells[0].Value.ToString();
            category CateQuery = db.categories.Single(x => x.category_id ==
          int.Parse( tempID));
            if (CateQuery != null)
            {
                var PrQuery2 = (from DT in db.categories
                                where
DT.category_id ==int.Parse( txtCataID.Text)
                                select DT).SingleOrDefault();

                if (CateQuery.category_id ==int.Parse( txtCataID.Text))
                {
                    //CateQuery.district_id = txtDID.Text;
                    CateQuery.category_name = txtCataName.Text;
                    db.SaveChanges();
                }
                else
                {
                    if (PrQuery2 != null)
                    {
                        MessageBox.Show("Category_ID đã tồn tại trong Bảng  Categories không sửa được!", "Lỗi khóa!");
                        return;
                    }
                    try
                    {
                        db.categories.Remove(CateQuery);
                        db.SaveChanges(); category DT = new category();
                        DT.category_id =int.Parse( txtCataID.Text);
                        DT.category_name = txtCataID.Text;
                        db.categories.Add(DT);
                        db.SaveChanges();
                    }
                    catch
                    {
                        MessageBox.Show("Category_ID đã tồn tại khóa ngoại trong bảng Product, Vui lòng cập nhật Category_ID trong bảng Product trước!", "Lỗi khóa ngoại!");
                    }
                }
            }
            MySetCategory();
        }
        private void dtGridView_CellContentClick(object sender,
       DataGridViewCellEventArgs e)
        {
            int r = dtGridView.CurrentCell.RowIndex;
            // Chuyển thông tin từ Gridview lên các textbox ở panel
            txtCataID.Text = dtGridView.Rows[r].Cells[0].Value.ToString();
            txtCataName.Text = dtGridView.Rows[r].Cells[1].Value.ToString();
        }
        private void btDelete_Click(object sender, EventArgs e)
        {
            int r = dtGridView.CurrentCell.RowIndex;
            string tempID = dtGridView.Rows[r].Cells[0].Value.ToString();
            category CtQ = db.categories.Single(x => x.category_id ==
          int.Parse( tempID));
            //db.districts.DeleteOnSubmit(DistQ);
            //db.SubmitChanges();
            db.categories.Remove(CtQ);
            db.SaveChanges();
            MySetCategory();
        }
        private void btAdd_Click(object sender, EventArgs e)
        {
            var CateQuery = (from DT in db.categories
                           where DT.category_id ==int.Parse( txtCataID.Text)
                           select DT).SingleOrDefault();
            if (CateQuery != null)
            {
                MessageBox.Show("Category ID is already existed", "Lỗi!");
            }
            else
            {

                category DT = new category();
                DT.category_id =int.Parse( txtCataID.Text);
                DT.category_name = txtCataName.Text;
                db.categories.Add(DT);
                db.SaveChanges();

                MySetCategory();
            }
        }
        private void btReload_Click(object sender, EventArgs e)
        {
            MySetCategory();
        }
        private void txtCataID_Leave(object sender, EventArgs e)
        {
            txtCataID.Text = txtCataID.Text.Trim().ToUpper();
        }
        private void txtCataName_Leave(object sender, EventArgs e)
        {
            txtCataName.Text = txtCataName.Text.Trim();

        }
    }
}
