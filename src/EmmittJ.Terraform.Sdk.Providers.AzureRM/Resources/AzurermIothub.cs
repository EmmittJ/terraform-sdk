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
    public TerraformProperty<List<object>>? Endpoint
    {
        get => GetProperty<TerraformProperty<List<object>>>("endpoint");
        set => this.WithProperty("endpoint", value);
    }

    /// <summary>
    /// The enrichment attribute.
    /// </summary>
    public TerraformProperty<List<object>>? Enrichment
    {
        get => GetProperty<TerraformProperty<List<object>>>("enrichment");
        set => this.WithProperty("enrichment", value);
    }

    /// <summary>
    /// The event_hub_partition_count attribute.
    /// </summary>
    public TerraformProperty<double>? EventHubPartitionCount
    {
        get => GetProperty<TerraformProperty<double>>("event_hub_partition_count");
        set => this.WithProperty("event_hub_partition_count", value);
    }

    /// <summary>
    /// The event_hub_retention_in_days attribute.
    /// </summary>
    public TerraformProperty<double>? EventHubRetentionInDays
    {
        get => GetProperty<TerraformProperty<double>>("event_hub_retention_in_days");
        set => this.WithProperty("event_hub_retention_in_days", value);
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
    /// The local_authentication_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? LocalAuthenticationEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("local_authentication_enabled");
        set => this.WithProperty("local_authentication_enabled", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformProperty<string>? Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The min_tls_version attribute.
    /// </summary>
    public TerraformProperty<string>? MinTlsVersion
    {
        get => GetProperty<TerraformProperty<string>>("min_tls_version");
        set => this.WithProperty("min_tls_version", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The public_network_access_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? PublicNetworkAccessEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("public_network_access_enabled");
        set => this.WithProperty("public_network_access_enabled", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformProperty<string>? ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The route attribute.
    /// </summary>
    public TerraformProperty<List<object>>? Route
    {
        get => GetProperty<TerraformProperty<List<object>>>("route");
        set => this.WithProperty("route", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMapProperty<string>? Tags
    {
        get => GetProperty<TerraformMapProperty<string>>("tags");
        set => this.WithProperty("tags", value);
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
