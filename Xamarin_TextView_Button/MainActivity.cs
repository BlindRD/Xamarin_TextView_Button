using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace Xamarin_TextView_Button
{
    [Activity(Label = "Android.Xamarin | Часть 2 — TextView и Button (Hello world)", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {

        TextView myTxt;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.rarimardLayout);

            Button myButton = FindViewById<Button>(Resource.Id.button1);
            myTxt = FindViewById<TextView>(Resource.Id.textView1);

            myButton.Click += helloWorld;

        }

        private void helloWorld(object sender, EventArgs e)
        {
            myTxt.Text = "Hello World!";
        }
    }
}

