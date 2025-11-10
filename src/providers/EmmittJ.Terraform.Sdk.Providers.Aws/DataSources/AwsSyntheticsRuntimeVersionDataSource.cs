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
    public TerraformProperty<TerraformProperty<bool>>? Latest { get; set; }

    /// <summary>
    /// The prefix attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Prefix is required")]
    [TerraformPropertyName("prefix")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Prefix { get; set; }

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
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Version { get; set; }

    /// <summary>
    /// The deprecation_date attribute.
    /// </summary>
    [TerraformPropertyName("deprecation_date")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DeprecationDate => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "deprecation_date");

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Description => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "description");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Id => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The release_date attribute.
    /// </summary>
    [TerraformPropertyName("release_date")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ReleaseDate => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "release_date");

    /// <summary>
    /// The version_name attribute.
    /// </summary>
    [TerraformPropertyName("version_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> VersionName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "version_name");

}
