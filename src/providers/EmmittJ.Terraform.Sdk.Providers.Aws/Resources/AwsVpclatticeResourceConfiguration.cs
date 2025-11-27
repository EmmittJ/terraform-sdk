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
        get => new TerraformReference<string>(this, "arn");
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
        get => new TerraformReference<string>(this, "domain_name");
        set => SetArgument("domain_name", value);
    }

    /// <summary>
    /// The ip_address_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IpAddressType is required")]
    public required TerraformValue<string> IpAddressType
    {
        get => new TerraformReference<string>(this, "ip_address_type");
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
        get => new TerraformReference<string>(this, "ip_address");
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
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours). Setting a timeout for a Delete operation is only applicable if changes are saved into state before the destroy operation occurs.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
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
        get => new TerraformReference<bool>(this, "allow_association_to_shareable_service_network");
        set => SetArgument("allow_association_to_shareable_service_network", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The port_ranges attribute.
    /// </summary>
    public TerraformSet<string> PortRanges
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "port_ranges").ResolveNodes(ctx));
        set => SetArgument("port_ranges", value);
    }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    public TerraformValue<string> Protocol
    {
        get => new TerraformReference<string>(this, "protocol");
        set => SetArgument("protocol", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The resource_configuration_group_id attribute.
    /// </summary>
    public TerraformValue<string>? ResourceConfigurationGroupId
    {
        get => new TerraformReference<string>(this, "resource_configuration_group_id");
        set => SetArgument("resource_configuration_group_id", value);
    }

    /// <summary>
    /// The resource_gateway_identifier attribute.
    /// </summary>
    public TerraformValue<string> ResourceGatewayIdentifier
    {
        get => new TerraformReference<string>(this, "resource_gateway_identifier");
        set => SetArgument("resource_gateway_identifier", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags_all").ResolveNodes(ctx));
    }

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
