using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_eventhub_namespace resource.
/// </summary>
public class AzurermEventhubNamespace : TerraformResource
{
    public AzurermEventhubNamespace(string name) : base("azurerm_eventhub_namespace", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("default_primary_connection_string");
        this.DeclareOutput("default_primary_connection_string_alias");
        this.DeclareOutput("default_primary_key");
        this.DeclareOutput("default_secondary_connection_string");
        this.DeclareOutput("default_secondary_connection_string_alias");
        this.DeclareOutput("default_secondary_key");
    }

    /// <summary>
    /// The auto_inflate_enabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? AutoInflateEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("auto_inflate_enabled");
        set => this.WithProperty("auto_inflate_enabled", value);
    }

    /// <summary>
    /// The capacity attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? Capacity
    {
        get => GetProperty<TerraformLiteralProperty<double>>("capacity");
        set => this.WithProperty("capacity", value);
    }

    /// <summary>
    /// The dedicated_cluster_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? DedicatedClusterId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("dedicated_cluster_id");
        set => this.WithProperty("dedicated_cluster_id", value);
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
    /// The local_authentication_enabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? LocalAuthenticationEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("local_authentication_enabled");
        set => this.WithProperty("local_authentication_enabled", value);
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
    /// The maximum_throughput_units attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? MaximumThroughputUnits
    {
        get => GetProperty<TerraformLiteralProperty<double>>("maximum_throughput_units");
        set => this.WithProperty("maximum_throughput_units", value);
    }

    /// <summary>
    /// The minimum_tls_version attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? MinimumTlsVersion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("minimum_tls_version");
        set => this.WithProperty("minimum_tls_version", value);
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
    /// The network_rulesets attribute.
    /// </summary>
    public TerraformLiteralProperty<List<object>>? NetworkRulesets
    {
        get => GetProperty<TerraformLiteralProperty<List<object>>>("network_rulesets");
        set => this.WithProperty("network_rulesets", value);
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
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
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
    /// The default_primary_connection_string attribute.
    /// </summary>
    public TerraformExpression DefaultPrimaryConnectionString => this["default_primary_connection_string"];

    /// <summary>
    /// The default_primary_connection_string_alias attribute.
    /// </summary>
    public TerraformExpression DefaultPrimaryConnectionStringAlias => this["default_primary_connection_string_alias"];

    /// <summary>
    /// The default_primary_key attribute.
    /// </summary>
    public TerraformExpression DefaultPrimaryKey => this["default_primary_key"];

    /// <summary>
    /// The default_secondary_connection_string attribute.
    /// </summary>
    public TerraformExpression DefaultSecondaryConnectionString => this["default_secondary_connection_string"];

    /// <summary>
    /// The default_secondary_connection_string_alias attribute.
    /// </summary>
    public TerraformExpression DefaultSecondaryConnectionStringAlias => this["default_secondary_connection_string_alias"];

    /// <summary>
    /// The default_secondary_key attribute.
    /// </summary>
    public TerraformExpression DefaultSecondaryKey => this["default_secondary_key"];

}
