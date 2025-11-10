using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for azure_active_directory in .
/// Nesting mode: list
/// </summary>
public class AzurermServiceFabricClusterAzureActiveDirectoryBlock : TerraformBlock
{
    /// <summary>
    /// The client_application_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientApplicationId is required")]
    public required TerraformProperty<string> ClientApplicationId
    {
        set => SetProperty("client_application_id", value);
    }

    /// <summary>
    /// The cluster_application_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterApplicationId is required")]
    public required TerraformProperty<string> ClusterApplicationId
    {
        set => SetProperty("cluster_application_id", value);
    }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TenantId is required")]
    public required TerraformProperty<string> TenantId
    {
        set => SetProperty("tenant_id", value);
    }

}

/// <summary>
/// Block type for certificate in .
/// Nesting mode: list
/// </summary>
public class AzurermServiceFabricClusterCertificateBlock : TerraformBlock
{
    /// <summary>
    /// The thumbprint attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Thumbprint is required")]
    public required TerraformProperty<string> Thumbprint
    {
        set => SetProperty("thumbprint", value);
    }

    /// <summary>
    /// The thumbprint_secondary attribute.
    /// </summary>
    public TerraformProperty<string>? ThumbprintSecondary
    {
        set => SetProperty("thumbprint_secondary", value);
    }

    /// <summary>
    /// The x509_store_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "X509StoreName is required")]
    public required TerraformProperty<string> X509StoreName
    {
        set => SetProperty("x509_store_name", value);
    }

}

/// <summary>
/// Block type for certificate_common_names in .
/// Nesting mode: list
/// </summary>
public class AzurermServiceFabricClusterCertificateCommonNamesBlock : TerraformBlock
{
    /// <summary>
    /// The x509_store_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "X509StoreName is required")]
    public required TerraformProperty<string> X509StoreName
    {
        set => SetProperty("x509_store_name", value);
    }

}

/// <summary>
/// Block type for client_certificate_common_name in .
/// Nesting mode: list
/// </summary>
public class AzurermServiceFabricClusterClientCertificateCommonNameBlock : TerraformBlock
{
    /// <summary>
    /// The common_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CommonName is required")]
    public required TerraformProperty<string> CommonName
    {
        set => SetProperty("common_name", value);
    }

    /// <summary>
    /// The is_admin attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IsAdmin is required")]
    public required TerraformProperty<bool> IsAdmin
    {
        set => SetProperty("is_admin", value);
    }

    /// <summary>
    /// The issuer_thumbprint attribute.
    /// </summary>
    public TerraformProperty<string>? IssuerThumbprint
    {
        set => SetProperty("issuer_thumbprint", value);
    }

}

/// <summary>
/// Block type for client_certificate_thumbprint in .
/// Nesting mode: list
/// </summary>
public class AzurermServiceFabricClusterClientCertificateThumbprintBlock : TerraformBlock
{
    /// <summary>
    /// The is_admin attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IsAdmin is required")]
    public required TerraformProperty<bool> IsAdmin
    {
        set => SetProperty("is_admin", value);
    }

    /// <summary>
    /// The thumbprint attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Thumbprint is required")]
    public required TerraformProperty<string> Thumbprint
    {
        set => SetProperty("thumbprint", value);
    }

}

/// <summary>
/// Block type for diagnostics_config in .
/// Nesting mode: list
/// </summary>
public class AzurermServiceFabricClusterDiagnosticsConfigBlock : TerraformBlock
{
    /// <summary>
    /// The blob_endpoint attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BlobEndpoint is required")]
    public required TerraformProperty<string> BlobEndpoint
    {
        set => SetProperty("blob_endpoint", value);
    }

    /// <summary>
    /// The protected_account_key_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProtectedAccountKeyName is required")]
    public required TerraformProperty<string> ProtectedAccountKeyName
    {
        set => SetProperty("protected_account_key_name", value);
    }

    /// <summary>
    /// The queue_endpoint attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "QueueEndpoint is required")]
    public required TerraformProperty<string> QueueEndpoint
    {
        set => SetProperty("queue_endpoint", value);
    }

    /// <summary>
    /// The storage_account_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageAccountName is required")]
    public required TerraformProperty<string> StorageAccountName
    {
        set => SetProperty("storage_account_name", value);
    }

    /// <summary>
    /// The table_endpoint attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TableEndpoint is required")]
    public required TerraformProperty<string> TableEndpoint
    {
        set => SetProperty("table_endpoint", value);
    }

}

/// <summary>
/// Block type for fabric_settings in .
/// Nesting mode: list
/// </summary>
public class AzurermServiceFabricClusterFabricSettingsBlock : TerraformBlock
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The parameters attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Parameters
    {
        set => SetProperty("parameters", value);
    }

}

/// <summary>
/// Block type for node_type in .
/// Nesting mode: list
/// </summary>
public class AzurermServiceFabricClusterNodeTypeBlock : TerraformBlock
{
    /// <summary>
    /// The capacities attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Capacities
    {
        set => SetProperty("capacities", value);
    }

    /// <summary>
    /// The client_endpoint_port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientEndpointPort is required")]
    public required TerraformProperty<double> ClientEndpointPort
    {
        set => SetProperty("client_endpoint_port", value);
    }

    /// <summary>
    /// The durability_level attribute.
    /// </summary>
    public TerraformProperty<string>? DurabilityLevel
    {
        set => SetProperty("durability_level", value);
    }

    /// <summary>
    /// The http_endpoint_port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HttpEndpointPort is required")]
    public required TerraformProperty<double> HttpEndpointPort
    {
        set => SetProperty("http_endpoint_port", value);
    }

    /// <summary>
    /// The instance_count attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceCount is required")]
    public required TerraformProperty<double> InstanceCount
    {
        set => SetProperty("instance_count", value);
    }

    /// <summary>
    /// The is_primary attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IsPrimary is required")]
    public required TerraformProperty<bool> IsPrimary
    {
        set => SetProperty("is_primary", value);
    }

    /// <summary>
    /// The is_stateless attribute.
    /// </summary>
    public TerraformProperty<bool>? IsStateless
    {
        set => SetProperty("is_stateless", value);
    }

    /// <summary>
    /// The multiple_availability_zones attribute.
    /// </summary>
    public TerraformProperty<bool>? MultipleAvailabilityZones
    {
        set => SetProperty("multiple_availability_zones", value);
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
    /// The reverse_proxy_endpoint_port attribute.
    /// </summary>
    public TerraformProperty<double>? ReverseProxyEndpointPort
    {
        set => SetProperty("reverse_proxy_endpoint_port", value);
    }

}

/// <summary>
/// Block type for reverse_proxy_certificate in .
/// Nesting mode: list
/// </summary>
public class AzurermServiceFabricClusterReverseProxyCertificateBlock : TerraformBlock
{
    /// <summary>
    /// The thumbprint attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Thumbprint is required")]
    public required TerraformProperty<string> Thumbprint
    {
        set => SetProperty("thumbprint", value);
    }

    /// <summary>
    /// The thumbprint_secondary attribute.
    /// </summary>
    public TerraformProperty<string>? ThumbprintSecondary
    {
        set => SetProperty("thumbprint_secondary", value);
    }

    /// <summary>
    /// The x509_store_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "X509StoreName is required")]
    public required TerraformProperty<string> X509StoreName
    {
        set => SetProperty("x509_store_name", value);
    }

}

/// <summary>
/// Block type for reverse_proxy_certificate_common_names in .
/// Nesting mode: list
/// </summary>
public class AzurermServiceFabricClusterReverseProxyCertificateCommonNamesBlock : TerraformBlock
{
    /// <summary>
    /// The x509_store_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "X509StoreName is required")]
    public required TerraformProperty<string> X509StoreName
    {
        set => SetProperty("x509_store_name", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermServiceFabricClusterTimeoutsBlock : TerraformBlock
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
/// Block type for upgrade_policy in .
/// Nesting mode: list
/// </summary>
public class AzurermServiceFabricClusterUpgradePolicyBlock : TerraformBlock
{
    /// <summary>
    /// The force_restart_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? ForceRestartEnabled
    {
        set => SetProperty("force_restart_enabled", value);
    }

    /// <summary>
    /// The health_check_retry_timeout attribute.
    /// </summary>
    public TerraformProperty<string>? HealthCheckRetryTimeout
    {
        set => SetProperty("health_check_retry_timeout", value);
    }

    /// <summary>
    /// The health_check_stable_duration attribute.
    /// </summary>
    public TerraformProperty<string>? HealthCheckStableDuration
    {
        set => SetProperty("health_check_stable_duration", value);
    }

    /// <summary>
    /// The health_check_wait_duration attribute.
    /// </summary>
    public TerraformProperty<string>? HealthCheckWaitDuration
    {
        set => SetProperty("health_check_wait_duration", value);
    }

    /// <summary>
    /// The upgrade_domain_timeout attribute.
    /// </summary>
    public TerraformProperty<string>? UpgradeDomainTimeout
    {
        set => SetProperty("upgrade_domain_timeout", value);
    }

    /// <summary>
    /// The upgrade_replica_set_check_timeout attribute.
    /// </summary>
    public TerraformProperty<string>? UpgradeReplicaSetCheckTimeout
    {
        set => SetProperty("upgrade_replica_set_check_timeout", value);
    }

    /// <summary>
    /// The upgrade_timeout attribute.
    /// </summary>
    public TerraformProperty<string>? UpgradeTimeout
    {
        set => SetProperty("upgrade_timeout", value);
    }

}

/// <summary>
/// Manages a azurerm_service_fabric_cluster resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermServiceFabricCluster : TerraformResource
{
    public AzurermServiceFabricCluster(string name) : base("azurerm_service_fabric_cluster", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("cluster_endpoint");
        SetOutput("add_on_features");
        SetOutput("cluster_code_version");
        SetOutput("id");
        SetOutput("location");
        SetOutput("management_endpoint");
        SetOutput("name");
        SetOutput("reliability_level");
        SetOutput("resource_group_name");
        SetOutput("service_fabric_zonal_upgrade_mode");
        SetOutput("tags");
        SetOutput("upgrade_mode");
        SetOutput("vm_image");
        SetOutput("vmss_zonal_upgrade_mode");
    }

    /// <summary>
    /// The add_on_features attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> AddOnFeatures
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("add_on_features");
        set => SetProperty("add_on_features", value);
    }

    /// <summary>
    /// The cluster_code_version attribute.
    /// </summary>
    public TerraformProperty<string> ClusterCodeVersion
    {
        get => GetRequiredOutput<TerraformProperty<string>>("cluster_code_version");
        set => SetProperty("cluster_code_version", value);
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
    /// The management_endpoint attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ManagementEndpoint is required")]
    public required TerraformProperty<string> ManagementEndpoint
    {
        get => GetRequiredOutput<TerraformProperty<string>>("management_endpoint");
        set => SetProperty("management_endpoint", value);
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
    /// The reliability_level attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReliabilityLevel is required")]
    public required TerraformProperty<string> ReliabilityLevel
    {
        get => GetRequiredOutput<TerraformProperty<string>>("reliability_level");
        set => SetProperty("reliability_level", value);
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
    /// The service_fabric_zonal_upgrade_mode attribute.
    /// </summary>
    public TerraformProperty<string> ServiceFabricZonalUpgradeMode
    {
        get => GetRequiredOutput<TerraformProperty<string>>("service_fabric_zonal_upgrade_mode");
        set => SetProperty("service_fabric_zonal_upgrade_mode", value);
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
    /// The upgrade_mode attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UpgradeMode is required")]
    public required TerraformProperty<string> UpgradeMode
    {
        get => GetRequiredOutput<TerraformProperty<string>>("upgrade_mode");
        set => SetProperty("upgrade_mode", value);
    }

    /// <summary>
    /// The vm_image attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VmImage is required")]
    public required TerraformProperty<string> VmImage
    {
        get => GetRequiredOutput<TerraformProperty<string>>("vm_image");
        set => SetProperty("vm_image", value);
    }

    /// <summary>
    /// The vmss_zonal_upgrade_mode attribute.
    /// </summary>
    public TerraformProperty<string> VmssZonalUpgradeMode
    {
        get => GetRequiredOutput<TerraformProperty<string>>("vmss_zonal_upgrade_mode");
        set => SetProperty("vmss_zonal_upgrade_mode", value);
    }

    /// <summary>
    /// Block for azure_active_directory.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AzureActiveDirectory block(s) allowed")]
    public List<AzurermServiceFabricClusterAzureActiveDirectoryBlock>? AzureActiveDirectory
    {
        set => SetProperty("azure_active_directory", value);
    }

    /// <summary>
    /// Block for certificate.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Certificate block(s) allowed")]
    public List<AzurermServiceFabricClusterCertificateBlock>? Certificate
    {
        set => SetProperty("certificate", value);
    }

    /// <summary>
    /// Block for certificate_common_names.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CertificateCommonNames block(s) allowed")]
    public List<AzurermServiceFabricClusterCertificateCommonNamesBlock>? CertificateCommonNames
    {
        set => SetProperty("certificate_common_names", value);
    }

    /// <summary>
    /// Block for client_certificate_common_name.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermServiceFabricClusterClientCertificateCommonNameBlock>? ClientCertificateCommonName
    {
        set => SetProperty("client_certificate_common_name", value);
    }

    /// <summary>
    /// Block for client_certificate_thumbprint.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermServiceFabricClusterClientCertificateThumbprintBlock>? ClientCertificateThumbprint
    {
        set => SetProperty("client_certificate_thumbprint", value);
    }

    /// <summary>
    /// Block for diagnostics_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DiagnosticsConfig block(s) allowed")]
    public List<AzurermServiceFabricClusterDiagnosticsConfigBlock>? DiagnosticsConfig
    {
        set => SetProperty("diagnostics_config", value);
    }

    /// <summary>
    /// Block for fabric_settings.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermServiceFabricClusterFabricSettingsBlock>? FabricSettings
    {
        set => SetProperty("fabric_settings", value);
    }

    /// <summary>
    /// Block for node_type.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NodeType is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 NodeType block(s) required")]
    public List<AzurermServiceFabricClusterNodeTypeBlock>? NodeType
    {
        set => SetProperty("node_type", value);
    }

    /// <summary>
    /// Block for reverse_proxy_certificate.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ReverseProxyCertificate block(s) allowed")]
    public List<AzurermServiceFabricClusterReverseProxyCertificateBlock>? ReverseProxyCertificate
    {
        set => SetProperty("reverse_proxy_certificate", value);
    }

    /// <summary>
    /// Block for reverse_proxy_certificate_common_names.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ReverseProxyCertificateCommonNames block(s) allowed")]
    public List<AzurermServiceFabricClusterReverseProxyCertificateCommonNamesBlock>? ReverseProxyCertificateCommonNames
    {
        set => SetProperty("reverse_proxy_certificate_common_names", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermServiceFabricClusterTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// Block for upgrade_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 UpgradePolicy block(s) allowed")]
    public List<AzurermServiceFabricClusterUpgradePolicyBlock>? UpgradePolicy
    {
        set => SetProperty("upgrade_policy", value);
    }

    /// <summary>
    /// The cluster_endpoint attribute.
    /// </summary>
    public TerraformExpression ClusterEndpoint => this["cluster_endpoint"];

}
