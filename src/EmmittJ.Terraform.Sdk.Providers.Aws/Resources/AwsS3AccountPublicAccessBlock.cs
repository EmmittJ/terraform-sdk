using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_s3_account_public_access_block resource.
/// </summary>
public class AwsS3AccountPublicAccessBlock : TerraformResource
{
    public AwsS3AccountPublicAccessBlock(string name) : base("aws_s3_account_public_access_block", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The account_id attribute.
    /// </summary>
    public TerraformProperty<string>? AccountId
    {
        get => GetProperty<TerraformProperty<string>>("account_id");
        set => this.WithProperty("account_id", value);
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
    /// The restrict_public_buckets attribute.
    /// </summary>
    public TerraformProperty<bool>? RestrictPublicBuckets
    {
        get => GetProperty<TerraformProperty<bool>>("restrict_public_buckets");
        set => this.WithProperty("restrict_public_buckets", value);
    }

}
