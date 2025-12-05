using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for authentication in AzurermServiceFabricManagedCluster.
/// Nesting mode: list
/// </summary>
public class AzurermServiceFabricManagedClusterAuthenticationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "authentication";

    /// <summary>
    /// ActiveDirectory block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ActiveDirectory block(s) allowed")]
    public TerraformList<AzurermServiceFabricManagedClusterAuthenticationBlockActiveDirectoryBlock>? ActiveDirectory
    {
        get => GetArgument<TerraformList<AzurermServiceFabricManagedClusterAuthenticationBlockActiveDirectoryBlock>>("active_directory");
        set => SetArgument("active_directory", value);
    }

    /// <summary>
    /// Certificate block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermServiceFabricManagedClusterAuthenticationBlockCertificateBlock>? Certificate
    {
        get => GetArgument<TerraformList<AzurermServiceFabricManagedClusterAuthenticationBlockCertificateBlock>>("certificate");
        set => SetArgument("certificate", value);
    }

}

/// <summary>
/// Block type for active_directory in AzurermServiceFabricManagedClusterAuthenticationBlock.
/// Nesting mode: list
/// </summary>
public class AzurermServiceFabricManagedClusterAuthenticationBlockActiveDirectoryBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "active_directory";

    /// <summary>
    /// The client_application_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientApplicationId is required")]
    public required TerraformValue<string> ClientApplicationId
    {
        get => GetRequiredArgument<TerraformValue<string>>("client_application_id");
        set => SetArgument("client_application_id", value);
    }

    /// <summary>
    /// The cluster_application_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterApplicationId is required")]
    public required TerraformValue<string> ClusterApplicationId
    {
        get => GetRequiredArgument<TerraformValue<string>>("cluster_application_id");
        set => SetArgument("cluster_application_id", value);
    }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TenantId is required")]
    public required TerraformValue<string> TenantId
    {
        get => GetRequiredArgument<TerraformValue<string>>("tenant_id");
        set => SetArgument("tenant_id", value);
    }

}

/// <summary>
/// Block type for certificate in AzurermServiceFabricManagedClusterAuthenticationBlock.
/// Nesting mode: list
/// </summary>
public class AzurermServiceFabricManagedClusterAuthenticationBlockCertificateBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "certificate";

    /// <summary>
    /// The common_name attribute.
    /// </summary>
    public TerraformValue<string>? CommonName
    {
        get => GetArgument<TerraformValue<string>>("common_name");
        set => SetArgument("common_name", value);
    }

    /// <summary>
    /// The thumbprint attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Thumbprint is required")]
    public required TerraformValue<string> Thumbprint
    {
        get => GetRequiredArgument<TerraformValue<string>>("thumbprint");
        set => SetArgument("thumbprint", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => GetRequiredArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

}


/// <summary>
/// Block type for custom_fabric_setting in AzurermServiceFabricManagedCluster.
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
        get => GetRequiredArgument<TerraformValue<string>>("parameter");
        set => SetArgument("parameter", value);
    }

    /// <summary>
    /// The section attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Section is required")]
    public required TerraformValue<string> Section
    {
        get => GetRequiredArgument<TerraformValue<string>>("section");
        set => SetArgument("section", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}


/// <summary>
/// Block type for lb_rule in AzurermServiceFabricManagedCluster.
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
        get => GetRequiredArgument<TerraformValue<double>>("backend_port");
        set => SetArgument("backend_port", value);
    }

    /// <summary>
    /// The frontend_port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FrontendPort is required")]
    public required TerraformValue<double> FrontendPort
    {
        get => GetRequiredArgument<TerraformValue<double>>("frontend_port");
        set => SetArgument("frontend_port", value);
    }

    /// <summary>
    /// The probe_protocol attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProbeProtocol is required")]
    public required TerraformValue<string> ProbeProtocol
    {
        get => GetRequiredArgument<TerraformValue<string>>("probe_protocol");
        set => SetArgument("probe_protocol", value);
    }

    /// <summary>
    /// The probe_request_path attribute.
    /// </summary>
    public TerraformValue<string>? ProbeRequestPath
    {
        get => GetArgument<TerraformValue<string>>("probe_request_path");
        set => SetArgument("probe_request_path", value);
    }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Protocol is required")]
    public required TerraformValue<string> Protocol
    {
        get => GetRequiredArgument<TerraformValue<string>>("protocol");
        set => SetArgument("protocol", value);
    }

}


/// <summary>
/// Block type for node_type in AzurermServiceFabricManagedCluster.
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
        get => GetRequiredArgument<TerraformValue<string>>("application_port_range");
        set => SetArgument("application_port_range", value);
    }

    /// <summary>
    /// The capacities attribute.
    /// </summary>
    public TerraformMap<string>? Capacities
    {
        get => GetArgument<TerraformMap<string>>("capacities");
        set => SetArgument("capacities", value);
    }

    /// <summary>
    /// The data_disk_size_gb attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataDiskSizeGb is required")]
    public required TerraformValue<double> DataDiskSizeGb
    {
        get => GetRequiredArgument<TerraformValue<double>>("data_disk_size_gb");
        set => SetArgument("data_disk_size_gb", value);
    }

    /// <summary>
    /// The data_disk_type attribute.
    /// </summary>
    public TerraformValue<string>? DataDiskType
    {
        get => GetArgument<TerraformValue<string>>("data_disk_type");
        set => SetArgument("data_disk_type", value);
    }

    /// <summary>
    /// The ephemeral_port_range attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EphemeralPortRange is required")]
    public required TerraformValue<string> EphemeralPortRange
    {
        get => GetRequiredArgument<TerraformValue<string>>("ephemeral_port_range");
        set => SetArgument("ephemeral_port_range", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
        => CreateReference("id");

    /// <summary>
    /// The multiple_placement_groups_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? MultiplePlacementGroupsEnabled
    {
        get => GetArgument<TerraformValue<bool>>("multiple_placement_groups_enabled");
        set => SetArgument("multiple_placement_groups_enabled", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The placement_properties attribute.
    /// </summary>
    public TerraformMap<string>? PlacementProperties
    {
        get => GetArgument<TerraformMap<string>>("placement_properties");
        set => SetArgument("placement_properties", value);
    }

    /// <summary>
    /// The primary attribute.
    /// </summary>
    public TerraformValue<bool>? Primary
    {
        get => GetArgument<TerraformValue<bool>>("primary");
        set => SetArgument("primary", value);
    }

    /// <summary>
    /// The stateless attribute.
    /// </summary>
    public TerraformValue<bool>? Stateless
    {
        get => GetArgument<TerraformValue<bool>>("stateless");
        set => SetArgument("stateless", value);
    }

    /// <summary>
    /// The vm_image_offer attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VmImageOffer is required")]
    public required TerraformValue<string> VmImageOffer
    {
        get => GetRequiredArgument<TerraformValue<string>>("vm_image_offer");
        set => SetArgument("vm_image_offer", value);
    }

    /// <summary>
    /// The vm_image_publisher attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VmImagePublisher is required")]
    public required TerraformValue<string> VmImagePublisher
    {
        get => GetRequiredArgument<TerraformValue<string>>("vm_image_publisher");
        set => SetArgument("vm_image_publisher", value);
    }

    /// <summary>
    /// The vm_image_sku attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VmImageSku is required")]
    public required TerraformValue<string> VmImageSku
    {
        get => GetRequiredArgument<TerraformValue<string>>("vm_image_sku");
        set => SetArgument("vm_image_sku", value);
    }

    /// <summary>
    /// The vm_image_version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VmImageVersion is required")]
    public required TerraformValue<string> VmImageVersion
    {
        get => GetRequiredArgument<TerraformValue<string>>("vm_image_version");
        set => SetArgument("vm_image_version", value);
    }

    /// <summary>
    /// The vm_instance_count attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VmInstanceCount is required")]
    public required TerraformValue<double> VmInstanceCount
    {
        get => GetRequiredArgument<TerraformValue<double>>("vm_instance_count");
        set => SetArgument("vm_instance_count", value);
    }

    /// <summary>
    /// The vm_size attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VmSize is required")]
    public required TerraformValue<string> VmSize
    {
        get => GetRequiredArgument<TerraformValue<string>>("vm_size");
        set => SetArgument("vm_size", value);
    }

    /// <summary>
    /// VmSecrets block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermServiceFabricManagedClusterNodeTypeBlockVmSecretsBlock>? VmSecrets
    {
        get => GetArgument<TerraformList<AzurermServiceFabricManagedClusterNodeTypeBlockVmSecretsBlock>>("vm_secrets");
        set => SetArgument("vm_secrets", value);
    }

}

/// <summary>
/// Block type for vm_secrets in AzurermServiceFabricManagedClusterNodeTypeBlock.
/// Nesting mode: list
/// </summary>
public class AzurermServiceFabricManagedClusterNodeTypeBlockVmSecretsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "vm_secrets";

    /// <summary>
    /// The vault_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VaultId is required")]
    public required TerraformValue<string> VaultId
    {
        get => GetRequiredArgument<TerraformValue<string>>("vault_id");
        set => SetArgument("vault_id", value);
    }

    /// <summary>
    /// Certificates block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Certificates is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Certificates block(s) required")]
    public required TerraformList<AzurermServiceFabricManagedClusterNodeTypeBlockVmSecretsBlockCertificatesBlock> Certificates
    {
        get => GetRequiredArgument<TerraformList<AzurermServiceFabricManagedClusterNodeTypeBlockVmSecretsBlockCertificatesBlock>>("certificates");
        set => SetArgument("certificates", value);
    }

}

/// <summary>
/// Block type for certificates in AzurermServiceFabricManagedClusterNodeTypeBlockVmSecretsBlock.
/// Nesting mode: list
/// </summary>
public class AzurermServiceFabricManagedClusterNodeTypeBlockVmSecretsBlockCertificatesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "certificates";

    /// <summary>
    /// The store attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Store is required")]
    public required TerraformValue<string> Store
    {
        get => GetRequiredArgument<TerraformValue<string>>("store");
        set => SetArgument("store", value);
    }

    /// <summary>
    /// The url attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Url is required")]
    public required TerraformValue<string> Url
    {
        get => GetRequiredArgument<TerraformValue<string>>("url");
        set => SetArgument("url", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermServiceFabricManagedCluster.
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
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
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
        get => GetArgument<TerraformValue<bool>>("backup_service_enabled");
        set => SetArgument("backup_service_enabled", value);
    }

    /// <summary>
    /// The client_connection_port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientConnectionPort is required")]
    public required TerraformValue<double> ClientConnectionPort
    {
        get => GetRequiredArgument<TerraformValue<double>>("client_connection_port");
        set => SetArgument("client_connection_port", value);
    }

    /// <summary>
    /// The dns_name attribute.
    /// </summary>
    public TerraformValue<string> DnsName
    {
        get => GetArgument<TerraformValue<string>>("dns_name") ?? CreateReference("dns_name");
        set => SetArgument("dns_name", value);
    }

    /// <summary>
    /// The dns_service_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? DnsServiceEnabled
    {
        get => GetArgument<TerraformValue<bool>>("dns_service_enabled");
        set => SetArgument("dns_service_enabled", value);
    }

    /// <summary>
    /// The http_gateway_port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HttpGatewayPort is required")]
    public required TerraformValue<double> HttpGatewayPort
    {
        get => GetRequiredArgument<TerraformValue<double>>("http_gateway_port");
        set => SetArgument("http_gateway_port", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetRequiredArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The password attribute.
    /// </summary>
    public TerraformValue<string>? Password
    {
        get => GetArgument<TerraformValue<string>>("password");
        set => SetArgument("password", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => GetRequiredArgument<TerraformValue<string>>("resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The sku attribute.
    /// </summary>
    public TerraformValue<string>? Sku
    {
        get => GetArgument<TerraformValue<string>>("sku");
        set => SetArgument("sku", value);
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    public TerraformValue<string>? SubnetId
    {
        get => GetArgument<TerraformValue<string>>("subnet_id");
        set => SetArgument("subnet_id", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The upgrade_wave attribute.
    /// </summary>
    public TerraformValue<string>? UpgradeWave
    {
        get => GetArgument<TerraformValue<string>>("upgrade_wave");
        set => SetArgument("upgrade_wave", value);
    }

    /// <summary>
    /// The username attribute.
    /// </summary>
    public TerraformValue<string>? Username
    {
        get => GetArgument<TerraformValue<string>>("username");
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
