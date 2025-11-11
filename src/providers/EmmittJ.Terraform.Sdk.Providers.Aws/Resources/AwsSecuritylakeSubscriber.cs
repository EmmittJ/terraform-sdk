using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for source in .
/// Nesting mode: set
/// </summary>
public class AwsSecuritylakeSubscriberSourceBlock
{
}

/// <summary>
/// Block type for subscriber_identity in .
/// Nesting mode: list
/// </summary>
public class AwsSecuritylakeSubscriberSubscriberIdentityBlock
{
    /// <summary>
    /// The external_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ExternalId is required")]
    [TerraformPropertyName("external_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ExternalId { get; set; }

    /// <summary>
    /// The principal attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Principal is required")]
    [TerraformPropertyName("principal")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Principal { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsSecuritylakeSubscriberTimeoutsBlock
{
    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours). Setting a timeout for a Delete operation is only applicable if changes are saved into state before the destroy operation occurs.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a aws_securitylake_subscriber resource.
/// </summary>
public class AwsSecuritylakeSubscriber : TerraformResource
{
    public AwsSecuritylakeSubscriber(string name) : base("aws_securitylake_subscriber", name)
    {
    }

    /// <summary>
    /// The access_type attribute.
    /// </summary>
    [TerraformPropertyName("access_type")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> AccessType { get; set; } = default!;

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The subscriber_description attribute.
    /// </summary>
    [TerraformPropertyName("subscriber_description")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? SubscriberDescription { get; set; }

    /// <summary>
    /// The subscriber_name attribute.
    /// </summary>
    [TerraformPropertyName("subscriber_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? SubscriberName { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// Block for source.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("source")]
    public TerraformSet<TerraformBlock<AwsSecuritylakeSubscriberSourceBlock>>? Source { get; set; }

    /// <summary>
    /// Block for subscriber_identity.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("subscriber_identity")]
    public TerraformList<TerraformBlock<AwsSecuritylakeSubscriberSubscriberIdentityBlock>>? SubscriberIdentity { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsSecuritylakeSubscriberTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Id => new TerraformReference(this, "id");

    /// <summary>
    /// The resource_share_arn attribute.
    /// </summary>
    [TerraformPropertyName("resource_share_arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ResourceShareArn => new TerraformReference(this, "resource_share_arn");

    /// <summary>
    /// The resource_share_name attribute.
    /// </summary>
    [TerraformPropertyName("resource_share_name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ResourceShareName => new TerraformReference(this, "resource_share_name");

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [TerraformPropertyName("role_arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> RoleArn => new TerraformReference(this, "role_arn");

    /// <summary>
    /// The s3_bucket_arn attribute.
    /// </summary>
    [TerraformPropertyName("s3_bucket_arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> S3BucketArn => new TerraformReference(this, "s3_bucket_arn");

    /// <summary>
    /// The subscriber_endpoint attribute.
    /// </summary>
    [TerraformPropertyName("subscriber_endpoint")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SubscriberEndpoint => new TerraformReference(this, "subscriber_endpoint");

    /// <summary>
    /// The subscriber_status attribute.
    /// </summary>
    [TerraformPropertyName("subscriber_status")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SubscriberStatus => new TerraformReference(this, "subscriber_status");

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> TagsAll => new TerraformReference(this, "tags_all");

}
