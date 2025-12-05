using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_cloudfront_origin_access_identities Terraform data source.
/// Retrieves information about a aws_cloudfront_origin_access_identities.
/// </summary>
public partial class AwsCloudfrontOriginAccessIdentitiesDataSource(string name) : TerraformDataSource("aws_cloudfront_origin_access_identities", name)
{
    /// <summary>
    /// The comments attribute.
    /// </summary>
    public TerraformSet<string>? Comments
    {
        get => GetArgument<TerraformSet<string>>("comments");
        set => SetArgument("comments", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The iam_arns attribute.
    /// </summary>
    public TerraformSet<string> IamArns
        => CreateReference("iam_arns");

    /// <summary>
    /// The ids attribute.
    /// </summary>
    public TerraformSet<string> Ids
        => CreateReference("ids");

    /// <summary>
    /// The s3_canonical_user_ids attribute.
    /// </summary>
    public TerraformSet<string> S3CanonicalUserIds
        => CreateReference("s3_canonical_user_ids");

}
