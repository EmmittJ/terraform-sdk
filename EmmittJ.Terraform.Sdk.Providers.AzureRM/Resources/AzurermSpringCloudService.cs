using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_spring_cloud_service resource.
/// </summary>
public class AzurermSpringCloudService : TerraformResource
{
    public AzurermSpringCloudService(string name) : base("azurerm_spring_cloud_service", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("outbound_public_ip_addresses");
        this.DeclareOutput("required_network_traffic_rules");
        this.DeclareOutput("service_registry_id");
    }

    /// <summary>
    /// The build_agent_pool_size attribute.
    /// </summary>
    public string? BuildAgentPoolSize
    {
        get => GetProperty<TerraformLiteralProperty<string>>("build_agent_pool_size")?.Value;
        set => this.WithProperty("build_agent_pool_size", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The log_stream_public_endpoint_enabled attribute.
    /// </summary>
    public bool? LogStreamPublicEndpointEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("log_stream_public_endpoint_enabled")?.Value;
        set => this.WithProperty("log_stream_public_endpoint_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The managed_environment_id attribute.
    /// </summary>
    public string? ManagedEnvironmentId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("managed_environment_id")?.Value;
        set => this.WithProperty("managed_environment_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The resource_group_name attribute.
    /// </summary>
    public string? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name")?.Value;
        set => this.WithProperty("resource_group_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The service_registry_enabled attribute.
    /// </summary>
    public bool? ServiceRegistryEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("service_registry_enabled")?.Value;
        set => this.WithProperty("service_registry_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    public string? SkuName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("sku_name")?.Value;
        set => this.WithProperty("sku_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The sku_tier attribute.
    /// </summary>
    public string? SkuTier
    {
        get => GetProperty<TerraformLiteralProperty<string>>("sku_tier")?.Value;
        set => this.WithProperty("sku_tier", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The zone_redundant attribute.
    /// </summary>
    public bool? ZoneRedundant
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("zone_redundant")?.Value;
        set => this.WithProperty("zone_redundant", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The outbound_public_ip_addresses attribute.
    /// </summary>
    public TerraformExpression OutboundPublicIpAddresses => this["outbound_public_ip_addresses"];

    /// <summary>
    /// The required_network_traffic_rules attribute.
    /// </summary>
    public TerraformExpression RequiredNetworkTrafficRules => this["required_network_traffic_rules"];

    /// <summary>
    /// The service_registry_id attribute.
    /// </summary>
    public TerraformExpression ServiceRegistryId => this["service_registry_id"];

}
