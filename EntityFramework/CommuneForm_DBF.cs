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
    public partial class CommuneForm_DBF : Form
    {
        public CommuneForm_DBF()
        {
            InitializeComponent();
        }
        SalesDBMF db = null;
        private void MySetDistrict()
        {
            db = new SalesDBMF();
            var DistQ = from DistList in db.districts
                        select
            DistList.district_name;
            foreach (string DistName in DistQ)
            {
                cbDist.Items.Add(DistName);
            }
            cbDist.SelectedIndex = 0;
        }
        private void MySetCommune()
        {
            var CommQ = from CommList in db.communes
                        join DistList in db.districts on
                       CommList.district_id equals DistList.district_id
                        where (DistList.district_name == cbDist.Text)
                        select CommList;
            DataTable dt = new DataTable();
            dt.Columns.Add("Commune_ID");
            dt.Columns.Add("Commune_Name");
            dt.Columns.Add("Degree");
            dt.Columns.Add("District_ID");
            foreach (var p in CommQ)
            {
                dt.Rows.Add(p.commune_id, p.commune_name, p.degree,p.district_id);
            }
            dtGridView.DataSource = dt;
        }
        private void CommuneForm_Load(object sender, EventArgs e)
        {
            MySetDistrict();
        }
        private void cbDist_SelectedValueChanged(object sender, EventArgs
       e)
        {
            MySetCommune();
        }
        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btSave_Click(object sender, EventArgs e)
        {
            //db = new SalesDBMF();
            int r = dtGridView.CurrentCell.RowIndex;
            string tempCID = dtGridView.Rows[r].Cells[0].Value.ToString();
            commune DTQuery = db.communes.Single(x => x.commune_id ==
           tempCID);
            if (DTQuery != null)
            {
                district DQuery2 = db.districts.Single(x => x.district_id
               == txtDID.Text);
                var DTQuery2 = (from DT in db.communes
                                where
                            DT.commune_id == txtCID.Text
                                select DT).SingleOrDefault();
                if (DQuery2 == null)
                {
                    MessageBox.Show("District_id chưa tồn tại trong Bảng  District, Vui lòng cập nhật District_id trong bảng District trước!", "Lỗi khóa ngoại!");
                    return;
                }
                if (DTQuery.commune_id == txtCID.Text)
                {
                    //DTQuery.district_id = txtDID.Text;
                    DTQuery.commune_name = txtCName.Text;
                    DTQuery.degree =int.Parse( txtDegree.Text);
                    DTQuery.district_id = txtDID.Text;
                    db.SaveChanges();
                }
                else
                {
                    if (DTQuery2 != null)
                    {
                        MessageBox.Show("Commune_ID đã tồn tại trong Bảng  Commune không sửa được!", "Lỗi khóa!");
                        return;
                    }
                        db.communes.Remove(DTQuery);
                        db.SaveChanges(); commune DT = new commune();
                        DT.commune_id = txtDID.Text;
                        DT.commune_name = txtCName.Text;
                        DT.degree =int.Parse( txtDegree.Text);
                        DT.district_id = txtDID.Text;
                        db.communes.Add(DT);
                        db.SaveChanges();
                }
            }
            MySetCommune();
        }
        private void dtGridView_CellContentClick(object sender,
       DataGridViewCellEventArgs e)
        {
            int r = dtGridView.CurrentCell.RowIndex;
            // Chuyển thông tin từ Gridview lên các textbox ở panel
            txtCID.Text = dtGridView.Rows[r].Cells[0].Value.ToString();
            txtCName.Text = dtGridView.Rows[r].Cells[1].Value.ToString();
            txtDegree.Text = dtGridView.Rows[r].Cells[2].Value.ToString();
            txtDID.Text = dtGridView.Rows[r].Cells[3].Value.ToString();
        }
        private void btDelete_Click(object sender, EventArgs e)
        {
            int r = dtGridView.CurrentCell.RowIndex;
            string tempCID = dtGridView.Rows[r].Cells[0].Value.ToString();
            commune CommQ = db.communes.Single(x => x.commune_id ==
           tempCID);
            //db.districts.DeleteOnSubmit(DistQ);
            //db.SubmitChanges();
            db.communes.Remove(CommQ);
            db.SaveChanges();
            MySetDistrict();
        }
        private void btAdd_Click(object sender, EventArgs e)
        {
            var DTQuery = (from DT in db.communes
                           where DT.commune_id == txtCID.Text
                           select DT).SingleOrDefault();
            if (DTQuery != null)
            {
                MessageBox.Show("Commune ID is already existed", "Lỗi!");
            }
            else
            {
                try
                {
                    commune DT = new commune();
                    DT.commune_id = txtCID.Text;
                    DT.commune_name = txtCName.Text;
                    DT.degree = int.Parse(txtDegree.Text);
                    DT.district_id = txtDID.Text; db.communes.Add(DT);
                    db.SaveChanges();
                }
                catch
                {
                    MessageBox.Show("District_id chưa tồn tại trong Bảng   District.Vui lòng cập nhật District_id trong bảng District trước!", "Lỗi khóa ngoại!");
                }
                MySetCommune();
            }
        }
        private void btReload_Click(object sender, EventArgs e)
        {
            MySetCommune();
        }
        private void txtDID_Leave(object sender, EventArgs e)
        {
            txtDID.Text = txtDID.Text.Trim().ToUpper();
        }
        private void txtCName_Leave(object sender, EventArgs e)
        {
            txtCName.Text = txtCName.Text.Trim();

        }
        private void txtDegree_Leave(object sender, EventArgs e)
        {
            txtDegree.Text = txtDegree.Text.Trim();

        }
        private void txtCID_Leave(object sender, EventArgs e)
        {
            txtCID.Text = txtCID.Text.Trim().ToUpper();
        }
    }
}
