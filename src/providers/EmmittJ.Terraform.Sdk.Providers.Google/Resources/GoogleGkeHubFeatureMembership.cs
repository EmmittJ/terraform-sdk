using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for configmanagement in GoogleGkeHubFeatureMembership.
/// Nesting mode: list
/// </summary>
public class GoogleGkeHubFeatureMembershipConfigmanagementBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "configmanagement";

    /// <summary>
    /// Set this field to MANAGEMENT_AUTOMATIC to enable Config Sync auto-upgrades, and set this field to MANAGEMENT_MANUAL or MANAGEMENT_UNSPECIFIED to disable Config Sync auto-upgrades.
    /// </summary>
    public TerraformValue<string> Management
    {
        get => GetArgument<TerraformValue<string>>("management") ?? AsReference("management");
        set => SetArgument("management", value);
    }

    /// <summary>
    /// Optional. Version of ACM to install. Defaults to the latest version.
    /// </summary>
    public TerraformValue<string> Version
    {
        get => GetArgument<TerraformValue<string>>("version") ?? AsReference("version");
        set => SetArgument("version", value);
    }

    /// <summary>
    /// ConfigSync block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ConfigSync block(s) allowed")]
    public TerraformList<GoogleGkeHubFeatureMembershipConfigmanagementBlockConfigSyncBlock>? ConfigSync
    {
        get => GetArgument<TerraformList<GoogleGkeHubFeatureMembershipConfigmanagementBlockConfigSyncBlock>>("config_sync");
        set => SetArgument("config_sync", value);
    }

    /// <summary>
    /// HierarchyController block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HierarchyController block(s) allowed")]
    public TerraformList<GoogleGkeHubFeatureMembershipConfigmanagementBlockHierarchyControllerBlock>? HierarchyController
    {
        get => GetArgument<TerraformList<GoogleGkeHubFeatureMembershipConfigmanagementBlockHierarchyControllerBlock>>("hierarchy_controller");
        set => SetArgument("hierarchy_controller", value);
    }

    /// <summary>
    /// PolicyController block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PolicyController block(s) allowed")]
    public TerraformList<GoogleGkeHubFeatureMembershipConfigmanagementBlockPolicyControllerBlock>? PolicyController
    {
        get => GetArgument<TerraformList<GoogleGkeHubFeatureMembershipConfigmanagementBlockPolicyControllerBlock>>("policy_controller");
        set => SetArgument("policy_controller", value);
    }

}

/// <summary>
/// Block type for config_sync in GoogleGkeHubFeatureMembershipConfigmanagementBlock.
/// Nesting mode: list
/// </summary>
public class GoogleGkeHubFeatureMembershipConfigmanagementBlockConfigSyncBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "config_sync";

    /// <summary>
    /// Enables the installation of ConfigSync. If set to true, ConfigSync resources will be created and the other ConfigSync fields will be applied if exist. If set to false, all other ConfigSync fields will be ignored, ConfigSync resources will be deleted. If omitted, ConfigSync resources will be managed depends on the presence of the git or oci field.
    /// </summary>
    public TerraformValue<bool>? Enabled
    {
        get => GetArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// Deprecated: If Workload Identity Federation for GKE is enabled, Google Cloud Service Account is no longer needed for exporting Config Sync metrics: https://cloud.google.com/kubernetes-engine/enterprise/config-sync/docs/how-to/monitor-config-sync-cloud-monitoring#custom-monitoring.
    /// </summary>
    public TerraformValue<string>? MetricsGcpServiceAccountEmail
    {
        get => GetArgument<TerraformValue<string>>("metrics_gcp_service_account_email");
        set => SetArgument("metrics_gcp_service_account_email", value);
    }

    /// <summary>
    /// Set to true to enable the Config Sync admission webhook to prevent drifts. If set to `false`, disables the Config Sync admission webhook and does not prevent drifts.
    /// </summary>
    public TerraformValue<bool> PreventDrift
    {
        get => GetArgument<TerraformValue<bool>>("prevent_drift") ?? AsReference("prevent_drift");
        set => SetArgument("prevent_drift", value);
    }

    /// <summary>
    /// Specifies whether the Config Sync Repo is in &amp;quot;hierarchical&amp;quot; or &amp;quot;unstructured&amp;quot; mode.
    /// </summary>
    public TerraformValue<string>? SourceFormat
    {
        get => GetArgument<TerraformValue<string>>("source_format");
        set => SetArgument("source_format", value);
    }

    /// <summary>
    /// Set to true to stop syncing configs for a single cluster. Default: false.
    /// </summary>
    public TerraformValue<bool>? StopSyncing
    {
        get => GetArgument<TerraformValue<bool>>("stop_syncing");
        set => SetArgument("stop_syncing", value);
    }

    /// <summary>
    /// DeploymentOverrides block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleGkeHubFeatureMembershipConfigmanagementBlockConfigSyncBlockDeploymentOverridesBlock>? DeploymentOverrides
    {
        get => GetArgument<TerraformList<GoogleGkeHubFeatureMembershipConfigmanagementBlockConfigSyncBlockDeploymentOverridesBlock>>("deployment_overrides");
        set => SetArgument("deployment_overrides", value);
    }

    /// <summary>
    /// Git block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Git block(s) allowed")]
    public TerraformList<GoogleGkeHubFeatureMembershipConfigmanagementBlockConfigSyncBlockGitBlock>? Git
    {
        get => GetArgument<TerraformList<GoogleGkeHubFeatureMembershipConfigmanagementBlockConfigSyncBlockGitBlock>>("git");
        set => SetArgument("git", value);
    }

    /// <summary>
    /// Oci block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Oci block(s) allowed")]
    public TerraformList<GoogleGkeHubFeatureMembershipConfigmanagementBlockConfigSyncBlockOciBlock>? Oci
    {
        get => GetArgument<TerraformList<GoogleGkeHubFeatureMembershipConfigmanagementBlockConfigSyncBlockOciBlock>>("oci");
        set => SetArgument("oci", value);
    }

}

/// <summary>
/// Block type for deployment_overrides in GoogleGkeHubFeatureMembershipConfigmanagementBlockConfigSyncBlock.
/// Nesting mode: list
/// </summary>
public class GoogleGkeHubFeatureMembershipConfigmanagementBlockConfigSyncBlockDeploymentOverridesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "deployment_overrides";

    /// <summary>
    /// The name of the Deployment.
    /// </summary>
    public TerraformValue<string>? DeploymentName
    {
        get => GetArgument<TerraformValue<string>>("deployment_name");
        set => SetArgument("deployment_name", value);
    }

    /// <summary>
    /// The namespace of the Deployment.
    /// </summary>
    public TerraformValue<string>? DeploymentNamespace
    {
        get => GetArgument<TerraformValue<string>>("deployment_namespace");
        set => SetArgument("deployment_namespace", value);
    }

    /// <summary>
    /// Containers block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleGkeHubFeatureMembershipConfigmanagementBlockConfigSyncBlockDeploymentOverridesBlockContainersBlock>? Containers
    {
        get => GetArgument<TerraformList<GoogleGkeHubFeatureMembershipConfigmanagementBlockConfigSyncBlockDeploymentOverridesBlockContainersBlock>>("containers");
        set => SetArgument("containers", value);
    }

}

/// <summary>
/// Block type for containers in GoogleGkeHubFeatureMembershipConfigmanagementBlockConfigSyncBlockDeploymentOverridesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleGkeHubFeatureMembershipConfigmanagementBlockConfigSyncBlockDeploymentOverridesBlockContainersBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "containers";

    /// <summary>
    /// The name of the container.
    /// </summary>
    public TerraformValue<string>? ContainerName
    {
        get => GetArgument<TerraformValue<string>>("container_name");
        set => SetArgument("container_name", value);
    }

    /// <summary>
    /// The CPU limit of the container.
    /// </summary>
    public TerraformValue<string>? CpuLimit
    {
        get => GetArgument<TerraformValue<string>>("cpu_limit");
        set => SetArgument("cpu_limit", value);
    }

    /// <summary>
    /// The CPU request of the container.
    /// </summary>
    public TerraformValue<string>? CpuRequest
    {
        get => GetArgument<TerraformValue<string>>("cpu_request");
        set => SetArgument("cpu_request", value);
    }

    /// <summary>
    /// The memory limit of the container.
    /// </summary>
    public TerraformValue<string>? MemoryLimit
    {
        get => GetArgument<TerraformValue<string>>("memory_limit");
        set => SetArgument("memory_limit", value);
    }

    /// <summary>
    /// The memory request of the container.
    /// </summary>
    public TerraformValue<string>? MemoryRequest
    {
        get => GetArgument<TerraformValue<string>>("memory_request");
        set => SetArgument("memory_request", value);
    }

}

/// <summary>
/// Block type for git in GoogleGkeHubFeatureMembershipConfigmanagementBlockConfigSyncBlock.
/// Nesting mode: list
/// </summary>
public class GoogleGkeHubFeatureMembershipConfigmanagementBlockConfigSyncBlockGitBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "git";

    /// <summary>
    /// The GCP Service Account Email used for auth when secretType is gcpServiceAccount.
    /// </summary>
    public TerraformValue<string>? GcpServiceAccountEmail
    {
        get => GetArgument<TerraformValue<string>>("gcp_service_account_email");
        set => SetArgument("gcp_service_account_email", value);
    }

    /// <summary>
    /// URL for the HTTPS proxy to be used when communicating with the Git repo.
    /// </summary>
    public TerraformValue<string>? HttpsProxy
    {
        get => GetArgument<TerraformValue<string>>("https_proxy");
        set => SetArgument("https_proxy", value);
    }

    /// <summary>
    /// The path within the Git repository that represents the top level of the repo to sync. Default: the root directory of the repository.
    /// </summary>
    public TerraformValue<string>? PolicyDir
    {
        get => GetArgument<TerraformValue<string>>("policy_dir");
        set => SetArgument("policy_dir", value);
    }

    /// <summary>
    /// Type of secret configured for access to the Git repo. Must be one of ssh, cookiefile, gcenode, token, gcpserviceaccount or none. The validation of this is case-sensitive.
    /// </summary>
    public TerraformValue<string>? SecretType
    {
        get => GetArgument<TerraformValue<string>>("secret_type");
        set => SetArgument("secret_type", value);
    }

    /// <summary>
    /// The branch of the repository to sync from. Default: master.
    /// </summary>
    public TerraformValue<string>? SyncBranch
    {
        get => GetArgument<TerraformValue<string>>("sync_branch");
        set => SetArgument("sync_branch", value);
    }

    /// <summary>
    /// The URL of the Git repository to use as the source of truth.
    /// </summary>
    public TerraformValue<string>? SyncRepo
    {
        get => GetArgument<TerraformValue<string>>("sync_repo");
        set => SetArgument("sync_repo", value);
    }

    /// <summary>
    /// Git revision (tag or hash) to check out. Default HEAD.
    /// </summary>
    public TerraformValue<string>? SyncRev
    {
        get => GetArgument<TerraformValue<string>>("sync_rev");
        set => SetArgument("sync_rev", value);
    }

    /// <summary>
    /// Period in seconds between consecutive syncs. Default: 15.
    /// </summary>
    public TerraformValue<string>? SyncWaitSecs
    {
        get => GetArgument<TerraformValue<string>>("sync_wait_secs");
        set => SetArgument("sync_wait_secs", value);
    }

}

/// <summary>
/// Block type for oci in GoogleGkeHubFeatureMembershipConfigmanagementBlockConfigSyncBlock.
/// Nesting mode: list
/// </summary>
public class GoogleGkeHubFeatureMembershipConfigmanagementBlockConfigSyncBlockOciBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "oci";

    /// <summary>
    /// The GCP Service Account Email used for auth when secret_type is gcpserviceaccount. 
    /// </summary>
    public TerraformValue<string>? GcpServiceAccountEmail
    {
        get => GetArgument<TerraformValue<string>>("gcp_service_account_email");
        set => SetArgument("gcp_service_account_email", value);
    }

    /// <summary>
    /// The absolute path of the directory that contains the local resources. Default: the root directory of the image.
    /// </summary>
    public TerraformValue<string>? PolicyDir
    {
        get => GetArgument<TerraformValue<string>>("policy_dir");
        set => SetArgument("policy_dir", value);
    }

    /// <summary>
    /// Type of secret configured for access to the OCI Image. Must be one of gcenode, gcpserviceaccount or none. The validation of this is case-sensitive.
    /// </summary>
    public TerraformValue<string>? SecretType
    {
        get => GetArgument<TerraformValue<string>>("secret_type");
        set => SetArgument("secret_type", value);
    }

    /// <summary>
    /// The OCI image repository URL for the package to sync from. e.g. LOCATION-docker.pkg.dev/PROJECT_ID/REPOSITORY_NAME/PACKAGE_NAME.
    /// </summary>
    public TerraformValue<string>? SyncRepo
    {
        get => GetArgument<TerraformValue<string>>("sync_repo");
        set => SetArgument("sync_repo", value);
    }

    /// <summary>
    /// Period in seconds(int64 format) between consecutive syncs. Default: 15.
    /// </summary>
    public TerraformValue<string>? SyncWaitSecs
    {
        get => GetArgument<TerraformValue<string>>("sync_wait_secs");
        set => SetArgument("sync_wait_secs", value);
    }

}

/// <summary>
/// Block type for hierarchy_controller in GoogleGkeHubFeatureMembershipConfigmanagementBlock.
/// Nesting mode: list
/// </summary>
public class GoogleGkeHubFeatureMembershipConfigmanagementBlockHierarchyControllerBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "hierarchy_controller";

    /// <summary>
    /// Whether hierarchical resource quota is enabled in this cluster.
    /// </summary>
    public TerraformValue<bool>? EnableHierarchicalResourceQuota
    {
        get => GetArgument<TerraformValue<bool>>("enable_hierarchical_resource_quota");
        set => SetArgument("enable_hierarchical_resource_quota", value);
    }

    /// <summary>
    /// Whether pod tree labels are enabled in this cluster.
    /// </summary>
    public TerraformValue<bool>? EnablePodTreeLabels
    {
        get => GetArgument<TerraformValue<bool>>("enable_pod_tree_labels");
        set => SetArgument("enable_pod_tree_labels", value);
    }

    /// <summary>
    /// **DEPRECATED** Configuring Hierarchy Controller through the configmanagement feature is no longer recommended. Use https://github.com/kubernetes-sigs/hierarchical-namespaces instead.
    /// </summary>
    public TerraformValue<bool>? Enabled
    {
        get => GetArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

}

/// <summary>
/// Block type for policy_controller in GoogleGkeHubFeatureMembershipConfigmanagementBlock.
/// Nesting mode: list
/// </summary>
public class GoogleGkeHubFeatureMembershipConfigmanagementBlockPolicyControllerBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "policy_controller";

    /// <summary>
    /// Sets the interval for Policy Controller Audit Scans (in seconds). When set to 0, this disables audit functionality altogether.
    /// </summary>
    public TerraformValue<string>? AuditIntervalSeconds
    {
        get => GetArgument<TerraformValue<string>>("audit_interval_seconds");
        set => SetArgument("audit_interval_seconds", value);
    }

    /// <summary>
    /// Enables the installation of Policy Controller. If false, the rest of PolicyController fields take no effect.
    /// </summary>
    public TerraformValue<bool>? Enabled
    {
        get => GetArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The set of namespaces that are excluded from Policy Controller checks. Namespaces do not need to currently exist on the cluster.
    /// </summary>
    public TerraformList<string>? ExemptableNamespaces
    {
        get => GetArgument<TerraformList<string>>("exemptable_namespaces");
        set => SetArgument("exemptable_namespaces", value);
    }

    /// <summary>
    /// Logs all denies and dry run failures.
    /// </summary>
    public TerraformValue<bool>? LogDeniesEnabled
    {
        get => GetArgument<TerraformValue<bool>>("log_denies_enabled");
        set => SetArgument("log_denies_enabled", value);
    }

    /// <summary>
    /// Enable or disable mutation in policy controller. If true, mutation CRDs, webhook and controller deployment will be deployed to the cluster.
    /// </summary>
    public TerraformValue<bool>? MutationEnabled
    {
        get => GetArgument<TerraformValue<bool>>("mutation_enabled");
        set => SetArgument("mutation_enabled", value);
    }

    /// <summary>
    /// Enables the ability to use Constraint Templates that reference to objects other than the object currently being evaluated.
    /// </summary>
    public TerraformValue<bool>? ReferentialRulesEnabled
    {
        get => GetArgument<TerraformValue<bool>>("referential_rules_enabled");
        set => SetArgument("referential_rules_enabled", value);
    }

    /// <summary>
    /// Installs the default template library along with Policy Controller.
    /// </summary>
    public TerraformValue<bool>? TemplateLibraryInstalled
    {
        get => GetArgument<TerraformValue<bool>>("template_library_installed");
        set => SetArgument("template_library_installed", value);
    }

    /// <summary>
    /// Monitoring block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Monitoring block(s) allowed")]
    public TerraformList<GoogleGkeHubFeatureMembershipConfigmanagementBlockPolicyControllerBlockMonitoringBlock>? Monitoring
    {
        get => GetArgument<TerraformList<GoogleGkeHubFeatureMembershipConfigmanagementBlockPolicyControllerBlockMonitoringBlock>>("monitoring");
        set => SetArgument("monitoring", value);
    }

}

/// <summary>
/// Block type for monitoring in GoogleGkeHubFeatureMembershipConfigmanagementBlockPolicyControllerBlock.
/// Nesting mode: list
/// </summary>
public class GoogleGkeHubFeatureMembershipConfigmanagementBlockPolicyControllerBlockMonitoringBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "monitoring";

    /// <summary>
    ///  Specifies the list of backends Policy Controller will export to. Specifying an empty value `[]` disables metrics export.
    /// </summary>
    public TerraformList<string> Backends
    {
        get => GetArgument<TerraformList<string>>("backends") ?? AsReference("backends");
        set => SetArgument("backends", value);
    }

}


/// <summary>
/// Block type for mesh in GoogleGkeHubFeatureMembership.
/// Nesting mode: list
/// </summary>
public class GoogleGkeHubFeatureMembershipMeshBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "mesh";

    /// <summary>
    /// **DEPRECATED** Whether to automatically manage Service Mesh control planes. Possible values: CONTROL_PLANE_MANAGEMENT_UNSPECIFIED, AUTOMATIC, MANUAL
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformValue<string>? ControlPlane
    {
        get => GetArgument<TerraformValue<string>>("control_plane");
        set => SetArgument("control_plane", value);
    }

    /// <summary>
    /// Whether to automatically manage Service Mesh. Possible values: MANAGEMENT_UNSPECIFIED, MANAGEMENT_AUTOMATIC, MANAGEMENT_MANUAL
    /// </summary>
    public TerraformValue<string>? Management
    {
        get => GetArgument<TerraformValue<string>>("management");
        set => SetArgument("management", value);
    }

}


/// <summary>
/// Block type for policycontroller in GoogleGkeHubFeatureMembership.
/// Nesting mode: list
/// </summary>
public class GoogleGkeHubFeatureMembershipPolicycontrollerBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "policycontroller";

    /// <summary>
    /// Optional. Version of Policy Controller to install. Defaults to the latest version.
    /// </summary>
    public TerraformValue<string> Version
    {
        get => GetArgument<TerraformValue<string>>("version") ?? AsReference("version");
        set => SetArgument("version", value);
    }

    /// <summary>
    /// PolicyControllerHubConfig block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PolicyControllerHubConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 PolicyControllerHubConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PolicyControllerHubConfig block(s) allowed")]
    public required TerraformList<GoogleGkeHubFeatureMembershipPolicycontrollerBlockPolicyControllerHubConfigBlock> PolicyControllerHubConfig
    {
        get => GetRequiredArgument<TerraformList<GoogleGkeHubFeatureMembershipPolicycontrollerBlockPolicyControllerHubConfigBlock>>("policy_controller_hub_config");
        set => SetArgument("policy_controller_hub_config", value);
    }

}

/// <summary>
/// Block type for policy_controller_hub_config in GoogleGkeHubFeatureMembershipPolicycontrollerBlock.
/// Nesting mode: list
/// </summary>
public class GoogleGkeHubFeatureMembershipPolicycontrollerBlockPolicyControllerHubConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "policy_controller_hub_config";

    /// <summary>
    /// Sets the interval for Policy Controller Audit Scans (in seconds). When set to 0, this disables audit functionality altogether.
    /// </summary>
    public TerraformValue<double>? AuditIntervalSeconds
    {
        get => GetArgument<TerraformValue<double>>("audit_interval_seconds");
        set => SetArgument("audit_interval_seconds", value);
    }

    /// <summary>
    /// The maximum number of audit violations to be stored in a constraint. If not set, the internal default of 20 will be used.
    /// </summary>
    public TerraformValue<double>? ConstraintViolationLimit
    {
        get => GetArgument<TerraformValue<double>>("constraint_violation_limit");
        set => SetArgument("constraint_violation_limit", value);
    }

    /// <summary>
    /// The set of namespaces that are excluded from Policy Controller checks. Namespaces do not need to currently exist on the cluster.
    /// </summary>
    public TerraformList<string>? ExemptableNamespaces
    {
        get => GetArgument<TerraformList<string>>("exemptable_namespaces");
        set => SetArgument("exemptable_namespaces", value);
    }

    /// <summary>
    /// Configures the mode of the Policy Controller installation. Possible values: INSTALL_SPEC_UNSPECIFIED, INSTALL_SPEC_NOT_INSTALLED, INSTALL_SPEC_ENABLED, INSTALL_SPEC_SUSPENDED, INSTALL_SPEC_DETACHED
    /// </summary>
    public TerraformValue<string>? InstallSpec
    {
        get => GetArgument<TerraformValue<string>>("install_spec");
        set => SetArgument("install_spec", value);
    }

    /// <summary>
    /// Logs all denies and dry run failures.
    /// </summary>
    public TerraformValue<bool>? LogDeniesEnabled
    {
        get => GetArgument<TerraformValue<bool>>("log_denies_enabled");
        set => SetArgument("log_denies_enabled", value);
    }

    /// <summary>
    /// Enables the ability to mutate resources using Policy Controller.
    /// </summary>
    public TerraformValue<bool>? MutationEnabled
    {
        get => GetArgument<TerraformValue<bool>>("mutation_enabled");
        set => SetArgument("mutation_enabled", value);
    }

    /// <summary>
    /// Enables the ability to use Constraint Templates that reference to objects other than the object currently being evaluated.
    /// </summary>
    public TerraformValue<bool>? ReferentialRulesEnabled
    {
        get => GetArgument<TerraformValue<bool>>("referential_rules_enabled");
        set => SetArgument("referential_rules_enabled", value);
    }

    /// <summary>
    /// DeploymentConfigs block (nesting mode: set).
    /// </summary>
    public TerraformSet<GoogleGkeHubFeatureMembershipPolicycontrollerBlockPolicyControllerHubConfigBlockDeploymentConfigsBlock>? DeploymentConfigs
    {
        get => GetArgument<TerraformSet<GoogleGkeHubFeatureMembershipPolicycontrollerBlockPolicyControllerHubConfigBlockDeploymentConfigsBlock>>("deployment_configs");
        set => SetArgument("deployment_configs", value);
    }

    /// <summary>
    /// Monitoring block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Monitoring block(s) allowed")]
    public TerraformList<GoogleGkeHubFeatureMembershipPolicycontrollerBlockPolicyControllerHubConfigBlockMonitoringBlock>? Monitoring
    {
        get => GetArgument<TerraformList<GoogleGkeHubFeatureMembershipPolicycontrollerBlockPolicyControllerHubConfigBlockMonitoringBlock>>("monitoring");
        set => SetArgument("monitoring", value);
    }

    /// <summary>
    /// PolicyContent block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PolicyContent block(s) allowed")]
    public TerraformList<GoogleGkeHubFeatureMembershipPolicycontrollerBlockPolicyControllerHubConfigBlockPolicyContentBlock>? PolicyContent
    {
        get => GetArgument<TerraformList<GoogleGkeHubFeatureMembershipPolicycontrollerBlockPolicyControllerHubConfigBlockPolicyContentBlock>>("policy_content");
        set => SetArgument("policy_content", value);
    }

}

/// <summary>
/// Block type for deployment_configs in GoogleGkeHubFeatureMembershipPolicycontrollerBlockPolicyControllerHubConfigBlock.
/// Nesting mode: set
/// </summary>
public class GoogleGkeHubFeatureMembershipPolicycontrollerBlockPolicyControllerHubConfigBlockDeploymentConfigsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "deployment_configs";

    /// <summary>
    /// The name for the key in the map for which this object is mapped to in the API
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ComponentName is required")]
    public required TerraformValue<string> ComponentName
    {
        get => GetRequiredArgument<TerraformValue<string>>("component_name");
        set => SetArgument("component_name", value);
    }

    /// <summary>
    /// Pod affinity configuration. Possible values: AFFINITY_UNSPECIFIED, NO_AFFINITY, ANTI_AFFINITY
    /// </summary>
    public TerraformValue<string>? PodAffinity
    {
        get => GetArgument<TerraformValue<string>>("pod_affinity");
        set => SetArgument("pod_affinity", value);
    }

    /// <summary>
    /// Pod replica count.
    /// </summary>
    public TerraformValue<double>? ReplicaCount
    {
        get => GetArgument<TerraformValue<double>>("replica_count");
        set => SetArgument("replica_count", value);
    }

    /// <summary>
    /// ContainerResources block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ContainerResources block(s) allowed")]
    public TerraformList<GoogleGkeHubFeatureMembershipPolicycontrollerBlockPolicyControllerHubConfigBlockDeploymentConfigsBlockContainerResourcesBlock>? ContainerResources
    {
        get => GetArgument<TerraformList<GoogleGkeHubFeatureMembershipPolicycontrollerBlockPolicyControllerHubConfigBlockDeploymentConfigsBlockContainerResourcesBlock>>("container_resources");
        set => SetArgument("container_resources", value);
    }

    /// <summary>
    /// PodTolerations block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleGkeHubFeatureMembershipPolicycontrollerBlockPolicyControllerHubConfigBlockDeploymentConfigsBlockPodTolerationsBlock>? PodTolerations
    {
        get => GetArgument<TerraformList<GoogleGkeHubFeatureMembershipPolicycontrollerBlockPolicyControllerHubConfigBlockDeploymentConfigsBlockPodTolerationsBlock>>("pod_tolerations");
        set => SetArgument("pod_tolerations", value);
    }

}

/// <summary>
/// Block type for container_resources in GoogleGkeHubFeatureMembershipPolicycontrollerBlockPolicyControllerHubConfigBlockDeploymentConfigsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleGkeHubFeatureMembershipPolicycontrollerBlockPolicyControllerHubConfigBlockDeploymentConfigsBlockContainerResourcesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "container_resources";

    /// <summary>
    /// Limits block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Limits block(s) allowed")]
    public TerraformList<GoogleGkeHubFeatureMembershipPolicycontrollerBlockPolicyControllerHubConfigBlockDeploymentConfigsBlockContainerResourcesBlockLimitsBlock>? Limits
    {
        get => GetArgument<TerraformList<GoogleGkeHubFeatureMembershipPolicycontrollerBlockPolicyControllerHubConfigBlockDeploymentConfigsBlockContainerResourcesBlockLimitsBlock>>("limits");
        set => SetArgument("limits", value);
    }

    /// <summary>
    /// Requests block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Requests block(s) allowed")]
    public TerraformList<GoogleGkeHubFeatureMembershipPolicycontrollerBlockPolicyControllerHubConfigBlockDeploymentConfigsBlockContainerResourcesBlockRequestsBlock>? Requests
    {
        get => GetArgument<TerraformList<GoogleGkeHubFeatureMembershipPolicycontrollerBlockPolicyControllerHubConfigBlockDeploymentConfigsBlockContainerResourcesBlockRequestsBlock>>("requests");
        set => SetArgument("requests", value);
    }

}

/// <summary>
/// Block type for limits in GoogleGkeHubFeatureMembershipPolicycontrollerBlockPolicyControllerHubConfigBlockDeploymentConfigsBlockContainerResourcesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleGkeHubFeatureMembershipPolicycontrollerBlockPolicyControllerHubConfigBlockDeploymentConfigsBlockContainerResourcesBlockLimitsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "limits";

    /// <summary>
    /// CPU requirement expressed in Kubernetes resource units.
    /// </summary>
    public TerraformValue<string>? Cpu
    {
        get => GetArgument<TerraformValue<string>>("cpu");
        set => SetArgument("cpu", value);
    }

    /// <summary>
    /// Memory requirement expressed in Kubernetes resource units.
    /// </summary>
    public TerraformValue<string>? Memory
    {
        get => GetArgument<TerraformValue<string>>("memory");
        set => SetArgument("memory", value);
    }

}

/// <summary>
/// Block type for requests in GoogleGkeHubFeatureMembershipPolicycontrollerBlockPolicyControllerHubConfigBlockDeploymentConfigsBlockContainerResourcesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleGkeHubFeatureMembershipPolicycontrollerBlockPolicyControllerHubConfigBlockDeploymentConfigsBlockContainerResourcesBlockRequestsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "requests";

    /// <summary>
    /// CPU requirement expressed in Kubernetes resource units.
    /// </summary>
    public TerraformValue<string>? Cpu
    {
        get => GetArgument<TerraformValue<string>>("cpu");
        set => SetArgument("cpu", value);
    }

    /// <summary>
    /// Memory requirement expressed in Kubernetes resource units.
    /// </summary>
    public TerraformValue<string>? Memory
    {
        get => GetArgument<TerraformValue<string>>("memory");
        set => SetArgument("memory", value);
    }

}

/// <summary>
/// Block type for pod_tolerations in GoogleGkeHubFeatureMembershipPolicycontrollerBlockPolicyControllerHubConfigBlockDeploymentConfigsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleGkeHubFeatureMembershipPolicycontrollerBlockPolicyControllerHubConfigBlockDeploymentConfigsBlockPodTolerationsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "pod_tolerations";

    /// <summary>
    /// Matches a taint effect.
    /// </summary>
    public TerraformValue<string>? Effect
    {
        get => GetArgument<TerraformValue<string>>("effect");
        set => SetArgument("effect", value);
    }

    /// <summary>
    /// Matches a taint key (not necessarily unique).
    /// </summary>
    public TerraformValue<string>? Key
    {
        get => GetArgument<TerraformValue<string>>("key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// Matches a taint operator.
    /// </summary>
    public TerraformValue<string>? OperatorAttribute
    {
        get => GetArgument<TerraformValue<string>>("operator");
        set => SetArgument("operator", value);
    }

    /// <summary>
    /// Matches a taint value.
    /// </summary>
    public TerraformValue<string>? Value
    {
        get => GetArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for monitoring in GoogleGkeHubFeatureMembershipPolicycontrollerBlockPolicyControllerHubConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleGkeHubFeatureMembershipPolicycontrollerBlockPolicyControllerHubConfigBlockMonitoringBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "monitoring";

    /// <summary>
    ///  Specifies the list of backends Policy Controller will export to. Specifying an empty value `[]` disables metrics export.
    /// </summary>
    public TerraformList<string> Backends
    {
        get => GetArgument<TerraformList<string>>("backends") ?? AsReference("backends");
        set => SetArgument("backends", value);
    }

}

/// <summary>
/// Block type for policy_content in GoogleGkeHubFeatureMembershipPolicycontrollerBlockPolicyControllerHubConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleGkeHubFeatureMembershipPolicycontrollerBlockPolicyControllerHubConfigBlockPolicyContentBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "policy_content";

    /// <summary>
    /// Bundles block (nesting mode: set).
    /// </summary>
    public TerraformSet<GoogleGkeHubFeatureMembershipPolicycontrollerBlockPolicyControllerHubConfigBlockPolicyContentBlockBundlesBlock>? Bundles
    {
        get => GetArgument<TerraformSet<GoogleGkeHubFeatureMembershipPolicycontrollerBlockPolicyControllerHubConfigBlockPolicyContentBlockBundlesBlock>>("bundles");
        set => SetArgument("bundles", value);
    }

    /// <summary>
    /// TemplateLibrary block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TemplateLibrary block(s) allowed")]
    public TerraformList<GoogleGkeHubFeatureMembershipPolicycontrollerBlockPolicyControllerHubConfigBlockPolicyContentBlockTemplateLibraryBlock>? TemplateLibrary
    {
        get => GetArgument<TerraformList<GoogleGkeHubFeatureMembershipPolicycontrollerBlockPolicyControllerHubConfigBlockPolicyContentBlockTemplateLibraryBlock>>("template_library");
        set => SetArgument("template_library", value);
    }

}

/// <summary>
/// Block type for bundles in GoogleGkeHubFeatureMembershipPolicycontrollerBlockPolicyControllerHubConfigBlockPolicyContentBlock.
/// Nesting mode: set
/// </summary>
public class GoogleGkeHubFeatureMembershipPolicycontrollerBlockPolicyControllerHubConfigBlockPolicyContentBlockBundlesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "bundles";

    /// <summary>
    /// The name for the key in the map for which this object is mapped to in the API
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BundleName is required")]
    public required TerraformValue<string> BundleName
    {
        get => GetRequiredArgument<TerraformValue<string>>("bundle_name");
        set => SetArgument("bundle_name", value);
    }

    /// <summary>
    /// The set of namespaces to be exempted from the bundle.
    /// </summary>
    public TerraformList<string>? ExemptedNamespaces
    {
        get => GetArgument<TerraformList<string>>("exempted_namespaces");
        set => SetArgument("exempted_namespaces", value);
    }

}

/// <summary>
/// Block type for template_library in GoogleGkeHubFeatureMembershipPolicycontrollerBlockPolicyControllerHubConfigBlockPolicyContentBlock.
/// Nesting mode: list
/// </summary>
public class GoogleGkeHubFeatureMembershipPolicycontrollerBlockPolicyControllerHubConfigBlockPolicyContentBlockTemplateLibraryBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "template_library";

    /// <summary>
    /// Configures the manner in which the template library is installed on the cluster. Possible values: INSTALLATION_UNSPECIFIED, NOT_INSTALLED, ALL
    /// </summary>
    public TerraformValue<string>? Installation
    {
        get => GetArgument<TerraformValue<string>>("installation");
        set => SetArgument("installation", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleGkeHubFeatureMembership.
/// Nesting mode: single
/// </summary>
public class GoogleGkeHubFeatureMembershipTimeoutsBlock : TerraformBlock
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
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a google_gke_hub_feature_membership Terraform resource.
/// Manages a google_gke_hub_feature_membership resource.
/// </summary>
public partial class GoogleGkeHubFeatureMembership(string name) : TerraformResource("google_gke_hub_feature_membership", name)
{
    /// <summary>
    /// The name of the feature
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Feature is required")]
    public required TerraformValue<string> Feature
    {
        get => GetRequiredArgument<TerraformValue<string>>("feature");
        set => SetArgument("feature", value);
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
    /// The location of the feature
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetRequiredArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The name of the membership
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Membership is required")]
    public required TerraformValue<string> Membership
    {
        get => GetRequiredArgument<TerraformValue<string>>("membership");
        set => SetArgument("membership", value);
    }

    /// <summary>
    /// The location of the membership
    /// </summary>
    public TerraformValue<string>? MembershipLocation
    {
        get => GetArgument<TerraformValue<string>>("membership_location");
        set => SetArgument("membership_location", value);
    }

    /// <summary>
    /// The project of the feature
    /// </summary>
    public TerraformValue<string> Project
    {
        get => GetArgument<TerraformValue<string>>("project") ?? AsReference("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// Configmanagement block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Configmanagement block(s) allowed")]
    public TerraformList<GoogleGkeHubFeatureMembershipConfigmanagementBlock>? Configmanagement
    {
        get => GetArgument<TerraformList<GoogleGkeHubFeatureMembershipConfigmanagementBlock>>("configmanagement");
        set => SetArgument("configmanagement", value);
    }

    /// <summary>
    /// Mesh block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Mesh block(s) allowed")]
    public TerraformList<GoogleGkeHubFeatureMembershipMeshBlock>? Mesh
    {
        get => GetArgument<TerraformList<GoogleGkeHubFeatureMembershipMeshBlock>>("mesh");
        set => SetArgument("mesh", value);
    }

    /// <summary>
    /// Policycontroller block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Policycontroller block(s) allowed")]
    public TerraformList<GoogleGkeHubFeatureMembershipPolicycontrollerBlock>? Policycontroller
    {
        get => GetArgument<TerraformList<GoogleGkeHubFeatureMembershipPolicycontrollerBlock>>("policycontroller");
        set => SetArgument("policycontroller", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleGkeHubFeatureMembershipTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleGkeHubFeatureMembershipTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
