using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_neptune_engine_version.
/// </summary>
public class AwsNeptuneEngineVersionDataSource : TerraformDataSource
{
    public AwsNeptuneEngineVersionDataSource(string name) : base("aws_neptune_engine_version", name)
    {
    }

    /// <summary>
    /// The default_only attribute.
    /// </summary>
    [TerraformPropertyName("default_only")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? DefaultOnly { get; set; }

    /// <summary>
    /// The engine attribute.
    /// </summary>
    [TerraformPropertyName("engine")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Engine { get; set; }

    /// <summary>
    /// The has_major_target attribute.
    /// </summary>
    [TerraformPropertyName("has_major_target")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? HasMajorTarget { get; set; }

    /// <summary>
    /// The has_minor_target attribute.
    /// </summary>
    [TerraformPropertyName("has_minor_target")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? HasMinorTarget { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The latest attribute.
    /// </summary>
    [TerraformPropertyName("latest")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? Latest { get; set; }

    /// <summary>
    /// The parameter_group_family attribute.
    /// </summary>
    [TerraformPropertyName("parameter_group_family")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> ParameterGroupFamily { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "parameter_group_family");

    /// <summary>
    /// The preferred_major_targets attribute.
    /// </summary>
    [TerraformPropertyName("preferred_major_targets")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? PreferredMajorTargets { get; set; }

    /// <summary>
    /// The preferred_upgrade_targets attribute.
    /// </summary>
    [TerraformPropertyName("preferred_upgrade_targets")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? PreferredUpgradeTargets { get; set; }

    /// <summary>
    /// The preferred_versions attribute.
    /// </summary>
    [TerraformPropertyName("preferred_versions")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? PreferredVersions { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The version attribute.
    /// </summary>
    [TerraformPropertyName("version")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Version { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "version");

    /// <summary>
    /// The default_character_set attribute.
    /// </summary>
    [TerraformPropertyName("default_character_set")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DefaultCharacterSet => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "default_character_set");

    /// <summary>
    /// The engine_description attribute.
    /// </summary>
    [TerraformPropertyName("engine_description")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> EngineDescription => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "engine_description");

    /// <summary>
    /// The exportable_log_types attribute.
    /// </summary>
    [TerraformPropertyName("exportable_log_types")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<string>>> ExportableLogTypes => new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "exportable_log_types");

    /// <summary>
    /// The supported_character_sets attribute.
    /// </summary>
    [TerraformPropertyName("supported_character_sets")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<string>>> SupportedCharacterSets => new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "supported_character_sets");

    /// <summary>
    /// The supported_timezones attribute.
    /// </summary>
    [TerraformPropertyName("supported_timezones")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<string>>> SupportedTimezones => new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "supported_timezones");

    /// <summary>
    /// The supports_global_databases attribute.
    /// </summary>
    [TerraformPropertyName("supports_global_databases")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> SupportsGlobalDatabases => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "supports_global_databases");

    /// <summary>
    /// The supports_log_exports_to_cloudwatch attribute.
    /// </summary>
    [TerraformPropertyName("supports_log_exports_to_cloudwatch")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> SupportsLogExportsToCloudwatch => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "supports_log_exports_to_cloudwatch");

    /// <summary>
    /// The supports_read_replica attribute.
    /// </summary>
    [TerraformPropertyName("supports_read_replica")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> SupportsReadReplica => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "supports_read_replica");

    /// <summary>
    /// The valid_major_targets attribute.
    /// </summary>
    [TerraformPropertyName("valid_major_targets")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<string>>> ValidMajorTargets => new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "valid_major_targets");

    /// <summary>
    /// The valid_minor_targets attribute.
    /// </summary>
    [TerraformPropertyName("valid_minor_targets")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<string>>> ValidMinorTargets => new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "valid_minor_targets");

    /// <summary>
    /// The valid_upgrade_targets attribute.
    /// </summary>
    [TerraformPropertyName("valid_upgrade_targets")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<string>>> ValidUpgradeTargets => new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "valid_upgrade_targets");

    /// <summary>
    /// The version_actual attribute.
    /// </summary>
    [TerraformPropertyName("version_actual")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> VersionActual => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "version_actual");

    /// <summary>
    /// The version_description attribute.
    /// </summary>
    [TerraformPropertyName("version_description")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> VersionDescription => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "version_description");

}
