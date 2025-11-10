using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_s3_account_public_access_block.
/// </summary>
public class AwsS3AccountPublicAccessBlockDataSource : TerraformDataSource
{
    public AwsS3AccountPublicAccessBlockDataSource(string name) : base("aws_s3_account_public_access_block", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutputlock_public_acls");
        this.WithOutputlock_public_policy");
        this.WithOutputgnore_public_acls");
        this.WithOutputestrict_public_buckets");
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
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The block_public_acls attribute.
    /// </summary>
    public TerraformExpression BlockPublicAcls => this["block_public_acls"];

    /// <summary>
    /// The block_public_policy attribute.
    /// </summary>
    public TerraformExpression BlockPublicPolicy => this["block_public_policy"];

    /// <summary>
    /// The ignore_public_acls attribute.
    /// </summary>
    public TerraformExpression IgnorePublicAcls => this["ignore_public_acls"];

    /// <summary>
    /// The restrict_public_buckets attribute.
    /// </summary>
    public TerraformExpression RestrictPublicBuckets => this["restrict_public_buckets"];

}
