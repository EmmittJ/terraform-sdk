using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for install_patches in .
/// Nesting mode: list
/// </summary>
public class AzurermMaintenanceConfigurationInstallPatchesBlock : TerraformBlock
{
    /// <summary>
    /// The reboot attribute.
    /// </summary>
    public TerraformProperty<string>? Reboot
    {
        get => GetProperty<TerraformProperty<string>>("reboot");
        set => WithProperty("reboot", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermMaintenanceConfigurationTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Block type for window in .
/// Nesting mode: list
/// </summary>
public class AzurermMaintenanceConfigurationWindowBlock : TerraformBlock
{
    /// <summary>
    /// The duration attribute.
    /// </summary>
    public TerraformProperty<string>? Duration
    {
        get => GetProperty<TerraformProperty<string>>("duration");
        set => WithProperty("duration", value);
    }

    /// <summary>
    /// The expiration_date_time attribute.
    /// </summary>
    public TerraformProperty<string>? ExpirationDateTime
    {
        get => GetProperty<TerraformProperty<string>>("expiration_date_time");
        set => WithProperty("expiration_date_time", value);
    }

    /// <summary>
    /// The recur_every attribute.
    /// </summary>
    public TerraformProperty<string>? RecurEvery
    {
        get => GetProperty<TerraformProperty<string>>("recur_every");
        set => WithProperty("recur_every", value);
    }

    /// <summary>
    /// The start_date_time attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StartDateTime is required")]
    public required TerraformProperty<string> StartDateTime
    {
        get => GetProperty<TerraformProperty<string>>("start_date_time");
        set => WithProperty("start_date_time", value);
    }

    /// <summary>
    /// The time_zone attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TimeZone is required")]
    public required TerraformProperty<string> TimeZone
    {
        get => GetProperty<TerraformProperty<string>>("time_zone");
        set => WithProperty("time_zone", value);
    }

}

/// <summary>
/// Manages a azurerm_maintenance_configuration resource.
/// </summary>
public class AzurermMaintenanceConfiguration : TerraformResource
{
    public AzurermMaintenanceConfiguration(string name) : base("azurerm_maintenance_configuration", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The in_guest_user_patch_mode attribute.
    /// </summary>
    public TerraformProperty<string>? InGuestUserPatchMode
    {
        get => GetProperty<TerraformProperty<string>>("in_guest_user_patch_mode");
        set => this.WithProperty("in_guest_user_patch_mode", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The properties attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Properties
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("properties");
        set => this.WithProperty("properties", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The scope attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Scope is required")]
    public required TerraformProperty<string> Scope
    {
        get => GetProperty<TerraformProperty<string>>("scope");
        set => this.WithProperty("scope", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The visibility attribute.
    /// </summary>
    public TerraformProperty<string>? Visibility
    {
        get => GetProperty<TerraformProperty<string>>("visibility");
        set => this.WithProperty("visibility", value);
    }

    /// <summary>
    /// Block for install_patches.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InstallPatches block(s) allowed")]
    public List<AzurermMaintenanceConfigurationInstallPatchesBlock>? InstallPatches
    {
        get => GetProperty<List<AzurermMaintenanceConfigurationInstallPatchesBlock>>("install_patches");
        set => this.WithProperty("install_patches", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermMaintenanceConfigurationTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermMaintenanceConfigurationTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// Block for window.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Window block(s) allowed")]
    public List<AzurermMaintenanceConfigurationWindowBlock>? Window
    {
        get => GetProperty<List<AzurermMaintenanceConfigurationWindowBlock>>("window");
        set => this.WithProperty("window", value);
    }

}
