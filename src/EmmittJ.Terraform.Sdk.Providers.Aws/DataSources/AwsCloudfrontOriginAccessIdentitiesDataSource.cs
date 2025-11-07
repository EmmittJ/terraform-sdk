using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_cloudfront_origin_access_identities.
/// </summary>
public class AwsCloudfrontOriginAccessIdentitiesDataSource : TerraformDataSource
{
    public AwsCloudfrontOriginAccessIdentitiesDataSource(string name) : base("aws_cloudfront_origin_access_identities", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("iam_arns");
        this.DeclareOutput("ids");
        this.DeclareOutput("s3_canonical_user_ids");
    }

    /// <summary>
    /// The comments attribute.
    /// </summary>
    public TerraformProperty<HashSet<string>>? Comments
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("comments");
        set => this.WithProperty("comments", value);
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
    /// The iam_arns attribute.
    /// </summary>
    public TerraformExpression IamArns => this["iam_arns"];

    /// <summary>
    /// The ids attribute.
    /// </summary>
    public TerraformExpression Ids => this["ids"];

    /// <summary>
    /// The s3_canonical_user_ids attribute.
    /// </summary>
    public TerraformExpression S3CanonicalUserIds => this["s3_canonical_user_ids"];

}
