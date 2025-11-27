using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_ip_ranges Terraform data source.
/// Retrieves information about a aws_ip_ranges.
/// </summary>
public partial class AwsIpRangesDataSource(string name) : TerraformDataSource("aws_ip_ranges", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The regions attribute.
    /// </summary>
    public TerraformSet<string>? Regions
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "regions").ResolveNodes(ctx));
        set => SetArgument("regions", value);
    }

    /// <summary>
    /// The services attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Services is required")]
    public required TerraformSet<string> Services
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "services").ResolveNodes(ctx));
        set => SetArgument("services", value);
    }

    /// <summary>
    /// The url attribute.
    /// </summary>
    public TerraformValue<string>? Url
    {
        get => new TerraformReference<string>(this, "url");
        set => SetArgument("url", value);
    }

    /// <summary>
    /// The cidr_blocks attribute.
    /// </summary>
    public TerraformList<string> CidrBlocks
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "cidr_blocks").ResolveNodes(ctx));
    }

    /// <summary>
    /// The create_date attribute.
    /// </summary>
    public TerraformValue<string> CreateDate
    {
        get => new TerraformReference<string>(this, "create_date");
    }

    /// <summary>
    /// The ipv6_cidr_blocks attribute.
    /// </summary>
    public TerraformList<string> Ipv6CidrBlocks
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "ipv6_cidr_blocks").ResolveNodes(ctx));
    }

    /// <summary>
    /// The sync_token attribute.
    /// </summary>
    public TerraformValue<double> SyncToken
    {
        get => new TerraformReference<double>(this, "sync_token");
    }

}
