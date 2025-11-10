using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for authentication in .
/// Nesting mode: list
/// </summary>
public class AzurermServiceFabricManagedClusterAuthenticationBlock : TerraformBlock
{
}

/// <summary>
/// Block type for custom_fabric_setting in .
/// Nesting mode: list
/// </summary>
public class AzurermServiceFabricManagedClusterCustomFabricSettingBlock : TerraformBlock
{
    /// <summary>
    /// The parameter attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Parameter is required")]
    public required TerraformProperty<string> Parameter
    {
        get => GetProperty<TerraformProperty<string>>("parameter");
        set => WithProperty("parameter", value);
    }

    /// <summary>
    /// The section attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Section is required")]
    public required TerraformProperty<string> Section
    {
        get => GetProperty<TerraformProperty<string>>("section");
        set => WithProperty("section", value);
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
/// Block type for lb_rule in .
/// Nesting mode: list
/// </summary>
public class AzurermServiceFabricManagedClusterLbRuleBlock : TerraformBlock
{
    /// <summary>
    /// The backend_port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BackendPort is required")]
    public required TerraformProperty<double> BackendPort
    {
        get => GetProperty<TerraformProperty<double>>("backend_port");
        set => WithProperty("backend_port", value);
    }

    /// <summary>
    /// The frontend_port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FrontendPort is required")]
    public required TerraformProperty<double> FrontendPort
    {
        get => GetProperty<TerraformProperty<double>>("frontend_port");
        set => WithProperty("frontend_port", value);
    }

    /// <summary>
    /// The probe_protocol attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProbeProtocol is required")]
    public required TerraformProperty<string> ProbeProtocol
    {
        get => GetProperty<TerraformProperty<string>>("probe_protocol");
        set => WithProperty("probe_protocol", value);
    }

    /// <summary>
    /// The probe_request_path attribute.
    /// </summary>
    public TerraformProperty<string>? ProbeRequestPath
    {
        get => GetProperty<TerraformProperty<string>>("probe_request_path");
        set => WithProperty("probe_request_path", value);
    }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Protocol is required")]
    public required TerraformProperty<string> Protocol
    {
        get => GetProperty<TerraformProperty<string>>("protocol");
        set => WithProperty("protocol", value);
    }

}

/// <summary>
/// Block type for node_type in .
/// Nesting mode: list
/// </summary>
public class AzurermServiceFabricManagedClusterNodeTypeBlock : TerraformBlock
{
    /// <summary>
    /// The application_port_range attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApplicationPortRange is required")]
    public required TerraformProperty<string> ApplicationPortRange
    {
        get => GetProperty<TerraformProperty<string>>("application_port_range");
        set => WithProperty("application_port_range", value);
    }

    /// <summary>
    /// The capacities attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Capacities
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("capacities");
        set => WithProperty("capacities", value);
    }

    /// <summary>
    /// The data_disk_size_gb attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataDiskSizeGb is required")]
    public required TerraformProperty<double> DataDiskSizeGb
    {
        get => GetProperty<TerraformProperty<double>>("data_disk_size_gb");
        set => WithProperty("data_disk_size_gb", value);
    }

    /// <summary>
    /// The data_disk_type attribute.
    /// </summary>
    public TerraformProperty<string>? DataDiskType
    {
        get => GetProperty<TerraformProperty<string>>("data_disk_type");
        set => WithProperty("data_disk_type", value);
    }

    /// <summary>
    /// The ephemeral_port_range attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EphemeralPortRange is required")]
    public required TerraformProperty<string> EphemeralPortRange
    {
        get => GetProperty<TerraformProperty<string>>("ephemeral_port_range");
        set => WithProperty("ephemeral_port_range", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => WithProperty("id", value);
    }

    /// <summary>
    /// The multiple_placement_groups_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? MultiplePlacementGroupsEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("multiple_placement_groups_enabled");
        set => WithProperty("multiple_placement_groups_enabled", value);
    }

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
    /// The placement_properties attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? PlacementProperties
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("placement_properties");
        set => WithProperty("placement_properties", value);
    }

    /// <summary>
    /// The primary attribute.
    /// </summary>
    public TerraformProperty<bool>? Primary
    {
        get => GetProperty<TerraformProperty<bool>>("primary");
        set => WithProperty("primary", value);
    }

    /// <summary>
    /// The stateless attribute.
    /// </summary>
    public TerraformProperty<bool>? Stateless
    {
        get => GetProperty<TerraformProperty<bool>>("stateless");
        set => WithProperty("stateless", value);
    }

    /// <summary>
    /// The vm_image_offer attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VmImageOffer is required")]
    public required TerraformProperty<string> VmImageOffer
    {
        get => GetProperty<TerraformProperty<string>>("vm_image_offer");
        set => WithProperty("vm_image_offer", value);
    }

    /// <summary>
    /// The vm_image_publisher attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VmImagePublisher is required")]
    public required TerraformProperty<string> VmImagePublisher
    {
        get => GetProperty<TerraformProperty<string>>("vm_image_publisher");
        set => WithProperty("vm_image_publisher", value);
    }

    /// <summary>
    /// The vm_image_sku attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VmImageSku is required")]
    public required TerraformProperty<string> VmImageSku
    {
        get => GetProperty<TerraformProperty<string>>("vm_image_sku");
        set => WithProperty("vm_image_sku", value);
    }

    /// <summary>
    /// The vm_image_version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VmImageVersion is required")]
    public required TerraformProperty<string> VmImageVersion
    {
        get => GetProperty<TerraformProperty<string>>("vm_image_version");
        set => WithProperty("vm_image_version", value);
    }

    /// <summary>
    /// The vm_instance_count attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VmInstanceCount is required")]
    public required TerraformProperty<double> VmInstanceCount
    {
        get => GetProperty<TerraformProperty<double>>("vm_instance_count");
        set => WithProperty("vm_instance_count", value);
    }

    /// <summary>
    /// The vm_size attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VmSize is required")]
    public required TerraformProperty<string> VmSize
    {
        get => GetProperty<TerraformProperty<string>>("vm_size");
        set => WithProperty("vm_size", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermServiceFabricManagedClusterTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_service_fabric_managed_cluster resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermServiceFabricManagedCluster : TerraformResource
{
    public AzurermServiceFabricManagedCluster(string name) : base("azurerm_service_fabric_managed_cluster", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The backup_service_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? BackupServiceEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("backup_service_enabled");
        set => this.WithProperty("backup_service_enabled", value);
    }

    /// <summary>
    /// The client_connection_port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientConnectionPort is required")]
    public required TerraformProperty<double> ClientConnectionPort
    {
        get => GetProperty<TerraformProperty<double>>("client_connection_port");
        set => this.WithProperty("client_connection_port", value);
    }

    /// <summary>
    /// The dns_name attribute.
    /// </summary>
    public TerraformProperty<string>? DnsName
    {
        get => GetProperty<TerraformProperty<string>>("dns_name");
        set => this.WithProperty("dns_name", value);
    }

    /// <summary>
    /// The dns_service_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? DnsServiceEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("dns_service_enabled");
        set => this.WithProperty("dns_service_enabled", value);
    }

    /// <summary>
    /// The http_gateway_port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HttpGatewayPort is required")]
    public required TerraformProperty<double> HttpGatewayPort
    {
        get => GetProperty<TerraformProperty<double>>("http_gateway_port");
        set => this.WithProperty("http_gateway_port", value);
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
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
    /// The password attribute.
    /// </summary>
    public TerraformProperty<string>? Password
    {
        get => GetProperty<TerraformProperty<string>>("password");
        set => this.WithProperty("password", value);
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
    /// The sku attribute.
    /// </summary>
    public TerraformProperty<string>? Sku
    {
        get => GetProperty<TerraformProperty<string>>("sku");
        set => this.WithProperty("sku", value);
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    public TerraformProperty<string>? SubnetId
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
    /// The upgrade_wave attribute.
    /// </summary>
    public TerraformProperty<string>? UpgradeWave
    {
        get => GetProperty<TerraformProperty<string>>("upgrade_wave");
        set => this.WithProperty("upgrade_wave", value);
    }

    /// <summary>
    /// The username attribute.
    /// </summary>
    public TerraformProperty<string>? Username
    {
        get => GetProperty<TerraformProperty<string>>("username");
        set => this.WithProperty("username", value);
    }

    /// <summary>
    /// Block for authentication.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Authentication block(s) allowed")]
    public List<AzurermServiceFabricManagedClusterAuthenticationBlock>? Authentication
    {
        get => GetProperty<List<AzurermServiceFabricManagedClusterAuthenticationBlock>>("authentication");
        set => this.WithProperty("authentication", value);
    }

    /// <summary>
    /// Block for custom_fabric_setting.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermServiceFabricManagedClusterCustomFabricSettingBlock>? CustomFabricSetting
    {
        get => GetProperty<List<AzurermServiceFabricManagedClusterCustomFabricSettingBlock>>("custom_fabric_setting");
        set => this.WithProperty("custom_fabric_setting", value);
    }

    /// <summary>
    /// Block for lb_rule.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 LbRule block(s) required")]
    public List<AzurermServiceFabricManagedClusterLbRuleBlock>? LbRule
    {
        get => GetProperty<List<AzurermServiceFabricManagedClusterLbRuleBlock>>("lb_rule");
        set => this.WithProperty("lb_rule", value);
    }

    /// <summary>
    /// Block for node_type.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermServiceFabricManagedClusterNodeTypeBlock>? NodeType
    {
        get => GetProperty<List<AzurermServiceFabricManagedClusterNodeTypeBlock>>("node_type");
        set => this.WithProperty("node_type", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermServiceFabricManagedClusterTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermServiceFabricManagedClusterTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
