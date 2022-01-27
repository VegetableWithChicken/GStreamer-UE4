# gStreamerForUE4 
> Both Windows and Android versions are supported  
#### download GStreamer choice 1.63 
> The Windows and Android versions are not the same, so you need to download them separately. Thirdparty files includes android version 1.63  
> > https://gstreamer.freedesktop.org/download/  
#### in gStreamerAndroid.Build.cs
> const string GStreamerRoot = @"C:\gstreamer\1.0\x86_64"; // path to gstreamer development package
> On Windows, you need to copy the DLL file to the project Bianries
#### download gstreamer_android .so file
>https://zhuanlan.zhihu.com/p/460407293
#### how to add .cpp file,and do like this :
```
canot add it to .h file ,if .., it will error when package android
XXXX.cpp
#if PLATFORM_ANDROID
namespace GST{
	extern "C" {
#include "../ThirdParty/gStreamerAndroid/include/gstreamer-1.0/gst/gst.h"
#include "../ThirdParty/gStreamerAndroid/include/glib-2.0/glib.h"

	};
}

#endif //PLATFORM_ANDROID
```
#### There are a few configurations in build.cs that need to be noted
```
Type= ModuleType.External;
DefaultBuildSettings = BuildSettingsVersion.V2;
PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;
bUseUnity = false;
bEnableUndefinedIdentifierWarnings = false;
```
