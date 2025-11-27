using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_cloudfront_origin_access_identity Terraform data source.
/// Retrieves information about a aws_cloudfront_origin_access_identity.
/// </summary>
public partial class AwsCloudfrontOriginAccessIdentityDataSource(string name) : TerraformDataSource("aws_cloudfront_origin_access_identity", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    public required TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The caller_reference attribute.
    /// </summary>
    public TerraformValue<string> CallerReference
    {
        get => new TerraformReference<string>(this, "caller_reference");
    }

    /// <summary>
    /// The cloudfront_access_identity_path attribute.
    /// </summary>
    public TerraformValue<string> CloudfrontAccessIdentityPath
    {
        get => new TerraformReference<string>(this, "cloudfront_access_identity_path");
    }

    /// <summary>
    /// The comment attribute.
    /// </summary>
    public TerraformValue<string> Comment
    {
        get => new TerraformReference<string>(this, "comment");
    }

    /// <summary>
    /// The etag attribute.
    /// </summary>
    public TerraformValue<string> Etag
    {
        get => new TerraformReference<string>(this, "etag");
    }

    /// <summary>
    /// The iam_arn attribute.
    /// </summary>
    public TerraformValue<string> IamArn
    {
        get => new TerraformReference<string>(this, "iam_arn");
    }

    /// <summary>
    /// The s3_canonical_user_id attribute.
    /// </summary>
    public TerraformValue<string> S3CanonicalUserId
    {
        get => new TerraformReference<string>(this, "s3_canonical_user_id");
    }

}
