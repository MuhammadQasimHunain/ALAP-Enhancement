using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ALAP_Enhancement.Services
{
    public static class Settings
    {
        public static string LatexExecutablePath
        {
            get
            {
                return @"C:\Program Files\MiKTeX 2.9\miktex\bin\x64\pdflatex.exe";
            }
        }
        public static string LatexfolderRelativePath
        {
            get
            {
                return @"..\LatexContent\";
            }
        }
        public static string EnableCursorMode
        {   //To enable curser mode
            get
            {
                return string.Format("Cursor mode is enabled");
            }
        }
        public static string DisableCursorMode
        {   //To disable curser mode
            get
            {
                return string.Format("Cursor mode is disabled");
            }
        }
        public static string EnablePdfMode
        {   //To enable curser mode
            get
            {
                return string.Format("P D F mode is enabled");
            }
        }
        public static string DisablePdfMode
        {   //To disable curser mode
            get
            {
                return string.Format("P D F mode is disabled");
            }
        }
        public static string NoFurtherText
        {
            get
            {
                return string.Format("No further text");
            }
        }
        public static string EmptyLine
        {
            get
            {
                return string.Format("empty line");
            }
        }
        public static string TurnOnTTSSystem
        {
            get
            {
                return string.Format("TTS System is turned on");
            }
        }
        public static string Compile
        {
            get
            {
                return string.Format("Code is Compiling");
            }
        }
        public static string TurnOffCompleteTTSSystem
        {
            get
            {
                return string.Format("TTS System is turned Off");
            }
        }
        public static string TurnOnCompleteTTSSystem
        {
            get
            {
                return string.Format("TTS System is turned on");
            }
        }
        public static string TurnOffTTSSystem
        {
            get
            {
                return string.Format("TTS is Stopped");
            }
        }
        public static string TTSSystemIsPaused
        {
            get
            {
                return string.Format("TTS System is paused");
            }
        }
        public static string TTSSystemIsResumed
        {
            get
            {
                return string.Format("TTS System is Resumed");
            }
        }
        public static string TTSSystemIsReady
        {
            get
            {
                return string.Format("TTS System is Ready");
            }
        }
        public static string VerbosityLevelOfTTSByWord
        {
            get
            {
                return string.Format("verbosity level of TTS is by word");
            }
        }
        public static string VerbosityLevelOfTTSByChar
        {
            get
            {
                return string.Format("verbosity level of TTS is by chracter");
            }
        }
        public static string CapsKeyIsOn
        {
            get
            {
                return string.Format("Caps On");
            }
        }
        public static string NewLine
        {
            get
            {
                return string.Format("New Line");
            }
        }
    }
}