using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for install_patches in AzurermMaintenanceConfiguration.
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
    public TerraformValue<string>? Reboot
    {
        get => new TerraformReference<string>(this, "reboot");
        set => SetArgument("reboot", value);
    }

    /// <summary>
    /// Linux block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermMaintenanceConfigurationInstallPatchesBlockLinuxBlock>? Linux
    {
        get => GetArgument<TerraformList<AzurermMaintenanceConfigurationInstallPatchesBlockLinuxBlock>>("linux");
        set => SetArgument("linux", value);
    }

    /// <summary>
    /// Windows block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermMaintenanceConfigurationInstallPatchesBlockWindowsBlock>? Windows
    {
        get => GetArgument<TerraformList<AzurermMaintenanceConfigurationInstallPatchesBlockWindowsBlock>>("windows");
        set => SetArgument("windows", value);
    }

}

/// <summary>
/// Block type for linux in AzurermMaintenanceConfigurationInstallPatchesBlock.
/// Nesting mode: list
/// </summary>
public class AzurermMaintenanceConfigurationInstallPatchesBlockLinuxBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "linux";

    /// <summary>
    /// The classifications_to_include attribute.
    /// </summary>
    public TerraformList<string>? ClassificationsToInclude
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "classifications_to_include").ResolveNodes(ctx));
        set => SetArgument("classifications_to_include", value);
    }

    /// <summary>
    /// The package_names_mask_to_exclude attribute.
    /// </summary>
    public TerraformList<string>? PackageNamesMaskToExclude
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "package_names_mask_to_exclude").ResolveNodes(ctx));
        set => SetArgument("package_names_mask_to_exclude", value);
    }

    /// <summary>
    /// The package_names_mask_to_include attribute.
    /// </summary>
    public TerraformList<string>? PackageNamesMaskToInclude
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "package_names_mask_to_include").ResolveNodes(ctx));
        set => SetArgument("package_names_mask_to_include", value);
    }

}

/// <summary>
/// Block type for windows in AzurermMaintenanceConfigurationInstallPatchesBlock.
/// Nesting mode: list
/// </summary>
public class AzurermMaintenanceConfigurationInstallPatchesBlockWindowsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "windows";

    /// <summary>
    /// The classifications_to_include attribute.
    /// </summary>
    public TerraformList<string>? ClassificationsToInclude
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "classifications_to_include").ResolveNodes(ctx));
        set => SetArgument("classifications_to_include", value);
    }

    /// <summary>
    /// The kb_numbers_to_exclude attribute.
    /// </summary>
    public TerraformList<string>? KbNumbersToExclude
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "kb_numbers_to_exclude").ResolveNodes(ctx));
        set => SetArgument("kb_numbers_to_exclude", value);
    }

    /// <summary>
    /// The kb_numbers_to_include attribute.
    /// </summary>
    public TerraformList<string>? KbNumbersToInclude
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "kb_numbers_to_include").ResolveNodes(ctx));
        set => SetArgument("kb_numbers_to_include", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermMaintenanceConfiguration.
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
/// Block type for window in AzurermMaintenanceConfiguration.
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
    public TerraformValue<string>? Duration
    {
        get => new TerraformReference<string>(this, "duration");
        set => SetArgument("duration", value);
    }

    /// <summary>
    /// The expiration_date_time attribute.
    /// </summary>
    public TerraformValue<string>? ExpirationDateTime
    {
        get => new TerraformReference<string>(this, "expiration_date_time");
        set => SetArgument("expiration_date_time", value);
    }

    /// <summary>
    /// The recur_every attribute.
    /// </summary>
    public TerraformValue<string>? RecurEvery
    {
        get => new TerraformReference<string>(this, "recur_every");
        set => SetArgument("recur_every", value);
    }

    /// <summary>
    /// The start_date_time attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StartDateTime is required")]
    public required TerraformValue<string> StartDateTime
    {
        get => new TerraformReference<string>(this, "start_date_time");
        set => SetArgument("start_date_time", value);
    }

    /// <summary>
    /// The time_zone attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TimeZone is required")]
    public required TerraformValue<string> TimeZone
    {
        get => new TerraformReference<string>(this, "time_zone");
        set => SetArgument("time_zone", value);
    }

}


/// <summary>
/// Represents a azurerm_maintenance_configuration Terraform resource.
/// Manages a azurerm_maintenance_configuration resource.
/// </summary>
public partial class AzurermMaintenanceConfiguration(string name) : TerraformResource("azurerm_maintenance_configuration", name)
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
    /// The in_guest_user_patch_mode attribute.
    /// </summary>
    public TerraformValue<string>? InGuestUserPatchMode
    {
        get => new TerraformReference<string>(this, "in_guest_user_patch_mode");
        set => SetArgument("in_guest_user_patch_mode", value);
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The properties attribute.
    /// </summary>
    public TerraformMap<string>? Properties
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "properties").ResolveNodes(ctx));
        set => SetArgument("properties", value);
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
    /// The scope attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Scope is required")]
    public required TerraformValue<string> Scope
    {
        get => new TerraformReference<string>(this, "scope");
        set => SetArgument("scope", value);
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
    /// The visibility attribute.
    /// </summary>
    public TerraformValue<string>? Visibility
    {
        get => new TerraformReference<string>(this, "visibility");
        set => SetArgument("visibility", value);
    }

    /// <summary>
    /// InstallPatches block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InstallPatches block(s) allowed")]
    public TerraformList<AzurermMaintenanceConfigurationInstallPatchesBlock>? InstallPatches
    {
        get => GetArgument<TerraformList<AzurermMaintenanceConfigurationInstallPatchesBlock>>("install_patches");
        set => SetArgument("install_patches", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermMaintenanceConfigurationTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermMaintenanceConfigurationTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

    /// <summary>
    /// Window block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Window block(s) allowed")]
    public TerraformList<AzurermMaintenanceConfigurationWindowBlock>? Window
    {
        get => GetArgument<TerraformList<AzurermMaintenanceConfigurationWindowBlock>>("window");
        set => SetArgument("window", value);
    }

}
