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
        set => SetProperty("reboot", value);
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
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
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
        set => SetProperty("duration", value);
    }

    /// <summary>
    /// The expiration_date_time attribute.
    /// </summary>
    public TerraformProperty<string>? ExpirationDateTime
    {
        set => SetProperty("expiration_date_time", value);
    }

    /// <summary>
    /// The recur_every attribute.
    /// </summary>
    public TerraformProperty<string>? RecurEvery
    {
        set => SetProperty("recur_every", value);
    }

    /// <summary>
    /// The start_date_time attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StartDateTime is required")]
    public required TerraformProperty<string> StartDateTime
    {
        set => SetProperty("start_date_time", value);
    }

    /// <summary>
    /// The time_zone attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TimeZone is required")]
    public required TerraformProperty<string> TimeZone
    {
        set => SetProperty("time_zone", value);
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
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("id");
        SetOutput("in_guest_user_patch_mode");
        SetOutput("location");
        SetOutput("name");
        SetOutput("properties");
        SetOutput("resource_group_name");
        SetOutput("scope");
        SetOutput("tags");
        SetOutput("visibility");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The in_guest_user_patch_mode attribute.
    /// </summary>
    public TerraformProperty<string> InGuestUserPatchMode
    {
        get => GetRequiredOutput<TerraformProperty<string>>("in_guest_user_patch_mode");
        set => SetProperty("in_guest_user_patch_mode", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The properties attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Properties
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("properties");
        set => SetProperty("properties", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("resource_group_name");
        set => SetProperty("resource_group_name", value);
    }

    /// <summary>
    /// The scope attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Scope is required")]
    public required TerraformProperty<string> Scope
    {
        get => GetRequiredOutput<TerraformProperty<string>>("scope");
        set => SetProperty("scope", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The visibility attribute.
    /// </summary>
    public TerraformProperty<string> Visibility
    {
        get => GetRequiredOutput<TerraformProperty<string>>("visibility");
        set => SetProperty("visibility", value);
    }

    /// <summary>
    /// Block for install_patches.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InstallPatches block(s) allowed")]
    public List<AzurermMaintenanceConfigurationInstallPatchesBlock>? InstallPatches
    {
        set => SetProperty("install_patches", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermMaintenanceConfigurationTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// Block for window.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Window block(s) allowed")]
    public List<AzurermMaintenanceConfigurationWindowBlock>? Window
    {
        set => SetProperty("window", value);
    }

}
