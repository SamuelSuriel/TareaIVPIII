using System;

public class Class1
{
	public Class1()
	{


class conexion
    {
        //Parámetros para la cadena de conexion
        public string servidor, usuario, clave, db; 
        public string cadena;
        
        //función que tendrá la cadena de conexión
        
        public void conec()
        {
            servidor = "localhost";
            db = "DB_Avanzada";
            usuario = "sa";
            clave = "123456";
            cadena = "server="+ servidor +";uid="+ usuario + "; pwd=" + clave + ";database="+ db;
        }
    }
}
