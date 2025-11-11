using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_quicksight_analysis.
/// </summary>
public partial class AwsQuicksightAnalysisDataSource : TerraformDataSource
{
    public AwsQuicksightAnalysisDataSource(string name) : base("aws_quicksight_analysis", name)
    {
    }

    /// <summary>
    /// The analysis_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AnalysisId is required")]
    [TerraformProperty("analysis_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> AnalysisId { get; set; }

    /// <summary>
    /// The aws_account_id attribute.
    /// </summary>
    [TerraformProperty("aws_account_id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> AwsAccountId { get; set; }

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
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional+Computed - source generator will implement get/set
    public TerraformMap<string> Tags { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

    /// <summary>
    /// The created_time attribute.
    /// </summary>
    [TerraformProperty("created_time")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> CreatedTime { get; }

    /// <summary>
    /// The definition attribute.
    /// </summary>
    [TerraformProperty("definition")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> Definition { get; }

    /// <summary>
    /// The last_published_time attribute.
    /// </summary>
    [TerraformProperty("last_published_time")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> LastPublishedTime { get; }

    /// <summary>
    /// The last_updated_time attribute.
    /// </summary>
    [TerraformProperty("last_updated_time")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> LastUpdatedTime { get; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Name { get; }

    /// <summary>
    /// The permissions attribute.
    /// </summary>
    [TerraformProperty("permissions")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> Permissions { get; }

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformProperty("status")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Status { get; }

    /// <summary>
    /// The theme_arn attribute.
    /// </summary>
    [TerraformProperty("theme_arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ThemeArn { get; }

}
