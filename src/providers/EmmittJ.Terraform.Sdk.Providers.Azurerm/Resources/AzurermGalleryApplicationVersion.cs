using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for manage_action in AzurermGalleryApplicationVersion.
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
    public required TerraformValue<string> Install
    {
        get => GetArgument<TerraformValue<string>>("install");
        set => SetArgument("install", value);
    }

    /// <summary>
    /// The remove attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RemoveAttribute is required")]
    public required TerraformValue<string> RemoveAttribute
    {
        get => GetArgument<TerraformValue<string>>("remove");
        set => SetArgument("remove", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Block type for source in AzurermGalleryApplicationVersion.
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
    public TerraformValue<string>? DefaultConfigurationLink
    {
        get => GetArgument<TerraformValue<string>>("default_configuration_link");
        set => SetArgument("default_configuration_link", value);
    }

    /// <summary>
    /// The media_link attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MediaLink is required")]
    public required TerraformValue<string> MediaLink
    {
        get => GetArgument<TerraformValue<string>>("media_link");
        set => SetArgument("media_link", value);
    }

}


/// <summary>
/// Block type for target_region in AzurermGalleryApplicationVersion.
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
    public TerraformValue<bool>? ExcludeFromLatest
    {
        get => GetArgument<TerraformValue<bool>>("exclude_from_latest");
        set => SetArgument("exclude_from_latest", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The regional_replica_count attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RegionalReplicaCount is required")]
    public required TerraformValue<double> RegionalReplicaCount
    {
        get => GetArgument<TerraformValue<double>>("regional_replica_count");
        set => SetArgument("regional_replica_count", value);
    }

    /// <summary>
    /// The storage_account_type attribute.
    /// </summary>
    public TerraformValue<string>? StorageAccountType
    {
        get => GetArgument<TerraformValue<string>>("storage_account_type");
        set => SetArgument("storage_account_type", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermGalleryApplicationVersion.
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
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a azurerm_gallery_application_version Terraform resource.
/// Manages a azurerm_gallery_application_version resource.
/// </summary>
public partial class AzurermGalleryApplicationVersion(string name) : TerraformResource("azurerm_gallery_application_version", name)
{
    /// <summary>
    /// The config_file attribute.
    /// </summary>
    public TerraformValue<string>? ConfigFile
    {
        get => GetArgument<TerraformValue<string>>("config_file");
        set => SetArgument("config_file", value);
    }

    /// <summary>
    /// The enable_health_check attribute.
    /// </summary>
    public TerraformValue<bool>? EnableHealthCheck
    {
        get => GetArgument<TerraformValue<bool>>("enable_health_check");
        set => SetArgument("enable_health_check", value);
    }

    /// <summary>
    /// The end_of_life_date attribute.
    /// </summary>
    public TerraformValue<string>? EndOfLifeDate
    {
        get => GetArgument<TerraformValue<string>>("end_of_life_date");
        set => SetArgument("end_of_life_date", value);
    }

    /// <summary>
    /// The exclude_from_latest attribute.
    /// </summary>
    public TerraformValue<bool>? ExcludeFromLatest
    {
        get => GetArgument<TerraformValue<bool>>("exclude_from_latest");
        set => SetArgument("exclude_from_latest", value);
    }

    /// <summary>
    /// The gallery_application_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GalleryApplicationId is required")]
    public required TerraformValue<string> GalleryApplicationId
    {
        get => GetArgument<TerraformValue<string>>("gallery_application_id");
        set => SetArgument("gallery_application_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The package_file attribute.
    /// </summary>
    public TerraformValue<string>? PackageFile
    {
        get => GetArgument<TerraformValue<string>>("package_file");
        set => SetArgument("package_file", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// ManageAction block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ManageAction is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ManageAction block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ManageAction block(s) allowed")]
    public required TerraformList<AzurermGalleryApplicationVersionManageActionBlock> ManageAction
    {
        get => GetRequiredArgument<TerraformList<AzurermGalleryApplicationVersionManageActionBlock>>("manage_action");
        set => SetArgument("manage_action", value);
    }

    /// <summary>
    /// Source block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Source is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Source block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Source block(s) allowed")]
    public required TerraformList<AzurermGalleryApplicationVersionSourceBlock> Source
    {
        get => GetRequiredArgument<TerraformList<AzurermGalleryApplicationVersionSourceBlock>>("source");
        set => SetArgument("source", value);
    }

    /// <summary>
    /// TargetRegion block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetRegion is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 TargetRegion block(s) required")]
    public required TerraformList<AzurermGalleryApplicationVersionTargetRegionBlock> TargetRegion
    {
        get => GetRequiredArgument<TerraformList<AzurermGalleryApplicationVersionTargetRegionBlock>>("target_region");
        set => SetArgument("target_region", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermGalleryApplicationVersionTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermGalleryApplicationVersionTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
