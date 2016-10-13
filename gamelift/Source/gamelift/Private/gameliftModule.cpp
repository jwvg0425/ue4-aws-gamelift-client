#include "gameliftModulePrivatePCH.h"
#include "gameliftModule.h"

void GameliftModuleImpl::StartupModule()
{
	Aws::InitAPI(options);
}

void GameliftModuleImpl::ShutdownModule()
{
	Aws::ShutdownAPI(options);
}

IMPLEMENT_MODULE(GameliftModuleImpl, Module);