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
        get => GetProperty<TerraformProperty<string>>("kms_key");
        set => WithProperty("kms_key", value);
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
        get => GetProperty<TerraformProperty<double>>("healthy_threshold");
        set => WithProperty("healthy_threshold", value);
    }

    /// <summary>
    /// The interval attribute.
    /// </summary>
    public TerraformProperty<double>? Interval
    {
        get => GetProperty<TerraformProperty<double>>("interval");
        set => WithProperty("interval", value);
    }

    /// <summary>
    /// The path attribute.
    /// </summary>
    public TerraformProperty<string>? Path
    {
        get => GetProperty<TerraformProperty<string>>("path");
        set => WithProperty("path", value);
    }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    public TerraformProperty<string>? Protocol
    {
        get => GetProperty<TerraformProperty<string>>("protocol");
        set => WithProperty("protocol", value);
    }

    /// <summary>
    /// The timeout attribute.
    /// </summary>
    public TerraformProperty<double>? Timeout
    {
        get => GetProperty<TerraformProperty<double>>("timeout");
        set => WithProperty("timeout", value);
    }

    /// <summary>
    /// The unhealthy_threshold attribute.
    /// </summary>
    public TerraformProperty<double>? UnhealthyThreshold
    {
        get => GetProperty<TerraformProperty<double>>("unhealthy_threshold");
        set => WithProperty("unhealthy_threshold", value);
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
        get => GetProperty<TerraformProperty<string>>("cpu");
        set => WithProperty("cpu", value);
    }

    /// <summary>
    /// The instance_role_arn attribute.
    /// </summary>
    public TerraformProperty<string>? InstanceRoleArn
    {
        get => GetProperty<TerraformProperty<string>>("instance_role_arn");
        set => WithProperty("instance_role_arn", value);
    }

    /// <summary>
    /// The memory attribute.
    /// </summary>
    public TerraformProperty<string>? Memory
    {
        get => GetProperty<TerraformProperty<string>>("memory");
        set => WithProperty("memory", value);
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
        get => GetProperty<TerraformProperty<string>>("ip_address_type");
        set => WithProperty("ip_address_type", value);
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
        get => GetProperty<TerraformProperty<string>>("observability_configuration_arn");
        set => WithProperty("observability_configuration_arn", value);
    }

    /// <summary>
    /// The observability_enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ObservabilityEnabled is required")]
    public required TerraformProperty<bool> ObservabilityEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("observability_enabled");
        set => WithProperty("observability_enabled", value);
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
        get => GetProperty<TerraformProperty<bool>>("auto_deployments_enabled");
        set => WithProperty("auto_deployments_enabled", value);
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
        this.DeclareOutput("arn");
        this.DeclareOutput("service_id");
        this.DeclareOutput("service_url");
        this.DeclareOutput("status");
    }

    /// <summary>
    /// The auto_scaling_configuration_arn attribute.
    /// </summary>
    public TerraformProperty<string>? AutoScalingConfigurationArn
    {
        get => GetProperty<TerraformProperty<string>>("auto_scaling_configuration_arn");
        set => this.WithProperty("auto_scaling_configuration_arn", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The service_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceName is required")]
    public required TerraformProperty<string> ServiceName
    {
        get => GetProperty<TerraformProperty<string>>("service_name");
        set => this.WithProperty("service_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? TagsAll
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// Block for encryption_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EncryptionConfiguration block(s) allowed")]
    public List<AwsApprunnerServiceEncryptionConfigurationBlock>? EncryptionConfiguration
    {
        get => GetProperty<List<AwsApprunnerServiceEncryptionConfigurationBlock>>("encryption_configuration");
        set => this.WithProperty("encryption_configuration", value);
    }

    /// <summary>
    /// Block for health_check_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HealthCheckConfiguration block(s) allowed")]
    public List<AwsApprunnerServiceHealthCheckConfigurationBlock>? HealthCheckConfiguration
    {
        get => GetProperty<List<AwsApprunnerServiceHealthCheckConfigurationBlock>>("health_check_configuration");
        set => this.WithProperty("health_check_configuration", value);
    }

    /// <summary>
    /// Block for instance_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InstanceConfiguration block(s) allowed")]
    public List<AwsApprunnerServiceInstanceConfigurationBlock>? InstanceConfiguration
    {
        get => GetProperty<List<AwsApprunnerServiceInstanceConfigurationBlock>>("instance_configuration");
        set => this.WithProperty("instance_configuration", value);
    }

    /// <summary>
    /// Block for network_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NetworkConfiguration block(s) allowed")]
    public List<AwsApprunnerServiceNetworkConfigurationBlock>? NetworkConfiguration
    {
        get => GetProperty<List<AwsApprunnerServiceNetworkConfigurationBlock>>("network_configuration");
        set => this.WithProperty("network_configuration", value);
    }

    /// <summary>
    /// Block for observability_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ObservabilityConfiguration block(s) allowed")]
    public List<AwsApprunnerServiceObservabilityConfigurationBlock>? ObservabilityConfiguration
    {
        get => GetProperty<List<AwsApprunnerServiceObservabilityConfigurationBlock>>("observability_configuration");
        set => this.WithProperty("observability_configuration", value);
    }

    /// <summary>
    /// Block for source_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 SourceConfiguration block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SourceConfiguration block(s) allowed")]
    public List<AwsApprunnerServiceSourceConfigurationBlock>? SourceConfiguration
    {
        get => GetProperty<List<AwsApprunnerServiceSourceConfigurationBlock>>("source_configuration");
        set => this.WithProperty("source_configuration", value);
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
