using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_s3_bucket_public_access_block resource.
/// </summary>
public class AwsS3BucketPublicAccessBlock : TerraformResource
{
    public AwsS3BucketPublicAccessBlock(string name) : base("aws_s3_bucket_public_access_block", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The block_public_acls attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? BlockPublicAcls
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("block_public_acls");
        set => this.WithProperty("block_public_acls", value);
    }

    /// <summary>
    /// The block_public_policy attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? BlockPublicPolicy
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("block_public_policy");
        set => this.WithProperty("block_public_policy", value);
    }

    /// <summary>
    /// The bucket attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Bucket
    {
        get => GetProperty<TerraformLiteralProperty<string>>("bucket");
        set => this.WithProperty("bucket", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The ignore_public_acls attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? IgnorePublicAcls
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("ignore_public_acls");
        set => this.WithProperty("ignore_public_acls", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformLiteralProperty<string>? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The restrict_public_buckets attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? RestrictPublicBuckets
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("restrict_public_buckets");
        set => this.WithProperty("restrict_public_buckets", value);
    }

    /// <summary>
    /// The skip_destroy attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? SkipDestroy
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("skip_destroy");
        set => this.WithProperty("skip_destroy", value);
    }

}
