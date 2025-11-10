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
        SetOutput("block_public_acls");
        SetOutput("block_public_policy");
        SetOutput("ignore_public_acls");
        SetOutput("restrict_public_buckets");
        SetOutput("account_id");
        SetOutput("id");
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
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
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
