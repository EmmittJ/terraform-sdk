using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_netblock_ip_ranges.
/// </summary>
public class GoogleNetblockIpRangesDataSource : TerraformDataSource
{
    public GoogleNetblockIpRangesDataSource(string name) : base("google_netblock_ip_ranges", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The range_type attribute.
    /// </summary>
    [TerraformPropertyName("range_type")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? RangeType { get; set; }

    /// <summary>
    /// The cidr_blocks attribute.
    /// </summary>
    [TerraformPropertyName("cidr_blocks")]
    // Output-only attribute - read-only reference
    public TerraformList<string> CidrBlocks => new TerraformReference(this, "cidr_blocks");

    /// <summary>
    /// The cidr_blocks_ipv4 attribute.
    /// </summary>
    [TerraformPropertyName("cidr_blocks_ipv4")]
    // Output-only attribute - read-only reference
    public TerraformList<string> CidrBlocksIpv4 => new TerraformReference(this, "cidr_blocks_ipv4");

    /// <summary>
    /// The cidr_blocks_ipv6 attribute.
    /// </summary>
    [TerraformPropertyName("cidr_blocks_ipv6")]
    // Output-only attribute - read-only reference
    public TerraformList<string> CidrBlocksIpv6 => new TerraformReference(this, "cidr_blocks_ipv6");

}
