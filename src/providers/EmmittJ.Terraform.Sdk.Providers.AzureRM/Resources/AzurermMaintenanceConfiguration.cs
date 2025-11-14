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
/// Block type for install_patches in .
/// Nesting mode: list
/// </summary>
public class AzurermMaintenanceConfigurationInstallPatchesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "install_patches";

    /// <summary>
    /// The reboot attribute.
    /// </summary>
    [TerraformArgument("reboot")]
    public TerraformValue<string>? Reboot
    {
        get => new TerraformReference<string>(this, "reboot");
        set => SetArgument("reboot", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermMaintenanceConfigurationTimeoutsBlock : TerraformBlock
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
/// Block type for window in .
/// Nesting mode: list
/// </summary>
public class AzurermMaintenanceConfigurationWindowBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "window";

    /// <summary>
    /// The duration attribute.
    /// </summary>
    [TerraformArgument("duration")]
    public TerraformValue<string>? Duration
    {
        get => new TerraformReference<string>(this, "duration");
        set => SetArgument("duration", value);
    }

    /// <summary>
    /// The expiration_date_time attribute.
    /// </summary>
    [TerraformArgument("expiration_date_time")]
    public TerraformValue<string>? ExpirationDateTime
    {
        get => new TerraformReference<string>(this, "expiration_date_time");
        set => SetArgument("expiration_date_time", value);
    }

    /// <summary>
    /// The recur_every attribute.
    /// </summary>
    [TerraformArgument("recur_every")]
    public TerraformValue<string>? RecurEvery
    {
        get => new TerraformReference<string>(this, "recur_every");
        set => SetArgument("recur_every", value);
    }

    /// <summary>
    /// The start_date_time attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StartDateTime is required")]
    [TerraformArgument("start_date_time")]
    public required TerraformValue<string> StartDateTime
    {
        get => new TerraformReference<string>(this, "start_date_time");
        set => SetArgument("start_date_time", value);
    }

    /// <summary>
    /// The time_zone attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TimeZone is required")]
    [TerraformArgument("time_zone")]
    public required TerraformValue<string> TimeZone
    {
        get => new TerraformReference<string>(this, "time_zone");
        set => SetArgument("time_zone", value);
    }

}

/// <summary>
/// Manages a azurerm_maintenance_configuration resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermMaintenanceConfiguration : TerraformResource
{
    public AzurermMaintenanceConfiguration(string name) : base("azurerm_maintenance_configuration", name)
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
    /// The in_guest_user_patch_mode attribute.
    /// </summary>
    [TerraformArgument("in_guest_user_patch_mode")]
    public TerraformValue<string>? InGuestUserPatchMode
    {
        get => new TerraformReference<string>(this, "in_guest_user_patch_mode");
        set => SetArgument("in_guest_user_patch_mode", value);
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
    /// The properties attribute.
    /// </summary>
    [TerraformArgument("properties")]
    public TerraformMap<string>? Properties
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "properties").ResolveNodes(ctx));
        set => SetArgument("properties", value);
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
    /// The scope attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Scope is required")]
    [TerraformArgument("scope")]
    public required TerraformValue<string> Scope
    {
        get => new TerraformReference<string>(this, "scope");
        set => SetArgument("scope", value);
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
    /// The visibility attribute.
    /// </summary>
    [TerraformArgument("visibility")]
    public TerraformValue<string>? Visibility
    {
        get => new TerraformReference<string>(this, "visibility");
        set => SetArgument("visibility", value);
    }

    /// <summary>
    /// Block for install_patches.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InstallPatches block(s) allowed")]
    [TerraformArgument("install_patches")]
    public TerraformList<AzurermMaintenanceConfigurationInstallPatchesBlock> InstallPatches { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermMaintenanceConfigurationTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// Block for window.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Window block(s) allowed")]
    [TerraformArgument("window")]
    public TerraformList<AzurermMaintenanceConfigurationWindowBlock> Window { get; set; } = new();

}
