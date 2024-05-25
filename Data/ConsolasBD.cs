using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase___Laboratorio___25_05_2024.Data
{
    internal class ConsolasBD
    {
        // Información de conexión a la base de datos
        private string connectionString = "Server=localhost;Database=db_universidad;Uid=root;Pwd=59104667;";

        //constructor
        public ConsolasBD(string servidor, string usur, string pwd)
        {
            connectionString = "Server=" + servidor + ";Database=db_universidad;Uid=" + usur + ";Pwd=" + pwd + ";";
        }


        // Método para leer todos las consolas
        public DataTable LeerConsolas()
        {
            DataTable consolas = new DataTable();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string sql = "SELECT * FROM catalogo_consolas";
                using (MySqlCommand command = new MySqlCommand(sql, connection))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        adapter.Fill(consolas);
                    }
                }
            }
            return consolas;
        }

    }
}
