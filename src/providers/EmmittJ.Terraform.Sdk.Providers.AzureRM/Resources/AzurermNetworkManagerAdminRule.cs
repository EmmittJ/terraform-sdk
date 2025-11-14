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
/// Block type for destination in .
/// Nesting mode: list
/// </summary>
public class AzurermNetworkManagerAdminRuleDestinationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "destination";

    /// <summary>
    /// The address_prefix attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AddressPrefix is required")]
    [TerraformArgument("address_prefix")]
    public required TerraformValue<string> AddressPrefix
    {
        get => new TerraformReference<string>(this, "address_prefix");
        set => SetArgument("address_prefix", value);
    }

    /// <summary>
    /// The address_prefix_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AddressPrefixType is required")]
    [TerraformArgument("address_prefix_type")]
    public required TerraformValue<string> AddressPrefixType
    {
        get => new TerraformReference<string>(this, "address_prefix_type");
        set => SetArgument("address_prefix_type", value);
    }

}

/// <summary>
/// Block type for source in .
/// Nesting mode: list
/// </summary>
public class AzurermNetworkManagerAdminRuleSourceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "source";

    /// <summary>
    /// The address_prefix attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AddressPrefix is required")]
    [TerraformArgument("address_prefix")]
    public required TerraformValue<string> AddressPrefix
    {
        get => new TerraformReference<string>(this, "address_prefix");
        set => SetArgument("address_prefix", value);
    }

    /// <summary>
    /// The address_prefix_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AddressPrefixType is required")]
    [TerraformArgument("address_prefix_type")]
    public required TerraformValue<string> AddressPrefixType
    {
        get => new TerraformReference<string>(this, "address_prefix_type");
        set => SetArgument("address_prefix_type", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermNetworkManagerAdminRuleTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_network_manager_admin_rule resource.
/// </summary>
public class AzurermNetworkManagerAdminRule : TerraformResource
{
    public AzurermNetworkManagerAdminRule(string name) : base("azurerm_network_manager_admin_rule", name)
    {
    }

    /// <summary>
    /// The action attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Action is required")]
    [TerraformArgument("action")]
    public required TerraformValue<string> Action
    {
        get => new TerraformReference<string>(this, "action");
        set => SetArgument("action", value);
    }

    /// <summary>
    /// The admin_rule_collection_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AdminRuleCollectionId is required")]
    [TerraformArgument("admin_rule_collection_id")]
    public required TerraformValue<string> AdminRuleCollectionId
    {
        get => new TerraformReference<string>(this, "admin_rule_collection_id");
        set => SetArgument("admin_rule_collection_id", value);
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
    /// The destination_port_ranges attribute.
    /// </summary>
    [TerraformArgument("destination_port_ranges")]
    public TerraformList<string>? DestinationPortRanges
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "destination_port_ranges").ResolveNodes(ctx));
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
    /// The source_port_ranges attribute.
    /// </summary>
    [TerraformArgument("source_port_ranges")]
    public TerraformList<string>? SourcePortRanges
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "source_port_ranges").ResolveNodes(ctx));
        set => SetArgument("source_port_ranges", value);
    }

    /// <summary>
    /// Block for destination.
    /// Nesting mode: list
    /// </summary>
    [TerraformArgument("destination")]
    public TerraformList<AzurermNetworkManagerAdminRuleDestinationBlock> Destination { get; set; } = new();

    /// <summary>
    /// Block for source.
    /// Nesting mode: list
    /// </summary>
    [TerraformArgument("source")]
    public TerraformList<AzurermNetworkManagerAdminRuleSourceBlock> Source { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermNetworkManagerAdminRuleTimeoutsBlock Timeouts { get; set; } = new();

}
