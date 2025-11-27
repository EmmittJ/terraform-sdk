using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_s3_account_public_access_block Terraform resource.
/// Manages a aws_s3_account_public_access_block resource.
/// </summary>
public partial class AwsS3AccountPublicAccessBlock(string name) : TerraformResource("aws_s3_account_public_access_block", name)
{
    /// <summary>
    /// The account_id attribute.
    /// </summary>
    public TerraformValue<string> AccountId
    {
        get => new TerraformReference<string>(this, "account_id");
        set => SetArgument("account_id", value);
    }

    /// <summary>
    /// The block_public_acls attribute.
    /// </summary>
    public TerraformValue<bool>? BlockPublicAcls
    {
        get => new TerraformReference<bool>(this, "block_public_acls");
        set => SetArgument("block_public_acls", value);
    }

    /// <summary>
    /// The block_public_policy attribute.
    /// </summary>
    public TerraformValue<bool>? BlockPublicPolicy
    {
        get => new TerraformReference<bool>(this, "block_public_policy");
        set => SetArgument("block_public_policy", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The ignore_public_acls attribute.
    /// </summary>
    public TerraformValue<bool>? IgnorePublicAcls
    {
        get => new TerraformReference<bool>(this, "ignore_public_acls");
        set => SetArgument("ignore_public_acls", value);
    }

    /// <summary>
    /// The restrict_public_buckets attribute.
    /// </summary>
    public TerraformValue<bool>? RestrictPublicBuckets
    {
        get => new TerraformReference<bool>(this, "restrict_public_buckets");
        set => SetArgument("restrict_public_buckets", value);
    }

}
