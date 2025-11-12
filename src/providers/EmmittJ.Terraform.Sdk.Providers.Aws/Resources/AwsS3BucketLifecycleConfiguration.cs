using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for rule in .
/// Nesting mode: list
/// </summary>
public partial class AwsS3BucketLifecycleConfigurationRuleBlock() : TerraformBlock("rule")
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    [TerraformProperty("id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The prefix attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    [TerraformProperty("prefix")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Prefix { get; set; }

    /// <summary>
    /// The status attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Status is required")]
    [TerraformProperty("status")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Status { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsS3BucketLifecycleConfigurationTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a aws_s3_bucket_lifecycle_configuration resource.
/// </summary>
public partial class AwsS3BucketLifecycleConfiguration : TerraformResource
{
    public AwsS3BucketLifecycleConfiguration(string name) : base("aws_s3_bucket_lifecycle_configuration", name)
    {
    }

    /// <summary>
    /// The bucket attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Bucket is required")]
    [TerraformProperty("bucket")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Bucket { get; set; }

    /// <summary>
    /// The expected_bucket_owner attribute.
    /// </summary>
    [TerraformProperty("expected_bucket_owner")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> ExpectedBucketOwner { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The transition_default_minimum_object_size attribute.
    /// </summary>
    [TerraformProperty("transition_default_minimum_object_size")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> TransitionDefaultMinimumObjectSize { get; set; }

    /// <summary>
    /// Block for rule.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("rule")]
    public TerraformList<AwsS3BucketLifecycleConfigurationRuleBlock> Rule { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AwsS3BucketLifecycleConfigurationTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Id { get; }

}
