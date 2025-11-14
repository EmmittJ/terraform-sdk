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
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermKubernetesClusterDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

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
    [TerraformArgument("id")]
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermKubernetesClusterDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The aci_connector_linux attribute.
    /// </summary>
    [TerraformArgument("aci_connector_linux")]
    public TerraformList<object> AciConnectorLinux
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "aci_connector_linux").ResolveNodes(ctx));
    }

    /// <summary>
    /// The agent_pool_profile attribute.
    /// </summary>
    [TerraformArgument("agent_pool_profile")]
    public TerraformList<object> AgentPoolProfile
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "agent_pool_profile").ResolveNodes(ctx));
    }

    /// <summary>
    /// The api_server_authorized_ip_ranges attribute.
    /// </summary>
    [TerraformArgument("api_server_authorized_ip_ranges")]
    public TerraformSet<string> ApiServerAuthorizedIpRanges
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "api_server_authorized_ip_ranges").ResolveNodes(ctx));
    }

    /// <summary>
    /// The azure_active_directory_role_based_access_control attribute.
    /// </summary>
    [TerraformArgument("azure_active_directory_role_based_access_control")]
    public TerraformList<object> AzureActiveDirectoryRoleBasedAccessControl
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "azure_active_directory_role_based_access_control").ResolveNodes(ctx));
    }

    /// <summary>
    /// The azure_policy_enabled attribute.
    /// </summary>
    [TerraformArgument("azure_policy_enabled")]
    public TerraformValue<bool> AzurePolicyEnabled
    {
        get => new TerraformReference<bool>(this, "azure_policy_enabled");
    }

    /// <summary>
    /// The current_kubernetes_version attribute.
    /// </summary>
    [TerraformArgument("current_kubernetes_version")]
    public TerraformValue<string> CurrentKubernetesVersion
    {
        get => new TerraformReference<string>(this, "current_kubernetes_version");
    }

    /// <summary>
    /// The disk_encryption_set_id attribute.
    /// </summary>
    [TerraformArgument("disk_encryption_set_id")]
    public TerraformValue<string> DiskEncryptionSetId
    {
        get => new TerraformReference<string>(this, "disk_encryption_set_id");
    }

    /// <summary>
    /// The dns_prefix attribute.
    /// </summary>
    [TerraformArgument("dns_prefix")]
    public TerraformValue<string> DnsPrefix
    {
        get => new TerraformReference<string>(this, "dns_prefix");
    }

    /// <summary>
    /// The fqdn attribute.
    /// </summary>
    [TerraformArgument("fqdn")]
    public TerraformValue<string> Fqdn
    {
        get => new TerraformReference<string>(this, "fqdn");
    }

    /// <summary>
    /// The http_application_routing_enabled attribute.
    /// </summary>
    [TerraformArgument("http_application_routing_enabled")]
    public TerraformValue<bool> HttpApplicationRoutingEnabled
    {
        get => new TerraformReference<bool>(this, "http_application_routing_enabled");
    }

    /// <summary>
    /// The http_application_routing_zone_name attribute.
    /// </summary>
    [TerraformArgument("http_application_routing_zone_name")]
    public TerraformValue<string> HttpApplicationRoutingZoneName
    {
        get => new TerraformReference<string>(this, "http_application_routing_zone_name");
    }

    /// <summary>
    /// The identity attribute.
    /// </summary>
    [TerraformArgument("identity")]
    public TerraformList<object> Identity
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "identity").ResolveNodes(ctx));
    }

    /// <summary>
    /// The ingress_application_gateway attribute.
    /// </summary>
    [TerraformArgument("ingress_application_gateway")]
    public TerraformList<object> IngressApplicationGateway
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "ingress_application_gateway").ResolveNodes(ctx));
    }

    /// <summary>
    /// The key_management_service attribute.
    /// </summary>
    [TerraformArgument("key_management_service")]
    public TerraformList<object> KeyManagementService
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "key_management_service").ResolveNodes(ctx));
    }

    /// <summary>
    /// The key_vault_secrets_provider attribute.
    /// </summary>
    [TerraformArgument("key_vault_secrets_provider")]
    public TerraformList<object> KeyVaultSecretsProvider
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "key_vault_secrets_provider").ResolveNodes(ctx));
    }

    /// <summary>
    /// The kube_admin_config attribute.
    /// </summary>
    [TerraformArgument("kube_admin_config")]
    public TerraformList<object> KubeAdminConfig
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "kube_admin_config").ResolveNodes(ctx));
    }

    /// <summary>
    /// The kube_admin_config_raw attribute.
    /// </summary>
    [TerraformArgument("kube_admin_config_raw")]
    public TerraformValue<string> KubeAdminConfigRaw
    {
        get => new TerraformReference<string>(this, "kube_admin_config_raw");
    }

    /// <summary>
    /// The kube_config attribute.
    /// </summary>
    [TerraformArgument("kube_config")]
    public TerraformList<object> KubeConfig
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "kube_config").ResolveNodes(ctx));
    }

    /// <summary>
    /// The kube_config_raw attribute.
    /// </summary>
    [TerraformArgument("kube_config_raw")]
    public TerraformValue<string> KubeConfigRaw
    {
        get => new TerraformReference<string>(this, "kube_config_raw");
    }

    /// <summary>
    /// The kubelet_identity attribute.
    /// </summary>
    [TerraformArgument("kubelet_identity")]
    public TerraformList<object> KubeletIdentity
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "kubelet_identity").ResolveNodes(ctx));
    }

    /// <summary>
    /// The kubernetes_version attribute.
    /// </summary>
    [TerraformArgument("kubernetes_version")]
    public TerraformValue<string> KubernetesVersion
    {
        get => new TerraformReference<string>(this, "kubernetes_version");
    }

    /// <summary>
    /// The linux_profile attribute.
    /// </summary>
    [TerraformArgument("linux_profile")]
    public TerraformList<object> LinuxProfile
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "linux_profile").ResolveNodes(ctx));
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformArgument("location")]
    public TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
    }

    /// <summary>
    /// The microsoft_defender attribute.
    /// </summary>
    [TerraformArgument("microsoft_defender")]
    public TerraformList<object> MicrosoftDefender
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "microsoft_defender").ResolveNodes(ctx));
    }

    /// <summary>
    /// The network_profile attribute.
    /// </summary>
    [TerraformArgument("network_profile")]
    public TerraformList<object> NetworkProfile
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "network_profile").ResolveNodes(ctx));
    }

    /// <summary>
    /// The node_resource_group attribute.
    /// </summary>
    [TerraformArgument("node_resource_group")]
    public TerraformValue<string> NodeResourceGroup
    {
        get => new TerraformReference<string>(this, "node_resource_group");
    }

    /// <summary>
    /// The node_resource_group_id attribute.
    /// </summary>
    [TerraformArgument("node_resource_group_id")]
    public TerraformValue<string> NodeResourceGroupId
    {
        get => new TerraformReference<string>(this, "node_resource_group_id");
    }

    /// <summary>
    /// The oidc_issuer_enabled attribute.
    /// </summary>
    [TerraformArgument("oidc_issuer_enabled")]
    public TerraformValue<bool> OidcIssuerEnabled
    {
        get => new TerraformReference<bool>(this, "oidc_issuer_enabled");
    }

    /// <summary>
    /// The oidc_issuer_url attribute.
    /// </summary>
    [TerraformArgument("oidc_issuer_url")]
    public TerraformValue<string> OidcIssuerUrl
    {
        get => new TerraformReference<string>(this, "oidc_issuer_url");
    }

    /// <summary>
    /// The oms_agent attribute.
    /// </summary>
    [TerraformArgument("oms_agent")]
    public TerraformList<object> OmsAgent
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "oms_agent").ResolveNodes(ctx));
    }

    /// <summary>
    /// The open_service_mesh_enabled attribute.
    /// </summary>
    [TerraformArgument("open_service_mesh_enabled")]
    public TerraformValue<bool> OpenServiceMeshEnabled
    {
        get => new TerraformReference<bool>(this, "open_service_mesh_enabled");
    }

    /// <summary>
    /// The private_cluster_enabled attribute.
    /// </summary>
    [TerraformArgument("private_cluster_enabled")]
    public TerraformValue<bool> PrivateClusterEnabled
    {
        get => new TerraformReference<bool>(this, "private_cluster_enabled");
    }

    /// <summary>
    /// The private_fqdn attribute.
    /// </summary>
    [TerraformArgument("private_fqdn")]
    public TerraformValue<string> PrivateFqdn
    {
        get => new TerraformReference<string>(this, "private_fqdn");
    }

    /// <summary>
    /// The role_based_access_control_enabled attribute.
    /// </summary>
    [TerraformArgument("role_based_access_control_enabled")]
    public TerraformValue<bool> RoleBasedAccessControlEnabled
    {
        get => new TerraformReference<bool>(this, "role_based_access_control_enabled");
    }

    /// <summary>
    /// The service_mesh_profile attribute.
    /// </summary>
    [TerraformArgument("service_mesh_profile")]
    public TerraformList<object> ServiceMeshProfile
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "service_mesh_profile").ResolveNodes(ctx));
    }

    /// <summary>
    /// The service_principal attribute.
    /// </summary>
    [TerraformArgument("service_principal")]
    public TerraformList<object> ServicePrincipal
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "service_principal").ResolveNodes(ctx));
    }

    /// <summary>
    /// The storage_profile attribute.
    /// </summary>
    [TerraformArgument("storage_profile")]
    public TerraformList<object> StorageProfile
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "storage_profile").ResolveNodes(ctx));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformArgument("tags")]
    public TerraformMap<string> Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
    }

    /// <summary>
    /// The windows_profile attribute.
    /// </summary>
    [TerraformArgument("windows_profile")]
    public TerraformList<object> WindowsProfile
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "windows_profile").ResolveNodes(ctx));
    }

}
