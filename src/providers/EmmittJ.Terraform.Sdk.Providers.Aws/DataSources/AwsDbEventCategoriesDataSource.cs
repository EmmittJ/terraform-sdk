using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_db_event_categories.
/// </summary>
public class AwsDbEventCategoriesDataSource : TerraformDataSource
{
    public AwsDbEventCategoriesDataSource(string name) : base("aws_db_event_categories", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The source_type attribute.
    /// </summary>
    [TerraformPropertyName("source_type")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? SourceType { get; set; }

    /// <summary>
    /// The event_categories attribute.
    /// </summary>
    [TerraformPropertyName("event_categories")]
    // Output-only attribute - read-only reference
    public TerraformList<string> EventCategories => new TerraformReference(this, "event_categories");

}
