using System.Runtime.InteropServices;
using UnityEngine;

namespace NativeLanguage {
    public static class NativeLanguage {

        #if UNITY_IOS && !UNITY_EDITOR
        [DllImport ("__Internal")] 
        public static extern string NativeLocale_GetLanguage();
        #endif
        
        public static string GetLanguage()
        {
#if !UNITY_EDITOR
    #if UNITY_ANDROID
            try
            {
                var locale = new AndroidJavaClass("java.util.Locale");
                var localeInst = locale.CallStatic<AndroidJavaObject>("getDefault");
                var name = localeInst.Call<string>("getLanguage");
                return name;
            }
            catch(System.Exception e)
            {
                return "Error";
            }
    #elif UNITY_IOS
            return NativeLocale_GetLanguage();
    #else
            return "Not supported"
	#endif
#endif
	        return "Not supported";
        }
        
    }
}
