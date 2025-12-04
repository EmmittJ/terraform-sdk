using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for filter in GoogleStorageControlOrganizationIntelligenceConfig.
/// Nesting mode: list
/// </summary>
public class GoogleStorageControlOrganizationIntelligenceConfigFilterBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "filter";

    /// <summary>
    /// ExcludedCloudStorageBuckets block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ExcludedCloudStorageBuckets block(s) allowed")]
    public TerraformList<GoogleStorageControlOrganizationIntelligenceConfigFilterBlockExcludedCloudStorageBucketsBlock>? ExcludedCloudStorageBuckets
    {
        get => GetArgument<TerraformList<GoogleStorageControlOrganizationIntelligenceConfigFilterBlockExcludedCloudStorageBucketsBlock>>("excluded_cloud_storage_buckets");
        set => SetArgument("excluded_cloud_storage_buckets", value);
    }

    /// <summary>
    /// ExcludedCloudStorageLocations block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ExcludedCloudStorageLocations block(s) allowed")]
    public TerraformList<GoogleStorageControlOrganizationIntelligenceConfigFilterBlockExcludedCloudStorageLocationsBlock>? ExcludedCloudStorageLocations
    {
        get => GetArgument<TerraformList<GoogleStorageControlOrganizationIntelligenceConfigFilterBlockExcludedCloudStorageLocationsBlock>>("excluded_cloud_storage_locations");
        set => SetArgument("excluded_cloud_storage_locations", value);
    }

    /// <summary>
    /// IncludedCloudStorageBuckets block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IncludedCloudStorageBuckets block(s) allowed")]
    public TerraformList<GoogleStorageControlOrganizationIntelligenceConfigFilterBlockIncludedCloudStorageBucketsBlock>? IncludedCloudStorageBuckets
    {
        get => GetArgument<TerraformList<GoogleStorageControlOrganizationIntelligenceConfigFilterBlockIncludedCloudStorageBucketsBlock>>("included_cloud_storage_buckets");
        set => SetArgument("included_cloud_storage_buckets", value);
    }

    /// <summary>
    /// IncludedCloudStorageLocations block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IncludedCloudStorageLocations block(s) allowed")]
    public TerraformList<GoogleStorageControlOrganizationIntelligenceConfigFilterBlockIncludedCloudStorageLocationsBlock>? IncludedCloudStorageLocations
    {
        get => GetArgument<TerraformList<GoogleStorageControlOrganizationIntelligenceConfigFilterBlockIncludedCloudStorageLocationsBlock>>("included_cloud_storage_locations");
        set => SetArgument("included_cloud_storage_locations", value);
    }

}

/// <summary>
/// Block type for excluded_cloud_storage_buckets in GoogleStorageControlOrganizationIntelligenceConfigFilterBlock.
/// Nesting mode: list
/// </summary>
public class GoogleStorageControlOrganizationIntelligenceConfigFilterBlockExcludedCloudStorageBucketsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "excluded_cloud_storage_buckets";

    /// <summary>
    /// List of bucket id regexes to exclude in the storage intelligence plan.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BucketIdRegexes is required")]
    public TerraformList<string>? BucketIdRegexes
    {
        get => GetArgument<TerraformList<string>>("bucket_id_regexes");
        set => SetArgument("bucket_id_regexes", value);
    }

}

/// <summary>
/// Block type for excluded_cloud_storage_locations in GoogleStorageControlOrganizationIntelligenceConfigFilterBlock.
/// Nesting mode: list
/// </summary>
public class GoogleStorageControlOrganizationIntelligenceConfigFilterBlockExcludedCloudStorageLocationsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "excluded_cloud_storage_locations";

    /// <summary>
    /// List of locations.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Locations is required")]
    public TerraformList<string>? Locations
    {
        get => GetArgument<TerraformList<string>>("locations");
        set => SetArgument("locations", value);
    }

}

/// <summary>
/// Block type for included_cloud_storage_buckets in GoogleStorageControlOrganizationIntelligenceConfigFilterBlock.
/// Nesting mode: list
/// </summary>
public class GoogleStorageControlOrganizationIntelligenceConfigFilterBlockIncludedCloudStorageBucketsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "included_cloud_storage_buckets";

    /// <summary>
    /// List of bucket id regexes to exclude in the storage intelligence plan.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BucketIdRegexes is required")]
    public TerraformList<string>? BucketIdRegexes
    {
        get => GetArgument<TerraformList<string>>("bucket_id_regexes");
        set => SetArgument("bucket_id_regexes", value);
    }

}

/// <summary>
/// Block type for included_cloud_storage_locations in GoogleStorageControlOrganizationIntelligenceConfigFilterBlock.
/// Nesting mode: list
/// </summary>
public class GoogleStorageControlOrganizationIntelligenceConfigFilterBlockIncludedCloudStorageLocationsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "included_cloud_storage_locations";

    /// <summary>
    /// List of locations.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Locations is required")]
    public TerraformList<string>? Locations
    {
        get => GetArgument<TerraformList<string>>("locations");
        set => SetArgument("locations", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleStorageControlOrganizationIntelligenceConfig.
/// Nesting mode: single
/// </summary>
public class GoogleStorageControlOrganizationIntelligenceConfigTimeoutsBlock : TerraformBlock
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
/// Represents a google_storage_control_organization_intelligence_config Terraform resource.
/// Manages a google_storage_control_organization_intelligence_config resource.
/// </summary>
public partial class GoogleStorageControlOrganizationIntelligenceConfig(string name) : TerraformResource("google_storage_control_organization_intelligence_config", name)
{
    /// <summary>
    /// Edition configuration of the Storage Intelligence resource. Valid values are INHERIT, DISABLED, TRIAL and STANDARD.
    /// </summary>
    public TerraformValue<string> EditionConfig
    {
        get => GetArgument<TerraformValue<string>>("edition_config") ?? AsReference("edition_config");
        set => SetArgument("edition_config", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Identifier of the GCP Organization. For GCP org, this field should be organization number.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The Intelligence config that is effective for the resource.
    /// </summary>
    public TerraformList<TerraformMap<object>> EffectiveIntelligenceConfig
        => AsReference("effective_intelligence_config");

    /// <summary>
    /// The trial configuration of the Storage Intelligence resource.
    /// </summary>
    public TerraformList<TerraformMap<object>> TrialConfig
        => AsReference("trial_config");

    /// <summary>
    /// The time at which the Storage Intelligence Config resource is last updated.
    /// </summary>
    public TerraformValue<string> UpdateTime
        => AsReference("update_time");

    /// <summary>
    /// Filter block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Filter block(s) allowed")]
    public TerraformList<GoogleStorageControlOrganizationIntelligenceConfigFilterBlock>? Filter
    {
        get => GetArgument<TerraformList<GoogleStorageControlOrganizationIntelligenceConfigFilterBlock>>("filter");
        set => SetArgument("filter", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleStorageControlOrganizationIntelligenceConfigTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleStorageControlOrganizationIntelligenceConfigTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
