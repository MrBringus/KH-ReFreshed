/*
=================================================
      KINGDOM HEARTS - RE:FIXED FOR 1 FM!
       COPYRIGHT TOPAZ WHITELOCK - 2022
 LICENSED UNDER MIT. GIVE CREDIT WHERE IT'S DUE! 
=================================================
*/

using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace ReFixed
{
	public partial class Variables
	{
        public static Process GameProcess;
        public static IntPtr GameHandle;
        public static ulong GameAddress;

		public static ulong BaseAddress = 0x3A0606;
		public static ulong FovSwitchAddress = 0x2A5B7DA;

		public static ulong InputAddress = 0x1F9CA2E;

		public static ulong SoraMPAddress = 0x246E512;
		public static ulong SoraMagicAddress = 0x2A4543E;
		
		public static ulong SaveMenuSelect = 0x2A7C552; 
		public static ulong[] ResetAddresses = new ulong[] { 0x1F480D6, 0x1F480DA, 0x1F9BC3A };

		public static ulong[] FovTextAddresses = new ulong[] { 0x2A76F66, 0x2A78F86 };
		public static ulong[] CamTextAddresses = new ulong[] { 0x2A76F6E, 0x2A79D4D };

		public static ushort[] FovTextOffsets = new ushort[] { 0x1EBA, 0x1EC8, 0x1ED0, 0x1ED9 };
		public static ushort[] CamTextOffsets = new ushort[] { 0x2C88, 0x2C8F };

		public static float[] FovClassic = new float[] { 400, -50, -100, 350, 300, 300, 300, 300 };
		public static float[] FovEnhanced = new float[] { 600, 0, -150, 600, 600, 600, 600, 600 };

        public static ulong[] FovAddresses = new ulong[] 
        { 
            0x2194066, 0x2194072, 0x219406E, 
            0x0163352, 0x0163372, 0x0163392, 0x01633B2,
            0x2A4518E
        };

		public static byte[] FovTextArray = new byte[] 
		{ 
			0x30, 0x4D, 0x49, 0x50, 0x48, 0x01, 0x53, 0x4A, 0x01, 
			0x40, 0x4D, 0x49, 0x5B, 0x00, 0x2D, 0x50, 0x45, 0x57, 
			0x57, 0x4D, 0x47, 0x00, 0x2F, 0x52, 0x4C, 0x45, 0x52, 
			0x47, 0x49, 0x48, 0x00, 0x3E, 0x53, 0x4B, 0x4B, 0x50, 
			0x49, 0x01, 0x46, 0x49, 0x58, 0x5B, 0x49, 0x49, 0x52, 
			0x01, 0x30, 0x4D, 0x49, 0x50, 0x48, 0x01, 0x53, 0x4A, 
			0x01, 0x40, 0x4D, 0x49, 0x5B, 0x01, 0x51, 0x53, 0x48, 
			0x49, 0x57, 0x68, 0x00 
		};

		public static byte[] CamTextArray = new byte[] 
		{
			0x42, 0x64, 0x2B, 0x5C, 0x4D, 0x57, 0x00, 
			0x43, 0x64, 0x2B, 0x5C, 0x4D, 0x57, 0x00
		};
	}
}