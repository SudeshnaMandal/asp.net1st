using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Collections;

namespace DAL
{
    public class Class
    {
        SqlCommand cmd;
        SqlCommand cmd1;
        SqlConnection con;
        SqlTransaction transaction;
        SqlDataAdapter da = new SqlDataAdapter();
        public int insertUserData(string name, string email, int phone)
        {
            int UserId = 0;
            con = new SqlConnection(commm.GetConnectionString());
            string sql = "INSERT INTO Soham (Name , Email , Phone)  output inserted.UserId VALUES " + "(@Name , @Email , @Phone)";


            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlParameter[] param = new SqlParameter[3];


                param[0] = new SqlParameter("@Name", SqlDbType.VarChar, 50);
                param[1] = new SqlParameter("@Email", SqlDbType.VarChar, 50);
                param[2] = new SqlParameter("@Phone", SqlDbType.Int, 50);
                


                param[0].Value = name;
                param[1].Value = email;
                param[2].Value = phone;
               

                for (int i = 0; i < param.Length; i++)
                {
                    cmd.Parameters.Add(param[i]);
                }

                cmd.CommandType = CommandType.Text;
                UserId = Int32.Parse(cmd.ExecuteScalar().ToString());
            }
            catch (Exception ex)
            {
                string msg;
                msg = ex.Message;
               

            }
            finally
            {
                con.Close();
            }
            return UserId;
        }

        public int insertUserData(string name, string email, string mobile)
        {
            int UserId = 0;
            con = new SqlConnection(commm.GetConnectionString());
            string sql = "INSERT INTO Soham (Name , Email , Mobile)  output inserted.UserId VALUES " + "(@Name , @Email , @Mobile)";


            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlParameter[] param = new SqlParameter[3];


                param[0] = new SqlParameter("@Name", SqlDbType.VarChar, 50);
                param[1] = new SqlParameter("@Email", SqlDbType.VarChar, 50);
                param[2] = new SqlParameter("@Mobile", SqlDbType.VarChar, 50);



                param[0].Value = name;
                param[1].Value = email;
                param[2].Value = mobile;


                for (int i = 0; i < param.Length; i++)
                {
                    cmd.Parameters.Add(param[i]);
                }

                cmd.CommandType = CommandType.Text;
                UserId = Int32.Parse(cmd.ExecuteScalar().ToString());
            }
            catch (Exception ex)
            {
                string msg;
                msg = ex.Message;


            }
            finally
            {
                con.Close();
            }
            return UserId;
        }
    }
}
