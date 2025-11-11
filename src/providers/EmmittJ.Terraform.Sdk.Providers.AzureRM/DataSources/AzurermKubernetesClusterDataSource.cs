using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermKubernetesClusterDataSourceTimeoutsBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

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
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermKubernetesClusterDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The aci_connector_linux attribute.
    /// </summary>
    [TerraformPropertyName("aci_connector_linux")]
    // Output-only attribute - read-only reference
    public TerraformList<object> AciConnectorLinux => new TerraformReference(this, "aci_connector_linux");

    /// <summary>
    /// The agent_pool_profile attribute.
    /// </summary>
    [TerraformPropertyName("agent_pool_profile")]
    // Output-only attribute - read-only reference
    public TerraformList<object> AgentPoolProfile => new TerraformReference(this, "agent_pool_profile");

    /// <summary>
    /// The api_server_authorized_ip_ranges attribute.
    /// </summary>
    [TerraformPropertyName("api_server_authorized_ip_ranges")]
    // Output-only attribute - read-only reference
    public TerraformSet<string> ApiServerAuthorizedIpRanges => new TerraformReference(this, "api_server_authorized_ip_ranges");

    /// <summary>
    /// The azure_active_directory_role_based_access_control attribute.
    /// </summary>
    [TerraformPropertyName("azure_active_directory_role_based_access_control")]
    // Output-only attribute - read-only reference
    public TerraformList<object> AzureActiveDirectoryRoleBasedAccessControl => new TerraformReference(this, "azure_active_directory_role_based_access_control");

    /// <summary>
    /// The azure_policy_enabled attribute.
    /// </summary>
    [TerraformPropertyName("azure_policy_enabled")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> AzurePolicyEnabled => new TerraformReference(this, "azure_policy_enabled");

    /// <summary>
    /// The current_kubernetes_version attribute.
    /// </summary>
    [TerraformPropertyName("current_kubernetes_version")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CurrentKubernetesVersion => new TerraformReference(this, "current_kubernetes_version");

    /// <summary>
    /// The disk_encryption_set_id attribute.
    /// </summary>
    [TerraformPropertyName("disk_encryption_set_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DiskEncryptionSetId => new TerraformReference(this, "disk_encryption_set_id");

    /// <summary>
    /// The dns_prefix attribute.
    /// </summary>
    [TerraformPropertyName("dns_prefix")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DnsPrefix => new TerraformReference(this, "dns_prefix");

    /// <summary>
    /// The fqdn attribute.
    /// </summary>
    [TerraformPropertyName("fqdn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Fqdn => new TerraformReference(this, "fqdn");

    /// <summary>
    /// The http_application_routing_enabled attribute.
    /// </summary>
    [TerraformPropertyName("http_application_routing_enabled")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> HttpApplicationRoutingEnabled => new TerraformReference(this, "http_application_routing_enabled");

    /// <summary>
    /// The http_application_routing_zone_name attribute.
    /// </summary>
    [TerraformPropertyName("http_application_routing_zone_name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> HttpApplicationRoutingZoneName => new TerraformReference(this, "http_application_routing_zone_name");

    /// <summary>
    /// The identity attribute.
    /// </summary>
    [TerraformPropertyName("identity")]
    // Output-only attribute - read-only reference
    public TerraformList<object> Identity => new TerraformReference(this, "identity");

    /// <summary>
    /// The ingress_application_gateway attribute.
    /// </summary>
    [TerraformPropertyName("ingress_application_gateway")]
    // Output-only attribute - read-only reference
    public TerraformList<object> IngressApplicationGateway => new TerraformReference(this, "ingress_application_gateway");

    /// <summary>
    /// The key_management_service attribute.
    /// </summary>
    [TerraformPropertyName("key_management_service")]
    // Output-only attribute - read-only reference
    public TerraformList<object> KeyManagementService => new TerraformReference(this, "key_management_service");

    /// <summary>
    /// The key_vault_secrets_provider attribute.
    /// </summary>
    [TerraformPropertyName("key_vault_secrets_provider")]
    // Output-only attribute - read-only reference
    public TerraformList<object> KeyVaultSecretsProvider => new TerraformReference(this, "key_vault_secrets_provider");

    /// <summary>
    /// The kube_admin_config attribute.
    /// </summary>
    [TerraformPropertyName("kube_admin_config")]
    // Output-only attribute - read-only reference
    public TerraformList<object> KubeAdminConfig => new TerraformReference(this, "kube_admin_config");

    /// <summary>
    /// The kube_admin_config_raw attribute.
    /// </summary>
    [TerraformPropertyName("kube_admin_config_raw")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> KubeAdminConfigRaw => new TerraformReference(this, "kube_admin_config_raw");

    /// <summary>
    /// The kube_config attribute.
    /// </summary>
    [TerraformPropertyName("kube_config")]
    // Output-only attribute - read-only reference
    public TerraformList<object> KubeConfig => new TerraformReference(this, "kube_config");

    /// <summary>
    /// The kube_config_raw attribute.
    /// </summary>
    [TerraformPropertyName("kube_config_raw")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> KubeConfigRaw => new TerraformReference(this, "kube_config_raw");

    /// <summary>
    /// The kubelet_identity attribute.
    /// </summary>
    [TerraformPropertyName("kubelet_identity")]
    // Output-only attribute - read-only reference
    public TerraformList<object> KubeletIdentity => new TerraformReference(this, "kubelet_identity");

    /// <summary>
    /// The kubernetes_version attribute.
    /// </summary>
    [TerraformPropertyName("kubernetes_version")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> KubernetesVersion => new TerraformReference(this, "kubernetes_version");

    /// <summary>
    /// The linux_profile attribute.
    /// </summary>
    [TerraformPropertyName("linux_profile")]
    // Output-only attribute - read-only reference
    public TerraformList<object> LinuxProfile => new TerraformReference(this, "linux_profile");

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformPropertyName("location")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Location => new TerraformReference(this, "location");

    /// <summary>
    /// The microsoft_defender attribute.
    /// </summary>
    [TerraformPropertyName("microsoft_defender")]
    // Output-only attribute - read-only reference
    public TerraformList<object> MicrosoftDefender => new TerraformReference(this, "microsoft_defender");

    /// <summary>
    /// The network_profile attribute.
    /// </summary>
    [TerraformPropertyName("network_profile")]
    // Output-only attribute - read-only reference
    public TerraformList<object> NetworkProfile => new TerraformReference(this, "network_profile");

    /// <summary>
    /// The node_resource_group attribute.
    /// </summary>
    [TerraformPropertyName("node_resource_group")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> NodeResourceGroup => new TerraformReference(this, "node_resource_group");

    /// <summary>
    /// The node_resource_group_id attribute.
    /// </summary>
    [TerraformPropertyName("node_resource_group_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> NodeResourceGroupId => new TerraformReference(this, "node_resource_group_id");

    /// <summary>
    /// The oidc_issuer_enabled attribute.
    /// </summary>
    [TerraformPropertyName("oidc_issuer_enabled")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> OidcIssuerEnabled => new TerraformReference(this, "oidc_issuer_enabled");

    /// <summary>
    /// The oidc_issuer_url attribute.
    /// </summary>
    [TerraformPropertyName("oidc_issuer_url")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> OidcIssuerUrl => new TerraformReference(this, "oidc_issuer_url");

    /// <summary>
    /// The oms_agent attribute.
    /// </summary>
    [TerraformPropertyName("oms_agent")]
    // Output-only attribute - read-only reference
    public TerraformList<object> OmsAgent => new TerraformReference(this, "oms_agent");

    /// <summary>
    /// The open_service_mesh_enabled attribute.
    /// </summary>
    [TerraformPropertyName("open_service_mesh_enabled")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> OpenServiceMeshEnabled => new TerraformReference(this, "open_service_mesh_enabled");

    /// <summary>
    /// The private_cluster_enabled attribute.
    /// </summary>
    [TerraformPropertyName("private_cluster_enabled")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> PrivateClusterEnabled => new TerraformReference(this, "private_cluster_enabled");

    /// <summary>
    /// The private_fqdn attribute.
    /// </summary>
    [TerraformPropertyName("private_fqdn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PrivateFqdn => new TerraformReference(this, "private_fqdn");

    /// <summary>
    /// The role_based_access_control_enabled attribute.
    /// </summary>
    [TerraformPropertyName("role_based_access_control_enabled")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> RoleBasedAccessControlEnabled => new TerraformReference(this, "role_based_access_control_enabled");

    /// <summary>
    /// The service_mesh_profile attribute.
    /// </summary>
    [TerraformPropertyName("service_mesh_profile")]
    // Output-only attribute - read-only reference
    public TerraformList<object> ServiceMeshProfile => new TerraformReference(this, "service_mesh_profile");

    /// <summary>
    /// The service_principal attribute.
    /// </summary>
    [TerraformPropertyName("service_principal")]
    // Output-only attribute - read-only reference
    public TerraformList<object> ServicePrincipal => new TerraformReference(this, "service_principal");

    /// <summary>
    /// The storage_profile attribute.
    /// </summary>
    [TerraformPropertyName("storage_profile")]
    // Output-only attribute - read-only reference
    public TerraformList<object> StorageProfile => new TerraformReference(this, "storage_profile");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> Tags => new TerraformReference(this, "tags");

    /// <summary>
    /// The windows_profile attribute.
    /// </summary>
    [TerraformPropertyName("windows_profile")]
    // Output-only attribute - read-only reference
    public TerraformList<object> WindowsProfile => new TerraformReference(this, "windows_profile");

}
