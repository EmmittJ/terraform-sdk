using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for dns in .
/// Nesting mode: list
/// </summary>
public class AzurermFirewallPolicyDnsBlock : TerraformBlock
{
    /// <summary>
    /// The proxy_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? ProxyEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("proxy_enabled");
        set => WithProperty("proxy_enabled", value);
    }

    /// <summary>
    /// The servers attribute.
    /// </summary>
    public List<TerraformProperty<string>>? Servers
    {
        get => GetProperty<List<TerraformProperty<string>>>("servers");
        set => WithProperty("servers", value);
    }

}

/// <summary>
/// Block type for explicit_proxy in .
/// Nesting mode: list
/// </summary>
public class AzurermFirewallPolicyExplicitProxyBlock : TerraformBlock
{
    /// <summary>
    /// The enable_pac_file attribute.
    /// </summary>
    public TerraformProperty<bool>? EnablePacFile
    {
        get => GetProperty<TerraformProperty<bool>>("enable_pac_file");
        set => WithProperty("enable_pac_file", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? Enabled
    {
        get => GetProperty<TerraformProperty<bool>>("enabled");
        set => WithProperty("enabled", value);
    }

    /// <summary>
    /// The http_port attribute.
    /// </summary>
    public TerraformProperty<double>? HttpPort
    {
        get => GetProperty<TerraformProperty<double>>("http_port");
        set => WithProperty("http_port", value);
    }

    /// <summary>
    /// The https_port attribute.
    /// </summary>
    public TerraformProperty<double>? HttpsPort
    {
        get => GetProperty<TerraformProperty<double>>("https_port");
        set => WithProperty("https_port", value);
    }

    /// <summary>
    /// The pac_file attribute.
    /// </summary>
    public TerraformProperty<string>? PacFile
    {
        get => GetProperty<TerraformProperty<string>>("pac_file");
        set => WithProperty("pac_file", value);
    }

    /// <summary>
    /// The pac_file_port attribute.
    /// </summary>
    public TerraformProperty<double>? PacFilePort
    {
        get => GetProperty<TerraformProperty<double>>("pac_file_port");
        set => WithProperty("pac_file_port", value);
    }

}

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public class AzurermFirewallPolicyIdentityBlock : TerraformBlock
{
    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? IdentityIds
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("identity_ids");
        set => WithProperty("identity_ids", value);
    }

    /// <summary>
    /// The principal_id attribute.
    /// </summary>
    public TerraformProperty<string>? PrincipalId
    {
        get => GetProperty<TerraformProperty<string>>("principal_id");
        set => WithProperty("principal_id", value);
    }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    public TerraformProperty<string>? TenantId
    {
        get => GetProperty<TerraformProperty<string>>("tenant_id");
        set => WithProperty("tenant_id", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        get => GetRequiredProperty<TerraformProperty<string>>("type");
        set => WithProperty("type", value);
    }

}

/// <summary>
/// Block type for insights in .
/// Nesting mode: list
/// </summary>
public class AzurermFirewallPolicyInsightsBlock : TerraformBlock
{
    /// <summary>
    /// The default_log_analytics_workspace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DefaultLogAnalyticsWorkspaceId is required")]
    public required TerraformProperty<string> DefaultLogAnalyticsWorkspaceId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("default_log_analytics_workspace_id");
        set => WithProperty("default_log_analytics_workspace_id", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformProperty<bool> Enabled
    {
        get => GetRequiredProperty<TerraformProperty<bool>>("enabled");
        set => WithProperty("enabled", value);
    }

    /// <summary>
    /// The retention_in_days attribute.
    /// </summary>
    public TerraformProperty<double>? RetentionInDays
    {
        get => GetProperty<TerraformProperty<double>>("retention_in_days");
        set => WithProperty("retention_in_days", value);
    }

}

/// <summary>
/// Block type for intrusion_detection in .
/// Nesting mode: list
/// </summary>
public class AzurermFirewallPolicyIntrusionDetectionBlock : TerraformBlock
{
    /// <summary>
    /// The mode attribute.
    /// </summary>
    public TerraformProperty<string>? Mode
    {
        get => GetProperty<TerraformProperty<string>>("mode");
        set => WithProperty("mode", value);
    }

    /// <summary>
    /// The private_ranges attribute.
    /// </summary>
    public List<TerraformProperty<string>>? PrivateRanges
    {
        get => GetProperty<List<TerraformProperty<string>>>("private_ranges");
        set => WithProperty("private_ranges", value);
    }

}

/// <summary>
/// Block type for threat_intelligence_allowlist in .
/// Nesting mode: list
/// </summary>
public class AzurermFirewallPolicyThreatIntelligenceAllowlistBlock : TerraformBlock
{
    /// <summary>
    /// The fqdns attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? Fqdns
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("fqdns");
        set => WithProperty("fqdns", value);
    }

    /// <summary>
    /// The ip_addresses attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? IpAddresses
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("ip_addresses");
        set => WithProperty("ip_addresses", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermFirewallPolicyTimeoutsBlock : TerraformBlock
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
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
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
/// Block type for tls_certificate in .
/// Nesting mode: list
/// </summary>
public class AzurermFirewallPolicyTlsCertificateBlock : TerraformBlock
{
    /// <summary>
    /// The key_vault_secret_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyVaultSecretId is required")]
    public required TerraformProperty<string> KeyVaultSecretId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("key_vault_secret_id");
        set => WithProperty("key_vault_secret_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
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
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("child_policies");
        this.DeclareOutput("firewalls");
        this.DeclareOutput("rule_collection_groups");
    }

    /// <summary>
    /// The auto_learn_private_ranges_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? AutoLearnPrivateRangesEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("auto_learn_private_ranges_enabled");
        set => this.WithProperty("auto_learn_private_ranges_enabled", value);
    }

    /// <summary>
    /// The base_policy_id attribute.
    /// </summary>
    public TerraformProperty<string>? BasePolicyId
    {
        get => GetProperty<TerraformProperty<string>>("base_policy_id");
        set => this.WithProperty("base_policy_id", value);
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
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The private_ip_ranges attribute.
    /// </summary>
    public List<TerraformProperty<string>>? PrivateIpRanges
    {
        get => GetProperty<List<TerraformProperty<string>>>("private_ip_ranges");
        set => this.WithProperty("private_ip_ranges", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The sku attribute.
    /// </summary>
    public TerraformProperty<string>? Sku
    {
        get => GetProperty<TerraformProperty<string>>("sku");
        set => this.WithProperty("sku", value);
    }

    /// <summary>
    /// The sql_redirect_allowed attribute.
    /// </summary>
    public TerraformProperty<bool>? SqlRedirectAllowed
    {
        get => GetProperty<TerraformProperty<bool>>("sql_redirect_allowed");
        set => this.WithProperty("sql_redirect_allowed", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The threat_intelligence_mode attribute.
    /// </summary>
    public TerraformProperty<string>? ThreatIntelligenceMode
    {
        get => GetProperty<TerraformProperty<string>>("threat_intelligence_mode");
        set => this.WithProperty("threat_intelligence_mode", value);
    }

    /// <summary>
    /// Block for dns.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Dns block(s) allowed")]
    public List<AzurermFirewallPolicyDnsBlock>? Dns
    {
        get => GetProperty<List<AzurermFirewallPolicyDnsBlock>>("dns");
        set => this.WithProperty("dns", value);
    }

    /// <summary>
    /// Block for explicit_proxy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ExplicitProxy block(s) allowed")]
    public List<AzurermFirewallPolicyExplicitProxyBlock>? ExplicitProxy
    {
        get => GetProperty<List<AzurermFirewallPolicyExplicitProxyBlock>>("explicit_proxy");
        set => this.WithProperty("explicit_proxy", value);
    }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    public List<AzurermFirewallPolicyIdentityBlock>? Identity
    {
        get => GetProperty<List<AzurermFirewallPolicyIdentityBlock>>("identity");
        set => this.WithProperty("identity", value);
    }

    /// <summary>
    /// Block for insights.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Insights block(s) allowed")]
    public List<AzurermFirewallPolicyInsightsBlock>? Insights
    {
        get => GetProperty<List<AzurermFirewallPolicyInsightsBlock>>("insights");
        set => this.WithProperty("insights", value);
    }

    /// <summary>
    /// Block for intrusion_detection.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IntrusionDetection block(s) allowed")]
    public List<AzurermFirewallPolicyIntrusionDetectionBlock>? IntrusionDetection
    {
        get => GetProperty<List<AzurermFirewallPolicyIntrusionDetectionBlock>>("intrusion_detection");
        set => this.WithProperty("intrusion_detection", value);
    }

    /// <summary>
    /// Block for threat_intelligence_allowlist.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ThreatIntelligenceAllowlist block(s) allowed")]
    public List<AzurermFirewallPolicyThreatIntelligenceAllowlistBlock>? ThreatIntelligenceAllowlist
    {
        get => GetProperty<List<AzurermFirewallPolicyThreatIntelligenceAllowlistBlock>>("threat_intelligence_allowlist");
        set => this.WithProperty("threat_intelligence_allowlist", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermFirewallPolicyTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermFirewallPolicyTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// Block for tls_certificate.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TlsCertificate block(s) allowed")]
    public List<AzurermFirewallPolicyTlsCertificateBlock>? TlsCertificate
    {
        get => GetProperty<List<AzurermFirewallPolicyTlsCertificateBlock>>("tls_certificate");
        set => this.WithProperty("tls_certificate", value);
    }

    /// <summary>
    /// The child_policies attribute.
    /// </summary>
    public TerraformExpression ChildPolicies => this["child_policies"];

    /// <summary>
    /// The firewalls attribute.
    /// </summary>
    public TerraformExpression Firewalls => this["firewalls"];

    /// <summary>
    /// The rule_collection_groups attribute.
    /// </summary>
    public TerraformExpression RuleCollectionGroups => this["rule_collection_groups"];

}
