using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for dns_config in AwsServiceDiscoveryService.
/// Nesting mode: list
/// </summary>
public class AwsServiceDiscoveryServiceDnsConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "dns_config";

    /// <summary>
    /// The namespace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NamespaceId is required")]
    public required TerraformValue<string> NamespaceId
    {
        get => GetRequiredArgument<TerraformValue<string>>("namespace_id");
        set => SetArgument("namespace_id", value);
    }

    /// <summary>
    /// The routing_policy attribute.
    /// </summary>
    public TerraformValue<string>? RoutingPolicy
    {
        get => GetArgument<TerraformValue<string>>("routing_policy");
        set => SetArgument("routing_policy", value);
    }

    /// <summary>
    /// DnsRecords block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DnsRecords is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 DnsRecords block(s) required")]
    public required TerraformList<AwsServiceDiscoveryServiceDnsConfigBlockDnsRecordsBlock> DnsRecords
    {
        get => GetRequiredArgument<TerraformList<AwsServiceDiscoveryServiceDnsConfigBlockDnsRecordsBlock>>("dns_records");
        set => SetArgument("dns_records", value);
    }

}

/// <summary>
/// Block type for dns_records in AwsServiceDiscoveryServiceDnsConfigBlock.
/// Nesting mode: list
/// </summary>
public class AwsServiceDiscoveryServiceDnsConfigBlockDnsRecordsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "dns_records";

    /// <summary>
    /// The ttl attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Ttl is required")]
    public required TerraformValue<double> Ttl
    {
        get => GetRequiredArgument<TerraformValue<double>>("ttl");
        set => SetArgument("ttl", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => GetRequiredArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

}


/// <summary>
/// Block type for health_check_config in AwsServiceDiscoveryService.
/// Nesting mode: list
/// </summary>
public class AwsServiceDiscoveryServiceHealthCheckConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "health_check_config";

    /// <summary>
    /// The failure_threshold attribute.
    /// </summary>
    public TerraformValue<double>? FailureThreshold
    {
        get => GetArgument<TerraformValue<double>>("failure_threshold");
        set => SetArgument("failure_threshold", value);
    }

    /// <summary>
    /// The resource_path attribute.
    /// </summary>
    public TerraformValue<string>? ResourcePath
    {
        get => GetArgument<TerraformValue<string>>("resource_path");
        set => SetArgument("resource_path", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformValue<string>? Type
    {
        get => GetArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

}


/// <summary>
/// Block type for health_check_custom_config in AwsServiceDiscoveryService.
/// Nesting mode: list
/// </summary>
public class AwsServiceDiscoveryServiceHealthCheckCustomConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "health_check_custom_config";

    /// <summary>
    /// The failure_threshold attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformValue<double>? FailureThreshold
    {
        get => GetArgument<TerraformValue<double>>("failure_threshold");
        set => SetArgument("failure_threshold", value);
    }

}


/// <summary>
/// Represents a aws_service_discovery_service Terraform resource.
/// Manages a aws_service_discovery_service resource.
/// </summary>
public partial class AwsServiceDiscoveryService(string name) : TerraformResource("aws_service_discovery_service", name)
{
    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The force_destroy attribute.
    /// </summary>
    public TerraformValue<bool>? ForceDestroy
    {
        get => GetArgument<TerraformValue<bool>>("force_destroy");
        set => SetArgument("force_destroy", value);
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The namespace_id attribute.
    /// </summary>
    public TerraformValue<string> NamespaceId
    {
        get => GetArgument<TerraformValue<string>>("namespace_id") ?? AsReference("namespace_id");
        set => SetArgument("namespace_id", value);
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
        get => GetArgument<TerraformMap<string>>("tags_all") ?? AsReference("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformValue<string> Type
    {
        get => GetArgument<TerraformValue<string>>("type") ?? AsReference("type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// DnsConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DnsConfig block(s) allowed")]
    public TerraformList<AwsServiceDiscoveryServiceDnsConfigBlock>? DnsConfig
    {
        get => GetArgument<TerraformList<AwsServiceDiscoveryServiceDnsConfigBlock>>("dns_config");
        set => SetArgument("dns_config", value);
    }

    /// <summary>
    /// HealthCheckConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HealthCheckConfig block(s) allowed")]
    public TerraformList<AwsServiceDiscoveryServiceHealthCheckConfigBlock>? HealthCheckConfig
    {
        get => GetArgument<TerraformList<AwsServiceDiscoveryServiceHealthCheckConfigBlock>>("health_check_config");
        set => SetArgument("health_check_config", value);
    }

    /// <summary>
    /// HealthCheckCustomConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HealthCheckCustomConfig block(s) allowed")]
    public TerraformList<AwsServiceDiscoveryServiceHealthCheckCustomConfigBlock>? HealthCheckCustomConfig
    {
        get => GetArgument<TerraformList<AwsServiceDiscoveryServiceHealthCheckCustomConfigBlock>>("health_check_custom_config");
        set => SetArgument("health_check_custom_config", value);
    }

}
