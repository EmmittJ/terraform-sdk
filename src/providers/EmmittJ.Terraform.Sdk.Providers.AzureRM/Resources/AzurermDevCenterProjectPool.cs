using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermDevCenterProjectPoolTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_dev_center_project_pool Terraform resource.
/// Manages a azurerm_dev_center_project_pool resource.
/// </summary>
public partial class AzurermDevCenterProjectPool(string name) : TerraformResource("azurerm_dev_center_project_pool", name)
{
    /// <summary>
    /// The dev_box_definition_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DevBoxDefinitionName is required")]
    public required TerraformValue<string> DevBoxDefinitionName
    {
        get => new TerraformReference<string>(this, "dev_box_definition_name");
        set => SetArgument("dev_box_definition_name", value);
    }

    /// <summary>
    /// The dev_center_attached_network_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DevCenterAttachedNetworkName is required")]
    public required TerraformValue<string> DevCenterAttachedNetworkName
    {
        get => new TerraformReference<string>(this, "dev_center_attached_network_name");
        set => SetArgument("dev_center_attached_network_name", value);
    }

    /// <summary>
    /// The dev_center_project_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DevCenterProjectId is required")]
    public required TerraformValue<string> DevCenterProjectId
    {
        get => new TerraformReference<string>(this, "dev_center_project_id");
        set => SetArgument("dev_center_project_id", value);
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
    /// The local_administrator_enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LocalAdministratorEnabled is required")]
    public required TerraformValue<bool> LocalAdministratorEnabled
    {
        get => new TerraformReference<bool>(this, "local_administrator_enabled");
        set => SetArgument("local_administrator_enabled", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The managed_virtual_network_regions attribute.
    /// </summary>
    public TerraformList<string>? ManagedVirtualNetworkRegions
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "managed_virtual_network_regions").ResolveNodes(ctx));
        set => SetArgument("managed_virtual_network_regions", value);
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
    /// The single_sign_on_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? SingleSignOnEnabled
    {
        get => new TerraformReference<bool>(this, "single_sign_on_enabled");
        set => SetArgument("single_sign_on_enabled", value);
    }

    /// <summary>
    /// The stop_on_disconnect_grace_period_minutes attribute.
    /// </summary>
    public TerraformValue<double>? StopOnDisconnectGracePeriodMinutes
    {
        get => new TerraformReference<double>(this, "stop_on_disconnect_grace_period_minutes");
        set => SetArgument("stop_on_disconnect_grace_period_minutes", value);
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
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermDevCenterProjectPoolTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermDevCenterProjectPoolTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
