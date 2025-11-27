using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for alternative_name_server_config in GoogleDnsPolicy.
/// Nesting mode: list
/// </summary>
public class GoogleDnsPolicyAlternativeNameServerConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "alternative_name_server_config";

    /// <summary>
    /// TargetNameServers block (nesting mode: set).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetNameServers is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 TargetNameServers block(s) required")]
    public required TerraformSet<GoogleDnsPolicyAlternativeNameServerConfigBlockTargetNameServersBlock> TargetNameServers
    {
        get => GetRequiredArgument<TerraformSet<GoogleDnsPolicyAlternativeNameServerConfigBlockTargetNameServersBlock>>("target_name_servers");
        set => SetArgument("target_name_servers", value);
    }

}

/// <summary>
/// Block type for target_name_servers in GoogleDnsPolicyAlternativeNameServerConfigBlock.
/// Nesting mode: set
/// </summary>
public class GoogleDnsPolicyAlternativeNameServerConfigBlockTargetNameServersBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "target_name_servers";

    /// <summary>
    /// Forwarding path for this TargetNameServer. If unset or &#39;default&#39; Cloud DNS will make forwarding
    /// decision based on address ranges, i.e. RFC1918 addresses go to the VPC, Non-RFC1918 addresses go
    /// to the Internet. When set to &#39;private&#39;, Cloud DNS will always send queries through VPC for this target Possible values: [&amp;quot;default&amp;quot;, &amp;quot;private&amp;quot;]
    /// </summary>
    public TerraformValue<string>? ForwardingPath
    {
        get => new TerraformReference<string>(this, "forwarding_path");
        set => SetArgument("forwarding_path", value);
    }

    /// <summary>
    /// IPv4 address to forward to.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Ipv4Address is required")]
    public required TerraformValue<string> Ipv4Address
    {
        get => new TerraformReference<string>(this, "ipv4_address");
        set => SetArgument("ipv4_address", value);
    }

}


/// <summary>
/// Block type for dns64_config in GoogleDnsPolicy.
/// Nesting mode: list
/// </summary>
public class GoogleDnsPolicyDns64ConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "dns64_config";

    /// <summary>
    /// Scope block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Scope is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Scope block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Scope block(s) allowed")]
    public required TerraformList<GoogleDnsPolicyDns64ConfigBlockScopeBlock> Scope
    {
        get => GetRequiredArgument<TerraformList<GoogleDnsPolicyDns64ConfigBlockScopeBlock>>("scope");
        set => SetArgument("scope", value);
    }

}

/// <summary>
/// Block type for scope in GoogleDnsPolicyDns64ConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDnsPolicyDns64ConfigBlockScopeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "scope";

    /// <summary>
    /// Controls whether DNS64 is enabled globally at the network level.
    /// </summary>
    public TerraformValue<bool>? AllQueries
    {
        get => new TerraformReference<bool>(this, "all_queries");
        set => SetArgument("all_queries", value);
    }

}


/// <summary>
/// Block type for networks in GoogleDnsPolicy.
/// Nesting mode: set
/// </summary>
public class GoogleDnsPolicyNetworksBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "networks";

    /// <summary>
    /// The id or fully qualified URL of the VPC network to forward queries to.
    /// This should be formatted like &#39;projects/{project}/global/networks/{network}&#39; or
    /// &#39;https://www.googleapis.com/compute/v1/projects/{project}/global/networks/{network}&#39;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetworkUrl is required")]
    public required TerraformValue<string> NetworkUrl
    {
        get => new TerraformReference<string>(this, "network_url");
        set => SetArgument("network_url", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleDnsPolicy.
/// Nesting mode: single
/// </summary>
public class GoogleDnsPolicyTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a google_dns_policy Terraform resource.
/// Manages a google_dns_policy resource.
/// </summary>
public partial class GoogleDnsPolicy(string name) : TerraformResource("google_dns_policy", name)
{
    /// <summary>
    /// A textual description field. Defaults to &#39;Managed by Terraform&#39;.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// Allows networks bound to this policy to receive DNS queries sent
    /// by VMs or applications over VPN connections. When enabled, a
    /// virtual IP address will be allocated from each of the sub-networks
    /// that are bound to this policy.
    /// </summary>
    public TerraformValue<bool>? EnableInboundForwarding
    {
        get => new TerraformReference<bool>(this, "enable_inbound_forwarding");
        set => SetArgument("enable_inbound_forwarding", value);
    }

    /// <summary>
    /// Controls whether logging is enabled for the networks bound to this policy.
    /// Defaults to no logging if not set.
    /// </summary>
    public TerraformValue<bool>? EnableLogging
    {
        get => new TerraformReference<bool>(this, "enable_logging");
        set => SetArgument("enable_logging", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// User assigned name for this policy.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => new TerraformReference<string>(this, "project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// AlternativeNameServerConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AlternativeNameServerConfig block(s) allowed")]
    public TerraformList<GoogleDnsPolicyAlternativeNameServerConfigBlock>? AlternativeNameServerConfig
    {
        get => GetArgument<TerraformList<GoogleDnsPolicyAlternativeNameServerConfigBlock>>("alternative_name_server_config");
        set => SetArgument("alternative_name_server_config", value);
    }

    /// <summary>
    /// Dns64Config block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Dns64Config block(s) allowed")]
    public TerraformList<GoogleDnsPolicyDns64ConfigBlock>? Dns64Config
    {
        get => GetArgument<TerraformList<GoogleDnsPolicyDns64ConfigBlock>>("dns64_config");
        set => SetArgument("dns64_config", value);
    }

    /// <summary>
    /// Networks block (nesting mode: set).
    /// </summary>
    public TerraformSet<GoogleDnsPolicyNetworksBlock>? Networks
    {
        get => GetArgument<TerraformSet<GoogleDnsPolicyNetworksBlock>>("networks");
        set => SetArgument("networks", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleDnsPolicyTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleDnsPolicyTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
