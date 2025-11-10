using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermKubernetesClusterDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

}

/// <summary>
/// Retrieves information about a azurerm_kubernetes_cluster.
/// </summary>
public class AzurermKubernetesClusterDataSource : TerraformDataSource
{
    public AzurermKubernetesClusterDataSource(string name) : base("azurerm_kubernetes_cluster", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("aci_connector_linux");
        this.DeclareOutput("agent_pool_profile");
        this.DeclareOutput("api_server_authorized_ip_ranges");
        this.DeclareOutput("azure_active_directory_role_based_access_control");
        this.DeclareOutput("azure_policy_enabled");
        this.DeclareOutput("current_kubernetes_version");
        this.DeclareOutput("disk_encryption_set_id");
        this.DeclareOutput("dns_prefix");
        this.DeclareOutput("fqdn");
        this.DeclareOutput("http_application_routing_enabled");
        this.DeclareOutput("http_application_routing_zone_name");
        this.DeclareOutput("identity");
        this.DeclareOutput("ingress_application_gateway");
        this.DeclareOutput("key_management_service");
        this.DeclareOutput("key_vault_secrets_provider");
        this.DeclareOutput("kube_admin_config");
        this.DeclareOutput("kube_admin_config_raw");
        this.DeclareOutput("kube_config");
        this.DeclareOutput("kube_config_raw");
        this.DeclareOutput("kubelet_identity");
        this.DeclareOutput("kubernetes_version");
        this.DeclareOutput("linux_profile");
        this.DeclareOutput("location");
        this.DeclareOutput("microsoft_defender");
        this.DeclareOutput("network_profile");
        this.DeclareOutput("node_resource_group");
        this.DeclareOutput("node_resource_group_id");
        this.DeclareOutput("oidc_issuer_enabled");
        this.DeclareOutput("oidc_issuer_url");
        this.DeclareOutput("oms_agent");
        this.DeclareOutput("open_service_mesh_enabled");
        this.DeclareOutput("private_cluster_enabled");
        this.DeclareOutput("private_fqdn");
        this.DeclareOutput("role_based_access_control_enabled");
        this.DeclareOutput("service_mesh_profile");
        this.DeclareOutput("service_principal");
        this.DeclareOutput("storage_profile");
        this.DeclareOutput("tags");
        this.DeclareOutput("windows_profile");
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermKubernetesClusterDataSourceTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermKubernetesClusterDataSourceTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The aci_connector_linux attribute.
    /// </summary>
    public TerraformExpression AciConnectorLinux => this["aci_connector_linux"];

    /// <summary>
    /// The agent_pool_profile attribute.
    /// </summary>
    public TerraformExpression AgentPoolProfile => this["agent_pool_profile"];

    /// <summary>
    /// The api_server_authorized_ip_ranges attribute.
    /// </summary>
    public TerraformExpression ApiServerAuthorizedIpRanges => this["api_server_authorized_ip_ranges"];

    /// <summary>
    /// The azure_active_directory_role_based_access_control attribute.
    /// </summary>
    public TerraformExpression AzureActiveDirectoryRoleBasedAccessControl => this["azure_active_directory_role_based_access_control"];

    /// <summary>
    /// The azure_policy_enabled attribute.
    /// </summary>
    public TerraformExpression AzurePolicyEnabled => this["azure_policy_enabled"];

    /// <summary>
    /// The current_kubernetes_version attribute.
    /// </summary>
    public TerraformExpression CurrentKubernetesVersion => this["current_kubernetes_version"];

    /// <summary>
    /// The disk_encryption_set_id attribute.
    /// </summary>
    public TerraformExpression DiskEncryptionSetId => this["disk_encryption_set_id"];

    /// <summary>
    /// The dns_prefix attribute.
    /// </summary>
    public TerraformExpression DnsPrefix => this["dns_prefix"];

    /// <summary>
    /// The fqdn attribute.
    /// </summary>
    public TerraformExpression Fqdn => this["fqdn"];

    /// <summary>
    /// The http_application_routing_enabled attribute.
    /// </summary>
    public TerraformExpression HttpApplicationRoutingEnabled => this["http_application_routing_enabled"];

    /// <summary>
    /// The http_application_routing_zone_name attribute.
    /// </summary>
    public TerraformExpression HttpApplicationRoutingZoneName => this["http_application_routing_zone_name"];

    /// <summary>
    /// The identity attribute.
    /// </summary>
    public TerraformExpression Identity => this["identity"];

    /// <summary>
    /// The ingress_application_gateway attribute.
    /// </summary>
    public TerraformExpression IngressApplicationGateway => this["ingress_application_gateway"];

    /// <summary>
    /// The key_management_service attribute.
    /// </summary>
    public TerraformExpression KeyManagementService => this["key_management_service"];

    /// <summary>
    /// The key_vault_secrets_provider attribute.
    /// </summary>
    public TerraformExpression KeyVaultSecretsProvider => this["key_vault_secrets_provider"];

    /// <summary>
    /// The kube_admin_config attribute.
    /// </summary>
    public TerraformExpression KubeAdminConfig => this["kube_admin_config"];

    /// <summary>
    /// The kube_admin_config_raw attribute.
    /// </summary>
    public TerraformExpression KubeAdminConfigRaw => this["kube_admin_config_raw"];

    /// <summary>
    /// The kube_config attribute.
    /// </summary>
    public TerraformExpression KubeConfig => this["kube_config"];

    /// <summary>
    /// The kube_config_raw attribute.
    /// </summary>
    public TerraformExpression KubeConfigRaw => this["kube_config_raw"];

    /// <summary>
    /// The kubelet_identity attribute.
    /// </summary>
    public TerraformExpression KubeletIdentity => this["kubelet_identity"];

    /// <summary>
    /// The kubernetes_version attribute.
    /// </summary>
    public TerraformExpression KubernetesVersion => this["kubernetes_version"];

    /// <summary>
    /// The linux_profile attribute.
    /// </summary>
    public TerraformExpression LinuxProfile => this["linux_profile"];

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformExpression Location => this["location"];

    /// <summary>
    /// The microsoft_defender attribute.
    /// </summary>
    public TerraformExpression MicrosoftDefender => this["microsoft_defender"];

    /// <summary>
    /// The network_profile attribute.
    /// </summary>
    public TerraformExpression NetworkProfile => this["network_profile"];

    /// <summary>
    /// The node_resource_group attribute.
    /// </summary>
    public TerraformExpression NodeResourceGroup => this["node_resource_group"];

    /// <summary>
    /// The node_resource_group_id attribute.
    /// </summary>
    public TerraformExpression NodeResourceGroupId => this["node_resource_group_id"];

    /// <summary>
    /// The oidc_issuer_enabled attribute.
    /// </summary>
    public TerraformExpression OidcIssuerEnabled => this["oidc_issuer_enabled"];

    /// <summary>
    /// The oidc_issuer_url attribute.
    /// </summary>
    public TerraformExpression OidcIssuerUrl => this["oidc_issuer_url"];

    /// <summary>
    /// The oms_agent attribute.
    /// </summary>
    public TerraformExpression OmsAgent => this["oms_agent"];

    /// <summary>
    /// The open_service_mesh_enabled attribute.
    /// </summary>
    public TerraformExpression OpenServiceMeshEnabled => this["open_service_mesh_enabled"];

    /// <summary>
    /// The private_cluster_enabled attribute.
    /// </summary>
    public TerraformExpression PrivateClusterEnabled => this["private_cluster_enabled"];

    /// <summary>
    /// The private_fqdn attribute.
    /// </summary>
    public TerraformExpression PrivateFqdn => this["private_fqdn"];

    /// <summary>
    /// The role_based_access_control_enabled attribute.
    /// </summary>
    public TerraformExpression RoleBasedAccessControlEnabled => this["role_based_access_control_enabled"];

    /// <summary>
    /// The service_mesh_profile attribute.
    /// </summary>
    public TerraformExpression ServiceMeshProfile => this["service_mesh_profile"];

    /// <summary>
    /// The service_principal attribute.
    /// </summary>
    public TerraformExpression ServicePrincipal => this["service_principal"];

    /// <summary>
    /// The storage_profile attribute.
    /// </summary>
    public TerraformExpression StorageProfile => this["storage_profile"];

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformExpression Tags => this["tags"];

    /// <summary>
    /// The windows_profile attribute.
    /// </summary>
    public TerraformExpression WindowsProfile => this["windows_profile"];

}
