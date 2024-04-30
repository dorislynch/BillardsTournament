using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace Billards.Tournament.RNBillardsTournament
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNBillardsTournamentModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RNBillardsTournamentModule"/>.
        /// </summary>
        internal RNBillardsTournamentModule()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RNBillardsTournament";
            }
        }
    }
}
