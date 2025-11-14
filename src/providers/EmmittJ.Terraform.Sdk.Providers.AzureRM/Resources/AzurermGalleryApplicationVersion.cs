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
/// Block type for manage_action in .
/// Nesting mode: list
/// </summary>
public class AzurermGalleryApplicationVersionManageActionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "manage_action";

    /// <summary>
    /// The install attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Install is required")]
    [TerraformArgument("install")]
    public required TerraformValue<string> Install
    {
        get => new TerraformReference<string>(this, "install");
        set => SetArgument("install", value);
    }

    /// <summary>
    /// The remove attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Remove is required")]
    [TerraformArgument("remove")]
    public required TerraformValue<string> Remove
    {
        get => new TerraformReference<string>(this, "remove");
        set => SetArgument("remove", value);
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
/// Block type for source in .
/// Nesting mode: list
/// </summary>
public class AzurermGalleryApplicationVersionSourceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "source";

    /// <summary>
    /// The default_configuration_link attribute.
    /// </summary>
    [TerraformArgument("default_configuration_link")]
    public TerraformValue<string>? DefaultConfigurationLink
    {
        get => new TerraformReference<string>(this, "default_configuration_link");
        set => SetArgument("default_configuration_link", value);
    }

    /// <summary>
    /// The media_link attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MediaLink is required")]
    [TerraformArgument("media_link")]
    public required TerraformValue<string> MediaLink
    {
        get => new TerraformReference<string>(this, "media_link");
        set => SetArgument("media_link", value);
    }

}

/// <summary>
/// Block type for target_region in .
/// Nesting mode: list
/// </summary>
public class AzurermGalleryApplicationVersionTargetRegionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "target_region";

    /// <summary>
    /// The exclude_from_latest attribute.
    /// </summary>
    [TerraformArgument("exclude_from_latest")]
    public TerraformValue<bool>? ExcludeFromLatest
    {
        get => new TerraformReference<bool>(this, "exclude_from_latest");
        set => SetArgument("exclude_from_latest", value);
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
    /// The regional_replica_count attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RegionalReplicaCount is required")]
    [TerraformArgument("regional_replica_count")]
    public required TerraformValue<double> RegionalReplicaCount
    {
        get => new TerraformReference<double>(this, "regional_replica_count");
        set => SetArgument("regional_replica_count", value);
    }

    /// <summary>
    /// The storage_account_type attribute.
    /// </summary>
    [TerraformArgument("storage_account_type")]
    public TerraformValue<string>? StorageAccountType
    {
        get => new TerraformReference<string>(this, "storage_account_type");
        set => SetArgument("storage_account_type", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermGalleryApplicationVersionTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_gallery_application_version resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermGalleryApplicationVersion : TerraformResource
{
    public AzurermGalleryApplicationVersion(string name) : base("azurerm_gallery_application_version", name)
    {
    }

    /// <summary>
    /// The config_file attribute.
    /// </summary>
    [TerraformArgument("config_file")]
    public TerraformValue<string>? ConfigFile
    {
        get => new TerraformReference<string>(this, "config_file");
        set => SetArgument("config_file", value);
    }

    /// <summary>
    /// The enable_health_check attribute.
    /// </summary>
    [TerraformArgument("enable_health_check")]
    public TerraformValue<bool>? EnableHealthCheck
    {
        get => new TerraformReference<bool>(this, "enable_health_check");
        set => SetArgument("enable_health_check", value);
    }

    /// <summary>
    /// The end_of_life_date attribute.
    /// </summary>
    [TerraformArgument("end_of_life_date")]
    public TerraformValue<string>? EndOfLifeDate
    {
        get => new TerraformReference<string>(this, "end_of_life_date");
        set => SetArgument("end_of_life_date", value);
    }

    /// <summary>
    /// The exclude_from_latest attribute.
    /// </summary>
    [TerraformArgument("exclude_from_latest")]
    public TerraformValue<bool>? ExcludeFromLatest
    {
        get => new TerraformReference<bool>(this, "exclude_from_latest");
        set => SetArgument("exclude_from_latest", value);
    }

    /// <summary>
    /// The gallery_application_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GalleryApplicationId is required")]
    [TerraformArgument("gallery_application_id")]
    public required TerraformValue<string> GalleryApplicationId
    {
        get => new TerraformReference<string>(this, "gallery_application_id");
        set => SetArgument("gallery_application_id", value);
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
    /// The package_file attribute.
    /// </summary>
    [TerraformArgument("package_file")]
    public TerraformValue<string>? PackageFile
    {
        get => new TerraformReference<string>(this, "package_file");
        set => SetArgument("package_file", value);
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
    /// Block for manage_action.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ManageAction is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ManageAction block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ManageAction block(s) allowed")]
    [TerraformArgument("manage_action")]
    public required TerraformList<AzurermGalleryApplicationVersionManageActionBlock> ManageAction { get; set; } = new();

    /// <summary>
    /// Block for source.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Source is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Source block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Source block(s) allowed")]
    [TerraformArgument("source")]
    public required TerraformList<AzurermGalleryApplicationVersionSourceBlock> Source { get; set; } = new();

    /// <summary>
    /// Block for target_region.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetRegion is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 TargetRegion block(s) required")]
    [TerraformArgument("target_region")]
    public required TerraformList<AzurermGalleryApplicationVersionTargetRegionBlock> TargetRegion { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermGalleryApplicationVersionTimeoutsBlock Timeouts { get; set; } = new();

}
