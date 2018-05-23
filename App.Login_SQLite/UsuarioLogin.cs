using Android.App;
using Android.Content;
using Android.OS;
using Android.Widget;
using SQLite;
using System;
using System.IO;

namespace Propishare
{
    [Activity(Label = "Login de Usuario")]
    public class UsuarioLogin : Activity
    {
        EditText txtUsuario;
        EditText txtContraseña;
        Button btnCrear;
        Button btnLogin;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            //agregue estps datos como ejemplo para loguearse sirve
            try
            {
                string dpPath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "Usuario.db3");
                var db = new SQLiteConnection(dpPath);
                db.CreateTable<Login>();
                Login tblogin = new Login();
                tblogin.usuario = "Carlos";
                tblogin.Contraseña = "Carlos";
                tblogin.apellido = "Soto";
                tblogin.email = "CSoto2@gmail.com";

                db.Insert(tblogin);
            }

            catch {


            }



            SetContentView(Propishare.Resource.Layout.UsuarioLogin);

            btnLogin = FindViewById<Button>(Propishare.Resource.Id.btnLogin);
            btnCrear = FindViewById<Button>(Propishare.Resource.Id.btnRegistrar);
            txtUsuario = FindViewById<EditText>(Propishare.Resource.Id.txtUsuario);
            txtContraseña = FindViewById<EditText>(Propishare.Resource.Id.txtContraseña);

            btnLogin.Click += BtnLogin_Click;
            btnCrear.Click += btn_Crear_Click;
            CrearBancoDeDatos();

        }

        private void btn_Crear_Click(object sender, EventArgs e)
        {
            StartActivity(typeof(UsuarioRegistro));
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string dbPath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "Usuario.db3"); //Chama DB  
                var db = new SQLiteConnection(dbPath);
                var dados = db.Table<Login>();
                
                var login = dados.Where(x => x.usuario == txtUsuario.Text && x.Contraseña == txtContraseña.Text).FirstOrDefault(); //Consulta LINQ 
                if (login != null)
                {
                    Toast.MakeText(this, "Login realizado exitosamente", ToastLength.Short).Show();
                    var atividade2 = new Intent(this, typeof(UsuarioPrincipal));
                    
                    atividade2.PutExtra("nombre", FindViewById<EditText>(Propishare.Resource.Id.txtUsuario).Text);
                    StartActivity(atividade2);
                }
                else
                {
                    Toast.MakeText(this, "Nombre y/o contraseña inválidos", ToastLength.Short).Show();
                }
            }
            catch (Exception ex)
            {
                Toast.MakeText(this, "Nombre y/o contraseña inválidos", ToastLength.Short).Show();
            }
        }

        private void CrearBancoDeDatos()
        {
            try
            {
                string dbPath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "Usuario.db3"); //Cria o BD
                var db = new SQLiteConnection(dbPath);
            }
            catch (Exception ex)
            {
                Toast.MakeText(this, ex.ToString(), ToastLength.Short).Show();
            }
        }
    }
}

