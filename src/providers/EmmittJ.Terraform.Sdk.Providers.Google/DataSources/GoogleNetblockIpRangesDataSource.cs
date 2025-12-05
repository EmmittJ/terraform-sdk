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
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The range_type attribute.
    /// </summary>
    public TerraformValue<string>? RangeType
    {
        get => GetArgument<TerraformValue<string>>("range_type");
        set => SetArgument("range_type", value);
    }

    /// <summary>
    /// The cidr_blocks attribute.
    /// </summary>
    public TerraformList<string> CidrBlocks
        => CreateReference("cidr_blocks");

    /// <summary>
    /// The cidr_blocks_ipv4 attribute.
    /// </summary>
    public TerraformList<string> CidrBlocksIpv4
        => CreateReference("cidr_blocks_ipv4");

    /// <summary>
    /// The cidr_blocks_ipv6 attribute.
    /// </summary>
    public TerraformList<string> CidrBlocksIpv6
        => CreateReference("cidr_blocks_ipv6");

}
