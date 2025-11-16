using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for azure_active_directory in .
/// Nesting mode: list
/// </summary>
public class AzurermServiceFabricClusterAzureActiveDirectoryBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "azure_active_directory";

    /// <summary>
    /// The client_application_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientApplicationId is required")]
    public required TerraformValue<string> ClientApplicationId
    {
        get => new TerraformReference<string>(this, "client_application_id");
        set => SetArgument("client_application_id", value);
    }

    /// <summary>
    /// The cluster_application_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterApplicationId is required")]
    public required TerraformValue<string> ClusterApplicationId
    {
        get => new TerraformReference<string>(this, "cluster_application_id");
        set => SetArgument("cluster_application_id", value);
    }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TenantId is required")]
    public required TerraformValue<string> TenantId
    {
        get => new TerraformReference<string>(this, "tenant_id");
        set => SetArgument("tenant_id", value);
    }

}

/// <summary>
/// Block type for certificate in .
/// Nesting mode: list
/// </summary>
public class AzurermServiceFabricClusterCertificateBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "certificate";

    /// <summary>
    /// The thumbprint attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Thumbprint is required")]
    public required TerraformValue<string> Thumbprint
    {
        get => new TerraformReference<string>(this, "thumbprint");
        set => SetArgument("thumbprint", value);
    }

    /// <summary>
    /// The thumbprint_secondary attribute.
    /// </summary>
    public TerraformValue<string>? ThumbprintSecondary
    {
        get => new TerraformReference<string>(this, "thumbprint_secondary");
        set => SetArgument("thumbprint_secondary", value);
    }

    /// <summary>
    /// The x509_store_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "X509StoreName is required")]
    public required TerraformValue<string> X509StoreName
    {
        get => new TerraformReference<string>(this, "x509_store_name");
        set => SetArgument("x509_store_name", value);
    }

}

/// <summary>
/// Block type for certificate_common_names in .
/// Nesting mode: list
/// </summary>
public class AzurermServiceFabricClusterCertificateCommonNamesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "certificate_common_names";

    /// <summary>
    /// The x509_store_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "X509StoreName is required")]
    public required TerraformValue<string> X509StoreName
    {
        get => new TerraformReference<string>(this, "x509_store_name");
        set => SetArgument("x509_store_name", value);
    }

}

/// <summary>
/// Block type for client_certificate_common_name in .
/// Nesting mode: list
/// </summary>
public class AzurermServiceFabricClusterClientCertificateCommonNameBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "client_certificate_common_name";

    /// <summary>
    /// The common_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CommonName is required")]
    public required TerraformValue<string> CommonName
    {
        get => new TerraformReference<string>(this, "common_name");
        set => SetArgument("common_name", value);
    }

    /// <summary>
    /// The is_admin attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IsAdmin is required")]
    public required TerraformValue<bool> IsAdmin
    {
        get => new TerraformReference<bool>(this, "is_admin");
        set => SetArgument("is_admin", value);
    }

    /// <summary>
    /// The issuer_thumbprint attribute.
    /// </summary>
    public TerraformValue<string>? IssuerThumbprint
    {
        get => new TerraformReference<string>(this, "issuer_thumbprint");
        set => SetArgument("issuer_thumbprint", value);
    }

}

/// <summary>
/// Block type for client_certificate_thumbprint in .
/// Nesting mode: list
/// </summary>
public class AzurermServiceFabricClusterClientCertificateThumbprintBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "client_certificate_thumbprint";

    /// <summary>
    /// The is_admin attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IsAdmin is required")]
    public required TerraformValue<bool> IsAdmin
    {
        get => new TerraformReference<bool>(this, "is_admin");
        set => SetArgument("is_admin", value);
    }

    /// <summary>
    /// The thumbprint attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Thumbprint is required")]
    public required TerraformValue<string> Thumbprint
    {
        get => new TerraformReference<string>(this, "thumbprint");
        set => SetArgument("thumbprint", value);
    }

}

/// <summary>
/// Block type for diagnostics_config in .
/// Nesting mode: list
/// </summary>
public class AzurermServiceFabricClusterDiagnosticsConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "diagnostics_config";

    /// <summary>
    /// The blob_endpoint attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BlobEndpoint is required")]
    public required TerraformValue<string> BlobEndpoint
    {
        get => new TerraformReference<string>(this, "blob_endpoint");
        set => SetArgument("blob_endpoint", value);
    }

    /// <summary>
    /// The protected_account_key_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProtectedAccountKeyName is required")]
    public required TerraformValue<string> ProtectedAccountKeyName
    {
        get => new TerraformReference<string>(this, "protected_account_key_name");
        set => SetArgument("protected_account_key_name", value);
    }

    /// <summary>
    /// The queue_endpoint attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "QueueEndpoint is required")]
    public required TerraformValue<string> QueueEndpoint
    {
        get => new TerraformReference<string>(this, "queue_endpoint");
        set => SetArgument("queue_endpoint", value);
    }

    /// <summary>
    /// The storage_account_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageAccountName is required")]
    public required TerraformValue<string> StorageAccountName
    {
        get => new TerraformReference<string>(this, "storage_account_name");
        set => SetArgument("storage_account_name", value);
    }

    /// <summary>
    /// The table_endpoint attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TableEndpoint is required")]
    public required TerraformValue<string> TableEndpoint
    {
        get => new TerraformReference<string>(this, "table_endpoint");
        set => SetArgument("table_endpoint", value);
    }

}

/// <summary>
/// Block type for fabric_settings in .
/// Nesting mode: list
/// </summary>
public class AzurermServiceFabricClusterFabricSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "fabric_settings";

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
    /// The parameters attribute.
    /// </summary>
    public TerraformMap<string>? Parameters
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "parameters").ResolveNodes(ctx));
        set => SetArgument("parameters", value);
    }

}

/// <summary>
/// Block type for node_type in .
/// Nesting mode: list
/// </summary>
public class AzurermServiceFabricClusterNodeTypeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "node_type";

    /// <summary>
    /// The capacities attribute.
    /// </summary>
    public TerraformMap<string>? Capacities
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "capacities").ResolveNodes(ctx));
        set => SetArgument("capacities", value);
    }

    /// <summary>
    /// The client_endpoint_port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientEndpointPort is required")]
    public required TerraformValue<double> ClientEndpointPort
    {
        get => new TerraformReference<double>(this, "client_endpoint_port");
        set => SetArgument("client_endpoint_port", value);
    }

    /// <summary>
    /// The durability_level attribute.
    /// </summary>
    public TerraformValue<string>? DurabilityLevel
    {
        get => new TerraformReference<string>(this, "durability_level");
        set => SetArgument("durability_level", value);
    }

    /// <summary>
    /// The http_endpoint_port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HttpEndpointPort is required")]
    public required TerraformValue<double> HttpEndpointPort
    {
        get => new TerraformReference<double>(this, "http_endpoint_port");
        set => SetArgument("http_endpoint_port", value);
    }

    /// <summary>
    /// The instance_count attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceCount is required")]
    public required TerraformValue<double> InstanceCount
    {
        get => new TerraformReference<double>(this, "instance_count");
        set => SetArgument("instance_count", value);
    }

    /// <summary>
    /// The is_primary attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IsPrimary is required")]
    public required TerraformValue<bool> IsPrimary
    {
        get => new TerraformReference<bool>(this, "is_primary");
        set => SetArgument("is_primary", value);
    }

    /// <summary>
    /// The is_stateless attribute.
    /// </summary>
    public TerraformValue<bool>? IsStateless
    {
        get => new TerraformReference<bool>(this, "is_stateless");
        set => SetArgument("is_stateless", value);
    }

    /// <summary>
    /// The multiple_availability_zones attribute.
    /// </summary>
    public TerraformValue<bool>? MultipleAvailabilityZones
    {
        get => new TerraformReference<bool>(this, "multiple_availability_zones");
        set => SetArgument("multiple_availability_zones", value);
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
    /// The reverse_proxy_endpoint_port attribute.
    /// </summary>
    public TerraformValue<double>? ReverseProxyEndpointPort
    {
        get => new TerraformReference<double>(this, "reverse_proxy_endpoint_port");
        set => SetArgument("reverse_proxy_endpoint_port", value);
    }

}

/// <summary>
/// Block type for reverse_proxy_certificate in .
/// Nesting mode: list
/// </summary>
public class AzurermServiceFabricClusterReverseProxyCertificateBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "reverse_proxy_certificate";

    /// <summary>
    /// The thumbprint attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Thumbprint is required")]
    public required TerraformValue<string> Thumbprint
    {
        get => new TerraformReference<string>(this, "thumbprint");
        set => SetArgument("thumbprint", value);
    }

    /// <summary>
    /// The thumbprint_secondary attribute.
    /// </summary>
    public TerraformValue<string>? ThumbprintSecondary
    {
        get => new TerraformReference<string>(this, "thumbprint_secondary");
        set => SetArgument("thumbprint_secondary", value);
    }

    /// <summary>
    /// The x509_store_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "X509StoreName is required")]
    public required TerraformValue<string> X509StoreName
    {
        get => new TerraformReference<string>(this, "x509_store_name");
        set => SetArgument("x509_store_name", value);
    }

}

/// <summary>
/// Block type for reverse_proxy_certificate_common_names in .
/// Nesting mode: list
/// </summary>
public class AzurermServiceFabricClusterReverseProxyCertificateCommonNamesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "reverse_proxy_certificate_common_names";

    /// <summary>
    /// The x509_store_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "X509StoreName is required")]
    public required TerraformValue<string> X509StoreName
    {
        get => new TerraformReference<string>(this, "x509_store_name");
        set => SetArgument("x509_store_name", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermServiceFabricClusterTimeoutsBlock : TerraformBlock
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
/// Block type for upgrade_policy in .
/// Nesting mode: list
/// </summary>
public class AzurermServiceFabricClusterUpgradePolicyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "upgrade_policy";

    /// <summary>
    /// The force_restart_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? ForceRestartEnabled
    {
        get => new TerraformReference<bool>(this, "force_restart_enabled");
        set => SetArgument("force_restart_enabled", value);
    }

    /// <summary>
    /// The health_check_retry_timeout attribute.
    /// </summary>
    public TerraformValue<string>? HealthCheckRetryTimeout
    {
        get => new TerraformReference<string>(this, "health_check_retry_timeout");
        set => SetArgument("health_check_retry_timeout", value);
    }

    /// <summary>
    /// The health_check_stable_duration attribute.
    /// </summary>
    public TerraformValue<string>? HealthCheckStableDuration
    {
        get => new TerraformReference<string>(this, "health_check_stable_duration");
        set => SetArgument("health_check_stable_duration", value);
    }

    /// <summary>
    /// The health_check_wait_duration attribute.
    /// </summary>
    public TerraformValue<string>? HealthCheckWaitDuration
    {
        get => new TerraformReference<string>(this, "health_check_wait_duration");
        set => SetArgument("health_check_wait_duration", value);
    }

    /// <summary>
    /// The upgrade_domain_timeout attribute.
    /// </summary>
    public TerraformValue<string>? UpgradeDomainTimeout
    {
        get => new TerraformReference<string>(this, "upgrade_domain_timeout");
        set => SetArgument("upgrade_domain_timeout", value);
    }

    /// <summary>
    /// The upgrade_replica_set_check_timeout attribute.
    /// </summary>
    public TerraformValue<string>? UpgradeReplicaSetCheckTimeout
    {
        get => new TerraformReference<string>(this, "upgrade_replica_set_check_timeout");
        set => SetArgument("upgrade_replica_set_check_timeout", value);
    }

    /// <summary>
    /// The upgrade_timeout attribute.
    /// </summary>
    public TerraformValue<string>? UpgradeTimeout
    {
        get => new TerraformReference<string>(this, "upgrade_timeout");
        set => SetArgument("upgrade_timeout", value);
    }

}

/// <summary>
/// Represents a azurerm_service_fabric_cluster Terraform resource.
/// Manages a azurerm_service_fabric_cluster resource.
/// </summary>
public partial class AzurermServiceFabricCluster(string name) : TerraformResource("azurerm_service_fabric_cluster", name)
{
    /// <summary>
    /// The add_on_features attribute.
    /// </summary>
    public TerraformSet<string>? AddOnFeatures
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "add_on_features").ResolveNodes(ctx));
        set => SetArgument("add_on_features", value);
    }

    /// <summary>
    /// The cluster_code_version attribute.
    /// </summary>
    public TerraformValue<string> ClusterCodeVersion
    {
        get => new TerraformReference<string>(this, "cluster_code_version");
        set => SetArgument("cluster_code_version", value);
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
    /// The management_endpoint attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ManagementEndpoint is required")]
    public required TerraformValue<string> ManagementEndpoint
    {
        get => new TerraformReference<string>(this, "management_endpoint");
        set => SetArgument("management_endpoint", value);
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
    /// The reliability_level attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReliabilityLevel is required")]
    public required TerraformValue<string> ReliabilityLevel
    {
        get => new TerraformReference<string>(this, "reliability_level");
        set => SetArgument("reliability_level", value);
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
    /// The service_fabric_zonal_upgrade_mode attribute.
    /// </summary>
    public TerraformValue<string>? ServiceFabricZonalUpgradeMode
    {
        get => new TerraformReference<string>(this, "service_fabric_zonal_upgrade_mode");
        set => SetArgument("service_fabric_zonal_upgrade_mode", value);
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
    /// The upgrade_mode attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UpgradeMode is required")]
    public required TerraformValue<string> UpgradeMode
    {
        get => new TerraformReference<string>(this, "upgrade_mode");
        set => SetArgument("upgrade_mode", value);
    }

    /// <summary>
    /// The vm_image attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VmImage is required")]
    public required TerraformValue<string> VmImage
    {
        get => new TerraformReference<string>(this, "vm_image");
        set => SetArgument("vm_image", value);
    }

    /// <summary>
    /// The vmss_zonal_upgrade_mode attribute.
    /// </summary>
    public TerraformValue<string>? VmssZonalUpgradeMode
    {
        get => new TerraformReference<string>(this, "vmss_zonal_upgrade_mode");
        set => SetArgument("vmss_zonal_upgrade_mode", value);
    }

    /// <summary>
    /// AzureActiveDirectory block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AzureActiveDirectory block(s) allowed")]
    public AzurermServiceFabricClusterAzureActiveDirectoryBlock? AzureActiveDirectory
    {
        get => GetArgument<AzurermServiceFabricClusterAzureActiveDirectoryBlock>("azure_active_directory");
        set => SetArgument("azure_active_directory", value);
    }

    /// <summary>
    /// Certificate block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Certificate block(s) allowed")]
    public AzurermServiceFabricClusterCertificateBlock? Certificate
    {
        get => GetArgument<AzurermServiceFabricClusterCertificateBlock>("certificate");
        set => SetArgument("certificate", value);
    }

    /// <summary>
    /// CertificateCommonNames block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CertificateCommonNames block(s) allowed")]
    public AzurermServiceFabricClusterCertificateCommonNamesBlock? CertificateCommonNames
    {
        get => GetArgument<AzurermServiceFabricClusterCertificateCommonNamesBlock>("certificate_common_names");
        set => SetArgument("certificate_common_names", value);
    }

    /// <summary>
    /// ClientCertificateCommonName block (nesting mode: list).
    /// </summary>
    public AzurermServiceFabricClusterClientCertificateCommonNameBlock? ClientCertificateCommonName
    {
        get => GetArgument<AzurermServiceFabricClusterClientCertificateCommonNameBlock>("client_certificate_common_name");
        set => SetArgument("client_certificate_common_name", value);
    }

    /// <summary>
    /// ClientCertificateThumbprint block (nesting mode: list).
    /// </summary>
    public AzurermServiceFabricClusterClientCertificateThumbprintBlock? ClientCertificateThumbprint
    {
        get => GetArgument<AzurermServiceFabricClusterClientCertificateThumbprintBlock>("client_certificate_thumbprint");
        set => SetArgument("client_certificate_thumbprint", value);
    }

    /// <summary>
    /// DiagnosticsConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DiagnosticsConfig block(s) allowed")]
    public AzurermServiceFabricClusterDiagnosticsConfigBlock? DiagnosticsConfig
    {
        get => GetArgument<AzurermServiceFabricClusterDiagnosticsConfigBlock>("diagnostics_config");
        set => SetArgument("diagnostics_config", value);
    }

    /// <summary>
    /// FabricSettings block (nesting mode: list).
    /// </summary>
    public AzurermServiceFabricClusterFabricSettingsBlock? FabricSettings
    {
        get => GetArgument<AzurermServiceFabricClusterFabricSettingsBlock>("fabric_settings");
        set => SetArgument("fabric_settings", value);
    }

    /// <summary>
    /// NodeType block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NodeType is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 NodeType block(s) required")]
    public required AzurermServiceFabricClusterNodeTypeBlock NodeType
    {
        get => GetRequiredArgument<AzurermServiceFabricClusterNodeTypeBlock>("node_type");
        set => SetArgument("node_type", value);
    }

    /// <summary>
    /// ReverseProxyCertificate block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ReverseProxyCertificate block(s) allowed")]
    public AzurermServiceFabricClusterReverseProxyCertificateBlock? ReverseProxyCertificate
    {
        get => GetArgument<AzurermServiceFabricClusterReverseProxyCertificateBlock>("reverse_proxy_certificate");
        set => SetArgument("reverse_proxy_certificate", value);
    }

    /// <summary>
    /// ReverseProxyCertificateCommonNames block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ReverseProxyCertificateCommonNames block(s) allowed")]
    public AzurermServiceFabricClusterReverseProxyCertificateCommonNamesBlock? ReverseProxyCertificateCommonNames
    {
        get => GetArgument<AzurermServiceFabricClusterReverseProxyCertificateCommonNamesBlock>("reverse_proxy_certificate_common_names");
        set => SetArgument("reverse_proxy_certificate_common_names", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermServiceFabricClusterTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermServiceFabricClusterTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

    /// <summary>
    /// UpgradePolicy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 UpgradePolicy block(s) allowed")]
    public AzurermServiceFabricClusterUpgradePolicyBlock? UpgradePolicy
    {
        get => GetArgument<AzurermServiceFabricClusterUpgradePolicyBlock>("upgrade_policy");
        set => SetArgument("upgrade_policy", value);
    }

}
