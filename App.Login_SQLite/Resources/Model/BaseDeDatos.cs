using Android.Media;
using SQLite;
using System;

namespace Propishare
{
    public class Login
    {
        //aca va todo lo de usuarios

        [PrimaryKey, AutoIncrement]
        public int id { get; set; }

        [MaxLength(25)]
        public string usuario { get; set; }

        [MaxLength(25)]
        public string apellido { get; set; }

        [MaxLength(15)]
        public string Contraseña { get; set; }

        [MaxLength(15)]
        public string email { get; set; }

        [MaxLength(25)]
        public int idRoles { get; set; }


    }



    public class Comercio
    {
        [PrimaryKey, AutoIncrement]
        public int idComercio { get; set; }

        [MaxLength(25)]
        public string nombreComercio { get; set; }

        [MaxLength(25)]
        public string direccionComercio { get; set; }

        [MaxLength(15)]
        public string Contraseña { get; set; }

        [MaxLength(12)]
        public int telefonoComercio { get; set; }

        [MaxLength(15)]
        public string emailComercio { get; set; }

        // public Image fotoComercio { get; set; }

    }



    public class Mozos
    {


        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [MaxLength(25)]
        public string Nombre { get; set; }

        [MaxLength(25)]
        public string Apellido { get; set; }

        [MaxLength(25)]
        public string Direccion { get; set; }

        [MaxLength(15)]
        public string Contraseña { get; set; }

        [MaxLength(15)]
        public string Email { get; set; }

        [MaxLength(12)]
        public int Telefono { get; set; }


        [MaxLength(25)]
        public int IdRoles { get; set; }




    }

    public class Propinas
    {
        [PrimaryKey, AutoIncrement]
        public int IdPropina { get; set; }
        public DateTime fecha { get; set; }
        public float monto { get; set; }
        public int idCliente { get; set; }
        public int idEmpleado { get; set; }


    }
}