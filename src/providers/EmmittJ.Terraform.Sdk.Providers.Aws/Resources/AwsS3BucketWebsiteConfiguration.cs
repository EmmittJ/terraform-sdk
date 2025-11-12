using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for error_document in .
/// Nesting mode: list
/// </summary>
public partial class AwsS3BucketWebsiteConfigurationErrorDocumentBlock() : TerraformBlock("error_document")
{
    /// <summary>
    /// The key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    [TerraformProperty("key")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Key { get; set; }

}

/// <summary>
/// Block type for index_document in .
/// Nesting mode: list
/// </summary>
public partial class AwsS3BucketWebsiteConfigurationIndexDocumentBlock() : TerraformBlock("index_document")
{
    /// <summary>
    /// The suffix attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Suffix is required")]
    [TerraformProperty("suffix")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Suffix { get; set; }

}

/// <summary>
/// Block type for redirect_all_requests_to in .
/// Nesting mode: list
/// </summary>
public partial class AwsS3BucketWebsiteConfigurationRedirectAllRequestsToBlock() : TerraformBlock("redirect_all_requests_to")
{
    /// <summary>
    /// The host_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HostName is required")]
    [TerraformProperty("host_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> HostName { get; set; }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    [TerraformProperty("protocol")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Protocol { get; set; }

}

/// <summary>
/// Block type for routing_rule in .
/// Nesting mode: list
/// </summary>
public partial class AwsS3BucketWebsiteConfigurationRoutingRuleBlock() : TerraformBlock("routing_rule")
{
}

/// <summary>
/// Manages a aws_s3_bucket_website_configuration resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsS3BucketWebsiteConfiguration : TerraformResource
{
    public AwsS3BucketWebsiteConfiguration(string name) : base("aws_s3_bucket_website_configuration", name)
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
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ExpectedBucketOwner { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The routing_rules attribute.
    /// </summary>
    [TerraformProperty("routing_rules")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> RoutingRules { get; set; }

    /// <summary>
    /// Block for error_document.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ErrorDocument block(s) allowed")]
    [TerraformProperty("error_document")]
    public TerraformList<AwsS3BucketWebsiteConfigurationErrorDocumentBlock> ErrorDocument { get; set; } = new();

    /// <summary>
    /// Block for index_document.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IndexDocument block(s) allowed")]
    [TerraformProperty("index_document")]
    public TerraformList<AwsS3BucketWebsiteConfigurationIndexDocumentBlock> IndexDocument { get; set; } = new();

    /// <summary>
    /// Block for redirect_all_requests_to.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RedirectAllRequestsTo block(s) allowed")]
    [TerraformProperty("redirect_all_requests_to")]
    public TerraformList<AwsS3BucketWebsiteConfigurationRedirectAllRequestsToBlock> RedirectAllRequestsTo { get; set; } = new();

    /// <summary>
    /// Block for routing_rule.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("routing_rule")]
    public TerraformList<AwsS3BucketWebsiteConfigurationRoutingRuleBlock> RoutingRule { get; set; } = new();

    /// <summary>
    /// The website_domain attribute.
    /// </summary>
    [TerraformProperty("website_domain")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> WebsiteDomain { get; }

    /// <summary>
    /// The website_endpoint attribute.
    /// </summary>
    [TerraformProperty("website_endpoint")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> WebsiteEndpoint { get; }

}
