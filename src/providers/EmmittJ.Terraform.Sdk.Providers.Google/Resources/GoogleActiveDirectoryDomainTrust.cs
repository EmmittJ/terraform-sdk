using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleActiveDirectoryDomainTrustTimeoutsBlock : TerraformBlockBase
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

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_active_directory_domain_trust resource.
/// </summary>
public partial class GoogleActiveDirectoryDomainTrust : TerraformResource
{
    public GoogleActiveDirectoryDomainTrust(string name) : base("google_active_directory_domain_trust", name)
    {
    }

    /// <summary>
    /// The fully qualified domain name. e.g. mydomain.myorganization.com, with the restrictions
    /// of https://cloud.google.com/managed-microsoft-ad/reference/rest/v1/projects.locations.global.domains.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Domain is required")]
    [TerraformProperty("domain")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Domain { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Project { get; set; }

    /// <summary>
    /// Whether the trusted side has forest/domain wide access or selective access to an approved set of resources.
    /// </summary>
    [TerraformProperty("selective_authentication")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? SelectiveAuthentication { get; set; }

    /// <summary>
    /// The target DNS server IP addresses which can resolve the remote domain involved in the trust.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetDnsIpAddresses is required")]
    [TerraformProperty("target_dns_ip_addresses")]
    // Required argument - source generator will implement get/set
    public required TerraformSet<string> TargetDnsIpAddresses { get; set; }

    /// <summary>
    /// The fully qualified target domain name which will be in trust with the current domain.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetDomainName is required")]
    [TerraformProperty("target_domain_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> TargetDomainName { get; set; }

    /// <summary>
    /// The trust direction, which decides if the current domain is trusted, trusting, or both. Possible values: [&amp;quot;INBOUND&amp;quot;, &amp;quot;OUTBOUND&amp;quot;, &amp;quot;BIDIRECTIONAL&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TrustDirection is required")]
    [TerraformProperty("trust_direction")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> TrustDirection { get; set; }

    /// <summary>
    /// The trust secret used for the handshake with the target domain. This will not be stored.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TrustHandshakeSecret is required")]
    [TerraformProperty("trust_handshake_secret")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> TrustHandshakeSecret { get; set; }

    /// <summary>
    /// The type of trust represented by the trust resource. Possible values: [&amp;quot;FOREST&amp;quot;, &amp;quot;EXTERNAL&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TrustType is required")]
    [TerraformProperty("trust_type")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> TrustType { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<GoogleActiveDirectoryDomainTrustTimeoutsBlock>? Timeouts { get; set; }

}
