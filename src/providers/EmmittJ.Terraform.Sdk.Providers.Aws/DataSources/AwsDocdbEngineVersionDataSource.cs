using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_docdb_engine_version.
/// </summary>
public partial class AwsDocdbEngineVersionDataSource : TerraformDataSource
{
    public AwsDocdbEngineVersionDataSource(string name) : base("aws_docdb_engine_version", name)
    {
    }

    /// <summary>
    /// The engine attribute.
    /// </summary>
    [TerraformProperty("engine")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Engine { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The parameter_group_family attribute.
    /// </summary>
    [TerraformProperty("parameter_group_family")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> ParameterGroupFamily { get; set; }

    /// <summary>
    /// The preferred_versions attribute.
    /// </summary>
    [TerraformProperty("preferred_versions")]
    // Optional argument - source generator will implement get/set
    public TerraformList<string>? PreferredVersions { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The version attribute.
    /// </summary>
    [TerraformProperty("version")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Version { get; set; }

    /// <summary>
    /// The engine_description attribute.
    /// </summary>
    [TerraformProperty("engine_description")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> EngineDescription { get; }

    /// <summary>
    /// The exportable_log_types attribute.
    /// </summary>
    [TerraformProperty("exportable_log_types")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformSet<string> ExportableLogTypes { get; }

    /// <summary>
    /// The supports_log_exports_to_cloudwatch attribute.
    /// </summary>
    [TerraformProperty("supports_log_exports_to_cloudwatch")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> SupportsLogExportsToCloudwatch { get; }

    /// <summary>
    /// The valid_upgrade_targets attribute.
    /// </summary>
    [TerraformProperty("valid_upgrade_targets")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformSet<string> ValidUpgradeTargets { get; }

    /// <summary>
    /// The version_description attribute.
    /// </summary>
    [TerraformProperty("version_description")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> VersionDescription { get; }

}
