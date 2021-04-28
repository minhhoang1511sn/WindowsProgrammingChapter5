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
    public partial class StaffForm_BDF : Form
    {
        public StaffForm_BDF()
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
            var StaQ = from StaList in db.staffs
                        join StoList in db.stores on
                       StaList.store_id equals StoList.store_id
                        where (StoList.store_id == cbStore.Text)
                        select StaList;
            DataTable dt = new DataTable();
            dt.Columns.Add("Staff_ID");
            dt.Columns.Add("First_Name");
            dt.Columns.Add("Last_Name");
            dt.Columns.Add("Email");
            dt.Columns.Add("Phone");
            dt.Columns.Add("Active");
            dt.Columns.Add("Store_ID");
            dt.Columns.Add("Manager_ID");
            foreach (var p in StaQ)
            {
                dt.Rows.Add(p.staff_id, p.first_name, p.last_name, p.email, p.phone, p.active,p.store_id,p.manager_id);
            }
            dtGridView.DataSource = dt;
        }
        private void StaffForm_Load(object sender, EventArgs e)
        {
            MySetStore();
            MySetStaff();
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
            staff DTQuery = db.staffs.Single(x => x.staff_id ==
          tempDID);
            if (DTQuery != null)
            {
                store StoQuery2 = db.stores.Single(x => x.store_id
               == cbStore.Text);
                staff StaffQuery2 = db.staffs.Single(x => x.staff_id
              == txtStaffID.Text);
                var DTQuery2 = (from DT in db.staffs
                                where
                            DT.staff_id == txtStaffID.Text
                                select DT).SingleOrDefault();
                if (StoQuery2 == null)
                {
                    MessageBox.Show("Store_id chưa tồn tại trong Bảng  Store, Vui lòng cập nhật Store_id trong bảng Store trước!", "Lỗi khóa ngoại!");
                    return;
                }
                if (StaffQuery2 == null)
                {
                    MessageBox.Show("Staff_id chưa tồn tại trong Bảng  Staff, Vui lòng cập nhật Staff_id trong bảng Staff trước!", "Lỗi khóa ngoại!");
                    return;
                }
                if (DTQuery.staff_id == txtStaffID.Text)
                {
                    //DTQuery.district_id = txtDID.Text;
                    DTQuery.first_name = txtxFname.Text;
                    DTQuery.last_name = txtLname.Text;
                    DTQuery.email = txtEmail.Text;
                    DTQuery.phone = txtPhone.Text;
                    DTQuery.active =byte.Parse( txtActive.Text);
                    DTQuery.store_id = cbStore.Text;
                    DTQuery.manager_id = txtManagerID.Text;
                    db.SaveChanges();
                }
                else
                {
                    if (DTQuery2 != null)
                    {
                        MessageBox.Show("Staff_ID đã tồn tại trong Bảng  Staffs không sửa được!", "Lỗi khóa!");
                        return;
                    }

                    db.staffs.Remove(DTQuery);
                    db.SaveChanges(); staff DT = new staff();
                    DT.staff_id = txtStaffID.Text;
                    DT.first_name = txtxFname.Text;
                    DT.last_name = txtLname.Text;
                    DT.email = txtEmail.Text;
                    DT.phone = txtPhone.Text;
                    DT.active = byte.Parse(txtActive.Text);
                    DT.store_id = cbStore.Text;
                    DT.manager_id = txtManagerID.Text;
                    db.staffs.Add(DT);
                    db.SaveChanges();

                }
            }
            MySetStaff();
        }
        private void dtGridView_CellContentClick(object sender,
       DataGridViewCellEventArgs e)
        {
            int r = dtGridView.CurrentCell.RowIndex;
            // Chuyển thông tin từ Gridview lên các textbox ở panel
            txtStaffID.Text = dtGridView.Rows[r].Cells[0].Value.ToString();
            txtxFname.Text = dtGridView.Rows[r].Cells[1].Value.ToString();
            txtLname.Text = dtGridView.Rows[r].Cells[2].Value.ToString();
            txtEmail.Text = dtGridView.Rows[r].Cells[3].Value.ToString();
            txtPhone.Text = dtGridView.Rows[r].Cells[4].Value.ToString();
            txtActive.Text = dtGridView.Rows[r].Cells[5].Value.ToString();
            cbStore.Text = dtGridView.Rows[r].Cells[6].Value.ToString();
            txtManagerID.Text = dtGridView.Rows[r].Cells[7].Value.ToString();
        }
        private void btDelete_Click(object sender, EventArgs e)
        {
            int r = dtGridView.CurrentCell.RowIndex;
            string tempDID = dtGridView.Rows[r].Cells[0].Value.ToString();
            staff StaQ = db.staffs.Single(x => x.staff_id ==
          tempDID);
            //db.districts.DeleteOnSubmit(StaQ);
            //db.SubmitChanges();
            db.staffs.Remove(StaQ);
            db.SaveChanges();
            MySetStaff();
        }
        private void btAdd_Click(object sender, EventArgs e)
        {
            var DTQuery = (from DT in db.staffs
                           where DT.staff_id == txtStaffID.Text
                           select DT).SingleOrDefault();
            if (DTQuery != null)
            {
                MessageBox.Show("Staff ID is already existed", "Lỗi!");
            }
            else
            {
                try
                {
                    staff DT = new staff();
                    DT.staff_id = txtStaffID.Text;
                    DT.first_name = txtxFname.Text;
                    DT.last_name = txtLname.Text;
                    DT.email = txtEmail.Text;
                    DT.phone = txtPhone.Text;
                    DT.active = byte.Parse(txtActive.Text);
                    DT.store_id = cbStore.Text;
                    try
                    {
                        DT.manager_id = txtManagerID.Text;
                    }
                    catch
                    {
                        MessageBox.Show("Manager_id chưa tồn tại trong Bảng   Staff.Vui lòng cập nhật Manager_id trong bảng Staff trước!", "Lỗi khóa ngoại!");
                    }
                    db.staffs.Add(DT);
                    db.SaveChanges();
                }
                catch
                {
                    MessageBox.Show("Store_id chưa tồn tại trong Bảng   Store.Vui lòng cập nhật Store_id trong bảng Store trước!", "Lỗi khóa ngoại!");
                    
                }
                MySetStaff();
            }
        }
        private void btReload_Click(object sender, EventArgs e)
        {
            MySetStore();
        }
        private void txtStaffID_Leave(object sender, EventArgs e)
        {
            txtStaffID.Text = txtStaffID.Text.Trim().ToUpper();
        }
        private void txtxFname_Leave(object sender, EventArgs e)
        {
            txtxFname.Text = txtxFname.Text.Trim();

        }
        private void txtLname_Leave(object sender, EventArgs e)
        {
            txtLname.Text = txtLname.Text.Trim().ToUpper();
        }
        private void txtEmail_Leave(object sender, EventArgs e)
        {
            txtEmail.Text = txtEmail.Text.Trim().ToUpper();
        }
        private void txtPhone_Leave(object sender, EventArgs e)
        {
            txtPhone.Text = txtPhone.Text.Trim();

        }
        private void txtActive_Leave(object sender, EventArgs e)
        {
            txtActive.Text = txtActive.Text.Trim().ToUpper();
        }
        private void cbStore_Leave(object sender, EventArgs e)
        {
            cbStore.Text = cbStore.Text.Trim();

        }
        private void txtManagerID_Leave(object sender, EventArgs e)
        {
            txtManagerID.Text = txtManagerID.Text.Trim().ToUpper();
        }
    }
}
