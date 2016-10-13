#pragma once

#include "ModuleManager.h"

#include "aws/gamelift/GameliftClient.h"
#include "aws/gamelift/model/SearchGameSessionsRequest.h"
#include "aws/gamelift/model/CreatePlayerSessionsRequest.h"


class GameliftModuleImpl : public IModuleInterface
{
public:
	void StartupModule();
	void ShutdownModule();

private:
};