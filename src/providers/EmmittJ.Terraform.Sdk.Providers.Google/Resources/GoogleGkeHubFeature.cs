using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for fleet_default_member_config in GoogleGkeHubFeature.
/// Nesting mode: list
/// </summary>
public class GoogleGkeHubFeatureFleetDefaultMemberConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "fleet_default_member_config";

    /// <summary>
    /// Configmanagement block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Configmanagement block(s) allowed")]
    public TerraformList<GoogleGkeHubFeatureFleetDefaultMemberConfigBlockConfigmanagementBlock>? Configmanagement
    {
        get => GetArgument<TerraformList<GoogleGkeHubFeatureFleetDefaultMemberConfigBlockConfigmanagementBlock>>("configmanagement");
        set => SetArgument("configmanagement", value);
    }

    /// <summary>
    /// Mesh block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Mesh block(s) allowed")]
    public TerraformList<GoogleGkeHubFeatureFleetDefaultMemberConfigBlockMeshBlock>? Mesh
    {
        get => GetArgument<TerraformList<GoogleGkeHubFeatureFleetDefaultMemberConfigBlockMeshBlock>>("mesh");
        set => SetArgument("mesh", value);
    }

    /// <summary>
    /// Policycontroller block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Policycontroller block(s) allowed")]
    public TerraformList<GoogleGkeHubFeatureFleetDefaultMemberConfigBlockPolicycontrollerBlock>? Policycontroller
    {
        get => GetArgument<TerraformList<GoogleGkeHubFeatureFleetDefaultMemberConfigBlockPolicycontrollerBlock>>("policycontroller");
        set => SetArgument("policycontroller", value);
    }

}

/// <summary>
/// Block type for configmanagement in GoogleGkeHubFeatureFleetDefaultMemberConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleGkeHubFeatureFleetDefaultMemberConfigBlockConfigmanagementBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "configmanagement";

    /// <summary>
    /// Set this field to MANAGEMENT_AUTOMATIC to enable Config Sync auto-upgrades, and set this field to MANAGEMENT_MANUAL or MANAGEMENT_UNSPECIFIED to disable Config Sync auto-upgrades. Possible values: [&amp;quot;MANAGEMENT_UNSPECIFIED&amp;quot;, &amp;quot;MANAGEMENT_AUTOMATIC&amp;quot;, &amp;quot;MANAGEMENT_MANUAL&amp;quot;]
    /// </summary>
    public TerraformValue<string>? Management
    {
        get => GetArgument<TerraformValue<string>>("management");
        set => SetArgument("management", value);
    }

    /// <summary>
    /// Version of Config Sync installed
    /// </summary>
    public TerraformValue<string>? Version
    {
        get => GetArgument<TerraformValue<string>>("version");
        set => SetArgument("version", value);
    }

    /// <summary>
    /// ConfigSync block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ConfigSync block(s) allowed")]
    public TerraformList<GoogleGkeHubFeatureFleetDefaultMemberConfigBlockConfigmanagementBlockConfigSyncBlock>? ConfigSync
    {
        get => GetArgument<TerraformList<GoogleGkeHubFeatureFleetDefaultMemberConfigBlockConfigmanagementBlockConfigSyncBlock>>("config_sync");
        set => SetArgument("config_sync", value);
    }

}

/// <summary>
/// Block type for config_sync in GoogleGkeHubFeatureFleetDefaultMemberConfigBlockConfigmanagementBlock.
/// Nesting mode: list
/// </summary>
public class GoogleGkeHubFeatureFleetDefaultMemberConfigBlockConfigmanagementBlockConfigSyncBlock : TerraformBlock
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
    /// The Email of the Google Cloud Service Account (GSA) used for exporting Config Sync metrics to Cloud Monitoring. The GSA should have the Monitoring Metric Writer(roles/monitoring.metricWriter) IAM role. The Kubernetes ServiceAccount &#39;default&#39; in the namespace &#39;config-management-monitoring&#39; should be bound to the GSA.
    /// </summary>
    public TerraformValue<string>? MetricsGcpServiceAccountEmail
    {
        get => GetArgument<TerraformValue<string>>("metrics_gcp_service_account_email");
        set => SetArgument("metrics_gcp_service_account_email", value);
    }

    /// <summary>
    /// Set to true to enable the Config Sync admission webhook to prevent drifts. If set to &#39;false&#39;, disables the Config Sync admission webhook and does not prevent drifts.
    /// </summary>
    public TerraformValue<bool>? PreventDrift
    {
        get => GetArgument<TerraformValue<bool>>("prevent_drift");
        set => SetArgument("prevent_drift", value);
    }

    /// <summary>
    /// Specifies whether the Config Sync Repo is in hierarchical or unstructured mode
    /// </summary>
    public TerraformValue<string>? SourceFormat
    {
        get => GetArgument<TerraformValue<string>>("source_format");
        set => SetArgument("source_format", value);
    }

    /// <summary>
    /// Git block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Git block(s) allowed")]
    public TerraformList<GoogleGkeHubFeatureFleetDefaultMemberConfigBlockConfigmanagementBlockConfigSyncBlockGitBlock>? Git
    {
        get => GetArgument<TerraformList<GoogleGkeHubFeatureFleetDefaultMemberConfigBlockConfigmanagementBlockConfigSyncBlockGitBlock>>("git");
        set => SetArgument("git", value);
    }

    /// <summary>
    /// Oci block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Oci block(s) allowed")]
    public TerraformList<GoogleGkeHubFeatureFleetDefaultMemberConfigBlockConfigmanagementBlockConfigSyncBlockOciBlock>? Oci
    {
        get => GetArgument<TerraformList<GoogleGkeHubFeatureFleetDefaultMemberConfigBlockConfigmanagementBlockConfigSyncBlockOciBlock>>("oci");
        set => SetArgument("oci", value);
    }

}

/// <summary>
/// Block type for git in GoogleGkeHubFeatureFleetDefaultMemberConfigBlockConfigmanagementBlockConfigSyncBlock.
/// Nesting mode: list
/// </summary>
public class GoogleGkeHubFeatureFleetDefaultMemberConfigBlockConfigmanagementBlockConfigSyncBlockGitBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "git";

    /// <summary>
    /// The Google Cloud Service Account Email used for auth when secretType is gcpServiceAccount
    /// </summary>
    public TerraformValue<string>? GcpServiceAccountEmail
    {
        get => GetArgument<TerraformValue<string>>("gcp_service_account_email");
        set => SetArgument("gcp_service_account_email", value);
    }

    /// <summary>
    /// URL for the HTTPS Proxy to be used when communicating with the Git repo
    /// </summary>
    public TerraformValue<string>? HttpsProxy
    {
        get => GetArgument<TerraformValue<string>>("https_proxy");
        set => SetArgument("https_proxy", value);
    }

    /// <summary>
    /// The path within the Git repository that represents the top level of the repo to sync
    /// </summary>
    public TerraformValue<string>? PolicyDir
    {
        get => GetArgument<TerraformValue<string>>("policy_dir");
        set => SetArgument("policy_dir", value);
    }

    /// <summary>
    /// Type of secret configured for access to the Git repo
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecretType is required")]
    public required TerraformValue<string> SecretType
    {
        get => GetRequiredArgument<TerraformValue<string>>("secret_type");
        set => SetArgument("secret_type", value);
    }

    /// <summary>
    /// The branch of the repository to sync from. Default: master
    /// </summary>
    public TerraformValue<string>? SyncBranch
    {
        get => GetArgument<TerraformValue<string>>("sync_branch");
        set => SetArgument("sync_branch", value);
    }

    /// <summary>
    /// The URL of the Git repository to use as the source of truth
    /// </summary>
    public TerraformValue<string>? SyncRepo
    {
        get => GetArgument<TerraformValue<string>>("sync_repo");
        set => SetArgument("sync_repo", value);
    }

    /// <summary>
    /// Git revision (tag or hash) to check out. Default HEAD
    /// </summary>
    public TerraformValue<string>? SyncRev
    {
        get => GetArgument<TerraformValue<string>>("sync_rev");
        set => SetArgument("sync_rev", value);
    }

    /// <summary>
    /// Period in seconds between consecutive syncs. Default: 15
    /// </summary>
    public TerraformValue<string>? SyncWaitSecs
    {
        get => GetArgument<TerraformValue<string>>("sync_wait_secs");
        set => SetArgument("sync_wait_secs", value);
    }

}

/// <summary>
/// Block type for oci in GoogleGkeHubFeatureFleetDefaultMemberConfigBlockConfigmanagementBlockConfigSyncBlock.
/// Nesting mode: list
/// </summary>
public class GoogleGkeHubFeatureFleetDefaultMemberConfigBlockConfigmanagementBlockConfigSyncBlockOciBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "oci";

    /// <summary>
    /// The Google Cloud Service Account Email used for auth when secretType is gcpServiceAccount
    /// </summary>
    public TerraformValue<string>? GcpServiceAccountEmail
    {
        get => GetArgument<TerraformValue<string>>("gcp_service_account_email");
        set => SetArgument("gcp_service_account_email", value);
    }

    /// <summary>
    /// The absolute path of the directory that contains the local resources. Default: the root directory of the image
    /// </summary>
    public TerraformValue<string>? PolicyDir
    {
        get => GetArgument<TerraformValue<string>>("policy_dir");
        set => SetArgument("policy_dir", value);
    }

    /// <summary>
    /// Type of secret configured for access to the Git repo
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecretType is required")]
    public required TerraformValue<string> SecretType
    {
        get => GetRequiredArgument<TerraformValue<string>>("secret_type");
        set => SetArgument("secret_type", value);
    }

    /// <summary>
    /// The OCI image repository URL for the package to sync from
    /// </summary>
    public TerraformValue<string>? SyncRepo
    {
        get => GetArgument<TerraformValue<string>>("sync_repo");
        set => SetArgument("sync_repo", value);
    }

    /// <summary>
    /// Period in seconds between consecutive syncs. Default: 15
    /// </summary>
    public TerraformValue<string>? SyncWaitSecs
    {
        get => GetArgument<TerraformValue<string>>("sync_wait_secs");
        set => SetArgument("sync_wait_secs", value);
    }

    /// <summary>
    /// Version of Config Sync installed
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformValue<string>? Version
    {
        get => GetArgument<TerraformValue<string>>("version");
        set => SetArgument("version", value);
    }

}

/// <summary>
/// Block type for mesh in GoogleGkeHubFeatureFleetDefaultMemberConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleGkeHubFeatureFleetDefaultMemberConfigBlockMeshBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "mesh";

    /// <summary>
    /// Whether to automatically manage Service Mesh Possible values: [&amp;quot;MANAGEMENT_UNSPECIFIED&amp;quot;, &amp;quot;MANAGEMENT_AUTOMATIC&amp;quot;, &amp;quot;MANAGEMENT_MANUAL&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Management is required")]
    public required TerraformValue<string> Management
    {
        get => GetRequiredArgument<TerraformValue<string>>("management");
        set => SetArgument("management", value);
    }

}

/// <summary>
/// Block type for policycontroller in GoogleGkeHubFeatureFleetDefaultMemberConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleGkeHubFeatureFleetDefaultMemberConfigBlockPolicycontrollerBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "policycontroller";

    /// <summary>
    /// Configures the version of Policy Controller
    /// </summary>
    public TerraformValue<string> Version
    {
        get => GetArgument<TerraformValue<string>>("version") ?? CreateReference("version");
        set => SetArgument("version", value);
    }

    /// <summary>
    /// PolicyControllerHubConfig block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PolicyControllerHubConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 PolicyControllerHubConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PolicyControllerHubConfig block(s) allowed")]
    public required TerraformList<GoogleGkeHubFeatureFleetDefaultMemberConfigBlockPolicycontrollerBlockPolicyControllerHubConfigBlock> PolicyControllerHubConfig
    {
        get => GetRequiredArgument<TerraformList<GoogleGkeHubFeatureFleetDefaultMemberConfigBlockPolicycontrollerBlockPolicyControllerHubConfigBlock>>("policy_controller_hub_config");
        set => SetArgument("policy_controller_hub_config", value);
    }

}

/// <summary>
/// Block type for policy_controller_hub_config in GoogleGkeHubFeatureFleetDefaultMemberConfigBlockPolicycontrollerBlock.
/// Nesting mode: list
/// </summary>
public class GoogleGkeHubFeatureFleetDefaultMemberConfigBlockPolicycontrollerBlockPolicyControllerHubConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "policy_controller_hub_config";

    /// <summary>
    /// Interval for Policy Controller Audit scans (in seconds). When set to 0, this disables audit functionality altogether.
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
    /// Configures the mode of the Policy Controller installation Possible values: [&amp;quot;INSTALL_SPEC_UNSPECIFIED&amp;quot;, &amp;quot;INSTALL_SPEC_NOT_INSTALLED&amp;quot;, &amp;quot;INSTALL_SPEC_ENABLED&amp;quot;, &amp;quot;INSTALL_SPEC_SUSPENDED&amp;quot;, &amp;quot;INSTALL_SPEC_DETACHED&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstallSpec is required")]
    public required TerraformValue<string> InstallSpec
    {
        get => GetRequiredArgument<TerraformValue<string>>("install_spec");
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
    public TerraformSet<GoogleGkeHubFeatureFleetDefaultMemberConfigBlockPolicycontrollerBlockPolicyControllerHubConfigBlockDeploymentConfigsBlock>? DeploymentConfigs
    {
        get => GetArgument<TerraformSet<GoogleGkeHubFeatureFleetDefaultMemberConfigBlockPolicycontrollerBlockPolicyControllerHubConfigBlockDeploymentConfigsBlock>>("deployment_configs");
        set => SetArgument("deployment_configs", value);
    }

    /// <summary>
    /// Monitoring block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Monitoring block(s) allowed")]
    public TerraformList<GoogleGkeHubFeatureFleetDefaultMemberConfigBlockPolicycontrollerBlockPolicyControllerHubConfigBlockMonitoringBlock>? Monitoring
    {
        get => GetArgument<TerraformList<GoogleGkeHubFeatureFleetDefaultMemberConfigBlockPolicycontrollerBlockPolicyControllerHubConfigBlockMonitoringBlock>>("monitoring");
        set => SetArgument("monitoring", value);
    }

    /// <summary>
    /// PolicyContent block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PolicyContent block(s) allowed")]
    public TerraformList<GoogleGkeHubFeatureFleetDefaultMemberConfigBlockPolicycontrollerBlockPolicyControllerHubConfigBlockPolicyContentBlock>? PolicyContent
    {
        get => GetArgument<TerraformList<GoogleGkeHubFeatureFleetDefaultMemberConfigBlockPolicycontrollerBlockPolicyControllerHubConfigBlockPolicyContentBlock>>("policy_content");
        set => SetArgument("policy_content", value);
    }

}

/// <summary>
/// Block type for deployment_configs in GoogleGkeHubFeatureFleetDefaultMemberConfigBlockPolicycontrollerBlockPolicyControllerHubConfigBlock.
/// Nesting mode: set
/// </summary>
public class GoogleGkeHubFeatureFleetDefaultMemberConfigBlockPolicycontrollerBlockPolicyControllerHubConfigBlockDeploymentConfigsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "deployment_configs";

    /// <summary>
    /// The component attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Component is required")]
    public required TerraformValue<string> Component
    {
        get => GetRequiredArgument<TerraformValue<string>>("component");
        set => SetArgument("component", value);
    }

    /// <summary>
    /// Pod affinity configuration. Possible values: [&amp;quot;AFFINITY_UNSPECIFIED&amp;quot;, &amp;quot;NO_AFFINITY&amp;quot;, &amp;quot;ANTI_AFFINITY&amp;quot;]
    /// </summary>
    public TerraformValue<string> PodAffinity
    {
        get => GetArgument<TerraformValue<string>>("pod_affinity") ?? CreateReference("pod_affinity");
        set => SetArgument("pod_affinity", value);
    }

    /// <summary>
    /// Pod replica count.
    /// </summary>
    public TerraformValue<double> ReplicaCount
    {
        get => GetArgument<TerraformValue<double>>("replica_count") ?? CreateReference("replica_count");
        set => SetArgument("replica_count", value);
    }

    /// <summary>
    /// ContainerResources block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ContainerResources block(s) allowed")]
    public TerraformList<GoogleGkeHubFeatureFleetDefaultMemberConfigBlockPolicycontrollerBlockPolicyControllerHubConfigBlockDeploymentConfigsBlockContainerResourcesBlock>? ContainerResources
    {
        get => GetArgument<TerraformList<GoogleGkeHubFeatureFleetDefaultMemberConfigBlockPolicycontrollerBlockPolicyControllerHubConfigBlockDeploymentConfigsBlockContainerResourcesBlock>>("container_resources");
        set => SetArgument("container_resources", value);
    }

    /// <summary>
    /// PodToleration block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleGkeHubFeatureFleetDefaultMemberConfigBlockPolicycontrollerBlockPolicyControllerHubConfigBlockDeploymentConfigsBlockPodTolerationBlock>? PodToleration
    {
        get => GetArgument<TerraformList<GoogleGkeHubFeatureFleetDefaultMemberConfigBlockPolicycontrollerBlockPolicyControllerHubConfigBlockDeploymentConfigsBlockPodTolerationBlock>>("pod_toleration");
        set => SetArgument("pod_toleration", value);
    }

}

/// <summary>
/// Block type for container_resources in GoogleGkeHubFeatureFleetDefaultMemberConfigBlockPolicycontrollerBlockPolicyControllerHubConfigBlockDeploymentConfigsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleGkeHubFeatureFleetDefaultMemberConfigBlockPolicycontrollerBlockPolicyControllerHubConfigBlockDeploymentConfigsBlockContainerResourcesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "container_resources";

    /// <summary>
    /// Limits block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Limits block(s) allowed")]
    public TerraformList<GoogleGkeHubFeatureFleetDefaultMemberConfigBlockPolicycontrollerBlockPolicyControllerHubConfigBlockDeploymentConfigsBlockContainerResourcesBlockLimitsBlock>? Limits
    {
        get => GetArgument<TerraformList<GoogleGkeHubFeatureFleetDefaultMemberConfigBlockPolicycontrollerBlockPolicyControllerHubConfigBlockDeploymentConfigsBlockContainerResourcesBlockLimitsBlock>>("limits");
        set => SetArgument("limits", value);
    }

    /// <summary>
    /// Requests block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Requests block(s) allowed")]
    public TerraformList<GoogleGkeHubFeatureFleetDefaultMemberConfigBlockPolicycontrollerBlockPolicyControllerHubConfigBlockDeploymentConfigsBlockContainerResourcesBlockRequestsBlock>? Requests
    {
        get => GetArgument<TerraformList<GoogleGkeHubFeatureFleetDefaultMemberConfigBlockPolicycontrollerBlockPolicyControllerHubConfigBlockDeploymentConfigsBlockContainerResourcesBlockRequestsBlock>>("requests");
        set => SetArgument("requests", value);
    }

}

/// <summary>
/// Block type for limits in GoogleGkeHubFeatureFleetDefaultMemberConfigBlockPolicycontrollerBlockPolicyControllerHubConfigBlockDeploymentConfigsBlockContainerResourcesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleGkeHubFeatureFleetDefaultMemberConfigBlockPolicycontrollerBlockPolicyControllerHubConfigBlockDeploymentConfigsBlockContainerResourcesBlockLimitsBlock : TerraformBlock
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
/// Block type for requests in GoogleGkeHubFeatureFleetDefaultMemberConfigBlockPolicycontrollerBlockPolicyControllerHubConfigBlockDeploymentConfigsBlockContainerResourcesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleGkeHubFeatureFleetDefaultMemberConfigBlockPolicycontrollerBlockPolicyControllerHubConfigBlockDeploymentConfigsBlockContainerResourcesBlockRequestsBlock : TerraformBlock
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
/// Block type for pod_toleration in GoogleGkeHubFeatureFleetDefaultMemberConfigBlockPolicycontrollerBlockPolicyControllerHubConfigBlockDeploymentConfigsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleGkeHubFeatureFleetDefaultMemberConfigBlockPolicycontrollerBlockPolicyControllerHubConfigBlockDeploymentConfigsBlockPodTolerationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "pod_toleration";

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
/// Block type for monitoring in GoogleGkeHubFeatureFleetDefaultMemberConfigBlockPolicycontrollerBlockPolicyControllerHubConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleGkeHubFeatureFleetDefaultMemberConfigBlockPolicycontrollerBlockPolicyControllerHubConfigBlockMonitoringBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "monitoring";

    /// <summary>
    /// Specifies the list of backends Policy Controller will export to. An empty list would effectively disable metrics export. Possible values: [&amp;quot;MONITORING_BACKEND_UNSPECIFIED&amp;quot;, &amp;quot;PROMETHEUS&amp;quot;, &amp;quot;CLOUD_MONITORING&amp;quot;]
    /// </summary>
    public TerraformList<string> Backends
    {
        get => GetArgument<TerraformList<string>>("backends") ?? CreateReference("backends");
        set => SetArgument("backends", value);
    }

}

/// <summary>
/// Block type for policy_content in GoogleGkeHubFeatureFleetDefaultMemberConfigBlockPolicycontrollerBlockPolicyControllerHubConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleGkeHubFeatureFleetDefaultMemberConfigBlockPolicycontrollerBlockPolicyControllerHubConfigBlockPolicyContentBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "policy_content";

    /// <summary>
    /// Bundles block (nesting mode: set).
    /// </summary>
    public TerraformSet<GoogleGkeHubFeatureFleetDefaultMemberConfigBlockPolicycontrollerBlockPolicyControllerHubConfigBlockPolicyContentBlockBundlesBlock>? Bundles
    {
        get => GetArgument<TerraformSet<GoogleGkeHubFeatureFleetDefaultMemberConfigBlockPolicycontrollerBlockPolicyControllerHubConfigBlockPolicyContentBlockBundlesBlock>>("bundles");
        set => SetArgument("bundles", value);
    }

    /// <summary>
    /// TemplateLibrary block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TemplateLibrary block(s) allowed")]
    public TerraformList<GoogleGkeHubFeatureFleetDefaultMemberConfigBlockPolicycontrollerBlockPolicyControllerHubConfigBlockPolicyContentBlockTemplateLibraryBlock>? TemplateLibrary
    {
        get => GetArgument<TerraformList<GoogleGkeHubFeatureFleetDefaultMemberConfigBlockPolicycontrollerBlockPolicyControllerHubConfigBlockPolicyContentBlockTemplateLibraryBlock>>("template_library");
        set => SetArgument("template_library", value);
    }

}

/// <summary>
/// Block type for bundles in GoogleGkeHubFeatureFleetDefaultMemberConfigBlockPolicycontrollerBlockPolicyControllerHubConfigBlockPolicyContentBlock.
/// Nesting mode: set
/// </summary>
public class GoogleGkeHubFeatureFleetDefaultMemberConfigBlockPolicycontrollerBlockPolicyControllerHubConfigBlockPolicyContentBlockBundlesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "bundles";

    /// <summary>
    /// The bundle attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Bundle is required")]
    public required TerraformValue<string> Bundle
    {
        get => GetRequiredArgument<TerraformValue<string>>("bundle");
        set => SetArgument("bundle", value);
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
/// Block type for template_library in GoogleGkeHubFeatureFleetDefaultMemberConfigBlockPolicycontrollerBlockPolicyControllerHubConfigBlockPolicyContentBlock.
/// Nesting mode: list
/// </summary>
public class GoogleGkeHubFeatureFleetDefaultMemberConfigBlockPolicycontrollerBlockPolicyControllerHubConfigBlockPolicyContentBlockTemplateLibraryBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "template_library";

    /// <summary>
    /// Configures the manner in which the template library is installed on the cluster. Possible values: [&amp;quot;INSTALLATION_UNSPECIFIED&amp;quot;, &amp;quot;NOT_INSTALLED&amp;quot;, &amp;quot;ALL&amp;quot;]
    /// </summary>
    public TerraformValue<string>? Installation
    {
        get => GetArgument<TerraformValue<string>>("installation");
        set => SetArgument("installation", value);
    }

}


/// <summary>
/// Block type for spec in GoogleGkeHubFeature.
/// Nesting mode: list
/// </summary>
public class GoogleGkeHubFeatureSpecBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "spec";

    /// <summary>
    /// Clusterupgrade block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Clusterupgrade block(s) allowed")]
    public TerraformList<GoogleGkeHubFeatureSpecBlockClusterupgradeBlock>? Clusterupgrade
    {
        get => GetArgument<TerraformList<GoogleGkeHubFeatureSpecBlockClusterupgradeBlock>>("clusterupgrade");
        set => SetArgument("clusterupgrade", value);
    }

    /// <summary>
    /// Fleetobservability block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Fleetobservability block(s) allowed")]
    public TerraformList<GoogleGkeHubFeatureSpecBlockFleetobservabilityBlock>? Fleetobservability
    {
        get => GetArgument<TerraformList<GoogleGkeHubFeatureSpecBlockFleetobservabilityBlock>>("fleetobservability");
        set => SetArgument("fleetobservability", value);
    }

    /// <summary>
    /// Multiclusteringress block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Multiclusteringress block(s) allowed")]
    public TerraformList<GoogleGkeHubFeatureSpecBlockMulticlusteringressBlock>? Multiclusteringress
    {
        get => GetArgument<TerraformList<GoogleGkeHubFeatureSpecBlockMulticlusteringressBlock>>("multiclusteringress");
        set => SetArgument("multiclusteringress", value);
    }

    /// <summary>
    /// Rbacrolebindingactuation block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Rbacrolebindingactuation block(s) allowed")]
    public TerraformList<GoogleGkeHubFeatureSpecBlockRbacrolebindingactuationBlock>? Rbacrolebindingactuation
    {
        get => GetArgument<TerraformList<GoogleGkeHubFeatureSpecBlockRbacrolebindingactuationBlock>>("rbacrolebindingactuation");
        set => SetArgument("rbacrolebindingactuation", value);
    }

}

/// <summary>
/// Block type for clusterupgrade in GoogleGkeHubFeatureSpecBlock.
/// Nesting mode: list
/// </summary>
public class GoogleGkeHubFeatureSpecBlockClusterupgradeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "clusterupgrade";

    /// <summary>
    /// Specified if other fleet should be considered as a source of upgrades. Currently, at most one upstream fleet is allowed. The fleet name should be either fleet project number or id.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UpstreamFleets is required")]
    public TerraformList<string>? UpstreamFleets
    {
        get => GetArgument<TerraformList<string>>("upstream_fleets");
        set => SetArgument("upstream_fleets", value);
    }

    /// <summary>
    /// GkeUpgradeOverrides block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleGkeHubFeatureSpecBlockClusterupgradeBlockGkeUpgradeOverridesBlock>? GkeUpgradeOverrides
    {
        get => GetArgument<TerraformList<GoogleGkeHubFeatureSpecBlockClusterupgradeBlockGkeUpgradeOverridesBlock>>("gke_upgrade_overrides");
        set => SetArgument("gke_upgrade_overrides", value);
    }

    /// <summary>
    /// PostConditions block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PostConditions block(s) allowed")]
    public TerraformList<GoogleGkeHubFeatureSpecBlockClusterupgradeBlockPostConditionsBlock>? PostConditions
    {
        get => GetArgument<TerraformList<GoogleGkeHubFeatureSpecBlockClusterupgradeBlockPostConditionsBlock>>("post_conditions");
        set => SetArgument("post_conditions", value);
    }

}

/// <summary>
/// Block type for gke_upgrade_overrides in GoogleGkeHubFeatureSpecBlockClusterupgradeBlock.
/// Nesting mode: list
/// </summary>
public class GoogleGkeHubFeatureSpecBlockClusterupgradeBlockGkeUpgradeOverridesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "gke_upgrade_overrides";

    /// <summary>
    /// PostConditions block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PostConditions is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 PostConditions block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PostConditions block(s) allowed")]
    public required TerraformList<GoogleGkeHubFeatureSpecBlockClusterupgradeBlockGkeUpgradeOverridesBlockPostConditionsBlock> PostConditions
    {
        get => GetRequiredArgument<TerraformList<GoogleGkeHubFeatureSpecBlockClusterupgradeBlockGkeUpgradeOverridesBlockPostConditionsBlock>>("post_conditions");
        set => SetArgument("post_conditions", value);
    }

    /// <summary>
    /// Upgrade block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Upgrade is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Upgrade block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Upgrade block(s) allowed")]
    public required TerraformList<GoogleGkeHubFeatureSpecBlockClusterupgradeBlockGkeUpgradeOverridesBlockUpgradeBlock> Upgrade
    {
        get => GetRequiredArgument<TerraformList<GoogleGkeHubFeatureSpecBlockClusterupgradeBlockGkeUpgradeOverridesBlockUpgradeBlock>>("upgrade");
        set => SetArgument("upgrade", value);
    }

}

/// <summary>
/// Block type for post_conditions in GoogleGkeHubFeatureSpecBlockClusterupgradeBlockGkeUpgradeOverridesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleGkeHubFeatureSpecBlockClusterupgradeBlockGkeUpgradeOverridesBlockPostConditionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "post_conditions";

    /// <summary>
    /// Amount of time to &amp;quot;soak&amp;quot; after a rollout has been finished before marking it COMPLETE. Cannot exceed 30 days.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Soaking is required")]
    public required TerraformValue<string> Soaking
    {
        get => GetRequiredArgument<TerraformValue<string>>("soaking");
        set => SetArgument("soaking", value);
    }

}

/// <summary>
/// Block type for upgrade in GoogleGkeHubFeatureSpecBlockClusterupgradeBlockGkeUpgradeOverridesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleGkeHubFeatureSpecBlockClusterupgradeBlockGkeUpgradeOverridesBlockUpgradeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "upgrade";

    /// <summary>
    /// Name of the upgrade, e.g., &amp;quot;k8s_control_plane&amp;quot;. It should be a valid upgrade name. It must not exceet 99 characters.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Version of the upgrade, e.g., &amp;quot;1.22.1-gke.100&amp;quot;. It should be a valid version. It must not exceet 99 characters.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Version is required")]
    public required TerraformValue<string> Version
    {
        get => GetRequiredArgument<TerraformValue<string>>("version");
        set => SetArgument("version", value);
    }

}

/// <summary>
/// Block type for post_conditions in GoogleGkeHubFeatureSpecBlockClusterupgradeBlock.
/// Nesting mode: list
/// </summary>
public class GoogleGkeHubFeatureSpecBlockClusterupgradeBlockPostConditionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "post_conditions";

    /// <summary>
    /// Amount of time to &amp;quot;soak&amp;quot; after a rollout has been finished before marking it COMPLETE. Cannot exceed 30 days.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Soaking is required")]
    public required TerraformValue<string> Soaking
    {
        get => GetRequiredArgument<TerraformValue<string>>("soaking");
        set => SetArgument("soaking", value);
    }

}

/// <summary>
/// Block type for fleetobservability in GoogleGkeHubFeatureSpecBlock.
/// Nesting mode: list
/// </summary>
public class GoogleGkeHubFeatureSpecBlockFleetobservabilityBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "fleetobservability";

    /// <summary>
    /// LoggingConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LoggingConfig block(s) allowed")]
    public TerraformList<GoogleGkeHubFeatureSpecBlockFleetobservabilityBlockLoggingConfigBlock>? LoggingConfig
    {
        get => GetArgument<TerraformList<GoogleGkeHubFeatureSpecBlockFleetobservabilityBlockLoggingConfigBlock>>("logging_config");
        set => SetArgument("logging_config", value);
    }

}

/// <summary>
/// Block type for logging_config in GoogleGkeHubFeatureSpecBlockFleetobservabilityBlock.
/// Nesting mode: list
/// </summary>
public class GoogleGkeHubFeatureSpecBlockFleetobservabilityBlockLoggingConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "logging_config";

    /// <summary>
    /// DefaultConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DefaultConfig block(s) allowed")]
    public TerraformList<GoogleGkeHubFeatureSpecBlockFleetobservabilityBlockLoggingConfigBlockDefaultConfigBlock>? DefaultConfig
    {
        get => GetArgument<TerraformList<GoogleGkeHubFeatureSpecBlockFleetobservabilityBlockLoggingConfigBlockDefaultConfigBlock>>("default_config");
        set => SetArgument("default_config", value);
    }

    /// <summary>
    /// FleetScopeLogsConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FleetScopeLogsConfig block(s) allowed")]
    public TerraformList<GoogleGkeHubFeatureSpecBlockFleetobservabilityBlockLoggingConfigBlockFleetScopeLogsConfigBlock>? FleetScopeLogsConfig
    {
        get => GetArgument<TerraformList<GoogleGkeHubFeatureSpecBlockFleetobservabilityBlockLoggingConfigBlockFleetScopeLogsConfigBlock>>("fleet_scope_logs_config");
        set => SetArgument("fleet_scope_logs_config", value);
    }

}

/// <summary>
/// Block type for default_config in GoogleGkeHubFeatureSpecBlockFleetobservabilityBlockLoggingConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleGkeHubFeatureSpecBlockFleetobservabilityBlockLoggingConfigBlockDefaultConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "default_config";

    /// <summary>
    /// Specified if fleet logging feature is enabled. Possible values: [&amp;quot;MODE_UNSPECIFIED&amp;quot;, &amp;quot;COPY&amp;quot;, &amp;quot;MOVE&amp;quot;]
    /// </summary>
    public TerraformValue<string>? Mode
    {
        get => GetArgument<TerraformValue<string>>("mode");
        set => SetArgument("mode", value);
    }

}

/// <summary>
/// Block type for fleet_scope_logs_config in GoogleGkeHubFeatureSpecBlockFleetobservabilityBlockLoggingConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleGkeHubFeatureSpecBlockFleetobservabilityBlockLoggingConfigBlockFleetScopeLogsConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "fleet_scope_logs_config";

    /// <summary>
    /// Specified if fleet logging feature is enabled. Possible values: [&amp;quot;MODE_UNSPECIFIED&amp;quot;, &amp;quot;COPY&amp;quot;, &amp;quot;MOVE&amp;quot;]
    /// </summary>
    public TerraformValue<string>? Mode
    {
        get => GetArgument<TerraformValue<string>>("mode");
        set => SetArgument("mode", value);
    }

}

/// <summary>
/// Block type for multiclusteringress in GoogleGkeHubFeatureSpecBlock.
/// Nesting mode: list
/// </summary>
public class GoogleGkeHubFeatureSpecBlockMulticlusteringressBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "multiclusteringress";

    /// <summary>
    /// Fully-qualified Membership name which hosts the MultiClusterIngress CRD. Example: &#39;projects/foo-proj/locations/global/memberships/bar&#39;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConfigMembership is required")]
    public required TerraformValue<string> ConfigMembership
    {
        get => GetRequiredArgument<TerraformValue<string>>("config_membership");
        set => SetArgument("config_membership", value);
    }

}

/// <summary>
/// Block type for rbacrolebindingactuation in GoogleGkeHubFeatureSpecBlock.
/// Nesting mode: list
/// </summary>
public class GoogleGkeHubFeatureSpecBlockRbacrolebindingactuationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "rbacrolebindingactuation";

    /// <summary>
    /// The list of allowed custom roles (ClusterRoles). If a custom role is not part of this list, it cannot be used in a fleet scope RBACRoleBinding. If a custom role in this list is in use, it cannot be removed from the list until the scope RBACRolebindings using it are deleted.
    /// </summary>
    public TerraformList<string>? AllowedCustomRoles
    {
        get => GetArgument<TerraformList<string>>("allowed_custom_roles");
        set => SetArgument("allowed_custom_roles", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleGkeHubFeature.
/// Nesting mode: single
/// </summary>
public class GoogleGkeHubFeatureTimeoutsBlock : TerraformBlock
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
/// Represents a google_gke_hub_feature Terraform resource.
/// Manages a google_gke_hub_feature resource.
/// </summary>
public partial class GoogleGkeHubFeature(string name) : TerraformResource("google_gke_hub_feature", name)
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
    /// GCP labels for this Feature.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public TerraformMap<string>? Labels
    {
        get => GetArgument<TerraformMap<string>>("labels");
        set => SetArgument("labels", value);
    }

    /// <summary>
    /// The location for the resource
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetRequiredArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The full, unique name of this Feature resource
    /// </summary>
    public TerraformValue<string>? Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => GetArgument<TerraformValue<string>>("project") ?? CreateReference("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// Output only. When the Feature resource was created.
    /// </summary>
    public TerraformValue<string> CreateTime
        => CreateReference("create_time");

    /// <summary>
    /// Output only. When the Feature resource was deleted.
    /// </summary>
    public TerraformValue<string> DeleteTime
        => CreateReference("delete_time");

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveLabels
        => CreateReference("effective_labels");

    /// <summary>
    /// State of the Feature resource itself.
    /// </summary>
    public TerraformList<TerraformMap<object>> ResourceState
        => CreateReference("resource_state");

    /// <summary>
    /// Output only. The Hub-wide Feature state
    /// </summary>
    public TerraformList<TerraformMap<object>> State
        => CreateReference("state");

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformMap<string> TerraformLabels
        => CreateReference("terraform_labels");

    /// <summary>
    /// Output only. When the Feature resource was last updated.
    /// </summary>
    public TerraformValue<string> UpdateTime
        => CreateReference("update_time");

    /// <summary>
    /// FleetDefaultMemberConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FleetDefaultMemberConfig block(s) allowed")]
    public TerraformList<GoogleGkeHubFeatureFleetDefaultMemberConfigBlock>? FleetDefaultMemberConfig
    {
        get => GetArgument<TerraformList<GoogleGkeHubFeatureFleetDefaultMemberConfigBlock>>("fleet_default_member_config");
        set => SetArgument("fleet_default_member_config", value);
    }

    /// <summary>
    /// Spec block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Spec block(s) allowed")]
    public TerraformList<GoogleGkeHubFeatureSpecBlock>? Spec
    {
        get => GetArgument<TerraformList<GoogleGkeHubFeatureSpecBlock>>("spec");
        set => SetArgument("spec", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleGkeHubFeatureTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleGkeHubFeatureTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
