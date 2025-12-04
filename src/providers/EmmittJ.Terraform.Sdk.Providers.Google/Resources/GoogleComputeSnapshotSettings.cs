using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for storage_location in GoogleComputeSnapshotSettings.
/// Nesting mode: list
/// </summary>
public class GoogleComputeSnapshotSettingsStorageLocationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "storage_location";

    /// <summary>
    /// The chosen location policy Possible values: [&amp;quot;NEAREST_MULTI_REGION&amp;quot;, &amp;quot;LOCAL_REGION&amp;quot;, &amp;quot;SPECIFIC_LOCATIONS&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Policy is required")]
    public required TerraformValue<string> Policy
    {
        get => GetArgument<TerraformValue<string>>("policy");
        set => SetArgument("policy", value);
    }

    /// <summary>
    /// Locations block (nesting mode: set).
    /// </summary>
    public TerraformSet<GoogleComputeSnapshotSettingsStorageLocationBlockLocationsBlock>? Locations
    {
        get => GetArgument<TerraformSet<GoogleComputeSnapshotSettingsStorageLocationBlockLocationsBlock>>("locations");
        set => SetArgument("locations", value);
    }

}

/// <summary>
/// Block type for locations in GoogleComputeSnapshotSettingsStorageLocationBlock.
/// Nesting mode: set
/// </summary>
public class GoogleComputeSnapshotSettingsStorageLocationBlockLocationsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "locations";

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
    /// Name of the location. It should be one of the Cloud Storage buckets.
    /// Only one location can be specified. (should match location)
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleComputeSnapshotSettings.
/// Nesting mode: single
/// </summary>
public class GoogleComputeSnapshotSettingsTimeoutsBlock : TerraformBlock
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
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a google_compute_snapshot_settings Terraform resource.
/// Manages a google_compute_snapshot_settings resource.
/// </summary>
public partial class GoogleComputeSnapshotSettings(string name) : TerraformResource("google_compute_snapshot_settings", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string>? Project
    {
        get => GetArgument<TerraformValue<string>>("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// StorageLocation block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageLocation is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 StorageLocation block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StorageLocation block(s) allowed")]
    public required TerraformList<GoogleComputeSnapshotSettingsStorageLocationBlock> StorageLocation
    {
        get => GetRequiredArgument<TerraformList<GoogleComputeSnapshotSettingsStorageLocationBlock>>("storage_location");
        set => SetArgument("storage_location", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleComputeSnapshotSettingsTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleComputeSnapshotSettingsTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
