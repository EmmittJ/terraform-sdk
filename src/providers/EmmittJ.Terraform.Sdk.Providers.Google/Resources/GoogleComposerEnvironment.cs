using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for config in GoogleComposerEnvironment.
/// Nesting mode: list
/// </summary>
public class GoogleComposerEnvironmentConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "config";

    /// <summary>
    /// The URI of the Apache Airflow Web UI hosted within this environment.
    /// </summary>
    public TerraformValue<string> AirflowUri
        => AsReference("airflow_uri");

    /// <summary>
    /// The Cloud Storage prefix of the DAGs for this environment. Although Cloud Storage objects reside in a flat namespace, a hierarchical file tree can be simulated using &#39;/&#39;-delimited object name prefixes. DAG objects for this environment reside in a simulated directory with this prefix.
    /// </summary>
    public TerraformValue<string> DagGcsPrefix
        => AsReference("dag_gcs_prefix");

    /// <summary>
    /// Optional. If true, builds performed during operations that install Python packages have only private connectivity to Google services. If false, the builds also have access to the internet.
    /// </summary>
    public TerraformValue<bool> EnablePrivateBuildsOnly
    {
        get => GetArgument<TerraformValue<bool>>("enable_private_builds_only") ?? AsReference("enable_private_builds_only");
        set => SetArgument("enable_private_builds_only", value);
    }

    /// <summary>
    /// Optional. If true, a private Composer environment will be created.
    /// </summary>
    public TerraformValue<bool> EnablePrivateEnvironment
    {
        get => GetArgument<TerraformValue<bool>>("enable_private_environment") ?? AsReference("enable_private_environment");
        set => SetArgument("enable_private_environment", value);
    }

    /// <summary>
    /// The size of the Cloud Composer environment. This field is supported for Cloud Composer environments in versions composer-2.*.*-airflow-*.*.* and newer.
    /// </summary>
    public TerraformValue<string> EnvironmentSize
    {
        get => GetArgument<TerraformValue<string>>("environment_size") ?? AsReference("environment_size");
        set => SetArgument("environment_size", value);
    }

    /// <summary>
    /// The Kubernetes Engine cluster used to run this environment.
    /// </summary>
    public TerraformValue<string> GkeCluster
        => AsReference("gke_cluster");

    /// <summary>
    /// The number of nodes in the Kubernetes Engine cluster that will be used to run this environment. This field is supported for Cloud Composer environments in versions composer-1.*.*-airflow-*.*.*.
    /// </summary>
    public TerraformValue<double> NodeCount
    {
        get => GetArgument<TerraformValue<double>>("node_count") ?? AsReference("node_count");
        set => SetArgument("node_count", value);
    }

    /// <summary>
    /// Whether high resilience is enabled or not. This field is supported for Cloud Composer environments in versions composer-2.1.15-airflow-*.*.* and newer.
    /// </summary>
    public TerraformValue<string> ResilienceMode
    {
        get => GetArgument<TerraformValue<string>>("resilience_mode") ?? AsReference("resilience_mode");
        set => SetArgument("resilience_mode", value);
    }

    /// <summary>
    /// DataRetentionConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DataRetentionConfig block(s) allowed")]
    public TerraformList<GoogleComposerEnvironmentConfigBlockDataRetentionConfigBlock>? DataRetentionConfig
    {
        get => GetArgument<TerraformList<GoogleComposerEnvironmentConfigBlockDataRetentionConfigBlock>>("data_retention_config");
        set => SetArgument("data_retention_config", value);
    }

    /// <summary>
    /// DatabaseConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DatabaseConfig block(s) allowed")]
    public TerraformList<GoogleComposerEnvironmentConfigBlockDatabaseConfigBlock>? DatabaseConfig
    {
        get => GetArgument<TerraformList<GoogleComposerEnvironmentConfigBlockDatabaseConfigBlock>>("database_config");
        set => SetArgument("database_config", value);
    }

    /// <summary>
    /// EncryptionConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EncryptionConfig block(s) allowed")]
    public TerraformList<GoogleComposerEnvironmentConfigBlockEncryptionConfigBlock>? EncryptionConfig
    {
        get => GetArgument<TerraformList<GoogleComposerEnvironmentConfigBlockEncryptionConfigBlock>>("encryption_config");
        set => SetArgument("encryption_config", value);
    }

    /// <summary>
    /// MaintenanceWindow block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MaintenanceWindow block(s) allowed")]
    public TerraformList<GoogleComposerEnvironmentConfigBlockMaintenanceWindowBlock>? MaintenanceWindow
    {
        get => GetArgument<TerraformList<GoogleComposerEnvironmentConfigBlockMaintenanceWindowBlock>>("maintenance_window");
        set => SetArgument("maintenance_window", value);
    }

    /// <summary>
    /// MasterAuthorizedNetworksConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MasterAuthorizedNetworksConfig block(s) allowed")]
    public TerraformList<GoogleComposerEnvironmentConfigBlockMasterAuthorizedNetworksConfigBlock>? MasterAuthorizedNetworksConfig
    {
        get => GetArgument<TerraformList<GoogleComposerEnvironmentConfigBlockMasterAuthorizedNetworksConfigBlock>>("master_authorized_networks_config");
        set => SetArgument("master_authorized_networks_config", value);
    }

    /// <summary>
    /// NodeConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NodeConfig block(s) allowed")]
    public TerraformList<GoogleComposerEnvironmentConfigBlockNodeConfigBlock>? NodeConfig
    {
        get => GetArgument<TerraformList<GoogleComposerEnvironmentConfigBlockNodeConfigBlock>>("node_config");
        set => SetArgument("node_config", value);
    }

    /// <summary>
    /// PrivateEnvironmentConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PrivateEnvironmentConfig block(s) allowed")]
    public TerraformList<GoogleComposerEnvironmentConfigBlockPrivateEnvironmentConfigBlock>? PrivateEnvironmentConfig
    {
        get => GetArgument<TerraformList<GoogleComposerEnvironmentConfigBlockPrivateEnvironmentConfigBlock>>("private_environment_config");
        set => SetArgument("private_environment_config", value);
    }

    /// <summary>
    /// RecoveryConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RecoveryConfig block(s) allowed")]
    public TerraformList<GoogleComposerEnvironmentConfigBlockRecoveryConfigBlock>? RecoveryConfig
    {
        get => GetArgument<TerraformList<GoogleComposerEnvironmentConfigBlockRecoveryConfigBlock>>("recovery_config");
        set => SetArgument("recovery_config", value);
    }

    /// <summary>
    /// SoftwareConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SoftwareConfig block(s) allowed")]
    public TerraformList<GoogleComposerEnvironmentConfigBlockSoftwareConfigBlock>? SoftwareConfig
    {
        get => GetArgument<TerraformList<GoogleComposerEnvironmentConfigBlockSoftwareConfigBlock>>("software_config");
        set => SetArgument("software_config", value);
    }

    /// <summary>
    /// WebServerConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WebServerConfig block(s) allowed")]
    public TerraformList<GoogleComposerEnvironmentConfigBlockWebServerConfigBlock>? WebServerConfig
    {
        get => GetArgument<TerraformList<GoogleComposerEnvironmentConfigBlockWebServerConfigBlock>>("web_server_config");
        set => SetArgument("web_server_config", value);
    }

    /// <summary>
    /// WebServerNetworkAccessControl block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WebServerNetworkAccessControl block(s) allowed")]
    public TerraformList<GoogleComposerEnvironmentConfigBlockWebServerNetworkAccessControlBlock>? WebServerNetworkAccessControl
    {
        get => GetArgument<TerraformList<GoogleComposerEnvironmentConfigBlockWebServerNetworkAccessControlBlock>>("web_server_network_access_control");
        set => SetArgument("web_server_network_access_control", value);
    }

    /// <summary>
    /// WorkloadsConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WorkloadsConfig block(s) allowed")]
    public TerraformList<GoogleComposerEnvironmentConfigBlockWorkloadsConfigBlock>? WorkloadsConfig
    {
        get => GetArgument<TerraformList<GoogleComposerEnvironmentConfigBlockWorkloadsConfigBlock>>("workloads_config");
        set => SetArgument("workloads_config", value);
    }

}

/// <summary>
/// Block type for data_retention_config in GoogleComposerEnvironmentConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComposerEnvironmentConfigBlockDataRetentionConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "data_retention_config";

    /// <summary>
    /// AirflowMetadataRetentionConfig block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleComposerEnvironmentConfigBlockDataRetentionConfigBlockAirflowMetadataRetentionConfigBlock>? AirflowMetadataRetentionConfig
    {
        get => GetArgument<TerraformList<GoogleComposerEnvironmentConfigBlockDataRetentionConfigBlockAirflowMetadataRetentionConfigBlock>>("airflow_metadata_retention_config");
        set => SetArgument("airflow_metadata_retention_config", value);
    }

    /// <summary>
    /// TaskLogsRetentionConfig block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleComposerEnvironmentConfigBlockDataRetentionConfigBlockTaskLogsRetentionConfigBlock>? TaskLogsRetentionConfig
    {
        get => GetArgument<TerraformList<GoogleComposerEnvironmentConfigBlockDataRetentionConfigBlockTaskLogsRetentionConfigBlock>>("task_logs_retention_config");
        set => SetArgument("task_logs_retention_config", value);
    }

}

/// <summary>
/// Block type for airflow_metadata_retention_config in GoogleComposerEnvironmentConfigBlockDataRetentionConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComposerEnvironmentConfigBlockDataRetentionConfigBlockAirflowMetadataRetentionConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "airflow_metadata_retention_config";

    /// <summary>
    /// How many days data should be retained for. This field is supported for Cloud Composer environments in composer 3 and newer.
    /// </summary>
    public TerraformValue<double> RetentionDays
    {
        get => GetArgument<TerraformValue<double>>("retention_days") ?? AsReference("retention_days");
        set => SetArgument("retention_days", value);
    }

    /// <summary>
    /// Whether database retention is enabled or not. This field is supported for Cloud Composer environments in composer 3 and newer.
    /// </summary>
    public TerraformValue<string> RetentionMode
    {
        get => GetArgument<TerraformValue<string>>("retention_mode") ?? AsReference("retention_mode");
        set => SetArgument("retention_mode", value);
    }

}

/// <summary>
/// Block type for task_logs_retention_config in GoogleComposerEnvironmentConfigBlockDataRetentionConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComposerEnvironmentConfigBlockDataRetentionConfigBlockTaskLogsRetentionConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "task_logs_retention_config";

    /// <summary>
    /// Whether logs in cloud logging only is enabled or not. This field is supported for Cloud Composer environments in versions composer-2.0.32-airflow-2.1.4 and newer but not in composer-3*
    /// </summary>
    public TerraformValue<string>? StorageMode
    {
        get => GetArgument<TerraformValue<string>>("storage_mode");
        set => SetArgument("storage_mode", value);
    }

}

/// <summary>
/// Block type for database_config in GoogleComposerEnvironmentConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComposerEnvironmentConfigBlockDatabaseConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "database_config";

    /// <summary>
    /// Optional. Cloud SQL machine type used by Airflow database. It has to be one of: db-n1-standard-2, db-n1-standard-4, db-n1-standard-8 or db-n1-standard-16. If not specified, db-n1-standard-2 will be used.
    /// </summary>
    public TerraformValue<string>? MachineType
    {
        get => GetArgument<TerraformValue<string>>("machine_type");
        set => SetArgument("machine_type", value);
    }

    /// <summary>
    /// Optional. Cloud SQL database preferred zone.
    /// </summary>
    public TerraformValue<string>? Zone
    {
        get => GetArgument<TerraformValue<string>>("zone");
        set => SetArgument("zone", value);
    }

}

/// <summary>
/// Block type for encryption_config in GoogleComposerEnvironmentConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComposerEnvironmentConfigBlockEncryptionConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "encryption_config";

    /// <summary>
    /// Optional. Customer-managed Encryption Key available through Google&#39;s Key Management Service. Cannot be updated.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KmsKeyName is required")]
    public required TerraformValue<string> KmsKeyName
    {
        get => GetRequiredArgument<TerraformValue<string>>("kms_key_name");
        set => SetArgument("kms_key_name", value);
    }

}

/// <summary>
/// Block type for maintenance_window in GoogleComposerEnvironmentConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComposerEnvironmentConfigBlockMaintenanceWindowBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "maintenance_window";

    /// <summary>
    /// Maintenance window end time. It is used only to calculate the duration of the maintenance window. The value for end-time must be in the future, relative to &#39;start_time&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EndTime is required")]
    public required TerraformValue<string> EndTime
    {
        get => GetRequiredArgument<TerraformValue<string>>("end_time");
        set => SetArgument("end_time", value);
    }

    /// <summary>
    /// Maintenance window recurrence. Format is a subset of RFC-5545 (https://tools.ietf.org/html/rfc5545) &#39;RRULE&#39;. The only allowed values for &#39;FREQ&#39; field are &#39;FREQ=DAILY&#39; and &#39;FREQ=WEEKLY;BYDAY=...&#39;. Example values: &#39;FREQ=WEEKLY;BYDAY=TU,WE&#39;, &#39;FREQ=DAILY&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Recurrence is required")]
    public required TerraformValue<string> Recurrence
    {
        get => GetRequiredArgument<TerraformValue<string>>("recurrence");
        set => SetArgument("recurrence", value);
    }

    /// <summary>
    /// Start time of the first recurrence of the maintenance window.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StartTime is required")]
    public required TerraformValue<string> StartTime
    {
        get => GetRequiredArgument<TerraformValue<string>>("start_time");
        set => SetArgument("start_time", value);
    }

}

/// <summary>
/// Block type for master_authorized_networks_config in GoogleComposerEnvironmentConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComposerEnvironmentConfigBlockMasterAuthorizedNetworksConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "master_authorized_networks_config";

    /// <summary>
    /// Whether or not master authorized networks is enabled.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformValue<bool> Enabled
    {
        get => GetRequiredArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// CidrBlocks block (nesting mode: set).
    /// </summary>
    public TerraformSet<GoogleComposerEnvironmentConfigBlockMasterAuthorizedNetworksConfigBlockCidrBlocksBlock>? CidrBlocks
    {
        get => GetArgument<TerraformSet<GoogleComposerEnvironmentConfigBlockMasterAuthorizedNetworksConfigBlockCidrBlocksBlock>>("cidr_blocks");
        set => SetArgument("cidr_blocks", value);
    }

}

/// <summary>
/// Block type for cidr_blocks in GoogleComposerEnvironmentConfigBlockMasterAuthorizedNetworksConfigBlock.
/// Nesting mode: set
/// </summary>
public class GoogleComposerEnvironmentConfigBlockMasterAuthorizedNetworksConfigBlockCidrBlocksBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "cidr_blocks";

    /// <summary>
    /// cidr_block must be specified in CIDR notation.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CidrBlock is required")]
    public required TerraformValue<string> CidrBlock
    {
        get => GetRequiredArgument<TerraformValue<string>>("cidr_block");
        set => SetArgument("cidr_block", value);
    }

    /// <summary>
    /// display_name is a field for users to identify CIDR blocks.
    /// </summary>
    public TerraformValue<string>? DisplayName
    {
        get => GetArgument<TerraformValue<string>>("display_name");
        set => SetArgument("display_name", value);
    }

}

/// <summary>
/// Block type for node_config in GoogleComposerEnvironmentConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComposerEnvironmentConfigBlockNodeConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "node_config";

    /// <summary>
    /// IPv4 cidr range that will be used by Composer internal components.
    /// </summary>
    public TerraformValue<string> ComposerInternalIpv4CidrBlock
    {
        get => GetArgument<TerraformValue<string>>("composer_internal_ipv4_cidr_block") ?? AsReference("composer_internal_ipv4_cidr_block");
        set => SetArgument("composer_internal_ipv4_cidr_block", value);
    }

    /// <summary>
    /// PSC (Private Service Connect) Network entry point. Customers can pre-create the Network Attachment and point Cloud Composer environment to use. It is possible to share network attachment among many environments, provided enough IP addresses are available.
    /// </summary>
    public TerraformValue<string> ComposerNetworkAttachment
    {
        get => GetArgument<TerraformValue<string>>("composer_network_attachment") ?? AsReference("composer_network_attachment");
        set => SetArgument("composer_network_attachment", value);
    }

    /// <summary>
    /// The disk size in GB used for node VMs. Minimum size is 20GB. If unspecified, defaults to 100GB. Cannot be updated. This field is supported for Cloud Composer environments in versions composer-1.*.*-airflow-*.*.*.
    /// </summary>
    public TerraformValue<double> DiskSizeGb
    {
        get => GetArgument<TerraformValue<double>>("disk_size_gb") ?? AsReference("disk_size_gb");
        set => SetArgument("disk_size_gb", value);
    }

    /// <summary>
    /// Deploys &#39;ip-masq-agent&#39; daemon set in the GKE cluster and defines nonMasqueradeCIDRs equals to pod IP range so IP masquerading is used for all destination addresses, except between pods traffic. See: https://cloud.google.com/kubernetes-engine/docs/how-to/ip-masquerade-agent
    /// </summary>
    public TerraformValue<bool> EnableIpMasqAgent
    {
        get => GetArgument<TerraformValue<bool>>("enable_ip_masq_agent") ?? AsReference("enable_ip_masq_agent");
        set => SetArgument("enable_ip_masq_agent", value);
    }

    /// <summary>
    /// The Compute Engine machine type used for cluster instances, specified as a name or relative resource name. For example: &amp;quot;projects/{project}/zones/{zone}/machineTypes/{machineType}&amp;quot;. Must belong to the enclosing environment&#39;s project and region/zone. This field is supported for Cloud Composer environments in versions composer-1.*.*-airflow-*.*.*.
    /// </summary>
    public TerraformValue<string> MachineType
    {
        get => GetArgument<TerraformValue<string>>("machine_type") ?? AsReference("machine_type");
        set => SetArgument("machine_type", value);
    }

    /// <summary>
    /// The Compute Engine machine type used for cluster instances, specified as a name or relative resource name. For example: &amp;quot;projects/{project}/zones/{zone}/machineTypes/{machineType}&amp;quot;. Must belong to the enclosing environment&#39;s project and region/zone. The network must belong to the environment&#39;s project. If unspecified, the &amp;quot;default&amp;quot; network ID in the environment&#39;s project is used. If a Custom Subnet Network is provided, subnetwork must also be provided.
    /// </summary>
    public TerraformValue<string> Network
    {
        get => GetArgument<TerraformValue<string>>("network") ?? AsReference("network");
        set => SetArgument("network", value);
    }

    /// <summary>
    /// The set of Google API scopes to be made available on all node VMs. Cannot be updated. If empty, defaults to [&amp;quot;https://www.googleapis.com/auth/cloud-platform&amp;quot;]. This field is supported for Cloud Composer environments in versions composer-1.*.*-airflow-*.*.*.
    /// </summary>
    public TerraformSet<string> OauthScopes
    {
        get => GetArgument<TerraformSet<string>>("oauth_scopes") ?? AsReference("oauth_scopes");
        set => SetArgument("oauth_scopes", value);
    }

    /// <summary>
    /// The Google Cloud Platform Service Account to be used by the node VMs. If a service account is not specified, the &amp;quot;default&amp;quot; Compute Engine service account is used. Cannot be updated. If given, note that the service account must have roles/composer.worker for any GCP resources created under the Cloud Composer Environment.
    /// </summary>
    public TerraformValue<string> ServiceAccount
    {
        get => GetArgument<TerraformValue<string>>("service_account") ?? AsReference("service_account");
        set => SetArgument("service_account", value);
    }

    /// <summary>
    /// The Compute Engine subnetwork to be used for machine communications, specified as a self-link, relative resource name (e.g. &amp;quot;projects/{project}/regions/{region}/subnetworks/{subnetwork}&amp;quot;), or by name. If subnetwork is provided, network must also be provided and the subnetwork must belong to the enclosing environment&#39;s project and region.
    /// </summary>
    public TerraformValue<string> Subnetwork
    {
        get => GetArgument<TerraformValue<string>>("subnetwork") ?? AsReference("subnetwork");
        set => SetArgument("subnetwork", value);
    }

    /// <summary>
    /// The list of instance tags applied to all node VMs. Tags are used to identify valid sources or targets for network firewalls. Each tag within the list must comply with RFC1035. Cannot be updated.
    /// </summary>
    public TerraformSet<string>? Tags
    {
        get => GetArgument<TerraformSet<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The Compute Engine zone in which to deploy the VMs running the Apache Airflow software, specified as the zone name or relative resource name (e.g. &amp;quot;projects/{project}/zones/{zone}&amp;quot;). Must belong to the enclosing environment&#39;s project and region. This field is supported for Cloud Composer environments in versions composer-1.*.*-airflow-*.*.*.
    /// </summary>
    public TerraformValue<string> Zone
    {
        get => GetArgument<TerraformValue<string>>("zone") ?? AsReference("zone");
        set => SetArgument("zone", value);
    }

    /// <summary>
    /// IpAllocationPolicy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IpAllocationPolicy block(s) allowed")]
    public TerraformList<GoogleComposerEnvironmentConfigBlockNodeConfigBlockIpAllocationPolicyBlock>? IpAllocationPolicy
    {
        get => GetArgument<TerraformList<GoogleComposerEnvironmentConfigBlockNodeConfigBlockIpAllocationPolicyBlock>>("ip_allocation_policy");
        set => SetArgument("ip_allocation_policy", value);
    }

}

/// <summary>
/// Block type for ip_allocation_policy in GoogleComposerEnvironmentConfigBlockNodeConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComposerEnvironmentConfigBlockNodeConfigBlockIpAllocationPolicyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ip_allocation_policy";

    /// <summary>
    /// The IP address range used to allocate IP addresses to pods in the cluster. For Cloud Composer environments in versions composer-1.*.*-airflow-*.*.*, this field is applicable only when use_ip_aliases is true. Set to blank to have GKE choose a range with the default size. Set to /netmask (e.g. /14) to have GKE choose a range with a specific netmask. Set to a CIDR notation (e.g. 10.96.0.0/14) from the RFC-1918 private networks (e.g. 10.0.0.0/8, 172.16.0.0/12, 192.168.0.0/16) to pick a specific range to use. Specify either cluster_secondary_range_name or cluster_ipv4_cidr_block but not both.
    /// </summary>
    public TerraformValue<string>? ClusterIpv4CidrBlock
    {
        get => GetArgument<TerraformValue<string>>("cluster_ipv4_cidr_block");
        set => SetArgument("cluster_ipv4_cidr_block", value);
    }

    /// <summary>
    /// The name of the cluster&#39;s secondary range used to allocate IP addresses to pods. Specify either cluster_secondary_range_name or cluster_ipv4_cidr_block but not both. For Cloud Composer environments in versions composer-1.*.*-airflow-*.*.*, this field is applicable only when use_ip_aliases is true.
    /// </summary>
    public TerraformValue<string>? ClusterSecondaryRangeName
    {
        get => GetArgument<TerraformValue<string>>("cluster_secondary_range_name");
        set => SetArgument("cluster_secondary_range_name", value);
    }

    /// <summary>
    /// The IP address range used to allocate IP addresses in this cluster. For Cloud Composer environments in versions composer-1.*.*-airflow-*.*.*, this field is applicable only when use_ip_aliases is true. Set to blank to have GKE choose a range with the default size. Set to /netmask (e.g. /14) to have GKE choose a range with a specific netmask. Set to a CIDR notation (e.g. 10.96.0.0/14) from the RFC-1918 private networks (e.g. 10.0.0.0/8, 172.16.0.0/12, 192.168.0.0/16) to pick a specific range to use. Specify either services_secondary_range_name or services_ipv4_cidr_block but not both.
    /// </summary>
    public TerraformValue<string>? ServicesIpv4CidrBlock
    {
        get => GetArgument<TerraformValue<string>>("services_ipv4_cidr_block");
        set => SetArgument("services_ipv4_cidr_block", value);
    }

    /// <summary>
    /// The name of the services&#39; secondary range used to allocate IP addresses to the cluster. Specify either services_secondary_range_name or services_ipv4_cidr_block but not both. For Cloud Composer environments in versions composer-1.*.*-airflow-*.*.*, this field is applicable only when use_ip_aliases is true.
    /// </summary>
    public TerraformValue<string>? ServicesSecondaryRangeName
    {
        get => GetArgument<TerraformValue<string>>("services_secondary_range_name");
        set => SetArgument("services_secondary_range_name", value);
    }

    /// <summary>
    /// Whether or not to enable Alias IPs in the GKE cluster. If true, a VPC-native cluster is created. Defaults to true if the ip_allocation_policy block is present in config. This field is only supported for Cloud Composer environments in versions composer-1.*.*-airflow-*.*.*. Environments in newer versions always use VPC-native GKE clusters.
    /// </summary>
    public TerraformValue<bool>? UseIpAliases
    {
        get => GetArgument<TerraformValue<bool>>("use_ip_aliases");
        set => SetArgument("use_ip_aliases", value);
    }

}

/// <summary>
/// Block type for private_environment_config in GoogleComposerEnvironmentConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComposerEnvironmentConfigBlockPrivateEnvironmentConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "private_environment_config";

    /// <summary>
    /// When specified, the environment will use Private Service Connect instead of VPC peerings to connect to Cloud SQL in the Tenant Project, and the PSC endpoint in the Customer Project will use an IP address from this subnetwork. This field is supported for Cloud Composer environments in versions composer-2.*.*-airflow-*.*.* and newer.
    /// </summary>
    public TerraformValue<string> CloudComposerConnectionSubnetwork
    {
        get => GetArgument<TerraformValue<string>>("cloud_composer_connection_subnetwork") ?? AsReference("cloud_composer_connection_subnetwork");
        set => SetArgument("cloud_composer_connection_subnetwork", value);
    }

    /// <summary>
    /// The CIDR block from which IP range for Cloud Composer Network in tenant project will be reserved. Needs to be disjoint from private_cluster_config.master_ipv4_cidr_block and cloud_sql_ipv4_cidr_block. This field is supported for Cloud Composer environments in versions composer-2.*.*-airflow-*.*.* and newer.
    /// </summary>
    public TerraformValue<string> CloudComposerNetworkIpv4CidrBlock
    {
        get => GetArgument<TerraformValue<string>>("cloud_composer_network_ipv4_cidr_block") ?? AsReference("cloud_composer_network_ipv4_cidr_block");
        set => SetArgument("cloud_composer_network_ipv4_cidr_block", value);
    }

    /// <summary>
    /// The CIDR block from which IP range in tenant project will be reserved for Cloud SQL. Needs to be disjoint from web_server_ipv4_cidr_block.
    /// </summary>
    public TerraformValue<string> CloudSqlIpv4CidrBlock
    {
        get => GetArgument<TerraformValue<string>>("cloud_sql_ipv4_cidr_block") ?? AsReference("cloud_sql_ipv4_cidr_block");
        set => SetArgument("cloud_sql_ipv4_cidr_block", value);
    }

    /// <summary>
    /// Mode of internal communication within the Composer environment. Must be one of &amp;quot;VPC_PEERING&amp;quot; or &amp;quot;PRIVATE_SERVICE_CONNECT&amp;quot;.
    /// </summary>
    public TerraformValue<string> ConnectionType
    {
        get => GetArgument<TerraformValue<string>>("connection_type") ?? AsReference("connection_type");
        set => SetArgument("connection_type", value);
    }

    /// <summary>
    /// If true, access to the public endpoint of the GKE cluster is denied. If this field is set to true, ip_allocation_policy.use_ip_aliases must be set to true for Cloud Composer environments in versions composer-1.*.*-airflow-*.*.*.
    /// </summary>
    public TerraformValue<bool>? EnablePrivateEndpoint
    {
        get => GetArgument<TerraformValue<bool>>("enable_private_endpoint");
        set => SetArgument("enable_private_endpoint", value);
    }

    /// <summary>
    /// When enabled, IPs from public (non-RFC1918) ranges can be used for ip_allocation_policy.cluster_ipv4_cidr_block and ip_allocation_policy.service_ipv4_cidr_block.
    /// </summary>
    public TerraformValue<bool> EnablePrivatelyUsedPublicIps
    {
        get => GetArgument<TerraformValue<bool>>("enable_privately_used_public_ips") ?? AsReference("enable_privately_used_public_ips");
        set => SetArgument("enable_privately_used_public_ips", value);
    }

    /// <summary>
    /// The IP range in CIDR notation to use for the hosted master network. This range is used for assigning internal IP addresses to the cluster master or set of masters and to the internal load balancer virtual IP. This range must not overlap with any other ranges in use within the cluster&#39;s network. If left blank, the default value of &#39;172.16.0.0/28&#39; is used.
    /// </summary>
    public TerraformValue<string> MasterIpv4CidrBlock
    {
        get => GetArgument<TerraformValue<string>>("master_ipv4_cidr_block") ?? AsReference("master_ipv4_cidr_block");
        set => SetArgument("master_ipv4_cidr_block", value);
    }

    /// <summary>
    /// The CIDR block from which IP range for web server will be reserved. Needs to be disjoint from master_ipv4_cidr_block and cloud_sql_ipv4_cidr_block. This field is supported for Cloud Composer environments in versions composer-1.*.*-airflow-*.*.*.
    /// </summary>
    public TerraformValue<string> WebServerIpv4CidrBlock
    {
        get => GetArgument<TerraformValue<string>>("web_server_ipv4_cidr_block") ?? AsReference("web_server_ipv4_cidr_block");
        set => SetArgument("web_server_ipv4_cidr_block", value);
    }

}

/// <summary>
/// Block type for recovery_config in GoogleComposerEnvironmentConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComposerEnvironmentConfigBlockRecoveryConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "recovery_config";

    /// <summary>
    /// ScheduledSnapshotsConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ScheduledSnapshotsConfig block(s) allowed")]
    public TerraformList<GoogleComposerEnvironmentConfigBlockRecoveryConfigBlockScheduledSnapshotsConfigBlock>? ScheduledSnapshotsConfig
    {
        get => GetArgument<TerraformList<GoogleComposerEnvironmentConfigBlockRecoveryConfigBlockScheduledSnapshotsConfigBlock>>("scheduled_snapshots_config");
        set => SetArgument("scheduled_snapshots_config", value);
    }

}

/// <summary>
/// Block type for scheduled_snapshots_config in GoogleComposerEnvironmentConfigBlockRecoveryConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComposerEnvironmentConfigBlockRecoveryConfigBlockScheduledSnapshotsConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "scheduled_snapshots_config";

    /// <summary>
    /// When enabled, Cloud Composer periodically saves snapshots of your environment to a Cloud Storage bucket.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformValue<bool> Enabled
    {
        get => GetRequiredArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// Snapshot schedule, in the unix-cron format.
    /// </summary>
    public TerraformValue<string>? SnapshotCreationSchedule
    {
        get => GetArgument<TerraformValue<string>>("snapshot_creation_schedule");
        set => SetArgument("snapshot_creation_schedule", value);
    }

    /// <summary>
    /// the URI of a bucket folder where to save the snapshot.
    /// </summary>
    public TerraformValue<string>? SnapshotLocation
    {
        get => GetArgument<TerraformValue<string>>("snapshot_location");
        set => SetArgument("snapshot_location", value);
    }

    /// <summary>
    /// A time zone for the schedule. This value is a time offset and does not take into account daylight saving time changes. Valid values are from UTC-12 to UTC+12. Examples: UTC, UTC-01, UTC+03.
    /// </summary>
    public TerraformValue<string>? TimeZone
    {
        get => GetArgument<TerraformValue<string>>("time_zone");
        set => SetArgument("time_zone", value);
    }

}

/// <summary>
/// Block type for software_config in GoogleComposerEnvironmentConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComposerEnvironmentConfigBlockSoftwareConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "software_config";

    /// <summary>
    /// Apache Airflow configuration properties to override. Property keys contain the section and property names, separated by a hyphen, for example &amp;quot;core-dags_are_paused_at_creation&amp;quot;. Section names must not contain hyphens (&amp;quot;-&amp;quot;), opening square brackets (&amp;quot;[&amp;quot;), or closing square brackets (&amp;quot;]&amp;quot;). The property name must not be empty and cannot contain &amp;quot;=&amp;quot; or &amp;quot;;&amp;quot;. Section and property names cannot contain characters: &amp;quot;.&amp;quot; Apache Airflow configuration property names must be written in snake_case. Property values can contain any character, and can be written in any lower/upper case format. Certain Apache Airflow configuration property values are blacklisted, and cannot be overridden.
    /// </summary>
    public TerraformMap<string>? AirflowConfigOverrides
    {
        get => GetArgument<TerraformMap<string>>("airflow_config_overrides");
        set => SetArgument("airflow_config_overrides", value);
    }

    /// <summary>
    /// Additional environment variables to provide to the Apache Airflow scheduler, worker, and webserver processes. Environment variable names must match the regular expression [a-zA-Z_][a-zA-Z0-9_]*. They cannot specify Apache Airflow software configuration overrides (they cannot match the regular expression AIRFLOW__[A-Z0-9_]+__[A-Z0-9_]+), and they cannot match any of the following reserved names: AIRFLOW_HOME C_FORCE_ROOT CONTAINER_NAME DAGS_FOLDER GCP_PROJECT GCS_BUCKET GKE_CLUSTER_NAME SQL_DATABASE SQL_INSTANCE SQL_PASSWORD SQL_PROJECT SQL_REGION SQL_USER.
    /// </summary>
    public TerraformMap<string>? EnvVariables
    {
        get => GetArgument<TerraformMap<string>>("env_variables");
        set => SetArgument("env_variables", value);
    }

    /// <summary>
    /// The version of the software running in the environment. This encapsulates both the version of Cloud Composer functionality and the version of Apache Airflow. It must match the regular expression composer-([0-9]+(\.[0-9]+\.[0-9]+(-preview\.[0-9]+)?)?|latest)-airflow-([0-9]+(\.[0-9]+(\.[0-9]+)?)?). The Cloud Composer portion of the image version is a full semantic version, or an alias in the form of major version number or &#39;latest&#39;. The Apache Airflow portion of the image version is a full semantic version that points to one of the supported Apache Airflow versions, or an alias in the form of only major or major.minor versions specified. See documentation for more details and version list.
    /// </summary>
    public TerraformValue<string> ImageVersion
    {
        get => GetArgument<TerraformValue<string>>("image_version") ?? AsReference("image_version");
        set => SetArgument("image_version", value);
    }

    /// <summary>
    /// Custom Python Package Index (PyPI) packages to be installed in the environment. Keys refer to the lowercase package name (e.g. &amp;quot;numpy&amp;quot;). Values are the lowercase extras and version specifier (e.g. &amp;quot;==1.12.0&amp;quot;, &amp;quot;[devel,gcp_api]&amp;quot;, &amp;quot;[devel]&amp;gt;=1.8.2, &amp;lt;1.9.2&amp;quot;). To specify a package without pinning it to a version specifier, use the empty string as the value.
    /// </summary>
    public TerraformMap<string>? PypiPackages
    {
        get => GetArgument<TerraformMap<string>>("pypi_packages");
        set => SetArgument("pypi_packages", value);
    }

    /// <summary>
    /// The major version of Python used to run the Apache Airflow scheduler, worker, and webserver processes. Can be set to &#39;2&#39; or &#39;3&#39;. If not specified, the default is &#39;2&#39;. Cannot be updated. This field is supported for Cloud Composer environments in versions composer-1.*.*-airflow-*.*.*. Environments in newer versions always use Python major version 3.
    /// </summary>
    public TerraformValue<string> PythonVersion
    {
        get => GetArgument<TerraformValue<string>>("python_version") ?? AsReference("python_version");
        set => SetArgument("python_version", value);
    }

    /// <summary>
    /// The number of schedulers for Airflow. This field is supported for Cloud Composer environments in versions composer-1.*.*-airflow-2.*.*.
    /// </summary>
    public TerraformValue<double> SchedulerCount
    {
        get => GetArgument<TerraformValue<double>>("scheduler_count") ?? AsReference("scheduler_count");
        set => SetArgument("scheduler_count", value);
    }

    /// <summary>
    /// Should be either &#39;ENABLED&#39; or &#39;DISABLED&#39;. Defaults to &#39;ENABLED&#39;. Used in Composer 3.
    /// </summary>
    public TerraformValue<string> WebServerPluginsMode
    {
        get => GetArgument<TerraformValue<string>>("web_server_plugins_mode") ?? AsReference("web_server_plugins_mode");
        set => SetArgument("web_server_plugins_mode", value);
    }

    /// <summary>
    /// CloudDataLineageIntegration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CloudDataLineageIntegration block(s) allowed")]
    public TerraformList<GoogleComposerEnvironmentConfigBlockSoftwareConfigBlockCloudDataLineageIntegrationBlock>? CloudDataLineageIntegration
    {
        get => GetArgument<TerraformList<GoogleComposerEnvironmentConfigBlockSoftwareConfigBlockCloudDataLineageIntegrationBlock>>("cloud_data_lineage_integration");
        set => SetArgument("cloud_data_lineage_integration", value);
    }

}

/// <summary>
/// Block type for cloud_data_lineage_integration in GoogleComposerEnvironmentConfigBlockSoftwareConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComposerEnvironmentConfigBlockSoftwareConfigBlockCloudDataLineageIntegrationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "cloud_data_lineage_integration";

    /// <summary>
    /// Whether or not Cloud Data Lineage integration is enabled.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformValue<bool> Enabled
    {
        get => GetRequiredArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

}

/// <summary>
/// Block type for web_server_config in GoogleComposerEnvironmentConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComposerEnvironmentConfigBlockWebServerConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "web_server_config";

    /// <summary>
    /// Optional. Machine type on which Airflow web server is running. It has to be one of: composer-n1-webserver-2, composer-n1-webserver-4 or composer-n1-webserver-8. If not specified, composer-n1-webserver-2 will be used. Value custom is returned only in response, if Airflow web server parameters were manually changed to a non-standard values.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MachineType is required")]
    public required TerraformValue<string> MachineType
    {
        get => GetRequiredArgument<TerraformValue<string>>("machine_type");
        set => SetArgument("machine_type", value);
    }

}

/// <summary>
/// Block type for web_server_network_access_control in GoogleComposerEnvironmentConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComposerEnvironmentConfigBlockWebServerNetworkAccessControlBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "web_server_network_access_control";

    /// <summary>
    /// AllowedIpRange block (nesting mode: set).
    /// </summary>
    public TerraformSet<GoogleComposerEnvironmentConfigBlockWebServerNetworkAccessControlBlockAllowedIpRangeBlock>? AllowedIpRange
    {
        get => GetArgument<TerraformSet<GoogleComposerEnvironmentConfigBlockWebServerNetworkAccessControlBlockAllowedIpRangeBlock>>("allowed_ip_range");
        set => SetArgument("allowed_ip_range", value);
    }

}

/// <summary>
/// Block type for allowed_ip_range in GoogleComposerEnvironmentConfigBlockWebServerNetworkAccessControlBlock.
/// Nesting mode: set
/// </summary>
public class GoogleComposerEnvironmentConfigBlockWebServerNetworkAccessControlBlockAllowedIpRangeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "allowed_ip_range";

    /// <summary>
    /// A description of this ip range.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// IP address or range, defined using CIDR notation, of requests that this rule applies to. Examples: 192.168.1.1 or 192.168.0.0/16 or 2001:db8::/32 or 2001:0db8:0000:0042:0000:8a2e:0370:7334. IP range prefixes should be properly truncated. For example, 1.2.3.4/24 should be truncated to 1.2.3.0/24. Similarly, for IPv6, 2001:db8::1/32 should be truncated to 2001:db8::/32.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for workloads_config in GoogleComposerEnvironmentConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComposerEnvironmentConfigBlockWorkloadsConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "workloads_config";

    /// <summary>
    /// DagProcessor block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DagProcessor block(s) allowed")]
    public TerraformList<GoogleComposerEnvironmentConfigBlockWorkloadsConfigBlockDagProcessorBlock>? DagProcessor
    {
        get => GetArgument<TerraformList<GoogleComposerEnvironmentConfigBlockWorkloadsConfigBlockDagProcessorBlock>>("dag_processor");
        set => SetArgument("dag_processor", value);
    }

    /// <summary>
    /// Scheduler block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Scheduler block(s) allowed")]
    public TerraformList<GoogleComposerEnvironmentConfigBlockWorkloadsConfigBlockSchedulerBlock>? Scheduler
    {
        get => GetArgument<TerraformList<GoogleComposerEnvironmentConfigBlockWorkloadsConfigBlockSchedulerBlock>>("scheduler");
        set => SetArgument("scheduler", value);
    }

    /// <summary>
    /// Triggerer block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Triggerer block(s) allowed")]
    public TerraformList<GoogleComposerEnvironmentConfigBlockWorkloadsConfigBlockTriggererBlock>? Triggerer
    {
        get => GetArgument<TerraformList<GoogleComposerEnvironmentConfigBlockWorkloadsConfigBlockTriggererBlock>>("triggerer");
        set => SetArgument("triggerer", value);
    }

    /// <summary>
    /// WebServer block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WebServer block(s) allowed")]
    public TerraformList<GoogleComposerEnvironmentConfigBlockWorkloadsConfigBlockWebServerBlock>? WebServer
    {
        get => GetArgument<TerraformList<GoogleComposerEnvironmentConfigBlockWorkloadsConfigBlockWebServerBlock>>("web_server");
        set => SetArgument("web_server", value);
    }

    /// <summary>
    /// Worker block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Worker block(s) allowed")]
    public TerraformList<GoogleComposerEnvironmentConfigBlockWorkloadsConfigBlockWorkerBlock>? Worker
    {
        get => GetArgument<TerraformList<GoogleComposerEnvironmentConfigBlockWorkloadsConfigBlockWorkerBlock>>("worker");
        set => SetArgument("worker", value);
    }

}

/// <summary>
/// Block type for dag_processor in GoogleComposerEnvironmentConfigBlockWorkloadsConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComposerEnvironmentConfigBlockWorkloadsConfigBlockDagProcessorBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "dag_processor";

    /// <summary>
    /// Number of DAG processors.
    /// </summary>
    public TerraformValue<double> CountAttribute
    {
        get => GetArgument<TerraformValue<double>>("count") ?? AsReference("count");
        set => SetArgument("count", value);
    }

    /// <summary>
    /// CPU request and limit for DAG processor.
    /// </summary>
    public TerraformValue<double> Cpu
    {
        get => GetArgument<TerraformValue<double>>("cpu") ?? AsReference("cpu");
        set => SetArgument("cpu", value);
    }

    /// <summary>
    /// Memory (GB) request and limit for DAG processor.
    /// </summary>
    public TerraformValue<double> MemoryGb
    {
        get => GetArgument<TerraformValue<double>>("memory_gb") ?? AsReference("memory_gb");
        set => SetArgument("memory_gb", value);
    }

    /// <summary>
    /// Storage (GB) request and limit for DAG processor.
    /// </summary>
    public TerraformValue<double> StorageGb
    {
        get => GetArgument<TerraformValue<double>>("storage_gb") ?? AsReference("storage_gb");
        set => SetArgument("storage_gb", value);
    }

}

/// <summary>
/// Block type for scheduler in GoogleComposerEnvironmentConfigBlockWorkloadsConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComposerEnvironmentConfigBlockWorkloadsConfigBlockSchedulerBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "scheduler";

    /// <summary>
    /// The number of schedulers.
    /// </summary>
    public TerraformValue<double> CountAttribute
    {
        get => GetArgument<TerraformValue<double>>("count") ?? AsReference("count");
        set => SetArgument("count", value);
    }

    /// <summary>
    /// CPU request and limit for a single Airflow scheduler replica
    /// </summary>
    public TerraformValue<double> Cpu
    {
        get => GetArgument<TerraformValue<double>>("cpu") ?? AsReference("cpu");
        set => SetArgument("cpu", value);
    }

    /// <summary>
    /// Memory (GB) request and limit for a single Airflow scheduler replica.
    /// </summary>
    public TerraformValue<double> MemoryGb
    {
        get => GetArgument<TerraformValue<double>>("memory_gb") ?? AsReference("memory_gb");
        set => SetArgument("memory_gb", value);
    }

    /// <summary>
    /// Storage (GB) request and limit for a single Airflow scheduler replica.
    /// </summary>
    public TerraformValue<double> StorageGb
    {
        get => GetArgument<TerraformValue<double>>("storage_gb") ?? AsReference("storage_gb");
        set => SetArgument("storage_gb", value);
    }

}

/// <summary>
/// Block type for triggerer in GoogleComposerEnvironmentConfigBlockWorkloadsConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComposerEnvironmentConfigBlockWorkloadsConfigBlockTriggererBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "triggerer";

    /// <summary>
    /// The number of triggerers.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CountAttribute is required")]
    public required TerraformValue<double> CountAttribute
    {
        get => GetRequiredArgument<TerraformValue<double>>("count");
        set => SetArgument("count", value);
    }

    /// <summary>
    /// CPU request and limit for a single Airflow triggerer replica.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Cpu is required")]
    public required TerraformValue<double> Cpu
    {
        get => GetRequiredArgument<TerraformValue<double>>("cpu");
        set => SetArgument("cpu", value);
    }

    /// <summary>
    /// Memory (GB) request and limit for a single Airflow triggerer replica.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MemoryGb is required")]
    public required TerraformValue<double> MemoryGb
    {
        get => GetRequiredArgument<TerraformValue<double>>("memory_gb");
        set => SetArgument("memory_gb", value);
    }

}

/// <summary>
/// Block type for web_server in GoogleComposerEnvironmentConfigBlockWorkloadsConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComposerEnvironmentConfigBlockWorkloadsConfigBlockWebServerBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "web_server";

    /// <summary>
    /// CPU request and limit for Airflow web server.
    /// </summary>
    public TerraformValue<double> Cpu
    {
        get => GetArgument<TerraformValue<double>>("cpu") ?? AsReference("cpu");
        set => SetArgument("cpu", value);
    }

    /// <summary>
    /// Memory (GB) request and limit for Airflow web server.
    /// </summary>
    public TerraformValue<double> MemoryGb
    {
        get => GetArgument<TerraformValue<double>>("memory_gb") ?? AsReference("memory_gb");
        set => SetArgument("memory_gb", value);
    }

    /// <summary>
    /// Storage (GB) request and limit for Airflow web server.
    /// </summary>
    public TerraformValue<double> StorageGb
    {
        get => GetArgument<TerraformValue<double>>("storage_gb") ?? AsReference("storage_gb");
        set => SetArgument("storage_gb", value);
    }

}

/// <summary>
/// Block type for worker in GoogleComposerEnvironmentConfigBlockWorkloadsConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComposerEnvironmentConfigBlockWorkloadsConfigBlockWorkerBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "worker";

    /// <summary>
    /// CPU request and limit for a single Airflow worker replica.
    /// </summary>
    public TerraformValue<double> Cpu
    {
        get => GetArgument<TerraformValue<double>>("cpu") ?? AsReference("cpu");
        set => SetArgument("cpu", value);
    }

    /// <summary>
    /// Maximum number of workers for autoscaling.
    /// </summary>
    public TerraformValue<double> MaxCount
    {
        get => GetArgument<TerraformValue<double>>("max_count") ?? AsReference("max_count");
        set => SetArgument("max_count", value);
    }

    /// <summary>
    /// Memory (GB) request and limit for a single Airflow worker replica.
    /// </summary>
    public TerraformValue<double> MemoryGb
    {
        get => GetArgument<TerraformValue<double>>("memory_gb") ?? AsReference("memory_gb");
        set => SetArgument("memory_gb", value);
    }

    /// <summary>
    /// Minimum number of workers for autoscaling.
    /// </summary>
    public TerraformValue<double> MinCount
    {
        get => GetArgument<TerraformValue<double>>("min_count") ?? AsReference("min_count");
        set => SetArgument("min_count", value);
    }

    /// <summary>
    /// Storage (GB) request and limit for a single Airflow worker replica.
    /// </summary>
    public TerraformValue<double> StorageGb
    {
        get => GetArgument<TerraformValue<double>>("storage_gb") ?? AsReference("storage_gb");
        set => SetArgument("storage_gb", value);
    }

}


/// <summary>
/// Block type for storage_config in GoogleComposerEnvironment.
/// Nesting mode: list
/// </summary>
public class GoogleComposerEnvironmentStorageConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "storage_config";

    /// <summary>
    /// Optional. Name of an existing Cloud Storage bucket to be used by the environment.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Bucket is required")]
    public required TerraformValue<string> Bucket
    {
        get => GetRequiredArgument<TerraformValue<string>>("bucket");
        set => SetArgument("bucket", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleComposerEnvironment.
/// Nesting mode: single
/// </summary>
public class GoogleComposerEnvironmentTimeoutsBlock : TerraformBlock
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
/// Represents a google_composer_environment Terraform resource.
/// Manages a google_composer_environment resource.
/// </summary>
public partial class GoogleComposerEnvironment(string name) : TerraformResource("google_composer_environment", name)
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
    /// User-defined labels for this environment. The labels map can contain no more than 64 entries. Entries of the labels map are UTF8 strings that comply with the following restrictions: Label keys must be between 1 and 63 characters long and must conform to the following regular expression: [a-z]([-a-z0-9]*[a-z0-9])?. Label values must be between 0 and 63 characters long and must conform to the regular expression ([a-z]([-a-z0-9]*[a-z0-9])?)?. No more than 64 labels can be associated with a given environment. Both keys and values must be &amp;lt;= 128 bytes in size.
    /// 
    /// 				**Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// 				Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public TerraformMap<string>? Labels
    {
        get => GetArgument<TerraformMap<string>>("labels");
        set => SetArgument("labels", value);
    }

    /// <summary>
    /// Name of the environment.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The ID of the project in which the resource belongs. If it is not provided, the provider project is used.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => GetArgument<TerraformValue<string>>("project") ?? AsReference("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The location or Compute Engine region for the environment.
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? AsReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveLabels
        => AsReference("effective_labels");

    /// <summary>
    /// The combination of labels configured directly on the resource and default labels configured on the provider.
    /// </summary>
    public TerraformMap<string> TerraformLabels
        => AsReference("terraform_labels");

    /// <summary>
    /// Config block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Config block(s) allowed")]
    public TerraformList<GoogleComposerEnvironmentConfigBlock>? Config
    {
        get => GetArgument<TerraformList<GoogleComposerEnvironmentConfigBlock>>("config");
        set => SetArgument("config", value);
    }

    /// <summary>
    /// StorageConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StorageConfig block(s) allowed")]
    public TerraformList<GoogleComposerEnvironmentStorageConfigBlock>? StorageConfig
    {
        get => GetArgument<TerraformList<GoogleComposerEnvironmentStorageConfigBlock>>("storage_config");
        set => SetArgument("storage_config", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleComposerEnvironmentTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleComposerEnvironmentTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
