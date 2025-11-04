using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_iothub resource.
/// </summary>
public class AzurermIothub : TerraformResource
{
    public AzurermIothub(string name) : base("azurerm_iothub", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("event_hub_events_endpoint");
        this.DeclareOutput("event_hub_events_namespace");
        this.DeclareOutput("event_hub_events_path");
        this.DeclareOutput("event_hub_operations_endpoint");
        this.DeclareOutput("event_hub_operations_path");
        this.DeclareOutput("hostname");
        this.DeclareOutput("shared_access_policy");
        this.DeclareOutput("type");
    }

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    public List<object>? Endpoint
    {
        get => GetProperty<TerraformLiteralProperty<List<object>>>("endpoint")?.Value;
        set => this.WithProperty("endpoint", value == null ? null : new TerraformLiteralProperty<List<object>>(value));
    }

    /// <summary>
    /// The enrichment attribute.
    /// </summary>
    public List<object>? Enrichment
    {
        get => GetProperty<TerraformLiteralProperty<List<object>>>("enrichment")?.Value;
        set => this.WithProperty("enrichment", value == null ? null : new TerraformLiteralProperty<List<object>>(value));
    }

    /// <summary>
    /// The event_hub_partition_count attribute.
    /// </summary>
    public double? EventHubPartitionCount
    {
        get => GetProperty<TerraformLiteralProperty<double>>("event_hub_partition_count")?.Value;
        set => this.WithProperty("event_hub_partition_count", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The event_hub_retention_in_days attribute.
    /// </summary>
    public double? EventHubRetentionInDays
    {
        get => GetProperty<TerraformLiteralProperty<double>>("event_hub_retention_in_days")?.Value;
        set => this.WithProperty("event_hub_retention_in_days", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
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
    /// The min_tls_version attribute.
    /// </summary>
    public string? MinTlsVersion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("min_tls_version")?.Value;
        set => this.WithProperty("min_tls_version", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The route attribute.
    /// </summary>
    public List<object>? Route
    {
        get => GetProperty<TerraformLiteralProperty<List<object>>>("route")?.Value;
        set => this.WithProperty("route", value == null ? null : new TerraformLiteralProperty<List<object>>(value));
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
    /// The event_hub_events_endpoint attribute.
    /// </summary>
    public TerraformExpression EventHubEventsEndpoint => this["event_hub_events_endpoint"];

    /// <summary>
    /// The event_hub_events_namespace attribute.
    /// </summary>
    public TerraformExpression EventHubEventsNamespace => this["event_hub_events_namespace"];

    /// <summary>
    /// The event_hub_events_path attribute.
    /// </summary>
    public TerraformExpression EventHubEventsPath => this["event_hub_events_path"];

    /// <summary>
    /// The event_hub_operations_endpoint attribute.
    /// </summary>
    public TerraformExpression EventHubOperationsEndpoint => this["event_hub_operations_endpoint"];

    /// <summary>
    /// The event_hub_operations_path attribute.
    /// </summary>
    public TerraformExpression EventHubOperationsPath => this["event_hub_operations_path"];

    /// <summary>
    /// The hostname attribute.
    /// </summary>
    public TerraformExpression Hostname => this["hostname"];

    /// <summary>
    /// The shared_access_policy attribute.
    /// </summary>
    public TerraformExpression SharedAccessPolicy => this["shared_access_policy"];

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformExpression Type => this["type"];

}
