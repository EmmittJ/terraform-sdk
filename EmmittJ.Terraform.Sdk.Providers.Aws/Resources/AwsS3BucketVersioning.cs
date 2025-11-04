using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_s3_bucket_versioning resource.
/// </summary>
public class AwsS3BucketVersioning : TerraformResource
{
    public AwsS3BucketVersioning(string name) : base("aws_s3_bucket_versioning", name)
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
    /// The mfa attribute.
    /// </summary>
    public string? Mfa
    {
        get => GetProperty<TerraformLiteralProperty<string>>("mfa")?.Value;
        set => this.WithProperty("mfa", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
