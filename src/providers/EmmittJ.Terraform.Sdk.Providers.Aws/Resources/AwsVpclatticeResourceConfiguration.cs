using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for resource_configuration_definition in AwsVpclatticeResourceConfiguration.
/// Nesting mode: list
/// </summary>
public class AwsVpclatticeResourceConfigurationResourceConfigurationDefinitionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "resource_configuration_definition";

    /// <summary>
    /// ArnResource block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsVpclatticeResourceConfigurationResourceConfigurationDefinitionBlockArnResourceBlock>? ArnResource
    {
        get => GetArgument<TerraformList<AwsVpclatticeResourceConfigurationResourceConfigurationDefinitionBlockArnResourceBlock>>("arn_resource");
        set => SetArgument("arn_resource", value);
    }

    /// <summary>
    /// DnsResource block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsVpclatticeResourceConfigurationResourceConfigurationDefinitionBlockDnsResourceBlock>? DnsResource
    {
        get => GetArgument<TerraformList<AwsVpclatticeResourceConfigurationResourceConfigurationDefinitionBlockDnsResourceBlock>>("dns_resource");
        set => SetArgument("dns_resource", value);
    }

    /// <summary>
    /// IpResource block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsVpclatticeResourceConfigurationResourceConfigurationDefinitionBlockIpResourceBlock>? IpResource
    {
        get => GetArgument<TerraformList<AwsVpclatticeResourceConfigurationResourceConfigurationDefinitionBlockIpResourceBlock>>("ip_resource");
        set => SetArgument("ip_resource", value);
    }

}

/// <summary>
/// Block type for arn_resource in AwsVpclatticeResourceConfigurationResourceConfigurationDefinitionBlock.
/// Nesting mode: list
/// </summary>
public class AwsVpclatticeResourceConfigurationResourceConfigurationDefinitionBlockArnResourceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "arn_resource";

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Arn is required")]
    public required TerraformValue<string> Arn
    {
        get => GetRequiredArgument<TerraformValue<string>>("arn");
        set => SetArgument("arn", value);
    }

}

/// <summary>
/// Block type for dns_resource in AwsVpclatticeResourceConfigurationResourceConfigurationDefinitionBlock.
/// Nesting mode: list
/// </summary>
public class AwsVpclatticeResourceConfigurationResourceConfigurationDefinitionBlockDnsResourceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "dns_resource";

    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainName is required")]
    public required TerraformValue<string> DomainName
    {
        get => GetRequiredArgument<TerraformValue<string>>("domain_name");
        set => SetArgument("domain_name", value);
    }

    /// <summary>
    /// The ip_address_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IpAddressType is required")]
    public required TerraformValue<string> IpAddressType
    {
        get => GetRequiredArgument<TerraformValue<string>>("ip_address_type");
        set => SetArgument("ip_address_type", value);
    }

}

/// <summary>
/// Block type for ip_resource in AwsVpclatticeResourceConfigurationResourceConfigurationDefinitionBlock.
/// Nesting mode: list
/// </summary>
public class AwsVpclatticeResourceConfigurationResourceConfigurationDefinitionBlockIpResourceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ip_resource";

    /// <summary>
    /// The ip_address attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IpAddress is required")]
    public required TerraformValue<string> IpAddress
    {
        get => GetRequiredArgument<TerraformValue<string>>("ip_address");
        set => SetArgument("ip_address", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsVpclatticeResourceConfiguration.
/// Nesting mode: single
/// </summary>
public class AwsVpclatticeResourceConfigurationTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours). Setting a timeout for a Delete operation is only applicable if changes are saved into state before the destroy operation occurs.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a aws_vpclattice_resource_configuration Terraform resource.
/// Manages a aws_vpclattice_resource_configuration resource.
/// </summary>
public partial class AwsVpclatticeResourceConfiguration(string name) : TerraformResource("aws_vpclattice_resource_configuration", name)
{
    /// <summary>
    /// The allow_association_to_shareable_service_network attribute.
    /// </summary>
    public TerraformValue<bool> AllowAssociationToShareableServiceNetwork
    {
        get => GetArgument<TerraformValue<bool>>("allow_association_to_shareable_service_network") ?? AsReference("allow_association_to_shareable_service_network");
        set => SetArgument("allow_association_to_shareable_service_network", value);
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
    /// The port_ranges attribute.
    /// </summary>
    public TerraformSet<string> PortRanges
    {
        get => GetArgument<TerraformSet<string>>("port_ranges") ?? AsReference("port_ranges");
        set => SetArgument("port_ranges", value);
    }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    public TerraformValue<string> Protocol
    {
        get => GetArgument<TerraformValue<string>>("protocol") ?? AsReference("protocol");
        set => SetArgument("protocol", value);
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
    /// The resource_configuration_group_id attribute.
    /// </summary>
    public TerraformValue<string>? ResourceConfigurationGroupId
    {
        get => GetArgument<TerraformValue<string>>("resource_configuration_group_id");
        set => SetArgument("resource_configuration_group_id", value);
    }

    /// <summary>
    /// The resource_gateway_identifier attribute.
    /// </summary>
    public TerraformValue<string> ResourceGatewayIdentifier
    {
        get => GetArgument<TerraformValue<string>>("resource_gateway_identifier") ?? AsReference("resource_gateway_identifier");
        set => SetArgument("resource_gateway_identifier", value);
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
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
        => AsReference("id");

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
        => AsReference("tags_all");

    /// <summary>
    /// ResourceConfigurationDefinition block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsVpclatticeResourceConfigurationResourceConfigurationDefinitionBlock>? ResourceConfigurationDefinition
    {
        get => GetArgument<TerraformList<AwsVpclatticeResourceConfigurationResourceConfigurationDefinitionBlock>>("resource_configuration_definition");
        set => SetArgument("resource_configuration_definition", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsVpclatticeResourceConfigurationTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsVpclatticeResourceConfigurationTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
