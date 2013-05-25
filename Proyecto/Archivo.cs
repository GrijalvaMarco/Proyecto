using System;
using System.IO;

namespace archivos
{
	public class Archivo
	{
		private string path;

		public Archivo (String path)
		{
			this.path = path;
		}

		public void setPath(String path){
			this.path = path;
		}

		public string leer(){
			String linea;
			try 
				{
					string contenido = "";
					//Se indica el archivo a leer
					StreamReader lector = new StreamReader(this.path);

					//Lee la primera linea del archivo
					linea = lector.ReadLine();
					contenido += linea;

					//Continua leyendo hasta que se termina el archivo
					while (linea != null) 
					{
						//Lee la siguiente linea
						linea = lector.ReadLine();
						contenido += linea;
					}

					//cierra el lector
					lector.Close();
					return contenido;
				}
				catch(Exception e)
				{
					return "";
				}
		}
	}
}

