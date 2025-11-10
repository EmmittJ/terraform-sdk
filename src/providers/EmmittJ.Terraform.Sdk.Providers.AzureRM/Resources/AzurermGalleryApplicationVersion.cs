using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for manage_action in .
/// Nesting mode: list
/// </summary>
public class AzurermGalleryApplicationVersionManageActionBlock : TerraformBlock
{
    /// <summary>
    /// The install attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Install is required")]
    public required TerraformProperty<string> Install
    {
        set => SetProperty("install", value);
    }

    /// <summary>
    /// The remove attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Remove is required")]
    public required TerraformProperty<string> Remove
    {
        set => SetProperty("remove", value);
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
/// Block type for source in .
/// Nesting mode: list
/// </summary>
public class AzurermGalleryApplicationVersionSourceBlock : TerraformBlock
{
    /// <summary>
    /// The default_configuration_link attribute.
    /// </summary>
    public TerraformProperty<string>? DefaultConfigurationLink
    {
        set => SetProperty("default_configuration_link", value);
    }

    /// <summary>
    /// The media_link attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MediaLink is required")]
    public required TerraformProperty<string> MediaLink
    {
        set => SetProperty("media_link", value);
    }

}

/// <summary>
/// Block type for target_region in .
/// Nesting mode: list
/// </summary>
public class AzurermGalleryApplicationVersionTargetRegionBlock : TerraformBlock
{
    /// <summary>
    /// The exclude_from_latest attribute.
    /// </summary>
    public TerraformProperty<bool>? ExcludeFromLatest
    {
        set => SetProperty("exclude_from_latest", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The regional_replica_count attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RegionalReplicaCount is required")]
    public required TerraformProperty<double> RegionalReplicaCount
    {
        set => SetProperty("regional_replica_count", value);
    }

    /// <summary>
    /// The storage_account_type attribute.
    /// </summary>
    public TerraformProperty<string>? StorageAccountType
    {
        set => SetProperty("storage_account_type", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermGalleryApplicationVersionTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_gallery_application_version resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermGalleryApplicationVersion : TerraformResource
{
    public AzurermGalleryApplicationVersion(string name) : base("azurerm_gallery_application_version", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("config_file");
        SetOutput("enable_health_check");
        SetOutput("end_of_life_date");
        SetOutput("exclude_from_latest");
        SetOutput("gallery_application_id");
        SetOutput("id");
        SetOutput("location");
        SetOutput("name");
        SetOutput("package_file");
        SetOutput("tags");
    }

    /// <summary>
    /// The config_file attribute.
    /// </summary>
    public TerraformProperty<string> ConfigFile
    {
        get => GetRequiredOutput<TerraformProperty<string>>("config_file");
        set => SetProperty("config_file", value);
    }

    /// <summary>
    /// The enable_health_check attribute.
    /// </summary>
    public TerraformProperty<bool> EnableHealthCheck
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("enable_health_check");
        set => SetProperty("enable_health_check", value);
    }

    /// <summary>
    /// The end_of_life_date attribute.
    /// </summary>
    public TerraformProperty<string> EndOfLifeDate
    {
        get => GetRequiredOutput<TerraformProperty<string>>("end_of_life_date");
        set => SetProperty("end_of_life_date", value);
    }

    /// <summary>
    /// The exclude_from_latest attribute.
    /// </summary>
    public TerraformProperty<bool> ExcludeFromLatest
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("exclude_from_latest");
        set => SetProperty("exclude_from_latest", value);
    }

    /// <summary>
    /// The gallery_application_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GalleryApplicationId is required")]
    public required TerraformProperty<string> GalleryApplicationId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("gallery_application_id");
        set => SetProperty("gallery_application_id", value);
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
    /// The package_file attribute.
    /// </summary>
    public TerraformProperty<string> PackageFile
    {
        get => GetRequiredOutput<TerraformProperty<string>>("package_file");
        set => SetProperty("package_file", value);
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
    /// Block for manage_action.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ManageAction is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ManageAction block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ManageAction block(s) allowed")]
    public List<AzurermGalleryApplicationVersionManageActionBlock>? ManageAction
    {
        set => SetProperty("manage_action", value);
    }

    /// <summary>
    /// Block for source.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Source is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Source block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Source block(s) allowed")]
    public List<AzurermGalleryApplicationVersionSourceBlock>? Source
    {
        set => SetProperty("source", value);
    }

    /// <summary>
    /// Block for target_region.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetRegion is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 TargetRegion block(s) required")]
    public List<AzurermGalleryApplicationVersionTargetRegionBlock>? TargetRegion
    {
        set => SetProperty("target_region", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermGalleryApplicationVersionTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
