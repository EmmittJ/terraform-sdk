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
/// Block type for ip_filter_rule in .
/// Nesting mode: list
/// </summary>
public class AzurermIothubDpsIpFilterRuleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ip_filter_rule";

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
    /// The ip_mask attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IpMask is required")]
    [TerraformArgument("ip_mask")]
    public required TerraformValue<string> IpMask
    {
        get => new TerraformReference<string>(this, "ip_mask");
        set => SetArgument("ip_mask", value);
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
    /// The target attribute.
    /// </summary>
    [TerraformArgument("target")]
    public TerraformValue<string>? Target
    {
        get => new TerraformReference<string>(this, "target");
        set => SetArgument("target", value);
    }

}

/// <summary>
/// Block type for linked_hub in .
/// Nesting mode: list
/// </summary>
public class AzurermIothubDpsLinkedHubBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "linked_hub";

    /// <summary>
    /// The allocation_weight attribute.
    /// </summary>
    [TerraformArgument("allocation_weight")]
    public TerraformValue<double>? AllocationWeight
    {
        get => new TerraformReference<double>(this, "allocation_weight");
        set => SetArgument("allocation_weight", value);
    }

    /// <summary>
    /// The apply_allocation_policy attribute.
    /// </summary>
    [TerraformArgument("apply_allocation_policy")]
    public TerraformValue<bool>? ApplyAllocationPolicy
    {
        get => new TerraformReference<bool>(this, "apply_allocation_policy");
        set => SetArgument("apply_allocation_policy", value);
    }

    /// <summary>
    /// The connection_string attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConnectionString is required")]
    [TerraformArgument("connection_string")]
    public required TerraformValue<string> ConnectionString
    {
        get => new TerraformReference<string>(this, "connection_string");
        set => SetArgument("connection_string", value);
    }


    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformArgument("location")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

}

/// <summary>
/// Block type for sku in .
/// Nesting mode: list
/// </summary>
public class AzurermIothubDpsSkuBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "sku";

    /// <summary>
    /// The capacity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Capacity is required")]
    [TerraformArgument("capacity")]
    public required TerraformValue<double> Capacity
    {
        get => new TerraformReference<double>(this, "capacity");
        set => SetArgument("capacity", value);
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

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermIothubDpsTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_iothub_dps resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermIothubDps : TerraformResource
{
    public AzurermIothubDps(string name) : base("azurerm_iothub_dps", name)
    {
    }

    /// <summary>
    /// The allocation_policy attribute.
    /// </summary>
    [TerraformArgument("allocation_policy")]
    public TerraformValue<string>? AllocationPolicy
    {
        get => new TerraformReference<string>(this, "allocation_policy");
        set => SetArgument("allocation_policy", value);
    }

    /// <summary>
    /// The data_residency_enabled attribute.
    /// </summary>
    [TerraformArgument("data_residency_enabled")]
    public TerraformValue<bool>? DataResidencyEnabled
    {
        get => new TerraformReference<bool>(this, "data_residency_enabled");
        set => SetArgument("data_residency_enabled", value);
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
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformArgument("location")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
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
    /// The public_network_access_enabled attribute.
    /// </summary>
    [TerraformArgument("public_network_access_enabled")]
    public TerraformValue<bool>? PublicNetworkAccessEnabled
    {
        get => new TerraformReference<bool>(this, "public_network_access_enabled");
        set => SetArgument("public_network_access_enabled", value);
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
    /// The tags attribute.
    /// </summary>
    [TerraformArgument("tags")]
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// Block for ip_filter_rule.
    /// Nesting mode: list
    /// </summary>
    [TerraformArgument("ip_filter_rule")]
    public TerraformList<AzurermIothubDpsIpFilterRuleBlock> IpFilterRule { get; set; } = new();

    /// <summary>
    /// Block for linked_hub.
    /// Nesting mode: list
    /// </summary>
    [TerraformArgument("linked_hub")]
    public TerraformList<AzurermIothubDpsLinkedHubBlock> LinkedHub { get; set; } = new();

    /// <summary>
    /// Block for sku.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Sku is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Sku block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Sku block(s) allowed")]
    [TerraformArgument("sku")]
    public required TerraformList<AzurermIothubDpsSkuBlock> Sku { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermIothubDpsTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The device_provisioning_host_name attribute.
    /// </summary>
    [TerraformArgument("device_provisioning_host_name")]
    public TerraformValue<string> DeviceProvisioningHostName
    {
        get => new TerraformReference<string>(this, "device_provisioning_host_name");
    }

    /// <summary>
    /// The id_scope attribute.
    /// </summary>
    [TerraformArgument("id_scope")]
    public TerraformValue<string> IdScope
    {
        get => new TerraformReference<string>(this, "id_scope");
    }

    /// <summary>
    /// The service_operations_host_name attribute.
    /// </summary>
    [TerraformArgument("service_operations_host_name")]
    public TerraformValue<string> ServiceOperationsHostName
    {
        get => new TerraformReference<string>(this, "service_operations_host_name");
    }

}
