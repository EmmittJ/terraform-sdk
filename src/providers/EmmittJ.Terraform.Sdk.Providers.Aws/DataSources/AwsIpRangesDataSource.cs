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
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The regions attribute.
    /// </summary>
    [TerraformPropertyName("regions")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? Regions { get; set; }

    /// <summary>
    /// The services attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Services is required")]
    [TerraformPropertyName("services")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformProperty<HashSet<TerraformProperty<string>>>? Services { get; set; }

    /// <summary>
    /// The url attribute.
    /// </summary>
    [TerraformPropertyName("url")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Url { get; set; }

    /// <summary>
    /// The cidr_blocks attribute.
    /// </summary>
    [TerraformPropertyName("cidr_blocks")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> CidrBlocks => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "cidr_blocks");

    /// <summary>
    /// The create_date attribute.
    /// </summary>
    [TerraformPropertyName("create_date")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreateDate => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "create_date");

    /// <summary>
    /// The ipv6_cidr_blocks attribute.
    /// </summary>
    [TerraformPropertyName("ipv6_cidr_blocks")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> Ipv6CidrBlocks => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "ipv6_cidr_blocks");

    /// <summary>
    /// The sync_token attribute.
    /// </summary>
    [TerraformPropertyName("sync_token")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> SyncToken => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "sync_token");

}
