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
        get => GetRequiredProperty<TerraformProperty<string>>("client_application_id");
        set => WithProperty("client_application_id", value);
    }

    /// <summary>
    /// The cluster_application_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterApplicationId is required")]
    public required TerraformProperty<string> ClusterApplicationId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("cluster_application_id");
        set => WithProperty("cluster_application_id", value);
    }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TenantId is required")]
    public required TerraformProperty<string> TenantId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("tenant_id");
        set => WithProperty("tenant_id", value);
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
        get => GetRequiredProperty<TerraformProperty<string>>("thumbprint");
        set => WithProperty("thumbprint", value);
    }

    /// <summary>
    /// The thumbprint_secondary attribute.
    /// </summary>
    public TerraformProperty<string>? ThumbprintSecondary
    {
        get => GetProperty<TerraformProperty<string>>("thumbprint_secondary");
        set => WithProperty("thumbprint_secondary", value);
    }

    /// <summary>
    /// The x509_store_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "X509StoreName is required")]
    public required TerraformProperty<string> X509StoreName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("x509_store_name");
        set => WithProperty("x509_store_name", value);
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
        get => GetRequiredProperty<TerraformProperty<string>>("x509_store_name");
        set => WithProperty("x509_store_name", value);
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
        get => GetRequiredProperty<TerraformProperty<string>>("common_name");
        set => WithProperty("common_name", value);
    }

    /// <summary>
    /// The is_admin attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IsAdmin is required")]
    public required TerraformProperty<bool> IsAdmin
    {
        get => GetRequiredProperty<TerraformProperty<bool>>("is_admin");
        set => WithProperty("is_admin", value);
    }

    /// <summary>
    /// The issuer_thumbprint attribute.
    /// </summary>
    public TerraformProperty<string>? IssuerThumbprint
    {
        get => GetProperty<TerraformProperty<string>>("issuer_thumbprint");
        set => WithProperty("issuer_thumbprint", value);
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
        get => GetRequiredProperty<TerraformProperty<bool>>("is_admin");
        set => WithProperty("is_admin", value);
    }

    /// <summary>
    /// The thumbprint attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Thumbprint is required")]
    public required TerraformProperty<string> Thumbprint
    {
        get => GetRequiredProperty<TerraformProperty<string>>("thumbprint");
        set => WithProperty("thumbprint", value);
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
        get => GetRequiredProperty<TerraformProperty<string>>("blob_endpoint");
        set => WithProperty("blob_endpoint", value);
    }

    /// <summary>
    /// The protected_account_key_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProtectedAccountKeyName is required")]
    public required TerraformProperty<string> ProtectedAccountKeyName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("protected_account_key_name");
        set => WithProperty("protected_account_key_name", value);
    }

    /// <summary>
    /// The queue_endpoint attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "QueueEndpoint is required")]
    public required TerraformProperty<string> QueueEndpoint
    {
        get => GetRequiredProperty<TerraformProperty<string>>("queue_endpoint");
        set => WithProperty("queue_endpoint", value);
    }

    /// <summary>
    /// The storage_account_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageAccountName is required")]
    public required TerraformProperty<string> StorageAccountName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("storage_account_name");
        set => WithProperty("storage_account_name", value);
    }

    /// <summary>
    /// The table_endpoint attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TableEndpoint is required")]
    public required TerraformProperty<string> TableEndpoint
    {
        get => GetRequiredProperty<TerraformProperty<string>>("table_endpoint");
        set => WithProperty("table_endpoint", value);
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
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

    /// <summary>
    /// The parameters attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Parameters
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("parameters");
        set => WithProperty("parameters", value);
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
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("capacities");
        set => WithProperty("capacities", value);
    }

    /// <summary>
    /// The client_endpoint_port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientEndpointPort is required")]
    public required TerraformProperty<double> ClientEndpointPort
    {
        get => GetRequiredProperty<TerraformProperty<double>>("client_endpoint_port");
        set => WithProperty("client_endpoint_port", value);
    }

    /// <summary>
    /// The durability_level attribute.
    /// </summary>
    public TerraformProperty<string>? DurabilityLevel
    {
        get => GetProperty<TerraformProperty<string>>("durability_level");
        set => WithProperty("durability_level", value);
    }

    /// <summary>
    /// The http_endpoint_port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HttpEndpointPort is required")]
    public required TerraformProperty<double> HttpEndpointPort
    {
        get => GetRequiredProperty<TerraformProperty<double>>("http_endpoint_port");
        set => WithProperty("http_endpoint_port", value);
    }

    /// <summary>
    /// The instance_count attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceCount is required")]
    public required TerraformProperty<double> InstanceCount
    {
        get => GetRequiredProperty<TerraformProperty<double>>("instance_count");
        set => WithProperty("instance_count", value);
    }

    /// <summary>
    /// The is_primary attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IsPrimary is required")]
    public required TerraformProperty<bool> IsPrimary
    {
        get => GetRequiredProperty<TerraformProperty<bool>>("is_primary");
        set => WithProperty("is_primary", value);
    }

    /// <summary>
    /// The is_stateless attribute.
    /// </summary>
    public TerraformProperty<bool>? IsStateless
    {
        get => GetProperty<TerraformProperty<bool>>("is_stateless");
        set => WithProperty("is_stateless", value);
    }

    /// <summary>
    /// The multiple_availability_zones attribute.
    /// </summary>
    public TerraformProperty<bool>? MultipleAvailabilityZones
    {
        get => GetProperty<TerraformProperty<bool>>("multiple_availability_zones");
        set => WithProperty("multiple_availability_zones", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
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
    /// The reverse_proxy_endpoint_port attribute.
    /// </summary>
    public TerraformProperty<double>? ReverseProxyEndpointPort
    {
        get => GetProperty<TerraformProperty<double>>("reverse_proxy_endpoint_port");
        set => WithProperty("reverse_proxy_endpoint_port", value);
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
        get => GetRequiredProperty<TerraformProperty<string>>("thumbprint");
        set => WithProperty("thumbprint", value);
    }

    /// <summary>
    /// The thumbprint_secondary attribute.
    /// </summary>
    public TerraformProperty<string>? ThumbprintSecondary
    {
        get => GetProperty<TerraformProperty<string>>("thumbprint_secondary");
        set => WithProperty("thumbprint_secondary", value);
    }

    /// <summary>
    /// The x509_store_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "X509StoreName is required")]
    public required TerraformProperty<string> X509StoreName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("x509_store_name");
        set => WithProperty("x509_store_name", value);
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
        get => GetRequiredProperty<TerraformProperty<string>>("x509_store_name");
        set => WithProperty("x509_store_name", value);
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
        get => GetProperty<TerraformProperty<bool>>("force_restart_enabled");
        set => WithProperty("force_restart_enabled", value);
    }

    /// <summary>
    /// The health_check_retry_timeout attribute.
    /// </summary>
    public TerraformProperty<string>? HealthCheckRetryTimeout
    {
        get => GetProperty<TerraformProperty<string>>("health_check_retry_timeout");
        set => WithProperty("health_check_retry_timeout", value);
    }

    /// <summary>
    /// The health_check_stable_duration attribute.
    /// </summary>
    public TerraformProperty<string>? HealthCheckStableDuration
    {
        get => GetProperty<TerraformProperty<string>>("health_check_stable_duration");
        set => WithProperty("health_check_stable_duration", value);
    }

    /// <summary>
    /// The health_check_wait_duration attribute.
    /// </summary>
    public TerraformProperty<string>? HealthCheckWaitDuration
    {
        get => GetProperty<TerraformProperty<string>>("health_check_wait_duration");
        set => WithProperty("health_check_wait_duration", value);
    }

    /// <summary>
    /// The upgrade_domain_timeout attribute.
    /// </summary>
    public TerraformProperty<string>? UpgradeDomainTimeout
    {
        get => GetProperty<TerraformProperty<string>>("upgrade_domain_timeout");
        set => WithProperty("upgrade_domain_timeout", value);
    }

    /// <summary>
    /// The upgrade_replica_set_check_timeout attribute.
    /// </summary>
    public TerraformProperty<string>? UpgradeReplicaSetCheckTimeout
    {
        get => GetProperty<TerraformProperty<string>>("upgrade_replica_set_check_timeout");
        set => WithProperty("upgrade_replica_set_check_timeout", value);
    }

    /// <summary>
    /// The upgrade_timeout attribute.
    /// </summary>
    public TerraformProperty<string>? UpgradeTimeout
    {
        get => GetProperty<TerraformProperty<string>>("upgrade_timeout");
        set => WithProperty("upgrade_timeout", value);
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
        this.DeclareOutput("cluster_endpoint");
    }

    /// <summary>
    /// The add_on_features attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? AddOnFeatures
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("add_on_features");
        set => this.WithProperty("add_on_features", value);
    }

    /// <summary>
    /// The cluster_code_version attribute.
    /// </summary>
    public TerraformProperty<string>? ClusterCodeVersion
    {
        get => GetProperty<TerraformProperty<string>>("cluster_code_version");
        set => this.WithProperty("cluster_code_version", value);
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
        get => GetRequiredProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The management_endpoint attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ManagementEndpoint is required")]
    public required TerraformProperty<string> ManagementEndpoint
    {
        get => GetRequiredProperty<TerraformProperty<string>>("management_endpoint");
        set => this.WithProperty("management_endpoint", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The reliability_level attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReliabilityLevel is required")]
    public required TerraformProperty<string> ReliabilityLevel
    {
        get => GetRequiredProperty<TerraformProperty<string>>("reliability_level");
        set => this.WithProperty("reliability_level", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The service_fabric_zonal_upgrade_mode attribute.
    /// </summary>
    public TerraformProperty<string>? ServiceFabricZonalUpgradeMode
    {
        get => GetProperty<TerraformProperty<string>>("service_fabric_zonal_upgrade_mode");
        set => this.WithProperty("service_fabric_zonal_upgrade_mode", value);
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
    /// The upgrade_mode attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UpgradeMode is required")]
    public required TerraformProperty<string> UpgradeMode
    {
        get => GetRequiredProperty<TerraformProperty<string>>("upgrade_mode");
        set => this.WithProperty("upgrade_mode", value);
    }

    /// <summary>
    /// The vm_image attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VmImage is required")]
    public required TerraformProperty<string> VmImage
    {
        get => GetRequiredProperty<TerraformProperty<string>>("vm_image");
        set => this.WithProperty("vm_image", value);
    }

    /// <summary>
    /// The vmss_zonal_upgrade_mode attribute.
    /// </summary>
    public TerraformProperty<string>? VmssZonalUpgradeMode
    {
        get => GetProperty<TerraformProperty<string>>("vmss_zonal_upgrade_mode");
        set => this.WithProperty("vmss_zonal_upgrade_mode", value);
    }

    /// <summary>
    /// Block for azure_active_directory.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AzureActiveDirectory block(s) allowed")]
    public List<AzurermServiceFabricClusterAzureActiveDirectoryBlock>? AzureActiveDirectory
    {
        get => GetProperty<List<AzurermServiceFabricClusterAzureActiveDirectoryBlock>>("azure_active_directory");
        set => this.WithProperty("azure_active_directory", value);
    }

    /// <summary>
    /// Block for certificate.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Certificate block(s) allowed")]
    public List<AzurermServiceFabricClusterCertificateBlock>? Certificate
    {
        get => GetProperty<List<AzurermServiceFabricClusterCertificateBlock>>("certificate");
        set => this.WithProperty("certificate", value);
    }

    /// <summary>
    /// Block for certificate_common_names.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CertificateCommonNames block(s) allowed")]
    public List<AzurermServiceFabricClusterCertificateCommonNamesBlock>? CertificateCommonNames
    {
        get => GetProperty<List<AzurermServiceFabricClusterCertificateCommonNamesBlock>>("certificate_common_names");
        set => this.WithProperty("certificate_common_names", value);
    }

    /// <summary>
    /// Block for client_certificate_common_name.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermServiceFabricClusterClientCertificateCommonNameBlock>? ClientCertificateCommonName
    {
        get => GetProperty<List<AzurermServiceFabricClusterClientCertificateCommonNameBlock>>("client_certificate_common_name");
        set => this.WithProperty("client_certificate_common_name", value);
    }

    /// <summary>
    /// Block for client_certificate_thumbprint.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermServiceFabricClusterClientCertificateThumbprintBlock>? ClientCertificateThumbprint
    {
        get => GetProperty<List<AzurermServiceFabricClusterClientCertificateThumbprintBlock>>("client_certificate_thumbprint");
        set => this.WithProperty("client_certificate_thumbprint", value);
    }

    /// <summary>
    /// Block for diagnostics_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DiagnosticsConfig block(s) allowed")]
    public List<AzurermServiceFabricClusterDiagnosticsConfigBlock>? DiagnosticsConfig
    {
        get => GetProperty<List<AzurermServiceFabricClusterDiagnosticsConfigBlock>>("diagnostics_config");
        set => this.WithProperty("diagnostics_config", value);
    }

    /// <summary>
    /// Block for fabric_settings.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermServiceFabricClusterFabricSettingsBlock>? FabricSettings
    {
        get => GetProperty<List<AzurermServiceFabricClusterFabricSettingsBlock>>("fabric_settings");
        set => this.WithProperty("fabric_settings", value);
    }

    /// <summary>
    /// Block for node_type.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 NodeType block(s) required")]
    public List<AzurermServiceFabricClusterNodeTypeBlock>? NodeType
    {
        get => GetProperty<List<AzurermServiceFabricClusterNodeTypeBlock>>("node_type");
        set => this.WithProperty("node_type", value);
    }

    /// <summary>
    /// Block for reverse_proxy_certificate.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ReverseProxyCertificate block(s) allowed")]
    public List<AzurermServiceFabricClusterReverseProxyCertificateBlock>? ReverseProxyCertificate
    {
        get => GetProperty<List<AzurermServiceFabricClusterReverseProxyCertificateBlock>>("reverse_proxy_certificate");
        set => this.WithProperty("reverse_proxy_certificate", value);
    }

    /// <summary>
    /// Block for reverse_proxy_certificate_common_names.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ReverseProxyCertificateCommonNames block(s) allowed")]
    public List<AzurermServiceFabricClusterReverseProxyCertificateCommonNamesBlock>? ReverseProxyCertificateCommonNames
    {
        get => GetProperty<List<AzurermServiceFabricClusterReverseProxyCertificateCommonNamesBlock>>("reverse_proxy_certificate_common_names");
        set => this.WithProperty("reverse_proxy_certificate_common_names", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermServiceFabricClusterTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermServiceFabricClusterTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// Block for upgrade_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 UpgradePolicy block(s) allowed")]
    public List<AzurermServiceFabricClusterUpgradePolicyBlock>? UpgradePolicy
    {
        get => GetProperty<List<AzurermServiceFabricClusterUpgradePolicyBlock>>("upgrade_policy");
        set => this.WithProperty("upgrade_policy", value);
    }

    /// <summary>
    /// The cluster_endpoint attribute.
    /// </summary>
    public TerraformExpression ClusterEndpoint => this["cluster_endpoint"];

}
