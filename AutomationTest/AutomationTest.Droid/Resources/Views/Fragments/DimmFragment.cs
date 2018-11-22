﻿using Android.OS;
using Android.Views;
using AutomationTest.Core.ViewModels;
using MvvmCross.Binding.Droid.BindingContext;
using MvvmCross.Droid.Support.V4;

namespace AutomationTest.Droid.Resources.Views.Fragments
{
    public class DimmFragment : MvxFragment<DimmPackagesViewModel>
    {
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            base.OnCreateView(inflater, container, savedInstanceState);
            return this.BindingInflate(Resource.Layout.fragment_dimm_packages, null);
        }
    }
}