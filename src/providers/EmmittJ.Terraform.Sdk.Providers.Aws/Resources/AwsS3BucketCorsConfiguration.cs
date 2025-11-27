using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for cors_rule in AwsS3BucketCorsConfiguration.
/// Nesting mode: set
/// </summary>
public class AwsS3BucketCorsConfigurationCorsRuleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "cors_rule";

    /// <summary>
    /// The allowed_headers attribute.
    /// </summary>
    public TerraformSet<string>? AllowedHeaders
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "allowed_headers").ResolveNodes(ctx));
        set => SetArgument("allowed_headers", value);
    }

    /// <summary>
    /// The allowed_methods attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AllowedMethods is required")]
    public required TerraformSet<string> AllowedMethods
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "allowed_methods").ResolveNodes(ctx));
        set => SetArgument("allowed_methods", value);
    }

    /// <summary>
    /// The allowed_origins attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AllowedOrigins is required")]
    public required TerraformSet<string> AllowedOrigins
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "allowed_origins").ResolveNodes(ctx));
        set => SetArgument("allowed_origins", value);
    }

    /// <summary>
    /// The expose_headers attribute.
    /// </summary>
    public TerraformSet<string>? ExposeHeaders
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "expose_headers").ResolveNodes(ctx));
        set => SetArgument("expose_headers", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The max_age_seconds attribute.
    /// </summary>
    public TerraformValue<double>? MaxAgeSeconds
    {
        get => new TerraformReference<double>(this, "max_age_seconds");
        set => SetArgument("max_age_seconds", value);
    }

}


/// <summary>
/// Represents a aws_s3_bucket_cors_configuration Terraform resource.
/// Manages a aws_s3_bucket_cors_configuration resource.
/// </summary>
public partial class AwsS3BucketCorsConfiguration(string name) : TerraformResource("aws_s3_bucket_cors_configuration", name)
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
    /// CorsRule block (nesting mode: set).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CorsRule is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 CorsRule block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(100, ErrorMessage = "Maximum 100 CorsRule block(s) allowed")]
    public required TerraformSet<AwsS3BucketCorsConfigurationCorsRuleBlock> CorsRule
    {
        get => GetRequiredArgument<TerraformSet<AwsS3BucketCorsConfigurationCorsRuleBlock>>("cors_rule");
        set => SetArgument("cors_rule", value);
    }

}
