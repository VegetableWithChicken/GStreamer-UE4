// Fill out your copyright notice in the Description page of Project Settings.


#include "MyClass.h"
#if PLATFORM_ANDROID
namespace GST{
	extern "C" {
#include "../ThirdParty/gStreamerAndroid/include/gstreamer-1.0/gst/gst.h"
#include "../ThirdParty/gStreamerAndroid/include/glib-2.0/glib.h"

	};
}

#endif //PLATFORM_ANDROID
MyClass::MyClass()

{
}

MyClass::~MyClass()
{
}
