using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_practice
{
    internal class DataHandler
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-8GCK8IN\SQLEXPRESS; Initial Catalog=PRG281Project; Integrated Security=True");
        SqlCommand cmd;
        public BindingSource bs = new BindingSource();
        public List<string> modules;
        public List<string> students;

        int lastStudentNumber;

        public string GetLastStudentNumber()
        {
            GetStudents();
            foreach (DbDataRecord dr in bs)
            {
                lastStudentNumber = int.Parse(dr[0].ToString()) + 1;
            }
            return Convert.ToString(lastStudentNumber);
        }
        public void AddStudent(Student st)
        {
            try
            {
                cmd = new SqlCommand("InsertStudent", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Name", st.Name);
                cmd.Parameters.AddWithValue("@Surname", st.Surname);
                cmd.Parameters.AddWithValue("@Image", st.Image);
                cmd.Parameters.AddWithValue("@DOB", st.Dob);
                cmd.Parameters.AddWithValue("@Gender", st.Gender);
                cmd.Parameters.AddWithValue("@Phone", st.Phone);
                cmd.Parameters.AddWithValue("@Address", st.Address);
                conn.Open();
                cmd.ExecuteNonQuery();
                foreach (var item in st.Modules)
                {
                    cmd = new SqlCommand("InsertModuleCode", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@StudentNumber", st.StudentNumber);
                    cmd.Parameters.AddWithValue("@ModuleCode", item);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Modules has been alocated for the student");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            conn.Close();
        }

        public void AddModule(Module mod)
        {
            try
            {
                cmd = new SqlCommand("InsertModule", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ModuleCode", mod.ModuleCode);
                cmd.Parameters.AddWithValue("@Name", mod.Name);
                cmd.Parameters.AddWithValue("@Description", mod.Description);
                cmd.Parameters.AddWithValue("@Links", mod.Links);
                conn.Open();
                cmd.ExecuteNonQuery ();
                MessageBox.Show("Module has been successfully added");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
        }

        public void UpdateStudent(Student st)
        {
            SqlDataReader reader;
            try
            {
                cmd = new SqlCommand("UpdateStudent", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@StudentNumber", st.StudentNumber);
                cmd.Parameters.AddWithValue("@Name", st.Name);
                cmd.Parameters.AddWithValue("@Surname", st.Surname);
                cmd.Parameters.AddWithValue("@Image", st.Image);
                cmd.Parameters.AddWithValue("@DOB", st.Dob);
                cmd.Parameters.AddWithValue("@Gender", st.Gender);
                cmd.Parameters.AddWithValue("@Phone", st.Phone);
                cmd.Parameters.AddWithValue("@Address", st.Address);
                conn.Open();
                cmd.ExecuteNonQuery();

                foreach (var item in st.Modules)
                {
                    cmd = new SqlCommand("InsertModuleCode", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@StudentNumber", st.StudentNumber);
                    cmd.Parameters.AddWithValue("@ModuleCode", item);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
        }

        public void UpdateModule(Module mod)
        {
            try
            {
                cmd = new SqlCommand("UpdateModule", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ModuleCode", mod.ModuleCode);
                cmd.Parameters.AddWithValue("@Name", mod.Name);
                cmd.Parameters.AddWithValue("@Description", mod.Description);
                cmd.Parameters.AddWithValue("@Links", mod.Links);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            conn.Close();
        }

        public void DeleteStudent(int ID)
        {
            try
            {
                cmd = new SqlCommand("DeleteStudent", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@StudentNumber", ID);
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Student has been successfully Deleted");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            conn.Close();

        }

        public void DeleteModule(string ModCode)
        {
            try
            {
                cmd = new SqlCommand("DeleteModule", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ModuleCode", ModCode);
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Module has been successfully Deleted");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            conn.Close();
        }

        public void GetStudents()
        {
            try
            {
                cmd = new SqlCommand("GetStudents", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    bs.DataSource = reader;
                }
                reader.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            conn.Close();
        }

        public void GetStudents(int ID)
        { 
            string query = $@"SELECT * FROM Student WHERE StudentNumber = {ID}";
            try
            {
                cmd = new SqlCommand("GetStudent", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@StudentNumber", ID);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    bs.DataSource = reader;
                }
                reader.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            conn.Close();
        }

        public void GetModules()
        {
            try
            {
                cmd = new SqlCommand("GetModules", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    bs.DataSource = reader;
                }
                reader.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            conn.Close();
        }

        public void GetModules(string modCode)
        {
            
            try
            {
                cmd = new SqlCommand("GetModule", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ModuleCode", modCode);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    bs.DataSource = reader;
                }
                reader.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            conn.Close();
        }

        public List<string> GetStudentModules(int ID)
        {
            SqlDataReader reader;
            List<string> strings = new List<string>();
            students = new List<string>();
            modules = new List<string>();
            try
            {

                conn.Open();
                cmd = new SqlCommand("GetStudentModulesByStudent", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@StudentNumber", ID);
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {

                    bs.DataSource = reader;
                    reader.Close();
                    string number1 = "";
                    string number2 = "";
                    int count = 0;
                    foreach (DbDataRecord dr in bs)
                    {
                        number1 = dr[1].ToString();
                        if (number1 != number2 && count > 0)
                        {
                            students.Add(number2);
                            modules.Add(string.Join(",", strings));
                            strings.Clear();
                        }
                        strings.Add(dr[2].ToString());
                        count++;
                        number2 = dr[1].ToString();
                    }
                    students.Add(number2);
                    modules.Add(string.Join(",", strings));
                }
                reader.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            conn.Close();
            return strings;
        }

        public void GetStudentModules(string ModCode)
        {
            SqlDataReader reader;
            List<string> strings = new List<string>();
            students = new List<string>();
            modules = new List<string>();
            try
            {

                cmd = new SqlCommand("GetStudentModulesByModuleCode", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ModuleCode", ModCode);
                conn.Open();
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {

                    bs.DataSource = reader;
                    reader.Close();
                    string number1 = "";
                    string number2 = "";
                    int count = 0;
                    foreach (DbDataRecord dr in bs)
                    {
                        number1 = dr[1].ToString();
                        if (number1 != number2 && count > 0)
                        {
                            students.Add(number2);
                            modules.Add(string.Join(",", strings));
                            strings.Clear();
                        }
                        strings.Add(dr[2].ToString());
                        count++;
                        number2 = dr[1].ToString();
                    }
                    students.Add(number2);
                    modules.Add(string.Join(",", strings));
                }
                reader.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            conn.Close();
        }

        public void GetStudentModules()
        {
            SqlDataReader reader;
            List<string> strings = new List<string>(); 
            students = new List<string>();
            modules = new List<string>();
            try
            {

                cmd = new SqlCommand("GetStudentModules", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                conn.Open();
                reader = cmd.ExecuteReader();
                if(reader.HasRows)
                {

                    bs.DataSource = reader;
                    reader.Close();
                    string number1 = "";
                    string number2 = "";
                    int count = 0;
                    foreach (DbDataRecord dr in bs)
                    {
                        number1 = dr[1].ToString();
                        if (number1 != number2 && count > 0)
                        {
                            students.Add(number2);
                            modules.Add(string.Join(",", strings));
                            strings.Clear();
                        }
                        strings.Add(dr[2].ToString());
                        count++;
                        number2 = dr[1].ToString();
                    }
                    students.Add(number2);
                    modules.Add(string.Join(",", strings));
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
        }
    }
}

