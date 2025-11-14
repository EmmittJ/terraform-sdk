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
public class AzurermAppServiceSlotCustomHostnameBindingTimeoutsBlock : TerraformBlock
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

}

/// <summary>
/// Manages a azurerm_app_service_slot_custom_hostname_binding resource.
/// </summary>
public class AzurermAppServiceSlotCustomHostnameBinding : TerraformResource
{
    public AzurermAppServiceSlotCustomHostnameBinding(string name) : base("azurerm_app_service_slot_custom_hostname_binding", name)
    {
    }

    /// <summary>
    /// The app_service_slot_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AppServiceSlotId is required")]
    [TerraformArgument("app_service_slot_id")]
    public required TerraformValue<string> AppServiceSlotId
    {
        get => new TerraformReference<string>(this, "app_service_slot_id");
        set => SetArgument("app_service_slot_id", value);
    }

    /// <summary>
    /// The hostname attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Hostname is required")]
    [TerraformArgument("hostname")]
    public required TerraformValue<string> Hostname
    {
        get => new TerraformReference<string>(this, "hostname");
        set => SetArgument("hostname", value);
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
    /// The ssl_state attribute.
    /// </summary>
    [TerraformArgument("ssl_state")]
    public TerraformValue<string> SslState
    {
        get => new TerraformReference<string>(this, "ssl_state");
        set => SetArgument("ssl_state", value);
    }

    /// <summary>
    /// The thumbprint attribute.
    /// </summary>
    [TerraformArgument("thumbprint")]
    public TerraformValue<string> Thumbprint
    {
        get => new TerraformReference<string>(this, "thumbprint");
        set => SetArgument("thumbprint", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermAppServiceSlotCustomHostnameBindingTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The virtual_ip attribute.
    /// </summary>
    [TerraformArgument("virtual_ip")]
    public TerraformValue<string> VirtualIp
    {
        get => new TerraformReference<string>(this, "virtual_ip");
    }

}
