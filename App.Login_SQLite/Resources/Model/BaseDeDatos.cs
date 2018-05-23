using Android.Media;
using SQLite;


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
        public int id { get; set; }

        [MaxLength(25)]
        public string nombre { get; set; }

        [MaxLength(25)]
        public string apellido { get; set; }

        [MaxLength(25)]
        public string direccion { get; set; }

        [MaxLength(15)]
        public string Contraseña { get; set; }

        [MaxLength(15)]
        public string email { get; set; }

        [MaxLength(12)]
        public int telefono { get; set; }


        [MaxLength(25)]
        public int idRoles { get; set; }


        //Editado

    }

}