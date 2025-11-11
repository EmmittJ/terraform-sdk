using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_quicksight_analysis.
/// </summary>
public class AwsQuicksightAnalysisDataSource : TerraformDataSource
{
    public AwsQuicksightAnalysisDataSource(string name) : base("aws_quicksight_analysis", name)
    {
    }

    /// <summary>
    /// The analysis_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AnalysisId is required")]
    [TerraformPropertyName("analysis_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> AnalysisId { get; set; }

    /// <summary>
    /// The aws_account_id attribute.
    /// </summary>
    [TerraformPropertyName("aws_account_id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> AwsAccountId { get; set; } = default!;

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
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformMap<string> Tags { get; set; } = default!;

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The created_time attribute.
    /// </summary>
    [TerraformPropertyName("created_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CreatedTime => new TerraformReference(this, "created_time");

    /// <summary>
    /// The definition attribute.
    /// </summary>
    [TerraformPropertyName("definition")]
    // Output-only attribute - read-only reference
    public TerraformList<object> Definition => new TerraformReference(this, "definition");

    /// <summary>
    /// The last_published_time attribute.
    /// </summary>
    [TerraformPropertyName("last_published_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> LastPublishedTime => new TerraformReference(this, "last_published_time");

    /// <summary>
    /// The last_updated_time attribute.
    /// </summary>
    [TerraformPropertyName("last_updated_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> LastUpdatedTime => new TerraformReference(this, "last_updated_time");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Name => new TerraformReference(this, "name");

    /// <summary>
    /// The permissions attribute.
    /// </summary>
    [TerraformPropertyName("permissions")]
    // Output-only attribute - read-only reference
    public TerraformList<object> Permissions => new TerraformReference(this, "permissions");

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformPropertyName("status")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Status => new TerraformReference(this, "status");

    /// <summary>
    /// The theme_arn attribute.
    /// </summary>
    [TerraformPropertyName("theme_arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ThemeArn => new TerraformReference(this, "theme_arn");

}
