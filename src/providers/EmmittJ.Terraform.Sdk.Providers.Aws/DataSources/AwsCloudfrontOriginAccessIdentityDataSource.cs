using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_cloudfront_origin_access_identity.
/// </summary>
public class AwsCloudfrontOriginAccessIdentityDataSource : TerraformDataSource
{
    public AwsCloudfrontOriginAccessIdentityDataSource(string name) : base("aws_cloudfront_origin_access_identity", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("arn");
        this.WithOutput("caller_reference");
        this.WithOutput("cloudfront_access_identity_path");
        this.WithOutput("comment");
        this.WithOutput("etag");
        this.WithOutput("iam_arn");
        this.WithOutput("s3_canonical_user_id");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    public required TerraformProperty<string> Id
    {
        get => GetRequiredProperty<TerraformProperty<string>>("id");
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
    /// The comment attribute.
    /// </summary>
    public TerraformExpression Comment => this["comment"];

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
