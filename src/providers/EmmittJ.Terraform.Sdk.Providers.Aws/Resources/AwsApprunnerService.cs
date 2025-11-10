using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for encryption_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsApprunnerServiceEncryptionConfigurationBlock : ITerraformBlock
{
    /// <summary>
    /// The kms_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KmsKey is required")]
    [TerraformPropertyName("kms_key")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> KmsKey { get; set; }

}

/// <summary>
/// Block type for health_check_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsApprunnerServiceHealthCheckConfigurationBlock : ITerraformBlock
{
    /// <summary>
    /// The healthy_threshold attribute.
    /// </summary>
    [TerraformPropertyName("healthy_threshold")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? HealthyThreshold { get; set; }

    /// <summary>
    /// The interval attribute.
    /// </summary>
    [TerraformPropertyName("interval")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? Interval { get; set; }

    /// <summary>
    /// The path attribute.
    /// </summary>
    [TerraformPropertyName("path")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Path { get; set; }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    [TerraformPropertyName("protocol")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Protocol { get; set; }

    /// <summary>
    /// The timeout attribute.
    /// </summary>
    [TerraformPropertyName("timeout")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? Timeout { get; set; }

    /// <summary>
    /// The unhealthy_threshold attribute.
    /// </summary>
    [TerraformPropertyName("unhealthy_threshold")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? UnhealthyThreshold { get; set; }

}

/// <summary>
/// Block type for instance_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsApprunnerServiceInstanceConfigurationBlock : ITerraformBlock
{
    /// <summary>
    /// The cpu attribute.
    /// </summary>
    [TerraformPropertyName("cpu")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Cpu { get; set; }

    /// <summary>
    /// The instance_role_arn attribute.
    /// </summary>
    [TerraformPropertyName("instance_role_arn")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? InstanceRoleArn { get; set; }

    /// <summary>
    /// The memory attribute.
    /// </summary>
    [TerraformPropertyName("memory")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Memory { get; set; }

}

/// <summary>
/// Block type for network_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsApprunnerServiceNetworkConfigurationBlock : ITerraformBlock
{
    /// <summary>
    /// The ip_address_type attribute.
    /// </summary>
    [TerraformPropertyName("ip_address_type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? IpAddressType { get; set; }

}

/// <summary>
/// Block type for observability_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsApprunnerServiceObservabilityConfigurationBlock : ITerraformBlock
{
    /// <summary>
    /// The observability_configuration_arn attribute.
    /// </summary>
    [TerraformPropertyName("observability_configuration_arn")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ObservabilityConfigurationArn { get; set; }

    /// <summary>
    /// The observability_enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ObservabilityEnabled is required")]
    [TerraformPropertyName("observability_enabled")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<bool>> ObservabilityEnabled { get; set; }

}

/// <summary>
/// Block type for source_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsApprunnerServiceSourceConfigurationBlock : ITerraformBlock
{
    /// <summary>
    /// The auto_deployments_enabled attribute.
    /// </summary>
    [TerraformPropertyName("auto_deployments_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? AutoDeploymentsEnabled { get; set; }

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
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> AutoScalingConfigurationArn { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "auto_scaling_configuration_arn");

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
    /// The service_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceName is required")]
    [TerraformPropertyName("service_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ServiceName { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TagsAll { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags_all");

    /// <summary>
    /// Block for encryption_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EncryptionConfiguration block(s) allowed")]
    [TerraformPropertyName("encryption_configuration")]
    public TerraformList<TerraformBlock<AwsApprunnerServiceEncryptionConfigurationBlock>>? EncryptionConfiguration { get; set; } = new();

    /// <summary>
    /// Block for health_check_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HealthCheckConfiguration block(s) allowed")]
    [TerraformPropertyName("health_check_configuration")]
    public TerraformList<TerraformBlock<AwsApprunnerServiceHealthCheckConfigurationBlock>>? HealthCheckConfiguration { get; set; } = new();

    /// <summary>
    /// Block for instance_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InstanceConfiguration block(s) allowed")]
    [TerraformPropertyName("instance_configuration")]
    public TerraformList<TerraformBlock<AwsApprunnerServiceInstanceConfigurationBlock>>? InstanceConfiguration { get; set; } = new();

    /// <summary>
    /// Block for network_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NetworkConfiguration block(s) allowed")]
    [TerraformPropertyName("network_configuration")]
    public TerraformList<TerraformBlock<AwsApprunnerServiceNetworkConfigurationBlock>>? NetworkConfiguration { get; set; } = new();

    /// <summary>
    /// Block for observability_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ObservabilityConfiguration block(s) allowed")]
    [TerraformPropertyName("observability_configuration")]
    public TerraformList<TerraformBlock<AwsApprunnerServiceObservabilityConfigurationBlock>>? ObservabilityConfiguration { get; set; } = new();

    /// <summary>
    /// Block for source_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceConfiguration is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 SourceConfiguration block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SourceConfiguration block(s) allowed")]
    [TerraformPropertyName("source_configuration")]
    public TerraformList<TerraformBlock<AwsApprunnerServiceSourceConfigurationBlock>>? SourceConfiguration { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The service_id attribute.
    /// </summary>
    [TerraformPropertyName("service_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ServiceId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "service_id");

    /// <summary>
    /// The service_url attribute.
    /// </summary>
    [TerraformPropertyName("service_url")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ServiceUrl => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "service_url");

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformPropertyName("status")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Status => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "status");

}
