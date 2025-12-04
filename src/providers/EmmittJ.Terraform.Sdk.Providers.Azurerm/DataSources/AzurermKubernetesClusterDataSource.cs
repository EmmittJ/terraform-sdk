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
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
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
        => AsReference("aci_connector_linux");

    /// <summary>
    /// The agent_pool_profile attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> AgentPoolProfile
        => AsReference("agent_pool_profile");

    /// <summary>
    /// The api_server_authorized_ip_ranges attribute.
    /// </summary>
    public TerraformSet<string> ApiServerAuthorizedIpRanges
        => AsReference("api_server_authorized_ip_ranges");

    /// <summary>
    /// The azure_active_directory_role_based_access_control attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> AzureActiveDirectoryRoleBasedAccessControl
        => AsReference("azure_active_directory_role_based_access_control");

    /// <summary>
    /// The azure_policy_enabled attribute.
    /// </summary>
    public TerraformValue<bool> AzurePolicyEnabled
        => AsReference("azure_policy_enabled");

    /// <summary>
    /// The current_kubernetes_version attribute.
    /// </summary>
    public TerraformValue<string> CurrentKubernetesVersion
        => AsReference("current_kubernetes_version");

    /// <summary>
    /// The disk_encryption_set_id attribute.
    /// </summary>
    public TerraformValue<string> DiskEncryptionSetId
        => AsReference("disk_encryption_set_id");

    /// <summary>
    /// The dns_prefix attribute.
    /// </summary>
    public TerraformValue<string> DnsPrefix
        => AsReference("dns_prefix");

    /// <summary>
    /// The fqdn attribute.
    /// </summary>
    public TerraformValue<string> Fqdn
        => AsReference("fqdn");

    /// <summary>
    /// The http_application_routing_enabled attribute.
    /// </summary>
    public TerraformValue<bool> HttpApplicationRoutingEnabled
        => AsReference("http_application_routing_enabled");

    /// <summary>
    /// The http_application_routing_zone_name attribute.
    /// </summary>
    public TerraformValue<string> HttpApplicationRoutingZoneName
        => AsReference("http_application_routing_zone_name");

    /// <summary>
    /// The identity attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Identity
        => AsReference("identity");

    /// <summary>
    /// The ingress_application_gateway attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> IngressApplicationGateway
        => AsReference("ingress_application_gateway");

    /// <summary>
    /// The key_management_service attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> KeyManagementService
        => AsReference("key_management_service");

    /// <summary>
    /// The key_vault_secrets_provider attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> KeyVaultSecretsProvider
        => AsReference("key_vault_secrets_provider");

    /// <summary>
    /// The kube_admin_config attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> KubeAdminConfig
        => AsReference("kube_admin_config");

    /// <summary>
    /// The kube_admin_config_raw attribute.
    /// </summary>
    public TerraformValue<string> KubeAdminConfigRaw
        => AsReference("kube_admin_config_raw");

    /// <summary>
    /// The kube_config attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> KubeConfig
        => AsReference("kube_config");

    /// <summary>
    /// The kube_config_raw attribute.
    /// </summary>
    public TerraformValue<string> KubeConfigRaw
        => AsReference("kube_config_raw");

    /// <summary>
    /// The kubelet_identity attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> KubeletIdentity
        => AsReference("kubelet_identity");

    /// <summary>
    /// The kubernetes_version attribute.
    /// </summary>
    public TerraformValue<string> KubernetesVersion
        => AsReference("kubernetes_version");

    /// <summary>
    /// The linux_profile attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> LinuxProfile
        => AsReference("linux_profile");

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformValue<string> Location
        => AsReference("location");

    /// <summary>
    /// The microsoft_defender attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> MicrosoftDefender
        => AsReference("microsoft_defender");

    /// <summary>
    /// The network_profile attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> NetworkProfile
        => AsReference("network_profile");

    /// <summary>
    /// The node_resource_group attribute.
    /// </summary>
    public TerraformValue<string> NodeResourceGroup
        => AsReference("node_resource_group");

    /// <summary>
    /// The node_resource_group_id attribute.
    /// </summary>
    public TerraformValue<string> NodeResourceGroupId
        => AsReference("node_resource_group_id");

    /// <summary>
    /// The oidc_issuer_enabled attribute.
    /// </summary>
    public TerraformValue<bool> OidcIssuerEnabled
        => AsReference("oidc_issuer_enabled");

    /// <summary>
    /// The oidc_issuer_url attribute.
    /// </summary>
    public TerraformValue<string> OidcIssuerUrl
        => AsReference("oidc_issuer_url");

    /// <summary>
    /// The oms_agent attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> OmsAgent
        => AsReference("oms_agent");

    /// <summary>
    /// The open_service_mesh_enabled attribute.
    /// </summary>
    public TerraformValue<bool> OpenServiceMeshEnabled
        => AsReference("open_service_mesh_enabled");

    /// <summary>
    /// The private_cluster_enabled attribute.
    /// </summary>
    public TerraformValue<bool> PrivateClusterEnabled
        => AsReference("private_cluster_enabled");

    /// <summary>
    /// The private_fqdn attribute.
    /// </summary>
    public TerraformValue<string> PrivateFqdn
        => AsReference("private_fqdn");

    /// <summary>
    /// The role_based_access_control_enabled attribute.
    /// </summary>
    public TerraformValue<bool> RoleBasedAccessControlEnabled
        => AsReference("role_based_access_control_enabled");

    /// <summary>
    /// The service_mesh_profile attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> ServiceMeshProfile
        => AsReference("service_mesh_profile");

    /// <summary>
    /// The service_principal attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> ServicePrincipal
        => AsReference("service_principal");

    /// <summary>
    /// The storage_profile attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> StorageProfile
        => AsReference("storage_profile");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
        => AsReference("tags");

    /// <summary>
    /// The windows_profile attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> WindowsProfile
        => AsReference("windows_profile");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermKubernetesClusterDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermKubernetesClusterDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
