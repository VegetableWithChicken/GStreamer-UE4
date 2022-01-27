// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.IO;

public class gStreamerAndroid : ModuleRules
{
    public gStreamerAndroid(ReadOnlyTargetRules Target) : base(Target)
    {
        Type= ModuleType.External;
        DefaultBuildSettings = BuildSettingsVersion.V2;
        PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;
        bUseUnity = false;
        bEnableUndefinedIdentifierWarnings = false;


        PublicDependencyModuleNames.AddRange(
        new string[]
            {
				// ... add other public dependencies that you statically link with here ...
			});

        if (Target.Platform == UnrealTargetPlatform.Win64 || Target.Platform == UnrealTargetPlatform.Win32)
        {
            const string GStreamerRoot = @"C:\gstreamer\1.0\x86_64"; // path to gstreamer development package

            PublicIncludePaths.Add(Path.Combine(GStreamerRoot, "include"));
            PublicIncludePaths.Add(Path.Combine(GStreamerRoot, "include", "gstreamer-1.0"));
            PublicIncludePaths.Add(Path.Combine(GStreamerRoot, "include", "glib-2.0"));
            PublicIncludePaths.Add(Path.Combine(GStreamerRoot, "lib", "glib-2.0", "include"));

            var GStreamerLibPath = Path.Combine(GStreamerRoot, "lib");
            var GStreamerBinPath = Path.Combine(GStreamerRoot, "bin");
            PublicSystemLibraryPaths.Add(GStreamerLibPath);

            PublicAdditionalLibraries.Add(Path.Combine(GStreamerLibPath, "glib-2.0.lib"));
            PublicAdditionalLibraries.Add(Path.Combine(GStreamerLibPath, "gobject-2.0.lib"));
            PublicAdditionalLibraries.Add(Path.Combine(GStreamerLibPath, "gstreamer-1.0.lib"));
            PublicAdditionalLibraries.Add(Path.Combine(GStreamerLibPath, "gstvideo-1.0.lib"));
            PublicAdditionalLibraries.Add(Path.Combine(GStreamerLibPath, "gstapp-1.0.lib"));

            PublicDelayLoadDLLs.Add(Path.Combine(GStreamerBinPath, "libglib-2.0-0.dll"));
            PublicDelayLoadDLLs.Add(Path.Combine(GStreamerBinPath,"libgobject-2.0-0.dll"));
            PublicDelayLoadDLLs.Add(Path.Combine(GStreamerBinPath,"libgstreamer-1.0-0.dll"));
            PublicDelayLoadDLLs.Add(Path.Combine(GStreamerBinPath,"libgstvideo-1.0-0.dll"));
            PublicDelayLoadDLLs.Add(Path.Combine(GStreamerBinPath,"libgstapp-1.0-0.dll"));
        }


        PrivateDependencyModuleNames.AddRange(
            new string[]
            {
                "Projects"
				// ... add private dependencies that you statically link with here ...	
			}
            );

        if (Target.Platform == UnrealTargetPlatform.Android)
        {
            const string GStreamerRoot = "$(ModuleDir)/../../ThirdParty/gStreamerAndroid"; // path to gstreamer development package

            PublicIncludePaths.Add(Path.Combine(GStreamerRoot, "include"));
            PublicIncludePaths.Add(Path.Combine(GStreamerRoot, "include", "gstreamer-1.0"));
            PublicIncludePaths.Add(Path.Combine(GStreamerRoot, "include", "glib-2.0"));
            PublicIncludePaths.Add(Path.Combine(GStreamerRoot, "lib", "glib-2.0", "include"));
            AdditionalPropertiesForReceipt.Add("AndroidPlugin", Path.Combine(ModuleDirectory, "gStreamer_UPL.XML"));
            //PublicAdditionalLibraries.Add(ModuleDirectory + "/ThirdParty/gstreamer/android/libgstreamer_android.so");
            // PublicAdditionalLibraries.Add(ModuleDirectory + "/ThirdParty/gstreamer/android/libc++_shared.so");
            //PublicAdditionalLibraries.Add(ModuleDirectory + "/ThirdParty/gstreamer/android/libRTSPServer.so");
        }
    }
}
