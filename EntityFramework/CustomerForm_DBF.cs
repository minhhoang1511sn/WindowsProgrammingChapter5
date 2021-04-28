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
    public partial class CustomerForm_DBF : Form
    {
        public CustomerForm_DBF()
        {
            InitializeComponent();
        }
        SalesDBMF db = null;

        private void MySetCustomer()
        {
            db = new SalesDBMF();
            var CusQ = from CusList in db.customers
                       select CusList;
            DataTable dt = new DataTable();
            dt.Columns.Add("Customer_ID");
            dt.Columns.Add("First_Name");
            dt.Columns.Add("Last_Name");
            dt.Columns.Add("Phone");
            dt.Columns.Add("Email");
            dt.Columns.Add("Street");
            dt.Columns.Add("City");
            dt.Columns.Add("State/Province");
            dt.Columns.Add("Zipcode");
            foreach (var p in CusQ)
            {
                dt.Rows.Add(p.customer_id, p.first_name,p.last_name, p.phone, p.email, p.street, p.city, p.state, p.zip_code);
            }
            dtGridView.DataSource = dt;
        }
        private void CustomerForm_Load(object sender, EventArgs e)
        {
            MySetCustomer();
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
            customer CusQuery = db.customers.Single(x => x.customer_id ==
          tempID);
            if (CusQuery != null)
            {
                var PrQuery2 = (from DT in db.customers
                                where
DT.customer_id == txtCusID.Text
                                select DT).SingleOrDefault();

                if (CusQuery.customer_id == txtCusID.Text)
                {
                    //CusQuery.district_id = txtDID.Text;
                    CusQuery.first_name = txtFName.Text;
                    CusQuery.last_name = txtLname.Text;
                    CusQuery.phone = txtPhone.Text;
                    CusQuery.email = txtEmail.Text;
                    CusQuery.street = txtStreet.Text;
                    CusQuery.city = txtCity.Text;
                    CusQuery.state = txtState.Text;
                    CusQuery.zip_code = txtZipcode.Text;
                    db.SaveChanges();
                }
                else
                {
                    if (PrQuery2 != null)
                    {
                        MessageBox.Show("Customer_ID đã tồn tại trong Bảng  Customer không sửa được!", "Lỗi khóa!");
                        return;
                    }
                    try
                    {
                        db.customers.Remove(CusQuery);
                        db.SaveChanges(); customer DT = new customer();
                        DT.customer_id = txtCusID.Text;
                        DT.first_name = txtFName.Text;
                        DT.last_name = txtLname.Text;
                        DT.phone = txtPhone.Text;
                        DT.email = txtEmail.Text;
                        DT.street = txtStreet.Text;
                        DT.city = txtCity.Text;
                        DT.state = txtState.Text;
                        DT.zip_code = txtZipcode.Text;
                        db.customers.Add(DT);
                        db.SaveChanges();
                    }
                    catch
                    {
                        MessageBox.Show("Customer_ID đã tồn tại khóa ngoại trong bảng order, Vui lòng cập nhật Store_ID trong bảng order trước!", "Lỗi khóa ngoại!");
                    }
                }
            }
            MySetCustomer();
        }
        private void dtGridView_CellContentClick(object sender,
       DataGridViewCellEventArgs e)
        {
            int r = dtGridView.CurrentCell.RowIndex;
            // Chuyển thông tin từ Gridview lên các textbox ở panel
            txtCusID.Text = dtGridView.Rows[r].Cells[0].Value.ToString();
            txtFName.Text = dtGridView.Rows[r].Cells[1].Value.ToString();
            txtLname.Text = dtGridView.Rows[r].Cells[2].Value.ToString();
            txtPhone.Text = dtGridView.Rows[r].Cells[3].Value.ToString();
            txtEmail.Text = dtGridView.Rows[r].Cells[4].Value.ToString();
            txtStreet.Text = dtGridView.Rows[r].Cells[5].Value.ToString();
            txtCity.Text = dtGridView.Rows[r].Cells[6].Value.ToString();
            txtState.Text = dtGridView.Rows[r].Cells[7].Value.ToString();
            txtZipcode.Text = dtGridView.Rows[r].Cells[8].Value.ToString();
        }
        private void btDelete_Click(object sender, EventArgs e)
        {
            int r = dtGridView.CurrentCell.RowIndex;
            string tempID = dtGridView.Rows[r].Cells[0].Value.ToString();
            customer CutQ = db.customers.Single(x => x.customer_id ==
          tempID);
            //db.districts.DeleteOnSubmit(DistQ);
            //db.SubmitChanges();
            db.customers.Remove(CutQ);
            db.SaveChanges();
            MySetCustomer();
        }
        private void btAdd_Click(object sender, EventArgs e)
        {
            var CusQuery = (from DT in db.customers
                            where DT.customer_id == txtCusID.Text
                            select DT).SingleOrDefault();
            if (CusQuery != null)
            {
                MessageBox.Show("Customer ID is already existed", "Lỗi!");
            }
            else
            {

                customer DT = new customer();
                DT.customer_id = txtCusID.Text;
                DT.first_name = txtFName.Text;
                DT.last_name = txtLname.Text;
                DT.phone = txtPhone.Text;
                DT.email = txtEmail.Text;
                DT.street = txtStreet.Text;
                DT.city = txtCity.Text;
                DT.state = txtState.Text;
                DT.zip_code = txtZipcode.Text;
                db.customers.Add(DT);
                db.SaveChanges();

                MySetCustomer();
            }
        }
        private void btReload_Click(object sender, EventArgs e)
        {
            MySetCustomer();
        }
        private void txtCusID_Leave(object sender, EventArgs e)
        {
            txtCusID.Text = txtCusID.Text.Trim().ToUpper();
        }
        private void txtFName_Leave(object sender, EventArgs e)
        {
            txtFName.Text = txtFName.Text.Trim();

        }
        private void txtLname_Leave(object sender, EventArgs e)
        {
            txtLname.Text = txtLname.Text.Trim();

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
