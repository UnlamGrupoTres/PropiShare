using Android.App;
using Android.OS;
using Android.Widget;
using SQLite;
using System;
using System.IO;

namespace Propishare
{
    [Activity(Label = "Registro")]
    public class UsuarioRegistro : Activity
    {
        EditText txtNuevoUsuario;
        EditText txtContraseñaNueva;

        EditText txtNuevoApellido;
        EditText txtNuevoEmail;

        Button btnCrearUsuario;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Propishare.Resource.Layout.NuevoUsuario);

            btnCrearUsuario = FindViewById<Button>(Propishare.Resource.Id.btnRegistrar);
            txtNuevoUsuario = FindViewById<EditText>(Propishare.Resource.Id.txtNuevoUsuario);
            txtContraseñaNueva = FindViewById<EditText>(Propishare.Resource.Id.txtContraseñaNuevoUsuario);
           
            txtNuevoEmail = FindViewById<EditText>(Propishare.Resource.Id.txtemail);
            txtNuevoApellido = FindViewById<EditText>(Propishare.Resource.Id.txtapellido);

            btnCrearUsuario.Click += BtnCriarNovoUsuario_Click;
        }

        private void BtnCriarNovoUsuario_Click(object sender, System.EventArgs e)
        {
            try
            {
                string dpPath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "Usuario.db3");
                var db = new SQLiteConnection(dpPath);
                db.CreateTable<Login>();
                Login tblogin = new Login();
                tblogin.usuario = txtNuevoUsuario.Text;
                tblogin.Contraseña = txtContraseñaNueva.Text;
                tblogin.apellido = txtNuevoApellido.Text;
                tblogin.email = txtNuevoEmail.Text;

                db.Insert(tblogin);
                Toast.MakeText(this, "Registro concluido con éxito...,", ToastLength.Short).Show();
                StartActivity(typeof(UsuarioLogin));
            }
            catch (Exception ex)
            {
                Toast.MakeText(this, ex.ToString(), ToastLength.Short).Show();
            }
        }
    }
}