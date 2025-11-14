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
public class AzurermVirtualDesktopHostPoolRegistrationInfoTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_virtual_desktop_host_pool_registration_info resource.
/// </summary>
public class AzurermVirtualDesktopHostPoolRegistrationInfo : TerraformResource
{
    public AzurermVirtualDesktopHostPoolRegistrationInfo(string name) : base("azurerm_virtual_desktop_host_pool_registration_info", name)
    {
    }

    /// <summary>
    /// The expiration_date attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ExpirationDate is required")]
    [TerraformArgument("expiration_date")]
    public required TerraformValue<string> ExpirationDate
    {
        get => new TerraformReference<string>(this, "expiration_date");
        set => SetArgument("expiration_date", value);
    }

    /// <summary>
    /// The hostpool_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HostpoolId is required")]
    [TerraformArgument("hostpool_id")]
    public required TerraformValue<string> HostpoolId
    {
        get => new TerraformReference<string>(this, "hostpool_id");
        set => SetArgument("hostpool_id", value);
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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermVirtualDesktopHostPoolRegistrationInfoTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The token attribute.
    /// </summary>
    [TerraformArgument("token")]
    public TerraformValue<string> Token
    {
        get => new TerraformReference<string>(this, "token");
    }

}
