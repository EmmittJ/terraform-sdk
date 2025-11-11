using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermKubernetesClusterDataSourceTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_kubernetes_cluster.
/// </summary>
public partial class AzurermKubernetesClusterDataSource : TerraformDataSource
{
    public AzurermKubernetesClusterDataSource(string name) : base("azurerm_kubernetes_cluster", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzurermKubernetesClusterDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The aci_connector_linux attribute.
    /// </summary>
    [TerraformProperty("aci_connector_linux")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> AciConnectorLinux { get; }

    /// <summary>
    /// The agent_pool_profile attribute.
    /// </summary>
    [TerraformProperty("agent_pool_profile")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> AgentPoolProfile { get; }

    /// <summary>
    /// The api_server_authorized_ip_ranges attribute.
    /// </summary>
    [TerraformProperty("api_server_authorized_ip_ranges")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformSet<string> ApiServerAuthorizedIpRanges { get; }

    /// <summary>
    /// The azure_active_directory_role_based_access_control attribute.
    /// </summary>
    [TerraformProperty("azure_active_directory_role_based_access_control")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> AzureActiveDirectoryRoleBasedAccessControl { get; }

    /// <summary>
    /// The azure_policy_enabled attribute.
    /// </summary>
    [TerraformProperty("azure_policy_enabled")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> AzurePolicyEnabled { get; }

    /// <summary>
    /// The current_kubernetes_version attribute.
    /// </summary>
    [TerraformProperty("current_kubernetes_version")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> CurrentKubernetesVersion { get; }

    /// <summary>
    /// The disk_encryption_set_id attribute.
    /// </summary>
    [TerraformProperty("disk_encryption_set_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> DiskEncryptionSetId { get; }

    /// <summary>
    /// The dns_prefix attribute.
    /// </summary>
    [TerraformProperty("dns_prefix")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> DnsPrefix { get; }

    /// <summary>
    /// The fqdn attribute.
    /// </summary>
    [TerraformProperty("fqdn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Fqdn { get; }

    /// <summary>
    /// The http_application_routing_enabled attribute.
    /// </summary>
    [TerraformProperty("http_application_routing_enabled")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> HttpApplicationRoutingEnabled { get; }

    /// <summary>
    /// The http_application_routing_zone_name attribute.
    /// </summary>
    [TerraformProperty("http_application_routing_zone_name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> HttpApplicationRoutingZoneName { get; }

    /// <summary>
    /// The identity attribute.
    /// </summary>
    [TerraformProperty("identity")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> Identity { get; }

    /// <summary>
    /// The ingress_application_gateway attribute.
    /// </summary>
    [TerraformProperty("ingress_application_gateway")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> IngressApplicationGateway { get; }

    /// <summary>
    /// The key_management_service attribute.
    /// </summary>
    [TerraformProperty("key_management_service")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> KeyManagementService { get; }

    /// <summary>
    /// The key_vault_secrets_provider attribute.
    /// </summary>
    [TerraformProperty("key_vault_secrets_provider")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> KeyVaultSecretsProvider { get; }

    /// <summary>
    /// The kube_admin_config attribute.
    /// </summary>
    [TerraformProperty("kube_admin_config")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> KubeAdminConfig { get; }

    /// <summary>
    /// The kube_admin_config_raw attribute.
    /// </summary>
    [TerraformProperty("kube_admin_config_raw")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> KubeAdminConfigRaw { get; }

    /// <summary>
    /// The kube_config attribute.
    /// </summary>
    [TerraformProperty("kube_config")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> KubeConfig { get; }

    /// <summary>
    /// The kube_config_raw attribute.
    /// </summary>
    [TerraformProperty("kube_config_raw")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> KubeConfigRaw { get; }

    /// <summary>
    /// The kubelet_identity attribute.
    /// </summary>
    [TerraformProperty("kubelet_identity")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> KubeletIdentity { get; }

    /// <summary>
    /// The kubernetes_version attribute.
    /// </summary>
    [TerraformProperty("kubernetes_version")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> KubernetesVersion { get; }

    /// <summary>
    /// The linux_profile attribute.
    /// </summary>
    [TerraformProperty("linux_profile")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> LinuxProfile { get; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformProperty("location")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Location { get; }

    /// <summary>
    /// The microsoft_defender attribute.
    /// </summary>
    [TerraformProperty("microsoft_defender")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> MicrosoftDefender { get; }

    /// <summary>
    /// The network_profile attribute.
    /// </summary>
    [TerraformProperty("network_profile")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> NetworkProfile { get; }

    /// <summary>
    /// The node_resource_group attribute.
    /// </summary>
    [TerraformProperty("node_resource_group")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> NodeResourceGroup { get; }

    /// <summary>
    /// The node_resource_group_id attribute.
    /// </summary>
    [TerraformProperty("node_resource_group_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> NodeResourceGroupId { get; }

    /// <summary>
    /// The oidc_issuer_enabled attribute.
    /// </summary>
    [TerraformProperty("oidc_issuer_enabled")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> OidcIssuerEnabled { get; }

    /// <summary>
    /// The oidc_issuer_url attribute.
    /// </summary>
    [TerraformProperty("oidc_issuer_url")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> OidcIssuerUrl { get; }

    /// <summary>
    /// The oms_agent attribute.
    /// </summary>
    [TerraformProperty("oms_agent")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> OmsAgent { get; }

    /// <summary>
    /// The open_service_mesh_enabled attribute.
    /// </summary>
    [TerraformProperty("open_service_mesh_enabled")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> OpenServiceMeshEnabled { get; }

    /// <summary>
    /// The private_cluster_enabled attribute.
    /// </summary>
    [TerraformProperty("private_cluster_enabled")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> PrivateClusterEnabled { get; }

    /// <summary>
    /// The private_fqdn attribute.
    /// </summary>
    [TerraformProperty("private_fqdn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> PrivateFqdn { get; }

    /// <summary>
    /// The role_based_access_control_enabled attribute.
    /// </summary>
    [TerraformProperty("role_based_access_control_enabled")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> RoleBasedAccessControlEnabled { get; }

    /// <summary>
    /// The service_mesh_profile attribute.
    /// </summary>
    [TerraformProperty("service_mesh_profile")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> ServiceMeshProfile { get; }

    /// <summary>
    /// The service_principal attribute.
    /// </summary>
    [TerraformProperty("service_principal")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> ServicePrincipal { get; }

    /// <summary>
    /// The storage_profile attribute.
    /// </summary>
    [TerraformProperty("storage_profile")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> StorageProfile { get; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformMap<string> Tags { get; }

    /// <summary>
    /// The windows_profile attribute.
    /// </summary>
    [TerraformProperty("windows_profile")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> WindowsProfile { get; }

}
