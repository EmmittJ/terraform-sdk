using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for error_document in .
/// Nesting mode: list
/// </summary>
public class AwsS3BucketWebsiteConfigurationErrorDocumentBlock : TerraformBlock
{
    /// <summary>
    /// The key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    public required TerraformProperty<string> Key
    {
        set => SetProperty("key", value);
    }

}

/// <summary>
/// Block type for index_document in .
/// Nesting mode: list
/// </summary>
public class AwsS3BucketWebsiteConfigurationIndexDocumentBlock : TerraformBlock
{
    /// <summary>
    /// The suffix attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Suffix is required")]
    public required TerraformProperty<string> Suffix
    {
        set => SetProperty("suffix", value);
    }

}

/// <summary>
/// Block type for redirect_all_requests_to in .
/// Nesting mode: list
/// </summary>
public class AwsS3BucketWebsiteConfigurationRedirectAllRequestsToBlock : TerraformBlock
{
    /// <summary>
    /// The host_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HostName is required")]
    public required TerraformProperty<string> HostName
    {
        set => SetProperty("host_name", value);
    }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    public TerraformProperty<string>? Protocol
    {
        set => SetProperty("protocol", value);
    }

}

/// <summary>
/// Block type for routing_rule in .
/// Nesting mode: list
/// </summary>
public class AwsS3BucketWebsiteConfigurationRoutingRuleBlock : TerraformBlock
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
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("website_domain");
        SetOutput("website_endpoint");
        SetOutput("bucket");
        SetOutput("expected_bucket_owner");
        SetOutput("id");
        SetOutput("region");
        SetOutput("routing_rules");
    }

    /// <summary>
    /// The bucket attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Bucket is required")]
    public required TerraformProperty<string> Bucket
    {
        get => GetRequiredOutput<TerraformProperty<string>>("bucket");
        set => SetProperty("bucket", value);
    }

    /// <summary>
    /// The expected_bucket_owner attribute.
    /// </summary>
    public TerraformProperty<string> ExpectedBucketOwner
    {
        get => GetRequiredOutput<TerraformProperty<string>>("expected_bucket_owner");
        set => SetProperty("expected_bucket_owner", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The routing_rules attribute.
    /// </summary>
    public TerraformProperty<string> RoutingRules
    {
        get => GetRequiredOutput<TerraformProperty<string>>("routing_rules");
        set => SetProperty("routing_rules", value);
    }

    /// <summary>
    /// Block for error_document.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ErrorDocument block(s) allowed")]
    public List<AwsS3BucketWebsiteConfigurationErrorDocumentBlock>? ErrorDocument
    {
        set => SetProperty("error_document", value);
    }

    /// <summary>
    /// Block for index_document.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IndexDocument block(s) allowed")]
    public List<AwsS3BucketWebsiteConfigurationIndexDocumentBlock>? IndexDocument
    {
        set => SetProperty("index_document", value);
    }

    /// <summary>
    /// Block for redirect_all_requests_to.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RedirectAllRequestsTo block(s) allowed")]
    public List<AwsS3BucketWebsiteConfigurationRedirectAllRequestsToBlock>? RedirectAllRequestsTo
    {
        set => SetProperty("redirect_all_requests_to", value);
    }

    /// <summary>
    /// Block for routing_rule.
    /// Nesting mode: list
    /// </summary>
    public List<AwsS3BucketWebsiteConfigurationRoutingRuleBlock>? RoutingRule
    {
        set => SetProperty("routing_rule", value);
    }

    /// <summary>
    /// The website_domain attribute.
    /// </summary>
    public TerraformExpression WebsiteDomain => this["website_domain"];

    /// <summary>
    /// The website_endpoint attribute.
    /// </summary>
    public TerraformExpression WebsiteEndpoint => this["website_endpoint"];

}
