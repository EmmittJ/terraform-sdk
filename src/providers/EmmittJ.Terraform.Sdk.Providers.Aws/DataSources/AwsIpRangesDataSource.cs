using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_ip_ranges.
/// </summary>
public class AwsIpRangesDataSource : TerraformDataSource
{
    public AwsIpRangesDataSource(string name) : base("aws_ip_ranges", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The regions attribute.
    /// </summary>
    [TerraformPropertyName("regions")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? Regions { get; set; }

    /// <summary>
    /// The services attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Services is required")]
    [TerraformPropertyName("services")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformSet<string> Services { get; set; }

    /// <summary>
    /// The url attribute.
    /// </summary>
    [TerraformPropertyName("url")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Url { get; set; }

    /// <summary>
    /// The cidr_blocks attribute.
    /// </summary>
    [TerraformPropertyName("cidr_blocks")]
    // Output-only attribute - read-only reference
    public TerraformList<string> CidrBlocks => new TerraformReference(this, "cidr_blocks");

    /// <summary>
    /// The create_date attribute.
    /// </summary>
    [TerraformPropertyName("create_date")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CreateDate => new TerraformReference(this, "create_date");

    /// <summary>
    /// The ipv6_cidr_blocks attribute.
    /// </summary>
    [TerraformPropertyName("ipv6_cidr_blocks")]
    // Output-only attribute - read-only reference
    public TerraformList<string> Ipv6CidrBlocks => new TerraformReference(this, "ipv6_cidr_blocks");

    /// <summary>
    /// The sync_token attribute.
    /// </summary>
    [TerraformPropertyName("sync_token")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> SyncToken => new TerraformReference(this, "sync_token");

}
