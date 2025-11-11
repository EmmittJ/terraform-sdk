using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filter in .
/// Nesting mode: set
/// </summary>
public class AwsEc2NetworkInsightsAnalysisDataSourceFilterBlock
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Values is required")]
    [TerraformPropertyName("values")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformSet<string> Values { get; set; }

}

/// <summary>
/// Retrieves information about a aws_ec2_network_insights_analysis.
/// </summary>
public class AwsEc2NetworkInsightsAnalysisDataSource : TerraformDataSource
{
    public AwsEc2NetworkInsightsAnalysisDataSource(string name) : base("aws_ec2_network_insights_analysis", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The network_insights_analysis_id attribute.
    /// </summary>
    [TerraformPropertyName("network_insights_analysis_id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> NetworkInsightsAnalysisId { get; set; } = default!;

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
    /// Block for filter.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("filter")]
    public TerraformSet<TerraformBlock<AwsEc2NetworkInsightsAnalysisDataSourceFilterBlock>>? Filter { get; set; }

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
    /// The filter_in_arns attribute.
    /// </summary>
    [TerraformPropertyName("filter_in_arns")]
    // Output-only attribute - read-only reference
    public TerraformList<string> FilterInArns => new TerraformReference(this, "filter_in_arns");

    /// <summary>
    /// The forward_path_components attribute.
    /// </summary>
    [TerraformPropertyName("forward_path_components")]
    // Output-only attribute - read-only reference
    public TerraformList<object> ForwardPathComponents => new TerraformReference(this, "forward_path_components");

    /// <summary>
    /// The network_insights_path_id attribute.
    /// </summary>
    [TerraformPropertyName("network_insights_path_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> NetworkInsightsPathId => new TerraformReference(this, "network_insights_path_id");

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
