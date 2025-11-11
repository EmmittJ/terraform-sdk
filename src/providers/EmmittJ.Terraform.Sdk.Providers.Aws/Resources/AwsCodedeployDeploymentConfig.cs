using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for minimum_healthy_hosts in .
/// Nesting mode: list
/// </summary>
public partial class AwsCodedeployDeploymentConfigMinimumHealthyHostsBlock : TerraformBlockBase
{
    /// <summary>
    /// The type attribute.
    /// </summary>
    [TerraformProperty("type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Type { get; set; }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [TerraformProperty("value")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? Value { get; set; }

}

/// <summary>
/// Block type for traffic_routing_config in .
/// Nesting mode: list
/// </summary>
public partial class AwsCodedeployDeploymentConfigTrafficRoutingConfigBlock : TerraformBlockBase
{
    /// <summary>
    /// The type attribute.
    /// </summary>
    [TerraformProperty("type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Type { get; set; }

}

/// <summary>
/// Block type for zonal_config in .
/// Nesting mode: list
/// </summary>
public partial class AwsCodedeployDeploymentConfigZonalConfigBlock : TerraformBlockBase
{
    /// <summary>
    /// The first_zone_monitor_duration_in_seconds attribute.
    /// </summary>
    [TerraformProperty("first_zone_monitor_duration_in_seconds")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? FirstZoneMonitorDurationInSeconds { get; set; }

    /// <summary>
    /// The monitor_duration_in_seconds attribute.
    /// </summary>
    [TerraformProperty("monitor_duration_in_seconds")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? MonitorDurationInSeconds { get; set; }

}

/// <summary>
/// Manages a aws_codedeploy_deployment_config resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsCodedeployDeploymentConfig : TerraformResource
{
    public AwsCodedeployDeploymentConfig(string name) : base("aws_codedeploy_deployment_config", name)
    {
    }

    /// <summary>
    /// The compute_platform attribute.
    /// </summary>
    [TerraformProperty("compute_platform")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ComputePlatform { get; set; }

    /// <summary>
    /// The deployment_config_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DeploymentConfigName is required")]
    [TerraformProperty("deployment_config_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DeploymentConfigName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// Block for minimum_healthy_hosts.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MinimumHealthyHosts block(s) allowed")]
    [TerraformProperty("minimum_healthy_hosts")]
    public partial TerraformList<TerraformBlock<AwsCodedeployDeploymentConfigMinimumHealthyHostsBlock>>? MinimumHealthyHosts { get; set; }

    /// <summary>
    /// Block for traffic_routing_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TrafficRoutingConfig block(s) allowed")]
    [TerraformProperty("traffic_routing_config")]
    public partial TerraformList<TerraformBlock<AwsCodedeployDeploymentConfigTrafficRoutingConfigBlock>>? TrafficRoutingConfig { get; set; }

    /// <summary>
    /// Block for zonal_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ZonalConfig block(s) allowed")]
    [TerraformProperty("zonal_config")]
    public partial TerraformList<TerraformBlock<AwsCodedeployDeploymentConfigZonalConfigBlock>>? ZonalConfig { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The deployment_config_id attribute.
    /// </summary>
    [TerraformProperty("deployment_config_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DeploymentConfigId { get; }

}
