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
        SetOutput("block_public_acls");
        SetOutput("block_public_policy");
        SetOutput("bucket");
        SetOutput("id");
        SetOutput("ignore_public_acls");
        SetOutput("region");
        SetOutput("restrict_public_buckets");
        SetOutput("skip_destroy");
    }

    /// <summary>
    /// The block_public_acls attribute.
    /// </summary>
    public TerraformProperty<bool> BlockPublicAcls
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("block_public_acls");
        set => SetProperty("block_public_acls", value);
    }

    /// <summary>
    /// The block_public_policy attribute.
    /// </summary>
    public TerraformProperty<bool> BlockPublicPolicy
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("block_public_policy");
        set => SetProperty("block_public_policy", value);
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
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The ignore_public_acls attribute.
    /// </summary>
    public TerraformProperty<bool> IgnorePublicAcls
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("ignore_public_acls");
        set => SetProperty("ignore_public_acls", value);
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
    /// The restrict_public_buckets attribute.
    /// </summary>
    public TerraformProperty<bool> RestrictPublicBuckets
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("restrict_public_buckets");
        set => SetProperty("restrict_public_buckets", value);
    }

    /// <summary>
    /// The skip_destroy attribute.
    /// </summary>
    public TerraformProperty<bool> SkipDestroy
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("skip_destroy");
        set => SetProperty("skip_destroy", value);
    }

}
