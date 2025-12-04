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
        get => GetArgument<TerraformValue<string>>("account_id") ?? AsReference("account_id");
        set => SetArgument("account_id", value);
    }

    /// <summary>
    /// The block_public_acls attribute.
    /// </summary>
    public TerraformValue<bool>? BlockPublicAcls
    {
        get => GetArgument<TerraformValue<bool>>("block_public_acls");
        set => SetArgument("block_public_acls", value);
    }

    /// <summary>
    /// The block_public_policy attribute.
    /// </summary>
    public TerraformValue<bool>? BlockPublicPolicy
    {
        get => GetArgument<TerraformValue<bool>>("block_public_policy");
        set => SetArgument("block_public_policy", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The ignore_public_acls attribute.
    /// </summary>
    public TerraformValue<bool>? IgnorePublicAcls
    {
        get => GetArgument<TerraformValue<bool>>("ignore_public_acls");
        set => SetArgument("ignore_public_acls", value);
    }

    /// <summary>
    /// The restrict_public_buckets attribute.
    /// </summary>
    public TerraformValue<bool>? RestrictPublicBuckets
    {
        get => GetArgument<TerraformValue<bool>>("restrict_public_buckets");
        set => SetArgument("restrict_public_buckets", value);
    }

}
