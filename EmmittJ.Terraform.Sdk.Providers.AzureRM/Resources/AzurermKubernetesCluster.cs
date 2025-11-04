using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_kubernetes_cluster resource.
/// </summary>
public class AzurermKubernetesCluster : TerraformResource
{
    public AzurermKubernetesCluster(string name) : base("azurerm_kubernetes_cluster", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("current_kubernetes_version");
        this.DeclareOutput("fqdn");
        this.DeclareOutput("http_application_routing_zone_name");
        this.DeclareOutput("kube_admin_config");
        this.DeclareOutput("kube_admin_config_raw");
        this.DeclareOutput("kube_config");
        this.DeclareOutput("kube_config_raw");
        this.DeclareOutput("node_resource_group_id");
        this.DeclareOutput("oidc_issuer_url");
        this.DeclareOutput("portal_fqdn");
        this.DeclareOutput("private_fqdn");
    }

    /// <summary>
    /// The ai_toolchain_operator_enabled attribute.
    /// </summary>
    public bool? AiToolchainOperatorEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("ai_toolchain_operator_enabled")?.Value;
        set => this.WithProperty("ai_toolchain_operator_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The automatic_upgrade_channel attribute.
    /// </summary>
    public string? AutomaticUpgradeChannel
    {
        get => GetProperty<TerraformLiteralProperty<string>>("automatic_upgrade_channel")?.Value;
        set => this.WithProperty("automatic_upgrade_channel", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The azure_policy_enabled attribute.
    /// </summary>
    public bool? AzurePolicyEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("azure_policy_enabled")?.Value;
        set => this.WithProperty("azure_policy_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The cost_analysis_enabled attribute.
    /// </summary>
    public bool? CostAnalysisEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("cost_analysis_enabled")?.Value;
        set => this.WithProperty("cost_analysis_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The custom_ca_trust_certificates_base64 attribute.
    /// </summary>
    public List<string>? CustomCaTrustCertificatesBase64
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("custom_ca_trust_certificates_base64")?.Value;
        set => this.WithProperty("custom_ca_trust_certificates_base64", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    /// <summary>
    /// The disk_encryption_set_id attribute.
    /// </summary>
    public string? DiskEncryptionSetId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("disk_encryption_set_id")?.Value;
        set => this.WithProperty("disk_encryption_set_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The dns_prefix attribute.
    /// </summary>
    public string? DnsPrefix
    {
        get => GetProperty<TerraformLiteralProperty<string>>("dns_prefix")?.Value;
        set => this.WithProperty("dns_prefix", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The dns_prefix_private_cluster attribute.
    /// </summary>
    public string? DnsPrefixPrivateCluster
    {
        get => GetProperty<TerraformLiteralProperty<string>>("dns_prefix_private_cluster")?.Value;
        set => this.WithProperty("dns_prefix_private_cluster", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The edge_zone attribute.
    /// </summary>
    public string? EdgeZone
    {
        get => GetProperty<TerraformLiteralProperty<string>>("edge_zone")?.Value;
        set => this.WithProperty("edge_zone", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The http_application_routing_enabled attribute.
    /// </summary>
    public bool? HttpApplicationRoutingEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("http_application_routing_enabled")?.Value;
        set => this.WithProperty("http_application_routing_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The image_cleaner_enabled attribute.
    /// </summary>
    public bool? ImageCleanerEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("image_cleaner_enabled")?.Value;
        set => this.WithProperty("image_cleaner_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The image_cleaner_interval_hours attribute.
    /// </summary>
    public double? ImageCleanerIntervalHours
    {
        get => GetProperty<TerraformLiteralProperty<double>>("image_cleaner_interval_hours")?.Value;
        set => this.WithProperty("image_cleaner_interval_hours", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The kubernetes_version attribute.
    /// </summary>
    public string? KubernetesVersion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("kubernetes_version")?.Value;
        set => this.WithProperty("kubernetes_version", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The local_account_disabled attribute.
    /// </summary>
    public bool? LocalAccountDisabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("local_account_disabled")?.Value;
        set => this.WithProperty("local_account_disabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public string? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location")?.Value;
        set => this.WithProperty("location", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The node_os_upgrade_channel attribute.
    /// </summary>
    public string? NodeOsUpgradeChannel
    {
        get => GetProperty<TerraformLiteralProperty<string>>("node_os_upgrade_channel")?.Value;
        set => this.WithProperty("node_os_upgrade_channel", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The node_resource_group attribute.
    /// </summary>
    public string? NodeResourceGroup
    {
        get => GetProperty<TerraformLiteralProperty<string>>("node_resource_group")?.Value;
        set => this.WithProperty("node_resource_group", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The oidc_issuer_enabled attribute.
    /// </summary>
    public bool? OidcIssuerEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("oidc_issuer_enabled")?.Value;
        set => this.WithProperty("oidc_issuer_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The open_service_mesh_enabled attribute.
    /// </summary>
    public bool? OpenServiceMeshEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("open_service_mesh_enabled")?.Value;
        set => this.WithProperty("open_service_mesh_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The private_cluster_enabled attribute.
    /// </summary>
    public bool? PrivateClusterEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("private_cluster_enabled")?.Value;
        set => this.WithProperty("private_cluster_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The private_cluster_public_fqdn_enabled attribute.
    /// </summary>
    public bool? PrivateClusterPublicFqdnEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("private_cluster_public_fqdn_enabled")?.Value;
        set => this.WithProperty("private_cluster_public_fqdn_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The private_dns_zone_id attribute.
    /// </summary>
    public string? PrivateDnsZoneId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("private_dns_zone_id")?.Value;
        set => this.WithProperty("private_dns_zone_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public string? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name")?.Value;
        set => this.WithProperty("resource_group_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The role_based_access_control_enabled attribute.
    /// </summary>
    public bool? RoleBasedAccessControlEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("role_based_access_control_enabled")?.Value;
        set => this.WithProperty("role_based_access_control_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The run_command_enabled attribute.
    /// </summary>
    public bool? RunCommandEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("run_command_enabled")?.Value;
        set => this.WithProperty("run_command_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The sku_tier attribute.
    /// </summary>
    public string? SkuTier
    {
        get => GetProperty<TerraformLiteralProperty<string>>("sku_tier")?.Value;
        set => this.WithProperty("sku_tier", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The support_plan attribute.
    /// </summary>
    public string? SupportPlan
    {
        get => GetProperty<TerraformLiteralProperty<string>>("support_plan")?.Value;
        set => this.WithProperty("support_plan", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The workload_identity_enabled attribute.
    /// </summary>
    public bool? WorkloadIdentityEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("workload_identity_enabled")?.Value;
        set => this.WithProperty("workload_identity_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The current_kubernetes_version attribute.
    /// </summary>
    public TerraformExpression CurrentKubernetesVersion => this["current_kubernetes_version"];

    /// <summary>
    /// The fqdn attribute.
    /// </summary>
    public TerraformExpression Fqdn => this["fqdn"];

    /// <summary>
    /// The http_application_routing_zone_name attribute.
    /// </summary>
    public TerraformExpression HttpApplicationRoutingZoneName => this["http_application_routing_zone_name"];

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
    /// The node_resource_group_id attribute.
    /// </summary>
    public TerraformExpression NodeResourceGroupId => this["node_resource_group_id"];

    /// <summary>
    /// The oidc_issuer_url attribute.
    /// </summary>
    public TerraformExpression OidcIssuerUrl => this["oidc_issuer_url"];

    /// <summary>
    /// The portal_fqdn attribute.
    /// </summary>
    public TerraformExpression PortalFqdn => this["portal_fqdn"];

    /// <summary>
    /// The private_fqdn attribute.
    /// </summary>
    public TerraformExpression PrivateFqdn => this["private_fqdn"];

}
