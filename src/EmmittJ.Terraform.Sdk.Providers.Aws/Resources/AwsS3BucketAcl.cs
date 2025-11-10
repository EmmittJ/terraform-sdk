using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for access_control_policy in .
/// Nesting mode: list
/// </summary>
public class AwsS3BucketAclAccessControlPolicyBlock : TerraformBlock
{
}

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
    public TerraformProperty<string>? Acl
    {
        get => GetProperty<TerraformProperty<string>>("acl");
        set => this.WithProperty("acl", value);
    }

    /// <summary>
    /// The bucket attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Bucket is required")]
    public required TerraformProperty<string> Bucket
    {
        get => GetProperty<TerraformProperty<string>>("bucket");
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
    /// Block for access_control_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AccessControlPolicy block(s) allowed")]
    public List<AwsS3BucketAclAccessControlPolicyBlock>? AccessControlPolicy
    {
        get => GetProperty<List<AwsS3BucketAclAccessControlPolicyBlock>>("access_control_policy");
        set => this.WithProperty("access_control_policy", value);
    }

}
