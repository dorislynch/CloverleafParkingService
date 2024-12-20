using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace Cloverleaf.Parking.Service.RNCloverleafParkingService
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNCloverleafParkingServiceModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RNCloverleafParkingServiceModule"/>.
        /// </summary>
        internal RNCloverleafParkingServiceModule()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RNCloverleafParkingService";
            }
        }
    }
}
