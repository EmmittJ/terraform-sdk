using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for dns in .
/// Nesting mode: list
/// </summary>
public partial class AzurermFirewallPolicyDnsBlock() : TerraformBlock("dns")
{
    /// <summary>
    /// The proxy_enabled attribute.
    /// </summary>
    [TerraformProperty("proxy_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? ProxyEnabled { get; set; }

    /// <summary>
    /// The servers attribute.
    /// </summary>
    [TerraformProperty("servers")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? Servers { get; set; }

}

/// <summary>
/// Block type for explicit_proxy in .
/// Nesting mode: list
/// </summary>
public partial class AzurermFirewallPolicyExplicitProxyBlock() : TerraformBlock("explicit_proxy")
{
    /// <summary>
    /// The enable_pac_file attribute.
    /// </summary>
    [TerraformProperty("enable_pac_file")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? EnablePacFile { get; set; }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformProperty("enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? Enabled { get; set; }

    /// <summary>
    /// The http_port attribute.
    /// </summary>
    [TerraformProperty("http_port")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? HttpPort { get; set; }

    /// <summary>
    /// The https_port attribute.
    /// </summary>
    [TerraformProperty("https_port")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? HttpsPort { get; set; }

    /// <summary>
    /// The pac_file attribute.
    /// </summary>
    [TerraformProperty("pac_file")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? PacFile { get; set; }

    /// <summary>
    /// The pac_file_port attribute.
    /// </summary>
    [TerraformProperty("pac_file_port")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? PacFilePort { get; set; }

}

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public partial class AzurermFirewallPolicyIdentityBlock() : TerraformBlock("identity")
{
    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    [TerraformProperty("identity_ids")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? IdentityIds { get; set; }



    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformProperty("type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Type { get; set; }

}

/// <summary>
/// Block type for insights in .
/// Nesting mode: list
/// </summary>
public partial class AzurermFirewallPolicyInsightsBlock() : TerraformBlock("insights")
{
    /// <summary>
    /// The default_log_analytics_workspace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DefaultLogAnalyticsWorkspaceId is required")]
    [TerraformProperty("default_log_analytics_workspace_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DefaultLogAnalyticsWorkspaceId { get; set; }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    [TerraformProperty("enabled")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<bool> Enabled { get; set; }

    /// <summary>
    /// The retention_in_days attribute.
    /// </summary>
    [TerraformProperty("retention_in_days")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? RetentionInDays { get; set; }

}

/// <summary>
/// Block type for intrusion_detection in .
/// Nesting mode: list
/// </summary>
public partial class AzurermFirewallPolicyIntrusionDetectionBlock() : TerraformBlock("intrusion_detection")
{
    /// <summary>
    /// The mode attribute.
    /// </summary>
    [TerraformProperty("mode")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Mode { get; set; }

    /// <summary>
    /// The private_ranges attribute.
    /// </summary>
    [TerraformProperty("private_ranges")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? PrivateRanges { get; set; }

}

/// <summary>
/// Block type for threat_intelligence_allowlist in .
/// Nesting mode: list
/// </summary>
public partial class AzurermFirewallPolicyThreatIntelligenceAllowlistBlock() : TerraformBlock("threat_intelligence_allowlist")
{
    /// <summary>
    /// The fqdns attribute.
    /// </summary>
    [TerraformProperty("fqdns")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? Fqdns { get; set; }

    /// <summary>
    /// The ip_addresses attribute.
    /// </summary>
    [TerraformProperty("ip_addresses")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? IpAddresses { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermFirewallPolicyTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Block type for tls_certificate in .
/// Nesting mode: list
/// </summary>
public partial class AzurermFirewallPolicyTlsCertificateBlock() : TerraformBlock("tls_certificate")
{
    /// <summary>
    /// The key_vault_secret_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyVaultSecretId is required")]
    [TerraformProperty("key_vault_secret_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> KeyVaultSecretId { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

}

/// <summary>
/// Manages a azurerm_firewall_policy resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermFirewallPolicy : TerraformResource
{
    public AzurermFirewallPolicy(string name) : base("azurerm_firewall_policy", name)
    {
    }

    /// <summary>
    /// The auto_learn_private_ranges_enabled attribute.
    /// </summary>
    [TerraformProperty("auto_learn_private_ranges_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? AutoLearnPrivateRangesEnabled { get; set; }

    /// <summary>
    /// The base_policy_id attribute.
    /// </summary>
    [TerraformProperty("base_policy_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? BasePolicyId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The private_ip_ranges attribute.
    /// </summary>
    [TerraformProperty("private_ip_ranges")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? PrivateIpRanges { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The sku attribute.
    /// </summary>
    [TerraformProperty("sku")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Sku { get; set; }

    /// <summary>
    /// The sql_redirect_allowed attribute.
    /// </summary>
    [TerraformProperty("sql_redirect_allowed")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? SqlRedirectAllowed { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The threat_intelligence_mode attribute.
    /// </summary>
    [TerraformProperty("threat_intelligence_mode")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ThreatIntelligenceMode { get; set; }

    /// <summary>
    /// Block for dns.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Dns block(s) allowed")]
    [TerraformProperty("dns")]
    public TerraformList<AzurermFirewallPolicyDnsBlock> Dns { get; set; } = new();

    /// <summary>
    /// Block for explicit_proxy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ExplicitProxy block(s) allowed")]
    [TerraformProperty("explicit_proxy")]
    public TerraformList<AzurermFirewallPolicyExplicitProxyBlock> ExplicitProxy { get; set; } = new();

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    [TerraformProperty("identity")]
    public TerraformList<AzurermFirewallPolicyIdentityBlock> Identity { get; set; } = new();

    /// <summary>
    /// Block for insights.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Insights block(s) allowed")]
    [TerraformProperty("insights")]
    public TerraformList<AzurermFirewallPolicyInsightsBlock> Insights { get; set; } = new();

    /// <summary>
    /// Block for intrusion_detection.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IntrusionDetection block(s) allowed")]
    [TerraformProperty("intrusion_detection")]
    public TerraformList<AzurermFirewallPolicyIntrusionDetectionBlock> IntrusionDetection { get; set; } = new();

    /// <summary>
    /// Block for threat_intelligence_allowlist.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ThreatIntelligenceAllowlist block(s) allowed")]
    [TerraformProperty("threat_intelligence_allowlist")]
    public TerraformList<AzurermFirewallPolicyThreatIntelligenceAllowlistBlock> ThreatIntelligenceAllowlist { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermFirewallPolicyTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// Block for tls_certificate.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TlsCertificate block(s) allowed")]
    [TerraformProperty("tls_certificate")]
    public TerraformList<AzurermFirewallPolicyTlsCertificateBlock> TlsCertificate { get; set; } = new();

    /// <summary>
    /// The child_policies attribute.
    /// </summary>
    [TerraformProperty("child_policies")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<string> ChildPolicies { get; }

    /// <summary>
    /// The firewalls attribute.
    /// </summary>
    [TerraformProperty("firewalls")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<string> Firewalls { get; }

    /// <summary>
    /// The rule_collection_groups attribute.
    /// </summary>
    [TerraformProperty("rule_collection_groups")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<string> RuleCollectionGroups { get; }

}
