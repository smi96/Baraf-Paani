using System;
using UnityEngine.UI;
using UnityEngine.Networking;

namespace AssemblyCSharp
{
	public class OverridenNetworkDiscovery : NetworkDiscovery
	{
		public InputField ipinput;
		public override void OnReceivedBroadcast(string fromAddress , string Data)
		{
			if (ipinput.text.Equals ("127.0.0.1")) {
				int i = 0;
				char[] array = fromAddress.ToCharArray ();
				do {
					if(array[i] - '0' <=9) break;
					i++;
				} while(true);

				ipinput.text = fromAddress.Substring (i);
			}
		}
	}
}

