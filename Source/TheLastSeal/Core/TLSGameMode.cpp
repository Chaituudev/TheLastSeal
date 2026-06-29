// Fill out your copyright notice in the Description page of Project Settings.


#include "Core/TLSGameMode.h"
#include "Player/TLSCharacter.h"
#include "Controllers/TLSPlayerController.h"

ATLSGameMode::ATLSGameMode()
{
    DefaultPawnClass = ATLSCharacter::StaticClass();
    PlayerControllerClass = ATLSPlayerController::StaticClass();
}