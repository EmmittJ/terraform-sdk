using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_servicebus_namespace resource.
/// </summary>
public class AzurermServicebusNamespace : TerraformResource
{
    public AzurermServicebusNamespace(string name) : base("azurerm_servicebus_namespace", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("default_primary_connection_string");
        this.DeclareOutput("default_primary_key");
        this.DeclareOutput("default_secondary_connection_string");
        this.DeclareOutput("default_secondary_key");
        this.DeclareOutput("endpoint");
    }

    /// <summary>
    /// The capacity attribute.
    /// </summary>
    public double? Capacity
    {
        get => GetProperty<TerraformLiteralProperty<double>>("capacity")?.Value;
        set => this.WithProperty("capacity", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
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
    /// The local_auth_enabled attribute.
    /// </summary>
    public bool? LocalAuthEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("local_auth_enabled")?.Value;
        set => this.WithProperty("local_auth_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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
    /// The minimum_tls_version attribute.
    /// </summary>
    public string? MinimumTlsVersion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("minimum_tls_version")?.Value;
        set => this.WithProperty("minimum_tls_version", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The premium_messaging_partitions attribute.
    /// </summary>
    public double? PremiumMessagingPartitions
    {
        get => GetProperty<TerraformLiteralProperty<double>>("premium_messaging_partitions")?.Value;
        set => this.WithProperty("premium_messaging_partitions", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
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
    /// The resource_group_name attribute.
    /// </summary>
    public string? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name")?.Value;
        set => this.WithProperty("resource_group_name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The default_primary_connection_string attribute.
    /// </summary>
    public TerraformExpression DefaultPrimaryConnectionString => this["default_primary_connection_string"];

    /// <summary>
    /// The default_primary_key attribute.
    /// </summary>
    public TerraformExpression DefaultPrimaryKey => this["default_primary_key"];

    /// <summary>
    /// The default_secondary_connection_string attribute.
    /// </summary>
    public TerraformExpression DefaultSecondaryConnectionString => this["default_secondary_connection_string"];

    /// <summary>
    /// The default_secondary_key attribute.
    /// </summary>
    public TerraformExpression DefaultSecondaryKey => this["default_secondary_key"];

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    public TerraformExpression Endpoint => this["endpoint"];

}
