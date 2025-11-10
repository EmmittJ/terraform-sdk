using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for alternative_name_server_config in .
/// Nesting mode: list
/// </summary>
public class GoogleDnsPolicyAlternativeNameServerConfigBlock : ITerraformBlock
{
}

/// <summary>
/// Block type for dns64_config in .
/// Nesting mode: list
/// </summary>
public class GoogleDnsPolicyDns64ConfigBlock : ITerraformBlock
{
}

/// <summary>
/// Block type for networks in .
/// Nesting mode: set
/// </summary>
public class GoogleDnsPolicyNetworksBlock : ITerraformBlock
{
    /// <summary>
    /// The id or fully qualified URL of the VPC network to forward queries to.
    /// This should be formatted like &#39;projects/{project}/global/networks/{network}&#39; or
    /// &#39;https://www.googleapis.com/compute/v1/projects/{project}/global/networks/{network}&#39;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetworkUrl is required")]
    [TerraformPropertyName("network_url")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> NetworkUrl { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleDnsPolicyTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Manages a google_dns_policy resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleDnsPolicy : TerraformResource
{
    public GoogleDnsPolicy(string name) : base("google_dns_policy", name)
    {
    }

    /// <summary>
    /// A textual description field. Defaults to &#39;Managed by Terraform&#39;.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Description { get; set; }

    /// <summary>
    /// Allows networks bound to this policy to receive DNS queries sent
    /// by VMs or applications over VPN connections. When enabled, a
    /// virtual IP address will be allocated from each of the sub-networks
    /// that are bound to this policy.
    /// </summary>
    [TerraformPropertyName("enable_inbound_forwarding")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? EnableInboundForwarding { get; set; }

    /// <summary>
    /// Controls whether logging is enabled for the networks bound to this policy.
    /// Defaults to no logging if not set.
    /// </summary>
    [TerraformPropertyName("enable_logging")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? EnableLogging { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// User assigned name for this policy.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Project { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "project");

    /// <summary>
    /// Block for alternative_name_server_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AlternativeNameServerConfig block(s) allowed")]
    [TerraformPropertyName("alternative_name_server_config")]
    public TerraformList<TerraformBlock<GoogleDnsPolicyAlternativeNameServerConfigBlock>>? AlternativeNameServerConfig { get; set; } = new();

    /// <summary>
    /// Block for dns64_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Dns64Config block(s) allowed")]
    [TerraformPropertyName("dns64_config")]
    public TerraformList<TerraformBlock<GoogleDnsPolicyDns64ConfigBlock>>? Dns64Config { get; set; } = new();

    /// <summary>
    /// Block for networks.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("networks")]
    public TerraformSet<TerraformBlock<GoogleDnsPolicyNetworksBlock>>? Networks { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleDnsPolicyTimeoutsBlock>? Timeouts { get; set; } = new();

}
