﻿using Grpc.Core;
using Luck.Walnut.Application.Environments;
using Luck.Walnut.Query.Environments;
using Luck.Walnut.V1;

namespace Luck.Walnut.Api.GrpcServices
{
    public class GetConfigService : GetConfig.GetConfigBase
    {
        private readonly IEnvironmentQueryService _environmentQueryService;

        public GetConfigService(IEnvironmentQueryService environmentQueryService)
        {
            _environmentQueryService = environmentQueryService;
        }

        public override async Task<ApplicationConfigResponse> GetAppliactionConfig(ApplicationConfigRequest request, ServerCallContext context)
        {
            var configs = await _environmentQueryService.GetAppConfigurationByAppIdAndEnvironmentNameAsync(request.AppId, request.EnvironmentName);
                        var response = new ApplicationConfigResponse();
            
            
            
            
            return response;
        }
    }
}
