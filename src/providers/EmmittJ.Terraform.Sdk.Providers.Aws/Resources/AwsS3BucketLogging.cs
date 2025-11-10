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
        get => GetRequiredProperty<TerraformProperty<string>>("permission");
        set => WithProperty("permission", value);
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
    }

    /// <summary>
    /// The bucket attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Bucket is required")]
    public required TerraformProperty<string> Bucket
    {
        get => GetRequiredProperty<TerraformProperty<string>>("bucket");
        set => this.WithProperty("bucket", value);
    }

    /// <summary>
    /// The expected_bucket_owner attribute.
    /// </summary>
    public TerraformProperty<string>? ExpectedBucketOwner
    {
        get => GetProperty<TerraformProperty<string>>("expected_bucket_owner");
        set => this.WithProperty("expected_bucket_owner", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The target_bucket attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetBucket is required")]
    public required TerraformProperty<string> TargetBucket
    {
        get => GetRequiredProperty<TerraformProperty<string>>("target_bucket");
        set => this.WithProperty("target_bucket", value);
    }

    /// <summary>
    /// The target_prefix attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetPrefix is required")]
    public required TerraformProperty<string> TargetPrefix
    {
        get => GetRequiredProperty<TerraformProperty<string>>("target_prefix");
        set => this.WithProperty("target_prefix", value);
    }

    /// <summary>
    /// Block for target_grant.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsS3BucketLoggingTargetGrantBlock>? TargetGrant
    {
        get => GetProperty<HashSet<AwsS3BucketLoggingTargetGrantBlock>>("target_grant");
        set => this.WithProperty("target_grant", value);
    }

    /// <summary>
    /// Block for target_object_key_format.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TargetObjectKeyFormat block(s) allowed")]
    public List<AwsS3BucketLoggingTargetObjectKeyFormatBlock>? TargetObjectKeyFormat
    {
        get => GetProperty<List<AwsS3BucketLoggingTargetObjectKeyFormatBlock>>("target_object_key_format");
        set => this.WithProperty("target_object_key_format", value);
    }

}
