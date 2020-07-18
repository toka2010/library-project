using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace MyLibrabry.Models
{
    public class UserBL
    {
        public static List<Users> GetAllAdmin()
        {
            string statement = "select * from Users ";
            List<Users> users = new List<Users>();
            var ds = DBManager.ExecuteQuery(statement);
           DateTime hd = DateTime.Now;
            foreach (DataRow item in ds.Tables[0].Rows)
            {
                users.Add(
                    new Users
                    {
                        u_id = int.Parse(item["u_id"].ToString()),
                        u_fname = item["u_fname"].ToString(),
                        u_lname = item["u_lname"].ToString(),
                        hdate = item["hdate"].ToString(),
  
                        salary = int.Parse(item["salary"].ToString()),
                        age = int.Parse(item["age"].ToString()),
                        u_address = item["u_address"].ToString(),
                        phone = int.Parse(item["phone"].ToString()),
                        u_name = item["u_name"].ToString(),
                        u_password = item["u_password"].ToString(),
                        u_email = item["u_email"].ToString(),
                        photo = item["photo"].ToString()

                    });
            }
            return users;
        }

        public static List<Users> GetAllEmp()
        {
            string statement = "select * from Users where u_type=3";
            List<Users> users = new List<Users>();
            var ds = DBManager.ExecuteQuery(statement);

            foreach (DataRow item in ds.Tables[0].Rows)
            {
                users.Add(
                    new Users
                    {
                        u_id = int.Parse(item["u_id"].ToString()),
                        u_fname = item["u_fname"].ToString(),
                        u_lname = item["u_lname"].ToString(),
                        hdate = item["hdate"].ToString(),
                        salary = int.Parse(item["salary"].ToString()),
                        age = int.Parse(item["age"].ToString()),
                        u_address = item["u_address"].ToString(),
                        phone = int.Parse(item["phone"].ToString()),
                        u_name = item["u_name"].ToString(),
                        u_password = item["u_password"].ToString(),
                        u_email = item["u_email"].ToString(),
                        photo = item["photo"].ToString()

                    });
            }
            return users;
        }

        public static List<Users> GetAllMem()
        {
            string statement = "select * from Users where u_type=4";
            List<Users> users = new List<Users>();
            var ds = DBManager.ExecuteQuery(statement);

            foreach (DataRow item in ds.Tables[0].Rows)
            {
                users.Add(
                    new Users
                    {
                        u_id = int.Parse(item["u_id"].ToString()),
                        u_fname = item["u_fname"].ToString(),
                        u_lname = item["u_lname"].ToString(),
                        hdate = item["hdate"].ToString(),
                        salary = int.Parse(item["salary"].ToString()),
                        age = int.Parse(item["age"].ToString()),
                        u_address = item["u_address"].ToString(),
                        phone = int.Parse(item["phone"].ToString()),
                        u_name = item["u_name"].ToString(),
                        u_password = item["u_password"].ToString(),
                        u_email = item["u_email"].ToString(),
                        photo = item["photo"].ToString()

                    });
            }
            return users;
        }

        public static Users GetById(int id)
        {
            string statement = $"select * from users where u_id={id}";
            var ds = DBManager.ExecuteQuery(statement);
            var item = ds.Tables[0].Rows[0];
            var u = new Users
            {
                u_id = int.Parse(item["u_id"].ToString()),
                u_fname = item["u_fname"].ToString(),
                u_lname = item["u_lname"].ToString(),
                hdate = item["hdate"].ToString(),
                salary = int.Parse(item["salary"].ToString()),
                age = int.Parse(item["age"].ToString()),
                u_address = item["u_address"].ToString(),
                phone = int.Parse(item["phone"].ToString()),
                u_name = item["u_name"].ToString(),
                u_password = item["u_password"].ToString(),
                u_email = item["u_email"].ToString(),
                photo = item["photo"].ToString()

            };

            return u;
        }
        public static int InsertAdmin(Users u)
        {
            string statement = $"INSERT INTO Users (u_fname, u_lname, hdate, salary, age, u_address, phone, u_name, u_password, u_email, photo,u_type)values('{u.u_fname}','{u.u_lname}','{u.hdate}',{u.salary},{u.age},'{u.u_address}',{u.phone},'{u.u_name}','{u.u_password}','{u.u_email}','{u.photo}',2)";


            var affected = DBManager.ExecuteNonQuery(statement);
            return affected;
        }
        public static int InsertEmp(Users u)
        {
            //string statement = $"INSERT INTO Users (u_fname, u_lname, hdate, salary, age, u_address, phone, u_name, u_password, u_email, photo,u_type)values('{u.u_fname}','{u.u_lname}','{u.hdate}',{u.salary},{u.age},'{u.u_address}',{u.phone},'{u.u_name}','{u.u_password}','{u.u_email}','{u.photo}',3)";
            string statement = $"INSERT INTO Users (u_fname, u_lname, hdate, salary, age, u_address, phone, u_name, u_password, u_email, photo,u_type)values('{u.u_fname}','{u.u_lname}','{u.hdate}',{u.salary},{u.age},'{u.u_address}',{u.phone},'{u.u_name}','{u.u_password}','{u.u_email}','{u.photo}',3)";


            var affected = DBManager.ExecuteNonQuery(statement);
            return affected;
        }
        public static int InsertMemb(Users u)
        {
            string statement = $"INSERT INTO Users (u_fname, u_lname, hdate, salary, age, u_address, phone, u_name, u_password, u_email, photo,u_type)values('{u.u_fname}','{u.u_lname}','{u.hdate}',{u.salary},{u.age},'{u.u_address}',{u.phone},'{u.u_name}','{u.u_password}','{u.u_email}','{u.photo}',4)";


            var affected = DBManager.ExecuteNonQuery(statement);
            return affected;
        }


        public static int Update(Users u)
        {
            string stataement = $"update Users set u_fname='{u.u_fname}',u_lname='{u.u_lname}',age={u.age},u_address='{u.u_address}',u_name='{u.u_name}',u_password={u.u_password},u_email='{u.u_email}',photo='{u.photo}' where u_id={u.u_id}";
            int affected = DBManager.ExecuteNonQuery(stataement);
            return affected;
        }

        public static int Delete(int id)
        {
            string statement = $"delete from Users where u_id={id}";
            var affected = DBManager.ExecuteNonQuery(statement);
            return affected;
        }
        public static List<Users> GetAll()
        {
            string statement = "select * from  Users";
            var ds = DBManager.ExecuteQuery(statement);
            List<Users> users = new List<Users>();
            foreach (DataRow item in ds.Tables[0].Rows)
            {
                users.Add(
                    new Users
                    {
                        u_id = int.Parse(item["u_id"].ToString()),
                        u_name = item["u_name"].ToString(),

                        u_password = item["u_password"].ToString(),

                    });
            }
            return users;
        }


        public static int GetId(string un)
        {
            string st = $"select u_id from  Users where u_name='{un}'";
            var ds = DBManager.ExecuteQuery(st);
            return int.Parse(ds.Tables[0].Rows[0]["u_id"].ToString());
        }
        public static bool checkIn(string un, string pwd)
        {
            var q = $"select * from  Users where u_name='{un}' and u_password='{pwd}'";
            var d = DBManager.ExecuteQuery(q);

            if (d.Tables[0].Rows.Count == 0)
            {
                return false;
            }
            else
            {
                return true;
            }

        }
        public static string getType(string un)
        {
            //string q = $"select type  from Users s ,Usertype t where s.u_name='{un}' and s.u_id=t.id";
            string q = $" select type from Usertype, Users where u_name = '{un}' and id = u_type";
            var d = DBManager.ExecuteQuery(q);
            var s = d.Tables[0].Rows[0]["type"].ToString();
            return s.Trim();
        }
        public static Users getById(int id)
        {
            string statement = $"select * from Users where u_id={id}";
            var ds = DBManager.ExecuteQuery(statement);
            var item = ds.Tables[0].Rows[0];
            var std = new Users
            {
                u_id = int.Parse(item["u_id"].ToString()),
                u_fname = item["u_fname"].ToString(),
                u_lname = item["u_lname"].ToString(),
                age = int.Parse(item["age"].ToString()),
                u_email = item["u_email"].ToString(),
                u_password = item["u_password"].ToString(),
                salary = int.Parse(item["salary"].ToString()),
                u_name = item["u_name"].ToString(),
                u_address = item["u_address"].ToString(),
                // photo = item["photos"].ToString(),

                phone = int.Parse(item["phone"].ToString()),



            };
            return std;
        }
    }
}