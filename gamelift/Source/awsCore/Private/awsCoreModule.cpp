#include "awsCoreModulePrivatePCH.h"
#include "awsCoreModule.h"

void AwsCoreModuleImpl::StartupModule()
{
	Aws::InitAPI(options);
}

void AwsCoreModuleImpl::ShutdownModule()
{
	Aws::ShutdownAPI(options);
}

IMPLEMENT_MODULE(AwsCoreModuleImpl, awsCore);