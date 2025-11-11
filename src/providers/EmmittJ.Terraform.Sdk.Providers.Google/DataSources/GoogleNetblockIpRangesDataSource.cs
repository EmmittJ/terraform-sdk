using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_netblock_ip_ranges.
/// </summary>
public partial class GoogleNetblockIpRangesDataSource : TerraformDataSource
{
    public GoogleNetblockIpRangesDataSource(string name) : base("google_netblock_ip_ranges", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The range_type attribute.
    /// </summary>
    [TerraformProperty("range_type")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? RangeType { get; set; }

    /// <summary>
    /// The cidr_blocks attribute.
    /// </summary>
    [TerraformProperty("cidr_blocks")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<string> CidrBlocks { get; }

    /// <summary>
    /// The cidr_blocks_ipv4 attribute.
    /// </summary>
    [TerraformProperty("cidr_blocks_ipv4")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<string> CidrBlocksIpv4 { get; }

    /// <summary>
    /// The cidr_blocks_ipv6 attribute.
    /// </summary>
    [TerraformProperty("cidr_blocks_ipv6")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<string> CidrBlocksIpv6 { get; }

}
