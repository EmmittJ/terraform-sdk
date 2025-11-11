using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for error_document in .
/// Nesting mode: list
/// </summary>
public class AwsS3BucketWebsiteConfigurationErrorDocumentBlock
{
    /// <summary>
    /// The key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    [TerraformPropertyName("key")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Key { get; set; }

}

/// <summary>
/// Block type for index_document in .
/// Nesting mode: list
/// </summary>
public class AwsS3BucketWebsiteConfigurationIndexDocumentBlock
{
    /// <summary>
    /// The suffix attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Suffix is required")]
    [TerraformPropertyName("suffix")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Suffix { get; set; }

}

/// <summary>
/// Block type for redirect_all_requests_to in .
/// Nesting mode: list
/// </summary>
public class AwsS3BucketWebsiteConfigurationRedirectAllRequestsToBlock
{
    /// <summary>
    /// The host_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HostName is required")]
    [TerraformPropertyName("host_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> HostName { get; set; }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    [TerraformPropertyName("protocol")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Protocol { get; set; }

}

/// <summary>
/// Block type for routing_rule in .
/// Nesting mode: list
/// </summary>
public class AwsS3BucketWebsiteConfigurationRoutingRuleBlock
{
}

/// <summary>
/// Manages a aws_s3_bucket_website_configuration resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsS3BucketWebsiteConfiguration : TerraformResource
{
    public AwsS3BucketWebsiteConfiguration(string name) : base("aws_s3_bucket_website_configuration", name)
    {
    }

    /// <summary>
    /// The bucket attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Bucket is required")]
    [TerraformPropertyName("bucket")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Bucket { get; set; }

    /// <summary>
    /// The expected_bucket_owner attribute.
    /// </summary>
    [TerraformPropertyName("expected_bucket_owner")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ExpectedBucketOwner { get; set; }

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
    /// The routing_rules attribute.
    /// </summary>
    [TerraformPropertyName("routing_rules")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> RoutingRules { get; set; } = default!;

    /// <summary>
    /// Block for error_document.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ErrorDocument block(s) allowed")]
    [TerraformPropertyName("error_document")]
    public TerraformList<TerraformBlock<AwsS3BucketWebsiteConfigurationErrorDocumentBlock>>? ErrorDocument { get; set; }

    /// <summary>
    /// Block for index_document.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IndexDocument block(s) allowed")]
    [TerraformPropertyName("index_document")]
    public TerraformList<TerraformBlock<AwsS3BucketWebsiteConfigurationIndexDocumentBlock>>? IndexDocument { get; set; }

    /// <summary>
    /// Block for redirect_all_requests_to.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RedirectAllRequestsTo block(s) allowed")]
    [TerraformPropertyName("redirect_all_requests_to")]
    public TerraformList<TerraformBlock<AwsS3BucketWebsiteConfigurationRedirectAllRequestsToBlock>>? RedirectAllRequestsTo { get; set; }

    /// <summary>
    /// Block for routing_rule.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("routing_rule")]
    public TerraformList<TerraformBlock<AwsS3BucketWebsiteConfigurationRoutingRuleBlock>>? RoutingRule { get; set; }

    /// <summary>
    /// The website_domain attribute.
    /// </summary>
    [TerraformPropertyName("website_domain")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> WebsiteDomain => new TerraformReference(this, "website_domain");

    /// <summary>
    /// The website_endpoint attribute.
    /// </summary>
    [TerraformPropertyName("website_endpoint")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> WebsiteEndpoint => new TerraformReference(this, "website_endpoint");

}
