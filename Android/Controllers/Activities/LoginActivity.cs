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

namespace Android.Controllers.Activities
{
    [Activity(Label = "LetsCookie", MainLauncher = true, Icon = "@drawable/icon", Theme = "@android:style/Theme.Black.NoTitleBar.Fullscreen")]
    public class LoginActivity : Activity
    {
        private Button _btnEntrar;
        private EditText _editLogin;
        private EditText _editSenha;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.LoginActivity);
            

        }

        private void setupUI()
        {

        }
    }
}