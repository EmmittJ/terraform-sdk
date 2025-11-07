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
    public TerraformProperty<string>? BuildAgentPoolSize
    {
        get => GetProperty<TerraformProperty<string>>("build_agent_pool_size");
        set => this.WithProperty("build_agent_pool_size", value);
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
    public TerraformProperty<string>? Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The log_stream_public_endpoint_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? LogStreamPublicEndpointEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("log_stream_public_endpoint_enabled");
        set => this.WithProperty("log_stream_public_endpoint_enabled", value);
    }

    /// <summary>
    /// The managed_environment_id attribute.
    /// </summary>
    public TerraformProperty<string>? ManagedEnvironmentId
    {
        get => GetProperty<TerraformProperty<string>>("managed_environment_id");
        set => this.WithProperty("managed_environment_id", value);
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
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformProperty<string>? ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The service_registry_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? ServiceRegistryEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("service_registry_enabled");
        set => this.WithProperty("service_registry_enabled", value);
    }

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    public TerraformProperty<string>? SkuName
    {
        get => GetProperty<TerraformProperty<string>>("sku_name");
        set => this.WithProperty("sku_name", value);
    }

    /// <summary>
    /// The sku_tier attribute.
    /// </summary>
    public TerraformProperty<string>? SkuTier
    {
        get => GetProperty<TerraformProperty<string>>("sku_tier");
        set => this.WithProperty("sku_tier", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The zone_redundant attribute.
    /// </summary>
    public TerraformProperty<bool>? ZoneRedundant
    {
        get => GetProperty<TerraformProperty<bool>>("zone_redundant");
        set => this.WithProperty("zone_redundant", value);
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
