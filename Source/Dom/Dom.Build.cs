// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class Dom : ModuleRules
{
	public Dom(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[]
		{
			"Core", "CoreUObject", "Engine", "InputCore", "Chaos", "ChaosVehicles", "HeadMountedDisplay", "PhysicsCore"
		});
	}
}