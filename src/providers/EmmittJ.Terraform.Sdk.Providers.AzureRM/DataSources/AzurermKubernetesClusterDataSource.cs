using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

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
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

}

/// <summary>
/// Represents a azurerm_kubernetes_cluster Terraform data source.
/// Retrieves information about a azurerm_kubernetes_cluster.
/// </summary>
public partial class AzurermKubernetesClusterDataSource(string name) : TerraformDataSource("azurerm_kubernetes_cluster", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
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
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The aci_connector_linux attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> AciConnectorLinux
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "aci_connector_linux").ResolveNodes(ctx));
    }

    /// <summary>
    /// The agent_pool_profile attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> AgentPoolProfile
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "agent_pool_profile").ResolveNodes(ctx));
    }

    /// <summary>
    /// The api_server_authorized_ip_ranges attribute.
    /// </summary>
    public TerraformSet<string> ApiServerAuthorizedIpRanges
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "api_server_authorized_ip_ranges").ResolveNodes(ctx));
    }

    /// <summary>
    /// The azure_active_directory_role_based_access_control attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> AzureActiveDirectoryRoleBasedAccessControl
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "azure_active_directory_role_based_access_control").ResolveNodes(ctx));
    }

    /// <summary>
    /// The azure_policy_enabled attribute.
    /// </summary>
    public TerraformValue<bool> AzurePolicyEnabled
    {
        get => new TerraformReference<bool>(this, "azure_policy_enabled");
    }

    /// <summary>
    /// The current_kubernetes_version attribute.
    /// </summary>
    public TerraformValue<string> CurrentKubernetesVersion
    {
        get => new TerraformReference<string>(this, "current_kubernetes_version");
    }

    /// <summary>
    /// The disk_encryption_set_id attribute.
    /// </summary>
    public TerraformValue<string> DiskEncryptionSetId
    {
        get => new TerraformReference<string>(this, "disk_encryption_set_id");
    }

    /// <summary>
    /// The dns_prefix attribute.
    /// </summary>
    public TerraformValue<string> DnsPrefix
    {
        get => new TerraformReference<string>(this, "dns_prefix");
    }

    /// <summary>
    /// The fqdn attribute.
    /// </summary>
    public TerraformValue<string> Fqdn
    {
        get => new TerraformReference<string>(this, "fqdn");
    }

    /// <summary>
    /// The http_application_routing_enabled attribute.
    /// </summary>
    public TerraformValue<bool> HttpApplicationRoutingEnabled
    {
        get => new TerraformReference<bool>(this, "http_application_routing_enabled");
    }

    /// <summary>
    /// The http_application_routing_zone_name attribute.
    /// </summary>
    public TerraformValue<string> HttpApplicationRoutingZoneName
    {
        get => new TerraformReference<string>(this, "http_application_routing_zone_name");
    }

    /// <summary>
    /// The identity attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Identity
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "identity").ResolveNodes(ctx));
    }

    /// <summary>
    /// The ingress_application_gateway attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> IngressApplicationGateway
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "ingress_application_gateway").ResolveNodes(ctx));
    }

    /// <summary>
    /// The key_management_service attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> KeyManagementService
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "key_management_service").ResolveNodes(ctx));
    }

    /// <summary>
    /// The key_vault_secrets_provider attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> KeyVaultSecretsProvider
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "key_vault_secrets_provider").ResolveNodes(ctx));
    }

    /// <summary>
    /// The kube_admin_config attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> KubeAdminConfig
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "kube_admin_config").ResolveNodes(ctx));
    }

    /// <summary>
    /// The kube_admin_config_raw attribute.
    /// </summary>
    public TerraformValue<string> KubeAdminConfigRaw
    {
        get => new TerraformReference<string>(this, "kube_admin_config_raw");
    }

    /// <summary>
    /// The kube_config attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> KubeConfig
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "kube_config").ResolveNodes(ctx));
    }

    /// <summary>
    /// The kube_config_raw attribute.
    /// </summary>
    public TerraformValue<string> KubeConfigRaw
    {
        get => new TerraformReference<string>(this, "kube_config_raw");
    }

    /// <summary>
    /// The kubelet_identity attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> KubeletIdentity
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "kubelet_identity").ResolveNodes(ctx));
    }

    /// <summary>
    /// The kubernetes_version attribute.
    /// </summary>
    public TerraformValue<string> KubernetesVersion
    {
        get => new TerraformReference<string>(this, "kubernetes_version");
    }

    /// <summary>
    /// The linux_profile attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> LinuxProfile
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "linux_profile").ResolveNodes(ctx));
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
    }

    /// <summary>
    /// The microsoft_defender attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> MicrosoftDefender
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "microsoft_defender").ResolveNodes(ctx));
    }

    /// <summary>
    /// The network_profile attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> NetworkProfile
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "network_profile").ResolveNodes(ctx));
    }

    /// <summary>
    /// The node_resource_group attribute.
    /// </summary>
    public TerraformValue<string> NodeResourceGroup
    {
        get => new TerraformReference<string>(this, "node_resource_group");
    }

    /// <summary>
    /// The node_resource_group_id attribute.
    /// </summary>
    public TerraformValue<string> NodeResourceGroupId
    {
        get => new TerraformReference<string>(this, "node_resource_group_id");
    }

    /// <summary>
    /// The oidc_issuer_enabled attribute.
    /// </summary>
    public TerraformValue<bool> OidcIssuerEnabled
    {
        get => new TerraformReference<bool>(this, "oidc_issuer_enabled");
    }

    /// <summary>
    /// The oidc_issuer_url attribute.
    /// </summary>
    public TerraformValue<string> OidcIssuerUrl
    {
        get => new TerraformReference<string>(this, "oidc_issuer_url");
    }

    /// <summary>
    /// The oms_agent attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> OmsAgent
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "oms_agent").ResolveNodes(ctx));
    }

    /// <summary>
    /// The open_service_mesh_enabled attribute.
    /// </summary>
    public TerraformValue<bool> OpenServiceMeshEnabled
    {
        get => new TerraformReference<bool>(this, "open_service_mesh_enabled");
    }

    /// <summary>
    /// The private_cluster_enabled attribute.
    /// </summary>
    public TerraformValue<bool> PrivateClusterEnabled
    {
        get => new TerraformReference<bool>(this, "private_cluster_enabled");
    }

    /// <summary>
    /// The private_fqdn attribute.
    /// </summary>
    public TerraformValue<string> PrivateFqdn
    {
        get => new TerraformReference<string>(this, "private_fqdn");
    }

    /// <summary>
    /// The role_based_access_control_enabled attribute.
    /// </summary>
    public TerraformValue<bool> RoleBasedAccessControlEnabled
    {
        get => new TerraformReference<bool>(this, "role_based_access_control_enabled");
    }

    /// <summary>
    /// The service_mesh_profile attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> ServiceMeshProfile
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "service_mesh_profile").ResolveNodes(ctx));
    }

    /// <summary>
    /// The service_principal attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> ServicePrincipal
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "service_principal").ResolveNodes(ctx));
    }

    /// <summary>
    /// The storage_profile attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> StorageProfile
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "storage_profile").ResolveNodes(ctx));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
    }

    /// <summary>
    /// The windows_profile attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> WindowsProfile
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "windows_profile").ResolveNodes(ctx));
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermKubernetesClusterDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermKubernetesClusterDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
