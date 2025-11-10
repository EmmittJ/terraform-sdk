using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for encryption_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsApprunnerServiceEncryptionConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// The kms_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KmsKey is required")]
    public required TerraformProperty<string> KmsKey
    {
        set => SetProperty("kms_key", value);
    }

}

/// <summary>
/// Block type for health_check_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsApprunnerServiceHealthCheckConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// The healthy_threshold attribute.
    /// </summary>
    public TerraformProperty<double>? HealthyThreshold
    {
        set => SetProperty("healthy_threshold", value);
    }

    /// <summary>
    /// The interval attribute.
    /// </summary>
    public TerraformProperty<double>? Interval
    {
        set => SetProperty("interval", value);
    }

    /// <summary>
    /// The path attribute.
    /// </summary>
    public TerraformProperty<string>? Path
    {
        set => SetProperty("path", value);
    }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    public TerraformProperty<string>? Protocol
    {
        set => SetProperty("protocol", value);
    }

    /// <summary>
    /// The timeout attribute.
    /// </summary>
    public TerraformProperty<double>? Timeout
    {
        set => SetProperty("timeout", value);
    }

    /// <summary>
    /// The unhealthy_threshold attribute.
    /// </summary>
    public TerraformProperty<double>? UnhealthyThreshold
    {
        set => SetProperty("unhealthy_threshold", value);
    }

}

/// <summary>
/// Block type for instance_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsApprunnerServiceInstanceConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// The cpu attribute.
    /// </summary>
    public TerraformProperty<string>? Cpu
    {
        set => SetProperty("cpu", value);
    }

    /// <summary>
    /// The instance_role_arn attribute.
    /// </summary>
    public TerraformProperty<string>? InstanceRoleArn
    {
        set => SetProperty("instance_role_arn", value);
    }

    /// <summary>
    /// The memory attribute.
    /// </summary>
    public TerraformProperty<string>? Memory
    {
        set => SetProperty("memory", value);
    }

}

/// <summary>
/// Block type for network_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsApprunnerServiceNetworkConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// The ip_address_type attribute.
    /// </summary>
    public TerraformProperty<string>? IpAddressType
    {
        set => SetProperty("ip_address_type", value);
    }

}

/// <summary>
/// Block type for observability_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsApprunnerServiceObservabilityConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// The observability_configuration_arn attribute.
    /// </summary>
    public TerraformProperty<string>? ObservabilityConfigurationArn
    {
        set => SetProperty("observability_configuration_arn", value);
    }

    /// <summary>
    /// The observability_enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ObservabilityEnabled is required")]
    public required TerraformProperty<bool> ObservabilityEnabled
    {
        set => SetProperty("observability_enabled", value);
    }

}

/// <summary>
/// Block type for source_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsApprunnerServiceSourceConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// The auto_deployments_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? AutoDeploymentsEnabled
    {
        set => SetProperty("auto_deployments_enabled", value);
    }

}

/// <summary>
/// Manages a aws_apprunner_service resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsApprunnerService : TerraformResource
{
    public AwsApprunnerService(string name) : base("aws_apprunner_service", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("service_id");
        SetOutput("service_url");
        SetOutput("status");
        SetOutput("auto_scaling_configuration_arn");
        SetOutput("id");
        SetOutput("region");
        SetOutput("service_name");
        SetOutput("tags");
        SetOutput("tags_all");
    }

    /// <summary>
    /// The auto_scaling_configuration_arn attribute.
    /// </summary>
    public TerraformProperty<string> AutoScalingConfigurationArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("auto_scaling_configuration_arn");
        set => SetProperty("auto_scaling_configuration_arn", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The service_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceName is required")]
    public required TerraformProperty<string> ServiceName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("service_name");
        set => SetProperty("service_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> TagsAll
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => SetProperty("tags_all", value);
    }

    /// <summary>
    /// Block for encryption_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EncryptionConfiguration block(s) allowed")]
    public List<AwsApprunnerServiceEncryptionConfigurationBlock>? EncryptionConfiguration
    {
        set => SetProperty("encryption_configuration", value);
    }

    /// <summary>
    /// Block for health_check_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HealthCheckConfiguration block(s) allowed")]
    public List<AwsApprunnerServiceHealthCheckConfigurationBlock>? HealthCheckConfiguration
    {
        set => SetProperty("health_check_configuration", value);
    }

    /// <summary>
    /// Block for instance_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InstanceConfiguration block(s) allowed")]
    public List<AwsApprunnerServiceInstanceConfigurationBlock>? InstanceConfiguration
    {
        set => SetProperty("instance_configuration", value);
    }

    /// <summary>
    /// Block for network_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NetworkConfiguration block(s) allowed")]
    public List<AwsApprunnerServiceNetworkConfigurationBlock>? NetworkConfiguration
    {
        set => SetProperty("network_configuration", value);
    }

    /// <summary>
    /// Block for observability_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ObservabilityConfiguration block(s) allowed")]
    public List<AwsApprunnerServiceObservabilityConfigurationBlock>? ObservabilityConfiguration
    {
        set => SetProperty("observability_configuration", value);
    }

    /// <summary>
    /// Block for source_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceConfiguration is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 SourceConfiguration block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SourceConfiguration block(s) allowed")]
    public List<AwsApprunnerServiceSourceConfigurationBlock>? SourceConfiguration
    {
        set => SetProperty("source_configuration", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The service_id attribute.
    /// </summary>
    public TerraformExpression ServiceId => this["service_id"];

    /// <summary>
    /// The service_url attribute.
    /// </summary>
    public TerraformExpression ServiceUrl => this["service_url"];

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformExpression Status => this["status"];

}
