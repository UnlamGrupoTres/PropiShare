using Android.App;
using Android.Content;
using Android.OS;
using Android.Widget;

namespace Propishare
{
    [Activity(Label = "Pantalla de Usuario")]
    public class UsuarioPrincipal : Activity
    {
        TextView txtTextoLogin;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Propishare.Resource.Layout.UsuarioPrincipal);
            txtTextoLogin = FindViewById<TextView>(Propishare.Resource.Id.txtTextoLogin);
            //toma los datos obtenidos en la primera actividad y se muestra en TextField
            FindViewById<TextView>(Propishare.Resource.Id.txtTextoLogin).Text = txtTextoLogin.Text + " : " + Intent.GetStringExtra("nome") ?? "Error en datos";
        }
    }
}