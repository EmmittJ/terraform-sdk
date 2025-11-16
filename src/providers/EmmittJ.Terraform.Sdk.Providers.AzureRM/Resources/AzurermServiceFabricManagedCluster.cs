using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

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
    public required TerraformValue<string> Parameter
    {
        get => new TerraformReference<string>(this, "parameter");
        set => SetArgument("parameter", value);
    }

    /// <summary>
    /// The section attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Section is required")]
    public required TerraformValue<string> Section
    {
        get => new TerraformReference<string>(this, "section");
        set => SetArgument("section", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
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
    public required TerraformValue<double> BackendPort
    {
        get => new TerraformReference<double>(this, "backend_port");
        set => SetArgument("backend_port", value);
    }

    /// <summary>
    /// The frontend_port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FrontendPort is required")]
    public required TerraformValue<double> FrontendPort
    {
        get => new TerraformReference<double>(this, "frontend_port");
        set => SetArgument("frontend_port", value);
    }

    /// <summary>
    /// The probe_protocol attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProbeProtocol is required")]
    public required TerraformValue<string> ProbeProtocol
    {
        get => new TerraformReference<string>(this, "probe_protocol");
        set => SetArgument("probe_protocol", value);
    }

    /// <summary>
    /// The probe_request_path attribute.
    /// </summary>
    public TerraformValue<string>? ProbeRequestPath
    {
        get => new TerraformReference<string>(this, "probe_request_path");
        set => SetArgument("probe_request_path", value);
    }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Protocol is required")]
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
    public required TerraformValue<string> ApplicationPortRange
    {
        get => new TerraformReference<string>(this, "application_port_range");
        set => SetArgument("application_port_range", value);
    }

    /// <summary>
    /// The capacities attribute.
    /// </summary>
    public TerraformMap<string>? Capacities
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "capacities").ResolveNodes(ctx));
        set => SetArgument("capacities", value);
    }

    /// <summary>
    /// The data_disk_size_gb attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataDiskSizeGb is required")]
    public required TerraformValue<double> DataDiskSizeGb
    {
        get => new TerraformReference<double>(this, "data_disk_size_gb");
        set => SetArgument("data_disk_size_gb", value);
    }

    /// <summary>
    /// The data_disk_type attribute.
    /// </summary>
    public TerraformValue<string>? DataDiskType
    {
        get => new TerraformReference<string>(this, "data_disk_type");
        set => SetArgument("data_disk_type", value);
    }

    /// <summary>
    /// The ephemeral_port_range attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EphemeralPortRange is required")]
    public required TerraformValue<string> EphemeralPortRange
    {
        get => new TerraformReference<string>(this, "ephemeral_port_range");
        set => SetArgument("ephemeral_port_range", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
    }

    /// <summary>
    /// The multiple_placement_groups_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? MultiplePlacementGroupsEnabled
    {
        get => new TerraformReference<bool>(this, "multiple_placement_groups_enabled");
        set => SetArgument("multiple_placement_groups_enabled", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The placement_properties attribute.
    /// </summary>
    public TerraformMap<string>? PlacementProperties
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "placement_properties").ResolveNodes(ctx));
        set => SetArgument("placement_properties", value);
    }

    /// <summary>
    /// The primary attribute.
    /// </summary>
    public TerraformValue<bool>? Primary
    {
        get => new TerraformReference<bool>(this, "primary");
        set => SetArgument("primary", value);
    }

    /// <summary>
    /// The stateless attribute.
    /// </summary>
    public TerraformValue<bool>? Stateless
    {
        get => new TerraformReference<bool>(this, "stateless");
        set => SetArgument("stateless", value);
    }

    /// <summary>
    /// The vm_image_offer attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VmImageOffer is required")]
    public required TerraformValue<string> VmImageOffer
    {
        get => new TerraformReference<string>(this, "vm_image_offer");
        set => SetArgument("vm_image_offer", value);
    }

    /// <summary>
    /// The vm_image_publisher attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VmImagePublisher is required")]
    public required TerraformValue<string> VmImagePublisher
    {
        get => new TerraformReference<string>(this, "vm_image_publisher");
        set => SetArgument("vm_image_publisher", value);
    }

    /// <summary>
    /// The vm_image_sku attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VmImageSku is required")]
    public required TerraformValue<string> VmImageSku
    {
        get => new TerraformReference<string>(this, "vm_image_sku");
        set => SetArgument("vm_image_sku", value);
    }

    /// <summary>
    /// The vm_image_version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VmImageVersion is required")]
    public required TerraformValue<string> VmImageVersion
    {
        get => new TerraformReference<string>(this, "vm_image_version");
        set => SetArgument("vm_image_version", value);
    }

    /// <summary>
    /// The vm_instance_count attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VmInstanceCount is required")]
    public required TerraformValue<double> VmInstanceCount
    {
        get => new TerraformReference<double>(this, "vm_instance_count");
        set => SetArgument("vm_instance_count", value);
    }

    /// <summary>
    /// The vm_size attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VmSize is required")]
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
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}

/// <summary>
/// Represents a azurerm_service_fabric_managed_cluster Terraform resource.
/// Manages a azurerm_service_fabric_managed_cluster resource.
/// </summary>
public partial class AzurermServiceFabricManagedCluster(string name) : TerraformResource("azurerm_service_fabric_managed_cluster", name)
{
    /// <summary>
    /// The backup_service_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? BackupServiceEnabled
    {
        get => new TerraformReference<bool>(this, "backup_service_enabled");
        set => SetArgument("backup_service_enabled", value);
    }

    /// <summary>
    /// The client_connection_port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientConnectionPort is required")]
    public required TerraformValue<double> ClientConnectionPort
    {
        get => new TerraformReference<double>(this, "client_connection_port");
        set => SetArgument("client_connection_port", value);
    }

    /// <summary>
    /// The dns_name attribute.
    /// </summary>
    public TerraformValue<string> DnsName
    {
        get => new TerraformReference<string>(this, "dns_name");
        set => SetArgument("dns_name", value);
    }

    /// <summary>
    /// The dns_service_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? DnsServiceEnabled
    {
        get => new TerraformReference<bool>(this, "dns_service_enabled");
        set => SetArgument("dns_service_enabled", value);
    }

    /// <summary>
    /// The http_gateway_port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HttpGatewayPort is required")]
    public required TerraformValue<double> HttpGatewayPort
    {
        get => new TerraformReference<double>(this, "http_gateway_port");
        set => SetArgument("http_gateway_port", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The password attribute.
    /// </summary>
    public TerraformValue<string>? Password
    {
        get => new TerraformReference<string>(this, "password");
        set => SetArgument("password", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The sku attribute.
    /// </summary>
    public TerraformValue<string>? Sku
    {
        get => new TerraformReference<string>(this, "sku");
        set => SetArgument("sku", value);
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    public TerraformValue<string>? SubnetId
    {
        get => new TerraformReference<string>(this, "subnet_id");
        set => SetArgument("subnet_id", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The upgrade_wave attribute.
    /// </summary>
    public TerraformValue<string>? UpgradeWave
    {
        get => new TerraformReference<string>(this, "upgrade_wave");
        set => SetArgument("upgrade_wave", value);
    }

    /// <summary>
    /// The username attribute.
    /// </summary>
    public TerraformValue<string>? Username
    {
        get => new TerraformReference<string>(this, "username");
        set => SetArgument("username", value);
    }

    /// <summary>
    /// Authentication block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Authentication block(s) allowed")]
    public TerraformList<AzurermServiceFabricManagedClusterAuthenticationBlock>? Authentication
    {
        get => GetArgument<TerraformList<AzurermServiceFabricManagedClusterAuthenticationBlock>>("authentication");
        set => SetArgument("authentication", value);
    }

    /// <summary>
    /// CustomFabricSetting block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermServiceFabricManagedClusterCustomFabricSettingBlock>? CustomFabricSetting
    {
        get => GetArgument<TerraformList<AzurermServiceFabricManagedClusterCustomFabricSettingBlock>>("custom_fabric_setting");
        set => SetArgument("custom_fabric_setting", value);
    }

    /// <summary>
    /// LbRule block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LbRule is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 LbRule block(s) required")]
    public required TerraformList<AzurermServiceFabricManagedClusterLbRuleBlock> LbRule
    {
        get => GetRequiredArgument<TerraformList<AzurermServiceFabricManagedClusterLbRuleBlock>>("lb_rule");
        set => SetArgument("lb_rule", value);
    }

    /// <summary>
    /// NodeType block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermServiceFabricManagedClusterNodeTypeBlock>? NodeType
    {
        get => GetArgument<TerraformList<AzurermServiceFabricManagedClusterNodeTypeBlock>>("node_type");
        set => SetArgument("node_type", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermServiceFabricManagedClusterTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermServiceFabricManagedClusterTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
