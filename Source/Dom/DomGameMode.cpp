// Copyright Epic Games, Inc. All Rights Reserved.

#include "DomGameMode.h"
#include "DomPawn.h"
#include "DomHud.h"

ADomGameMode::ADomGameMode()
{
	DefaultPawnClass = ADomPawn::StaticClass();
	HUDClass = ADomHud::StaticClass();
}
