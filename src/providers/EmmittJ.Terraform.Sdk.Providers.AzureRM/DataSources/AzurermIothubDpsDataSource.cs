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
public class AzurermIothubDpsDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

}

/// <summary>
/// Retrieves information about a azurerm_iothub_dps.
/// </summary>
public class AzurermIothubDpsDataSource : TerraformDataSource
{
    public AzurermIothubDpsDataSource(string name) : base("azurerm_iothub_dps", name)
    {
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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermIothubDpsDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The allocation_policy attribute.
    /// </summary>
    [TerraformArgument("allocation_policy")]
    public TerraformValue<string> AllocationPolicy
    {
        get => new TerraformReference<string>(this, "allocation_policy");
    }

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
    /// The location attribute.
    /// </summary>
    [TerraformArgument("location")]
    public TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
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
