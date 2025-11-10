using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for target_grant in .
/// Nesting mode: set
/// </summary>
public class AwsS3BucketLoggingTargetGrantBlock : TerraformBlock
{
    /// <summary>
    /// The permission attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Permission is required")]
    public required TerraformProperty<string> Permission
    {
        set => SetProperty("permission", value);
    }

}

/// <summary>
/// Block type for target_object_key_format in .
/// Nesting mode: list
/// </summary>
public class AwsS3BucketLoggingTargetObjectKeyFormatBlock : TerraformBlock
{
}

/// <summary>
/// Manages a aws_s3_bucket_logging resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsS3BucketLogging : TerraformResource
{
    public AwsS3BucketLogging(string name) : base("aws_s3_bucket_logging", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("bucket");
        SetOutput("expected_bucket_owner");
        SetOutput("id");
        SetOutput("region");
        SetOutput("target_bucket");
        SetOutput("target_prefix");
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
    /// The target_bucket attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetBucket is required")]
    public required TerraformProperty<string> TargetBucket
    {
        get => GetRequiredOutput<TerraformProperty<string>>("target_bucket");
        set => SetProperty("target_bucket", value);
    }

    /// <summary>
    /// The target_prefix attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetPrefix is required")]
    public required TerraformProperty<string> TargetPrefix
    {
        get => GetRequiredOutput<TerraformProperty<string>>("target_prefix");
        set => SetProperty("target_prefix", value);
    }

    /// <summary>
    /// Block for target_grant.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsS3BucketLoggingTargetGrantBlock>? TargetGrant
    {
        set => SetProperty("target_grant", value);
    }

    /// <summary>
    /// Block for target_object_key_format.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TargetObjectKeyFormat block(s) allowed")]
    public List<AwsS3BucketLoggingTargetObjectKeyFormatBlock>? TargetObjectKeyFormat
    {
        set => SetProperty("target_object_key_format", value);
    }

}
