using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filter in .
/// Nesting mode: set
/// </summary>
public partial class AwsRdsEngineVersionDataSourceFilterBlock : TerraformBlockBase
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Values is required")]
    [TerraformProperty("values")]
    // Required argument - source generator will implement get/set
    public required partial TerraformSet<string> Values { get; set; }

}

/// <summary>
/// Retrieves information about a aws_rds_engine_version.
/// </summary>
public partial class AwsRdsEngineVersionDataSource : TerraformDataSource
{
    public AwsRdsEngineVersionDataSource(string name) : base("aws_rds_engine_version", name)
    {
    }

    /// <summary>
    /// The default_only attribute.
    /// </summary>
    [TerraformProperty("default_only")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? DefaultOnly { get; set; }

    /// <summary>
    /// The engine attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Engine is required")]
    [TerraformProperty("engine")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Engine { get; set; }

    /// <summary>
    /// The has_major_target attribute.
    /// </summary>
    [TerraformProperty("has_major_target")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? HasMajorTarget { get; set; }

    /// <summary>
    /// The has_minor_target attribute.
    /// </summary>
    [TerraformProperty("has_minor_target")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? HasMinorTarget { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The include_all attribute.
    /// </summary>
    [TerraformProperty("include_all")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? IncludeAll { get; set; }

    /// <summary>
    /// The latest attribute.
    /// </summary>
    [TerraformProperty("latest")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? Latest { get; set; }

    /// <summary>
    /// The parameter_group_family attribute.
    /// </summary>
    [TerraformProperty("parameter_group_family")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> ParameterGroupFamily { get; set; }

    /// <summary>
    /// The preferred_major_targets attribute.
    /// </summary>
    [TerraformProperty("preferred_major_targets")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? PreferredMajorTargets { get; set; }

    /// <summary>
    /// The preferred_upgrade_targets attribute.
    /// </summary>
    [TerraformProperty("preferred_upgrade_targets")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? PreferredUpgradeTargets { get; set; }

    /// <summary>
    /// The preferred_versions attribute.
    /// </summary>
    [TerraformProperty("preferred_versions")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? PreferredVersions { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The version attribute.
    /// </summary>
    [TerraformProperty("version")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Version { get; set; }

    /// <summary>
    /// Block for filter.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("filter")]
    public partial TerraformSet<TerraformBlock<AwsRdsEngineVersionDataSourceFilterBlock>>? Filter { get; set; }

    /// <summary>
    /// The default_character_set attribute.
    /// </summary>
    [TerraformProperty("default_character_set")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DefaultCharacterSet { get; }

    /// <summary>
    /// The engine_description attribute.
    /// </summary>
    [TerraformProperty("engine_description")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> EngineDescription { get; }

    /// <summary>
    /// The exportable_log_types attribute.
    /// </summary>
    [TerraformProperty("exportable_log_types")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformSet<string> ExportableLogTypes { get; }

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformProperty("status")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Status { get; }

    /// <summary>
    /// The supported_character_sets attribute.
    /// </summary>
    [TerraformProperty("supported_character_sets")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformSet<string> SupportedCharacterSets { get; }

    /// <summary>
    /// The supported_feature_names attribute.
    /// </summary>
    [TerraformProperty("supported_feature_names")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformSet<string> SupportedFeatureNames { get; }

    /// <summary>
    /// The supported_modes attribute.
    /// </summary>
    [TerraformProperty("supported_modes")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformSet<string> SupportedModes { get; }

    /// <summary>
    /// The supported_timezones attribute.
    /// </summary>
    [TerraformProperty("supported_timezones")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformSet<string> SupportedTimezones { get; }

    /// <summary>
    /// The supports_certificate_rotation_without_restart attribute.
    /// </summary>
    [TerraformProperty("supports_certificate_rotation_without_restart")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> SupportsCertificateRotationWithoutRestart { get; }

    /// <summary>
    /// The supports_global_databases attribute.
    /// </summary>
    [TerraformProperty("supports_global_databases")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> SupportsGlobalDatabases { get; }

    /// <summary>
    /// The supports_integrations attribute.
    /// </summary>
    [TerraformProperty("supports_integrations")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> SupportsIntegrations { get; }

    /// <summary>
    /// The supports_limitless_database attribute.
    /// </summary>
    [TerraformProperty("supports_limitless_database")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> SupportsLimitlessDatabase { get; }

    /// <summary>
    /// The supports_local_write_forwarding attribute.
    /// </summary>
    [TerraformProperty("supports_local_write_forwarding")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> SupportsLocalWriteForwarding { get; }

    /// <summary>
    /// The supports_log_exports_to_cloudwatch attribute.
    /// </summary>
    [TerraformProperty("supports_log_exports_to_cloudwatch")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> SupportsLogExportsToCloudwatch { get; }

    /// <summary>
    /// The supports_parallel_query attribute.
    /// </summary>
    [TerraformProperty("supports_parallel_query")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> SupportsParallelQuery { get; }

    /// <summary>
    /// The supports_read_replica attribute.
    /// </summary>
    [TerraformProperty("supports_read_replica")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> SupportsReadReplica { get; }

    /// <summary>
    /// The valid_major_targets attribute.
    /// </summary>
    [TerraformProperty("valid_major_targets")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformSet<string> ValidMajorTargets { get; }

    /// <summary>
    /// The valid_minor_targets attribute.
    /// </summary>
    [TerraformProperty("valid_minor_targets")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformSet<string> ValidMinorTargets { get; }

    /// <summary>
    /// The valid_upgrade_targets attribute.
    /// </summary>
    [TerraformProperty("valid_upgrade_targets")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformSet<string> ValidUpgradeTargets { get; }

    /// <summary>
    /// The version_actual attribute.
    /// </summary>
    [TerraformProperty("version_actual")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> VersionActual { get; }

    /// <summary>
    /// The version_description attribute.
    /// </summary>
    [TerraformProperty("version_description")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> VersionDescription { get; }

}
