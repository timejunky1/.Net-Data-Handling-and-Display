using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.Common;

namespace Project_practice
{
    public partial class Form1 : Form
    {
        string str = "Name";
        List<string> modules = new List<string>();
        DataHandler dh = new DataHandler();
        Student student;
        Module mod;
        string display = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            btnChangeImage.Visible = false;
            listBox1.Visible = false;
            btnM.Visible = false;
            btnI.Visible = false;
            btnRemoveMod.Visible = false;
            dh.GetModules();
            foreach (DbDataRecord dr in dh.bs)
            {
                comboModules.Items.Add(dr[0]);
            }
            txtStdNum.Text = dh.GetLastStudentNumber();
        }

        private void btnImage_Click(object sender, EventArgs e)
        {
            Path.GetDirectoryName(Application.ExecutablePath);
            //Image image = Image.FromFile(@"C: \Users\sjaco\Downloads\RoboticHand.jpeg");
            Image image = Image.FromFile(@"C:\Users\sjaco\Downloads\RoboticHand.jpeg");
            MessageBox.Show(image.ToString());
            pictureBox1.Visible=true;
            pictureBox1.BackgroundImage = image;
            btnChangeImage.Visible = true;
            btnImage.Visible = false;
        }

        private void btnStudMod_Click(object sender, EventArgs e)
        {
            List<StudentModule> list = new List<StudentModule>();
            display = "StudMod";
            dh.GetStudentModules();
            for (int i = 0; i < dh.students.Count; i++)
            {
                list.Add(new StudentModule(dh.students[i], dh.modules[i]));            
            }
            dgvData.DataSource = list;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string module = comboModules.Text;
            if (!modules.Contains(module))
            {
                modules.Add(module);
            }
            listBox1.Items.Clear();
            foreach(var item in modules)
            {
                listBox1.Items.Add(item);
            }
            listBox1.Visible = true;
            btnM.Visible = true;
            btnI.Visible = true;
            btnRemoveMod.Visible = true;
        }

        private void btnAddM_Click(object sender, EventArgs e)
        {
            try
            {
                mod = new Module(txtModCode.Text, txtModName.Text, txtDescription.Text, txtlinks.Text);
                dh.AddModule(mod);
                dh.GetModules();
                foreach(DbDataRecord dr in dh.bs)
                {
                    comboModules.Items.Add(dr[0]);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdateM_Click(object sender, EventArgs e)
        {
            try
            {
                mod = new Module(txtModCode.Text, txtModName.Text, txtDescription.Text, txtlinks.Text);
                dh.UpdateModule(mod);
                dh.GetModules();
                foreach (DbDataRecord dr in dh.bs)
                {
                    comboModules.Items.Add(dr[0]);
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnDeleteM_Click(object sender, EventArgs e)
        {
            
            try { dh.DeleteModule(txtModCode.Text); } catch (Exception ex) { MessageBox.Show(ex.Message); }
            dh.GetModules();
            foreach (DbDataRecord dr in dh.bs)
            {
                comboModules.Items.Add(dr[1]);
            }
        }

        private void btnAddS_Click(object sender, EventArgs e)
        { 
            try
            {
                string gender;
                if (rbtnMale.Checked)
                {
                    gender = "Male";
                }
                else
                {
                    gender = "Female";
                }
                student = new Student(0, txtName.Text, txtSurname.Text, pictureBox1.BackgroundImage, 
                    dtpDBO.Value, gender, txtPhone.Text, txtAddress.Text, modules);
                dh.AddStudent(student);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdateS_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (string item in listBox1.Items)
                {
                    modules.Add(item);
                }
                string gender;
                if (rbtnMale.Checked)
                {
                    gender = "Male";
                }
                else
                {
                    gender = "Female";
                }
                student = new Student(int.Parse(txtStdNum.Text), txtName.Text, txtSurname.Text, pictureBox1.BackgroundImage,
                    dtpDBO.Value, gender, txtPhone.Text, txtAddress.Text, modules);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            dh.UpdateStudent(student);
        }

        private void btnDeleteS_Click(object sender, EventArgs e)
        {
            dh.DeleteStudent(int.Parse(txtStdNum.Text));
        }

        private void btnRemoveMod_Click(object sender, EventArgs e)
        {
            modules.Remove(listBox1.SelectedItem.ToString());
            listBox1.Items.Clear();
            foreach (var item in modules)
            {
                listBox1.Items.Add(item);
            }
        }

        private void btnDisplayStudents_Click(object sender, EventArgs e)
        {
            display = "Students";
            dh.GetStudents();
            dgvData.DataSource = dh.bs;
        }

        private void btnDisplayModules_Click(object sender, EventArgs e)
        {
            display = "Modules";
            dh.GetModules();
            dgvData.DataSource = dh.bs;
        }

        private void btnSearchS_Click(object sender, EventArgs e)
        {
            switch (display)
            {
                case "Students":
                    
                    try { dh.GetStudents(int.Parse(txtSearchStudent.Text)); dgvData.DataSource = dh.bs; } catch (Exception ex) { MessageBox.Show(ex.Message); }
                    break;
                case "StudMod":
                    List<StudentModule> list = new List<StudentModule>();
                    try{ dh.GetStudentModules(int.Parse(txtSearchStudent.Text)); }catch (Exception ex) { MessageBox.Show(ex.Message); }
                    if (dh.students.Count > 0)
                    {
                        for (int i = 0; i < dh.students.Count; i++)
                        {
                            list.Add(new StudentModule(dh.students[i], dh.modules[i]));
                        }
                        dgvData.DataSource = list;

                    }
                    else
                    {
                        dgvData.Columns.Clear(); ;
                    }
                    break;
                default:
                    break;
            }
        }

        private void btnSearchM_Click(object sender, EventArgs e)
        {
            switch (display)
            {
                case "Modules":
                    try { dh.GetModules(txtSearchModule.Text); dgvData.DataSource = dh.bs; } catch (Exception ex) { MessageBox.Show(ex.Message); }
                    break;
                case "StudMod":
                    List<StudentModule> list = new List<StudentModule>();
                    try { dh.GetStudentModules(txtSearchModule.Text); } catch (Exception ex) { MessageBox.Show(ex.Message); }
                    if (dh.students.Count >= 0)
                    {
                        
                        for (int i = 0; i < dh.students.Count; i++)
                        {
                            list.Add(new StudentModule(dh.students[i], dh.modules[i]));
                        }
                        dgvData.DataSource = list;

                    }
                    else
                    {
                        dgvData.Columns.Clear(); ;
                    }
                    break;
                default:
                    break;
            }
        }

        private void dgvData_SelectionChanged(object sender, EventArgs e)
        {
            DbDataRecord dr = dh.bs.Current as DbDataRecord;
            if(dr != null && dr.FieldCount == 8)
            {
                txtStdNum.Text = dr[0].ToString();
                txtName.Text = dr[1].ToString();
                txtSurname.Text = dr[2].ToString();
                if (dr[4].ToString() == "Male")
                {
                    rbtnMale.Checked = true;
                    rbtnFemale.Checked = false;
                }
                else
                {
                    rbtnFemale.Checked = true;
                    rbtnMale.Checked = false;
                }
                txtPhone.Text = dr[5].ToString();
                txtAddress.Text = dr[6].ToString();
                listBox1.DataSource = (dh.GetStudentModules(int.Parse(dr[0].ToString())));
            }
            else if(dr != null && dr.FieldCount == 4)
            {
                txtModCode.Text = dr[0].ToString();
                txtModName.Text = dr[1].ToString();
                txtDescription.Text = dr[2].ToString();
                txtlinks.Text = dr[3].ToString();
            }
            
        }

        private void btnI_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            btnChangeImage.Visible = true;
            listBox1.Visible = false;
        }

        private void btnM_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            btnChangeImage.Visible = false;
            listBox1.Visible = true;
        }
    }
}
