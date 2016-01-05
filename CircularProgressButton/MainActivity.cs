using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace CircularProgressButton
{
    [Activity(Label = "CircularProgressButton", Icon = "@drawable/icon")]
    public class MainActivity : ListActivity
    {
        int count = 1;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            String[] items = Resources.GetStringArray(Resource.Array.sample_list);

            ArrayAdapter<String> adapter = new ArrayAdapter<String>(this, Android.Resource.Layout.SimpleListItem1,items);
            ListAdapter = adapter;
        }
        protected override void OnListItemClick(ListView l, View v, int position, long id)
        {
            switch (position)
            {
                case 0:
                    Sample1Activity.startThisActivity(this);
                    break;
                case 1:
                    Sample2Activity.startThisActivity(this);
                    break;
                case 2:
                    Sample3Activity.startThisActivity(this);
                    break;
                case 3:
                    Sample4Activity.startThisActivity(this);
                    break;
                case 4:
                    Sample5Activity.startThisActivity(this);
                    break;
            }
        }
    }
}

