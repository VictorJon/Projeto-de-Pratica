using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoPratica
{
    public class Evento
    {
        public int Id { get; set; }
        public int QntPessoas { get; set; }
        public DateTime Data { get; set; }
        public string Responsavel { get; set; }

        public static DataTable GetEventos(DateTime? data = null)
        {
            var dt = new DataTable();
            var sqlQuerry = "SELECT * FROM bdcondominio.agendamentos";

            if(data != null)
            {
                string dataFormatada = data.Value.ToString("yyyy-MM-dd");

                sqlQuerry = "SELECT * FROM bdcondominio.agendamentos where data = '" + dataFormatada + "'";
            }

            string conn = ConfigurationManager.ConnectionStrings["MySQLConnectionString"].ToString();
            MySqlConnection con = new MySqlConnection(conn);
            
            try
            {
                con.Open();
                using (var da = new MySqlDataAdapter(sqlQuerry, con))
                {
                    da.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dt;
        }
    }
}
