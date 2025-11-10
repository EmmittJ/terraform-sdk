using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filter in .
/// Nesting mode: set
/// </summary>
public class AwsEc2NetworkInsightsAnalysisDataSourceFilterBlock : ITerraformBlock
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Values is required")]
    [TerraformPropertyName("values")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformProperty<HashSet<TerraformProperty<string>>>? Values { get; set; }

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
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The network_insights_analysis_id attribute.
    /// </summary>
    [TerraformPropertyName("network_insights_analysis_id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> NetworkInsightsAnalysisId { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "network_insights_analysis_id");

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Tags { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags");

    /// <summary>
    /// Block for filter.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("filter")]
    public TerraformSet<TerraformBlock<AwsEc2NetworkInsightsAnalysisDataSourceFilterBlock>>? Filter { get; set; } = new();

    /// <summary>
    /// The alternate_path_hints attribute.
    /// </summary>
    [TerraformPropertyName("alternate_path_hints")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> AlternatePathHints => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "alternate_path_hints");

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The explanations attribute.
    /// </summary>
    [TerraformPropertyName("explanations")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Explanations => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "explanations");

    /// <summary>
    /// The filter_in_arns attribute.
    /// </summary>
    [TerraformPropertyName("filter_in_arns")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> FilterInArns => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "filter_in_arns");

    /// <summary>
    /// The forward_path_components attribute.
    /// </summary>
    [TerraformPropertyName("forward_path_components")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> ForwardPathComponents => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "forward_path_components");

    /// <summary>
    /// The network_insights_path_id attribute.
    /// </summary>
    [TerraformPropertyName("network_insights_path_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> NetworkInsightsPathId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "network_insights_path_id");

    /// <summary>
    /// The path_found attribute.
    /// </summary>
    [TerraformPropertyName("path_found")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> PathFound => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "path_found");

    /// <summary>
    /// The return_path_components attribute.
    /// </summary>
    [TerraformPropertyName("return_path_components")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> ReturnPathComponents => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "return_path_components");

    /// <summary>
    /// The start_date attribute.
    /// </summary>
    [TerraformPropertyName("start_date")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> StartDate => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "start_date");

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformPropertyName("status")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Status => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "status");

    /// <summary>
    /// The status_message attribute.
    /// </summary>
    [TerraformPropertyName("status_message")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> StatusMessage => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "status_message");

    /// <summary>
    /// The warning_message attribute.
    /// </summary>
    [TerraformPropertyName("warning_message")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> WarningMessage => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "warning_message");

}
