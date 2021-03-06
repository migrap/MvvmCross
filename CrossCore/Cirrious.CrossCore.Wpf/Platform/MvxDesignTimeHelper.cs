// MvxDesignTimeHelper.cs
// (c) Copyright Cirrious Ltd. http://www.cirrious.com
// MvvmCross is licensed using Microsoft Public License (Ms-PL)
// Contributions and inspirations noted in readme.md and license.txt
// 
// Project Lead - Stuart Lodge, @slodge, me@slodge.com

using System.ComponentModel;
using Cirrious.CrossCore.Core;
using Cirrious.CrossCore.IoC;

namespace Cirrious.CrossCore.Wpf.Platform
{
    public abstract class MvxDesignTimeHelper
    {
        protected MvxDesignTimeHelper()
        {
            if (!(bool)DesignerProperties.IsInDesignModeProperty.GetMetadata(typeof(System.Windows.DependencyObject)).DefaultValue)
                return;

            if (MvxSingleton<IMvxIoCProvider>.Instance == null)
            {
                var iocProvider = MvxSimpleIoCContainer.Initialise();
                Mvx.RegisterSingleton(iocProvider);
            }
        }
    }
}