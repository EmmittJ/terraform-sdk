using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleComputePublicAdvertisedPrefixTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

}

/// <summary>
/// Manages a google_compute_public_advertised_prefix resource.
/// </summary>
public partial class GoogleComputePublicAdvertisedPrefix : TerraformResource
{
    public GoogleComputePublicAdvertisedPrefix(string name) : base("google_compute_public_advertised_prefix", name)
    {
    }

    /// <summary>
    /// An optional description of this resource.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The IPv4 address to be used for reverse DNS verification.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DnsVerificationIp is required")]
    [TerraformProperty("dns_verification_ip")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> DnsVerificationIp { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The address range, in CIDR format, represented by this public advertised prefix.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IpCidrRange is required")]
    [TerraformProperty("ip_cidr_range")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> IpCidrRange { get; set; }

    /// <summary>
    /// Name of the resource. The name must be 1-63 characters long, and
    /// comply with RFC1035. Specifically, the name must be 1-63 characters
    /// long and match the regular expression &#39;[a-z]([-a-z0-9]*[a-z0-9])?&#39;
    /// which means the first character must be a lowercase letter, and all
    /// following characters must be a dash, lowercase letter, or digit,
    /// except the last character, which cannot be a dash.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Specifies how child public delegated prefix will be scoped. pdpScope
    /// must be one of: GLOBAL, REGIONAL
    /// * REGIONAL: The public delegated prefix is regional only. The
    /// provisioning will take a few minutes.
    /// * GLOBAL: The public delegated prefix is global only. The provisioning
    /// will take ~4 weeks. Possible values: [&amp;quot;GLOBAL&amp;quot;, &amp;quot;REGIONAL&amp;quot;]
    /// </summary>
    [TerraformProperty("pdp_scope")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? PdpScope { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Project { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<GoogleComputePublicAdvertisedPrefixTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The self_link attribute.
    /// </summary>
    [TerraformProperty("self_link")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> SelfLink { get; }

    /// <summary>
    /// Output Only. The shared secret to be used for reverse DNS verification.
    /// </summary>
    [TerraformProperty("shared_secret")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> SharedSecret { get; }

}
