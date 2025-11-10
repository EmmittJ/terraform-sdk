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
        set => SetProperty("parameter", value);
    }

    /// <summary>
    /// The section attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Section is required")]
    public required TerraformProperty<string> Section
    {
        set => SetProperty("section", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformProperty<string> Value
    {
        set => SetProperty("value", value);
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
        set => SetProperty("backend_port", value);
    }

    /// <summary>
    /// The frontend_port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FrontendPort is required")]
    public required TerraformProperty<double> FrontendPort
    {
        set => SetProperty("frontend_port", value);
    }

    /// <summary>
    /// The probe_protocol attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProbeProtocol is required")]
    public required TerraformProperty<string> ProbeProtocol
    {
        set => SetProperty("probe_protocol", value);
    }

    /// <summary>
    /// The probe_request_path attribute.
    /// </summary>
    public TerraformProperty<string>? ProbeRequestPath
    {
        set => SetProperty("probe_request_path", value);
    }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Protocol is required")]
    public required TerraformProperty<string> Protocol
    {
        set => SetProperty("protocol", value);
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
        set => SetProperty("application_port_range", value);
    }

    /// <summary>
    /// The capacities attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Capacities
    {
        set => SetProperty("capacities", value);
    }

    /// <summary>
    /// The data_disk_size_gb attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataDiskSizeGb is required")]
    public required TerraformProperty<double> DataDiskSizeGb
    {
        set => SetProperty("data_disk_size_gb", value);
    }

    /// <summary>
    /// The data_disk_type attribute.
    /// </summary>
    public TerraformProperty<string>? DataDiskType
    {
        set => SetProperty("data_disk_type", value);
    }

    /// <summary>
    /// The ephemeral_port_range attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EphemeralPortRange is required")]
    public required TerraformProperty<string> EphemeralPortRange
    {
        set => SetProperty("ephemeral_port_range", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The multiple_placement_groups_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? MultiplePlacementGroupsEnabled
    {
        set => SetProperty("multiple_placement_groups_enabled", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The placement_properties attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? PlacementProperties
    {
        set => SetProperty("placement_properties", value);
    }

    /// <summary>
    /// The primary attribute.
    /// </summary>
    public TerraformProperty<bool>? Primary
    {
        set => SetProperty("primary", value);
    }

    /// <summary>
    /// The stateless attribute.
    /// </summary>
    public TerraformProperty<bool>? Stateless
    {
        set => SetProperty("stateless", value);
    }

    /// <summary>
    /// The vm_image_offer attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VmImageOffer is required")]
    public required TerraformProperty<string> VmImageOffer
    {
        set => SetProperty("vm_image_offer", value);
    }

    /// <summary>
    /// The vm_image_publisher attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VmImagePublisher is required")]
    public required TerraformProperty<string> VmImagePublisher
    {
        set => SetProperty("vm_image_publisher", value);
    }

    /// <summary>
    /// The vm_image_sku attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VmImageSku is required")]
    public required TerraformProperty<string> VmImageSku
    {
        set => SetProperty("vm_image_sku", value);
    }

    /// <summary>
    /// The vm_image_version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VmImageVersion is required")]
    public required TerraformProperty<string> VmImageVersion
    {
        set => SetProperty("vm_image_version", value);
    }

    /// <summary>
    /// The vm_instance_count attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VmInstanceCount is required")]
    public required TerraformProperty<double> VmInstanceCount
    {
        set => SetProperty("vm_instance_count", value);
    }

    /// <summary>
    /// The vm_size attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VmSize is required")]
    public required TerraformProperty<string> VmSize
    {
        set => SetProperty("vm_size", value);
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
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
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
        SetOutput("backup_service_enabled");
        SetOutput("client_connection_port");
        SetOutput("dns_name");
        SetOutput("dns_service_enabled");
        SetOutput("http_gateway_port");
        SetOutput("id");
        SetOutput("location");
        SetOutput("name");
        SetOutput("password");
        SetOutput("resource_group_name");
        SetOutput("sku");
        SetOutput("subnet_id");
        SetOutput("tags");
        SetOutput("upgrade_wave");
        SetOutput("username");
    }

    /// <summary>
    /// The backup_service_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> BackupServiceEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("backup_service_enabled");
        set => SetProperty("backup_service_enabled", value);
    }

    /// <summary>
    /// The client_connection_port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientConnectionPort is required")]
    public required TerraformProperty<double> ClientConnectionPort
    {
        get => GetRequiredOutput<TerraformProperty<double>>("client_connection_port");
        set => SetProperty("client_connection_port", value);
    }

    /// <summary>
    /// The dns_name attribute.
    /// </summary>
    public TerraformProperty<string> DnsName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("dns_name");
        set => SetProperty("dns_name", value);
    }

    /// <summary>
    /// The dns_service_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> DnsServiceEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("dns_service_enabled");
        set => SetProperty("dns_service_enabled", value);
    }

    /// <summary>
    /// The http_gateway_port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HttpGatewayPort is required")]
    public required TerraformProperty<double> HttpGatewayPort
    {
        get => GetRequiredOutput<TerraformProperty<double>>("http_gateway_port");
        set => SetProperty("http_gateway_port", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The password attribute.
    /// </summary>
    public TerraformProperty<string> Password
    {
        get => GetRequiredOutput<TerraformProperty<string>>("password");
        set => SetProperty("password", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("resource_group_name");
        set => SetProperty("resource_group_name", value);
    }

    /// <summary>
    /// The sku attribute.
    /// </summary>
    public TerraformProperty<string> Sku
    {
        get => GetRequiredOutput<TerraformProperty<string>>("sku");
        set => SetProperty("sku", value);
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    public TerraformProperty<string> SubnetId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("subnet_id");
        set => SetProperty("subnet_id", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The upgrade_wave attribute.
    /// </summary>
    public TerraformProperty<string> UpgradeWave
    {
        get => GetRequiredOutput<TerraformProperty<string>>("upgrade_wave");
        set => SetProperty("upgrade_wave", value);
    }

    /// <summary>
    /// The username attribute.
    /// </summary>
    public TerraformProperty<string> Username
    {
        get => GetRequiredOutput<TerraformProperty<string>>("username");
        set => SetProperty("username", value);
    }

    /// <summary>
    /// Block for authentication.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Authentication block(s) allowed")]
    public List<AzurermServiceFabricManagedClusterAuthenticationBlock>? Authentication
    {
        set => SetProperty("authentication", value);
    }

    /// <summary>
    /// Block for custom_fabric_setting.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermServiceFabricManagedClusterCustomFabricSettingBlock>? CustomFabricSetting
    {
        set => SetProperty("custom_fabric_setting", value);
    }

    /// <summary>
    /// Block for lb_rule.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LbRule is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 LbRule block(s) required")]
    public List<AzurermServiceFabricManagedClusterLbRuleBlock>? LbRule
    {
        set => SetProperty("lb_rule", value);
    }

    /// <summary>
    /// Block for node_type.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermServiceFabricManagedClusterNodeTypeBlock>? NodeType
    {
        set => SetProperty("node_type", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermServiceFabricManagedClusterTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
