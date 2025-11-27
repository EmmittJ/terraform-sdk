using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_cloudfront_distribution Terraform data source.
/// Retrieves information about a aws_cloudfront_distribution.
/// </summary>
public partial class AwsCloudfrontDistributionDataSource(string name) : TerraformDataSource("aws_cloudfront_distribution", name)
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
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The aliases attribute.
    /// </summary>
    public TerraformSet<string> Aliases
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "aliases").ResolveNodes(ctx));
    }

    /// <summary>
    /// The anycast_ip_list_id attribute.
    /// </summary>
    public TerraformValue<string> AnycastIpListId
    {
        get => new TerraformReference<string>(this, "anycast_ip_list_id");
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    public TerraformValue<string> DomainName
    {
        get => new TerraformReference<string>(this, "domain_name");
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformValue<bool> Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
    }

    /// <summary>
    /// The etag attribute.
    /// </summary>
    public TerraformValue<string> Etag
    {
        get => new TerraformReference<string>(this, "etag");
    }

    /// <summary>
    /// The hosted_zone_id attribute.
    /// </summary>
    public TerraformValue<string> HostedZoneId
    {
        get => new TerraformReference<string>(this, "hosted_zone_id");
    }

    /// <summary>
    /// The in_progress_validation_batches attribute.
    /// </summary>
    public TerraformValue<double> InProgressValidationBatches
    {
        get => new TerraformReference<double>(this, "in_progress_validation_batches");
    }

    /// <summary>
    /// The last_modified_time attribute.
    /// </summary>
    public TerraformValue<string> LastModifiedTime
    {
        get => new TerraformReference<string>(this, "last_modified_time");
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string> Status
    {
        get => new TerraformReference<string>(this, "status");
    }

    /// <summary>
    /// The web_acl_id attribute.
    /// </summary>
    public TerraformValue<string> WebAclId
    {
        get => new TerraformReference<string>(this, "web_acl_id");
    }

}
