using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for source in .
/// Nesting mode: set
/// </summary>
public partial class AwsSecuritylakeSubscriberSourceBlock() : TerraformBlock("source")
{
}

/// <summary>
/// Block type for subscriber_identity in .
/// Nesting mode: list
/// </summary>
public partial class AwsSecuritylakeSubscriberSubscriberIdentityBlock() : TerraformBlock("subscriber_identity")
{
    /// <summary>
    /// The external_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ExternalId is required")]
    [TerraformProperty("external_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ExternalId { get; set; }

    /// <summary>
    /// The principal attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Principal is required")]
    [TerraformProperty("principal")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Principal { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsSecuritylakeSubscriberTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours). Setting a timeout for a Delete operation is only applicable if changes are saved into state before the destroy operation occurs.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a aws_securitylake_subscriber resource.
/// </summary>
public partial class AwsSecuritylakeSubscriber : TerraformResource
{
    public AwsSecuritylakeSubscriber(string name) : base("aws_securitylake_subscriber", name)
    {
    }

    /// <summary>
    /// The access_type attribute.
    /// </summary>
    [TerraformProperty("access_type")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> AccessType { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The subscriber_description attribute.
    /// </summary>
    [TerraformProperty("subscriber_description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SubscriberDescription { get; set; }

    /// <summary>
    /// The subscriber_name attribute.
    /// </summary>
    [TerraformProperty("subscriber_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SubscriberName { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// Block for source.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("source")]
    public TerraformSet<AwsSecuritylakeSubscriberSourceBlock> Source { get; set; } = new();

    /// <summary>
    /// Block for subscriber_identity.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("subscriber_identity")]
    public TerraformList<AwsSecuritylakeSubscriberSubscriberIdentityBlock> SubscriberIdentity { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AwsSecuritylakeSubscriberTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Id { get; }

    /// <summary>
    /// The resource_share_arn attribute.
    /// </summary>
    [TerraformProperty("resource_share_arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ResourceShareArn { get; }

    /// <summary>
    /// The resource_share_name attribute.
    /// </summary>
    [TerraformProperty("resource_share_name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ResourceShareName { get; }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [TerraformProperty("role_arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> RoleArn { get; }

    /// <summary>
    /// The s3_bucket_arn attribute.
    /// </summary>
    [TerraformProperty("s3_bucket_arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> S3BucketArn { get; }

    /// <summary>
    /// The subscriber_endpoint attribute.
    /// </summary>
    [TerraformProperty("subscriber_endpoint")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SubscriberEndpoint { get; }

    /// <summary>
    /// The subscriber_status attribute.
    /// </summary>
    [TerraformProperty("subscriber_status")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SubscriberStatus { get; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> TagsAll { get; }

}
