using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace xphu
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        string connString = "SERVER = localhost;"
                                   + "DATABASE = nhom;"
                                   + "USERNAME = root;"
                                   + "PASSWORD = 1234;";

        public bool Account(UserDetail userinfo)
        {
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("select Role from Account where IdAcc = @IdAcc and Pass = @Pass", conn);
            cmd.Parameters.AddWithValue("@IdAcc", userinfo.idacc);
            cmd.Parameters.AddWithValue("@Pass", userinfo.pass);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                switch (dt.Rows[0]["Role"].ToString())
                {
                    case "1":
                        {
                            return true;
                        }
                    case "0":
                        {
                            return false;
                        }
                }
            }
            return true;
        }

        public bool DangNhap(UserDetail userinfo)
        {
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("select * from Account where IdAcc = @IdAcc and Pass = @Pass", conn);
            cmd.Parameters.AddWithValue("@IdAcc", userinfo.idacc);
            cmd.Parameters.AddWithValue("@Pass", userinfo.pass);
            MySqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read() == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public DataSet DsAcount()
        {
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("Select * from Account", conn);
            MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            cmd.ExecuteNonQuery();
            conn.Close();
            return ds;
        }
        public bool Them(UserDetail userinfo)
        {
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            try
            {
                MySqlCommand cmd = new MySqlCommand("Insert Into Account(IdAcc,Name,Role,Pass) Values (@IdAcc,@Name,@Role,@Pass)", conn);
                cmd.Parameters.AddWithValue("@idacc", userinfo.idacc);
                cmd.Parameters.AddWithValue("@pass", userinfo.pass);
                cmd.Parameters.AddWithValue("@role", userinfo.role);
                cmd.Parameters.AddWithValue("@name", userinfo.name);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count == 0)
                {
                    return true;
                }

            }
            catch (Exception)
            {
                return false;
            }
            conn.Close();
            return true;
        }
        public bool Sua(UserDetail userinfo)
        {
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("update Account set Name=@Name, Pass=@Pass, Role=@Role where IdAcc=@IdAcc;", conn);
            cmd.Parameters.AddWithValue("@Name", userinfo.name);
            cmd.Parameters.AddWithValue("@Pass", userinfo.pass);
            cmd.Parameters.AddWithValue("@Role", userinfo.role);
            cmd.Parameters.AddWithValue("@IdAcc", userinfo.idacc);
            MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt != null)
            {
                foreach (DataRow row in dt.Rows)
                {
                    return true;
                }
            }
            else
            {
                return false;
            }
            conn.Close();
            return true;
        }
        public bool Xoa(UserDetail userinfo)
        {
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("Delete  From Account Where IdAcc=@IdAcc", conn);
            cmd.Parameters.AddWithValue("@IdAcc", userinfo.idacc);
            cmd.ExecuteNonQuery();
            conn.Close();
            return true;
        }
        //public DataSet DsContents()
        //{
        //    MySqlConnection conn = new MySqlConnection(connString);
        //    conn.Open();
        //    MySqlCommand cmd = new MySqlCommand("Select Contents from nhom.option", conn);
        //    MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
        //    DataSet ds = new DataSet();
        //    sda.Fill(ds);
        //    cmd.ExecuteNonQuery();
        //    conn.Close();
        //    return ds;


        //}
        public bool ThemContents(Option option)
        {
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            try
            {
                //DateTime n = DateTime.Now;
                //string d = n.ToString("yyyy-MM-dd HH:mm:ss");
                MySqlCommand cmd = new MySqlCommand("Insert Into nhom.option(IdOpt,Contents,DeadlineTime) Values (@IdOpt,@Contents,@DeadlineTime)", conn);
                cmd.Parameters.AddWithValue("@idopt", option.idopt);
                cmd.Parameters.AddWithValue("@contents", option.contents);
                //cmd.Parameters.AddWithValue("@code", option.code);
                cmd.Parameters.AddWithValue("@deadlinetime", option.deadlinetime);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count == 0)
                {
                    return true;
                }

            }
            catch (Exception)
            {
                return false;
            }
            conn.Close();
            return true;
        }
        public bool XoaOption(Option xoa)
        {
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("Delete  From nhom.option Where Code=@Code", conn);
            cmd.Parameters.AddWithValue("@Code", xoa.code);
            cmd.ExecuteNonQuery();
            conn.Close();
            return true;
        }

        public bool LoadContent(Vote vote)
        {
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT Contents from nhom.vote inner join nhom.option on vote.Code = nhom.option.Contents;", conn);
            cmd.Parameters.AddWithValue("@IdAcc", vote.idacc);
            cmd.Parameters.AddWithValue("@Code", vote.code);
            cmd.Parameters.AddWithValue("@IdVote", vote.idvote);
            MySqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read() == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public DataSet DsOption()
        {
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT  Contents, DeadlineTime, IdVote from nhom.vote inner join nhom.option on vote.IdOpt = nhom.option.IdOpt;", conn);
            MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            cmd.ExecuteNonQuery();
            conn.Close();
            return ds;
        }

        public DataSet DsCode(string idac)
        {
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT account.IdAcc,  option.IdOpt, account.Name, option.Contents, vote.Time FROM ((nhom.vote INNER JOIN nhom.account ON vote.IdAcc = account.IdAcc)INNER JOIN nhom.option ON  vote.Code = option.Contents) where account.IdAcc = @IdAcc;", conn);
            cmd.Parameters.AddWithValue("@IdAcc", idac);
            MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            cmd.ExecuteNonQuery();
            conn.Close();
            return ds;
        }

        public DataSet DsCode1()
        {
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT   option.IdOpt, account.Name, option.Contents, vote.Time FROM ((nhom.vote INNER JOIN nhom.account ON vote.IdAcc = account.IdAcc)INNER JOIN nhom.option ON  vote.Code = option.Contents)", conn);
            //cmd.Parameters.AddWithValue("@IdAcc", idac);
            MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            cmd.ExecuteNonQuery();
            conn.Close();
            return ds;
        }


        public bool SuaVote(Vote sua)
        {
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("update nhom.vote set vote.Code=@Code, vote.SetFlag = 1 where IdAcc=@IdAcc;", conn);
            cmd.Parameters.AddWithValue("@Code", sua.code);
            cmd.Parameters.AddWithValue("@IdAcc", sua.idacc);
            cmd.Parameters.AddWithValue("@SetFlag", sua.setflag);
            MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt != null)
            {
                foreach (DataRow row in dt.Rows)
                {
                    return true;
                }
            }
            else
            {
                return false;
            }
            conn.Close();
            return true;
        }

        public bool ThemVote(Vote them)
        {
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            try
            {
                DateTime n = DateTime.Now;
                string d = n.ToString("yyyy-MM-dd HH:mm:ss");
                MySqlCommand cmd = new MySqlCommand("Insert Into nhom.vote(IdAcc,Code,IdOpt,Time) Values (@IdAcc,@Code,@IdOpt,@Time)", conn);
                //cmd.Parameters.AddWithValue("@IdVote", them.idvote);
                cmd.Parameters.AddWithValue("@IdAcc", them.idacc);
                cmd.Parameters.AddWithValue("@code", them.code);
                cmd.Parameters.AddWithValue("@IdOpt", them.idopt);
                cmd.Parameters.AddWithValue("@Time", d);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count == 0)
                {
                    return true;
                }

            }
            catch (Exception)
            {
                return false;
            }
            conn.Close();
            return true;
        }

        public bool KiemTraIdAcc(Vote Kt)
        {
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT IdAcc from nhom.vote where IdAcc = @IdAcc;", conn);
            cmd.Parameters.AddWithValue("@IdAcc", Kt.idacc);
            MySqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read() == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool KiemTraContents(Option ktContents)
        {
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT Code, IdOpt from nhom.option where Contents = @Contents;", conn);
            cmd.Parameters.AddWithValue("@Contents", ktContents.contents);
            MySqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read() == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public DataSet DsAns()
        {
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("Select nhom.option.Contents, nhom.option.Code, nhom.option.IdOpt from nhom.option where Code not like '1'", conn);
            MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            cmd.ExecuteNonQuery();
            conn.Close();
            return ds;
        }

        public DataSet DsQuestion()
        {
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("Select nhom.option.Contents from nhom.option where Code like '1'", conn);
            MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            cmd.ExecuteNonQuery();
            conn.Close();
            return ds;
        }

        public bool SuaAns(Option sua)
        {
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("update nhom.option set Contents=@Contents where Code = @Code;", conn);
            cmd.Parameters.AddWithValue("@Contents", sua.contents);
            cmd.Parameters.AddWithValue("@Code", sua.code);
            MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt != null)
            {
                foreach (DataRow row in dt.Rows)
                {
                    return true;
                }
            }
            else
            {
                return false;
            }
            conn.Close();
            return true;
        }

        public int DemAns(Vote Dem)
        {
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT COUNT(Code) AS Answer FROM nhom.vote where Code = 2;", conn);
            cmd.Parameters.AddWithValue("@Code", Dem.code);
            int a = int.Parse(cmd.ExecuteScalar().ToString());
            return a;
        }

        public int DemK(Vote Dem)
        {
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT COUNT(Code) AS Answer FROM nhom.vote where Code = 3;", conn);
            //MySqlDataAdapter ad = new MySqlDataAdapter(cmd);
            cmd.Parameters.AddWithValue("@Code", Dem.code);
            int a = int.Parse(cmd.ExecuteScalar().ToString());
            return a;
            //DataTable dt = new DataTable();
            //ad.Fill(dt);
            //return dt;
        }

        public int DemCb(Vote Dem)
        {
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT COUNT(Code) AS Answer FROM nhom.vote where Code = 4;", conn);
            cmd.Parameters.AddWithValue("@Code", Dem.code);
            int a = int.Parse(cmd.ExecuteScalar().ToString());
            return a;
        }

        public DataSet DistinctOpt()
        {
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("select distinct IdOpt from nhom.option;", conn);
            MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            cmd.ExecuteNonQuery();
            conn.Close();
            return ds;
        }

        public DataSet LuotVote()
        {
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT Code, count(Code) AS Anwser FROM nhom.vote GROUP BY Code;", conn);
            MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            cmd.ExecuteNonQuery();
            conn.Close();
            return ds;
        }

        public bool KtSetFlag(Vote Kt)
        {
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("select SetFlag from nhom.vote where IdAcc = @IdAcc", conn);
            cmd.Parameters.AddWithValue("@IdAcc", Kt.idacc);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                switch (dt.Rows[0]["SetFlag"].ToString())
                {
                    case "1":
                        {
                            return true;
                        }
                    case "0":
                        {
                            return false;
                        }
                }
            }
            return true;
        }



        public bool KtActivate(UserDetail KtAc)
        {
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("select Activate from nhom.account where IdAcc = @IdAcc", conn);
            cmd.Parameters.AddWithValue("@IdAcc", KtAc.idacc);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                switch (dt.Rows[0]["Activate"].ToString())
                {
                    case "1":
                        {
                            return true;
                        }
                    case "0":
                        {
                            return false;
                        }
                }
            }
            return true;
        }

        public bool SuaActi(UserDetail suaacti)
        {
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("update nhom.account set Activate = 1 where IdAcc=@IdAcc;", conn);
            cmd.Parameters.AddWithValue("@IdAcc", suaacti.idacc);
            MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt != null)
            {
                foreach (DataRow row in dt.Rows)
                {
                    return true;
                }
            }
            else
            {
                return false;
            }
            conn.Close();
            return true;
        }

        public bool RsActi(UserDetail rs)
        {
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("update nhom.account set Activate = 0", conn);
            //cmd.Parameters.AddWithValue("@IdAcc", rs.idacc);
            MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt != null)
            {
                foreach (DataRow row in dt.Rows)
                {
                    return true;
                }
            }
            else
            {
                return false;
            }
            conn.Close();
            return true;
        }

        public bool KtDlVote(Vote Kt)
        {
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT   option.IdOpt, account.Name, option.Contents, vote.Time FROM ((nhom.vote INNER JOIN nhom.account ON vote.IdAcc = account.IdAcc)INNER JOIN nhom.option ON  vote.Code = option.Contents) where IdAcc = @IdAcc;", conn);
            cmd.Parameters.AddWithValue("@IdAcc", Kt.idacc);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                return true;
            }

            return true;
        }
    }
}
