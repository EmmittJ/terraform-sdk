using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for authentication in .
/// Nesting mode: list
/// </summary>
public partial class AzurermServiceFabricManagedClusterAuthenticationBlock : TerraformBlockBase
{
}

/// <summary>
/// Block type for custom_fabric_setting in .
/// Nesting mode: list
/// </summary>
public partial class AzurermServiceFabricManagedClusterCustomFabricSettingBlock : TerraformBlockBase
{
    /// <summary>
    /// The parameter attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Parameter is required")]
    [TerraformProperty("parameter")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Parameter { get; set; }

    /// <summary>
    /// The section attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Section is required")]
    [TerraformProperty("section")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Section { get; set; }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    [TerraformProperty("value")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Value { get; set; }

}

/// <summary>
/// Block type for lb_rule in .
/// Nesting mode: list
/// </summary>
public partial class AzurermServiceFabricManagedClusterLbRuleBlock : TerraformBlockBase
{
    /// <summary>
    /// The backend_port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BackendPort is required")]
    [TerraformProperty("backend_port")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<double> BackendPort { get; set; }

    /// <summary>
    /// The frontend_port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FrontendPort is required")]
    [TerraformProperty("frontend_port")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<double> FrontendPort { get; set; }

    /// <summary>
    /// The probe_protocol attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProbeProtocol is required")]
    [TerraformProperty("probe_protocol")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ProbeProtocol { get; set; }

    /// <summary>
    /// The probe_request_path attribute.
    /// </summary>
    [TerraformProperty("probe_request_path")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ProbeRequestPath { get; set; }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Protocol is required")]
    [TerraformProperty("protocol")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Protocol { get; set; }

}

/// <summary>
/// Block type for node_type in .
/// Nesting mode: list
/// </summary>
public partial class AzurermServiceFabricManagedClusterNodeTypeBlock : TerraformBlockBase
{
    /// <summary>
    /// The application_port_range attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApplicationPortRange is required")]
    [TerraformProperty("application_port_range")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ApplicationPortRange { get; set; }

    /// <summary>
    /// The capacities attribute.
    /// </summary>
    [TerraformProperty("capacities")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Capacities { get; set; }

    /// <summary>
    /// The data_disk_size_gb attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataDiskSizeGb is required")]
    [TerraformProperty("data_disk_size_gb")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<double> DataDiskSizeGb { get; set; }

    /// <summary>
    /// The data_disk_type attribute.
    /// </summary>
    [TerraformProperty("data_disk_type")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? DataDiskType { get; set; }

    /// <summary>
    /// The ephemeral_port_range attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EphemeralPortRange is required")]
    [TerraformProperty("ephemeral_port_range")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> EphemeralPortRange { get; set; }


    /// <summary>
    /// The multiple_placement_groups_enabled attribute.
    /// </summary>
    [TerraformProperty("multiple_placement_groups_enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? MultiplePlacementGroupsEnabled { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The placement_properties attribute.
    /// </summary>
    [TerraformProperty("placement_properties")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? PlacementProperties { get; set; }

    /// <summary>
    /// The primary attribute.
    /// </summary>
    [TerraformProperty("primary")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? Primary { get; set; }

    /// <summary>
    /// The stateless attribute.
    /// </summary>
    [TerraformProperty("stateless")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? Stateless { get; set; }

    /// <summary>
    /// The vm_image_offer attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VmImageOffer is required")]
    [TerraformProperty("vm_image_offer")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> VmImageOffer { get; set; }

    /// <summary>
    /// The vm_image_publisher attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VmImagePublisher is required")]
    [TerraformProperty("vm_image_publisher")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> VmImagePublisher { get; set; }

    /// <summary>
    /// The vm_image_sku attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VmImageSku is required")]
    [TerraformProperty("vm_image_sku")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> VmImageSku { get; set; }

    /// <summary>
    /// The vm_image_version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VmImageVersion is required")]
    [TerraformProperty("vm_image_version")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> VmImageVersion { get; set; }

    /// <summary>
    /// The vm_instance_count attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VmInstanceCount is required")]
    [TerraformProperty("vm_instance_count")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<double> VmInstanceCount { get; set; }

    /// <summary>
    /// The vm_size attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VmSize is required")]
    [TerraformProperty("vm_size")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> VmSize { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermServiceFabricManagedClusterTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_service_fabric_managed_cluster resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermServiceFabricManagedCluster : TerraformResource
{
    public AzurermServiceFabricManagedCluster(string name) : base("azurerm_service_fabric_managed_cluster", name)
    {
    }

    /// <summary>
    /// The backup_service_enabled attribute.
    /// </summary>
    [TerraformProperty("backup_service_enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? BackupServiceEnabled { get; set; }

    /// <summary>
    /// The client_connection_port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientConnectionPort is required")]
    [TerraformProperty("client_connection_port")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<double> ClientConnectionPort { get; set; }

    /// <summary>
    /// The dns_name attribute.
    /// </summary>
    [TerraformProperty("dns_name")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> DnsName { get; set; }

    /// <summary>
    /// The dns_service_enabled attribute.
    /// </summary>
    [TerraformProperty("dns_service_enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? DnsServiceEnabled { get; set; }

    /// <summary>
    /// The http_gateway_port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HttpGatewayPort is required")]
    [TerraformProperty("http_gateway_port")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<double> HttpGatewayPort { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The password attribute.
    /// </summary>
    [TerraformProperty("password")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Password { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The sku attribute.
    /// </summary>
    [TerraformProperty("sku")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Sku { get; set; }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [TerraformProperty("subnet_id")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? SubnetId { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The upgrade_wave attribute.
    /// </summary>
    [TerraformProperty("upgrade_wave")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? UpgradeWave { get; set; }

    /// <summary>
    /// The username attribute.
    /// </summary>
    [TerraformProperty("username")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Username { get; set; }

    /// <summary>
    /// Block for authentication.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Authentication block(s) allowed")]
    [TerraformProperty("authentication")]
    public TerraformList<TerraformBlock<AzurermServiceFabricManagedClusterAuthenticationBlock>>? Authentication { get; set; }

    /// <summary>
    /// Block for custom_fabric_setting.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("custom_fabric_setting")]
    public TerraformList<TerraformBlock<AzurermServiceFabricManagedClusterCustomFabricSettingBlock>>? CustomFabricSetting { get; set; }

    /// <summary>
    /// Block for lb_rule.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LbRule is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 LbRule block(s) required")]
    [TerraformProperty("lb_rule")]
    public TerraformList<TerraformBlock<AzurermServiceFabricManagedClusterLbRuleBlock>>? LbRule { get; set; }

    /// <summary>
    /// Block for node_type.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("node_type")]
    public TerraformList<TerraformBlock<AzurermServiceFabricManagedClusterNodeTypeBlock>>? NodeType { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzurermServiceFabricManagedClusterTimeoutsBlock>? Timeouts { get; set; }

}
