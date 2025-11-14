using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

// Resources, Data Sources, Ephemeral Resources, Blocks: Getter ALWAYS returns a reference
// This is the key to natural Terraform syntax
// When you access rg.Name, you get azurerm_resource_group.rg.name (a reference)
// The value that was SET is only used during serialization

// Providers: Getter returns stored value
// Providers are not referenced in HCL
// Use required getter if property is required or non-nullable

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermNetworkSecurityRuleTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformArgument("create")]
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformArgument("delete")]
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformArgument("update")]
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}

/// <summary>
/// Manages a azurerm_network_security_rule resource.
/// </summary>
public class AzurermNetworkSecurityRule : TerraformResource
{
    public AzurermNetworkSecurityRule(string name) : base("azurerm_network_security_rule", name)
    {
    }

    /// <summary>
    /// The access attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Access is required")]
    [TerraformArgument("access")]
    public required TerraformValue<string> Access
    {
        get => new TerraformReference<string>(this, "access");
        set => SetArgument("access", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformArgument("description")]
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The destination_address_prefix attribute.
    /// </summary>
    [TerraformArgument("destination_address_prefix")]
    public TerraformValue<string>? DestinationAddressPrefix
    {
        get => new TerraformReference<string>(this, "destination_address_prefix");
        set => SetArgument("destination_address_prefix", value);
    }

    /// <summary>
    /// The destination_address_prefixes attribute.
    /// </summary>
    [TerraformArgument("destination_address_prefixes")]
    public TerraformSet<string>? DestinationAddressPrefixes
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "destination_address_prefixes").ResolveNodes(ctx));
        set => SetArgument("destination_address_prefixes", value);
    }

    /// <summary>
    /// The destination_application_security_group_ids attribute.
    /// </summary>
    [TerraformArgument("destination_application_security_group_ids")]
    public TerraformSet<string>? DestinationApplicationSecurityGroupIds
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "destination_application_security_group_ids").ResolveNodes(ctx));
        set => SetArgument("destination_application_security_group_ids", value);
    }

    /// <summary>
    /// The destination_port_range attribute.
    /// </summary>
    [TerraformArgument("destination_port_range")]
    public TerraformValue<string>? DestinationPortRange
    {
        get => new TerraformReference<string>(this, "destination_port_range");
        set => SetArgument("destination_port_range", value);
    }

    /// <summary>
    /// The destination_port_ranges attribute.
    /// </summary>
    [TerraformArgument("destination_port_ranges")]
    public TerraformSet<string>? DestinationPortRanges
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "destination_port_ranges").ResolveNodes(ctx));
        set => SetArgument("destination_port_ranges", value);
    }

    /// <summary>
    /// The direction attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Direction is required")]
    [TerraformArgument("direction")]
    public required TerraformValue<string> Direction
    {
        get => new TerraformReference<string>(this, "direction");
        set => SetArgument("direction", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformArgument("id")]
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The network_security_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetworkSecurityGroupName is required")]
    [TerraformArgument("network_security_group_name")]
    public required TerraformValue<string> NetworkSecurityGroupName
    {
        get => new TerraformReference<string>(this, "network_security_group_name");
        set => SetArgument("network_security_group_name", value);
    }

    /// <summary>
    /// The priority attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Priority is required")]
    [TerraformArgument("priority")]
    public required TerraformValue<double> Priority
    {
        get => new TerraformReference<double>(this, "priority");
        set => SetArgument("priority", value);
    }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Protocol is required")]
    [TerraformArgument("protocol")]
    public required TerraformValue<string> Protocol
    {
        get => new TerraformReference<string>(this, "protocol");
        set => SetArgument("protocol", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformArgument("resource_group_name")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The source_address_prefix attribute.
    /// </summary>
    [TerraformArgument("source_address_prefix")]
    public TerraformValue<string>? SourceAddressPrefix
    {
        get => new TerraformReference<string>(this, "source_address_prefix");
        set => SetArgument("source_address_prefix", value);
    }

    /// <summary>
    /// The source_address_prefixes attribute.
    /// </summary>
    [TerraformArgument("source_address_prefixes")]
    public TerraformSet<string>? SourceAddressPrefixes
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "source_address_prefixes").ResolveNodes(ctx));
        set => SetArgument("source_address_prefixes", value);
    }

    /// <summary>
    /// The source_application_security_group_ids attribute.
    /// </summary>
    [TerraformArgument("source_application_security_group_ids")]
    public TerraformSet<string>? SourceApplicationSecurityGroupIds
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "source_application_security_group_ids").ResolveNodes(ctx));
        set => SetArgument("source_application_security_group_ids", value);
    }

    /// <summary>
    /// The source_port_range attribute.
    /// </summary>
    [TerraformArgument("source_port_range")]
    public TerraformValue<string>? SourcePortRange
    {
        get => new TerraformReference<string>(this, "source_port_range");
        set => SetArgument("source_port_range", value);
    }

    /// <summary>
    /// The source_port_ranges attribute.
    /// </summary>
    [TerraformArgument("source_port_ranges")]
    public TerraformSet<string>? SourcePortRanges
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "source_port_ranges").ResolveNodes(ctx));
        set => SetArgument("source_port_ranges", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermNetworkSecurityRuleTimeoutsBlock Timeouts { get; set; } = new();

}
