using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for dns in .
/// Nesting mode: list
/// </summary>
public class AzurermFirewallPolicyDnsBlock : ITerraformBlock
{
    /// <summary>
    /// The proxy_enabled attribute.
    /// </summary>
    [TerraformPropertyName("proxy_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? ProxyEnabled { get; set; }

    /// <summary>
    /// The servers attribute.
    /// </summary>
    [TerraformPropertyName("servers")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? Servers { get; set; }

}

/// <summary>
/// Block type for explicit_proxy in .
/// Nesting mode: list
/// </summary>
public class AzurermFirewallPolicyExplicitProxyBlock : ITerraformBlock
{
    /// <summary>
    /// The enable_pac_file attribute.
    /// </summary>
    [TerraformPropertyName("enable_pac_file")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? EnablePacFile { get; set; }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformPropertyName("enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? Enabled { get; set; }

    /// <summary>
    /// The http_port attribute.
    /// </summary>
    [TerraformPropertyName("http_port")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? HttpPort { get; set; }

    /// <summary>
    /// The https_port attribute.
    /// </summary>
    [TerraformPropertyName("https_port")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? HttpsPort { get; set; }

    /// <summary>
    /// The pac_file attribute.
    /// </summary>
    [TerraformPropertyName("pac_file")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? PacFile { get; set; }

    /// <summary>
    /// The pac_file_port attribute.
    /// </summary>
    [TerraformPropertyName("pac_file_port")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? PacFilePort { get; set; }

}

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public class AzurermFirewallPolicyIdentityBlock : ITerraformBlock
{
    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    [TerraformPropertyName("identity_ids")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? IdentityIds { get; set; }

    /// <summary>
    /// The principal_id attribute.
    /// </summary>
    [TerraformPropertyName("principal_id")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PrincipalId => new TerraformReferenceProperty<TerraformProperty<string>>("", "principal_id");

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    [TerraformPropertyName("tenant_id")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> TenantId => new TerraformReferenceProperty<TerraformProperty<string>>("", "tenant_id");

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformPropertyName("type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Type { get; set; }

}

/// <summary>
/// Block type for insights in .
/// Nesting mode: list
/// </summary>
public class AzurermFirewallPolicyInsightsBlock : ITerraformBlock
{
    /// <summary>
    /// The default_log_analytics_workspace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DefaultLogAnalyticsWorkspaceId is required")]
    [TerraformPropertyName("default_log_analytics_workspace_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> DefaultLogAnalyticsWorkspaceId { get; set; }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    [TerraformPropertyName("enabled")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<bool>> Enabled { get; set; }

    /// <summary>
    /// The retention_in_days attribute.
    /// </summary>
    [TerraformPropertyName("retention_in_days")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? RetentionInDays { get; set; }

}

/// <summary>
/// Block type for intrusion_detection in .
/// Nesting mode: list
/// </summary>
public class AzurermFirewallPolicyIntrusionDetectionBlock : ITerraformBlock
{
    /// <summary>
    /// The mode attribute.
    /// </summary>
    [TerraformPropertyName("mode")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Mode { get; set; }

    /// <summary>
    /// The private_ranges attribute.
    /// </summary>
    [TerraformPropertyName("private_ranges")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? PrivateRanges { get; set; }

}

/// <summary>
/// Block type for threat_intelligence_allowlist in .
/// Nesting mode: list
/// </summary>
public class AzurermFirewallPolicyThreatIntelligenceAllowlistBlock : ITerraformBlock
{
    /// <summary>
    /// The fqdns attribute.
    /// </summary>
    [TerraformPropertyName("fqdns")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? Fqdns { get; set; }

    /// <summary>
    /// The ip_addresses attribute.
    /// </summary>
    [TerraformPropertyName("ip_addresses")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? IpAddresses { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermFirewallPolicyTimeoutsBlock : ITerraformBlock
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
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Block type for tls_certificate in .
/// Nesting mode: list
/// </summary>
public class AzurermFirewallPolicyTlsCertificateBlock : ITerraformBlock
{
    /// <summary>
    /// The key_vault_secret_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyVaultSecretId is required")]
    [TerraformPropertyName("key_vault_secret_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> KeyVaultSecretId { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

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
    [TerraformPropertyName("auto_learn_private_ranges_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? AutoLearnPrivateRangesEnabled { get; set; }

    /// <summary>
    /// The base_policy_id attribute.
    /// </summary>
    [TerraformPropertyName("base_policy_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? BasePolicyId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Location { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The private_ip_ranges attribute.
    /// </summary>
    [TerraformPropertyName("private_ip_ranges")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? PrivateIpRanges { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ResourceGroupName { get; set; }

    /// <summary>
    /// The sku attribute.
    /// </summary>
    [TerraformPropertyName("sku")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Sku { get; set; }

    /// <summary>
    /// The sql_redirect_allowed attribute.
    /// </summary>
    [TerraformPropertyName("sql_redirect_allowed")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? SqlRedirectAllowed { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// The threat_intelligence_mode attribute.
    /// </summary>
    [TerraformPropertyName("threat_intelligence_mode")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ThreatIntelligenceMode { get; set; }

    /// <summary>
    /// Block for dns.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Dns block(s) allowed")]
    [TerraformPropertyName("dns")]
    public TerraformList<TerraformBlock<AzurermFirewallPolicyDnsBlock>>? Dns { get; set; } = new();

    /// <summary>
    /// Block for explicit_proxy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ExplicitProxy block(s) allowed")]
    [TerraformPropertyName("explicit_proxy")]
    public TerraformList<TerraformBlock<AzurermFirewallPolicyExplicitProxyBlock>>? ExplicitProxy { get; set; } = new();

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    [TerraformPropertyName("identity")]
    public TerraformList<TerraformBlock<AzurermFirewallPolicyIdentityBlock>>? Identity { get; set; } = new();

    /// <summary>
    /// Block for insights.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Insights block(s) allowed")]
    [TerraformPropertyName("insights")]
    public TerraformList<TerraformBlock<AzurermFirewallPolicyInsightsBlock>>? Insights { get; set; } = new();

    /// <summary>
    /// Block for intrusion_detection.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IntrusionDetection block(s) allowed")]
    [TerraformPropertyName("intrusion_detection")]
    public TerraformList<TerraformBlock<AzurermFirewallPolicyIntrusionDetectionBlock>>? IntrusionDetection { get; set; } = new();

    /// <summary>
    /// Block for threat_intelligence_allowlist.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ThreatIntelligenceAllowlist block(s) allowed")]
    [TerraformPropertyName("threat_intelligence_allowlist")]
    public TerraformList<TerraformBlock<AzurermFirewallPolicyThreatIntelligenceAllowlistBlock>>? ThreatIntelligenceAllowlist { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermFirewallPolicyTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// Block for tls_certificate.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TlsCertificate block(s) allowed")]
    [TerraformPropertyName("tls_certificate")]
    public TerraformList<TerraformBlock<AzurermFirewallPolicyTlsCertificateBlock>>? TlsCertificate { get; set; } = new();

    /// <summary>
    /// The child_policies attribute.
    /// </summary>
    [TerraformPropertyName("child_policies")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> ChildPolicies => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "child_policies");

    /// <summary>
    /// The firewalls attribute.
    /// </summary>
    [TerraformPropertyName("firewalls")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> Firewalls => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "firewalls");

    /// <summary>
    /// The rule_collection_groups attribute.
    /// </summary>
    [TerraformPropertyName("rule_collection_groups")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> RuleCollectionGroups => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "rule_collection_groups");

}
