using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermAppServiceSlotCustomHostnameBindingTimeoutsBlock : TerraformBlock
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

}

/// <summary>
/// Represents a azurerm_app_service_slot_custom_hostname_binding Terraform resource.
/// Manages a azurerm_app_service_slot_custom_hostname_binding resource.
/// </summary>
public partial class AzurermAppServiceSlotCustomHostnameBinding(string name) : TerraformResource("azurerm_app_service_slot_custom_hostname_binding", name)
{
    /// <summary>
    /// The app_service_slot_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AppServiceSlotId is required")]
    public required TerraformValue<string> AppServiceSlotId
    {
        get => new TerraformReference<string>(this, "app_service_slot_id");
        set => SetArgument("app_service_slot_id", value);
    }

    /// <summary>
    /// The hostname attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Hostname is required")]
    public required TerraformValue<string> Hostname
    {
        get => new TerraformReference<string>(this, "hostname");
        set => SetArgument("hostname", value);
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
    /// The ssl_state attribute.
    /// </summary>
    public TerraformValue<string> SslState
    {
        get => new TerraformReference<string>(this, "ssl_state");
        set => SetArgument("ssl_state", value);
    }

    /// <summary>
    /// The thumbprint attribute.
    /// </summary>
    public TerraformValue<string> Thumbprint
    {
        get => new TerraformReference<string>(this, "thumbprint");
        set => SetArgument("thumbprint", value);
    }

    /// <summary>
    /// The virtual_ip attribute.
    /// </summary>
    public TerraformValue<string> VirtualIp
    {
        get => new TerraformReference<string>(this, "virtual_ip");
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermAppServiceSlotCustomHostnameBindingTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermAppServiceSlotCustomHostnameBindingTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
