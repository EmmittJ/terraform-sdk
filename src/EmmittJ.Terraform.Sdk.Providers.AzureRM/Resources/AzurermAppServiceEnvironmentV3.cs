using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for cluster_setting in .
/// Nesting mode: list
/// </summary>
public class AzurermAppServiceEnvironmentV3ClusterSettingBlock : TerraformBlock
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformProperty<string> Value
    {
        get => GetProperty<TerraformProperty<string>>("value");
        set => WithProperty("value", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermAppServiceEnvironmentV3TimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a azurerm_app_service_environment_v3 resource.
/// </summary>
public class AzurermAppServiceEnvironmentV3 : TerraformResource
{
    public AzurermAppServiceEnvironmentV3(string name) : base("azurerm_app_service_environment_v3", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("dns_suffix");
        this.DeclareOutput("external_inbound_ip_addresses");
        this.DeclareOutput("inbound_network_dependencies");
        this.DeclareOutput("internal_inbound_ip_addresses");
        this.DeclareOutput("ip_ssl_address_count");
        this.DeclareOutput("linux_outbound_ip_addresses");
        this.DeclareOutput("location");
        this.DeclareOutput("pricing_tier");
        this.DeclareOutput("windows_outbound_ip_addresses");
    }

    /// <summary>
    /// The allow_new_private_endpoint_connections attribute.
    /// </summary>
    public TerraformProperty<bool>? AllowNewPrivateEndpointConnections
    {
        get => GetProperty<TerraformProperty<bool>>("allow_new_private_endpoint_connections");
        set => this.WithProperty("allow_new_private_endpoint_connections", value);
    }

    /// <summary>
    /// The dedicated_host_count attribute.
    /// </summary>
    public TerraformProperty<double>? DedicatedHostCount
    {
        get => GetProperty<TerraformProperty<double>>("dedicated_host_count");
        set => this.WithProperty("dedicated_host_count", value);
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
    /// The internal_load_balancing_mode attribute.
    /// </summary>
    public TerraformProperty<string>? InternalLoadBalancingMode
    {
        get => GetProperty<TerraformProperty<string>>("internal_load_balancing_mode");
        set => this.WithProperty("internal_load_balancing_mode", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The remote_debugging_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? RemoteDebuggingEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("remote_debugging_enabled");
        set => this.WithProperty("remote_debugging_enabled", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetId is required")]
    public required TerraformProperty<string> SubnetId
    {
        get => GetProperty<TerraformProperty<string>>("subnet_id");
        set => this.WithProperty("subnet_id", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
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
    /// Block for cluster_setting.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermAppServiceEnvironmentV3ClusterSettingBlock>? ClusterSetting
    {
        get => GetProperty<List<AzurermAppServiceEnvironmentV3ClusterSettingBlock>>("cluster_setting");
        set => this.WithProperty("cluster_setting", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermAppServiceEnvironmentV3TimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermAppServiceEnvironmentV3TimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The dns_suffix attribute.
    /// </summary>
    public TerraformExpression DnsSuffix => this["dns_suffix"];

    /// <summary>
    /// The external_inbound_ip_addresses attribute.
    /// </summary>
    public TerraformExpression ExternalInboundIpAddresses => this["external_inbound_ip_addresses"];

    /// <summary>
    /// The inbound_network_dependencies attribute.
    /// </summary>
    public TerraformExpression InboundNetworkDependencies => this["inbound_network_dependencies"];

    /// <summary>
    /// The internal_inbound_ip_addresses attribute.
    /// </summary>
    public TerraformExpression InternalInboundIpAddresses => this["internal_inbound_ip_addresses"];

    /// <summary>
    /// The ip_ssl_address_count attribute.
    /// </summary>
    public TerraformExpression IpSslAddressCount => this["ip_ssl_address_count"];

    /// <summary>
    /// The linux_outbound_ip_addresses attribute.
    /// </summary>
    public TerraformExpression LinuxOutboundIpAddresses => this["linux_outbound_ip_addresses"];

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformExpression Location => this["location"];

    /// <summary>
    /// The pricing_tier attribute.
    /// </summary>
    public TerraformExpression PricingTier => this["pricing_tier"];

    /// <summary>
    /// The windows_outbound_ip_addresses attribute.
    /// </summary>
    public TerraformExpression WindowsOutboundIpAddresses => this["windows_outbound_ip_addresses"];

}
