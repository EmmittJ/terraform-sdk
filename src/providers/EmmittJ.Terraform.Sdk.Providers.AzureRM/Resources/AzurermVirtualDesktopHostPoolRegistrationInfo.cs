using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermVirtualDesktopHostPoolRegistrationInfoTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_virtual_desktop_host_pool_registration_info Terraform resource.
/// Manages a azurerm_virtual_desktop_host_pool_registration_info resource.
/// </summary>
public partial class AzurermVirtualDesktopHostPoolRegistrationInfo(string name) : TerraformResource("azurerm_virtual_desktop_host_pool_registration_info", name)
{
    /// <summary>
    /// The expiration_date attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ExpirationDate is required")]
    public required TerraformValue<string> ExpirationDate
    {
        get => new TerraformReference<string>(this, "expiration_date");
        set => SetArgument("expiration_date", value);
    }

    /// <summary>
    /// The hostpool_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HostpoolId is required")]
    public required TerraformValue<string> HostpoolId
    {
        get => new TerraformReference<string>(this, "hostpool_id");
        set => SetArgument("hostpool_id", value);
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
    /// The token attribute.
    /// </summary>
    public TerraformValue<string> Token
    {
        get => new TerraformReference<string>(this, "token");
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermVirtualDesktopHostPoolRegistrationInfoTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermVirtualDesktopHostPoolRegistrationInfoTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
