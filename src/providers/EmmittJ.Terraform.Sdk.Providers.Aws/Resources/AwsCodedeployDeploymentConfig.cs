using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for minimum_healthy_hosts in .
/// Nesting mode: list
/// </summary>
public class AwsCodedeployDeploymentConfigMinimumHealthyHostsBlock : ITerraformBlock
{
    /// <summary>
    /// The type attribute.
    /// </summary>
    [TerraformPropertyName("type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Type { get; set; }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [TerraformPropertyName("value")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? Value { get; set; }

}

/// <summary>
/// Block type for traffic_routing_config in .
/// Nesting mode: list
/// </summary>
public class AwsCodedeployDeploymentConfigTrafficRoutingConfigBlock : ITerraformBlock
{
    /// <summary>
    /// The type attribute.
    /// </summary>
    [TerraformPropertyName("type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Type { get; set; }

}

/// <summary>
/// Block type for zonal_config in .
/// Nesting mode: list
/// </summary>
public class AwsCodedeployDeploymentConfigZonalConfigBlock : ITerraformBlock
{
    /// <summary>
    /// The first_zone_monitor_duration_in_seconds attribute.
    /// </summary>
    [TerraformPropertyName("first_zone_monitor_duration_in_seconds")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? FirstZoneMonitorDurationInSeconds { get; set; }

    /// <summary>
    /// The monitor_duration_in_seconds attribute.
    /// </summary>
    [TerraformPropertyName("monitor_duration_in_seconds")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? MonitorDurationInSeconds { get; set; }

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
    public TerraformProperty<TerraformProperty<string>>? ComputePlatform { get; set; }

    /// <summary>
    /// The deployment_config_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DeploymentConfigName is required")]
    [TerraformPropertyName("deployment_config_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> DeploymentConfigName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// Block for minimum_healthy_hosts.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MinimumHealthyHosts block(s) allowed")]
    [TerraformPropertyName("minimum_healthy_hosts")]
    public TerraformList<TerraformBlock<AwsCodedeployDeploymentConfigMinimumHealthyHostsBlock>>? MinimumHealthyHosts { get; set; } = new();

    /// <summary>
    /// Block for traffic_routing_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TrafficRoutingConfig block(s) allowed")]
    [TerraformPropertyName("traffic_routing_config")]
    public TerraformList<TerraformBlock<AwsCodedeployDeploymentConfigTrafficRoutingConfigBlock>>? TrafficRoutingConfig { get; set; } = new();

    /// <summary>
    /// Block for zonal_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ZonalConfig block(s) allowed")]
    [TerraformPropertyName("zonal_config")]
    public TerraformList<TerraformBlock<AwsCodedeployDeploymentConfigZonalConfigBlock>>? ZonalConfig { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The deployment_config_id attribute.
    /// </summary>
    [TerraformPropertyName("deployment_config_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DeploymentConfigId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "deployment_config_id");

}
