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
using Java.Lang;
namespace CircularProgressButton
{
    [Activity(Label = "Sample1Activity")]
    public class Sample1Activity : Activity, CirButton.IOnClickListener
    {
        CirButton circularButton1;
        CirButton circularButton2;
        public static void startThisActivity(Activity activity)
        {
            activity.StartActivity(new Intent(activity, typeof(Sample1Activity)));

        }
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.ac_sample_1);
            ActionBar actionBar = ActionBar;
            if (actionBar != null)
            {
                actionBar.SetTitle(Resource.String.IndeterminateProgressSample);
            }
           
            circularButton1 = FindViewById<CirButton>(Resource.Id.circularButton1);
            circularButton1.SetMaxEms(1000000000);
            circularButton1.IndeterminateProgressMode = true;
            circularButton1.SetOnClickListener(this);
            circularButton2 = FindViewById<CirButton>(Resource.Id.circularButton2);
            circularButton2.IndeterminateProgressMode = true;
            circularButton2.SetOnClickListener(this);
        }

        public void OnClick(View v)
        {
            switch (v.Id)
            {
                case Resource.Id.circularButton1:
                    if (circularButton1.Progress == 0)
                    {
                      for(int i=0;i<=1000;i++)
                        {
                            circularButton1.Progress++;
                        }

                    }
                    else if (circularButton1.Progress == 100)
                    {
                        circularButton1.Progress = 0;
                    }
                    else
                    {
                        circularButton1.Progress = 100;
                    }
                    break;
                case Resource.Id.circularButton2:
                    if (circularButton2.Progress == 0)
                    {
                        circularButton2.Progress = 50;
                    }
                    else if (circularButton2.Progress == -1)
                    {
                        circularButton2.Progress = 0;
                    }
                    else
                    {
                        circularButton2.Progress = -1;
                    }
                    break;
            }

        }
    }
}