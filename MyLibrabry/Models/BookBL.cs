using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace MyLibrabry.Models
{
    public class BookBL
    {
        public static List<Book> GetAll()
        {
            string statement = "select * from Books";
            var ds = DBManager.ExecuteQuery(statement);
            List<Book> books = new List<Book>();
            foreach (DataRow item in ds.Tables[0].Rows)
            {
                books.Add(
                    new Book
                    {
                        b_id = int.Parse(item["b_id"].ToString()),
                        b_title = item["b_title"].ToString(),
                        b_author = item["b_author"].ToString(),
                        b_publisher = item["b_publisher"].ToString(),
                        pdate = int.Parse(item["pdate"].ToString()),
                        category = item["category"].ToString(),
                        edition = int.Parse(item["edition"].ToString()),
                        no_pages = int.Parse(item["no_pages"].ToString()),
                        no_shelf = int.Parse(item["no_shelf"].ToString()),
                        no_copies = int.Parse(item["no_copies"].ToString()),
                        photo = item["photo"].ToString(),
                       // avilable = int.Parse(item["avilable"].ToString()),
                        b_description = item["b_description"].ToString(),
                        b_url = item["b_url"].ToString(),
                        //IsActive = 0
                    });
            }
            return books;
        }
        //public static List<Users> GetAllMem()
        //{
        //    string statement = "select * from Users where u_type=4";
        //    List<Users> users = new List<Users>();
        //    var ds = DBManager.ExecuteQuery(statement);

        //    foreach (DataRow item in ds.Tables[0].Rows)
        //    {
        //        users.Add(
        //            new Users
        //            {
        //                u_id = int.Parse(item["u_id"].ToString()),
        //                u_fname = item["u_fname"].ToString(),
        //                u_lname = item["u_lname"].ToString(),
        //                hdate = item["hdate"].ToString(),
        //                salary = int.Parse(item["salary"].ToString()),
        //                age = int.Parse(item["age"].ToString()),
        //                u_address = item["u_address"].ToString(),
        //                phone = int.Parse(item["phone"].ToString()),
        //                u_name = item["u_name"].ToString(),
        //                u_password = item["u_password"].ToString(),
        //                u_email = item["u_email"].ToString(),
        //                photo = item["photo"].ToString()

        //            });
        //    }
        //    return users;
        //}
        public static Book GetById(int id)
        {
            string statement = $"select * from Books where b_id={id}";
            var ds = DBManager.ExecuteQuery(statement);
            var item = ds.Tables[0].Rows[0];
            var std = new Book
            {
                b_id = int.Parse(item["b_id"].ToString()),
                b_title = item["b_title"].ToString(),
                b_author = item["b_author"].ToString(),
                b_publisher = item["b_publisher"].ToString(),
                pdate = int.Parse(item["pdate"].ToString()),
                category = item["category"].ToString(),
                edition = int.Parse(item["edition"].ToString()),
                no_pages = int.Parse(item["no_pages"].ToString()),
                //avilable = int.Parse(item["avilable"].ToString()),
                no_shelf = int.Parse(item["no_shelf"].ToString()),
                no_copies = int.Parse(item["no_copies"].ToString()),
                photo = item["photo"].ToString(),
                b_description = item["b_description"].ToString(),
                b_url = item["b_url"].ToString(),
                //IsActive = 0
            };
            return std;
        }

        public static int Insert(Book s)
        {
            string statement = $"insert into Books (b_title,b_author,b_publisher,pdate,category,edition,no_pages,no_shelf,no_copies,photo)values('{s.b_title}','{s.b_author}','{s.b_publisher}',{s.pdate},'{s.category}',{s.edition},{s.no_pages},{s.no_shelf},{s.no_copies},'{s.photo}')";
            var affected = DBManager.ExecuteNonQuery(statement);
            return affected;
        }
       // borrow
        public static int Insertborrow(BorrowBook s,int id)
        {
            string statement = $"insert into Borrowbook(bo_day,bo_month,bo_year,arr_date,is_available,userid,u_mem,book_id) values('{s.bo_day}','{s.bo_month}','{s.bo_year}',{s.arr_date},'{s.is_available}',{s.userid},'{s.u_mem}',{id})";
            var affected = DBManager.ExecuteNonQuery(statement);
            return affected;
        }
        public static int Update(Book s)
        {
            string stataement = $"update Books set b_title='{s.b_title}',b_author='{s.b_author}',b_publisher='{s.b_publisher}',pdate={s.pdate},category='{s.category}',edition={s.edition},no_pages={s.no_pages},no_shelf={s.no_shelf},no_copies={s.no_copies},photo='{s.photo}' where b_id={s.b_id}";
            int affected = DBManager.ExecuteNonQuery(stataement);
            return affected;
        }

        //public static int Update(Book s)
        //{
        //    string stataement = $"update Books set b_title = 'dfhjdfhjdfh', b_author = 'cdfddfd', b_publisher = 'fdsdf', pdate = 2001, category = 'jdfhjsfh', edition = 7, no_pages = 2000, no_shelf = 2, no_copies = 2, photo = 'sss.ss' where b_id = 11";
        //    //  string stataement = $"update Books set b_title='{s.b_title}',b_author='{s.b_author}',b_publisher='{s.b_publisher}',pdate={s.pdate},category='{s.category}',edition={s.edition},no_pages={s.no_pages},no_shelf={s.no_shelf},no_copies={s.no_copies},photo='{s.photo}' where b_id={s.b_id}";
        //    int affected = DBManager.ExecuteNonQuery(stataement);
        //    return affected;
        //}

        public static int Delete(int id)
        {
            string statement = $"delete from Books where b_id={id}";
            var affected = DBManager.ExecuteNonQuery(statement);
            return affected;
        }
        public static List<mybook> allmybook()
        {
            string statement = "select  b_id,b_title,b_author,category,edition,photo,arr_date from Books,Borrowbook where b_id= book_id";
            var ds = DBManager.ExecuteQuery(statement);
            List<mybook> mybooks = new List<mybook>();
            foreach (DataRow item in ds.Tables[0].Rows)
            {
                mybooks.Add(
                    new mybook
                    {
                        b_id = int.Parse(item["b_id"].ToString()),
                        b_title = item["b_title"].ToString(),
                        b_author = item["b_author"].ToString(),
                        //b_publisher = item["b_publisher"].ToString(),
                        //pdate = int.Parse(item["pdate"].ToString()),
                        category = item["category"].ToString(),
                        edition = int.Parse(item["edition"].ToString()),
                        //no_pages = int.Parse(item["no_pages"].ToString()),
                        //no_shelf = int.Parse(item["no_shelf"].ToString()),
                        //no_copies = int.Parse(item["no_copies"].ToString()),
                        photo = item["photo"].ToString(),
                        arr_date =item["arr_date"].ToString(),
                        // avilable = bool.Parse(item["avilable"].ToString()),
                        //b_description = item["b_description"].ToString(),
                        //b_url = item["b_url"].ToString(),
                        //IsActive = 0
                    });
            }
            return mybooks;
        }
    }

}