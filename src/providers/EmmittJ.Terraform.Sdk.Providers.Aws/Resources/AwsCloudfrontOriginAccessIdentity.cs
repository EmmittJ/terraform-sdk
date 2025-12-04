using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_cloudfront_origin_access_identity Terraform resource.
/// Manages a aws_cloudfront_origin_access_identity resource.
/// </summary>
public partial class AwsCloudfrontOriginAccessIdentity(string name) : TerraformResource("aws_cloudfront_origin_access_identity", name)
{
    /// <summary>
    /// The comment attribute.
    /// </summary>
    public TerraformValue<string>? Comment
    {
        get => GetArgument<TerraformValue<string>>("comment");
        set => SetArgument("comment", value);
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
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The caller_reference attribute.
    /// </summary>
    public TerraformValue<string> CallerReference
        => AsReference("caller_reference");

    /// <summary>
    /// The cloudfront_access_identity_path attribute.
    /// </summary>
    public TerraformValue<string> CloudfrontAccessIdentityPath
        => AsReference("cloudfront_access_identity_path");

    /// <summary>
    /// The etag attribute.
    /// </summary>
    public TerraformValue<string> Etag
        => AsReference("etag");

    /// <summary>
    /// The iam_arn attribute.
    /// </summary>
    public TerraformValue<string> IamArn
        => AsReference("iam_arn");

    /// <summary>
    /// The s3_canonical_user_id attribute.
    /// </summary>
    public TerraformValue<string> S3CanonicalUserId
        => AsReference("s3_canonical_user_id");

}
