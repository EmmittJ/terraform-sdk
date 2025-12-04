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
        get => GetArgument<TerraformValue<bool>>("proxy_enabled");
        set => SetArgument("proxy_enabled", value);
    }

    /// <summary>
    /// The servers attribute.
    /// </summary>
    public TerraformList<string>? Servers
    {
        get => GetArgument<TerraformList<string>>("servers");
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
        get => GetArgument<TerraformValue<bool>>("enable_pac_file");
        set => SetArgument("enable_pac_file", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformValue<bool>? Enabled
    {
        get => GetArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The http_port attribute.
    /// </summary>
    public TerraformValue<double>? HttpPort
    {
        get => GetArgument<TerraformValue<double>>("http_port");
        set => SetArgument("http_port", value);
    }

    /// <summary>
    /// The https_port attribute.
    /// </summary>
    public TerraformValue<double>? HttpsPort
    {
        get => GetArgument<TerraformValue<double>>("https_port");
        set => SetArgument("https_port", value);
    }

    /// <summary>
    /// The pac_file attribute.
    /// </summary>
    public TerraformValue<string>? PacFile
    {
        get => GetArgument<TerraformValue<string>>("pac_file");
        set => SetArgument("pac_file", value);
    }

    /// <summary>
    /// The pac_file_port attribute.
    /// </summary>
    public TerraformValue<double>? PacFilePort
    {
        get => GetArgument<TerraformValue<double>>("pac_file_port");
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
        get => GetArgument<TerraformSet<string>>("identity_ids");
        set => SetArgument("identity_ids", value);
    }

    /// <summary>
    /// The principal_id attribute.
    /// </summary>
    public TerraformValue<string> PrincipalId
        => AsReference("principal_id");

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    public TerraformValue<string> TenantId
        => AsReference("tenant_id");

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => GetRequiredArgument<TerraformValue<string>>("type");
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
        get => GetRequiredArgument<TerraformValue<string>>("default_log_analytics_workspace_id");
        set => SetArgument("default_log_analytics_workspace_id", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformValue<bool> Enabled
    {
        get => GetRequiredArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The retention_in_days attribute.
    /// </summary>
    public TerraformValue<double>? RetentionInDays
    {
        get => GetArgument<TerraformValue<double>>("retention_in_days");
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
        get => GetRequiredArgument<TerraformValue<string>>("firewall_location");
        set => SetArgument("firewall_location", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    public required TerraformValue<string> Id
    {
        get => GetRequiredArgument<TerraformValue<string>>("id");
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
        get => GetArgument<TerraformValue<string>>("mode");
        set => SetArgument("mode", value);
    }

    /// <summary>
    /// The private_ranges attribute.
    /// </summary>
    public TerraformList<string>? PrivateRanges
    {
        get => GetArgument<TerraformList<string>>("private_ranges");
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
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The state attribute.
    /// </summary>
    public TerraformValue<string>? State
    {
        get => GetArgument<TerraformValue<string>>("state");
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
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The destination_addresses attribute.
    /// </summary>
    public TerraformSet<string>? DestinationAddresses
    {
        get => GetArgument<TerraformSet<string>>("destination_addresses");
        set => SetArgument("destination_addresses", value);
    }

    /// <summary>
    /// The destination_ip_groups attribute.
    /// </summary>
    public TerraformSet<string>? DestinationIpGroups
    {
        get => GetArgument<TerraformSet<string>>("destination_ip_groups");
        set => SetArgument("destination_ip_groups", value);
    }

    /// <summary>
    /// The destination_ports attribute.
    /// </summary>
    public TerraformSet<string>? DestinationPorts
    {
        get => GetArgument<TerraformSet<string>>("destination_ports");
        set => SetArgument("destination_ports", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Protocol is required")]
    public required TerraformValue<string> Protocol
    {
        get => GetRequiredArgument<TerraformValue<string>>("protocol");
        set => SetArgument("protocol", value);
    }

    /// <summary>
    /// The source_addresses attribute.
    /// </summary>
    public TerraformSet<string>? SourceAddresses
    {
        get => GetArgument<TerraformSet<string>>("source_addresses");
        set => SetArgument("source_addresses", value);
    }

    /// <summary>
    /// The source_ip_groups attribute.
    /// </summary>
    public TerraformSet<string>? SourceIpGroups
    {
        get => GetArgument<TerraformSet<string>>("source_ip_groups");
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
        get => GetArgument<TerraformSet<string>>("fqdns");
        set => SetArgument("fqdns", value);
    }

    /// <summary>
    /// The ip_addresses attribute.
    /// </summary>
    public TerraformSet<string>? IpAddresses
    {
        get => GetArgument<TerraformSet<string>>("ip_addresses");
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
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
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
        get => GetRequiredArgument<TerraformValue<string>>("key_vault_secret_id");
        set => SetArgument("key_vault_secret_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
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
        get => GetArgument<TerraformValue<bool>>("auto_learn_private_ranges_enabled");
        set => SetArgument("auto_learn_private_ranges_enabled", value);
    }

    /// <summary>
    /// The base_policy_id attribute.
    /// </summary>
    public TerraformValue<string>? BasePolicyId
    {
        get => GetArgument<TerraformValue<string>>("base_policy_id");
        set => SetArgument("base_policy_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetRequiredArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The private_ip_ranges attribute.
    /// </summary>
    public TerraformList<string>? PrivateIpRanges
    {
        get => GetArgument<TerraformList<string>>("private_ip_ranges");
        set => SetArgument("private_ip_ranges", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => GetRequiredArgument<TerraformValue<string>>("resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The sku attribute.
    /// </summary>
    public TerraformValue<string>? Sku
    {
        get => GetArgument<TerraformValue<string>>("sku");
        set => SetArgument("sku", value);
    }

    /// <summary>
    /// The sql_redirect_allowed attribute.
    /// </summary>
    public TerraformValue<bool>? SqlRedirectAllowed
    {
        get => GetArgument<TerraformValue<bool>>("sql_redirect_allowed");
        set => SetArgument("sql_redirect_allowed", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The threat_intelligence_mode attribute.
    /// </summary>
    public TerraformValue<string>? ThreatIntelligenceMode
    {
        get => GetArgument<TerraformValue<string>>("threat_intelligence_mode");
        set => SetArgument("threat_intelligence_mode", value);
    }

    /// <summary>
    /// The child_policies attribute.
    /// </summary>
    public TerraformList<string> ChildPolicies
        => AsReference("child_policies");

    /// <summary>
    /// The firewalls attribute.
    /// </summary>
    public TerraformList<string> Firewalls
        => AsReference("firewalls");

    /// <summary>
    /// The rule_collection_groups attribute.
    /// </summary>
    public TerraformList<string> RuleCollectionGroups
        => AsReference("rule_collection_groups");

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
