using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filters in .
/// Nesting mode: list
/// </summary>
public partial class AwsEmrReleaseLabelsDataSourceFiltersBlock : TerraformBlockBase
{
    /// <summary>
    /// The application attribute.
    /// </summary>
    [TerraformProperty("application")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Application { get; set; }

    /// <summary>
    /// The prefix attribute.
    /// </summary>
    [TerraformProperty("prefix")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Prefix { get; set; }

}

/// <summary>
/// Retrieves information about a aws_emr_release_labels.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsEmrReleaseLabelsDataSource : TerraformDataSource
{
    public AwsEmrReleaseLabelsDataSource(string name) : base("aws_emr_release_labels", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// Block for filters.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Filters block(s) allowed")]
    [TerraformProperty("filters")]
    public TerraformList<TerraformBlock<AwsEmrReleaseLabelsDataSourceFiltersBlock>>? Filters { get; set; }

    /// <summary>
    /// The release_labels attribute.
    /// </summary>
    [TerraformProperty("release_labels")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<string> ReleaseLabels { get; }

}
