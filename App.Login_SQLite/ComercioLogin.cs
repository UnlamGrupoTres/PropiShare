using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Drawing;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.Media;
using SQLite;
using Android.Graphics;

namespace Propishare
{
    [Activity(Label = "Login de Comercio")]
    public class ComercioLogin : Activity
    {

        EditText txtUsuario;
        EditText txtContrase�a;
        Button btnLogin;

        
       


        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            //agregue estps datos como ejemplo para loguearse sirve
            try
            {
                string dpPath = System.IO.Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "Usuario.db3");
                var db = new SQLiteConnection(dpPath);
                db.CreateTable<Comercio>();
                Comercio tblogin = new Comercio();
                tblogin.nombreComercio = "Rayuela";
                tblogin.telefonoComercio = 47893042;
                tblogin.emailComercio = "Rayuela@outlook";
                tblogin.direccionComercio = "Balvanera 333, CABA";
                tblogin.Contrase�a = "Rayuela";
       
                    

                db.Insert(tblogin);
            }

            catch
            {


            }


            SetContentView(Propishare.Resource.Layout.ComercioLogin);

            btnLogin = FindViewById<Button>(Propishare.Resource.Id.btnIngresarComercio);
            txtUsuario = FindViewById<EditText>(Propishare.Resource.Id.txtNombreComercio);
            txtContrase�a = FindViewById<EditText>(Propishare.Resource.Id.txtContrase�aComercio);

            btnLogin.Click += BtnLogin_Click;
           
            CrearBancoDeDatos();

            
        }


        

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string dbPath = System.IO.Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "Usuario.db3"); //Chama DB  
                var db = new SQLiteConnection(dbPath);
                var dados = db.Table<Comercio>();
                var login = dados.Where(x => x.nombreComercio == txtUsuario.Text && x.Contrase�a == txtContrase�a.Text).FirstOrDefault(); //Consulta LINQ 
                if (login != null)
                {
                    Toast.MakeText(this, "Login realizado exitosamente", ToastLength.Short).Show();

                    StartActivity(typeof(ComercioGestion));
                }
                else
                {
                    Toast.MakeText(this, "Nombre y/o contrase�a inv�lidos", ToastLength.Short).Show();
                }
            }
            catch (Exception ex)
            {
                Toast.MakeText(this, "Nombre y/o contrase�a inv�lidos", ToastLength.Short).Show();
            }
        }


        private void CrearBancoDeDatos()
        {
            try
            {
                string dbPath = System.IO.Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "Usuario.db3"); //Cria o BD
                var db = new SQLiteConnection(dbPath);
            }
            catch (Exception ex)
            {
                Toast.MakeText(this, ex.ToString(), ToastLength.Short).Show();
            }
        }
    }
}