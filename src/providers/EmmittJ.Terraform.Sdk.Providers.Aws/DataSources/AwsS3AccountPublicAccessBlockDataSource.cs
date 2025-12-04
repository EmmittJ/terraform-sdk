using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_s3_account_public_access_block Terraform data source.
/// Retrieves information about a aws_s3_account_public_access_block.
/// </summary>
public partial class AwsS3AccountPublicAccessBlockDataSource(string name) : TerraformDataSource("aws_s3_account_public_access_block", name)
{
    /// <summary>
    /// The account_id attribute.
    /// </summary>
    public TerraformValue<string>? AccountId
    {
        get => GetArgument<TerraformValue<string>>("account_id");
        set => SetArgument("account_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The block_public_acls attribute.
    /// </summary>
    public TerraformValue<bool> BlockPublicAcls
        => AsReference("block_public_acls");

    /// <summary>
    /// The block_public_policy attribute.
    /// </summary>
    public TerraformValue<bool> BlockPublicPolicy
        => AsReference("block_public_policy");

    /// <summary>
    /// The ignore_public_acls attribute.
    /// </summary>
    public TerraformValue<bool> IgnorePublicAcls
        => AsReference("ignore_public_acls");

    /// <summary>
    /// The restrict_public_buckets attribute.
    /// </summary>
    public TerraformValue<bool> RestrictPublicBuckets
        => AsReference("restrict_public_buckets");

}
