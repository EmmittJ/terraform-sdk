using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermKubernetesClusterDataSource.
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
        get => GetArgument<TerraformValue<string>>("read");
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
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
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
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => GetRequiredArgument<TerraformValue<string>>("resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The aci_connector_linux attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> AciConnectorLinux
        => CreateReference("aci_connector_linux");

    /// <summary>
    /// The agent_pool_profile attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> AgentPoolProfile
        => CreateReference("agent_pool_profile");

    /// <summary>
    /// The api_server_authorized_ip_ranges attribute.
    /// </summary>
    public TerraformSet<string> ApiServerAuthorizedIpRanges
        => CreateReference("api_server_authorized_ip_ranges");

    /// <summary>
    /// The azure_active_directory_role_based_access_control attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> AzureActiveDirectoryRoleBasedAccessControl
        => CreateReference("azure_active_directory_role_based_access_control");

    /// <summary>
    /// The azure_policy_enabled attribute.
    /// </summary>
    public TerraformValue<bool> AzurePolicyEnabled
        => CreateReference("azure_policy_enabled");

    /// <summary>
    /// The current_kubernetes_version attribute.
    /// </summary>
    public TerraformValue<string> CurrentKubernetesVersion
        => CreateReference("current_kubernetes_version");

    /// <summary>
    /// The disk_encryption_set_id attribute.
    /// </summary>
    public TerraformValue<string> DiskEncryptionSetId
        => CreateReference("disk_encryption_set_id");

    /// <summary>
    /// The dns_prefix attribute.
    /// </summary>
    public TerraformValue<string> DnsPrefix
        => CreateReference("dns_prefix");

    /// <summary>
    /// The fqdn attribute.
    /// </summary>
    public TerraformValue<string> Fqdn
        => CreateReference("fqdn");

    /// <summary>
    /// The http_application_routing_enabled attribute.
    /// </summary>
    public TerraformValue<bool> HttpApplicationRoutingEnabled
        => CreateReference("http_application_routing_enabled");

    /// <summary>
    /// The http_application_routing_zone_name attribute.
    /// </summary>
    public TerraformValue<string> HttpApplicationRoutingZoneName
        => CreateReference("http_application_routing_zone_name");

    /// <summary>
    /// The identity attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Identity
        => CreateReference("identity");

    /// <summary>
    /// The ingress_application_gateway attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> IngressApplicationGateway
        => CreateReference("ingress_application_gateway");

    /// <summary>
    /// The key_management_service attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> KeyManagementService
        => CreateReference("key_management_service");

    /// <summary>
    /// The key_vault_secrets_provider attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> KeyVaultSecretsProvider
        => CreateReference("key_vault_secrets_provider");

    /// <summary>
    /// The kube_admin_config attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> KubeAdminConfig
        => CreateReference("kube_admin_config");

    /// <summary>
    /// The kube_admin_config_raw attribute.
    /// </summary>
    public TerraformValue<string> KubeAdminConfigRaw
        => CreateReference("kube_admin_config_raw");

    /// <summary>
    /// The kube_config attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> KubeConfig
        => CreateReference("kube_config");

    /// <summary>
    /// The kube_config_raw attribute.
    /// </summary>
    public TerraformValue<string> KubeConfigRaw
        => CreateReference("kube_config_raw");

    /// <summary>
    /// The kubelet_identity attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> KubeletIdentity
        => CreateReference("kubelet_identity");

    /// <summary>
    /// The kubernetes_version attribute.
    /// </summary>
    public TerraformValue<string> KubernetesVersion
        => CreateReference("kubernetes_version");

    /// <summary>
    /// The linux_profile attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> LinuxProfile
        => CreateReference("linux_profile");

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformValue<string> Location
        => CreateReference("location");

    /// <summary>
    /// The microsoft_defender attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> MicrosoftDefender
        => CreateReference("microsoft_defender");

    /// <summary>
    /// The network_profile attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> NetworkProfile
        => CreateReference("network_profile");

    /// <summary>
    /// The node_resource_group attribute.
    /// </summary>
    public TerraformValue<string> NodeResourceGroup
        => CreateReference("node_resource_group");

    /// <summary>
    /// The node_resource_group_id attribute.
    /// </summary>
    public TerraformValue<string> NodeResourceGroupId
        => CreateReference("node_resource_group_id");

    /// <summary>
    /// The oidc_issuer_enabled attribute.
    /// </summary>
    public TerraformValue<bool> OidcIssuerEnabled
        => CreateReference("oidc_issuer_enabled");

    /// <summary>
    /// The oidc_issuer_url attribute.
    /// </summary>
    public TerraformValue<string> OidcIssuerUrl
        => CreateReference("oidc_issuer_url");

    /// <summary>
    /// The oms_agent attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> OmsAgent
        => CreateReference("oms_agent");

    /// <summary>
    /// The open_service_mesh_enabled attribute.
    /// </summary>
    public TerraformValue<bool> OpenServiceMeshEnabled
        => CreateReference("open_service_mesh_enabled");

    /// <summary>
    /// The private_cluster_enabled attribute.
    /// </summary>
    public TerraformValue<bool> PrivateClusterEnabled
        => CreateReference("private_cluster_enabled");

    /// <summary>
    /// The private_fqdn attribute.
    /// </summary>
    public TerraformValue<string> PrivateFqdn
        => CreateReference("private_fqdn");

    /// <summary>
    /// The role_based_access_control_enabled attribute.
    /// </summary>
    public TerraformValue<bool> RoleBasedAccessControlEnabled
        => CreateReference("role_based_access_control_enabled");

    /// <summary>
    /// The service_mesh_profile attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> ServiceMeshProfile
        => CreateReference("service_mesh_profile");

    /// <summary>
    /// The service_principal attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> ServicePrincipal
        => CreateReference("service_principal");

    /// <summary>
    /// The storage_profile attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> StorageProfile
        => CreateReference("storage_profile");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
        => CreateReference("tags");

    /// <summary>
    /// The windows_profile attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> WindowsProfile
        => CreateReference("windows_profile");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermKubernetesClusterDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermKubernetesClusterDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
