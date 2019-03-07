using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace File.Opener.RNFileOpener
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNFileOpenerModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RNFileOpenerModule"/>.
        /// </summary>
        internal RNFileOpenerModule()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RNFileOpener";
            }
        }
    }
}
