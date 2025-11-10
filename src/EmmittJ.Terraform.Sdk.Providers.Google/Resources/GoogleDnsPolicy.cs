using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for alternative_name_server_config in .
/// Nesting mode: list
/// </summary>
public class GoogleDnsPolicyAlternativeNameServerConfigBlock : TerraformBlock
{
}

/// <summary>
/// Block type for dns64_config in .
/// Nesting mode: list
/// </summary>
public class GoogleDnsPolicyDns64ConfigBlock : TerraformBlock
{
}

/// <summary>
/// Block type for networks in .
/// Nesting mode: set
/// </summary>
public class GoogleDnsPolicyNetworksBlock : TerraformBlock
{
    /// <summary>
    /// The id or fully qualified URL of the VPC network to forward queries to.
    /// This should be formatted like &#39;projects/{project}/global/networks/{network}&#39; or
    /// &#39;https://www.googleapis.com/compute/v1/projects/{project}/global/networks/{network}&#39;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetworkUrl is required")]
    public required TerraformProperty<string> NetworkUrl
    {
        get => GetProperty<TerraformProperty<string>>("network_url");
        set => WithProperty("network_url", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleDnsPolicyTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a google_dns_policy resource.
/// </summary>
public class GoogleDnsPolicy : TerraformResource
{
    public GoogleDnsPolicy(string name) : base("google_dns_policy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// A textual description field. Defaults to &#39;Managed by Terraform&#39;.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// Allows networks bound to this policy to receive DNS queries sent
    /// by VMs or applications over VPN connections. When enabled, a
    /// virtual IP address will be allocated from each of the sub-networks
    /// that are bound to this policy.
    /// </summary>
    public TerraformProperty<bool>? EnableInboundForwarding
    {
        get => GetProperty<TerraformProperty<bool>>("enable_inbound_forwarding");
        set => this.WithProperty("enable_inbound_forwarding", value);
    }

    /// <summary>
    /// Controls whether logging is enabled for the networks bound to this policy.
    /// Defaults to no logging if not set.
    /// </summary>
    public TerraformProperty<bool>? EnableLogging
    {
        get => GetProperty<TerraformProperty<bool>>("enable_logging");
        set => this.WithProperty("enable_logging", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// User assigned name for this policy.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string>? Project
    {
        get => GetProperty<TerraformProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// Block for alternative_name_server_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AlternativeNameServerConfig block(s) allowed")]
    public List<GoogleDnsPolicyAlternativeNameServerConfigBlock>? AlternativeNameServerConfig
    {
        get => GetProperty<List<GoogleDnsPolicyAlternativeNameServerConfigBlock>>("alternative_name_server_config");
        set => this.WithProperty("alternative_name_server_config", value);
    }

    /// <summary>
    /// Block for dns64_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Dns64Config block(s) allowed")]
    public List<GoogleDnsPolicyDns64ConfigBlock>? Dns64Config
    {
        get => GetProperty<List<GoogleDnsPolicyDns64ConfigBlock>>("dns64_config");
        set => this.WithProperty("dns64_config", value);
    }

    /// <summary>
    /// Block for networks.
    /// Nesting mode: set
    /// </summary>
    public HashSet<GoogleDnsPolicyNetworksBlock>? Networks
    {
        get => GetProperty<HashSet<GoogleDnsPolicyNetworksBlock>>("networks");
        set => this.WithProperty("networks", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleDnsPolicyTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleDnsPolicyTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
