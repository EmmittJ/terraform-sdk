using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for serial_pipeline in GoogleClouddeployDeliveryPipeline.
/// Nesting mode: list
/// </summary>
public class GoogleClouddeployDeliveryPipelineSerialPipelineBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "serial_pipeline";

    /// <summary>
    /// Stages block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleClouddeployDeliveryPipelineSerialPipelineBlockStagesBlock>? Stages
    {
        get => GetArgument<TerraformList<GoogleClouddeployDeliveryPipelineSerialPipelineBlockStagesBlock>>("stages");
        set => SetArgument("stages", value);
    }

}

/// <summary>
/// Block type for stages in GoogleClouddeployDeliveryPipelineSerialPipelineBlock.
/// Nesting mode: list
/// </summary>
public class GoogleClouddeployDeliveryPipelineSerialPipelineBlockStagesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "stages";

    /// <summary>
    /// Skaffold profiles to use when rendering the manifest for this stage&#39;s `Target`.
    /// </summary>
    public TerraformList<string>? Profiles
    {
        get => GetArgument<TerraformList<string>>("profiles");
        set => SetArgument("profiles", value);
    }

    /// <summary>
    /// The target_id to which this stage points. This field refers exclusively to the last segment of a target name. For example, this field would just be `my-target` (rather than `projects/project/locations/location/targets/my-target`). The location of the `Target` is inferred to be the same as the location of the `DeliveryPipeline` that contains this `Stage`.
    /// </summary>
    public TerraformValue<string>? TargetId
    {
        get => GetArgument<TerraformValue<string>>("target_id");
        set => SetArgument("target_id", value);
    }

    /// <summary>
    /// DeployParameters block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleClouddeployDeliveryPipelineSerialPipelineBlockStagesBlockDeployParametersBlock>? DeployParameters
    {
        get => GetArgument<TerraformList<GoogleClouddeployDeliveryPipelineSerialPipelineBlockStagesBlockDeployParametersBlock>>("deploy_parameters");
        set => SetArgument("deploy_parameters", value);
    }

    /// <summary>
    /// Strategy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Strategy block(s) allowed")]
    public TerraformList<GoogleClouddeployDeliveryPipelineSerialPipelineBlockStagesBlockStrategyBlock>? Strategy
    {
        get => GetArgument<TerraformList<GoogleClouddeployDeliveryPipelineSerialPipelineBlockStagesBlockStrategyBlock>>("strategy");
        set => SetArgument("strategy", value);
    }

}

/// <summary>
/// Block type for deploy_parameters in GoogleClouddeployDeliveryPipelineSerialPipelineBlockStagesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleClouddeployDeliveryPipelineSerialPipelineBlockStagesBlockDeployParametersBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "deploy_parameters";

    /// <summary>
    /// Optional. Deploy parameters are applied to targets with match labels. If unspecified, deploy parameters are applied to all targets (including child targets of a multi-target).
    /// </summary>
    public TerraformMap<string>? MatchTargetLabels
    {
        get => GetArgument<TerraformMap<string>>("match_target_labels");
        set => SetArgument("match_target_labels", value);
    }

    /// <summary>
    /// Required. Values are deploy parameters in key-value pairs.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ValuesAttribute is required")]
    public required TerraformMap<string> ValuesAttribute
    {
        get => GetRequiredArgument<TerraformMap<string>>("values");
        set => SetArgument("values", value);
    }

}

/// <summary>
/// Block type for strategy in GoogleClouddeployDeliveryPipelineSerialPipelineBlockStagesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleClouddeployDeliveryPipelineSerialPipelineBlockStagesBlockStrategyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "strategy";

    /// <summary>
    /// Canary block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Canary block(s) allowed")]
    public TerraformList<GoogleClouddeployDeliveryPipelineSerialPipelineBlockStagesBlockStrategyBlockCanaryBlock>? Canary
    {
        get => GetArgument<TerraformList<GoogleClouddeployDeliveryPipelineSerialPipelineBlockStagesBlockStrategyBlockCanaryBlock>>("canary");
        set => SetArgument("canary", value);
    }

    /// <summary>
    /// Standard block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Standard block(s) allowed")]
    public TerraformList<GoogleClouddeployDeliveryPipelineSerialPipelineBlockStagesBlockStrategyBlockStandardBlock>? Standard
    {
        get => GetArgument<TerraformList<GoogleClouddeployDeliveryPipelineSerialPipelineBlockStagesBlockStrategyBlockStandardBlock>>("standard");
        set => SetArgument("standard", value);
    }

}

/// <summary>
/// Block type for canary in GoogleClouddeployDeliveryPipelineSerialPipelineBlockStagesBlockStrategyBlock.
/// Nesting mode: list
/// </summary>
public class GoogleClouddeployDeliveryPipelineSerialPipelineBlockStagesBlockStrategyBlockCanaryBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "canary";

    /// <summary>
    /// CanaryDeployment block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CanaryDeployment block(s) allowed")]
    public TerraformList<GoogleClouddeployDeliveryPipelineSerialPipelineBlockStagesBlockStrategyBlockCanaryBlockCanaryDeploymentBlock>? CanaryDeployment
    {
        get => GetArgument<TerraformList<GoogleClouddeployDeliveryPipelineSerialPipelineBlockStagesBlockStrategyBlockCanaryBlockCanaryDeploymentBlock>>("canary_deployment");
        set => SetArgument("canary_deployment", value);
    }

    /// <summary>
    /// CustomCanaryDeployment block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CustomCanaryDeployment block(s) allowed")]
    public TerraformList<GoogleClouddeployDeliveryPipelineSerialPipelineBlockStagesBlockStrategyBlockCanaryBlockCustomCanaryDeploymentBlock>? CustomCanaryDeployment
    {
        get => GetArgument<TerraformList<GoogleClouddeployDeliveryPipelineSerialPipelineBlockStagesBlockStrategyBlockCanaryBlockCustomCanaryDeploymentBlock>>("custom_canary_deployment");
        set => SetArgument("custom_canary_deployment", value);
    }

    /// <summary>
    /// RuntimeConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RuntimeConfig block(s) allowed")]
    public TerraformList<GoogleClouddeployDeliveryPipelineSerialPipelineBlockStagesBlockStrategyBlockCanaryBlockRuntimeConfigBlock>? RuntimeConfig
    {
        get => GetArgument<TerraformList<GoogleClouddeployDeliveryPipelineSerialPipelineBlockStagesBlockStrategyBlockCanaryBlockRuntimeConfigBlock>>("runtime_config");
        set => SetArgument("runtime_config", value);
    }

}

/// <summary>
/// Block type for canary_deployment in GoogleClouddeployDeliveryPipelineSerialPipelineBlockStagesBlockStrategyBlockCanaryBlock.
/// Nesting mode: list
/// </summary>
public class GoogleClouddeployDeliveryPipelineSerialPipelineBlockStagesBlockStrategyBlockCanaryBlockCanaryDeploymentBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "canary_deployment";

    /// <summary>
    /// Required. The percentage based deployments that will occur as a part of a `Rollout`. List is expected in ascending order and each integer n is 0 &amp;lt;= n &amp;lt; 100.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Percentages is required")]
    public TerraformList<double>? Percentages
    {
        get => GetArgument<TerraformList<double>>("percentages");
        set => SetArgument("percentages", value);
    }

    /// <summary>
    /// Whether to run verify tests after each percentage deployment.
    /// </summary>
    public TerraformValue<bool>? Verify
    {
        get => GetArgument<TerraformValue<bool>>("verify");
        set => SetArgument("verify", value);
    }

    /// <summary>
    /// Postdeploy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Postdeploy block(s) allowed")]
    public TerraformList<GoogleClouddeployDeliveryPipelineSerialPipelineBlockStagesBlockStrategyBlockCanaryBlockCanaryDeploymentBlockPostdeployBlock>? Postdeploy
    {
        get => GetArgument<TerraformList<GoogleClouddeployDeliveryPipelineSerialPipelineBlockStagesBlockStrategyBlockCanaryBlockCanaryDeploymentBlockPostdeployBlock>>("postdeploy");
        set => SetArgument("postdeploy", value);
    }

    /// <summary>
    /// Predeploy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Predeploy block(s) allowed")]
    public TerraformList<GoogleClouddeployDeliveryPipelineSerialPipelineBlockStagesBlockStrategyBlockCanaryBlockCanaryDeploymentBlockPredeployBlock>? Predeploy
    {
        get => GetArgument<TerraformList<GoogleClouddeployDeliveryPipelineSerialPipelineBlockStagesBlockStrategyBlockCanaryBlockCanaryDeploymentBlockPredeployBlock>>("predeploy");
        set => SetArgument("predeploy", value);
    }

}

/// <summary>
/// Block type for postdeploy in GoogleClouddeployDeliveryPipelineSerialPipelineBlockStagesBlockStrategyBlockCanaryBlockCanaryDeploymentBlock.
/// Nesting mode: list
/// </summary>
public class GoogleClouddeployDeliveryPipelineSerialPipelineBlockStagesBlockStrategyBlockCanaryBlockCanaryDeploymentBlockPostdeployBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "postdeploy";

    /// <summary>
    /// Optional. A sequence of skaffold custom actions to invoke during execution of the postdeploy job.
    /// </summary>
    public TerraformList<string>? Actions
    {
        get => GetArgument<TerraformList<string>>("actions");
        set => SetArgument("actions", value);
    }

}

/// <summary>
/// Block type for predeploy in GoogleClouddeployDeliveryPipelineSerialPipelineBlockStagesBlockStrategyBlockCanaryBlockCanaryDeploymentBlock.
/// Nesting mode: list
/// </summary>
public class GoogleClouddeployDeliveryPipelineSerialPipelineBlockStagesBlockStrategyBlockCanaryBlockCanaryDeploymentBlockPredeployBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "predeploy";

    /// <summary>
    /// Optional. A sequence of skaffold custom actions to invoke during execution of the predeploy job.
    /// </summary>
    public TerraformList<string>? Actions
    {
        get => GetArgument<TerraformList<string>>("actions");
        set => SetArgument("actions", value);
    }

}

/// <summary>
/// Block type for custom_canary_deployment in GoogleClouddeployDeliveryPipelineSerialPipelineBlockStagesBlockStrategyBlockCanaryBlock.
/// Nesting mode: list
/// </summary>
public class GoogleClouddeployDeliveryPipelineSerialPipelineBlockStagesBlockStrategyBlockCanaryBlockCustomCanaryDeploymentBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "custom_canary_deployment";

    /// <summary>
    /// PhaseConfigs block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PhaseConfigs is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 PhaseConfigs block(s) required")]
    public required TerraformList<GoogleClouddeployDeliveryPipelineSerialPipelineBlockStagesBlockStrategyBlockCanaryBlockCustomCanaryDeploymentBlockPhaseConfigsBlock> PhaseConfigs
    {
        get => GetRequiredArgument<TerraformList<GoogleClouddeployDeliveryPipelineSerialPipelineBlockStagesBlockStrategyBlockCanaryBlockCustomCanaryDeploymentBlockPhaseConfigsBlock>>("phase_configs");
        set => SetArgument("phase_configs", value);
    }

}

/// <summary>
/// Block type for phase_configs in GoogleClouddeployDeliveryPipelineSerialPipelineBlockStagesBlockStrategyBlockCanaryBlockCustomCanaryDeploymentBlock.
/// Nesting mode: list
/// </summary>
public class GoogleClouddeployDeliveryPipelineSerialPipelineBlockStagesBlockStrategyBlockCanaryBlockCustomCanaryDeploymentBlockPhaseConfigsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "phase_configs";

    /// <summary>
    /// Required. Percentage deployment for the phase.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Percentage is required")]
    public required TerraformValue<double> Percentage
    {
        get => GetRequiredArgument<TerraformValue<double>>("percentage");
        set => SetArgument("percentage", value);
    }

    /// <summary>
    /// Required. The ID to assign to the `Rollout` phase. This value must consist of lower-case letters, numbers, and hyphens, start with a letter and end with a letter or a number, and have a max length of 63 characters. In other words, it must match the following regex: `^[a-z]([a-z0-9-]{0,61}[a-z0-9])?$`.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PhaseId is required")]
    public required TerraformValue<string> PhaseId
    {
        get => GetRequiredArgument<TerraformValue<string>>("phase_id");
        set => SetArgument("phase_id", value);
    }

    /// <summary>
    /// Skaffold profiles to use when rendering the manifest for this phase. These are in addition to the profiles list specified in the `DeliveryPipeline` stage.
    /// </summary>
    public TerraformList<string>? Profiles
    {
        get => GetArgument<TerraformList<string>>("profiles");
        set => SetArgument("profiles", value);
    }

    /// <summary>
    /// Whether to run verify tests after the deployment.
    /// </summary>
    public TerraformValue<bool>? Verify
    {
        get => GetArgument<TerraformValue<bool>>("verify");
        set => SetArgument("verify", value);
    }

    /// <summary>
    /// Postdeploy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Postdeploy block(s) allowed")]
    public TerraformList<GoogleClouddeployDeliveryPipelineSerialPipelineBlockStagesBlockStrategyBlockCanaryBlockCustomCanaryDeploymentBlockPhaseConfigsBlockPostdeployBlock>? Postdeploy
    {
        get => GetArgument<TerraformList<GoogleClouddeployDeliveryPipelineSerialPipelineBlockStagesBlockStrategyBlockCanaryBlockCustomCanaryDeploymentBlockPhaseConfigsBlockPostdeployBlock>>("postdeploy");
        set => SetArgument("postdeploy", value);
    }

    /// <summary>
    /// Predeploy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Predeploy block(s) allowed")]
    public TerraformList<GoogleClouddeployDeliveryPipelineSerialPipelineBlockStagesBlockStrategyBlockCanaryBlockCustomCanaryDeploymentBlockPhaseConfigsBlockPredeployBlock>? Predeploy
    {
        get => GetArgument<TerraformList<GoogleClouddeployDeliveryPipelineSerialPipelineBlockStagesBlockStrategyBlockCanaryBlockCustomCanaryDeploymentBlockPhaseConfigsBlockPredeployBlock>>("predeploy");
        set => SetArgument("predeploy", value);
    }

}

/// <summary>
/// Block type for postdeploy in GoogleClouddeployDeliveryPipelineSerialPipelineBlockStagesBlockStrategyBlockCanaryBlockCustomCanaryDeploymentBlockPhaseConfigsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleClouddeployDeliveryPipelineSerialPipelineBlockStagesBlockStrategyBlockCanaryBlockCustomCanaryDeploymentBlockPhaseConfigsBlockPostdeployBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "postdeploy";

    /// <summary>
    /// Optional. A sequence of skaffold custom actions to invoke during execution of the postdeploy job.
    /// </summary>
    public TerraformList<string>? Actions
    {
        get => GetArgument<TerraformList<string>>("actions");
        set => SetArgument("actions", value);
    }

}

/// <summary>
/// Block type for predeploy in GoogleClouddeployDeliveryPipelineSerialPipelineBlockStagesBlockStrategyBlockCanaryBlockCustomCanaryDeploymentBlockPhaseConfigsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleClouddeployDeliveryPipelineSerialPipelineBlockStagesBlockStrategyBlockCanaryBlockCustomCanaryDeploymentBlockPhaseConfigsBlockPredeployBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "predeploy";

    /// <summary>
    /// Optional. A sequence of skaffold custom actions to invoke during execution of the predeploy job.
    /// </summary>
    public TerraformList<string>? Actions
    {
        get => GetArgument<TerraformList<string>>("actions");
        set => SetArgument("actions", value);
    }

}

/// <summary>
/// Block type for runtime_config in GoogleClouddeployDeliveryPipelineSerialPipelineBlockStagesBlockStrategyBlockCanaryBlock.
/// Nesting mode: list
/// </summary>
public class GoogleClouddeployDeliveryPipelineSerialPipelineBlockStagesBlockStrategyBlockCanaryBlockRuntimeConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "runtime_config";

    /// <summary>
    /// CloudRun block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CloudRun block(s) allowed")]
    public TerraformList<GoogleClouddeployDeliveryPipelineSerialPipelineBlockStagesBlockStrategyBlockCanaryBlockRuntimeConfigBlockCloudRunBlock>? CloudRun
    {
        get => GetArgument<TerraformList<GoogleClouddeployDeliveryPipelineSerialPipelineBlockStagesBlockStrategyBlockCanaryBlockRuntimeConfigBlockCloudRunBlock>>("cloud_run");
        set => SetArgument("cloud_run", value);
    }

    /// <summary>
    /// Kubernetes block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Kubernetes block(s) allowed")]
    public TerraformList<GoogleClouddeployDeliveryPipelineSerialPipelineBlockStagesBlockStrategyBlockCanaryBlockRuntimeConfigBlockKubernetesBlock>? Kubernetes
    {
        get => GetArgument<TerraformList<GoogleClouddeployDeliveryPipelineSerialPipelineBlockStagesBlockStrategyBlockCanaryBlockRuntimeConfigBlockKubernetesBlock>>("kubernetes");
        set => SetArgument("kubernetes", value);
    }

}

/// <summary>
/// Block type for cloud_run in GoogleClouddeployDeliveryPipelineSerialPipelineBlockStagesBlockStrategyBlockCanaryBlockRuntimeConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleClouddeployDeliveryPipelineSerialPipelineBlockStagesBlockStrategyBlockCanaryBlockRuntimeConfigBlockCloudRunBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "cloud_run";

    /// <summary>
    /// Whether Cloud Deploy should update the traffic stanza in a Cloud Run Service on the user&#39;s behalf to facilitate traffic splitting. This is required to be true for CanaryDeployments, but optional for CustomCanaryDeployments.
    /// </summary>
    public TerraformValue<bool>? AutomaticTrafficControl
    {
        get => GetArgument<TerraformValue<bool>>("automatic_traffic_control");
        set => SetArgument("automatic_traffic_control", value);
    }

    /// <summary>
    /// Optional. A list of tags that are added to the canary revision while the canary phase is in progress.
    /// </summary>
    public TerraformList<string>? CanaryRevisionTags
    {
        get => GetArgument<TerraformList<string>>("canary_revision_tags");
        set => SetArgument("canary_revision_tags", value);
    }

    /// <summary>
    /// Optional. A list of tags that are added to the prior revision while the canary phase is in progress.
    /// </summary>
    public TerraformList<string>? PriorRevisionTags
    {
        get => GetArgument<TerraformList<string>>("prior_revision_tags");
        set => SetArgument("prior_revision_tags", value);
    }

    /// <summary>
    /// Optional. A list of tags that are added to the final stable revision when the stable phase is applied.
    /// </summary>
    public TerraformList<string>? StableRevisionTags
    {
        get => GetArgument<TerraformList<string>>("stable_revision_tags");
        set => SetArgument("stable_revision_tags", value);
    }

}

/// <summary>
/// Block type for kubernetes in GoogleClouddeployDeliveryPipelineSerialPipelineBlockStagesBlockStrategyBlockCanaryBlockRuntimeConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleClouddeployDeliveryPipelineSerialPipelineBlockStagesBlockStrategyBlockCanaryBlockRuntimeConfigBlockKubernetesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "kubernetes";

    /// <summary>
    /// GatewayServiceMesh block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GatewayServiceMesh block(s) allowed")]
    public TerraformList<GoogleClouddeployDeliveryPipelineSerialPipelineBlockStagesBlockStrategyBlockCanaryBlockRuntimeConfigBlockKubernetesBlockGatewayServiceMeshBlock>? GatewayServiceMesh
    {
        get => GetArgument<TerraformList<GoogleClouddeployDeliveryPipelineSerialPipelineBlockStagesBlockStrategyBlockCanaryBlockRuntimeConfigBlockKubernetesBlockGatewayServiceMeshBlock>>("gateway_service_mesh");
        set => SetArgument("gateway_service_mesh", value);
    }

    /// <summary>
    /// ServiceNetworking block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ServiceNetworking block(s) allowed")]
    public TerraformList<GoogleClouddeployDeliveryPipelineSerialPipelineBlockStagesBlockStrategyBlockCanaryBlockRuntimeConfigBlockKubernetesBlockServiceNetworkingBlock>? ServiceNetworking
    {
        get => GetArgument<TerraformList<GoogleClouddeployDeliveryPipelineSerialPipelineBlockStagesBlockStrategyBlockCanaryBlockRuntimeConfigBlockKubernetesBlockServiceNetworkingBlock>>("service_networking");
        set => SetArgument("service_networking", value);
    }

}

/// <summary>
/// Block type for gateway_service_mesh in GoogleClouddeployDeliveryPipelineSerialPipelineBlockStagesBlockStrategyBlockCanaryBlockRuntimeConfigBlockKubernetesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleClouddeployDeliveryPipelineSerialPipelineBlockStagesBlockStrategyBlockCanaryBlockRuntimeConfigBlockKubernetesBlockGatewayServiceMeshBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "gateway_service_mesh";

    /// <summary>
    /// Required. Name of the Kubernetes Deployment whose traffic is managed by the specified HTTPRoute and Service.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Deployment is required")]
    public required TerraformValue<string> Deployment
    {
        get => GetRequiredArgument<TerraformValue<string>>("deployment");
        set => SetArgument("deployment", value);
    }

    /// <summary>
    /// Required. Name of the Gateway API HTTPRoute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HttpRoute is required")]
    public required TerraformValue<string> HttpRoute
    {
        get => GetRequiredArgument<TerraformValue<string>>("http_route");
        set => SetArgument("http_route", value);
    }

    /// <summary>
    /// Optional. The label to use when selecting Pods for the Deployment and Service resources. This label must already be present in both resources.
    /// </summary>
    public TerraformValue<string>? PodSelectorLabel
    {
        get => GetArgument<TerraformValue<string>>("pod_selector_label");
        set => SetArgument("pod_selector_label", value);
    }

    /// <summary>
    /// Optional. The time to wait for route updates to propagate. The maximum configurable time is 3 hours, in seconds format. If unspecified, there is no wait time.
    /// </summary>
    public TerraformValue<string>? RouteUpdateWaitTime
    {
        get => GetArgument<TerraformValue<string>>("route_update_wait_time");
        set => SetArgument("route_update_wait_time", value);
    }

    /// <summary>
    /// Required. Name of the Kubernetes Service.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Service is required")]
    public required TerraformValue<string> Service
    {
        get => GetRequiredArgument<TerraformValue<string>>("service");
        set => SetArgument("service", value);
    }

    /// <summary>
    /// Optional. The amount of time to migrate traffic back from the canary Service to the original Service during the stable phase deployment. If specified, must be between 15s and 3600s. If unspecified, there is no cutback time.
    /// </summary>
    public TerraformValue<string>? StableCutbackDuration
    {
        get => GetArgument<TerraformValue<string>>("stable_cutback_duration");
        set => SetArgument("stable_cutback_duration", value);
    }

    /// <summary>
    /// RouteDestinations block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RouteDestinations block(s) allowed")]
    public TerraformList<GoogleClouddeployDeliveryPipelineSerialPipelineBlockStagesBlockStrategyBlockCanaryBlockRuntimeConfigBlockKubernetesBlockGatewayServiceMeshBlockRouteDestinationsBlock>? RouteDestinations
    {
        get => GetArgument<TerraformList<GoogleClouddeployDeliveryPipelineSerialPipelineBlockStagesBlockStrategyBlockCanaryBlockRuntimeConfigBlockKubernetesBlockGatewayServiceMeshBlockRouteDestinationsBlock>>("route_destinations");
        set => SetArgument("route_destinations", value);
    }

}

/// <summary>
/// Block type for route_destinations in GoogleClouddeployDeliveryPipelineSerialPipelineBlockStagesBlockStrategyBlockCanaryBlockRuntimeConfigBlockKubernetesBlockGatewayServiceMeshBlock.
/// Nesting mode: list
/// </summary>
public class GoogleClouddeployDeliveryPipelineSerialPipelineBlockStagesBlockStrategyBlockCanaryBlockRuntimeConfigBlockKubernetesBlockGatewayServiceMeshBlockRouteDestinationsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "route_destinations";

    /// <summary>
    /// Required. The clusters where the Gateway API HTTPRoute resource will be deployed to. Valid entries include the associated entities IDs configured in the Target resource and &amp;quot;@self&amp;quot; to include the Target cluster.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DestinationIds is required")]
    public TerraformList<string>? DestinationIds
    {
        get => GetArgument<TerraformList<string>>("destination_ids");
        set => SetArgument("destination_ids", value);
    }

    /// <summary>
    /// Optional. Whether to propagate the Kubernetes Service to the route destination clusters. The Service will always be deployed to the Target cluster even if the HTTPRoute is not. This option may be used to facilitiate successful DNS lookup in the route destination clusters. Can only be set to true if destinations are specified.
    /// </summary>
    public TerraformValue<bool>? PropagateService
    {
        get => GetArgument<TerraformValue<bool>>("propagate_service");
        set => SetArgument("propagate_service", value);
    }

}

/// <summary>
/// Block type for service_networking in GoogleClouddeployDeliveryPipelineSerialPipelineBlockStagesBlockStrategyBlockCanaryBlockRuntimeConfigBlockKubernetesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleClouddeployDeliveryPipelineSerialPipelineBlockStagesBlockStrategyBlockCanaryBlockRuntimeConfigBlockKubernetesBlockServiceNetworkingBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "service_networking";

    /// <summary>
    /// Required. Name of the Kubernetes Deployment whose traffic is managed by the specified Service.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Deployment is required")]
    public required TerraformValue<string> Deployment
    {
        get => GetRequiredArgument<TerraformValue<string>>("deployment");
        set => SetArgument("deployment", value);
    }

    /// <summary>
    /// Optional. Whether to disable Pod overprovisioning. If Pod overprovisioning is disabled then Cloud Deploy will limit the number of total Pods used for the deployment strategy to the number of Pods the Deployment has on the cluster.
    /// </summary>
    public TerraformValue<bool>? DisablePodOverprovisioning
    {
        get => GetArgument<TerraformValue<bool>>("disable_pod_overprovisioning");
        set => SetArgument("disable_pod_overprovisioning", value);
    }

    /// <summary>
    /// Optional. The label to use when selecting Pods for the Deployment resource. This label must already be present in the Deployment.
    /// </summary>
    public TerraformValue<string>? PodSelectorLabel
    {
        get => GetArgument<TerraformValue<string>>("pod_selector_label");
        set => SetArgument("pod_selector_label", value);
    }

    /// <summary>
    /// Required. Name of the Kubernetes Service.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Service is required")]
    public required TerraformValue<string> Service
    {
        get => GetRequiredArgument<TerraformValue<string>>("service");
        set => SetArgument("service", value);
    }

}

/// <summary>
/// Block type for standard in GoogleClouddeployDeliveryPipelineSerialPipelineBlockStagesBlockStrategyBlock.
/// Nesting mode: list
/// </summary>
public class GoogleClouddeployDeliveryPipelineSerialPipelineBlockStagesBlockStrategyBlockStandardBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "standard";

    /// <summary>
    /// Whether to verify a deployment.
    /// </summary>
    public TerraformValue<bool>? Verify
    {
        get => GetArgument<TerraformValue<bool>>("verify");
        set => SetArgument("verify", value);
    }

    /// <summary>
    /// Postdeploy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Postdeploy block(s) allowed")]
    public TerraformList<GoogleClouddeployDeliveryPipelineSerialPipelineBlockStagesBlockStrategyBlockStandardBlockPostdeployBlock>? Postdeploy
    {
        get => GetArgument<TerraformList<GoogleClouddeployDeliveryPipelineSerialPipelineBlockStagesBlockStrategyBlockStandardBlockPostdeployBlock>>("postdeploy");
        set => SetArgument("postdeploy", value);
    }

    /// <summary>
    /// Predeploy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Predeploy block(s) allowed")]
    public TerraformList<GoogleClouddeployDeliveryPipelineSerialPipelineBlockStagesBlockStrategyBlockStandardBlockPredeployBlock>? Predeploy
    {
        get => GetArgument<TerraformList<GoogleClouddeployDeliveryPipelineSerialPipelineBlockStagesBlockStrategyBlockStandardBlockPredeployBlock>>("predeploy");
        set => SetArgument("predeploy", value);
    }

}

/// <summary>
/// Block type for postdeploy in GoogleClouddeployDeliveryPipelineSerialPipelineBlockStagesBlockStrategyBlockStandardBlock.
/// Nesting mode: list
/// </summary>
public class GoogleClouddeployDeliveryPipelineSerialPipelineBlockStagesBlockStrategyBlockStandardBlockPostdeployBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "postdeploy";

    /// <summary>
    /// Optional. A sequence of skaffold custom actions to invoke during execution of the postdeploy job.
    /// </summary>
    public TerraformList<string>? Actions
    {
        get => GetArgument<TerraformList<string>>("actions");
        set => SetArgument("actions", value);
    }

}

/// <summary>
/// Block type for predeploy in GoogleClouddeployDeliveryPipelineSerialPipelineBlockStagesBlockStrategyBlockStandardBlock.
/// Nesting mode: list
/// </summary>
public class GoogleClouddeployDeliveryPipelineSerialPipelineBlockStagesBlockStrategyBlockStandardBlockPredeployBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "predeploy";

    /// <summary>
    /// Optional. A sequence of skaffold custom actions to invoke during execution of the predeploy job.
    /// </summary>
    public TerraformList<string>? Actions
    {
        get => GetArgument<TerraformList<string>>("actions");
        set => SetArgument("actions", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleClouddeployDeliveryPipeline.
/// Nesting mode: single
/// </summary>
public class GoogleClouddeployDeliveryPipelineTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a google_clouddeploy_delivery_pipeline Terraform resource.
/// Manages a google_clouddeploy_delivery_pipeline resource.
/// </summary>
public partial class GoogleClouddeployDeliveryPipeline(string name) : TerraformResource("google_clouddeploy_delivery_pipeline", name)
{
    /// <summary>
    /// User annotations. These attributes can only be set and used by the user, and not by Google Cloud Deploy. See https://google.aip.dev/128#annotations for more details such as format and size limitations.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the annotations present in your configuration.
    /// Please refer to the field `effective_annotations` for all of the annotations present on the resource.
    /// </summary>
    public TerraformMap<string>? Annotations
    {
        get => GetArgument<TerraformMap<string>>("annotations");
        set => SetArgument("annotations", value);
    }

    /// <summary>
    /// Description of the `DeliveryPipeline`. Max length is 255 characters.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Labels are attributes that can be set and used by both the user and by Google Cloud Deploy. Labels must meet the following constraints: * Keys and values can contain only lowercase letters, numeric characters, underscores, and dashes. * All characters must use UTF-8 encoding, and international characters are allowed. * Keys must start with a lowercase letter or international character. * Each resource is limited to a maximum of 64 labels. Both keys and values are additionally constrained to be &amp;lt;= 128 bytes.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field `effective_labels` for all of the labels present on the resource.
    /// </summary>
    public TerraformMap<string>? Labels
    {
        get => GetArgument<TerraformMap<string>>("labels");
        set => SetArgument("labels", value);
    }

    /// <summary>
    /// The location for the resource
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetRequiredArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// Name of the `DeliveryPipeline`. Format is `[a-z]([a-z0-9-]{0,61}[a-z0-9])?`.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The project for the resource
    /// </summary>
    public TerraformValue<string> Project
    {
        get => GetArgument<TerraformValue<string>>("project") ?? AsReference("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// When suspended, no new releases or rollouts can be created, but in-progress ones will complete.
    /// </summary>
    public TerraformValue<bool>? Suspended
    {
        get => GetArgument<TerraformValue<bool>>("suspended");
        set => SetArgument("suspended", value);
    }

    /// <summary>
    /// Output only. Information around the state of the Delivery Pipeline.
    /// </summary>
    public TerraformList<TerraformMap<object>> Condition
        => AsReference("condition");

    /// <summary>
    /// Output only. Time at which the pipeline was created.
    /// </summary>
    public TerraformValue<string> CreateTime
        => AsReference("create_time");

    /// <summary>
    /// All of annotations (key/value pairs) present on the resource in GCP, including the annotations configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveAnnotations
        => AsReference("effective_annotations");

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveLabels
        => AsReference("effective_labels");

    /// <summary>
    /// This checksum is computed by the server based on the value of other fields, and may be sent on update and delete requests to ensure the client has an up-to-date value before proceeding.
    /// </summary>
    public TerraformValue<string> Etag
        => AsReference("etag");

    /// <summary>
    /// The combination of labels configured directly on the resource and default labels configured on the provider.
    /// </summary>
    public TerraformMap<string> TerraformLabels
        => AsReference("terraform_labels");

    /// <summary>
    /// Output only. Unique identifier of the `DeliveryPipeline`.
    /// </summary>
    public TerraformValue<string> Uid
        => AsReference("uid");

    /// <summary>
    /// Output only. Most recent time at which the pipeline was updated.
    /// </summary>
    public TerraformValue<string> UpdateTime
        => AsReference("update_time");

    /// <summary>
    /// SerialPipeline block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SerialPipeline block(s) allowed")]
    public TerraformList<GoogleClouddeployDeliveryPipelineSerialPipelineBlock>? SerialPipeline
    {
        get => GetArgument<TerraformList<GoogleClouddeployDeliveryPipelineSerialPipelineBlock>>("serial_pipeline");
        set => SetArgument("serial_pipeline", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleClouddeployDeliveryPipelineTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleClouddeployDeliveryPipelineTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
