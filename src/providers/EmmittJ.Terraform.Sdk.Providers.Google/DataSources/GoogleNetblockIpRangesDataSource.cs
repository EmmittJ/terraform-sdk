using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Represents a google_netblock_ip_ranges Terraform data source.
/// Retrieves information about a google_netblock_ip_ranges.
/// </summary>
public partial class GoogleNetblockIpRangesDataSource(string name) : TerraformDataSource("google_netblock_ip_ranges", name)
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
    /// The range_type attribute.
    /// </summary>
    public TerraformValue<string>? RangeType
    {
        get => new TerraformReference<string>(this, "range_type");
        set => SetArgument("range_type", value);
    }

    /// <summary>
    /// The cidr_blocks attribute.
    /// </summary>
    public TerraformList<string> CidrBlocks
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "cidr_blocks").ResolveNodes(ctx));
    }

    /// <summary>
    /// The cidr_blocks_ipv4 attribute.
    /// </summary>
    public TerraformList<string> CidrBlocksIpv4
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "cidr_blocks_ipv4").ResolveNodes(ctx));
    }

    /// <summary>
    /// The cidr_blocks_ipv6 attribute.
    /// </summary>
    public TerraformList<string> CidrBlocksIpv6
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "cidr_blocks_ipv6").ResolveNodes(ctx));
    }

}
