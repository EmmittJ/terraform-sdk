using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filter in .
/// Nesting mode: set
/// </summary>
public class AwsRdsEngineVersionDataSourceFilterBlock
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Values is required")]
    [TerraformPropertyName("values")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformSet<string> Values { get; set; }

}

/// <summary>
/// Retrieves information about a aws_rds_engine_version.
/// </summary>
public class AwsRdsEngineVersionDataSource : TerraformDataSource
{
    public AwsRdsEngineVersionDataSource(string name) : base("aws_rds_engine_version", name)
    {
    }

    /// <summary>
    /// The default_only attribute.
    /// </summary>
    [TerraformPropertyName("default_only")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? DefaultOnly { get; set; }

    /// <summary>
    /// The engine attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Engine is required")]
    [TerraformPropertyName("engine")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Engine { get; set; }

    /// <summary>
    /// The has_major_target attribute.
    /// </summary>
    [TerraformPropertyName("has_major_target")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? HasMajorTarget { get; set; }

    /// <summary>
    /// The has_minor_target attribute.
    /// </summary>
    [TerraformPropertyName("has_minor_target")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? HasMinorTarget { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The include_all attribute.
    /// </summary>
    [TerraformPropertyName("include_all")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? IncludeAll { get; set; }

    /// <summary>
    /// The latest attribute.
    /// </summary>
    [TerraformPropertyName("latest")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? Latest { get; set; }

    /// <summary>
    /// The parameter_group_family attribute.
    /// </summary>
    [TerraformPropertyName("parameter_group_family")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> ParameterGroupFamily { get; set; } = default!;

    /// <summary>
    /// The preferred_major_targets attribute.
    /// </summary>
    [TerraformPropertyName("preferred_major_targets")]
    // Optional argument - user may or may not set a value
    public TerraformList<string>? PreferredMajorTargets { get; set; }

    /// <summary>
    /// The preferred_upgrade_targets attribute.
    /// </summary>
    [TerraformPropertyName("preferred_upgrade_targets")]
    // Optional argument - user may or may not set a value
    public TerraformList<string>? PreferredUpgradeTargets { get; set; }

    /// <summary>
    /// The preferred_versions attribute.
    /// </summary>
    [TerraformPropertyName("preferred_versions")]
    // Optional argument - user may or may not set a value
    public TerraformList<string>? PreferredVersions { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The version attribute.
    /// </summary>
    [TerraformPropertyName("version")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Version { get; set; } = default!;

    /// <summary>
    /// Block for filter.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("filter")]
    public TerraformSet<TerraformBlock<AwsRdsEngineVersionDataSourceFilterBlock>>? Filter { get; set; }

    /// <summary>
    /// The default_character_set attribute.
    /// </summary>
    [TerraformPropertyName("default_character_set")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DefaultCharacterSet => new TerraformReference(this, "default_character_set");

    /// <summary>
    /// The engine_description attribute.
    /// </summary>
    [TerraformPropertyName("engine_description")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> EngineDescription => new TerraformReference(this, "engine_description");

    /// <summary>
    /// The exportable_log_types attribute.
    /// </summary>
    [TerraformPropertyName("exportable_log_types")]
    // Output-only attribute - read-only reference
    public TerraformSet<string> ExportableLogTypes => new TerraformReference(this, "exportable_log_types");

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformPropertyName("status")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Status => new TerraformReference(this, "status");

    /// <summary>
    /// The supported_character_sets attribute.
    /// </summary>
    [TerraformPropertyName("supported_character_sets")]
    // Output-only attribute - read-only reference
    public TerraformSet<string> SupportedCharacterSets => new TerraformReference(this, "supported_character_sets");

    /// <summary>
    /// The supported_feature_names attribute.
    /// </summary>
    [TerraformPropertyName("supported_feature_names")]
    // Output-only attribute - read-only reference
    public TerraformSet<string> SupportedFeatureNames => new TerraformReference(this, "supported_feature_names");

    /// <summary>
    /// The supported_modes attribute.
    /// </summary>
    [TerraformPropertyName("supported_modes")]
    // Output-only attribute - read-only reference
    public TerraformSet<string> SupportedModes => new TerraformReference(this, "supported_modes");

    /// <summary>
    /// The supported_timezones attribute.
    /// </summary>
    [TerraformPropertyName("supported_timezones")]
    // Output-only attribute - read-only reference
    public TerraformSet<string> SupportedTimezones => new TerraformReference(this, "supported_timezones");

    /// <summary>
    /// The supports_certificate_rotation_without_restart attribute.
    /// </summary>
    [TerraformPropertyName("supports_certificate_rotation_without_restart")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> SupportsCertificateRotationWithoutRestart => new TerraformReference(this, "supports_certificate_rotation_without_restart");

    /// <summary>
    /// The supports_global_databases attribute.
    /// </summary>
    [TerraformPropertyName("supports_global_databases")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> SupportsGlobalDatabases => new TerraformReference(this, "supports_global_databases");

    /// <summary>
    /// The supports_integrations attribute.
    /// </summary>
    [TerraformPropertyName("supports_integrations")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> SupportsIntegrations => new TerraformReference(this, "supports_integrations");

    /// <summary>
    /// The supports_limitless_database attribute.
    /// </summary>
    [TerraformPropertyName("supports_limitless_database")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> SupportsLimitlessDatabase => new TerraformReference(this, "supports_limitless_database");

    /// <summary>
    /// The supports_local_write_forwarding attribute.
    /// </summary>
    [TerraformPropertyName("supports_local_write_forwarding")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> SupportsLocalWriteForwarding => new TerraformReference(this, "supports_local_write_forwarding");

    /// <summary>
    /// The supports_log_exports_to_cloudwatch attribute.
    /// </summary>
    [TerraformPropertyName("supports_log_exports_to_cloudwatch")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> SupportsLogExportsToCloudwatch => new TerraformReference(this, "supports_log_exports_to_cloudwatch");

    /// <summary>
    /// The supports_parallel_query attribute.
    /// </summary>
    [TerraformPropertyName("supports_parallel_query")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> SupportsParallelQuery => new TerraformReference(this, "supports_parallel_query");

    /// <summary>
    /// The supports_read_replica attribute.
    /// </summary>
    [TerraformPropertyName("supports_read_replica")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> SupportsReadReplica => new TerraformReference(this, "supports_read_replica");

    /// <summary>
    /// The valid_major_targets attribute.
    /// </summary>
    [TerraformPropertyName("valid_major_targets")]
    // Output-only attribute - read-only reference
    public TerraformSet<string> ValidMajorTargets => new TerraformReference(this, "valid_major_targets");

    /// <summary>
    /// The valid_minor_targets attribute.
    /// </summary>
    [TerraformPropertyName("valid_minor_targets")]
    // Output-only attribute - read-only reference
    public TerraformSet<string> ValidMinorTargets => new TerraformReference(this, "valid_minor_targets");

    /// <summary>
    /// The valid_upgrade_targets attribute.
    /// </summary>
    [TerraformPropertyName("valid_upgrade_targets")]
    // Output-only attribute - read-only reference
    public TerraformSet<string> ValidUpgradeTargets => new TerraformReference(this, "valid_upgrade_targets");

    /// <summary>
    /// The version_actual attribute.
    /// </summary>
    [TerraformPropertyName("version_actual")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> VersionActual => new TerraformReference(this, "version_actual");

    /// <summary>
    /// The version_description attribute.
    /// </summary>
    [TerraformPropertyName("version_description")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> VersionDescription => new TerraformReference(this, "version_description");

}
