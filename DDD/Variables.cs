/*
==================================================
      KINGDOM HEARTS - RE:FIXED FOR DDD!
       COPYRIGHT TOPAZ WHITELOCK - 2022
 LICENSED UNDER DBAD. GIVE CREDIT WHERE IT'S DUE! 
==================================================
*/

using System;
using System.IO;
using System.Media;
using System.Threading;
using System.Reflection;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Runtime.InteropServices;

using DiscordRPC;

namespace ReFixed
{
    public class Variables
    {
        //
        // CONFIG VARIABLES
        //
        // Variables that will be read from a config file to tell Re:Fixed what to do.
        //

        public static bool sfxToggle = true;
        public static bool rpcToggle = true;
        public static bool saveToggle = true;

        public static bool devMode = false;

        //
        // INFORMATION GRAB
        //
        // Grab informaiton from the EXE direct.
        //

        static Assembly ExeAssembly = Assembly.GetExecutingAssembly();

        //
        // RESOURCE LIBRARY
        //
        // Reserved for static resources, or initialization of APIs
        //

        public static DiscordRpcClient DiscordClient = new DiscordRpcClient("990165470080540702");

        public static Stream SaveSFX = ExeAssembly.GetManifestResourceStream("sfxSave.wav");        
        public static string SaveSFXPath = Path.GetTempPath() + "ReFixed/saveSFX.wav";

        //
        // RPC ASSET LIBRARY
        //
        // Everything DiscordRPC uses (except for the RPC itself) resides here.
        //

        public static string[] BTLDictionary = { "safe", "mob", "boss" };
        public static string[] WRLDictionary = { "", "di", "mt", "tt", "dc", "ft", "pn", "hb", "cc", "tr", "eh", "wm", "tt" };
        public static string[] CHRDictionary = { "Sora", "Riku" };
        public static string[] MDEDictionary = { "Beginner Mode", "Standard Mode", "Proud Mode", "Critical Mode" };

        //
        // ALTERED VARIABLES
        //
        // Variables that can be altered reside here.
        //

        public static bool Initialized = false;

        public static Task DCTask;
        public static Task ASTask;
        public static CancellationToken Token;
        public static CancellationTokenSource Source;

        //
        // ADDRESSES
        //
        // All of the necessary address values.
        //

        public static ulong BASE_ADDRESS = 0x770EFA;

        public static ulong ADDR_Input = 0x354E16;
        public static ulong ADDR_Vibration = 0x2DCE4C;
        public static ulong ADDR_SystemBAR = 0x101D1E76;
        public static ulong ADDR_Reset = 0x354FBE;
        public static ulong ADDR_Limiter = 0x354FD8;
        public static ulong ADDR_Framerate = 0x146573E0;

        //
        // INSTRUCTION ADDRESSES
        //
        // Addresses for instructions are here.
        //

        public static ulong ADDR_TimeINST = 0x2DD410;
        public static ulong ADDR_DrawINST = 0x2DD51B;
        public static ulong ADDR_PromptINST = 0x6CC010;
        public static ulong ADDR_LimiterINST = 0x60DB93;

        //
        // INSTRUCTIONS
        // 
        // We store the actual instructions here.
        //

        public static byte[] INST_DropTimer = { 0xF3, 0x0F, 0x5C, 0xC8 };
    }
}
