using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

// Resources, Data Sources, Ephemeral Resources, Blocks: Getter ALWAYS returns a reference
// This is the key to natural Terraform syntax
// When you access rg.Name, you get azurerm_resource_group.rg.name (a reference)
// The value that was SET is only used during serialization

// Providers: Getter returns stored value
// Providers are not referenced in HCL
// Use required getter if property is required or non-nullable

/// <summary>
/// Block type for dns in .
/// Nesting mode: list
/// </summary>
public class AzurermFirewallPolicyDnsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "dns";

    /// <summary>
    /// The proxy_enabled attribute.
    /// </summary>
    [TerraformArgument("proxy_enabled")]
    public TerraformValue<bool>? ProxyEnabled
    {
        get => new TerraformReference<bool>(this, "proxy_enabled");
        set => SetArgument("proxy_enabled", value);
    }

    /// <summary>
    /// The servers attribute.
    /// </summary>
    [TerraformArgument("servers")]
    public TerraformList<string>? Servers
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "servers").ResolveNodes(ctx));
        set => SetArgument("servers", value);
    }

}

/// <summary>
/// Block type for explicit_proxy in .
/// Nesting mode: list
/// </summary>
public class AzurermFirewallPolicyExplicitProxyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "explicit_proxy";

    /// <summary>
    /// The enable_pac_file attribute.
    /// </summary>
    [TerraformArgument("enable_pac_file")]
    public TerraformValue<bool>? EnablePacFile
    {
        get => new TerraformReference<bool>(this, "enable_pac_file");
        set => SetArgument("enable_pac_file", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformArgument("enabled")]
    public TerraformValue<bool>? Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The http_port attribute.
    /// </summary>
    [TerraformArgument("http_port")]
    public TerraformValue<double>? HttpPort
    {
        get => new TerraformReference<double>(this, "http_port");
        set => SetArgument("http_port", value);
    }

    /// <summary>
    /// The https_port attribute.
    /// </summary>
    [TerraformArgument("https_port")]
    public TerraformValue<double>? HttpsPort
    {
        get => new TerraformReference<double>(this, "https_port");
        set => SetArgument("https_port", value);
    }

    /// <summary>
    /// The pac_file attribute.
    /// </summary>
    [TerraformArgument("pac_file")]
    public TerraformValue<string>? PacFile
    {
        get => new TerraformReference<string>(this, "pac_file");
        set => SetArgument("pac_file", value);
    }

    /// <summary>
    /// The pac_file_port attribute.
    /// </summary>
    [TerraformArgument("pac_file_port")]
    public TerraformValue<double>? PacFilePort
    {
        get => new TerraformReference<double>(this, "pac_file_port");
        set => SetArgument("pac_file_port", value);
    }

}

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public class AzurermFirewallPolicyIdentityBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "identity";

    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    [TerraformArgument("identity_ids")]
    public TerraformSet<string>? IdentityIds
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "identity_ids").ResolveNodes(ctx));
        set => SetArgument("identity_ids", value);
    }



    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformArgument("type")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

}

/// <summary>
/// Block type for insights in .
/// Nesting mode: list
/// </summary>
public class AzurermFirewallPolicyInsightsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "insights";

    /// <summary>
    /// The default_log_analytics_workspace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DefaultLogAnalyticsWorkspaceId is required")]
    [TerraformArgument("default_log_analytics_workspace_id")]
    public required TerraformValue<string> DefaultLogAnalyticsWorkspaceId
    {
        get => new TerraformReference<string>(this, "default_log_analytics_workspace_id");
        set => SetArgument("default_log_analytics_workspace_id", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    [TerraformArgument("enabled")]
    public required TerraformValue<bool> Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The retention_in_days attribute.
    /// </summary>
    [TerraformArgument("retention_in_days")]
    public TerraformValue<double>? RetentionInDays
    {
        get => new TerraformReference<double>(this, "retention_in_days");
        set => SetArgument("retention_in_days", value);
    }

}

/// <summary>
/// Block type for intrusion_detection in .
/// Nesting mode: list
/// </summary>
public class AzurermFirewallPolicyIntrusionDetectionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "intrusion_detection";

    /// <summary>
    /// The mode attribute.
    /// </summary>
    [TerraformArgument("mode")]
    public TerraformValue<string>? Mode
    {
        get => new TerraformReference<string>(this, "mode");
        set => SetArgument("mode", value);
    }

    /// <summary>
    /// The private_ranges attribute.
    /// </summary>
    [TerraformArgument("private_ranges")]
    public TerraformList<string>? PrivateRanges
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "private_ranges").ResolveNodes(ctx));
        set => SetArgument("private_ranges", value);
    }

}

/// <summary>
/// Block type for threat_intelligence_allowlist in .
/// Nesting mode: list
/// </summary>
public class AzurermFirewallPolicyThreatIntelligenceAllowlistBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "threat_intelligence_allowlist";

    /// <summary>
    /// The fqdns attribute.
    /// </summary>
    [TerraformArgument("fqdns")]
    public TerraformSet<string>? Fqdns
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "fqdns").ResolveNodes(ctx));
        set => SetArgument("fqdns", value);
    }

    /// <summary>
    /// The ip_addresses attribute.
    /// </summary>
    [TerraformArgument("ip_addresses")]
    public TerraformSet<string>? IpAddresses
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "ip_addresses").ResolveNodes(ctx));
        set => SetArgument("ip_addresses", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermFirewallPolicyTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformArgument("create")]
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformArgument("delete")]
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformArgument("update")]
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}

/// <summary>
/// Block type for tls_certificate in .
/// Nesting mode: list
/// </summary>
public class AzurermFirewallPolicyTlsCertificateBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "tls_certificate";

    /// <summary>
    /// The key_vault_secret_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyVaultSecretId is required")]
    [TerraformArgument("key_vault_secret_id")]
    public required TerraformValue<string> KeyVaultSecretId
    {
        get => new TerraformReference<string>(this, "key_vault_secret_id");
        set => SetArgument("key_vault_secret_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

}

/// <summary>
/// Manages a azurerm_firewall_policy resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermFirewallPolicy : TerraformResource
{
    public AzurermFirewallPolicy(string name) : base("azurerm_firewall_policy", name)
    {
    }

    /// <summary>
    /// The auto_learn_private_ranges_enabled attribute.
    /// </summary>
    [TerraformArgument("auto_learn_private_ranges_enabled")]
    public TerraformValue<bool>? AutoLearnPrivateRangesEnabled
    {
        get => new TerraformReference<bool>(this, "auto_learn_private_ranges_enabled");
        set => SetArgument("auto_learn_private_ranges_enabled", value);
    }

    /// <summary>
    /// The base_policy_id attribute.
    /// </summary>
    [TerraformArgument("base_policy_id")]
    public TerraformValue<string>? BasePolicyId
    {
        get => new TerraformReference<string>(this, "base_policy_id");
        set => SetArgument("base_policy_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformArgument("id")]
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformArgument("location")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The private_ip_ranges attribute.
    /// </summary>
    [TerraformArgument("private_ip_ranges")]
    public TerraformList<string>? PrivateIpRanges
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "private_ip_ranges").ResolveNodes(ctx));
        set => SetArgument("private_ip_ranges", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformArgument("resource_group_name")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The sku attribute.
    /// </summary>
    [TerraformArgument("sku")]
    public TerraformValue<string>? Sku
    {
        get => new TerraformReference<string>(this, "sku");
        set => SetArgument("sku", value);
    }

    /// <summary>
    /// The sql_redirect_allowed attribute.
    /// </summary>
    [TerraformArgument("sql_redirect_allowed")]
    public TerraformValue<bool>? SqlRedirectAllowed
    {
        get => new TerraformReference<bool>(this, "sql_redirect_allowed");
        set => SetArgument("sql_redirect_allowed", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformArgument("tags")]
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The threat_intelligence_mode attribute.
    /// </summary>
    [TerraformArgument("threat_intelligence_mode")]
    public TerraformValue<string>? ThreatIntelligenceMode
    {
        get => new TerraformReference<string>(this, "threat_intelligence_mode");
        set => SetArgument("threat_intelligence_mode", value);
    }

    /// <summary>
    /// Block for dns.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Dns block(s) allowed")]
    [TerraformArgument("dns")]
    public TerraformList<AzurermFirewallPolicyDnsBlock> Dns { get; set; } = new();

    /// <summary>
    /// Block for explicit_proxy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ExplicitProxy block(s) allowed")]
    [TerraformArgument("explicit_proxy")]
    public TerraformList<AzurermFirewallPolicyExplicitProxyBlock> ExplicitProxy { get; set; } = new();

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    [TerraformArgument("identity")]
    public TerraformList<AzurermFirewallPolicyIdentityBlock> Identity { get; set; } = new();

    /// <summary>
    /// Block for insights.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Insights block(s) allowed")]
    [TerraformArgument("insights")]
    public TerraformList<AzurermFirewallPolicyInsightsBlock> Insights { get; set; } = new();

    /// <summary>
    /// Block for intrusion_detection.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IntrusionDetection block(s) allowed")]
    [TerraformArgument("intrusion_detection")]
    public TerraformList<AzurermFirewallPolicyIntrusionDetectionBlock> IntrusionDetection { get; set; } = new();

    /// <summary>
    /// Block for threat_intelligence_allowlist.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ThreatIntelligenceAllowlist block(s) allowed")]
    [TerraformArgument("threat_intelligence_allowlist")]
    public TerraformList<AzurermFirewallPolicyThreatIntelligenceAllowlistBlock> ThreatIntelligenceAllowlist { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermFirewallPolicyTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// Block for tls_certificate.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TlsCertificate block(s) allowed")]
    [TerraformArgument("tls_certificate")]
    public TerraformList<AzurermFirewallPolicyTlsCertificateBlock> TlsCertificate { get; set; } = new();

    /// <summary>
    /// The child_policies attribute.
    /// </summary>
    [TerraformArgument("child_policies")]
    public TerraformList<string> ChildPolicies
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "child_policies").ResolveNodes(ctx));
    }

    /// <summary>
    /// The firewalls attribute.
    /// </summary>
    [TerraformArgument("firewalls")]
    public TerraformList<string> Firewalls
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "firewalls").ResolveNodes(ctx));
    }

    /// <summary>
    /// The rule_collection_groups attribute.
    /// </summary>
    [TerraformArgument("rule_collection_groups")]
    public TerraformList<string> RuleCollectionGroups
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "rule_collection_groups").ResolveNodes(ctx));
    }

}
