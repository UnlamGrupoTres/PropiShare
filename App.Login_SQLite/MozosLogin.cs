using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System.IO;
using SQLite;
using System.Data;
using Android.Database;

namespace Propishare
{
    [Activity(Label = "Login de Mozos", MainLauncher = true, Icon = "@drawable/Icon")]
    public class MozosLogin : Activity
    {
        EditText txtEmail;
        EditText txtContraseña;
        Button btnLogin;

       

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            try
            {
                string dpPath = System.IO.Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "user.db3");
                var db = new SQLiteConnection(dpPath);
                db.CreateTable<Mozos>();
                Mozos tblogin = new Mozos();
                tblogin.Nombre = "Maria";
                tblogin.Apellido = "Paz";
                tblogin.Email = "mariapaz@gmail.com";
                tblogin.Direccion = "Almafuerte 2030, San Justo";
                tblogin.Contraseña = "Pass";

                db.Insert(tblogin);

                db.CreateTable<Propinas>();
                Propinas propina1 = new Propinas()
                {
                    fecha = DateTime.Now,
                    monto = 80,
                    idCliente = 1,
                    idEmpleado = 1
                };
                db.Insert(propina1);
                
              


                

               // iv = (ImageView)findViewById(R.id.myimage);



                
            }

            catch
            {


            }


            SetContentView(Propishare.Resource.Layout.MozoLogin);
            // Create your application here

            // Get our button from the layout resource,  
            // and attach an event to it  
            btnLogin = FindViewById<Button>(Resource.Id.btnLogin);
            // btncreate = FindViewById<Button>(Resource.Id.btnregister);

            txtEmail = FindViewById<EditText>(Resource.Id.Email);
            txtContraseña = FindViewById<EditText>(Resource.Id.txtContraseñaMozo);
            btnLogin.Click += Btnsign_Click;
            // btncreate.Click += Btncreate_Click;
            CreateDB();
            
            //private void Btncreate_Click(object sender, EventArgs e)
            //{
            //    StartActivity(typeof(RegisterActivity));
            //}
           


          //


        }

        private void Btnsign_Click(object sender, EventArgs e)
        {
            try
            {
                string dpPath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "user.db3"); //Call Database  
                var db = new SQLiteConnection(dpPath);
                var data = db.Table<Mozos>(); //Call Table  
                var data1 = data.Where(x => x.Email == txtEmail.Text && x.Contraseña == txtContraseña.Text).FirstOrDefault(); //Linq Query  
                if (data1 != null)
                {
                    Toast.MakeText(this, "Login Exitoso", ToastLength.Short).Show();

                    Button button = FindViewById<Button>(Resource.Id.btnLogin);

                    /*
                    inicio prueba               */




                    /*Fin prueba*/



                    button.Click += delegate {
                        String nom = data1.Nombre;
                        String apel = data1.Apellido;
                        String id = data1.Id.ToString();

                        var intent = new Intent(this, typeof(MozoGestion));

                        intent.PutExtra("Nombre", nom );

                        intent.PutExtra("Apellido", apel);
                        intent.PutExtra("idMozo", id);
                       
                       

                        StartActivity(intent);


                    };


                  //  StartActivity(typeof(MozoGestion));


                }
                else
                {
                    Toast.MakeText(this, "Username or Password invalid", ToastLength.Short).Show();
                }
            }
            catch (Exception ex)
            {
                Toast.MakeText(this, ex.ToString(), ToastLength.Short).Show();
            }
        }


        public string CreateDB()
        {
            var output = "";
            output += "Creating Databse if it doesnt exists";
            string dpPath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "user.db3"); //Create New Database  
            var db = new SQLiteConnection(dpPath);
            output += "\n Database Created....";
            return output;
        }
        // Prueba:








}
}

