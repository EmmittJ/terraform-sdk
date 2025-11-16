using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

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
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

}

/// <summary>
/// Represents a azurerm_iothub_dps Terraform data source.
/// Retrieves information about a azurerm_iothub_dps.
/// </summary>
public partial class AzurermIothubDpsDataSource(string name) : TerraformDataSource("azurerm_iothub_dps", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
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
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
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
    /// The allocation_policy attribute.
    /// </summary>
    public TerraformValue<string> AllocationPolicy
    {
        get => new TerraformReference<string>(this, "allocation_policy");
    }

    /// <summary>
    /// The device_provisioning_host_name attribute.
    /// </summary>
    public TerraformValue<string> DeviceProvisioningHostName
    {
        get => new TerraformReference<string>(this, "device_provisioning_host_name");
    }

    /// <summary>
    /// The id_scope attribute.
    /// </summary>
    public TerraformValue<string> IdScope
    {
        get => new TerraformReference<string>(this, "id_scope");
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
    }

    /// <summary>
    /// The service_operations_host_name attribute.
    /// </summary>
    public TerraformValue<string> ServiceOperationsHostName
    {
        get => new TerraformReference<string>(this, "service_operations_host_name");
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermIothubDpsDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermIothubDpsDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
