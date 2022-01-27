// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

public class TestUITarget : TargetRules
{
	public TestUITarget(TargetInfo Target) : base(Target)
	{
		
		Type = TargetType.Game;
		DefaultBuildSettings = BuildSettingsVersion.V2;

		bForceUnityBuild = false;
		bUsePCHFiles = false;

		ExtraModuleNames.AddRange( new string[] { "TestUI" } );
	}
}
