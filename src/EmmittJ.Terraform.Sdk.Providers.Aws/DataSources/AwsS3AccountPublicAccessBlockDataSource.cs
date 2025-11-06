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
        this.DeclareOutput("block_public_acls");
        this.DeclareOutput("block_public_policy");
        this.DeclareOutput("ignore_public_acls");
        this.DeclareOutput("restrict_public_buckets");
    }

    /// <summary>
    /// The account_id attribute.
    /// </summary>
    public string? AccountId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("account_id")?.Value;
        set => this.WithProperty("account_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
