using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermAppServiceSlotVirtualNetworkSwiftConnection.
/// Nesting mode: single
/// </summary>
public class AzurermAppServiceSlotVirtualNetworkSwiftConnectionTimeoutsBlock : TerraformBlock
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
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a azurerm_app_service_slot_virtual_network_swift_connection Terraform resource.
/// Manages a azurerm_app_service_slot_virtual_network_swift_connection resource.
/// </summary>
public partial class AzurermAppServiceSlotVirtualNetworkSwiftConnection(string name) : TerraformResource("azurerm_app_service_slot_virtual_network_swift_connection", name)
{
    /// <summary>
    /// The app_service_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AppServiceId is required")]
    public required TerraformValue<string> AppServiceId
    {
        get => new TerraformReference<string>(this, "app_service_id");
        set => SetArgument("app_service_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The slot_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SlotName is required")]
    public required TerraformValue<string> SlotName
    {
        get => new TerraformReference<string>(this, "slot_name");
        set => SetArgument("slot_name", value);
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetId is required")]
    public required TerraformValue<string> SubnetId
    {
        get => new TerraformReference<string>(this, "subnet_id");
        set => SetArgument("subnet_id", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermAppServiceSlotVirtualNetworkSwiftConnectionTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermAppServiceSlotVirtualNetworkSwiftConnectionTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
