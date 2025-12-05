using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for encryption_configuration in AwsApprunnerService.
/// Nesting mode: list
/// </summary>
public class AwsApprunnerServiceEncryptionConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "encryption_configuration";

    /// <summary>
    /// The kms_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KmsKey is required")]
    public required TerraformValue<string> KmsKey
    {
        get => GetRequiredArgument<TerraformValue<string>>("kms_key");
        set => SetArgument("kms_key", value);
    }

}


/// <summary>
/// Block type for health_check_configuration in AwsApprunnerService.
/// Nesting mode: list
/// </summary>
public class AwsApprunnerServiceHealthCheckConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "health_check_configuration";

    /// <summary>
    /// The healthy_threshold attribute.
    /// </summary>
    public TerraformValue<double>? HealthyThreshold
    {
        get => GetArgument<TerraformValue<double>>("healthy_threshold");
        set => SetArgument("healthy_threshold", value);
    }

    /// <summary>
    /// The interval attribute.
    /// </summary>
    public TerraformValue<double>? Interval
    {
        get => GetArgument<TerraformValue<double>>("interval");
        set => SetArgument("interval", value);
    }

    /// <summary>
    /// The path attribute.
    /// </summary>
    public TerraformValue<string>? Path
    {
        get => GetArgument<TerraformValue<string>>("path");
        set => SetArgument("path", value);
    }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    public TerraformValue<string>? Protocol
    {
        get => GetArgument<TerraformValue<string>>("protocol");
        set => SetArgument("protocol", value);
    }

    /// <summary>
    /// The timeout attribute.
    /// </summary>
    public TerraformValue<double>? Timeout
    {
        get => GetArgument<TerraformValue<double>>("timeout");
        set => SetArgument("timeout", value);
    }

    /// <summary>
    /// The unhealthy_threshold attribute.
    /// </summary>
    public TerraformValue<double>? UnhealthyThreshold
    {
        get => GetArgument<TerraformValue<double>>("unhealthy_threshold");
        set => SetArgument("unhealthy_threshold", value);
    }

}


/// <summary>
/// Block type for instance_configuration in AwsApprunnerService.
/// Nesting mode: list
/// </summary>
public class AwsApprunnerServiceInstanceConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "instance_configuration";

    /// <summary>
    /// The cpu attribute.
    /// </summary>
    public TerraformValue<string>? Cpu
    {
        get => GetArgument<TerraformValue<string>>("cpu");
        set => SetArgument("cpu", value);
    }

    /// <summary>
    /// The instance_role_arn attribute.
    /// </summary>
    public TerraformValue<string>? InstanceRoleArn
    {
        get => GetArgument<TerraformValue<string>>("instance_role_arn");
        set => SetArgument("instance_role_arn", value);
    }

    /// <summary>
    /// The memory attribute.
    /// </summary>
    public TerraformValue<string>? Memory
    {
        get => GetArgument<TerraformValue<string>>("memory");
        set => SetArgument("memory", value);
    }

}


/// <summary>
/// Block type for network_configuration in AwsApprunnerService.
/// Nesting mode: list
/// </summary>
public class AwsApprunnerServiceNetworkConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "network_configuration";

    /// <summary>
    /// The ip_address_type attribute.
    /// </summary>
    public TerraformValue<string>? IpAddressType
    {
        get => GetArgument<TerraformValue<string>>("ip_address_type");
        set => SetArgument("ip_address_type", value);
    }

    /// <summary>
    /// EgressConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EgressConfiguration block(s) allowed")]
    public TerraformList<AwsApprunnerServiceNetworkConfigurationBlockEgressConfigurationBlock>? EgressConfiguration
    {
        get => GetArgument<TerraformList<AwsApprunnerServiceNetworkConfigurationBlockEgressConfigurationBlock>>("egress_configuration");
        set => SetArgument("egress_configuration", value);
    }

    /// <summary>
    /// IngressConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IngressConfiguration block(s) allowed")]
    public TerraformList<AwsApprunnerServiceNetworkConfigurationBlockIngressConfigurationBlock>? IngressConfiguration
    {
        get => GetArgument<TerraformList<AwsApprunnerServiceNetworkConfigurationBlockIngressConfigurationBlock>>("ingress_configuration");
        set => SetArgument("ingress_configuration", value);
    }

}

/// <summary>
/// Block type for egress_configuration in AwsApprunnerServiceNetworkConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsApprunnerServiceNetworkConfigurationBlockEgressConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "egress_configuration";

    /// <summary>
    /// The egress_type attribute.
    /// </summary>
    public TerraformValue<string> EgressType
    {
        get => GetArgument<TerraformValue<string>>("egress_type") ?? CreateReference("egress_type");
        set => SetArgument("egress_type", value);
    }

    /// <summary>
    /// The vpc_connector_arn attribute.
    /// </summary>
    public TerraformValue<string>? VpcConnectorArn
    {
        get => GetArgument<TerraformValue<string>>("vpc_connector_arn");
        set => SetArgument("vpc_connector_arn", value);
    }

}

/// <summary>
/// Block type for ingress_configuration in AwsApprunnerServiceNetworkConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsApprunnerServiceNetworkConfigurationBlockIngressConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ingress_configuration";

    /// <summary>
    /// The is_publicly_accessible attribute.
    /// </summary>
    public TerraformValue<bool>? IsPubliclyAccessible
    {
        get => GetArgument<TerraformValue<bool>>("is_publicly_accessible");
        set => SetArgument("is_publicly_accessible", value);
    }

}


/// <summary>
/// Block type for observability_configuration in AwsApprunnerService.
/// Nesting mode: list
/// </summary>
public class AwsApprunnerServiceObservabilityConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "observability_configuration";

    /// <summary>
    /// The observability_configuration_arn attribute.
    /// </summary>
    public TerraformValue<string>? ObservabilityConfigurationArn
    {
        get => GetArgument<TerraformValue<string>>("observability_configuration_arn");
        set => SetArgument("observability_configuration_arn", value);
    }

    /// <summary>
    /// The observability_enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ObservabilityEnabled is required")]
    public required TerraformValue<bool> ObservabilityEnabled
    {
        get => GetRequiredArgument<TerraformValue<bool>>("observability_enabled");
        set => SetArgument("observability_enabled", value);
    }

}


/// <summary>
/// Block type for source_configuration in AwsApprunnerService.
/// Nesting mode: list
/// </summary>
public class AwsApprunnerServiceSourceConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "source_configuration";

    /// <summary>
    /// The auto_deployments_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? AutoDeploymentsEnabled
    {
        get => GetArgument<TerraformValue<bool>>("auto_deployments_enabled");
        set => SetArgument("auto_deployments_enabled", value);
    }

    /// <summary>
    /// AuthenticationConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AuthenticationConfiguration block(s) allowed")]
    public TerraformList<AwsApprunnerServiceSourceConfigurationBlockAuthenticationConfigurationBlock>? AuthenticationConfiguration
    {
        get => GetArgument<TerraformList<AwsApprunnerServiceSourceConfigurationBlockAuthenticationConfigurationBlock>>("authentication_configuration");
        set => SetArgument("authentication_configuration", value);
    }

    /// <summary>
    /// CodeRepository block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CodeRepository block(s) allowed")]
    public TerraformList<AwsApprunnerServiceSourceConfigurationBlockCodeRepositoryBlock>? CodeRepository
    {
        get => GetArgument<TerraformList<AwsApprunnerServiceSourceConfigurationBlockCodeRepositoryBlock>>("code_repository");
        set => SetArgument("code_repository", value);
    }

    /// <summary>
    /// ImageRepository block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ImageRepository block(s) allowed")]
    public TerraformList<AwsApprunnerServiceSourceConfigurationBlockImageRepositoryBlock>? ImageRepository
    {
        get => GetArgument<TerraformList<AwsApprunnerServiceSourceConfigurationBlockImageRepositoryBlock>>("image_repository");
        set => SetArgument("image_repository", value);
    }

}

/// <summary>
/// Block type for authentication_configuration in AwsApprunnerServiceSourceConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsApprunnerServiceSourceConfigurationBlockAuthenticationConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "authentication_configuration";

    /// <summary>
    /// The access_role_arn attribute.
    /// </summary>
    public TerraformValue<string>? AccessRoleArn
    {
        get => GetArgument<TerraformValue<string>>("access_role_arn");
        set => SetArgument("access_role_arn", value);
    }

    /// <summary>
    /// The connection_arn attribute.
    /// </summary>
    public TerraformValue<string>? ConnectionArn
    {
        get => GetArgument<TerraformValue<string>>("connection_arn");
        set => SetArgument("connection_arn", value);
    }

}

/// <summary>
/// Block type for code_repository in AwsApprunnerServiceSourceConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsApprunnerServiceSourceConfigurationBlockCodeRepositoryBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "code_repository";

    /// <summary>
    /// The repository_url attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RepositoryUrl is required")]
    public required TerraformValue<string> RepositoryUrl
    {
        get => GetRequiredArgument<TerraformValue<string>>("repository_url");
        set => SetArgument("repository_url", value);
    }

    /// <summary>
    /// The source_directory attribute.
    /// </summary>
    public TerraformValue<string> SourceDirectory
    {
        get => GetArgument<TerraformValue<string>>("source_directory") ?? CreateReference("source_directory");
        set => SetArgument("source_directory", value);
    }

    /// <summary>
    /// CodeConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CodeConfiguration block(s) allowed")]
    public TerraformList<AwsApprunnerServiceSourceConfigurationBlockCodeRepositoryBlockCodeConfigurationBlock>? CodeConfiguration
    {
        get => GetArgument<TerraformList<AwsApprunnerServiceSourceConfigurationBlockCodeRepositoryBlockCodeConfigurationBlock>>("code_configuration");
        set => SetArgument("code_configuration", value);
    }

    /// <summary>
    /// SourceCodeVersion block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceCodeVersion is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 SourceCodeVersion block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SourceCodeVersion block(s) allowed")]
    public required TerraformList<AwsApprunnerServiceSourceConfigurationBlockCodeRepositoryBlockSourceCodeVersionBlock> SourceCodeVersion
    {
        get => GetRequiredArgument<TerraformList<AwsApprunnerServiceSourceConfigurationBlockCodeRepositoryBlockSourceCodeVersionBlock>>("source_code_version");
        set => SetArgument("source_code_version", value);
    }

}

/// <summary>
/// Block type for code_configuration in AwsApprunnerServiceSourceConfigurationBlockCodeRepositoryBlock.
/// Nesting mode: list
/// </summary>
public class AwsApprunnerServiceSourceConfigurationBlockCodeRepositoryBlockCodeConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "code_configuration";

    /// <summary>
    /// The configuration_source attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConfigurationSource is required")]
    public required TerraformValue<string> ConfigurationSource
    {
        get => GetRequiredArgument<TerraformValue<string>>("configuration_source");
        set => SetArgument("configuration_source", value);
    }

    /// <summary>
    /// CodeConfigurationValues block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CodeConfigurationValues block(s) allowed")]
    public TerraformList<AwsApprunnerServiceSourceConfigurationBlockCodeRepositoryBlockCodeConfigurationBlockCodeConfigurationValuesBlock>? CodeConfigurationValues
    {
        get => GetArgument<TerraformList<AwsApprunnerServiceSourceConfigurationBlockCodeRepositoryBlockCodeConfigurationBlockCodeConfigurationValuesBlock>>("code_configuration_values");
        set => SetArgument("code_configuration_values", value);
    }

}

/// <summary>
/// Block type for code_configuration_values in AwsApprunnerServiceSourceConfigurationBlockCodeRepositoryBlockCodeConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsApprunnerServiceSourceConfigurationBlockCodeRepositoryBlockCodeConfigurationBlockCodeConfigurationValuesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "code_configuration_values";

    /// <summary>
    /// The build_command attribute.
    /// </summary>
    public TerraformValue<string>? BuildCommand
    {
        get => GetArgument<TerraformValue<string>>("build_command");
        set => SetArgument("build_command", value);
    }

    /// <summary>
    /// The port attribute.
    /// </summary>
    public TerraformValue<string>? Port
    {
        get => GetArgument<TerraformValue<string>>("port");
        set => SetArgument("port", value);
    }

    /// <summary>
    /// The runtime attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Runtime is required")]
    public required TerraformValue<string> Runtime
    {
        get => GetRequiredArgument<TerraformValue<string>>("runtime");
        set => SetArgument("runtime", value);
    }

    /// <summary>
    /// The runtime_environment_secrets attribute.
    /// </summary>
    public TerraformMap<string>? RuntimeEnvironmentSecrets
    {
        get => GetArgument<TerraformMap<string>>("runtime_environment_secrets");
        set => SetArgument("runtime_environment_secrets", value);
    }

    /// <summary>
    /// The runtime_environment_variables attribute.
    /// </summary>
    public TerraformMap<string>? RuntimeEnvironmentVariables
    {
        get => GetArgument<TerraformMap<string>>("runtime_environment_variables");
        set => SetArgument("runtime_environment_variables", value);
    }

    /// <summary>
    /// The start_command attribute.
    /// </summary>
    public TerraformValue<string>? StartCommand
    {
        get => GetArgument<TerraformValue<string>>("start_command");
        set => SetArgument("start_command", value);
    }

}

/// <summary>
/// Block type for source_code_version in AwsApprunnerServiceSourceConfigurationBlockCodeRepositoryBlock.
/// Nesting mode: list
/// </summary>
public class AwsApprunnerServiceSourceConfigurationBlockCodeRepositoryBlockSourceCodeVersionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "source_code_version";

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => GetRequiredArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for image_repository in AwsApprunnerServiceSourceConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsApprunnerServiceSourceConfigurationBlockImageRepositoryBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "image_repository";

    /// <summary>
    /// The image_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ImageIdentifier is required")]
    public required TerraformValue<string> ImageIdentifier
    {
        get => GetRequiredArgument<TerraformValue<string>>("image_identifier");
        set => SetArgument("image_identifier", value);
    }

    /// <summary>
    /// The image_repository_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ImageRepositoryType is required")]
    public required TerraformValue<string> ImageRepositoryType
    {
        get => GetRequiredArgument<TerraformValue<string>>("image_repository_type");
        set => SetArgument("image_repository_type", value);
    }

    /// <summary>
    /// ImageConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ImageConfiguration block(s) allowed")]
    public TerraformList<AwsApprunnerServiceSourceConfigurationBlockImageRepositoryBlockImageConfigurationBlock>? ImageConfiguration
    {
        get => GetArgument<TerraformList<AwsApprunnerServiceSourceConfigurationBlockImageRepositoryBlockImageConfigurationBlock>>("image_configuration");
        set => SetArgument("image_configuration", value);
    }

}

/// <summary>
/// Block type for image_configuration in AwsApprunnerServiceSourceConfigurationBlockImageRepositoryBlock.
/// Nesting mode: list
/// </summary>
public class AwsApprunnerServiceSourceConfigurationBlockImageRepositoryBlockImageConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "image_configuration";

    /// <summary>
    /// The port attribute.
    /// </summary>
    public TerraformValue<string>? Port
    {
        get => GetArgument<TerraformValue<string>>("port");
        set => SetArgument("port", value);
    }

    /// <summary>
    /// The runtime_environment_secrets attribute.
    /// </summary>
    public TerraformMap<string>? RuntimeEnvironmentSecrets
    {
        get => GetArgument<TerraformMap<string>>("runtime_environment_secrets");
        set => SetArgument("runtime_environment_secrets", value);
    }

    /// <summary>
    /// The runtime_environment_variables attribute.
    /// </summary>
    public TerraformMap<string>? RuntimeEnvironmentVariables
    {
        get => GetArgument<TerraformMap<string>>("runtime_environment_variables");
        set => SetArgument("runtime_environment_variables", value);
    }

    /// <summary>
    /// The start_command attribute.
    /// </summary>
    public TerraformValue<string>? StartCommand
    {
        get => GetArgument<TerraformValue<string>>("start_command");
        set => SetArgument("start_command", value);
    }

}


/// <summary>
/// Represents a aws_apprunner_service Terraform resource.
/// Manages a aws_apprunner_service resource.
/// </summary>
public partial class AwsApprunnerService(string name) : TerraformResource("aws_apprunner_service", name)
{
    /// <summary>
    /// The auto_scaling_configuration_arn attribute.
    /// </summary>
    public TerraformValue<string> AutoScalingConfigurationArn
    {
        get => GetArgument<TerraformValue<string>>("auto_scaling_configuration_arn") ?? CreateReference("auto_scaling_configuration_arn");
        set => SetArgument("auto_scaling_configuration_arn", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? CreateReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The service_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceName is required")]
    public required TerraformValue<string> ServiceName
    {
        get => GetRequiredArgument<TerraformValue<string>>("service_name");
        set => SetArgument("service_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => GetArgument<TerraformMap<string>>("tags_all") ?? CreateReference("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => CreateReference("arn");

    /// <summary>
    /// The service_id attribute.
    /// </summary>
    public TerraformValue<string> ServiceId
        => CreateReference("service_id");

    /// <summary>
    /// The service_url attribute.
    /// </summary>
    public TerraformValue<string> ServiceUrl
        => CreateReference("service_url");

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string> Status
        => CreateReference("status");

    /// <summary>
    /// EncryptionConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EncryptionConfiguration block(s) allowed")]
    public TerraformList<AwsApprunnerServiceEncryptionConfigurationBlock>? EncryptionConfiguration
    {
        get => GetArgument<TerraformList<AwsApprunnerServiceEncryptionConfigurationBlock>>("encryption_configuration");
        set => SetArgument("encryption_configuration", value);
    }

    /// <summary>
    /// HealthCheckConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HealthCheckConfiguration block(s) allowed")]
    public TerraformList<AwsApprunnerServiceHealthCheckConfigurationBlock>? HealthCheckConfiguration
    {
        get => GetArgument<TerraformList<AwsApprunnerServiceHealthCheckConfigurationBlock>>("health_check_configuration");
        set => SetArgument("health_check_configuration", value);
    }

    /// <summary>
    /// InstanceConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InstanceConfiguration block(s) allowed")]
    public TerraformList<AwsApprunnerServiceInstanceConfigurationBlock>? InstanceConfiguration
    {
        get => GetArgument<TerraformList<AwsApprunnerServiceInstanceConfigurationBlock>>("instance_configuration");
        set => SetArgument("instance_configuration", value);
    }

    /// <summary>
    /// NetworkConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NetworkConfiguration block(s) allowed")]
    public TerraformList<AwsApprunnerServiceNetworkConfigurationBlock>? NetworkConfiguration
    {
        get => GetArgument<TerraformList<AwsApprunnerServiceNetworkConfigurationBlock>>("network_configuration");
        set => SetArgument("network_configuration", value);
    }

    /// <summary>
    /// ObservabilityConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ObservabilityConfiguration block(s) allowed")]
    public TerraformList<AwsApprunnerServiceObservabilityConfigurationBlock>? ObservabilityConfiguration
    {
        get => GetArgument<TerraformList<AwsApprunnerServiceObservabilityConfigurationBlock>>("observability_configuration");
        set => SetArgument("observability_configuration", value);
    }

    /// <summary>
    /// SourceConfiguration block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceConfiguration is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 SourceConfiguration block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SourceConfiguration block(s) allowed")]
    public required TerraformList<AwsApprunnerServiceSourceConfigurationBlock> SourceConfiguration
    {
        get => GetRequiredArgument<TerraformList<AwsApprunnerServiceSourceConfigurationBlock>>("source_configuration");
        set => SetArgument("source_configuration", value);
    }

}
