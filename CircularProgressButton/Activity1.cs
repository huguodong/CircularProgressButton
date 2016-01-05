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
using CirButton = Com.DD.CircularProgressButton;
namespace CircularProgressButton
{
    [Activity(Label = "Activity1", MainLauncher = true)]
    public class Activity1 : Activity
    {
        CirButton circularButton1;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.layout1);
            circularButton1 = FindViewById<CirButton>(Resource.Id.circularButton1);

            circularButton1.Click += delegate
            {
                if (circularButton1.Progress != 100)
                {
                    circularButton1.Progress += 10;
                }
                else { circularButton1.Progress = 0; }
            };
            // Create your application herebtnWithText
        }
    }
}