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
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "comments").ResolveNodes(ctx));
        set => SetArgument("comments", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The iam_arns attribute.
    /// </summary>
    public TerraformSet<string> IamArns
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "iam_arns").ResolveNodes(ctx));
    }

    /// <summary>
    /// The ids attribute.
    /// </summary>
    public TerraformSet<string> Ids
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "ids").ResolveNodes(ctx));
    }

    /// <summary>
    /// The s3_canonical_user_ids attribute.
    /// </summary>
    public TerraformSet<string> S3CanonicalUserIds
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "s3_canonical_user_ids").ResolveNodes(ctx));
    }

}
