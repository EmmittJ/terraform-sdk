using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_ip_ranges.
/// </summary>
public partial class AwsIpRangesDataSource : TerraformDataSource
{
    public AwsIpRangesDataSource(string name) : base("aws_ip_ranges", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The regions attribute.
    /// </summary>
    [TerraformProperty("regions")]
    // Optional argument - source generator will implement get/set
    public TerraformSet<string>? Regions { get; set; }

    /// <summary>
    /// The services attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Services is required")]
    [TerraformProperty("services")]
    // Required argument - source generator will implement get/set
    public required TerraformSet<string> Services { get; set; }

    /// <summary>
    /// The url attribute.
    /// </summary>
    [TerraformProperty("url")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Url { get; set; }

    /// <summary>
    /// The cidr_blocks attribute.
    /// </summary>
    [TerraformProperty("cidr_blocks")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<string> CidrBlocks { get; }

    /// <summary>
    /// The create_date attribute.
    /// </summary>
    [TerraformProperty("create_date")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> CreateDate { get; }

    /// <summary>
    /// The ipv6_cidr_blocks attribute.
    /// </summary>
    [TerraformProperty("ipv6_cidr_blocks")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<string> Ipv6CidrBlocks { get; }

    /// <summary>
    /// The sync_token attribute.
    /// </summary>
    [TerraformProperty("sync_token")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> SyncToken { get; }

}
