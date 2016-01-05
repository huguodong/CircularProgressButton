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
    [Activity(Label = "Sample3Activity")]
    public class Sample3Activity : Activity, CirButton.IOnClickListener
    {
        CirButton circularButton1;
        CirButton circularButton2;
        public static void startThisActivity(Activity activity)
        {
            activity.StartActivity(new Intent(activity, typeof(Sample3Activity)));

        }
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.ac_sample_3);
            ActionBar actionBar = ActionBar;
            if (actionBar != null)
            {
                actionBar.SetTitle(Resource.String.StateChangeSample);
            }
            circularButton1 = FindViewById<CirButton>(Resource.Id.circularButton1);
            circularButton1.SetOnClickListener(this);
            circularButton2 = FindViewById<CirButton>(Resource.Id.circularButton2);
            circularButton2.SetOnClickListener(this);
            // Create your application here
        }

        public void OnClick(View v)
        {
            switch (v.Id)
            {
                case Resource.Id.circularButton1:
                    if (circularButton1.Progress == 0)
                    {
                        circularButton1.Progress = 100;
                    }
                    else
                    {
                        circularButton1.Progress = 0;
                    }
                    break;
                case Resource.Id.circularButton2:
                    if (circularButton2.Progress == 0)
                    {
                        circularButton2.Progress = -1;
                    }
                    else
                    {
                        circularButton2.Progress = 0;
                    }
                    break;
            }
        }
    }
}