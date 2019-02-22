using System;
using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Support.Design.Widget;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;

namespace TipCalculator
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme.NoActionBar", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        private EditText inputBill;
        private Button calculateButton;
        private TextView outputTip;
        private TextView outputTotal;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_main);

            inputBill = FindViewById<EditText>(Resource.Id.inputBill);
            calculateButton = FindViewById<Button>(Resource.Id.calculateButton);
            outputTip = FindViewById<TextView>(Resource.Id.outputTip);
            outputTotal = FindViewById<TextView>(Resource.Id.outputTotal);

            calculateButton.Click += OnCalculateClick;
        }

        private void OnCalculateClick(object sender, EventArgs e)
        {
            double.TryParse(inputBill.Text, out double bill);

            var tip = bill * 0.15;
            var total = bill + tip;

            outputTip.Text = tip.ToString();
            outputTotal.Text = total.ToString();
        }
    }
}