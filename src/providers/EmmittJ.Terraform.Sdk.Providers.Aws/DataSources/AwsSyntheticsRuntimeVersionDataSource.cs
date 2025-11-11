using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_synthetics_runtime_version.
/// </summary>
public class AwsSyntheticsRuntimeVersionDataSource : TerraformDataSource
{
    public AwsSyntheticsRuntimeVersionDataSource(string name) : base("aws_synthetics_runtime_version", name)
    {
    }

    /// <summary>
    /// The latest attribute.
    /// </summary>
    [TerraformPropertyName("latest")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? Latest { get; set; }

    /// <summary>
    /// The prefix attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Prefix is required")]
    [TerraformPropertyName("prefix")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Prefix { get; set; }

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
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Version { get; set; }

    /// <summary>
    /// The deprecation_date attribute.
    /// </summary>
    [TerraformPropertyName("deprecation_date")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DeprecationDate => new TerraformReference(this, "deprecation_date");

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Description => new TerraformReference(this, "description");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Id => new TerraformReference(this, "id");

    /// <summary>
    /// The release_date attribute.
    /// </summary>
    [TerraformPropertyName("release_date")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ReleaseDate => new TerraformReference(this, "release_date");

    /// <summary>
    /// The version_name attribute.
    /// </summary>
    [TerraformPropertyName("version_name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> VersionName => new TerraformReference(this, "version_name");

}
