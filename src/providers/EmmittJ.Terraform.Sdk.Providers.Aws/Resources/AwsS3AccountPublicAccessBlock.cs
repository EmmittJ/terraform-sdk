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
        SetOutput("account_id");
        SetOutput("block_public_acls");
        SetOutput("block_public_policy");
        SetOutput("id");
        SetOutput("ignore_public_acls");
        SetOutput("restrict_public_buckets");
    }

    /// <summary>
    /// The account_id attribute.
    /// </summary>
    public TerraformProperty<string> AccountId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("account_id");
        set => SetProperty("account_id", value);
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
    /// The restrict_public_buckets attribute.
    /// </summary>
    public TerraformProperty<bool> RestrictPublicBuckets
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("restrict_public_buckets");
        set => SetProperty("restrict_public_buckets", value);
    }

}
