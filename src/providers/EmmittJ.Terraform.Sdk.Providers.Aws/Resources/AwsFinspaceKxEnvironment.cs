using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for custom_dns_configuration in AwsFinspaceKxEnvironment.
/// Nesting mode: list
/// </summary>
public class AwsFinspaceKxEnvironmentCustomDnsConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "custom_dns_configuration";

    /// <summary>
    /// The custom_dns_server_ip attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CustomDnsServerIp is required")]
    public required TerraformValue<string> CustomDnsServerIp
    {
        get => GetRequiredArgument<TerraformValue<string>>("custom_dns_server_ip");
        set => SetArgument("custom_dns_server_ip", value);
    }

    /// <summary>
    /// The custom_dns_server_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CustomDnsServerName is required")]
    public required TerraformValue<string> CustomDnsServerName
    {
        get => GetRequiredArgument<TerraformValue<string>>("custom_dns_server_name");
        set => SetArgument("custom_dns_server_name", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsFinspaceKxEnvironment.
/// Nesting mode: single
/// </summary>
public class AwsFinspaceKxEnvironmentTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Block type for transit_gateway_configuration in AwsFinspaceKxEnvironment.
/// Nesting mode: list
/// </summary>
public class AwsFinspaceKxEnvironmentTransitGatewayConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "transit_gateway_configuration";

    /// <summary>
    /// The routable_cidr_space attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoutableCidrSpace is required")]
    public required TerraformValue<string> RoutableCidrSpace
    {
        get => GetRequiredArgument<TerraformValue<string>>("routable_cidr_space");
        set => SetArgument("routable_cidr_space", value);
    }

    /// <summary>
    /// The transit_gateway_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TransitGatewayId is required")]
    public required TerraformValue<string> TransitGatewayId
    {
        get => GetRequiredArgument<TerraformValue<string>>("transit_gateway_id");
        set => SetArgument("transit_gateway_id", value);
    }

    /// <summary>
    /// AttachmentNetworkAclConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(100, ErrorMessage = "Maximum 100 AttachmentNetworkAclConfiguration block(s) allowed")]
    public TerraformList<AwsFinspaceKxEnvironmentTransitGatewayConfigurationBlockAttachmentNetworkAclConfigurationBlock>? AttachmentNetworkAclConfiguration
    {
        get => GetArgument<TerraformList<AwsFinspaceKxEnvironmentTransitGatewayConfigurationBlockAttachmentNetworkAclConfigurationBlock>>("attachment_network_acl_configuration");
        set => SetArgument("attachment_network_acl_configuration", value);
    }

}

/// <summary>
/// Block type for attachment_network_acl_configuration in AwsFinspaceKxEnvironmentTransitGatewayConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsFinspaceKxEnvironmentTransitGatewayConfigurationBlockAttachmentNetworkAclConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "attachment_network_acl_configuration";

    /// <summary>
    /// The cidr_block attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CidrBlock is required")]
    public required TerraformValue<string> CidrBlock
    {
        get => GetRequiredArgument<TerraformValue<string>>("cidr_block");
        set => SetArgument("cidr_block", value);
    }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Protocol is required")]
    public required TerraformValue<string> Protocol
    {
        get => GetRequiredArgument<TerraformValue<string>>("protocol");
        set => SetArgument("protocol", value);
    }

    /// <summary>
    /// The rule_action attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RuleAction is required")]
    public required TerraformValue<string> RuleAction
    {
        get => GetRequiredArgument<TerraformValue<string>>("rule_action");
        set => SetArgument("rule_action", value);
    }

    /// <summary>
    /// The rule_number attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RuleNumber is required")]
    public required TerraformValue<double> RuleNumber
    {
        get => GetRequiredArgument<TerraformValue<double>>("rule_number");
        set => SetArgument("rule_number", value);
    }

    /// <summary>
    /// IcmpTypeCode block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IcmpTypeCode block(s) allowed")]
    public TerraformList<AwsFinspaceKxEnvironmentTransitGatewayConfigurationBlockAttachmentNetworkAclConfigurationBlockIcmpTypeCodeBlock>? IcmpTypeCode
    {
        get => GetArgument<TerraformList<AwsFinspaceKxEnvironmentTransitGatewayConfigurationBlockAttachmentNetworkAclConfigurationBlockIcmpTypeCodeBlock>>("icmp_type_code");
        set => SetArgument("icmp_type_code", value);
    }

    /// <summary>
    /// PortRange block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PortRange block(s) allowed")]
    public TerraformList<AwsFinspaceKxEnvironmentTransitGatewayConfigurationBlockAttachmentNetworkAclConfigurationBlockPortRangeBlock>? PortRange
    {
        get => GetArgument<TerraformList<AwsFinspaceKxEnvironmentTransitGatewayConfigurationBlockAttachmentNetworkAclConfigurationBlockPortRangeBlock>>("port_range");
        set => SetArgument("port_range", value);
    }

}

/// <summary>
/// Block type for icmp_type_code in AwsFinspaceKxEnvironmentTransitGatewayConfigurationBlockAttachmentNetworkAclConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsFinspaceKxEnvironmentTransitGatewayConfigurationBlockAttachmentNetworkAclConfigurationBlockIcmpTypeCodeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "icmp_type_code";

    /// <summary>
    /// The code attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Code is required")]
    public required TerraformValue<double> Code
    {
        get => GetRequiredArgument<TerraformValue<double>>("code");
        set => SetArgument("code", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<double> Type
    {
        get => GetRequiredArgument<TerraformValue<double>>("type");
        set => SetArgument("type", value);
    }

}

/// <summary>
/// Block type for port_range in AwsFinspaceKxEnvironmentTransitGatewayConfigurationBlockAttachmentNetworkAclConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsFinspaceKxEnvironmentTransitGatewayConfigurationBlockAttachmentNetworkAclConfigurationBlockPortRangeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "port_range";

    /// <summary>
    /// The from attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "From is required")]
    public required TerraformValue<double> From
    {
        get => GetRequiredArgument<TerraformValue<double>>("from");
        set => SetArgument("from", value);
    }

    /// <summary>
    /// The to attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "To is required")]
    public required TerraformValue<double> To
    {
        get => GetRequiredArgument<TerraformValue<double>>("to");
        set => SetArgument("to", value);
    }

}


/// <summary>
/// Represents a aws_finspace_kx_environment Terraform resource.
/// Manages a aws_finspace_kx_environment resource.
/// </summary>
public partial class AwsFinspaceKxEnvironment(string name) : TerraformResource("aws_finspace_kx_environment", name)
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
    /// The kms_key_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KmsKeyId is required")]
    public required TerraformValue<string> KmsKeyId
    {
        get => GetRequiredArgument<TerraformValue<string>>("kms_key_id");
        set => SetArgument("kms_key_id", value);
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? CreateReference("region");
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
        get => GetArgument<TerraformMap<string>>("tags_all") ?? CreateReference("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => CreateReference("arn");

    /// <summary>
    /// The availability_zones attribute.
    /// </summary>
    public TerraformList<string> AvailabilityZones
        => CreateReference("availability_zones");

    /// <summary>
    /// The created_timestamp attribute.
    /// </summary>
    public TerraformValue<string> CreatedTimestamp
        => CreateReference("created_timestamp");

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
        => CreateReference("id");

    /// <summary>
    /// The infrastructure_account_id attribute.
    /// </summary>
    public TerraformValue<string> InfrastructureAccountId
        => CreateReference("infrastructure_account_id");

    /// <summary>
    /// The last_modified_timestamp attribute.
    /// </summary>
    public TerraformValue<string> LastModifiedTimestamp
        => CreateReference("last_modified_timestamp");

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string> Status
        => CreateReference("status");

    /// <summary>
    /// CustomDnsConfiguration block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsFinspaceKxEnvironmentCustomDnsConfigurationBlock>? CustomDnsConfiguration
    {
        get => GetArgument<TerraformList<AwsFinspaceKxEnvironmentCustomDnsConfigurationBlock>>("custom_dns_configuration");
        set => SetArgument("custom_dns_configuration", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsFinspaceKxEnvironmentTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsFinspaceKxEnvironmentTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

    /// <summary>
    /// TransitGatewayConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TransitGatewayConfiguration block(s) allowed")]
    public TerraformList<AwsFinspaceKxEnvironmentTransitGatewayConfigurationBlock>? TransitGatewayConfiguration
    {
        get => GetArgument<TerraformList<AwsFinspaceKxEnvironmentTransitGatewayConfigurationBlock>>("transit_gateway_configuration");
        set => SetArgument("transit_gateway_configuration", value);
    }

}
