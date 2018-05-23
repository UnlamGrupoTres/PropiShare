using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SQLite;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Propishare.Resources.layout
{
    [Activity(Label = "PropiShare", MainLauncher = true, Icon = "@drawable/icon")]
    public class pantallaInicial : Activity
    {

        Button aClientes;
        Button aComercios;
        Button aMozos;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Propishare.Resource.Layout.pantallaInicial);

            aClientes = FindViewById<Button>(Propishare.Resource.Id.btnCliente);
            aComercios = FindViewById<Button>(Propishare.Resource.Id.btnComercio);
            aMozos = FindViewById<Button>(Propishare.Resource.Id.btnMozo);


            aClientes.Click += btn_Cliente_Click;
            aComercios.Click += btn_Comercio_Click;
            aMozos.Click += btn_Mozo_Click;

            CrearBancoDeDatos();

        }


        private void btn_Cliente_Click(object sender, EventArgs e)
        {
            StartActivity(typeof(UsuarioLogin));
        }

        private void btn_Comercio_Click(object sender, EventArgs e)
        {
            StartActivity(typeof(ComercioLogin));
        }


        private void btn_Mozo_Click(object sender, EventArgs e)
        {
            StartActivity(typeof(MozosLogin));
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