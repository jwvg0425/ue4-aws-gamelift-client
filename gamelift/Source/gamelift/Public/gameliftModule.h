#pragma once

#include "ModuleManager.h"

class GameliftModuleImpl : public IModuleInterface
{
public:
	void StartupModule();
	void ShutdownModule();
};