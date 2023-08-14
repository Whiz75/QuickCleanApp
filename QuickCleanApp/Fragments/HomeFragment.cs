using Android.App;
using Android.OS;
using Android.Views;
using Fragment = AndroidX.Fragment.App.Fragment;

namespace QuickCleanApp.Fragments
{
    public class HomeFragment : Fragment
    {
        public HomeFragment()
        {
        }

        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your fragment here
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            // Use this to return your custom view for this Fragment
            // return inflater.Inflate(Resource.Layout.YourFragment, container, false);
            View view = inflater.Inflate(Resource.Layout.home_fragment, container, false);
            Init(view);

            return view;
        }

        private void Init(View view)
        {

        }
    }
}