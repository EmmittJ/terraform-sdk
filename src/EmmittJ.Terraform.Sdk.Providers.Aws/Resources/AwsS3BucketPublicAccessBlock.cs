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
    public TerraformProperty<bool>? BlockPublicAcls
    {
        get => GetProperty<TerraformProperty<bool>>("block_public_acls");
        set => this.WithProperty("block_public_acls", value);
    }

    /// <summary>
    /// The block_public_policy attribute.
    /// </summary>
    public TerraformProperty<bool>? BlockPublicPolicy
    {
        get => GetProperty<TerraformProperty<bool>>("block_public_policy");
        set => this.WithProperty("block_public_policy", value);
    }

    /// <summary>
    /// The bucket attribute.
    /// </summary>
    public TerraformProperty<string>? Bucket
    {
        get => GetProperty<TerraformProperty<string>>("bucket");
        set => this.WithProperty("bucket", value);
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
    /// The ignore_public_acls attribute.
    /// </summary>
    public TerraformProperty<bool>? IgnorePublicAcls
    {
        get => GetProperty<TerraformProperty<bool>>("ignore_public_acls");
        set => this.WithProperty("ignore_public_acls", value);
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
    /// The restrict_public_buckets attribute.
    /// </summary>
    public TerraformProperty<bool>? RestrictPublicBuckets
    {
        get => GetProperty<TerraformProperty<bool>>("restrict_public_buckets");
        set => this.WithProperty("restrict_public_buckets", value);
    }

    /// <summary>
    /// The skip_destroy attribute.
    /// </summary>
    public TerraformProperty<bool>? SkipDestroy
    {
        get => GetProperty<TerraformProperty<bool>>("skip_destroy");
        set => this.WithProperty("skip_destroy", value);
    }

}
