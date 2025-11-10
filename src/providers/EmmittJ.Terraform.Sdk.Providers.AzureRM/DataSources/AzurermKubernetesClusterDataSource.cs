using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermKubernetesClusterDataSourceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_kubernetes_cluster.
/// </summary>
public class AzurermKubernetesClusterDataSource : TerraformDataSource
{
    public AzurermKubernetesClusterDataSource(string name) : base("azurerm_kubernetes_cluster", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ResourceGroupName { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermKubernetesClusterDataSourceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The aci_connector_linux attribute.
    /// </summary>
    [TerraformPropertyName("aci_connector_linux")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> AciConnectorLinux => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "aci_connector_linux");

    /// <summary>
    /// The agent_pool_profile attribute.
    /// </summary>
    [TerraformPropertyName("agent_pool_profile")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> AgentPoolProfile => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "agent_pool_profile");

    /// <summary>
    /// The api_server_authorized_ip_ranges attribute.
    /// </summary>
    [TerraformPropertyName("api_server_authorized_ip_ranges")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<string>>> ApiServerAuthorizedIpRanges => new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "api_server_authorized_ip_ranges");

    /// <summary>
    /// The azure_active_directory_role_based_access_control attribute.
    /// </summary>
    [TerraformPropertyName("azure_active_directory_role_based_access_control")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> AzureActiveDirectoryRoleBasedAccessControl => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "azure_active_directory_role_based_access_control");

    /// <summary>
    /// The azure_policy_enabled attribute.
    /// </summary>
    [TerraformPropertyName("azure_policy_enabled")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> AzurePolicyEnabled => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "azure_policy_enabled");

    /// <summary>
    /// The current_kubernetes_version attribute.
    /// </summary>
    [TerraformPropertyName("current_kubernetes_version")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CurrentKubernetesVersion => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "current_kubernetes_version");

    /// <summary>
    /// The disk_encryption_set_id attribute.
    /// </summary>
    [TerraformPropertyName("disk_encryption_set_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DiskEncryptionSetId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "disk_encryption_set_id");

    /// <summary>
    /// The dns_prefix attribute.
    /// </summary>
    [TerraformPropertyName("dns_prefix")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DnsPrefix => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "dns_prefix");

    /// <summary>
    /// The fqdn attribute.
    /// </summary>
    [TerraformPropertyName("fqdn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Fqdn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "fqdn");

    /// <summary>
    /// The http_application_routing_enabled attribute.
    /// </summary>
    [TerraformPropertyName("http_application_routing_enabled")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> HttpApplicationRoutingEnabled => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "http_application_routing_enabled");

    /// <summary>
    /// The http_application_routing_zone_name attribute.
    /// </summary>
    [TerraformPropertyName("http_application_routing_zone_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> HttpApplicationRoutingZoneName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "http_application_routing_zone_name");

    /// <summary>
    /// The identity attribute.
    /// </summary>
    [TerraformPropertyName("identity")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Identity => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "identity");

    /// <summary>
    /// The ingress_application_gateway attribute.
    /// </summary>
    [TerraformPropertyName("ingress_application_gateway")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> IngressApplicationGateway => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "ingress_application_gateway");

    /// <summary>
    /// The key_management_service attribute.
    /// </summary>
    [TerraformPropertyName("key_management_service")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> KeyManagementService => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "key_management_service");

    /// <summary>
    /// The key_vault_secrets_provider attribute.
    /// </summary>
    [TerraformPropertyName("key_vault_secrets_provider")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> KeyVaultSecretsProvider => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "key_vault_secrets_provider");

    /// <summary>
    /// The kube_admin_config attribute.
    /// </summary>
    [TerraformPropertyName("kube_admin_config")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> KubeAdminConfig => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "kube_admin_config");

    /// <summary>
    /// The kube_admin_config_raw attribute.
    /// </summary>
    [TerraformPropertyName("kube_admin_config_raw")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> KubeAdminConfigRaw => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "kube_admin_config_raw");

    /// <summary>
    /// The kube_config attribute.
    /// </summary>
    [TerraformPropertyName("kube_config")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> KubeConfig => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "kube_config");

    /// <summary>
    /// The kube_config_raw attribute.
    /// </summary>
    [TerraformPropertyName("kube_config_raw")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> KubeConfigRaw => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "kube_config_raw");

    /// <summary>
    /// The kubelet_identity attribute.
    /// </summary>
    [TerraformPropertyName("kubelet_identity")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> KubeletIdentity => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "kubelet_identity");

    /// <summary>
    /// The kubernetes_version attribute.
    /// </summary>
    [TerraformPropertyName("kubernetes_version")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> KubernetesVersion => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "kubernetes_version");

    /// <summary>
    /// The linux_profile attribute.
    /// </summary>
    [TerraformPropertyName("linux_profile")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> LinuxProfile => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "linux_profile");

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformPropertyName("location")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Location => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "location");

    /// <summary>
    /// The microsoft_defender attribute.
    /// </summary>
    [TerraformPropertyName("microsoft_defender")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> MicrosoftDefender => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "microsoft_defender");

    /// <summary>
    /// The network_profile attribute.
    /// </summary>
    [TerraformPropertyName("network_profile")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> NetworkProfile => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "network_profile");

    /// <summary>
    /// The node_resource_group attribute.
    /// </summary>
    [TerraformPropertyName("node_resource_group")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> NodeResourceGroup => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "node_resource_group");

    /// <summary>
    /// The node_resource_group_id attribute.
    /// </summary>
    [TerraformPropertyName("node_resource_group_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> NodeResourceGroupId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "node_resource_group_id");

    /// <summary>
    /// The oidc_issuer_enabled attribute.
    /// </summary>
    [TerraformPropertyName("oidc_issuer_enabled")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> OidcIssuerEnabled => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "oidc_issuer_enabled");

    /// <summary>
    /// The oidc_issuer_url attribute.
    /// </summary>
    [TerraformPropertyName("oidc_issuer_url")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> OidcIssuerUrl => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "oidc_issuer_url");

    /// <summary>
    /// The oms_agent attribute.
    /// </summary>
    [TerraformPropertyName("oms_agent")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> OmsAgent => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "oms_agent");

    /// <summary>
    /// The open_service_mesh_enabled attribute.
    /// </summary>
    [TerraformPropertyName("open_service_mesh_enabled")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> OpenServiceMeshEnabled => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "open_service_mesh_enabled");

    /// <summary>
    /// The private_cluster_enabled attribute.
    /// </summary>
    [TerraformPropertyName("private_cluster_enabled")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> PrivateClusterEnabled => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "private_cluster_enabled");

    /// <summary>
    /// The private_fqdn attribute.
    /// </summary>
    [TerraformPropertyName("private_fqdn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PrivateFqdn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "private_fqdn");

    /// <summary>
    /// The role_based_access_control_enabled attribute.
    /// </summary>
    [TerraformPropertyName("role_based_access_control_enabled")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> RoleBasedAccessControlEnabled => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "role_based_access_control_enabled");

    /// <summary>
    /// The service_mesh_profile attribute.
    /// </summary>
    [TerraformPropertyName("service_mesh_profile")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> ServiceMeshProfile => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "service_mesh_profile");

    /// <summary>
    /// The service_principal attribute.
    /// </summary>
    [TerraformPropertyName("service_principal")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> ServicePrincipal => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "service_principal");

    /// <summary>
    /// The storage_profile attribute.
    /// </summary>
    [TerraformPropertyName("storage_profile")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> StorageProfile => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "storage_profile");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Tags => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags");

    /// <summary>
    /// The windows_profile attribute.
    /// </summary>
    [TerraformPropertyName("windows_profile")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> WindowsProfile => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "windows_profile");

}
