using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_cloudfront_origin_access_identity resource.
/// </summary>
public class AwsCloudfrontOriginAccessIdentity : TerraformResource
{
    public AwsCloudfrontOriginAccessIdentity(string name) : base("aws_cloudfront_origin_access_identity", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("caller_reference");
        this.DeclareOutput("cloudfront_access_identity_path");
        this.DeclareOutput("etag");
        this.DeclareOutput("iam_arn");
        this.DeclareOutput("s3_canonical_user_id");
    }

    /// <summary>
    /// The comment attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Comment
    {
        get => GetProperty<TerraformLiteralProperty<string>>("comment");
        set => this.WithProperty("comment", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The caller_reference attribute.
    /// </summary>
    public TerraformExpression CallerReference => this["caller_reference"];

    /// <summary>
    /// The cloudfront_access_identity_path attribute.
    /// </summary>
    public TerraformExpression CloudfrontAccessIdentityPath => this["cloudfront_access_identity_path"];

    /// <summary>
    /// The etag attribute.
    /// </summary>
    public TerraformExpression Etag => this["etag"];

    /// <summary>
    /// The iam_arn attribute.
    /// </summary>
    public TerraformExpression IamArn => this["iam_arn"];

    /// <summary>
    /// The s3_canonical_user_id attribute.
    /// </summary>
    public TerraformExpression S3CanonicalUserId => this["s3_canonical_user_id"];

}
