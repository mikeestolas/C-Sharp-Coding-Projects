using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeFirstFinalAssignment
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            pic.Image = null;
            metroPanel.Enabled = true;
            studentsBindingSource.Add(new Students());
            studentsBindingSource.MoveLast();
            txtName.Focus();
        }

        private void txtStudID_Click(object sender, EventArgs e)
        {

        }

        private void BtnBrowse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "JPEG|*.jpg" })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    pic.Image = Image.FromFile(ofd.FileName);
                    Students obj = studentsBindingSource.Current as Students;
                    if (obj != null)
                    {
                        obj.ImageUrl = ofd.FileName;
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e) //ADDButton
        {
            using (ModelContext db = new ModelContext())
            {
                studentsBindingSource.DataSource = db.Studlist.ToList();
            }
            metroPanel.Enabled = false;
            Students obj = studentsBindingSource.Current as Students;
            if (obj != null)
                pic.Image = Image.FromFile(obj.ImageUrl);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            metroPanel.Enabled = true;
            txtName.Focus();
            Students obj = studentsBindingSource.Current as Students;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(MetroFramework.MetroMessageBox.Show(this,"Are You Sure you Want to Delete This Record?","Message",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes )
            {
                using (ModelContext db = new ModelContext())
                {
                    Students obj = studentsBindingSource.Current as Students;
                    if(obj != null)
                    {
                        if (db.Entry<Students>(obj).State == EntityState.Detached)
                            db.Set<Students>().Attach(obj);
                        db.Entry<Students>(obj).State = EntityState.Deleted;
                        db.SaveChanges();
                        MetroFramework.MetroMessageBox.Show(this, "Deleted Successfully");
                        studentsBindingSource.RemoveCurrent();
                        metroPanel.Enabled = false;
                        pic.Image = null;
                    }
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            metroPanel.Enabled = false;
            studentsBindingSource.ResetBindings(false);
            Form1_Load(sender, e);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (ModelContext db = new ModelContext())
            {
                Students obj = studentsBindingSource.Current as Students;
                if(obj!= null)
                {
                    if (db.Entry<Students>(obj).State == EntityState.Detached)
                        db.Set<Students>().Attach(obj);
                    if (obj.StudID == 0)
                        db.Entry<Students>(obj).State = EntityState.Added;
                    else
                        db.Entry<Students>(obj).State = EntityState.Modified;
                    db.SaveChanges();
                    MetroFramework.MetroMessageBox.Show(this, "SAved Successfully");
                    metroGrid.Refresh();
                    metroPanel.Enabled = false;
                   


                }
            }

        }

        private void metroGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Students obj = studentsBindingSource.Current as Students;
            if (obj != null)
                pic.Image = Image.FromFile(obj.ImageUrl);

        }
    }
}
