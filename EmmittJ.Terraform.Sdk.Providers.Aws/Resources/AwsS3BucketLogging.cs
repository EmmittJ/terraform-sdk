using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_s3_bucket_logging resource.
/// </summary>
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
    public string? Bucket
    {
        get => GetProperty<TerraformLiteralProperty<string>>("bucket")?.Value;
        set => this.WithProperty("bucket", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The expected_bucket_owner attribute.
    /// </summary>
    public string? ExpectedBucketOwner
    {
        get => GetProperty<TerraformLiteralProperty<string>>("expected_bucket_owner")?.Value;
        set => this.WithProperty("expected_bucket_owner", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The target_bucket attribute.
    /// </summary>
    public string? TargetBucket
    {
        get => GetProperty<TerraformLiteralProperty<string>>("target_bucket")?.Value;
        set => this.WithProperty("target_bucket", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The target_prefix attribute.
    /// </summary>
    public string? TargetPrefix
    {
        get => GetProperty<TerraformLiteralProperty<string>>("target_prefix")?.Value;
        set => this.WithProperty("target_prefix", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
