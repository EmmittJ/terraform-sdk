using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_docdb_engine_version.
/// </summary>
public class AwsDocdbEngineVersionDataSource : TerraformDataSource
{
    public AwsDocdbEngineVersionDataSource(string name) : base("aws_docdb_engine_version", name)
    {
    }

    /// <summary>
    /// The engine attribute.
    /// </summary>
    [TerraformPropertyName("engine")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Engine { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The parameter_group_family attribute.
    /// </summary>
    [TerraformPropertyName("parameter_group_family")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> ParameterGroupFamily { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "parameter_group_family");

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
    /// The supports_log_exports_to_cloudwatch attribute.
    /// </summary>
    [TerraformPropertyName("supports_log_exports_to_cloudwatch")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> SupportsLogExportsToCloudwatch => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "supports_log_exports_to_cloudwatch");

    /// <summary>
    /// The valid_upgrade_targets attribute.
    /// </summary>
    [TerraformPropertyName("valid_upgrade_targets")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<string>>> ValidUpgradeTargets => new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "valid_upgrade_targets");

    /// <summary>
    /// The version_description attribute.
    /// </summary>
    [TerraformPropertyName("version_description")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> VersionDescription => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "version_description");

}
