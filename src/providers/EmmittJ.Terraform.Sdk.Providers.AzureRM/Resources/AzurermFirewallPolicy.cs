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
        set => SetProperty("proxy_enabled", value);
    }

    /// <summary>
    /// The servers attribute.
    /// </summary>
    public List<TerraformProperty<string>>? Servers
    {
        set => SetProperty("servers", value);
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
        set => SetProperty("enable_pac_file", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? Enabled
    {
        set => SetProperty("enabled", value);
    }

    /// <summary>
    /// The http_port attribute.
    /// </summary>
    public TerraformProperty<double>? HttpPort
    {
        set => SetProperty("http_port", value);
    }

    /// <summary>
    /// The https_port attribute.
    /// </summary>
    public TerraformProperty<double>? HttpsPort
    {
        set => SetProperty("https_port", value);
    }

    /// <summary>
    /// The pac_file attribute.
    /// </summary>
    public TerraformProperty<string>? PacFile
    {
        set => SetProperty("pac_file", value);
    }

    /// <summary>
    /// The pac_file_port attribute.
    /// </summary>
    public TerraformProperty<double>? PacFilePort
    {
        set => SetProperty("pac_file_port", value);
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
        set => SetProperty("identity_ids", value);
    }

    /// <summary>
    /// The principal_id attribute.
    /// </summary>
    public TerraformProperty<string>? PrincipalId
    {
        set => SetProperty("principal_id", value);
    }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    public TerraformProperty<string>? TenantId
    {
        set => SetProperty("tenant_id", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        set => SetProperty("type", value);
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
        set => SetProperty("default_log_analytics_workspace_id", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformProperty<bool> Enabled
    {
        set => SetProperty("enabled", value);
    }

    /// <summary>
    /// The retention_in_days attribute.
    /// </summary>
    public TerraformProperty<double>? RetentionInDays
    {
        set => SetProperty("retention_in_days", value);
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
        set => SetProperty("mode", value);
    }

    /// <summary>
    /// The private_ranges attribute.
    /// </summary>
    public List<TerraformProperty<string>>? PrivateRanges
    {
        set => SetProperty("private_ranges", value);
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
        set => SetProperty("fqdns", value);
    }

    /// <summary>
    /// The ip_addresses attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? IpAddresses
    {
        set => SetProperty("ip_addresses", value);
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
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
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
        set => SetProperty("key_vault_secret_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        set => SetProperty("name", value);
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
        SetOutput("child_policies");
        SetOutput("firewalls");
        SetOutput("rule_collection_groups");
        SetOutput("auto_learn_private_ranges_enabled");
        SetOutput("base_policy_id");
        SetOutput("id");
        SetOutput("location");
        SetOutput("name");
        SetOutput("private_ip_ranges");
        SetOutput("resource_group_name");
        SetOutput("sku");
        SetOutput("sql_redirect_allowed");
        SetOutput("tags");
        SetOutput("threat_intelligence_mode");
    }

    /// <summary>
    /// The auto_learn_private_ranges_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> AutoLearnPrivateRangesEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("auto_learn_private_ranges_enabled");
        set => SetProperty("auto_learn_private_ranges_enabled", value);
    }

    /// <summary>
    /// The base_policy_id attribute.
    /// </summary>
    public TerraformProperty<string> BasePolicyId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("base_policy_id");
        set => SetProperty("base_policy_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The private_ip_ranges attribute.
    /// </summary>
    public List<TerraformProperty<string>> PrivateIpRanges
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("private_ip_ranges");
        set => SetProperty("private_ip_ranges", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("resource_group_name");
        set => SetProperty("resource_group_name", value);
    }

    /// <summary>
    /// The sku attribute.
    /// </summary>
    public TerraformProperty<string> Sku
    {
        get => GetRequiredOutput<TerraformProperty<string>>("sku");
        set => SetProperty("sku", value);
    }

    /// <summary>
    /// The sql_redirect_allowed attribute.
    /// </summary>
    public TerraformProperty<bool> SqlRedirectAllowed
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("sql_redirect_allowed");
        set => SetProperty("sql_redirect_allowed", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The threat_intelligence_mode attribute.
    /// </summary>
    public TerraformProperty<string> ThreatIntelligenceMode
    {
        get => GetRequiredOutput<TerraformProperty<string>>("threat_intelligence_mode");
        set => SetProperty("threat_intelligence_mode", value);
    }

    /// <summary>
    /// Block for dns.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Dns block(s) allowed")]
    public List<AzurermFirewallPolicyDnsBlock>? Dns
    {
        set => SetProperty("dns", value);
    }

    /// <summary>
    /// Block for explicit_proxy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ExplicitProxy block(s) allowed")]
    public List<AzurermFirewallPolicyExplicitProxyBlock>? ExplicitProxy
    {
        set => SetProperty("explicit_proxy", value);
    }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    public List<AzurermFirewallPolicyIdentityBlock>? Identity
    {
        set => SetProperty("identity", value);
    }

    /// <summary>
    /// Block for insights.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Insights block(s) allowed")]
    public List<AzurermFirewallPolicyInsightsBlock>? Insights
    {
        set => SetProperty("insights", value);
    }

    /// <summary>
    /// Block for intrusion_detection.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IntrusionDetection block(s) allowed")]
    public List<AzurermFirewallPolicyIntrusionDetectionBlock>? IntrusionDetection
    {
        set => SetProperty("intrusion_detection", value);
    }

    /// <summary>
    /// Block for threat_intelligence_allowlist.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ThreatIntelligenceAllowlist block(s) allowed")]
    public List<AzurermFirewallPolicyThreatIntelligenceAllowlistBlock>? ThreatIntelligenceAllowlist
    {
        set => SetProperty("threat_intelligence_allowlist", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermFirewallPolicyTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// Block for tls_certificate.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TlsCertificate block(s) allowed")]
    public List<AzurermFirewallPolicyTlsCertificateBlock>? TlsCertificate
    {
        set => SetProperty("tls_certificate", value);
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
