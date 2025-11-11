using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for encryption_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsApprunnerServiceEncryptionConfigurationBlock
{
    /// <summary>
    /// The kms_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KmsKey is required")]
    [TerraformPropertyName("kms_key")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> KmsKey { get; set; }

}

/// <summary>
/// Block type for health_check_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsApprunnerServiceHealthCheckConfigurationBlock
{
    /// <summary>
    /// The healthy_threshold attribute.
    /// </summary>
    [TerraformPropertyName("healthy_threshold")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? HealthyThreshold { get; set; }

    /// <summary>
    /// The interval attribute.
    /// </summary>
    [TerraformPropertyName("interval")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? Interval { get; set; }

    /// <summary>
    /// The path attribute.
    /// </summary>
    [TerraformPropertyName("path")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Path { get; set; }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    [TerraformPropertyName("protocol")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Protocol { get; set; }

    /// <summary>
    /// The timeout attribute.
    /// </summary>
    [TerraformPropertyName("timeout")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? Timeout { get; set; }

    /// <summary>
    /// The unhealthy_threshold attribute.
    /// </summary>
    [TerraformPropertyName("unhealthy_threshold")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? UnhealthyThreshold { get; set; }

}

/// <summary>
/// Block type for instance_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsApprunnerServiceInstanceConfigurationBlock
{
    /// <summary>
    /// The cpu attribute.
    /// </summary>
    [TerraformPropertyName("cpu")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Cpu { get; set; }

    /// <summary>
    /// The instance_role_arn attribute.
    /// </summary>
    [TerraformPropertyName("instance_role_arn")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? InstanceRoleArn { get; set; }

    /// <summary>
    /// The memory attribute.
    /// </summary>
    [TerraformPropertyName("memory")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Memory { get; set; }

}

/// <summary>
/// Block type for network_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsApprunnerServiceNetworkConfigurationBlock
{
    /// <summary>
    /// The ip_address_type attribute.
    /// </summary>
    [TerraformPropertyName("ip_address_type")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? IpAddressType { get; set; }

}

/// <summary>
/// Block type for observability_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsApprunnerServiceObservabilityConfigurationBlock
{
    /// <summary>
    /// The observability_configuration_arn attribute.
    /// </summary>
    [TerraformPropertyName("observability_configuration_arn")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ObservabilityConfigurationArn { get; set; }

    /// <summary>
    /// The observability_enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ObservabilityEnabled is required")]
    [TerraformPropertyName("observability_enabled")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<bool> ObservabilityEnabled { get; set; }

}

/// <summary>
/// Block type for source_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsApprunnerServiceSourceConfigurationBlock
{
    /// <summary>
    /// The auto_deployments_enabled attribute.
    /// </summary>
    [TerraformPropertyName("auto_deployments_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? AutoDeploymentsEnabled { get; set; }

}

/// <summary>
/// Manages a aws_apprunner_service resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsApprunnerService : TerraformResource
{
    public AwsApprunnerService(string name) : base("aws_apprunner_service", name)
    {
    }

    /// <summary>
    /// The auto_scaling_configuration_arn attribute.
    /// </summary>
    [TerraformPropertyName("auto_scaling_configuration_arn")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> AutoScalingConfigurationArn { get; set; } = default!;

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
    /// The service_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceName is required")]
    [TerraformPropertyName("service_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ServiceName { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformMap<string> TagsAll { get; set; } = default!;

    /// <summary>
    /// Block for encryption_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EncryptionConfiguration block(s) allowed")]
    [TerraformPropertyName("encryption_configuration")]
    public TerraformList<TerraformBlock<AwsApprunnerServiceEncryptionConfigurationBlock>>? EncryptionConfiguration { get; set; }

    /// <summary>
    /// Block for health_check_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HealthCheckConfiguration block(s) allowed")]
    [TerraformPropertyName("health_check_configuration")]
    public TerraformList<TerraformBlock<AwsApprunnerServiceHealthCheckConfigurationBlock>>? HealthCheckConfiguration { get; set; }

    /// <summary>
    /// Block for instance_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InstanceConfiguration block(s) allowed")]
    [TerraformPropertyName("instance_configuration")]
    public TerraformList<TerraformBlock<AwsApprunnerServiceInstanceConfigurationBlock>>? InstanceConfiguration { get; set; }

    /// <summary>
    /// Block for network_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NetworkConfiguration block(s) allowed")]
    [TerraformPropertyName("network_configuration")]
    public TerraformList<TerraformBlock<AwsApprunnerServiceNetworkConfigurationBlock>>? NetworkConfiguration { get; set; }

    /// <summary>
    /// Block for observability_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ObservabilityConfiguration block(s) allowed")]
    [TerraformPropertyName("observability_configuration")]
    public TerraformList<TerraformBlock<AwsApprunnerServiceObservabilityConfigurationBlock>>? ObservabilityConfiguration { get; set; }

    /// <summary>
    /// Block for source_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceConfiguration is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 SourceConfiguration block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SourceConfiguration block(s) allowed")]
    [TerraformPropertyName("source_configuration")]
    public TerraformList<TerraformBlock<AwsApprunnerServiceSourceConfigurationBlock>>? SourceConfiguration { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The service_id attribute.
    /// </summary>
    [TerraformPropertyName("service_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ServiceId => new TerraformReference(this, "service_id");

    /// <summary>
    /// The service_url attribute.
    /// </summary>
    [TerraformPropertyName("service_url")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ServiceUrl => new TerraformReference(this, "service_url");

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformPropertyName("status")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Status => new TerraformReference(this, "status");

}
