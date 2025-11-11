using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_db_event_categories.
/// </summary>
public partial class AwsDbEventCategoriesDataSource : TerraformDataSource
{
    public AwsDbEventCategoriesDataSource(string name) : base("aws_db_event_categories", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The source_type attribute.
    /// </summary>
    [TerraformProperty("source_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SourceType { get; set; }

    /// <summary>
    /// The event_categories attribute.
    /// </summary>
    [TerraformProperty("event_categories")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<string> EventCategories { get; }

}
