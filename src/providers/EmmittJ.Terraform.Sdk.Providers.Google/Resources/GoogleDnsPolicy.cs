using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for alternative_name_server_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleDnsPolicyAlternativeNameServerConfigBlock : TerraformBlockBase
{
}

/// <summary>
/// Block type for dns64_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleDnsPolicyDns64ConfigBlock : TerraformBlockBase
{
}

/// <summary>
/// Block type for networks in .
/// Nesting mode: set
/// </summary>
public partial class GoogleDnsPolicyNetworksBlock : TerraformBlockBase
{
    /// <summary>
    /// The id or fully qualified URL of the VPC network to forward queries to.
    /// This should be formatted like &#39;projects/{project}/global/networks/{network}&#39; or
    /// &#39;https://www.googleapis.com/compute/v1/projects/{project}/global/networks/{network}&#39;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetworkUrl is required")]
    [TerraformProperty("network_url")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> NetworkUrl { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleDnsPolicyTimeoutsBlock : TerraformBlockBase
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
/// Manages a google_dns_policy resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleDnsPolicy : TerraformResource
{
    public GoogleDnsPolicy(string name) : base("google_dns_policy", name)
    {
    }

    /// <summary>
    /// A textual description field. Defaults to &#39;Managed by Terraform&#39;.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// Allows networks bound to this policy to receive DNS queries sent
    /// by VMs or applications over VPN connections. When enabled, a
    /// virtual IP address will be allocated from each of the sub-networks
    /// that are bound to this policy.
    /// </summary>
    [TerraformProperty("enable_inbound_forwarding")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? EnableInboundForwarding { get; set; }

    /// <summary>
    /// Controls whether logging is enabled for the networks bound to this policy.
    /// Defaults to no logging if not set.
    /// </summary>
    [TerraformProperty("enable_logging")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? EnableLogging { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// User assigned name for this policy.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Project { get; set; }

    /// <summary>
    /// Block for alternative_name_server_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AlternativeNameServerConfig block(s) allowed")]
    [TerraformProperty("alternative_name_server_config")]
    public TerraformList<TerraformBlock<GoogleDnsPolicyAlternativeNameServerConfigBlock>>? AlternativeNameServerConfig { get; set; }

    /// <summary>
    /// Block for dns64_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Dns64Config block(s) allowed")]
    [TerraformProperty("dns64_config")]
    public TerraformList<TerraformBlock<GoogleDnsPolicyDns64ConfigBlock>>? Dns64Config { get; set; }

    /// <summary>
    /// Block for networks.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("networks")]
    public TerraformSet<TerraformBlock<GoogleDnsPolicyNetworksBlock>>? Networks { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<GoogleDnsPolicyTimeoutsBlock>? Timeouts { get; set; }

}
