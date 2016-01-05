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
using Android.Animation;
using Android.Views.Animations;
namespace CircularProgressButton
{
    [Activity(Label = "Sample2Activity")]
    public class Sample2Activity : Activity, CirButton.IOnClickListener, ValueAnimator.IAnimatorUpdateListener
    {
        CirButton circularButton1;
        CirButton circularButton2;
        bool success;
        CirButton cirbutton;
        public static void startThisActivity(Activity activity)
        {
            activity.StartActivity(new Intent(activity, typeof(Sample2Activity)));

        }
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.ac_sample_2);
            ActionBar actionBar = ActionBar;
            if (actionBar != null)
            {
                actionBar.SetTitle(Resource.String.IntegerProgressSample);
            }
            circularButton1 = FindViewById<CirButton>(Resource.Id.circularButton1);

            circularButton1.SetOnClickListener(this);

            circularButton2 = FindViewById<CirButton>(Resource.Id.circularButton2);

            circularButton2.SetOnClickListener(this);
        }

        public void OnClick(View v)
        {
            switch (v.Id)
            {
                case Resource.Id.circularButton1:
                    if (circularButton1.Progress == 0)
                    {
                        simulateSuccessProgress(circularButton1);
                    }
                    else
                    {
                        circularButton1.Progress = 0;
                    }
                    break;
                case Resource.Id.circularButton2:
                    if (circularButton2.Progress == 0)
                    {
                        simulateErrorProgress(circularButton2);
                    }
                    else
                    {
                        circularButton2.Progress = 0;
                    }
                    break;
            }
        }

        private void simulateSuccessProgress(CirButton button)
        {
            success = true;
            this.cirbutton = button;
            ValueAnimator widthAnimation = ValueAnimator.OfInt(1, 100);
            widthAnimation.SetDuration(1500);
            widthAnimation.SetInterpolator(new AccelerateDecelerateInterpolator());
            widthAnimation.AddUpdateListener(this);
            widthAnimation.Start();
        }
        private void simulateErrorProgress(CirButton button)
        {
            this.cirbutton = button;
            success = false;
            ValueAnimator widthAnimation = ValueAnimator.OfInt(1, 99);
            widthAnimation.SetDuration(1500);
            widthAnimation.SetInterpolator(new AccelerateDecelerateInterpolator());
            widthAnimation.AddUpdateListener(this);
            widthAnimation.Start();
        }
        public void OnAnimationUpdate(ValueAnimator animation)
        {
            switch (success)
            {
                case true:
                    int value = (int)animation.AnimatedValue;
                    cirbutton.Progress = value;
                    break;

                case false:
                    int value2 = (int)animation.AnimatedValue;
                    cirbutton.Progress = value2;
                    if (value2 == 99)
                    {
                        cirbutton.Progress = -1;
                    }
                    break;

            }
        }
    }
}