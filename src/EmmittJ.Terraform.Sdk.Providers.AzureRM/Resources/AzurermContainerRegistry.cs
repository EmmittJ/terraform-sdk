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
    public TerraformLiteralProperty<bool>? AdminEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("admin_enabled");
        set => this.WithProperty("admin_enabled", value);
    }

    /// <summary>
    /// The anonymous_pull_enabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? AnonymousPullEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("anonymous_pull_enabled");
        set => this.WithProperty("anonymous_pull_enabled", value);
    }

    /// <summary>
    /// The data_endpoint_enabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? DataEndpointEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("data_endpoint_enabled");
        set => this.WithProperty("data_endpoint_enabled", value);
    }

    /// <summary>
    /// The encryption attribute.
    /// </summary>
    public TerraformLiteralProperty<List<object>>? Encryption
    {
        get => GetProperty<TerraformLiteralProperty<List<object>>>("encryption");
        set => this.WithProperty("encryption", value);
    }

    /// <summary>
    /// The export_policy_enabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? ExportPolicyEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("export_policy_enabled");
        set => this.WithProperty("export_policy_enabled", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The network_rule_bypass_option attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? NetworkRuleBypassOption
    {
        get => GetProperty<TerraformLiteralProperty<string>>("network_rule_bypass_option");
        set => this.WithProperty("network_rule_bypass_option", value);
    }

    /// <summary>
    /// The network_rule_set attribute.
    /// </summary>
    public TerraformLiteralProperty<List<object>>? NetworkRuleSet
    {
        get => GetProperty<TerraformLiteralProperty<List<object>>>("network_rule_set");
        set => this.WithProperty("network_rule_set", value);
    }

    /// <summary>
    /// The public_network_access_enabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? PublicNetworkAccessEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("public_network_access_enabled");
        set => this.WithProperty("public_network_access_enabled", value);
    }

    /// <summary>
    /// The quarantine_policy_enabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? QuarantinePolicyEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("quarantine_policy_enabled");
        set => this.WithProperty("quarantine_policy_enabled", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The retention_policy_in_days attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? RetentionPolicyInDays
    {
        get => GetProperty<TerraformLiteralProperty<double>>("retention_policy_in_days");
        set => this.WithProperty("retention_policy_in_days", value);
    }

    /// <summary>
    /// The sku attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Sku
    {
        get => GetProperty<TerraformLiteralProperty<string>>("sku");
        set => this.WithProperty("sku", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The trust_policy_enabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? TrustPolicyEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("trust_policy_enabled");
        set => this.WithProperty("trust_policy_enabled", value);
    }

    /// <summary>
    /// The zone_redundancy_enabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? ZoneRedundancyEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("zone_redundancy_enabled");
        set => this.WithProperty("zone_redundancy_enabled", value);
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
