using System;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;
using System.Text;

namespace Proyecto
{
	public class Autenticacion : MySQL
	{
		public Autenticacion ()
		{
		}

		public bool valido(String login, String password){
			this.abrirConexion();

			password = this.SHA1(password);

			String sql = "SELECT * FROM Usuarios WHERE login = '"+login+"' AND password = '"+password+"'";

            MySqlCommand myCommand = new MySqlCommand(sql, myConnection);
            MySqlDataReader myReader = myCommand.ExecuteReader();	

			bool hasRows = myReader.HasRows;

            myReader.Close();
			myReader = null;
            myCommand.Dispose();
			myCommand = null;

			this.cerrarConexion();

			return hasRows;
		}

		private string SHA1( string str ){
			return str; // retorna varable str sin ser codificada a sha1
            byte[] bt = System.Text.Encoding.ASCII.GetBytes(str);
            SHA1 sha1 = new SHA1CryptoServiceProvider();

			byte[] cifrado = sha1.ComputeHash( bt );
			string cadenaCifrada = BitConverter.ToString(cifrado);
			cadenaCifrada = cadenaCifrada.Replace( "-", "" );

			return cadenaCifrada;
		}
	}
}
