// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class TheLastSeal : ModuleRules
{
	public TheLastSeal(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"UMG",
			"Slate"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"TheLastSeal",
			"TheLastSeal/Variant_Platforming",
			"TheLastSeal/Variant_Platforming/Animation",
			"TheLastSeal/Variant_Combat",
			"TheLastSeal/Variant_Combat/AI",
			"TheLastSeal/Variant_Combat/Animation",
			"TheLastSeal/Variant_Combat/Gameplay",
			"TheLastSeal/Variant_Combat/Interfaces",
			"TheLastSeal/Variant_Combat/UI",
			"TheLastSeal/Variant_SideScrolling",
			"TheLastSeal/Variant_SideScrolling/AI",
			"TheLastSeal/Variant_SideScrolling/Gameplay",
			"TheLastSeal/Variant_SideScrolling/Interfaces",
			"TheLastSeal/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
