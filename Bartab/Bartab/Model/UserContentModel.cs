using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using MySql.Data.MySqlClient;

namespace Bartab.Model
{
    public class UserContentModel
    {
        DBConnection DBConn = new DBConnection();

        public int semester()
        {
            using (var con = new MySqlConnection(DBConn.connstring))
            {
                con.Open();
                using (var cmd = con.CreateCommand())
                {
                    cmd.CommandText = "select MAX(id) from semester";
                    using (var dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            return (int)dr["max(id)"];
                        }
                    }
                }
            }
            return 0;
        }
        
        public List<User> LoadUsers()
        {
            var result = new List<User>();

            using (var con = new MySqlConnection(DBConn.connstring))
            {
                con.Open();
                using (var cmd = con.CreateCommand())
                {
                    cmd.CommandText = "select id, navn, var, semester from personer order by var ASC";
                    using (var dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            result.Add(new User
                            {
                                Id = (int)dr["id"],
                                Fornavn = (string)dr["navn"],
                                VærelseNr = (int)dr["var"],
                                Semester=(string)dr["semester"]
                            });
                        }
                    }
                }
            }
            return result;
        }

        public List<Vare> LoadVarer()
        {
            var result = new List<Vare>();

            using (var con = new MySqlConnection(DBConn.connstring))
            {
                con.Open();
                using (var cmd = con.CreateCommand())
                {
                    cmd.CommandText = "select id, navn, pris, raekkefoelge from priser where old=0 order by raekkefoelge ASC";
                    using (var dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            result.Add(new Vare
                            {
                                Id = (int)dr["id"],
                                Navn = (string)dr["navn"],
                                Pris = (float)dr["pris"],
                                Raekkefoelge = (int)dr["raekkefoelge"]
                            });
                        }
                    }
                }
            }
            return result;
        }

        public int Buy(int person, int type, int antal, float pris)
        {
            using (var con = new MySqlConnection(DBConn.connstring))
            {
                con.Open();
                using (var cmd = con.CreateCommand())
                {
                    var time = DateTimeOffset.Now.ToUnixTimeSeconds();
                    cmd.CommandText = "insert into oversigt (person,type,antal,pris,dato,semester) values ("+person+","+type+","+antal+","+pris+","+time.ToString()+","+31+");";
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
        }
    }
}
