﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MvvmCross.Core.ViewModels;
using MvvmCross.Platform;
using RoutingExample.Core.ViewModels;

namespace RoutingExample.Core
{
    public class App : MvxApplication
    {

        public override void Initialize()
        {
            base.Initialize();

            // Construct custom application start object    
            Mvx.ConstructAndRegisterSingleton<IMvxAppStart, AppStart>();
            var appStart = Mvx.Resolve<IMvxAppStart>();

            // register the appstart object
            RegisterAppStart(appStart);
        }
    }
}
