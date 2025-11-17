using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for dns in AzurermFirewallPolicy.
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
    public TerraformValue<bool>? ProxyEnabled
    {
        get => new TerraformReference<bool>(this, "proxy_enabled");
        set => SetArgument("proxy_enabled", value);
    }

    /// <summary>
    /// The servers attribute.
    /// </summary>
    public TerraformList<string>? Servers
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "servers").ResolveNodes(ctx));
        set => SetArgument("servers", value);
    }

}


/// <summary>
/// Block type for explicit_proxy in AzurermFirewallPolicy.
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
    public TerraformValue<bool>? EnablePacFile
    {
        get => new TerraformReference<bool>(this, "enable_pac_file");
        set => SetArgument("enable_pac_file", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformValue<bool>? Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The http_port attribute.
    /// </summary>
    public TerraformValue<double>? HttpPort
    {
        get => new TerraformReference<double>(this, "http_port");
        set => SetArgument("http_port", value);
    }

    /// <summary>
    /// The https_port attribute.
    /// </summary>
    public TerraformValue<double>? HttpsPort
    {
        get => new TerraformReference<double>(this, "https_port");
        set => SetArgument("https_port", value);
    }

    /// <summary>
    /// The pac_file attribute.
    /// </summary>
    public TerraformValue<string>? PacFile
    {
        get => new TerraformReference<string>(this, "pac_file");
        set => SetArgument("pac_file", value);
    }

    /// <summary>
    /// The pac_file_port attribute.
    /// </summary>
    public TerraformValue<double>? PacFilePort
    {
        get => new TerraformReference<double>(this, "pac_file_port");
        set => SetArgument("pac_file_port", value);
    }

}


/// <summary>
/// Block type for identity in AzurermFirewallPolicy.
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
    public TerraformSet<string>? IdentityIds
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "identity_ids").ResolveNodes(ctx));
        set => SetArgument("identity_ids", value);
    }

    /// <summary>
    /// The principal_id attribute.
    /// </summary>
    public TerraformValue<string> PrincipalId
    {
        get => new TerraformReference<string>(this, "principal_id");
    }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    public TerraformValue<string> TenantId
    {
        get => new TerraformReference<string>(this, "tenant_id");
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

}


/// <summary>
/// Block type for insights in AzurermFirewallPolicy.
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
    public required TerraformValue<string> DefaultLogAnalyticsWorkspaceId
    {
        get => new TerraformReference<string>(this, "default_log_analytics_workspace_id");
        set => SetArgument("default_log_analytics_workspace_id", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformValue<bool> Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The retention_in_days attribute.
    /// </summary>
    public TerraformValue<double>? RetentionInDays
    {
        get => new TerraformReference<double>(this, "retention_in_days");
        set => SetArgument("retention_in_days", value);
    }

    /// <summary>
    /// LogAnalyticsWorkspace block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermFirewallPolicyInsightsBlockLogAnalyticsWorkspaceBlock>? LogAnalyticsWorkspace
    {
        get => GetArgument<TerraformList<AzurermFirewallPolicyInsightsBlockLogAnalyticsWorkspaceBlock>>("log_analytics_workspace");
        set => SetArgument("log_analytics_workspace", value);
    }

}

/// <summary>
/// Block type for log_analytics_workspace in AzurermFirewallPolicyInsightsBlock.
/// Nesting mode: list
/// </summary>
public class AzurermFirewallPolicyInsightsBlockLogAnalyticsWorkspaceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "log_analytics_workspace";

    /// <summary>
    /// The firewall_location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FirewallLocation is required")]
    public required TerraformValue<string> FirewallLocation
    {
        get => new TerraformReference<string>(this, "firewall_location");
        set => SetArgument("firewall_location", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    public required TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

}


/// <summary>
/// Block type for intrusion_detection in AzurermFirewallPolicy.
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
    public TerraformValue<string>? Mode
    {
        get => new TerraformReference<string>(this, "mode");
        set => SetArgument("mode", value);
    }

    /// <summary>
    /// The private_ranges attribute.
    /// </summary>
    public TerraformList<string>? PrivateRanges
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "private_ranges").ResolveNodes(ctx));
        set => SetArgument("private_ranges", value);
    }

    /// <summary>
    /// SignatureOverrides block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermFirewallPolicyIntrusionDetectionBlockSignatureOverridesBlock>? SignatureOverrides
    {
        get => GetArgument<TerraformList<AzurermFirewallPolicyIntrusionDetectionBlockSignatureOverridesBlock>>("signature_overrides");
        set => SetArgument("signature_overrides", value);
    }

    /// <summary>
    /// TrafficBypass block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermFirewallPolicyIntrusionDetectionBlockTrafficBypassBlock>? TrafficBypass
    {
        get => GetArgument<TerraformList<AzurermFirewallPolicyIntrusionDetectionBlockTrafficBypassBlock>>("traffic_bypass");
        set => SetArgument("traffic_bypass", value);
    }

}

/// <summary>
/// Block type for signature_overrides in AzurermFirewallPolicyIntrusionDetectionBlock.
/// Nesting mode: list
/// </summary>
public class AzurermFirewallPolicyIntrusionDetectionBlockSignatureOverridesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "signature_overrides";

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The state attribute.
    /// </summary>
    public TerraformValue<string>? State
    {
        get => new TerraformReference<string>(this, "state");
        set => SetArgument("state", value);
    }

}

/// <summary>
/// Block type for traffic_bypass in AzurermFirewallPolicyIntrusionDetectionBlock.
/// Nesting mode: list
/// </summary>
public class AzurermFirewallPolicyIntrusionDetectionBlockTrafficBypassBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "traffic_bypass";

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The destination_addresses attribute.
    /// </summary>
    public TerraformSet<string>? DestinationAddresses
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "destination_addresses").ResolveNodes(ctx));
        set => SetArgument("destination_addresses", value);
    }

    /// <summary>
    /// The destination_ip_groups attribute.
    /// </summary>
    public TerraformSet<string>? DestinationIpGroups
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "destination_ip_groups").ResolveNodes(ctx));
        set => SetArgument("destination_ip_groups", value);
    }

    /// <summary>
    /// The destination_ports attribute.
    /// </summary>
    public TerraformSet<string>? DestinationPorts
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "destination_ports").ResolveNodes(ctx));
        set => SetArgument("destination_ports", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Protocol is required")]
    public required TerraformValue<string> Protocol
    {
        get => new TerraformReference<string>(this, "protocol");
        set => SetArgument("protocol", value);
    }

    /// <summary>
    /// The source_addresses attribute.
    /// </summary>
    public TerraformSet<string>? SourceAddresses
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "source_addresses").ResolveNodes(ctx));
        set => SetArgument("source_addresses", value);
    }

    /// <summary>
    /// The source_ip_groups attribute.
    /// </summary>
    public TerraformSet<string>? SourceIpGroups
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "source_ip_groups").ResolveNodes(ctx));
        set => SetArgument("source_ip_groups", value);
    }

}


/// <summary>
/// Block type for threat_intelligence_allowlist in AzurermFirewallPolicy.
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
    public TerraformSet<string>? Fqdns
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "fqdns").ResolveNodes(ctx));
        set => SetArgument("fqdns", value);
    }

    /// <summary>
    /// The ip_addresses attribute.
    /// </summary>
    public TerraformSet<string>? IpAddresses
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "ip_addresses").ResolveNodes(ctx));
        set => SetArgument("ip_addresses", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermFirewallPolicy.
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
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
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
/// Block type for tls_certificate in AzurermFirewallPolicy.
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
    public required TerraformValue<string> KeyVaultSecretId
    {
        get => new TerraformReference<string>(this, "key_vault_secret_id");
        set => SetArgument("key_vault_secret_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

}


/// <summary>
/// Represents a azurerm_firewall_policy Terraform resource.
/// Manages a azurerm_firewall_policy resource.
/// </summary>
public partial class AzurermFirewallPolicy(string name) : TerraformResource("azurerm_firewall_policy", name)
{
    /// <summary>
    /// The auto_learn_private_ranges_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? AutoLearnPrivateRangesEnabled
    {
        get => new TerraformReference<bool>(this, "auto_learn_private_ranges_enabled");
        set => SetArgument("auto_learn_private_ranges_enabled", value);
    }

    /// <summary>
    /// The base_policy_id attribute.
    /// </summary>
    public TerraformValue<string>? BasePolicyId
    {
        get => new TerraformReference<string>(this, "base_policy_id");
        set => SetArgument("base_policy_id", value);
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
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The private_ip_ranges attribute.
    /// </summary>
    public TerraformList<string>? PrivateIpRanges
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "private_ip_ranges").ResolveNodes(ctx));
        set => SetArgument("private_ip_ranges", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The sku attribute.
    /// </summary>
    public TerraformValue<string>? Sku
    {
        get => new TerraformReference<string>(this, "sku");
        set => SetArgument("sku", value);
    }

    /// <summary>
    /// The sql_redirect_allowed attribute.
    /// </summary>
    public TerraformValue<bool>? SqlRedirectAllowed
    {
        get => new TerraformReference<bool>(this, "sql_redirect_allowed");
        set => SetArgument("sql_redirect_allowed", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The threat_intelligence_mode attribute.
    /// </summary>
    public TerraformValue<string>? ThreatIntelligenceMode
    {
        get => new TerraformReference<string>(this, "threat_intelligence_mode");
        set => SetArgument("threat_intelligence_mode", value);
    }

    /// <summary>
    /// The child_policies attribute.
    /// </summary>
    public TerraformList<string> ChildPolicies
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "child_policies").ResolveNodes(ctx));
    }

    /// <summary>
    /// The firewalls attribute.
    /// </summary>
    public TerraformList<string> Firewalls
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "firewalls").ResolveNodes(ctx));
    }

    /// <summary>
    /// The rule_collection_groups attribute.
    /// </summary>
    public TerraformList<string> RuleCollectionGroups
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "rule_collection_groups").ResolveNodes(ctx));
    }

    /// <summary>
    /// Dns block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Dns block(s) allowed")]
    public TerraformList<AzurermFirewallPolicyDnsBlock>? Dns
    {
        get => GetArgument<TerraformList<AzurermFirewallPolicyDnsBlock>>("dns");
        set => SetArgument("dns", value);
    }

    /// <summary>
    /// ExplicitProxy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ExplicitProxy block(s) allowed")]
    public TerraformList<AzurermFirewallPolicyExplicitProxyBlock>? ExplicitProxy
    {
        get => GetArgument<TerraformList<AzurermFirewallPolicyExplicitProxyBlock>>("explicit_proxy");
        set => SetArgument("explicit_proxy", value);
    }

    /// <summary>
    /// Identity block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    public TerraformList<AzurermFirewallPolicyIdentityBlock>? Identity
    {
        get => GetArgument<TerraformList<AzurermFirewallPolicyIdentityBlock>>("identity");
        set => SetArgument("identity", value);
    }

    /// <summary>
    /// Insights block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Insights block(s) allowed")]
    public TerraformList<AzurermFirewallPolicyInsightsBlock>? Insights
    {
        get => GetArgument<TerraformList<AzurermFirewallPolicyInsightsBlock>>("insights");
        set => SetArgument("insights", value);
    }

    /// <summary>
    /// IntrusionDetection block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IntrusionDetection block(s) allowed")]
    public TerraformList<AzurermFirewallPolicyIntrusionDetectionBlock>? IntrusionDetection
    {
        get => GetArgument<TerraformList<AzurermFirewallPolicyIntrusionDetectionBlock>>("intrusion_detection");
        set => SetArgument("intrusion_detection", value);
    }

    /// <summary>
    /// ThreatIntelligenceAllowlist block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ThreatIntelligenceAllowlist block(s) allowed")]
    public TerraformList<AzurermFirewallPolicyThreatIntelligenceAllowlistBlock>? ThreatIntelligenceAllowlist
    {
        get => GetArgument<TerraformList<AzurermFirewallPolicyThreatIntelligenceAllowlistBlock>>("threat_intelligence_allowlist");
        set => SetArgument("threat_intelligence_allowlist", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermFirewallPolicyTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermFirewallPolicyTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

    /// <summary>
    /// TlsCertificate block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TlsCertificate block(s) allowed")]
    public TerraformList<AzurermFirewallPolicyTlsCertificateBlock>? TlsCertificate
    {
        get => GetArgument<TerraformList<AzurermFirewallPolicyTlsCertificateBlock>>("tls_certificate");
        set => SetArgument("tls_certificate", value);
    }

}
