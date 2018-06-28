using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using SQLite;
using Android.Database.Sqlite;
using Android.Database;
using System.Reflection;


namespace Propishare
{
    [Activity(Label = "MozoGestion" )]
    public class MozoGestion : Activity
    {
       // private ListView lista;
        ListView lv;
        ArrayList lista;
        ArrayAdapter adaptador;


        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.MozoGestion);

            // Create your application here
            
            TextView tNombre = FindViewById<TextView>(Resource.Id.textView1);
            TextView tApellido = FindViewById<TextView>(Resource.Id.textView2);
            TextView tid = FindViewById<TextView>(Resource.Id.textView4);
            
             

            String Nombre = Intent.GetStringExtra("Nombre");
            String Apellido = Intent.GetStringExtra("Apellido");
            String idMozo = Intent.GetStringExtra("idMozo");
            int Mozo = int.Parse(idMozo);
          

           

            tNombre.Text = Nombre;
            tApellido.Text = Apellido;
            tid.Text = idMozo;

        }
    }
}