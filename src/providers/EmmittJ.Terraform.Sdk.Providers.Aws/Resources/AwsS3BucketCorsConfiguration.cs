using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for cors_rule in .
/// Nesting mode: set
/// </summary>
public class AwsS3BucketCorsConfigurationCorsRuleBlock : TerraformBlock
{
    /// <summary>
    /// The allowed_headers attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? AllowedHeaders
    {
        set => SetProperty("allowed_headers", value);
    }

    /// <summary>
    /// The allowed_methods attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AllowedMethods is required")]
    public HashSet<TerraformProperty<string>>? AllowedMethods
    {
        set => SetProperty("allowed_methods", value);
    }

    /// <summary>
    /// The allowed_origins attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AllowedOrigins is required")]
    public HashSet<TerraformProperty<string>>? AllowedOrigins
    {
        set => SetProperty("allowed_origins", value);
    }

    /// <summary>
    /// The expose_headers attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? ExposeHeaders
    {
        set => SetProperty("expose_headers", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The max_age_seconds attribute.
    /// </summary>
    public TerraformProperty<double>? MaxAgeSeconds
    {
        set => SetProperty("max_age_seconds", value);
    }

}

/// <summary>
/// Manages a aws_s3_bucket_cors_configuration resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsS3BucketCorsConfiguration : TerraformResource
{
    public AwsS3BucketCorsConfiguration(string name) : base("aws_s3_bucket_cors_configuration", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("bucket");
        SetOutput("expected_bucket_owner");
        SetOutput("id");
        SetOutput("region");
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
    /// Block for cors_rule.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CorsRule is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 CorsRule block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(100, ErrorMessage = "Maximum 100 CorsRule block(s) allowed")]
    public HashSet<AwsS3BucketCorsConfigurationCorsRuleBlock>? CorsRule
    {
        set => SetProperty("cors_rule", value);
    }

}
