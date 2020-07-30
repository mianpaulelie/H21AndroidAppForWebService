using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;

namespace H21AndroidAppForWebService
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : Activity
    {

        TextView txtshow;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            Button btnget = FindViewById<Button>(Resource.Id.btnGetWebServiceInfo);
            txtshow = FindViewById<TextView>(Resource.Id.txtShow);
            btnget.Click += Btnget_Click;

           

        }

        private void Btnget_Click(object sender, System.EventArgs e)
        {
            ContactWebservice.WebServiceH21 webser = new ContactWebservice.WebServiceH21();

            webser.GetJsonAsync();
            webser.GetJsonCompleted += Webser_GetJsonCompleted;
        }

        private void Webser_GetJsonCompleted(object sender, ContactWebservice.GetJsonCompletedEventArgs e)
        {
            txtshow.Text = e.Result.ToString();
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}