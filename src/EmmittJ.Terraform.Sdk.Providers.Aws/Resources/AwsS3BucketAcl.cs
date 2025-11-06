using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_s3_bucket_acl resource.
/// </summary>
public class AwsS3BucketAcl : TerraformResource
{
    public AwsS3BucketAcl(string name) : base("aws_s3_bucket_acl", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The acl attribute.
    /// </summary>
    public string? Acl
    {
        get => GetProperty<TerraformLiteralProperty<string>>("acl")?.Value;
        set => this.WithProperty("acl", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
