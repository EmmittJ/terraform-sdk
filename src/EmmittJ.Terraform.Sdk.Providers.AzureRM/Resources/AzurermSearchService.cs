using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_search_service resource.
/// </summary>
public class AzurermSearchService : TerraformResource
{
    public AzurermSearchService(string name) : base("azurerm_search_service", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("customer_managed_key_encryption_compliance_status");
        this.DeclareOutput("primary_key");
        this.DeclareOutput("query_keys");
        this.DeclareOutput("secondary_key");
    }

    /// <summary>
    /// The allowed_ips attribute.
    /// </summary>
    public HashSet<string>? AllowedIps
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("allowed_ips")?.Value;
        set => this.WithProperty("allowed_ips", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The authentication_failure_mode attribute.
    /// </summary>
    public string? AuthenticationFailureMode
    {
        get => GetProperty<TerraformLiteralProperty<string>>("authentication_failure_mode")?.Value;
        set => this.WithProperty("authentication_failure_mode", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The customer_managed_key_enforcement_enabled attribute.
    /// </summary>
    public bool? CustomerManagedKeyEnforcementEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("customer_managed_key_enforcement_enabled")?.Value;
        set => this.WithProperty("customer_managed_key_enforcement_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The hosting_mode attribute.
    /// </summary>
    public string? HostingMode
    {
        get => GetProperty<TerraformLiteralProperty<string>>("hosting_mode")?.Value;
        set => this.WithProperty("hosting_mode", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The local_authentication_enabled attribute.
    /// </summary>
    public bool? LocalAuthenticationEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("local_authentication_enabled")?.Value;
        set => this.WithProperty("local_authentication_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public string? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location")?.Value;
        set => this.WithProperty("location", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The network_rule_bypass_option attribute.
    /// </summary>
    public string? NetworkRuleBypassOption
    {
        get => GetProperty<TerraformLiteralProperty<string>>("network_rule_bypass_option")?.Value;
        set => this.WithProperty("network_rule_bypass_option", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The partition_count attribute.
    /// </summary>
    public double? PartitionCount
    {
        get => GetProperty<TerraformLiteralProperty<double>>("partition_count")?.Value;
        set => this.WithProperty("partition_count", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The public_network_access_enabled attribute.
    /// </summary>
    public bool? PublicNetworkAccessEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("public_network_access_enabled")?.Value;
        set => this.WithProperty("public_network_access_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The replica_count attribute.
    /// </summary>
    public double? ReplicaCount
    {
        get => GetProperty<TerraformLiteralProperty<double>>("replica_count")?.Value;
        set => this.WithProperty("replica_count", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public string? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name")?.Value;
        set => this.WithProperty("resource_group_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The semantic_search_sku attribute.
    /// </summary>
    public string? SemanticSearchSku
    {
        get => GetProperty<TerraformLiteralProperty<string>>("semantic_search_sku")?.Value;
        set => this.WithProperty("semantic_search_sku", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The sku attribute.
    /// </summary>
    public string? Sku
    {
        get => GetProperty<TerraformLiteralProperty<string>>("sku")?.Value;
        set => this.WithProperty("sku", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The customer_managed_key_encryption_compliance_status attribute.
    /// </summary>
    public TerraformExpression CustomerManagedKeyEncryptionComplianceStatus => this["customer_managed_key_encryption_compliance_status"];

    /// <summary>
    /// The primary_key attribute.
    /// </summary>
    public TerraformExpression PrimaryKey => this["primary_key"];

    /// <summary>
    /// The query_keys attribute.
    /// </summary>
    public TerraformExpression QueryKeys => this["query_keys"];

    /// <summary>
    /// The secondary_key attribute.
    /// </summary>
    public TerraformExpression SecondaryKey => this["secondary_key"];

}
