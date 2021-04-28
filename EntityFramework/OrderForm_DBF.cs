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
    public partial class OrderForm_DBF : Form
    {
        public OrderForm_DBF()
        {
            InitializeComponent();
        }
        SalesDBMF db = null;
        private void MySetStore()
        {
            db = new SalesDBMF();
            var STOQ = from StoList in db.stores
                       select
           StoList.store_id;
            foreach (string StoID in STOQ)
            {
                cbStore.Items.Add(StoID);
            }
            cbStore.SelectedIndex = 0;
        }
        private void MySetStaff()
        {
            db = new SalesDBMF();
            var StaQ = from StaList in db.staffs
                       select
           StaList.staff_id;
            foreach (string StaID in StaQ)
            {
                cbStaff.Items.Add(StaID);
            }
            cbStaff.SelectedIndex = 0;
        }
        private void MySetCustomer()
        {
            db = new SalesDBMF();
            var CusQ = from CusList in db.customers
                       select
           CusList.customer_id;
            foreach (string CusID in CusQ)
            {
                cbCusto.Items.Add(CusID);
            }
            cbCusto.SelectedIndex = 0;
        }
        private void MySetOrder()
        {
            var OrdiQ = from OrderList in db.orders
                        join StoList in db.stores on
                       OrderList.store_id equals StoList.store_id
                        where (StoList.store_id == cbStore.Text)
                        join StaList in db.staffs on
                        OrderList.staff_id equals StaList.staff_id
                        where (StaList.staff_id == cbStaff.Text)
                        select OrderList;
            DataTable dt = new DataTable();
            dt.Columns.Add("Order_ID");
            dt.Columns.Add("Customer_ID");
            dt.Columns.Add("Order_status");
            dt.Columns.Add("Order_date");
            dt.Columns.Add("Require_date");
            dt.Columns.Add("Shipped_date");
            dt.Columns.Add("Store_id");
            dt.Columns.Add("Staff_id");
            foreach (var p in OrdiQ)
            {
                dt.Rows.Add(p.order_id, p.customer_id, p.order_status, p.order_date, p.shipped_date, p.store_id,p.staff_id);
            }
            dtGridView.DataSource = dt;
        }
        private void OrderForm_Load(object sender, EventArgs e)
        {
            MySetStore();
            MySetCustomer();
            MySetStaff();
            MySetOrder();
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
            txtOrID.Text = dtGridView.Rows[r].Cells[0].Value.ToString();
            cbCusto.Text = dtGridView.Rows[r].Cells[1].Value.ToString();
            txtOrderstatus.Text = dtGridView.Rows[r].Cells[2].Value.ToString();
            txtxOrderdate.Text = dtGridView.Rows[r].Cells[3].Value.ToString();
            txtrequireddate.Text = dtGridView.Rows[r].Cells[4].Value.ToString();
            txtShipped_date.Text = dtGridView.Rows[r].Cells[5].Value.ToString();
            cbStore.Text = dtGridView.Rows[r].Cells[6].Value.ToString();
            cbStaff.Text = dtGridView.Rows[r].Cells[7].Value.ToString();
        }
        private void btDelete_Click(object sender, EventArgs e)
        {
            int r = dtGridView.CurrentCell.RowIndex;
            string tempDID = dtGridView.Rows[r].Cells[0].Value.ToString();
            order OrdQ = db.orders.Single(x => x.order_id ==
          int.Parse(tempDID));
            //db.districts.DeleteOnSubmit(OrdiQ);
            //db.SubmitChanges();
            db.orders.Remove(OrdQ);
            db.SaveChanges();
            MySetOrder();
        }
        private void btAdd_Click(object sender, EventArgs e)
        {
            var DTQuery = (from DT in db.orders
                           where DT.order_id == int.Parse(txtOrID.Text)
                           select DT).SingleOrDefault();
            if (DTQuery != null)
            {
                MessageBox.Show("Order ID is already existed", "Lỗi!");
            }
            else
            {
                try
                {
                    order DT = new order();
                    DT.order_id = int.Parse(txtOrID.Text);
                    DT.customer_id = cbCusto.Text;
                    DT.order_status = byte.Parse(txtOrderstatus.Text);
                    DT.order_date =DateTime.Parse( txtxOrderdate.Text);
                    DT.required_date =DateTime.Parse( txtrequireddate.Text);
                    DT.shipped_date = DateTime.Parse(txtShipped_date.Text);
                    DT.store_id = cbStore.Text;
                    DT.staff_id = cbStaff.Text; db.orders.Add(DT);
                    db.SaveChanges();
                }
                catch
                {
                    MessageBox.Show("Customer_id chưa tồn tại trong Bảng   Customer.Vui lòng cập nhật Customer_id trong bảng Customer trước!", "Lỗi khóa ngoại!");
                    MessageBox.Show("Store_id chưa tồn tại trong Bảng   Store.Vui lòng cập nhật Store_id trong bảng Store trước!", "Lỗi khóa ngoại!");
                    MessageBox.Show("Staff_id chưa tồn tại trong Bảng   Staff.Vui lòng cập nhật Staff_id trong bảng Staff trước!", "Lỗi khóa ngoại!");
                }
                MySetOrder();
            }
        }
        private void btSave_Click(object sender, EventArgs e)
        {
            //db = new SalesDBMF();
            int r = dtGridView.CurrentCell.RowIndex;
            string tempDID = dtGridView.Rows[r].Cells[0].Value.ToString();
            order DTQuery = db.orders.Single(x => x.order_id ==
          int.Parse(tempDID));
            if (DTQuery != null)
            {
                store OdrQuery2 = db.stores.Single(x => x.store_id
               == cbStore.Text);
                customer CusQuery2 = db.customers.Single(x => x.customer_id
               == cbCusto.Text);
                staff StaQuery2 = db.staffs.Single(x => x.staff_id
               == cbStaff.Text);
                var DTQuery2 = (from DT in db.orders
                                where
DT.order_id == int.Parse(txtOrID.Text)
                                select DT).SingleOrDefault();
                if (OdrQuery2 == null)
                {
                    MessageBox.Show("Store_id chưa tồn tại trong Bảng  Store, Vui lòng cập nhật Store_id trong bảng Store trước!", "Lỗi khóa ngoại!");
                    return;
                }
                if (CusQuery2 == null)
                {
                    MessageBox.Show("Customer_id chưa tồn tại trong Bảng  Customer, Vui lòng cập nhật Customer_id trong bảng Customer trước!", "Lỗi khóa ngoại!");
                    return;
                }
                if (StaQuery2 == null)
                {
                    MessageBox.Show("Staff_id chưa tồn tại trong Bảng  Staff, Vui lòng cập nhật Staff_id trong bảng Staff trước!", "Lỗi khóa ngoại!");
                    return;
                }
                if (DTQuery.order_id == int.Parse(txtOrID.Text))
                {
                    //DTQuery.district_id = txtDID.Text;
                    DTQuery.customer_id = cbCusto.Text;
                    DTQuery.order_status = byte.Parse(txtOrderstatus.Text);
                    DTQuery.order_date = DateTime.Parse(txtxOrderdate.Text);
                    DTQuery.required_date = DateTime.Parse(txtrequireddate.Text);
                    DTQuery.shipped_date = DateTime.Parse( txtShipped_date.Text);
                    DTQuery.store_id = cbStore.Text;
                    DTQuery.staff_id = cbStaff.Text;
                    db.SaveChanges();
                }
                else
                {
                    if (DTQuery2 != null)
                    {
                        MessageBox.Show("Order_ID đã tồn tại trong Bảng  Order không sửa được!", "Lỗi khóa!");
                        return;
                    }

                    db.orders.Remove(DTQuery);
                    db.SaveChanges(); order DT = new order();
                    DT.customer_id = cbCusto.Text;
                    DT.order_status = byte.Parse(txtOrderstatus.Text);
                    DT.order_date = DateTime.Parse(txtxOrderdate.Text);
                    DT.required_date = DateTime.Parse(txtrequireddate.Text);
                    DT.shipped_date = DateTime.Parse(txtShipped_date.Text);
                    DT.store_id = cbStore.Text;
                    DT.staff_id = cbStaff.Text;
                    db.orders.Add(DT);
                    db.SaveChanges();

                }
            }
            MySetOrder();
        }
        private void btReload_Click(object sender, EventArgs e)
        {
            MySetCustomer();
            MySetStaff();
            MySetStore();
        }
        private void txtOrID_Leave(object sender, EventArgs e)
        {
            txtOrID.Text = txtOrID.Text.Trim().ToUpper();
        }
        private void cbCusto_Leave(object sender, EventArgs e)
        {
            cbCusto.Text = cbCusto.Text.Trim().ToUpper();
        }
        private void txtOrderstatus_Leave(object sender, EventArgs e)
        {
            txtOrderstatus.Text = txtOrderstatus.Text.Trim();

        }
        private void txtxOrderdate_Leave(object sender, EventArgs e)
        {
            txtxOrderdate.Text = txtxOrderdate.Text.Trim().ToUpper();
        }
        private void txtrequireddate_Leave(object sender, EventArgs e)
        {
            txtrequireddate.Text = txtrequireddate.Text.Trim().ToUpper();
        }
        private void txtShipped_date_Leave(object sender, EventArgs e)
        {
            txtShipped_date.Text = txtShipped_date.Text.Trim();

        }
        private void cbStore_Leave(object sender, EventArgs e)
        {
            cbStore.Text = cbStore.Text.Trim().ToUpper();
        }
        private void cbStaff_Leave(object sender, EventArgs e)
        {
            cbStaff.Text = cbStaff.Text.Trim().ToUpper();
        }
    }
}
