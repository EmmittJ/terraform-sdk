using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

// Resources, Data Sources, Ephemeral Resources, Blocks: Getter ALWAYS returns a reference
// This is the key to natural Terraform syntax
// When you access rg.Name, you get azurerm_resource_group.rg.name (a reference)
// The value that was SET is only used during serialization

// Providers: Getter returns stored value
// Providers are not referenced in HCL
// Use required getter if property is required or non-nullable

/// <summary>
/// Block type for authentication in .
/// Nesting mode: list
/// </summary>
public class AzurermServiceFabricManagedClusterAuthenticationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "authentication";

}

/// <summary>
/// Block type for custom_fabric_setting in .
/// Nesting mode: list
/// </summary>
public class AzurermServiceFabricManagedClusterCustomFabricSettingBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "custom_fabric_setting";

    /// <summary>
    /// The parameter attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Parameter is required")]
    [TerraformArgument("parameter")]
    public required TerraformValue<string> Parameter
    {
        get => new TerraformReference<string>(this, "parameter");
        set => SetArgument("parameter", value);
    }

    /// <summary>
    /// The section attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Section is required")]
    [TerraformArgument("section")]
    public required TerraformValue<string> Section
    {
        get => new TerraformReference<string>(this, "section");
        set => SetArgument("section", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    [TerraformArgument("value")]
    public required TerraformValue<string> Value
    {
        get => new TerraformReference<string>(this, "value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for lb_rule in .
/// Nesting mode: list
/// </summary>
public class AzurermServiceFabricManagedClusterLbRuleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "lb_rule";

    /// <summary>
    /// The backend_port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BackendPort is required")]
    [TerraformArgument("backend_port")]
    public required TerraformValue<double> BackendPort
    {
        get => new TerraformReference<double>(this, "backend_port");
        set => SetArgument("backend_port", value);
    }

    /// <summary>
    /// The frontend_port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FrontendPort is required")]
    [TerraformArgument("frontend_port")]
    public required TerraformValue<double> FrontendPort
    {
        get => new TerraformReference<double>(this, "frontend_port");
        set => SetArgument("frontend_port", value);
    }

    /// <summary>
    /// The probe_protocol attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProbeProtocol is required")]
    [TerraformArgument("probe_protocol")]
    public required TerraformValue<string> ProbeProtocol
    {
        get => new TerraformReference<string>(this, "probe_protocol");
        set => SetArgument("probe_protocol", value);
    }

    /// <summary>
    /// The probe_request_path attribute.
    /// </summary>
    [TerraformArgument("probe_request_path")]
    public TerraformValue<string>? ProbeRequestPath
    {
        get => new TerraformReference<string>(this, "probe_request_path");
        set => SetArgument("probe_request_path", value);
    }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Protocol is required")]
    [TerraformArgument("protocol")]
    public required TerraformValue<string> Protocol
    {
        get => new TerraformReference<string>(this, "protocol");
        set => SetArgument("protocol", value);
    }

}

/// <summary>
/// Block type for node_type in .
/// Nesting mode: list
/// </summary>
public class AzurermServiceFabricManagedClusterNodeTypeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "node_type";

    /// <summary>
    /// The application_port_range attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApplicationPortRange is required")]
    [TerraformArgument("application_port_range")]
    public required TerraformValue<string> ApplicationPortRange
    {
        get => new TerraformReference<string>(this, "application_port_range");
        set => SetArgument("application_port_range", value);
    }

    /// <summary>
    /// The capacities attribute.
    /// </summary>
    [TerraformArgument("capacities")]
    public TerraformMap<string>? Capacities
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "capacities").ResolveNodes(ctx));
        set => SetArgument("capacities", value);
    }

    /// <summary>
    /// The data_disk_size_gb attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataDiskSizeGb is required")]
    [TerraformArgument("data_disk_size_gb")]
    public required TerraformValue<double> DataDiskSizeGb
    {
        get => new TerraformReference<double>(this, "data_disk_size_gb");
        set => SetArgument("data_disk_size_gb", value);
    }

    /// <summary>
    /// The data_disk_type attribute.
    /// </summary>
    [TerraformArgument("data_disk_type")]
    public TerraformValue<string>? DataDiskType
    {
        get => new TerraformReference<string>(this, "data_disk_type");
        set => SetArgument("data_disk_type", value);
    }

    /// <summary>
    /// The ephemeral_port_range attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EphemeralPortRange is required")]
    [TerraformArgument("ephemeral_port_range")]
    public required TerraformValue<string> EphemeralPortRange
    {
        get => new TerraformReference<string>(this, "ephemeral_port_range");
        set => SetArgument("ephemeral_port_range", value);
    }


    /// <summary>
    /// The multiple_placement_groups_enabled attribute.
    /// </summary>
    [TerraformArgument("multiple_placement_groups_enabled")]
    public TerraformValue<bool>? MultiplePlacementGroupsEnabled
    {
        get => new TerraformReference<bool>(this, "multiple_placement_groups_enabled");
        set => SetArgument("multiple_placement_groups_enabled", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The placement_properties attribute.
    /// </summary>
    [TerraformArgument("placement_properties")]
    public TerraformMap<string>? PlacementProperties
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "placement_properties").ResolveNodes(ctx));
        set => SetArgument("placement_properties", value);
    }

    /// <summary>
    /// The primary attribute.
    /// </summary>
    [TerraformArgument("primary")]
    public TerraformValue<bool>? Primary
    {
        get => new TerraformReference<bool>(this, "primary");
        set => SetArgument("primary", value);
    }

    /// <summary>
    /// The stateless attribute.
    /// </summary>
    [TerraformArgument("stateless")]
    public TerraformValue<bool>? Stateless
    {
        get => new TerraformReference<bool>(this, "stateless");
        set => SetArgument("stateless", value);
    }

    /// <summary>
    /// The vm_image_offer attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VmImageOffer is required")]
    [TerraformArgument("vm_image_offer")]
    public required TerraformValue<string> VmImageOffer
    {
        get => new TerraformReference<string>(this, "vm_image_offer");
        set => SetArgument("vm_image_offer", value);
    }

    /// <summary>
    /// The vm_image_publisher attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VmImagePublisher is required")]
    [TerraformArgument("vm_image_publisher")]
    public required TerraformValue<string> VmImagePublisher
    {
        get => new TerraformReference<string>(this, "vm_image_publisher");
        set => SetArgument("vm_image_publisher", value);
    }

    /// <summary>
    /// The vm_image_sku attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VmImageSku is required")]
    [TerraformArgument("vm_image_sku")]
    public required TerraformValue<string> VmImageSku
    {
        get => new TerraformReference<string>(this, "vm_image_sku");
        set => SetArgument("vm_image_sku", value);
    }

    /// <summary>
    /// The vm_image_version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VmImageVersion is required")]
    [TerraformArgument("vm_image_version")]
    public required TerraformValue<string> VmImageVersion
    {
        get => new TerraformReference<string>(this, "vm_image_version");
        set => SetArgument("vm_image_version", value);
    }

    /// <summary>
    /// The vm_instance_count attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VmInstanceCount is required")]
    [TerraformArgument("vm_instance_count")]
    public required TerraformValue<double> VmInstanceCount
    {
        get => new TerraformReference<double>(this, "vm_instance_count");
        set => SetArgument("vm_instance_count", value);
    }

    /// <summary>
    /// The vm_size attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VmSize is required")]
    [TerraformArgument("vm_size")]
    public required TerraformValue<string> VmSize
    {
        get => new TerraformReference<string>(this, "vm_size");
        set => SetArgument("vm_size", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermServiceFabricManagedClusterTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformArgument("create")]
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformArgument("delete")]
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformArgument("update")]
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
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
    }

    /// <summary>
    /// The backup_service_enabled attribute.
    /// </summary>
    [TerraformArgument("backup_service_enabled")]
    public TerraformValue<bool>? BackupServiceEnabled
    {
        get => new TerraformReference<bool>(this, "backup_service_enabled");
        set => SetArgument("backup_service_enabled", value);
    }

    /// <summary>
    /// The client_connection_port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientConnectionPort is required")]
    [TerraformArgument("client_connection_port")]
    public required TerraformValue<double> ClientConnectionPort
    {
        get => new TerraformReference<double>(this, "client_connection_port");
        set => SetArgument("client_connection_port", value);
    }

    /// <summary>
    /// The dns_name attribute.
    /// </summary>
    [TerraformArgument("dns_name")]
    public TerraformValue<string> DnsName
    {
        get => new TerraformReference<string>(this, "dns_name");
        set => SetArgument("dns_name", value);
    }

    /// <summary>
    /// The dns_service_enabled attribute.
    /// </summary>
    [TerraformArgument("dns_service_enabled")]
    public TerraformValue<bool>? DnsServiceEnabled
    {
        get => new TerraformReference<bool>(this, "dns_service_enabled");
        set => SetArgument("dns_service_enabled", value);
    }

    /// <summary>
    /// The http_gateway_port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HttpGatewayPort is required")]
    [TerraformArgument("http_gateway_port")]
    public required TerraformValue<double> HttpGatewayPort
    {
        get => new TerraformReference<double>(this, "http_gateway_port");
        set => SetArgument("http_gateway_port", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformArgument("id")]
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformArgument("location")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The password attribute.
    /// </summary>
    [TerraformArgument("password")]
    public TerraformValue<string>? Password
    {
        get => new TerraformReference<string>(this, "password");
        set => SetArgument("password", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformArgument("resource_group_name")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The sku attribute.
    /// </summary>
    [TerraformArgument("sku")]
    public TerraformValue<string>? Sku
    {
        get => new TerraformReference<string>(this, "sku");
        set => SetArgument("sku", value);
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [TerraformArgument("subnet_id")]
    public TerraformValue<string>? SubnetId
    {
        get => new TerraformReference<string>(this, "subnet_id");
        set => SetArgument("subnet_id", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformArgument("tags")]
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The upgrade_wave attribute.
    /// </summary>
    [TerraformArgument("upgrade_wave")]
    public TerraformValue<string>? UpgradeWave
    {
        get => new TerraformReference<string>(this, "upgrade_wave");
        set => SetArgument("upgrade_wave", value);
    }

    /// <summary>
    /// The username attribute.
    /// </summary>
    [TerraformArgument("username")]
    public TerraformValue<string>? Username
    {
        get => new TerraformReference<string>(this, "username");
        set => SetArgument("username", value);
    }

    /// <summary>
    /// Block for authentication.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Authentication block(s) allowed")]
    [TerraformArgument("authentication")]
    public TerraformList<AzurermServiceFabricManagedClusterAuthenticationBlock> Authentication { get; set; } = new();

    /// <summary>
    /// Block for custom_fabric_setting.
    /// Nesting mode: list
    /// </summary>
    [TerraformArgument("custom_fabric_setting")]
    public TerraformList<AzurermServiceFabricManagedClusterCustomFabricSettingBlock> CustomFabricSetting { get; set; } = new();

    /// <summary>
    /// Block for lb_rule.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LbRule is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 LbRule block(s) required")]
    [TerraformArgument("lb_rule")]
    public required TerraformList<AzurermServiceFabricManagedClusterLbRuleBlock> LbRule { get; set; } = new();

    /// <summary>
    /// Block for node_type.
    /// Nesting mode: list
    /// </summary>
    [TerraformArgument("node_type")]
    public TerraformList<AzurermServiceFabricManagedClusterNodeTypeBlock> NodeType { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermServiceFabricManagedClusterTimeoutsBlock Timeouts { get; set; } = new();

}
