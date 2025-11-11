using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for minimum_healthy_hosts in .
/// Nesting mode: list
/// </summary>
public class AwsCodedeployDeploymentConfigMinimumHealthyHostsBlock
{
    /// <summary>
    /// The type attribute.
    /// </summary>
    [TerraformPropertyName("type")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Type { get; set; }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [TerraformPropertyName("value")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? Value { get; set; }

}

/// <summary>
/// Block type for traffic_routing_config in .
/// Nesting mode: list
/// </summary>
public class AwsCodedeployDeploymentConfigTrafficRoutingConfigBlock
{
    /// <summary>
    /// The type attribute.
    /// </summary>
    [TerraformPropertyName("type")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Type { get; set; }

}

/// <summary>
/// Block type for zonal_config in .
/// Nesting mode: list
/// </summary>
public class AwsCodedeployDeploymentConfigZonalConfigBlock
{
    /// <summary>
    /// The first_zone_monitor_duration_in_seconds attribute.
    /// </summary>
    [TerraformPropertyName("first_zone_monitor_duration_in_seconds")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? FirstZoneMonitorDurationInSeconds { get; set; }

    /// <summary>
    /// The monitor_duration_in_seconds attribute.
    /// </summary>
    [TerraformPropertyName("monitor_duration_in_seconds")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? MonitorDurationInSeconds { get; set; }

}

/// <summary>
/// Manages a aws_codedeploy_deployment_config resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsCodedeployDeploymentConfig : TerraformResource
{
    public AwsCodedeployDeploymentConfig(string name) : base("aws_codedeploy_deployment_config", name)
    {
    }

    /// <summary>
    /// The compute_platform attribute.
    /// </summary>
    [TerraformPropertyName("compute_platform")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ComputePlatform { get; set; }

    /// <summary>
    /// The deployment_config_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DeploymentConfigName is required")]
    [TerraformPropertyName("deployment_config_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> DeploymentConfigName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// Block for minimum_healthy_hosts.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MinimumHealthyHosts block(s) allowed")]
    [TerraformPropertyName("minimum_healthy_hosts")]
    public TerraformList<TerraformBlock<AwsCodedeployDeploymentConfigMinimumHealthyHostsBlock>>? MinimumHealthyHosts { get; set; }

    /// <summary>
    /// Block for traffic_routing_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TrafficRoutingConfig block(s) allowed")]
    [TerraformPropertyName("traffic_routing_config")]
    public TerraformList<TerraformBlock<AwsCodedeployDeploymentConfigTrafficRoutingConfigBlock>>? TrafficRoutingConfig { get; set; }

    /// <summary>
    /// Block for zonal_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ZonalConfig block(s) allowed")]
    [TerraformPropertyName("zonal_config")]
    public TerraformList<TerraformBlock<AwsCodedeployDeploymentConfigZonalConfigBlock>>? ZonalConfig { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The deployment_config_id attribute.
    /// </summary>
    [TerraformPropertyName("deployment_config_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DeploymentConfigId => new TerraformReference(this, "deployment_config_id");

}
