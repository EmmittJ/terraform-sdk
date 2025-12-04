using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for minimum_healthy_hosts in AwsCodedeployDeploymentConfig.
/// Nesting mode: list
/// </summary>
public class AwsCodedeployDeploymentConfigMinimumHealthyHostsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "minimum_healthy_hosts";

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformValue<string>? Type
    {
        get => GetArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    public TerraformValue<double>? Value
    {
        get => GetArgument<TerraformValue<double>>("value");
        set => SetArgument("value", value);
    }

}


/// <summary>
/// Block type for traffic_routing_config in AwsCodedeployDeploymentConfig.
/// Nesting mode: list
/// </summary>
public class AwsCodedeployDeploymentConfigTrafficRoutingConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "traffic_routing_config";

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformValue<string>? Type
    {
        get => GetArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// TimeBasedCanary block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TimeBasedCanary block(s) allowed")]
    public TerraformList<AwsCodedeployDeploymentConfigTrafficRoutingConfigBlockTimeBasedCanaryBlock>? TimeBasedCanary
    {
        get => GetArgument<TerraformList<AwsCodedeployDeploymentConfigTrafficRoutingConfigBlockTimeBasedCanaryBlock>>("time_based_canary");
        set => SetArgument("time_based_canary", value);
    }

    /// <summary>
    /// TimeBasedLinear block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TimeBasedLinear block(s) allowed")]
    public TerraformList<AwsCodedeployDeploymentConfigTrafficRoutingConfigBlockTimeBasedLinearBlock>? TimeBasedLinear
    {
        get => GetArgument<TerraformList<AwsCodedeployDeploymentConfigTrafficRoutingConfigBlockTimeBasedLinearBlock>>("time_based_linear");
        set => SetArgument("time_based_linear", value);
    }

}

/// <summary>
/// Block type for time_based_canary in AwsCodedeployDeploymentConfigTrafficRoutingConfigBlock.
/// Nesting mode: list
/// </summary>
public class AwsCodedeployDeploymentConfigTrafficRoutingConfigBlockTimeBasedCanaryBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "time_based_canary";

    /// <summary>
    /// The interval attribute.
    /// </summary>
    public TerraformValue<double>? Interval
    {
        get => GetArgument<TerraformValue<double>>("interval");
        set => SetArgument("interval", value);
    }

    /// <summary>
    /// The percentage attribute.
    /// </summary>
    public TerraformValue<double>? Percentage
    {
        get => GetArgument<TerraformValue<double>>("percentage");
        set => SetArgument("percentage", value);
    }

}

/// <summary>
/// Block type for time_based_linear in AwsCodedeployDeploymentConfigTrafficRoutingConfigBlock.
/// Nesting mode: list
/// </summary>
public class AwsCodedeployDeploymentConfigTrafficRoutingConfigBlockTimeBasedLinearBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "time_based_linear";

    /// <summary>
    /// The interval attribute.
    /// </summary>
    public TerraformValue<double>? Interval
    {
        get => GetArgument<TerraformValue<double>>("interval");
        set => SetArgument("interval", value);
    }

    /// <summary>
    /// The percentage attribute.
    /// </summary>
    public TerraformValue<double>? Percentage
    {
        get => GetArgument<TerraformValue<double>>("percentage");
        set => SetArgument("percentage", value);
    }

}


/// <summary>
/// Block type for zonal_config in AwsCodedeployDeploymentConfig.
/// Nesting mode: list
/// </summary>
public class AwsCodedeployDeploymentConfigZonalConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "zonal_config";

    /// <summary>
    /// The first_zone_monitor_duration_in_seconds attribute.
    /// </summary>
    public TerraformValue<double>? FirstZoneMonitorDurationInSeconds
    {
        get => GetArgument<TerraformValue<double>>("first_zone_monitor_duration_in_seconds");
        set => SetArgument("first_zone_monitor_duration_in_seconds", value);
    }

    /// <summary>
    /// The monitor_duration_in_seconds attribute.
    /// </summary>
    public TerraformValue<double>? MonitorDurationInSeconds
    {
        get => GetArgument<TerraformValue<double>>("monitor_duration_in_seconds");
        set => SetArgument("monitor_duration_in_seconds", value);
    }

    /// <summary>
    /// MinimumHealthyHostsPerZone block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MinimumHealthyHostsPerZone block(s) allowed")]
    public TerraformList<AwsCodedeployDeploymentConfigZonalConfigBlockMinimumHealthyHostsPerZoneBlock>? MinimumHealthyHostsPerZone
    {
        get => GetArgument<TerraformList<AwsCodedeployDeploymentConfigZonalConfigBlockMinimumHealthyHostsPerZoneBlock>>("minimum_healthy_hosts_per_zone");
        set => SetArgument("minimum_healthy_hosts_per_zone", value);
    }

}

/// <summary>
/// Block type for minimum_healthy_hosts_per_zone in AwsCodedeployDeploymentConfigZonalConfigBlock.
/// Nesting mode: list
/// </summary>
public class AwsCodedeployDeploymentConfigZonalConfigBlockMinimumHealthyHostsPerZoneBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "minimum_healthy_hosts_per_zone";

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformValue<string>? Type
    {
        get => GetArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    public TerraformValue<double>? Value
    {
        get => GetArgument<TerraformValue<double>>("value");
        set => SetArgument("value", value);
    }

}


/// <summary>
/// Represents a aws_codedeploy_deployment_config Terraform resource.
/// Manages a aws_codedeploy_deployment_config resource.
/// </summary>
public partial class AwsCodedeployDeploymentConfig(string name) : TerraformResource("aws_codedeploy_deployment_config", name)
{
    /// <summary>
    /// The compute_platform attribute.
    /// </summary>
    public TerraformValue<string>? ComputePlatform
    {
        get => GetArgument<TerraformValue<string>>("compute_platform");
        set => SetArgument("compute_platform", value);
    }

    /// <summary>
    /// The deployment_config_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DeploymentConfigName is required")]
    public required TerraformValue<string> DeploymentConfigName
    {
        get => GetRequiredArgument<TerraformValue<string>>("deployment_config_name");
        set => SetArgument("deployment_config_name", value);
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? AsReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The deployment_config_id attribute.
    /// </summary>
    public TerraformValue<string> DeploymentConfigId
        => AsReference("deployment_config_id");

    /// <summary>
    /// MinimumHealthyHosts block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MinimumHealthyHosts block(s) allowed")]
    public TerraformList<AwsCodedeployDeploymentConfigMinimumHealthyHostsBlock>? MinimumHealthyHosts
    {
        get => GetArgument<TerraformList<AwsCodedeployDeploymentConfigMinimumHealthyHostsBlock>>("minimum_healthy_hosts");
        set => SetArgument("minimum_healthy_hosts", value);
    }

    /// <summary>
    /// TrafficRoutingConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TrafficRoutingConfig block(s) allowed")]
    public TerraformList<AwsCodedeployDeploymentConfigTrafficRoutingConfigBlock>? TrafficRoutingConfig
    {
        get => GetArgument<TerraformList<AwsCodedeployDeploymentConfigTrafficRoutingConfigBlock>>("traffic_routing_config");
        set => SetArgument("traffic_routing_config", value);
    }

    /// <summary>
    /// ZonalConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ZonalConfig block(s) allowed")]
    public TerraformList<AwsCodedeployDeploymentConfigZonalConfigBlock>? ZonalConfig
    {
        get => GetArgument<TerraformList<AwsCodedeployDeploymentConfigZonalConfigBlock>>("zonal_config");
        set => SetArgument("zonal_config", value);
    }

}
