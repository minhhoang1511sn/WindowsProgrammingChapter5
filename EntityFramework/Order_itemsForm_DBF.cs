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
    public partial class Order_itemsForm_DBF : Form
    {
        public Order_itemsForm_DBF()
        {
            InitializeComponent();
        }
        SalesDBMF db = null;
        private void MySetOrder()
        {
            db = new SalesDBMF();
            var OrdQ = from OrdList in db.orders
                        select
            OrdList.order_id;
            foreach (int OrdID in OrdQ)
            {
                cbOrdersID.Items.Add(OrdID);
            }
            cbOrdersID.SelectedIndex = 0;
        }
        private void MySetProduct()
        {
            db = new SalesDBMF();
            var ProQ = from ProList in db.products
                       select
           ProList.product_id;
            foreach (int ProID in ProQ)
            {
                cbProductID.Items.Add(ProID);
            }
            cbProductID.SelectedIndex = 0;
        }
        private void MySetOrder_item()
        {
            var OrdiQ = from Order_itemList in db.order_item
                        join OrderList in db.orders on
                       Order_itemList.order_id equals OrderList.order_id
                        where (OrderList.order_id ==int.Parse( cbOrdersID.Text))
                        join ProList in db.products on
                       Order_itemList.product_id equals ProList.product_id
                        where (ProList.product_id == int.Parse(cbProductID.Text))
                        select Order_itemList;
            DataTable dt = new DataTable();
            dt.Columns.Add("Order_ID");
            dt.Columns.Add("Item_ID");
            dt.Columns.Add("Product_ID");
            dt.Columns.Add("Quanity");
            dt.Columns.Add("List_price");
            dt.Columns.Add("Discount");
            foreach (var p in OrdiQ)
            {
                dt.Rows.Add(p.order_id, p.item_id, p.product_id,p.quantity,p.list_price,p.discount);
            }
            dtGridView.DataSource = dt;
        }
        private void DistrictForm_Load(object sender, EventArgs e)
        {
            MySetOrder();
            MySetProduct();
            MySetOrder_item();
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
            order_item DTQuery = db.order_item.Single(x => x.item_id ==
          int.Parse( tempDID));
            if (DTQuery != null)
            {
                order OdrQuery2 = db.orders.Single(x => x.order_id
               ==int.Parse( cbOrdersID.Text));
                product PrQuery2 = db.products.Single(x => x.product_id
               == int.Parse(cbProductID.Text));
                var DTQuery2 = (from DT in db.order_item
                                where
DT.item_id == int.Parse(txtitemID.Text)
                                select DT).SingleOrDefault();
                if (OdrQuery2 == null)
                {
                    MessageBox.Show("order_id chưa tồn tại trong Bảng  Order, Vui lòng cập nhật order_id trong bảng Order trước!", "Lỗi khóa ngoại!");
                    return;
                }
                if (PrQuery2 == null)
                {
                    MessageBox.Show("Product_id chưa tồn tại trong Bảng  Product, Vui lòng cập nhật Product_id trong bảng Product trước!", "Lỗi khóa ngoại!");
                    return;
                }
                if (DTQuery.item_id ==int.Parse( txtitemID.Text))
                {
                    //DTQuery.district_id = txtDID.Text;
                    DTQuery.order_id = int.Parse(cbOrdersID.Text);
                    DTQuery.product_id = int.Parse(cbProductID.Text);
                    DTQuery.quantity = txtQuanity.Text;
                    DTQuery.list_price = textListprice.Text;
                    DTQuery.discount = txtdiscount.Text;
                    db.SaveChanges();
                }
                else
                {
                    if (DTQuery2 != null)
                    {
                        MessageBox.Show("item_ID đã tồn tại trong Bảng  Order_item không sửa được!", "Lỗi khóa!");
                        return;
                    }
                    
                        db.order_item.Remove(DTQuery);
                        db.SaveChanges(); order_item DT = new order_item();
                    DT.order_id = int.Parse(cbOrdersID.Text);
                    DT.item_id = int.Parse(txtitemID.Text);
                    DT.product_id = int.Parse(cbProductID.Text);
                    DT.quantity = txtQuanity.Text;
                    DT.list_price = textListprice.Text;
                    DT.discount = txtdiscount.Text;
                        db.order_item.Add(DT);
                        db.SaveChanges();
                    
                }
            }
            MySetOrder_item();
        }
        private void dtGridView_CellContentClick(object sender,
       DataGridViewCellEventArgs e)
        {
            int r = dtGridView.CurrentCell.RowIndex;
            // Chuyển thông tin từ Gridview lên các textbox ở panel
            cbOrdersID.Text = dtGridView.Rows[r].Cells[0].Value.ToString();
            txtitemID.Text = dtGridView.Rows[r].Cells[1].Value.ToString();
            cbProductID.Text = dtGridView.Rows[r].Cells[2].Value.ToString();
            txtQuanity.Text = dtGridView.Rows[r].Cells[3].Value.ToString();
            textListprice.Text = dtGridView.Rows[r].Cells[4].Value.ToString();
            txtdiscount.Text = dtGridView.Rows[r].Cells[5].Value.ToString();
        }
        private void btDelete_Click(object sender, EventArgs e)
        {
            int r = dtGridView.CurrentCell.RowIndex;
            string tempDID = dtGridView.Rows[r].Cells[1].Value.ToString();
            order_item OrdiQ = db.order_item.Single(x => x.item_id ==
          int.Parse( tempDID));
            //db.districts.DeleteOnSubmit(OrdiQ);
            //db.SubmitChanges();
            db.order_item.Remove(OrdiQ);
            db.SaveChanges();
            MySetOrder_item();
        }
        private void btAdd_Click(object sender, EventArgs e)
        {
            var DTQuery = (from DT in db.order_item
                           where DT.item_id ==int.Parse( txtitemID.Text)
                           select DT).SingleOrDefault();
            if (DTQuery != null)
            {
                MessageBox.Show("Item ID is already existed", "Lỗi!");
            }
            else
            {
                try
                {
                    order_item DT = new order_item();
                    DT.order_id = int.Parse(cbOrdersID.Text);
                    DT.item_id = int.Parse(txtitemID.Text);
                    DT.product_id = int.Parse(cbProductID.Text);
                    DT.quantity = txtQuanity.Text;
                    DT.list_price = textListprice.Text;
                    DT.discount = txtdiscount.Text; db.order_item.Add(DT);
                    db.SaveChanges();
                }
                catch
                {
                    MessageBox.Show("Order_id chưa tồn tại trong Bảng   Order.Vui lòng cập nhật Order_id trong bảng Order trước!", "Lỗi khóa ngoại!");
                    MessageBox.Show("Product_id chưa tồn tại trong Bảng   Product.Vui lòng cập nhật Product_id trong bảng OrdProducter trước!", "Lỗi khóa ngoại!");
                }
                MySetOrder_item();
            }
        }
        private void btReload_Click(object sender, EventArgs e)
        {
            MySetOrder();
            MySetProduct();
        }
        private void cbOrdersID_Leave(object sender, EventArgs e)
        {
            cbOrdersID.Text = cbOrdersID.Text.Trim().ToUpper();
        }
        private void txtitemID_Leave(object sender, EventArgs e)
        {
            txtitemID.Text = txtitemID.Text.Trim();

        }
        private void cbProductID_Leave(object sender, EventArgs e)
        {
            cbProductID.Text = cbProductID.Text.Trim().ToUpper();
        }
        private void txtQuanity_Leave(object sender, EventArgs e)
        {
            txtQuanity.Text = txtQuanity.Text.Trim().ToUpper();
        }
        private void textListprice_Leave(object sender, EventArgs e)
        {
            textListprice.Text = textListprice.Text.Trim();

        }
        private void txtdiscount_Leave(object sender, EventArgs e)
        {
            txtdiscount.Text = txtdiscount.Text.Trim().ToUpper();
        }
    }
}
