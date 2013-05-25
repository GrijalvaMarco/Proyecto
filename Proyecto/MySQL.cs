using System;
using MySql.Data.MySqlClient;
using archivos;

namespace Proyecto
{
	public class MySQL
	{
		protected MySqlConnection myConnection;
		public MySQL ()
		{
		}

		protected void abrirConexion(){
			Archivo configuracion = new Archivo("config.txt");
			string connectionString =configuracion.leer();
     	  	this.myConnection = new MySqlConnection(connectionString);
	       	this.myConnection.Open();
		}

		protected void cerrarConexion(){
			this.myConnection.Close(); 
			this.myConnection = null;
		}
	}
}
