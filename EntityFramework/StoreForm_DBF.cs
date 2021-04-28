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
    public partial class StoreForm_DBF : Form
    {
        public StoreForm_DBF()
        {
            InitializeComponent();
        }
        SalesDBMF db = null;

        private void MySetStore()
        {
            db = new SalesDBMF();
            var StoQ = from StoreList in db.stores
                        select StoreList;
            DataTable dt = new DataTable();
            dt.Columns.Add("Store_ID");
            dt.Columns.Add("Store_Name");
            dt.Columns.Add("Phone");
            dt.Columns.Add("Email");
            dt.Columns.Add("Street");
            dt.Columns.Add("City");
            dt.Columns.Add("State/Province");
            dt.Columns.Add("Zipcode");
            foreach (var p in StoQ)
            {
                dt.Rows.Add(p.store_id, p.store_name,p.phone,p.email,p.street,p.city,p.state,p.zip_code);
            }
            dtGridView.DataSource = dt;
        }
        private void StoreForm_Load(object sender, EventArgs e)
        {
            MySetStore();
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
            store StoQuery = db.stores.Single(x => x.store_id ==
          tempID);
            if (StoQuery != null)
            {
                var PrQuery2 = (from DT in db.stores
                                where
DT.store_id == txtSID.Text
                                select DT).SingleOrDefault();

                if (StoQuery.store_id == txtSID.Text)
                {
                    //StoQuery.district_id = txtDID.Text;
                    StoQuery.store_name = txtSName.Text;
                    StoQuery.phone = txtPhone.Text;
                    StoQuery.email = txtEmail.Text;
                    StoQuery.street = txtStreet.Text;
                    StoQuery.city = txtCity.Text;
                    StoQuery.state = txtState.Text;
                    StoQuery.zip_code = txtZipcode.Text;
                    db.SaveChanges();
                }
                else
                {
                    if (PrQuery2 != null)
                    {
                        MessageBox.Show("Store_ID đã tồn tại trong Bảng  Stores không sửa được!", "Lỗi khóa!");
                        return;
                    }
                    try
                    {
                        db.stores.Remove(StoQuery);
                        db.SaveChanges(); store DT = new store();
                        DT.store_id = txtSID.Text;
                        DT.store_name = txtSName.Text;
                        DT.phone = txtPhone.Text;
                        DT.email = txtEmail.Text;
                        DT.street = txtStreet.Text;
                        DT.city = txtCity.Text;
                        DT.state = txtState.Text;
                        DT.zip_code = txtZipcode.Text;
                        db.stores.Add(DT);
                        db.SaveChanges();
                    }
                    catch
                    {
                        MessageBox.Show("Store_ID đã tồn tại khóa ngoại trong bảng staff, stock và order, Vui lòng cập nhật Store_ID trong bảng đó trước!", "Lỗi khóa ngoại!");
                    }
                }
            }
            MySetStore();
        }
        private void dtGridView_CellContentClick(object sender,
       DataGridViewCellEventArgs e)
        {
            int r = dtGridView.CurrentCell.RowIndex;
            // Chuyển thông tin từ Gridview lên các textbox ở panel
            txtSID.Text = dtGridView.Rows[r].Cells[0].Value.ToString();
            txtSName.Text = dtGridView.Rows[r].Cells[1].Value.ToString();
            txtPhone.Text = dtGridView.Rows[r].Cells[2].Value.ToString();
            txtEmail.Text = dtGridView.Rows[r].Cells[3].Value.ToString();
            txtStreet.Text = dtGridView.Rows[r].Cells[4].Value.ToString();
            txtCity.Text = dtGridView.Rows[r].Cells[5].Value.ToString();
            txtState.Text = dtGridView.Rows[r].Cells[6].Value.ToString();
            txtZipcode.Text = dtGridView.Rows[r].Cells[7].Value.ToString();
        }
        private void btDelete_Click(object sender, EventArgs e)
        {
            int r = dtGridView.CurrentCell.RowIndex;
            string tempID = dtGridView.Rows[r].Cells[0].Value.ToString();
            store CtQ = db.stores.Single(x => x.store_id ==
          tempID);
            //db.districts.DeleteOnSubmit(DistQ);
            //db.SubmitChanges();
            db.stores.Remove(CtQ);
            db.SaveChanges();
            MySetStore();
        }
        private void btAdd_Click(object sender, EventArgs e)
        {
            var StoQuery = (from DT in db.stores
                             where DT.store_id == txtSID.Text
                             select DT).SingleOrDefault();
            if (StoQuery != null)
            {
                MessageBox.Show("Store ID is already existed", "Lỗi!");
            }
            else
            {

                store DT = new store();
                DT.store_id = txtSID.Text;
                DT.store_name = txtSName.Text;
                DT.phone = txtPhone.Text;
                DT.email = txtEmail.Text;
                DT.street = txtStreet.Text;
                DT.city = txtCity.Text;
                DT.state = txtState.Text;
                DT.zip_code = txtZipcode.Text;
                db.stores.Add(DT);
                db.SaveChanges();

                MySetStore();
            }
        }
        private void btReload_Click(object sender, EventArgs e)
        {
            MySetStore();
        }
        private void txtSID_Leave(object sender, EventArgs e)
        {
            txtSID.Text = txtSID.Text.Trim().ToUpper();
        }
        private void txtSName_Leave(object sender, EventArgs e)
        {
            txtSName.Text = txtSName.Text.Trim();

        }
        private void txtPhone_Leave(object sender, EventArgs e)
        {
            txtPhone.Text = txtPhone.Text.Trim().ToUpper();
        }
        private void txtEmail_Leave(object sender, EventArgs e)
        {
            txtEmail.Text = txtEmail.Text.Trim();

        }
        private void txtStreet_Leave(object sender, EventArgs e)
        {
            txtStreet.Text = txtStreet.Text.Trim().ToUpper();
        }
        private void txtCity_Leave(object sender, EventArgs e)
        {
            txtCity.Text = txtCity.Text.Trim();

        }
        private void txtState_Leave(object sender, EventArgs e)
        {
            txtState.Text = txtState.Text.Trim().ToUpper();
        }
        private void txtZipcode_Leave(object sender, EventArgs e)
        {
            txtZipcode.Text = txtZipcode.Text.Trim();

        }
    }
}
