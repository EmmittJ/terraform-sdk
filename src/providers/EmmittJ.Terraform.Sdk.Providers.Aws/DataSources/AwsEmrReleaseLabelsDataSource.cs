using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filters in .
/// Nesting mode: list
/// </summary>
public class AwsEmrReleaseLabelsDataSourceFiltersBlock : ITerraformBlock
{
    /// <summary>
    /// The application attribute.
    /// </summary>
    [TerraformPropertyName("application")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Application { get; set; }

    /// <summary>
    /// The prefix attribute.
    /// </summary>
    [TerraformPropertyName("prefix")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Prefix { get; set; }

}

/// <summary>
/// Retrieves information about a aws_emr_release_labels.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsEmrReleaseLabelsDataSource : TerraformDataSource
{
    public AwsEmrReleaseLabelsDataSource(string name) : base("aws_emr_release_labels", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// Block for filters.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Filters block(s) allowed")]
    [TerraformPropertyName("filters")]
    public TerraformList<TerraformBlock<AwsEmrReleaseLabelsDataSourceFiltersBlock>>? Filters { get; set; } = new();

    /// <summary>
    /// The release_labels attribute.
    /// </summary>
    [TerraformPropertyName("release_labels")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> ReleaseLabels => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "release_labels");

}
