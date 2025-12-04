using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for azure_active_directory in AzurermServiceFabricCluster.
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
/// Block type for certificate in AzurermServiceFabricCluster.
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
        get => GetRequiredArgument<TerraformValue<string>>("thumbprint");
        set => SetArgument("thumbprint", value);
    }

    /// <summary>
    /// The thumbprint_secondary attribute.
    /// </summary>
    public TerraformValue<string>? ThumbprintSecondary
    {
        get => GetArgument<TerraformValue<string>>("thumbprint_secondary");
        set => SetArgument("thumbprint_secondary", value);
    }

    /// <summary>
    /// The x509_store_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "X509StoreName is required")]
    public required TerraformValue<string> X509StoreName
    {
        get => GetRequiredArgument<TerraformValue<string>>("x509_store_name");
        set => SetArgument("x509_store_name", value);
    }

}


/// <summary>
/// Block type for certificate_common_names in AzurermServiceFabricCluster.
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
        get => GetRequiredArgument<TerraformValue<string>>("x509_store_name");
        set => SetArgument("x509_store_name", value);
    }

    /// <summary>
    /// CommonNames block (nesting mode: set).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CommonNames is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 CommonNames block(s) required")]
    public required TerraformSet<AzurermServiceFabricClusterCertificateCommonNamesBlockCommonNamesBlock> CommonNames
    {
        get => GetRequiredArgument<TerraformSet<AzurermServiceFabricClusterCertificateCommonNamesBlockCommonNamesBlock>>("common_names");
        set => SetArgument("common_names", value);
    }

}

/// <summary>
/// Block type for common_names in AzurermServiceFabricClusterCertificateCommonNamesBlock.
/// Nesting mode: set
/// </summary>
public class AzurermServiceFabricClusterCertificateCommonNamesBlockCommonNamesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "common_names";

    /// <summary>
    /// The certificate_common_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CertificateCommonName is required")]
    public required TerraformValue<string> CertificateCommonName
    {
        get => GetRequiredArgument<TerraformValue<string>>("certificate_common_name");
        set => SetArgument("certificate_common_name", value);
    }

    /// <summary>
    /// The certificate_issuer_thumbprint attribute.
    /// </summary>
    public TerraformValue<string>? CertificateIssuerThumbprint
    {
        get => GetArgument<TerraformValue<string>>("certificate_issuer_thumbprint");
        set => SetArgument("certificate_issuer_thumbprint", value);
    }

}


/// <summary>
/// Block type for client_certificate_common_name in AzurermServiceFabricCluster.
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
        get => GetRequiredArgument<TerraformValue<string>>("common_name");
        set => SetArgument("common_name", value);
    }

    /// <summary>
    /// The is_admin attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IsAdmin is required")]
    public required TerraformValue<bool> IsAdmin
    {
        get => GetRequiredArgument<TerraformValue<bool>>("is_admin");
        set => SetArgument("is_admin", value);
    }

    /// <summary>
    /// The issuer_thumbprint attribute.
    /// </summary>
    public TerraformValue<string>? IssuerThumbprint
    {
        get => GetArgument<TerraformValue<string>>("issuer_thumbprint");
        set => SetArgument("issuer_thumbprint", value);
    }

}


/// <summary>
/// Block type for client_certificate_thumbprint in AzurermServiceFabricCluster.
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
        get => GetRequiredArgument<TerraformValue<bool>>("is_admin");
        set => SetArgument("is_admin", value);
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

}


/// <summary>
/// Block type for diagnostics_config in AzurermServiceFabricCluster.
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
        get => GetRequiredArgument<TerraformValue<string>>("blob_endpoint");
        set => SetArgument("blob_endpoint", value);
    }

    /// <summary>
    /// The protected_account_key_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProtectedAccountKeyName is required")]
    public required TerraformValue<string> ProtectedAccountKeyName
    {
        get => GetRequiredArgument<TerraformValue<string>>("protected_account_key_name");
        set => SetArgument("protected_account_key_name", value);
    }

    /// <summary>
    /// The queue_endpoint attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "QueueEndpoint is required")]
    public required TerraformValue<string> QueueEndpoint
    {
        get => GetRequiredArgument<TerraformValue<string>>("queue_endpoint");
        set => SetArgument("queue_endpoint", value);
    }

    /// <summary>
    /// The storage_account_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageAccountName is required")]
    public required TerraformValue<string> StorageAccountName
    {
        get => GetRequiredArgument<TerraformValue<string>>("storage_account_name");
        set => SetArgument("storage_account_name", value);
    }

    /// <summary>
    /// The table_endpoint attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TableEndpoint is required")]
    public required TerraformValue<string> TableEndpoint
    {
        get => GetRequiredArgument<TerraformValue<string>>("table_endpoint");
        set => SetArgument("table_endpoint", value);
    }

}


/// <summary>
/// Block type for fabric_settings in AzurermServiceFabricCluster.
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
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The parameters attribute.
    /// </summary>
    public TerraformMap<string>? Parameters
    {
        get => GetArgument<TerraformMap<string>>("parameters");
        set => SetArgument("parameters", value);
    }

}


/// <summary>
/// Block type for node_type in AzurermServiceFabricCluster.
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
        get => GetArgument<TerraformMap<string>>("capacities");
        set => SetArgument("capacities", value);
    }

    /// <summary>
    /// The client_endpoint_port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientEndpointPort is required")]
    public required TerraformValue<double> ClientEndpointPort
    {
        get => GetRequiredArgument<TerraformValue<double>>("client_endpoint_port");
        set => SetArgument("client_endpoint_port", value);
    }

    /// <summary>
    /// The durability_level attribute.
    /// </summary>
    public TerraformValue<string>? DurabilityLevel
    {
        get => GetArgument<TerraformValue<string>>("durability_level");
        set => SetArgument("durability_level", value);
    }

    /// <summary>
    /// The http_endpoint_port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HttpEndpointPort is required")]
    public required TerraformValue<double> HttpEndpointPort
    {
        get => GetRequiredArgument<TerraformValue<double>>("http_endpoint_port");
        set => SetArgument("http_endpoint_port", value);
    }

    /// <summary>
    /// The instance_count attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceCount is required")]
    public required TerraformValue<double> InstanceCount
    {
        get => GetRequiredArgument<TerraformValue<double>>("instance_count");
        set => SetArgument("instance_count", value);
    }

    /// <summary>
    /// The is_primary attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IsPrimary is required")]
    public required TerraformValue<bool> IsPrimary
    {
        get => GetRequiredArgument<TerraformValue<bool>>("is_primary");
        set => SetArgument("is_primary", value);
    }

    /// <summary>
    /// The is_stateless attribute.
    /// </summary>
    public TerraformValue<bool>? IsStateless
    {
        get => GetArgument<TerraformValue<bool>>("is_stateless");
        set => SetArgument("is_stateless", value);
    }

    /// <summary>
    /// The multiple_availability_zones attribute.
    /// </summary>
    public TerraformValue<bool>? MultipleAvailabilityZones
    {
        get => GetArgument<TerraformValue<bool>>("multiple_availability_zones");
        set => SetArgument("multiple_availability_zones", value);
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
    /// The reverse_proxy_endpoint_port attribute.
    /// </summary>
    public TerraformValue<double>? ReverseProxyEndpointPort
    {
        get => GetArgument<TerraformValue<double>>("reverse_proxy_endpoint_port");
        set => SetArgument("reverse_proxy_endpoint_port", value);
    }

    /// <summary>
    /// ApplicationPorts block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ApplicationPorts block(s) allowed")]
    public TerraformList<AzurermServiceFabricClusterNodeTypeBlockApplicationPortsBlock>? ApplicationPorts
    {
        get => GetArgument<TerraformList<AzurermServiceFabricClusterNodeTypeBlockApplicationPortsBlock>>("application_ports");
        set => SetArgument("application_ports", value);
    }

    /// <summary>
    /// EphemeralPorts block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EphemeralPorts block(s) allowed")]
    public TerraformList<AzurermServiceFabricClusterNodeTypeBlockEphemeralPortsBlock>? EphemeralPorts
    {
        get => GetArgument<TerraformList<AzurermServiceFabricClusterNodeTypeBlockEphemeralPortsBlock>>("ephemeral_ports");
        set => SetArgument("ephemeral_ports", value);
    }

}

/// <summary>
/// Block type for application_ports in AzurermServiceFabricClusterNodeTypeBlock.
/// Nesting mode: list
/// </summary>
public class AzurermServiceFabricClusterNodeTypeBlockApplicationPortsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "application_ports";

    /// <summary>
    /// The end_port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EndPort is required")]
    public required TerraformValue<double> EndPort
    {
        get => GetRequiredArgument<TerraformValue<double>>("end_port");
        set => SetArgument("end_port", value);
    }

    /// <summary>
    /// The start_port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StartPort is required")]
    public required TerraformValue<double> StartPort
    {
        get => GetRequiredArgument<TerraformValue<double>>("start_port");
        set => SetArgument("start_port", value);
    }

}

/// <summary>
/// Block type for ephemeral_ports in AzurermServiceFabricClusterNodeTypeBlock.
/// Nesting mode: list
/// </summary>
public class AzurermServiceFabricClusterNodeTypeBlockEphemeralPortsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ephemeral_ports";

    /// <summary>
    /// The end_port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EndPort is required")]
    public required TerraformValue<double> EndPort
    {
        get => GetRequiredArgument<TerraformValue<double>>("end_port");
        set => SetArgument("end_port", value);
    }

    /// <summary>
    /// The start_port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StartPort is required")]
    public required TerraformValue<double> StartPort
    {
        get => GetRequiredArgument<TerraformValue<double>>("start_port");
        set => SetArgument("start_port", value);
    }

}


/// <summary>
/// Block type for reverse_proxy_certificate in AzurermServiceFabricCluster.
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
        get => GetRequiredArgument<TerraformValue<string>>("thumbprint");
        set => SetArgument("thumbprint", value);
    }

    /// <summary>
    /// The thumbprint_secondary attribute.
    /// </summary>
    public TerraformValue<string>? ThumbprintSecondary
    {
        get => GetArgument<TerraformValue<string>>("thumbprint_secondary");
        set => SetArgument("thumbprint_secondary", value);
    }

    /// <summary>
    /// The x509_store_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "X509StoreName is required")]
    public required TerraformValue<string> X509StoreName
    {
        get => GetRequiredArgument<TerraformValue<string>>("x509_store_name");
        set => SetArgument("x509_store_name", value);
    }

}


/// <summary>
/// Block type for reverse_proxy_certificate_common_names in AzurermServiceFabricCluster.
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
        get => GetRequiredArgument<TerraformValue<string>>("x509_store_name");
        set => SetArgument("x509_store_name", value);
    }

    /// <summary>
    /// CommonNames block (nesting mode: set).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CommonNames is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 CommonNames block(s) required")]
    public required TerraformSet<AzurermServiceFabricClusterReverseProxyCertificateCommonNamesBlockCommonNamesBlock> CommonNames
    {
        get => GetRequiredArgument<TerraformSet<AzurermServiceFabricClusterReverseProxyCertificateCommonNamesBlockCommonNamesBlock>>("common_names");
        set => SetArgument("common_names", value);
    }

}

/// <summary>
/// Block type for common_names in AzurermServiceFabricClusterReverseProxyCertificateCommonNamesBlock.
/// Nesting mode: set
/// </summary>
public class AzurermServiceFabricClusterReverseProxyCertificateCommonNamesBlockCommonNamesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "common_names";

    /// <summary>
    /// The certificate_common_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CertificateCommonName is required")]
    public required TerraformValue<string> CertificateCommonName
    {
        get => GetRequiredArgument<TerraformValue<string>>("certificate_common_name");
        set => SetArgument("certificate_common_name", value);
    }

    /// <summary>
    /// The certificate_issuer_thumbprint attribute.
    /// </summary>
    public TerraformValue<string>? CertificateIssuerThumbprint
    {
        get => GetArgument<TerraformValue<string>>("certificate_issuer_thumbprint");
        set => SetArgument("certificate_issuer_thumbprint", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermServiceFabricCluster.
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
/// Block type for upgrade_policy in AzurermServiceFabricCluster.
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
        get => GetArgument<TerraformValue<bool>>("force_restart_enabled");
        set => SetArgument("force_restart_enabled", value);
    }

    /// <summary>
    /// The health_check_retry_timeout attribute.
    /// </summary>
    public TerraformValue<string>? HealthCheckRetryTimeout
    {
        get => GetArgument<TerraformValue<string>>("health_check_retry_timeout");
        set => SetArgument("health_check_retry_timeout", value);
    }

    /// <summary>
    /// The health_check_stable_duration attribute.
    /// </summary>
    public TerraformValue<string>? HealthCheckStableDuration
    {
        get => GetArgument<TerraformValue<string>>("health_check_stable_duration");
        set => SetArgument("health_check_stable_duration", value);
    }

    /// <summary>
    /// The health_check_wait_duration attribute.
    /// </summary>
    public TerraformValue<string>? HealthCheckWaitDuration
    {
        get => GetArgument<TerraformValue<string>>("health_check_wait_duration");
        set => SetArgument("health_check_wait_duration", value);
    }

    /// <summary>
    /// The upgrade_domain_timeout attribute.
    /// </summary>
    public TerraformValue<string>? UpgradeDomainTimeout
    {
        get => GetArgument<TerraformValue<string>>("upgrade_domain_timeout");
        set => SetArgument("upgrade_domain_timeout", value);
    }

    /// <summary>
    /// The upgrade_replica_set_check_timeout attribute.
    /// </summary>
    public TerraformValue<string>? UpgradeReplicaSetCheckTimeout
    {
        get => GetArgument<TerraformValue<string>>("upgrade_replica_set_check_timeout");
        set => SetArgument("upgrade_replica_set_check_timeout", value);
    }

    /// <summary>
    /// The upgrade_timeout attribute.
    /// </summary>
    public TerraformValue<string>? UpgradeTimeout
    {
        get => GetArgument<TerraformValue<string>>("upgrade_timeout");
        set => SetArgument("upgrade_timeout", value);
    }

    /// <summary>
    /// DeltaHealthPolicy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DeltaHealthPolicy block(s) allowed")]
    public TerraformList<AzurermServiceFabricClusterUpgradePolicyBlockDeltaHealthPolicyBlock>? DeltaHealthPolicy
    {
        get => GetArgument<TerraformList<AzurermServiceFabricClusterUpgradePolicyBlockDeltaHealthPolicyBlock>>("delta_health_policy");
        set => SetArgument("delta_health_policy", value);
    }

    /// <summary>
    /// HealthPolicy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HealthPolicy block(s) allowed")]
    public TerraformList<AzurermServiceFabricClusterUpgradePolicyBlockHealthPolicyBlock>? HealthPolicy
    {
        get => GetArgument<TerraformList<AzurermServiceFabricClusterUpgradePolicyBlockHealthPolicyBlock>>("health_policy");
        set => SetArgument("health_policy", value);
    }

}

/// <summary>
/// Block type for delta_health_policy in AzurermServiceFabricClusterUpgradePolicyBlock.
/// Nesting mode: list
/// </summary>
public class AzurermServiceFabricClusterUpgradePolicyBlockDeltaHealthPolicyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "delta_health_policy";

    /// <summary>
    /// The max_delta_unhealthy_applications_percent attribute.
    /// </summary>
    public TerraformValue<double>? MaxDeltaUnhealthyApplicationsPercent
    {
        get => GetArgument<TerraformValue<double>>("max_delta_unhealthy_applications_percent");
        set => SetArgument("max_delta_unhealthy_applications_percent", value);
    }

    /// <summary>
    /// The max_delta_unhealthy_nodes_percent attribute.
    /// </summary>
    public TerraformValue<double>? MaxDeltaUnhealthyNodesPercent
    {
        get => GetArgument<TerraformValue<double>>("max_delta_unhealthy_nodes_percent");
        set => SetArgument("max_delta_unhealthy_nodes_percent", value);
    }

    /// <summary>
    /// The max_upgrade_domain_delta_unhealthy_nodes_percent attribute.
    /// </summary>
    public TerraformValue<double>? MaxUpgradeDomainDeltaUnhealthyNodesPercent
    {
        get => GetArgument<TerraformValue<double>>("max_upgrade_domain_delta_unhealthy_nodes_percent");
        set => SetArgument("max_upgrade_domain_delta_unhealthy_nodes_percent", value);
    }

}

/// <summary>
/// Block type for health_policy in AzurermServiceFabricClusterUpgradePolicyBlock.
/// Nesting mode: list
/// </summary>
public class AzurermServiceFabricClusterUpgradePolicyBlockHealthPolicyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "health_policy";

    /// <summary>
    /// The max_unhealthy_applications_percent attribute.
    /// </summary>
    public TerraformValue<double>? MaxUnhealthyApplicationsPercent
    {
        get => GetArgument<TerraformValue<double>>("max_unhealthy_applications_percent");
        set => SetArgument("max_unhealthy_applications_percent", value);
    }

    /// <summary>
    /// The max_unhealthy_nodes_percent attribute.
    /// </summary>
    public TerraformValue<double>? MaxUnhealthyNodesPercent
    {
        get => GetArgument<TerraformValue<double>>("max_unhealthy_nodes_percent");
        set => SetArgument("max_unhealthy_nodes_percent", value);
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
        get => GetArgument<TerraformSet<string>>("add_on_features");
        set => SetArgument("add_on_features", value);
    }

    /// <summary>
    /// The cluster_code_version attribute.
    /// </summary>
    public TerraformValue<string> ClusterCodeVersion
    {
        get => GetArgument<TerraformValue<string>>("cluster_code_version") ?? AsReference("cluster_code_version");
        set => SetArgument("cluster_code_version", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
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
    /// The management_endpoint attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ManagementEndpoint is required")]
    public required TerraformValue<string> ManagementEndpoint
    {
        get => GetRequiredArgument<TerraformValue<string>>("management_endpoint");
        set => SetArgument("management_endpoint", value);
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
    /// The reliability_level attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReliabilityLevel is required")]
    public required TerraformValue<string> ReliabilityLevel
    {
        get => GetRequiredArgument<TerraformValue<string>>("reliability_level");
        set => SetArgument("reliability_level", value);
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
    /// The service_fabric_zonal_upgrade_mode attribute.
    /// </summary>
    public TerraformValue<string>? ServiceFabricZonalUpgradeMode
    {
        get => GetArgument<TerraformValue<string>>("service_fabric_zonal_upgrade_mode");
        set => SetArgument("service_fabric_zonal_upgrade_mode", value);
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
    /// The upgrade_mode attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UpgradeMode is required")]
    public required TerraformValue<string> UpgradeMode
    {
        get => GetRequiredArgument<TerraformValue<string>>("upgrade_mode");
        set => SetArgument("upgrade_mode", value);
    }

    /// <summary>
    /// The vm_image attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VmImage is required")]
    public required TerraformValue<string> VmImage
    {
        get => GetRequiredArgument<TerraformValue<string>>("vm_image");
        set => SetArgument("vm_image", value);
    }

    /// <summary>
    /// The vmss_zonal_upgrade_mode attribute.
    /// </summary>
    public TerraformValue<string>? VmssZonalUpgradeMode
    {
        get => GetArgument<TerraformValue<string>>("vmss_zonal_upgrade_mode");
        set => SetArgument("vmss_zonal_upgrade_mode", value);
    }

    /// <summary>
    /// The cluster_endpoint attribute.
    /// </summary>
    public TerraformValue<string> ClusterEndpoint
        => AsReference("cluster_endpoint");

    /// <summary>
    /// AzureActiveDirectory block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AzureActiveDirectory block(s) allowed")]
    public TerraformList<AzurermServiceFabricClusterAzureActiveDirectoryBlock>? AzureActiveDirectory
    {
        get => GetArgument<TerraformList<AzurermServiceFabricClusterAzureActiveDirectoryBlock>>("azure_active_directory");
        set => SetArgument("azure_active_directory", value);
    }

    /// <summary>
    /// Certificate block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Certificate block(s) allowed")]
    public TerraformList<AzurermServiceFabricClusterCertificateBlock>? Certificate
    {
        get => GetArgument<TerraformList<AzurermServiceFabricClusterCertificateBlock>>("certificate");
        set => SetArgument("certificate", value);
    }

    /// <summary>
    /// CertificateCommonNames block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CertificateCommonNames block(s) allowed")]
    public TerraformList<AzurermServiceFabricClusterCertificateCommonNamesBlock>? CertificateCommonNames
    {
        get => GetArgument<TerraformList<AzurermServiceFabricClusterCertificateCommonNamesBlock>>("certificate_common_names");
        set => SetArgument("certificate_common_names", value);
    }

    /// <summary>
    /// ClientCertificateCommonName block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermServiceFabricClusterClientCertificateCommonNameBlock>? ClientCertificateCommonName
    {
        get => GetArgument<TerraformList<AzurermServiceFabricClusterClientCertificateCommonNameBlock>>("client_certificate_common_name");
        set => SetArgument("client_certificate_common_name", value);
    }

    /// <summary>
    /// ClientCertificateThumbprint block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermServiceFabricClusterClientCertificateThumbprintBlock>? ClientCertificateThumbprint
    {
        get => GetArgument<TerraformList<AzurermServiceFabricClusterClientCertificateThumbprintBlock>>("client_certificate_thumbprint");
        set => SetArgument("client_certificate_thumbprint", value);
    }

    /// <summary>
    /// DiagnosticsConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DiagnosticsConfig block(s) allowed")]
    public TerraformList<AzurermServiceFabricClusterDiagnosticsConfigBlock>? DiagnosticsConfig
    {
        get => GetArgument<TerraformList<AzurermServiceFabricClusterDiagnosticsConfigBlock>>("diagnostics_config");
        set => SetArgument("diagnostics_config", value);
    }

    /// <summary>
    /// FabricSettings block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermServiceFabricClusterFabricSettingsBlock>? FabricSettings
    {
        get => GetArgument<TerraformList<AzurermServiceFabricClusterFabricSettingsBlock>>("fabric_settings");
        set => SetArgument("fabric_settings", value);
    }

    /// <summary>
    /// NodeType block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NodeType is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 NodeType block(s) required")]
    public required TerraformList<AzurermServiceFabricClusterNodeTypeBlock> NodeType
    {
        get => GetRequiredArgument<TerraformList<AzurermServiceFabricClusterNodeTypeBlock>>("node_type");
        set => SetArgument("node_type", value);
    }

    /// <summary>
    /// ReverseProxyCertificate block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ReverseProxyCertificate block(s) allowed")]
    public TerraformList<AzurermServiceFabricClusterReverseProxyCertificateBlock>? ReverseProxyCertificate
    {
        get => GetArgument<TerraformList<AzurermServiceFabricClusterReverseProxyCertificateBlock>>("reverse_proxy_certificate");
        set => SetArgument("reverse_proxy_certificate", value);
    }

    /// <summary>
    /// ReverseProxyCertificateCommonNames block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ReverseProxyCertificateCommonNames block(s) allowed")]
    public TerraformList<AzurermServiceFabricClusterReverseProxyCertificateCommonNamesBlock>? ReverseProxyCertificateCommonNames
    {
        get => GetArgument<TerraformList<AzurermServiceFabricClusterReverseProxyCertificateCommonNamesBlock>>("reverse_proxy_certificate_common_names");
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
    public TerraformList<AzurermServiceFabricClusterUpgradePolicyBlock>? UpgradePolicy
    {
        get => GetArgument<TerraformList<AzurermServiceFabricClusterUpgradePolicyBlock>>("upgrade_policy");
        set => SetArgument("upgrade_policy", value);
    }

}
