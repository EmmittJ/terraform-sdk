using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for error_document in AwsS3BucketWebsiteConfiguration.
/// Nesting mode: list
/// </summary>
public class AwsS3BucketWebsiteConfigurationErrorDocumentBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "error_document";

    /// <summary>
    /// The key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    public required TerraformValue<string> Key
    {
        get => new TerraformReference<string>(this, "key");
        set => SetArgument("key", value);
    }

}


/// <summary>
/// Block type for index_document in AwsS3BucketWebsiteConfiguration.
/// Nesting mode: list
/// </summary>
public class AwsS3BucketWebsiteConfigurationIndexDocumentBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "index_document";

    /// <summary>
    /// The suffix attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Suffix is required")]
    public required TerraformValue<string> Suffix
    {
        get => new TerraformReference<string>(this, "suffix");
        set => SetArgument("suffix", value);
    }

}


/// <summary>
/// Block type for redirect_all_requests_to in AwsS3BucketWebsiteConfiguration.
/// Nesting mode: list
/// </summary>
public class AwsS3BucketWebsiteConfigurationRedirectAllRequestsToBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "redirect_all_requests_to";

    /// <summary>
    /// The host_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HostName is required")]
    public required TerraformValue<string> HostName
    {
        get => new TerraformReference<string>(this, "host_name");
        set => SetArgument("host_name", value);
    }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    public TerraformValue<string>? Protocol
    {
        get => new TerraformReference<string>(this, "protocol");
        set => SetArgument("protocol", value);
    }

}


/// <summary>
/// Block type for routing_rule in AwsS3BucketWebsiteConfiguration.
/// Nesting mode: list
/// </summary>
public class AwsS3BucketWebsiteConfigurationRoutingRuleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "routing_rule";

    /// <summary>
    /// Condition block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Condition block(s) allowed")]
    public TerraformList<AwsS3BucketWebsiteConfigurationRoutingRuleBlockConditionBlock>? Condition
    {
        get => GetArgument<TerraformList<AwsS3BucketWebsiteConfigurationRoutingRuleBlockConditionBlock>>("condition");
        set => SetArgument("condition", value);
    }

    /// <summary>
    /// Redirect block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Redirect is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Redirect block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Redirect block(s) allowed")]
    public required TerraformList<AwsS3BucketWebsiteConfigurationRoutingRuleBlockRedirectBlock> Redirect
    {
        get => GetRequiredArgument<TerraformList<AwsS3BucketWebsiteConfigurationRoutingRuleBlockRedirectBlock>>("redirect");
        set => SetArgument("redirect", value);
    }

}

/// <summary>
/// Block type for condition in AwsS3BucketWebsiteConfigurationRoutingRuleBlock.
/// Nesting mode: list
/// </summary>
public class AwsS3BucketWebsiteConfigurationRoutingRuleBlockConditionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "condition";

    /// <summary>
    /// The http_error_code_returned_equals attribute.
    /// </summary>
    public TerraformValue<string>? HttpErrorCodeReturnedEquals
    {
        get => new TerraformReference<string>(this, "http_error_code_returned_equals");
        set => SetArgument("http_error_code_returned_equals", value);
    }

    /// <summary>
    /// The key_prefix_equals attribute.
    /// </summary>
    public TerraformValue<string>? KeyPrefixEquals
    {
        get => new TerraformReference<string>(this, "key_prefix_equals");
        set => SetArgument("key_prefix_equals", value);
    }

}

/// <summary>
/// Block type for redirect in AwsS3BucketWebsiteConfigurationRoutingRuleBlock.
/// Nesting mode: list
/// </summary>
public class AwsS3BucketWebsiteConfigurationRoutingRuleBlockRedirectBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "redirect";

    /// <summary>
    /// The host_name attribute.
    /// </summary>
    public TerraformValue<string>? HostName
    {
        get => new TerraformReference<string>(this, "host_name");
        set => SetArgument("host_name", value);
    }

    /// <summary>
    /// The http_redirect_code attribute.
    /// </summary>
    public TerraformValue<string>? HttpRedirectCode
    {
        get => new TerraformReference<string>(this, "http_redirect_code");
        set => SetArgument("http_redirect_code", value);
    }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    public TerraformValue<string>? Protocol
    {
        get => new TerraformReference<string>(this, "protocol");
        set => SetArgument("protocol", value);
    }

    /// <summary>
    /// The replace_key_prefix_with attribute.
    /// </summary>
    public TerraformValue<string>? ReplaceKeyPrefixWith
    {
        get => new TerraformReference<string>(this, "replace_key_prefix_with");
        set => SetArgument("replace_key_prefix_with", value);
    }

    /// <summary>
    /// The replace_key_with attribute.
    /// </summary>
    public TerraformValue<string>? ReplaceKeyWith
    {
        get => new TerraformReference<string>(this, "replace_key_with");
        set => SetArgument("replace_key_with", value);
    }

}


/// <summary>
/// Represents a aws_s3_bucket_website_configuration Terraform resource.
/// Manages a aws_s3_bucket_website_configuration resource.
/// </summary>
public partial class AwsS3BucketWebsiteConfiguration(string name) : TerraformResource("aws_s3_bucket_website_configuration", name)
{
    /// <summary>
    /// The bucket attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Bucket is required")]
    public required TerraformValue<string> Bucket
    {
        get => new TerraformReference<string>(this, "bucket");
        set => SetArgument("bucket", value);
    }

    /// <summary>
    /// The expected_bucket_owner attribute.
    /// </summary>
    public TerraformValue<string>? ExpectedBucketOwner
    {
        get => new TerraformReference<string>(this, "expected_bucket_owner");
        set => SetArgument("expected_bucket_owner", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The routing_rules attribute.
    /// </summary>
    public TerraformValue<string> RoutingRules
    {
        get => new TerraformReference<string>(this, "routing_rules");
        set => SetArgument("routing_rules", value);
    }

    /// <summary>
    /// The website_domain attribute.
    /// </summary>
    public TerraformValue<string> WebsiteDomain
    {
        get => new TerraformReference<string>(this, "website_domain");
    }

    /// <summary>
    /// The website_endpoint attribute.
    /// </summary>
    public TerraformValue<string> WebsiteEndpoint
    {
        get => new TerraformReference<string>(this, "website_endpoint");
    }

    /// <summary>
    /// ErrorDocument block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ErrorDocument block(s) allowed")]
    public TerraformList<AwsS3BucketWebsiteConfigurationErrorDocumentBlock>? ErrorDocument
    {
        get => GetArgument<TerraformList<AwsS3BucketWebsiteConfigurationErrorDocumentBlock>>("error_document");
        set => SetArgument("error_document", value);
    }

    /// <summary>
    /// IndexDocument block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IndexDocument block(s) allowed")]
    public TerraformList<AwsS3BucketWebsiteConfigurationIndexDocumentBlock>? IndexDocument
    {
        get => GetArgument<TerraformList<AwsS3BucketWebsiteConfigurationIndexDocumentBlock>>("index_document");
        set => SetArgument("index_document", value);
    }

    /// <summary>
    /// RedirectAllRequestsTo block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RedirectAllRequestsTo block(s) allowed")]
    public TerraformList<AwsS3BucketWebsiteConfigurationRedirectAllRequestsToBlock>? RedirectAllRequestsTo
    {
        get => GetArgument<TerraformList<AwsS3BucketWebsiteConfigurationRedirectAllRequestsToBlock>>("redirect_all_requests_to");
        set => SetArgument("redirect_all_requests_to", value);
    }

    /// <summary>
    /// RoutingRule block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsS3BucketWebsiteConfigurationRoutingRuleBlock>? RoutingRule
    {
        get => GetArgument<TerraformList<AwsS3BucketWebsiteConfigurationRoutingRuleBlock>>("routing_rule");
        set => SetArgument("routing_rule", value);
    }

}
