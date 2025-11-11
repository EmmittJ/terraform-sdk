using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filter in .
/// Nesting mode: set
/// </summary>
public partial class AwsEc2NetworkInsightsAnalysisDataSourceFilterBlock : TerraformBlockBase
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Values is required")]
    [TerraformProperty("values")]
    // Required argument - source generator will implement get/set
    public required partial TerraformSet<string> Values { get; set; }

}

/// <summary>
/// Retrieves information about a aws_ec2_network_insights_analysis.
/// </summary>
public partial class AwsEc2NetworkInsightsAnalysisDataSource : TerraformDataSource
{
    public AwsEc2NetworkInsightsAnalysisDataSource(string name) : base("aws_ec2_network_insights_analysis", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The network_insights_analysis_id attribute.
    /// </summary>
    [TerraformProperty("network_insights_analysis_id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> NetworkInsightsAnalysisId { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformMap<string> Tags { get; set; }

    /// <summary>
    /// Block for filter.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("filter")]
    public partial TerraformSet<TerraformBlock<AwsEc2NetworkInsightsAnalysisDataSourceFilterBlock>>? Filter { get; set; }

    /// <summary>
    /// The alternate_path_hints attribute.
    /// </summary>
    [TerraformProperty("alternate_path_hints")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> AlternatePathHints { get; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The explanations attribute.
    /// </summary>
    [TerraformProperty("explanations")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> Explanations { get; }

    /// <summary>
    /// The filter_in_arns attribute.
    /// </summary>
    [TerraformProperty("filter_in_arns")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<string> FilterInArns { get; }

    /// <summary>
    /// The forward_path_components attribute.
    /// </summary>
    [TerraformProperty("forward_path_components")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> ForwardPathComponents { get; }

    /// <summary>
    /// The network_insights_path_id attribute.
    /// </summary>
    [TerraformProperty("network_insights_path_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> NetworkInsightsPathId { get; }

    /// <summary>
    /// The path_found attribute.
    /// </summary>
    [TerraformProperty("path_found")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> PathFound { get; }

    /// <summary>
    /// The return_path_components attribute.
    /// </summary>
    [TerraformProperty("return_path_components")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> ReturnPathComponents { get; }

    /// <summary>
    /// The start_date attribute.
    /// </summary>
    [TerraformProperty("start_date")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> StartDate { get; }

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformProperty("status")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Status { get; }

    /// <summary>
    /// The status_message attribute.
    /// </summary>
    [TerraformProperty("status_message")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> StatusMessage { get; }

    /// <summary>
    /// The warning_message attribute.
    /// </summary>
    [TerraformProperty("warning_message")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> WarningMessage { get; }

}
