using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_ec2_network_insights_analysis resource.
/// </summary>
public class AwsEc2NetworkInsightsAnalysis : TerraformResource
{
    public AwsEc2NetworkInsightsAnalysis(string name) : base("aws_ec2_network_insights_analysis", name)
    {
    }

    /// <summary>
    /// The filter_in_arns attribute.
    /// </summary>
    [TerraformPropertyName("filter_in_arns")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? FilterInArns { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The network_insights_path_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetworkInsightsPathId is required")]
    [TerraformPropertyName("network_insights_path_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> NetworkInsightsPathId { get; set; }

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
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformMap<string> TagsAll { get; set; } = default!;

    /// <summary>
    /// The wait_for_completion attribute.
    /// </summary>
    [TerraformPropertyName("wait_for_completion")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? WaitForCompletion { get; set; }

    /// <summary>
    /// The alternate_path_hints attribute.
    /// </summary>
    [TerraformPropertyName("alternate_path_hints")]
    // Output-only attribute - read-only reference
    public TerraformList<object> AlternatePathHints => new TerraformReference(this, "alternate_path_hints");

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The explanations attribute.
    /// </summary>
    [TerraformPropertyName("explanations")]
    // Output-only attribute - read-only reference
    public TerraformList<object> Explanations => new TerraformReference(this, "explanations");

    /// <summary>
    /// The forward_path_components attribute.
    /// </summary>
    [TerraformPropertyName("forward_path_components")]
    // Output-only attribute - read-only reference
    public TerraformList<object> ForwardPathComponents => new TerraformReference(this, "forward_path_components");

    /// <summary>
    /// The path_found attribute.
    /// </summary>
    [TerraformPropertyName("path_found")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> PathFound => new TerraformReference(this, "path_found");

    /// <summary>
    /// The return_path_components attribute.
    /// </summary>
    [TerraformPropertyName("return_path_components")]
    // Output-only attribute - read-only reference
    public TerraformList<object> ReturnPathComponents => new TerraformReference(this, "return_path_components");

    /// <summary>
    /// The start_date attribute.
    /// </summary>
    [TerraformPropertyName("start_date")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> StartDate => new TerraformReference(this, "start_date");

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformPropertyName("status")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Status => new TerraformReference(this, "status");

    /// <summary>
    /// The status_message attribute.
    /// </summary>
    [TerraformPropertyName("status_message")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> StatusMessage => new TerraformReference(this, "status_message");

    /// <summary>
    /// The warning_message attribute.
    /// </summary>
    [TerraformPropertyName("warning_message")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> WarningMessage => new TerraformReference(this, "warning_message");

}
