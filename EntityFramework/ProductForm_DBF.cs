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
    public partial class ProductForm_DBF : Form
    {
        public ProductForm_DBF()
        {
            InitializeComponent();
        }
        SalesDBMF db = null;
        private void MySetBrand()
        {
            db = new SalesDBMF();
            var BrQ = from BraList in db.brands
                       select
           BraList.brand_id;
            foreach (int BraID in BrQ)
            {
                cbBrandID.Items.Add(BraID);
            }
            cbBrandID.SelectedIndex = 0;
        }
        private void MySetCategories()
        {
            db = new SalesDBMF();
            var CateQ = from CateList in db.categories
                       select
           CateList.category_id;
            foreach (int CateID in CateQ)
            {
                cbCateID.Items.Add(CateID);
            }
            cbCateID.SelectedIndex = 0;
        }
        private void MySetProduct()
        {
            var OrdiQ = from ProdList in db.products
                        join BrList in db.brands on
                       ProdList.brand_id equals BrList.brand_id
                        where (BrList.brand_id ==int.Parse( cbBrandID.Text))
                        join CateList in db.categories on
                        ProdList.category_id equals CateList.category_id
                        where (CateList.category_id ==int.Parse( cbCateID.Text))
                        select ProdList;
            DataTable dt = new DataTable();
            dt.Columns.Add("Product_ID");
            dt.Columns.Add("Product_name");
            dt.Columns.Add("Brand_ID");
            dt.Columns.Add("Category_ID");
            dt.Columns.Add("Modelyear");
            dt.Columns.Add("Listprice");
            foreach (var p in OrdiQ)
            {
                dt.Rows.Add(p.product_id, p.product_name, p.brand_id, p.category_id, p.model_year, p.list_price);
            }
            dtGridView.DataSource = dt;
        }
        private void ProductForm_Load(object sender, EventArgs e)
        {
            MySetBrand();
            MySetCategories();
            MySetProduct();
        }
        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtGridView_CellContentClick(object sender,
       DataGridViewCellEventArgs e)
        {
            int r = dtGridView.CurrentCell.RowIndex;
            // Chuyển thông tin từ Gridview lên các textbox ở panel
            txtProID.Text = dtGridView.Rows[r].Cells[0].Value.ToString();
            txtProductname.Text = dtGridView.Rows[r].Cells[1].Value.ToString();
            cbBrandID.Text = dtGridView.Rows[r].Cells[2].Value.ToString();
            cbCateID.Text = dtGridView.Rows[r].Cells[3].Value.ToString();
            txtModelyears.Text = dtGridView.Rows[r].Cells[4].Value.ToString();
            txtlistprice.Text = dtGridView.Rows[r].Cells[5].Value.ToString();
          
        }
        private void btDelete_Click(object sender, EventArgs e)
        {
            int r = dtGridView.CurrentCell.RowIndex;
            string tempDID = dtGridView.Rows[r].Cells[0].Value.ToString();
            product OrdQ = db.products.Single(x => x.product_id ==
          int.Parse(tempDID));
            //db.districts.DeleteOnSubmit(OrdiQ);
            //db.SubmitChanges();
            db.products.Remove(OrdQ);
            db.SaveChanges();
            MySetProduct();
        }
        private void btAdd_Click(object sender, EventArgs e)
        {
            var DTQuery = (from DT in db.products
                           where DT.product_id == int.Parse(txtProID.Text)
                           select DT).SingleOrDefault();
            if (DTQuery != null)
            {
                MessageBox.Show("Product ID is already existed", "Lỗi!");
            }
            else
            {
                try
                {
                    product DT = new product();
                    DT.product_id = int.Parse(txtProID.Text);
                    DT.product_name = txtProductname.Text;
                    DT.brand_id = int.Parse(cbBrandID.Text);
                    DT.category_id = int.Parse(cbCateID.Text);
                    DT.model_year = short.Parse(txtModelyears.Text);
                    DT.list_price = Decimal.Parse(txtlistprice.Text); db.products.Add(DT);
                    db.SaveChanges();
                }
                catch
                {
                    MessageBox.Show("Brand_id chưa tồn tại trong Bảng   Brand.Vui lòng cập nhật Brnad_id trong bảng Brand trước!", "Lỗi khóa ngoại!");
                    MessageBox.Show("Category_id chưa tồn tại trong Bảng   Category.Vui lòng cập nhật Category_id trong bảng Category trước!", "Lỗi khóa ngoại!");
                    
                }
                MySetCategories();
            }
        }
        private void btSave_Click(object sender, EventArgs e)
        {
            //db = new SalesDBMF();
            int r = dtGridView.CurrentCell.RowIndex;
            string tempDID = dtGridView.Rows[r].Cells[0].Value.ToString();
            product DTQuery = db.products.Single(x => x.product_id ==
          int.Parse(tempDID));
            if (DTQuery != null)
            {
                brand BraQuery2 = db.brands.Single(x => x.brand_id
               ==int.Parse( cbBrandID.Text));
                category CateQuery2 = db.categories.Single(x => x.category_id
               ==int.Parse( cbCateID.Text));
                var DTQuery2 = (from DT in db.products
                                where
DT.product_id == int.Parse(txtProID.Text)
                                select DT).SingleOrDefault();
                if (BraQuery2 == null)
                {
                    MessageBox.Show("Brand_id chưa tồn tại trong Bảng  Brand, Vui lòng cập nhật Brand_id trong bảng Brand trước!", "Lỗi khóa ngoại!");
                    return;
                }
                if (CateQuery2 == null)
                {
                    MessageBox.Show("Category_id chưa tồn tại trong Bảng  Category, Vui lòng cập nhật Category_id trong bảng CustoCategorymer trước!", "Lỗi khóa ngoại!");
                    return;
                }
               
                if (DTQuery.product_id == int.Parse(txtProID.Text))
                {
                    //DTQuery.district_id = txtDID.Text;
                    DTQuery.product_name = txtProductname.Text;
                    DTQuery.brand_id = int.Parse(cbBrandID.Text);
                    DTQuery.category_id = int.Parse(cbCateID.Text);
                    DTQuery.list_price = decimal.Parse(txtlistprice.Text);
                    DTQuery.model_year = short.Parse(txtModelyears.Text);
                    db.SaveChanges();
                }
                else
                {
                    if (DTQuery2 != null)
                    {
                        MessageBox.Show("Product_ID đã tồn tại trong Bảng  Product không sửa được!", "Lỗi khóa!");
                        return;
                    }

                    db.products.Remove(DTQuery);
                    db.SaveChanges(); product DT = new product();
                    DT.product_id = int.Parse(txtProID.Text);
                    DT.product_name = txtProductname.Text;
                    DT.brand_id = int.Parse(cbBrandID.Text);
                    DT.category_id = int.Parse(cbCateID.Text);
                    DT.list_price = decimal.Parse(txtlistprice.Text);
                    DT.model_year = short.Parse(txtModelyears.Text);
                    db.products.Add(DT);
                    db.SaveChanges();

                }
            }
            MySetProduct();
        }
        private void btReload_Click(object sender, EventArgs e)
        {
            MySetBrand();
            MySetCategories();
            MySetProduct();
        }
        private void txtProID_Leave(object sender, EventArgs e)
        {
            txtProID.Text = txtProID.Text.Trim().ToUpper();
        }
        private void txtProductname_Leave(object sender, EventArgs e)
        {
            txtProductname.Text = txtProductname.Text.Trim().ToUpper();
        }
        private void cbBrandID_Leave(object sender, EventArgs e)
        {
            cbBrandID.Text = cbBrandID.Text.Trim();

        }
        private void cbCateID_Leave(object sender, EventArgs e)
        {
            cbCateID.Text = cbCateID.Text.Trim().ToUpper();
        }
        private void txtlistpricee_Leave(object sender, EventArgs e)
        {
            txtlistprice.Text = txtlistprice.Text.Trim().ToUpper();
        }
        private void txtModelyears_Leave(object sender, EventArgs e)
        {
            txtModelyears.Text = txtModelyears.Text.Trim();

        }
    }
}
