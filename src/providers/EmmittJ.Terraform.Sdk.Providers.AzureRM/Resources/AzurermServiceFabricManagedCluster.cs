using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for authentication in .
/// Nesting mode: list
/// </summary>
public class AzurermServiceFabricManagedClusterAuthenticationBlock : ITerraformBlock
{
}

/// <summary>
/// Block type for custom_fabric_setting in .
/// Nesting mode: list
/// </summary>
public class AzurermServiceFabricManagedClusterCustomFabricSettingBlock : ITerraformBlock
{
    /// <summary>
    /// The parameter attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Parameter is required")]
    [TerraformPropertyName("parameter")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Parameter { get; set; }

    /// <summary>
    /// The section attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Section is required")]
    [TerraformPropertyName("section")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Section { get; set; }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    [TerraformPropertyName("value")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Value { get; set; }

}

/// <summary>
/// Block type for lb_rule in .
/// Nesting mode: list
/// </summary>
public class AzurermServiceFabricManagedClusterLbRuleBlock : ITerraformBlock
{
    /// <summary>
    /// The backend_port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BackendPort is required")]
    [TerraformPropertyName("backend_port")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> BackendPort { get; set; }

    /// <summary>
    /// The frontend_port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FrontendPort is required")]
    [TerraformPropertyName("frontend_port")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> FrontendPort { get; set; }

    /// <summary>
    /// The probe_protocol attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProbeProtocol is required")]
    [TerraformPropertyName("probe_protocol")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ProbeProtocol { get; set; }

    /// <summary>
    /// The probe_request_path attribute.
    /// </summary>
    [TerraformPropertyName("probe_request_path")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ProbeRequestPath { get; set; }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Protocol is required")]
    [TerraformPropertyName("protocol")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Protocol { get; set; }

}

/// <summary>
/// Block type for node_type in .
/// Nesting mode: list
/// </summary>
public class AzurermServiceFabricManagedClusterNodeTypeBlock : ITerraformBlock
{
    /// <summary>
    /// The application_port_range attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApplicationPortRange is required")]
    [TerraformPropertyName("application_port_range")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ApplicationPortRange { get; set; }

    /// <summary>
    /// The capacities attribute.
    /// </summary>
    [TerraformPropertyName("capacities")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Capacities { get; set; }

    /// <summary>
    /// The data_disk_size_gb attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataDiskSizeGb is required")]
    [TerraformPropertyName("data_disk_size_gb")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> DataDiskSizeGb { get; set; }

    /// <summary>
    /// The data_disk_type attribute.
    /// </summary>
    [TerraformPropertyName("data_disk_type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DataDiskType { get; set; }

    /// <summary>
    /// The ephemeral_port_range attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EphemeralPortRange is required")]
    [TerraformPropertyName("ephemeral_port_range")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> EphemeralPortRange { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Id => new TerraformReferenceProperty<TerraformProperty<string>>("", "id");

    /// <summary>
    /// The multiple_placement_groups_enabled attribute.
    /// </summary>
    [TerraformPropertyName("multiple_placement_groups_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? MultiplePlacementGroupsEnabled { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The placement_properties attribute.
    /// </summary>
    [TerraformPropertyName("placement_properties")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? PlacementProperties { get; set; }

    /// <summary>
    /// The primary attribute.
    /// </summary>
    [TerraformPropertyName("primary")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? Primary { get; set; }

    /// <summary>
    /// The stateless attribute.
    /// </summary>
    [TerraformPropertyName("stateless")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? Stateless { get; set; }

    /// <summary>
    /// The vm_image_offer attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VmImageOffer is required")]
    [TerraformPropertyName("vm_image_offer")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> VmImageOffer { get; set; }

    /// <summary>
    /// The vm_image_publisher attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VmImagePublisher is required")]
    [TerraformPropertyName("vm_image_publisher")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> VmImagePublisher { get; set; }

    /// <summary>
    /// The vm_image_sku attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VmImageSku is required")]
    [TerraformPropertyName("vm_image_sku")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> VmImageSku { get; set; }

    /// <summary>
    /// The vm_image_version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VmImageVersion is required")]
    [TerraformPropertyName("vm_image_version")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> VmImageVersion { get; set; }

    /// <summary>
    /// The vm_instance_count attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VmInstanceCount is required")]
    [TerraformPropertyName("vm_instance_count")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> VmInstanceCount { get; set; }

    /// <summary>
    /// The vm_size attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VmSize is required")]
    [TerraformPropertyName("vm_size")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> VmSize { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermServiceFabricManagedClusterTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_service_fabric_managed_cluster resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermServiceFabricManagedCluster : TerraformResource
{
    public AzurermServiceFabricManagedCluster(string name) : base("azurerm_service_fabric_managed_cluster", name)
    {
    }

    /// <summary>
    /// The backup_service_enabled attribute.
    /// </summary>
    [TerraformPropertyName("backup_service_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? BackupServiceEnabled { get; set; }

    /// <summary>
    /// The client_connection_port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientConnectionPort is required")]
    [TerraformPropertyName("client_connection_port")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> ClientConnectionPort { get; set; }

    /// <summary>
    /// The dns_name attribute.
    /// </summary>
    [TerraformPropertyName("dns_name")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> DnsName { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "dns_name");

    /// <summary>
    /// The dns_service_enabled attribute.
    /// </summary>
    [TerraformPropertyName("dns_service_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? DnsServiceEnabled { get; set; }

    /// <summary>
    /// The http_gateway_port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HttpGatewayPort is required")]
    [TerraformPropertyName("http_gateway_port")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> HttpGatewayPort { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Location { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The password attribute.
    /// </summary>
    [TerraformPropertyName("password")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Password { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ResourceGroupName { get; set; }

    /// <summary>
    /// The sku attribute.
    /// </summary>
    [TerraformPropertyName("sku")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Sku { get; set; }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [TerraformPropertyName("subnet_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? SubnetId { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// The upgrade_wave attribute.
    /// </summary>
    [TerraformPropertyName("upgrade_wave")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? UpgradeWave { get; set; }

    /// <summary>
    /// The username attribute.
    /// </summary>
    [TerraformPropertyName("username")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Username { get; set; }

    /// <summary>
    /// Block for authentication.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Authentication block(s) allowed")]
    [TerraformPropertyName("authentication")]
    public TerraformList<TerraformBlock<AzurermServiceFabricManagedClusterAuthenticationBlock>>? Authentication { get; set; } = new();

    /// <summary>
    /// Block for custom_fabric_setting.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("custom_fabric_setting")]
    public TerraformList<TerraformBlock<AzurermServiceFabricManagedClusterCustomFabricSettingBlock>>? CustomFabricSetting { get; set; } = new();

    /// <summary>
    /// Block for lb_rule.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LbRule is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 LbRule block(s) required")]
    [TerraformPropertyName("lb_rule")]
    public TerraformList<TerraformBlock<AzurermServiceFabricManagedClusterLbRuleBlock>>? LbRule { get; set; } = new();

    /// <summary>
    /// Block for node_type.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("node_type")]
    public TerraformList<TerraformBlock<AzurermServiceFabricManagedClusterNodeTypeBlock>>? NodeType { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermServiceFabricManagedClusterTimeoutsBlock>? Timeouts { get; set; } = new();

}
