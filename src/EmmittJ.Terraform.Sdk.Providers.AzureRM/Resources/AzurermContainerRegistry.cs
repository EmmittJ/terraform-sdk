using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_container_registry resource.
/// </summary>
public class AzurermContainerRegistry : TerraformResource
{
    public AzurermContainerRegistry(string name) : base("azurerm_container_registry", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("admin_password");
        this.DeclareOutput("admin_username");
        this.DeclareOutput("data_endpoint_host_names");
        this.DeclareOutput("login_server");
    }

    /// <summary>
    /// The admin_enabled attribute.
    /// </summary>
    public bool? AdminEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("admin_enabled")?.Value;
        set => this.WithProperty("admin_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The anonymous_pull_enabled attribute.
    /// </summary>
    public bool? AnonymousPullEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("anonymous_pull_enabled")?.Value;
        set => this.WithProperty("anonymous_pull_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The data_endpoint_enabled attribute.
    /// </summary>
    public bool? DataEndpointEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("data_endpoint_enabled")?.Value;
        set => this.WithProperty("data_endpoint_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The encryption attribute.
    /// </summary>
    public List<object>? Encryption
    {
        get => GetProperty<TerraformLiteralProperty<List<object>>>("encryption")?.Value;
        set => this.WithProperty("encryption", value == null ? null : new TerraformLiteralProperty<List<object>>(value));
    }

    /// <summary>
    /// The export_policy_enabled attribute.
    /// </summary>
    public bool? ExportPolicyEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("export_policy_enabled")?.Value;
        set => this.WithProperty("export_policy_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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
    /// The network_rule_set attribute.
    /// </summary>
    public List<object>? NetworkRuleSet
    {
        get => GetProperty<TerraformLiteralProperty<List<object>>>("network_rule_set")?.Value;
        set => this.WithProperty("network_rule_set", value == null ? null : new TerraformLiteralProperty<List<object>>(value));
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
    /// The quarantine_policy_enabled attribute.
    /// </summary>
    public bool? QuarantinePolicyEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("quarantine_policy_enabled")?.Value;
        set => this.WithProperty("quarantine_policy_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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
    /// The retention_policy_in_days attribute.
    /// </summary>
    public double? RetentionPolicyInDays
    {
        get => GetProperty<TerraformLiteralProperty<double>>("retention_policy_in_days")?.Value;
        set => this.WithProperty("retention_policy_in_days", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
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
    /// The trust_policy_enabled attribute.
    /// </summary>
    public bool? TrustPolicyEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("trust_policy_enabled")?.Value;
        set => this.WithProperty("trust_policy_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The zone_redundancy_enabled attribute.
    /// </summary>
    public bool? ZoneRedundancyEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("zone_redundancy_enabled")?.Value;
        set => this.WithProperty("zone_redundancy_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The admin_password attribute.
    /// </summary>
    public TerraformExpression AdminPassword => this["admin_password"];

    /// <summary>
    /// The admin_username attribute.
    /// </summary>
    public TerraformExpression AdminUsername => this["admin_username"];

    /// <summary>
    /// The data_endpoint_host_names attribute.
    /// </summary>
    public TerraformExpression DataEndpointHostNames => this["data_endpoint_host_names"];

    /// <summary>
    /// The login_server attribute.
    /// </summary>
    public TerraformExpression LoginServer => this["login_server"];

}
