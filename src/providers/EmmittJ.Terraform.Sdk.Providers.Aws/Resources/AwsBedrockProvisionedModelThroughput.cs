using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsBedrockProvisionedModelThroughputTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

}

/// <summary>
/// Manages a aws_bedrock_provisioned_model_throughput resource.
/// </summary>
public partial class AwsBedrockProvisionedModelThroughput : TerraformResource
{
    public AwsBedrockProvisionedModelThroughput(string name) : base("aws_bedrock_provisioned_model_throughput", name)
    {
    }

    /// <summary>
    /// The commitment_duration attribute.
    /// </summary>
    [TerraformProperty("commitment_duration")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? CommitmentDuration { get; set; }

    /// <summary>
    /// The model_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ModelArn is required")]
    [TerraformProperty("model_arn")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ModelArn { get; set; }

    /// <summary>
    /// The model_units attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ModelUnits is required")]
    [TerraformProperty("model_units")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<double> ModelUnits { get; set; }

    /// <summary>
    /// The provisioned_model_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProvisionedModelName is required")]
    [TerraformProperty("provisioned_model_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ProvisionedModelName { get; set; }

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
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AwsBedrockProvisionedModelThroughputTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Id { get; }

    /// <summary>
    /// The provisioned_model_arn attribute.
    /// </summary>
    [TerraformProperty("provisioned_model_arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ProvisionedModelArn { get; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformMap<string> TagsAll { get; }

}
