using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for encryption_configuration in .
/// Nesting mode: list
/// </summary>
public partial class AwsApprunnerServiceEncryptionConfigurationBlock : TerraformBlockBase
{
    /// <summary>
    /// The kms_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KmsKey is required")]
    [TerraformProperty("kms_key")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> KmsKey { get; set; }

}

/// <summary>
/// Block type for health_check_configuration in .
/// Nesting mode: list
/// </summary>
public partial class AwsApprunnerServiceHealthCheckConfigurationBlock : TerraformBlockBase
{
    /// <summary>
    /// The healthy_threshold attribute.
    /// </summary>
    [TerraformProperty("healthy_threshold")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? HealthyThreshold { get; set; }

    /// <summary>
    /// The interval attribute.
    /// </summary>
    [TerraformProperty("interval")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? Interval { get; set; }

    /// <summary>
    /// The path attribute.
    /// </summary>
    [TerraformProperty("path")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Path { get; set; }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    [TerraformProperty("protocol")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Protocol { get; set; }

    /// <summary>
    /// The timeout attribute.
    /// </summary>
    [TerraformProperty("timeout")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? Timeout { get; set; }

    /// <summary>
    /// The unhealthy_threshold attribute.
    /// </summary>
    [TerraformProperty("unhealthy_threshold")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? UnhealthyThreshold { get; set; }

}

/// <summary>
/// Block type for instance_configuration in .
/// Nesting mode: list
/// </summary>
public partial class AwsApprunnerServiceInstanceConfigurationBlock : TerraformBlockBase
{
    /// <summary>
    /// The cpu attribute.
    /// </summary>
    [TerraformProperty("cpu")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Cpu { get; set; }

    /// <summary>
    /// The instance_role_arn attribute.
    /// </summary>
    [TerraformProperty("instance_role_arn")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? InstanceRoleArn { get; set; }

    /// <summary>
    /// The memory attribute.
    /// </summary>
    [TerraformProperty("memory")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Memory { get; set; }

}

/// <summary>
/// Block type for network_configuration in .
/// Nesting mode: list
/// </summary>
public partial class AwsApprunnerServiceNetworkConfigurationBlock : TerraformBlockBase
{
    /// <summary>
    /// The ip_address_type attribute.
    /// </summary>
    [TerraformProperty("ip_address_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? IpAddressType { get; set; }

}

/// <summary>
/// Block type for observability_configuration in .
/// Nesting mode: list
/// </summary>
public partial class AwsApprunnerServiceObservabilityConfigurationBlock : TerraformBlockBase
{
    /// <summary>
    /// The observability_configuration_arn attribute.
    /// </summary>
    [TerraformProperty("observability_configuration_arn")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ObservabilityConfigurationArn { get; set; }

    /// <summary>
    /// The observability_enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ObservabilityEnabled is required")]
    [TerraformProperty("observability_enabled")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<bool> ObservabilityEnabled { get; set; }

}

/// <summary>
/// Block type for source_configuration in .
/// Nesting mode: list
/// </summary>
public partial class AwsApprunnerServiceSourceConfigurationBlock : TerraformBlockBase
{
    /// <summary>
    /// The auto_deployments_enabled attribute.
    /// </summary>
    [TerraformProperty("auto_deployments_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? AutoDeploymentsEnabled { get; set; }

}

/// <summary>
/// Manages a aws_apprunner_service resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsApprunnerService : TerraformResource
{
    public AwsApprunnerService(string name) : base("aws_apprunner_service", name)
    {
    }

    /// <summary>
    /// The auto_scaling_configuration_arn attribute.
    /// </summary>
    [TerraformProperty("auto_scaling_configuration_arn")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> AutoScalingConfigurationArn { get; set; }

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
    /// The service_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceName is required")]
    [TerraformProperty("service_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ServiceName { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformMap<string> TagsAll { get; set; }

    /// <summary>
    /// Block for encryption_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EncryptionConfiguration block(s) allowed")]
    [TerraformProperty("encryption_configuration")]
    public partial TerraformList<TerraformBlock<AwsApprunnerServiceEncryptionConfigurationBlock>>? EncryptionConfiguration { get; set; }

    /// <summary>
    /// Block for health_check_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HealthCheckConfiguration block(s) allowed")]
    [TerraformProperty("health_check_configuration")]
    public partial TerraformList<TerraformBlock<AwsApprunnerServiceHealthCheckConfigurationBlock>>? HealthCheckConfiguration { get; set; }

    /// <summary>
    /// Block for instance_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InstanceConfiguration block(s) allowed")]
    [TerraformProperty("instance_configuration")]
    public partial TerraformList<TerraformBlock<AwsApprunnerServiceInstanceConfigurationBlock>>? InstanceConfiguration { get; set; }

    /// <summary>
    /// Block for network_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NetworkConfiguration block(s) allowed")]
    [TerraformProperty("network_configuration")]
    public partial TerraformList<TerraformBlock<AwsApprunnerServiceNetworkConfigurationBlock>>? NetworkConfiguration { get; set; }

    /// <summary>
    /// Block for observability_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ObservabilityConfiguration block(s) allowed")]
    [TerraformProperty("observability_configuration")]
    public partial TerraformList<TerraformBlock<AwsApprunnerServiceObservabilityConfigurationBlock>>? ObservabilityConfiguration { get; set; }

    /// <summary>
    /// Block for source_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceConfiguration is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 SourceConfiguration block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SourceConfiguration block(s) allowed")]
    [TerraformProperty("source_configuration")]
    public partial TerraformList<TerraformBlock<AwsApprunnerServiceSourceConfigurationBlock>>? SourceConfiguration { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The service_id attribute.
    /// </summary>
    [TerraformProperty("service_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ServiceId { get; }

    /// <summary>
    /// The service_url attribute.
    /// </summary>
    [TerraformProperty("service_url")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ServiceUrl { get; }

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformProperty("status")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Status { get; }

}
