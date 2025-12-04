using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for properties in GoogleOracleDatabaseCloudVmCluster.
/// Nesting mode: list
/// </summary>
public class GoogleOracleDatabaseCloudVmClusterPropertiesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "properties";

    /// <summary>
    /// OCI Cluster name.
    /// </summary>
    public TerraformValue<string>? ClusterName
    {
        get => GetArgument<TerraformValue<string>>("cluster_name");
        set => SetArgument("cluster_name", value);
    }

    /// <summary>
    /// Compartment ID of cluster.
    /// </summary>
    public TerraformValue<string> CompartmentId
        => AsReference("compartment_id");

    /// <summary>
    /// Number of enabled CPU cores.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CpuCoreCount is required")]
    public required TerraformValue<double> CpuCoreCount
    {
        get => GetArgument<TerraformValue<double>>("cpu_core_count");
        set => SetArgument("cpu_core_count", value);
    }

    /// <summary>
    /// The data disk group size to be allocated in TBs.
    /// </summary>
    public TerraformValue<double>? DataStorageSizeTb
    {
        get => GetArgument<TerraformValue<double>>("data_storage_size_tb");
        set => SetArgument("data_storage_size_tb", value);
    }

    /// <summary>
    /// Local storage per VM
    /// </summary>
    public TerraformValue<double>? DbNodeStorageSizeGb
    {
        get => GetArgument<TerraformValue<double>>("db_node_storage_size_gb");
        set => SetArgument("db_node_storage_size_gb", value);
    }

    /// <summary>
    /// OCID of database servers.
    /// </summary>
    public TerraformList<string>? DbServerOcids
    {
        get => GetArgument<TerraformList<string>>("db_server_ocids");
        set => SetArgument("db_server_ocids", value);
    }

    /// <summary>
    /// The type of redundancy. 
    ///  Possible values:
    ///  DISK_REDUNDANCY_UNSPECIFIED
    /// HIGH
    /// NORMAL
    /// </summary>
    public TerraformValue<string>? DiskRedundancy
    {
        get => GetArgument<TerraformValue<string>>("disk_redundancy");
        set => SetArgument("disk_redundancy", value);
    }

    /// <summary>
    /// DNS listener IP.
    /// </summary>
    public TerraformValue<string> DnsListenerIp
        => AsReference("dns_listener_ip");

    /// <summary>
    /// Parent DNS domain where SCAN DNS and hosts names are qualified.
    /// ex: ocispdelegated.ocisp10jvnet.oraclevcn.com
    /// </summary>
    public TerraformValue<string> Domain
        => AsReference("domain");

    /// <summary>
    /// Grid Infrastructure Version.
    /// </summary>
    public TerraformValue<string>? GiVersion
    {
        get => GetArgument<TerraformValue<string>>("gi_version");
        set => SetArgument("gi_version", value);
    }

    /// <summary>
    /// host name without domain.
    /// format: &amp;quot;-&amp;quot; with some suffix.
    /// ex: sp2-yi0xq where &amp;quot;sp2&amp;quot; is the hostname_prefix.
    /// </summary>
    public TerraformValue<string> Hostname
        => AsReference("hostname");

    /// <summary>
    /// Prefix for VM cluster host names.
    /// </summary>
    public TerraformValue<string>? HostnamePrefix
    {
        get => GetArgument<TerraformValue<string>>("hostname_prefix");
        set => SetArgument("hostname_prefix", value);
    }

    /// <summary>
    /// License type of VM Cluster. 
    ///  Possible values:
    ///  LICENSE_TYPE_UNSPECIFIED
    /// LICENSE_INCLUDED
    /// BRING_YOUR_OWN_LICENSE
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LicenseType is required")]
    public required TerraformValue<string> LicenseType
    {
        get => GetArgument<TerraformValue<string>>("license_type");
        set => SetArgument("license_type", value);
    }

    /// <summary>
    /// Use local backup.
    /// </summary>
    public TerraformValue<bool>? LocalBackupEnabled
    {
        get => GetArgument<TerraformValue<bool>>("local_backup_enabled");
        set => SetArgument("local_backup_enabled", value);
    }

    /// <summary>
    /// Memory allocated in GBs.
    /// </summary>
    public TerraformValue<double>? MemorySizeGb
    {
        get => GetArgument<TerraformValue<double>>("memory_size_gb");
        set => SetArgument("memory_size_gb", value);
    }

    /// <summary>
    /// Number of database servers.
    /// </summary>
    public TerraformValue<double>? NodeCount
    {
        get => GetArgument<TerraformValue<double>>("node_count");
        set => SetArgument("node_count", value);
    }

    /// <summary>
    /// Deep link to the OCI console to view this resource.
    /// </summary>
    public TerraformValue<string> OciUrl
        => AsReference("oci_url");

    /// <summary>
    /// Oracle Cloud Infrastructure ID of VM Cluster.
    /// </summary>
    public TerraformValue<string> Ocid
        => AsReference("ocid");

    /// <summary>
    /// OCPU count per VM. Minimum is 0.1.
    /// </summary>
    public TerraformValue<double>? OcpuCount
    {
        get => GetArgument<TerraformValue<double>>("ocpu_count");
        set => SetArgument("ocpu_count", value);
    }

    /// <summary>
    /// SCAN DNS name.
    /// ex: sp2-yi0xq-scan.ocispdelegated.ocisp10jvnet.oraclevcn.com
    /// </summary>
    public TerraformValue<string> ScanDns
        => AsReference("scan_dns");

    /// <summary>
    /// OCID of scan DNS record.
    /// </summary>
    public TerraformValue<string> ScanDnsRecordId
        => AsReference("scan_dns_record_id");

    /// <summary>
    /// OCIDs of scan IPs.
    /// </summary>
    public TerraformList<string> ScanIpIds
        => AsReference("scan_ip_ids");

    /// <summary>
    /// SCAN listener port - TCP
    /// </summary>
    public TerraformValue<double> ScanListenerPortTcp
        => AsReference("scan_listener_port_tcp");

    /// <summary>
    /// SCAN listener port - TLS
    /// </summary>
    public TerraformValue<double> ScanListenerPortTcpSsl
        => AsReference("scan_listener_port_tcp_ssl");

    /// <summary>
    /// Shape of VM Cluster.
    /// </summary>
    public TerraformValue<string> Shape
        => AsReference("shape");

    /// <summary>
    /// Use exadata sparse snapshots.
    /// </summary>
    public TerraformValue<bool>? SparseDiskgroupEnabled
    {
        get => GetArgument<TerraformValue<bool>>("sparse_diskgroup_enabled");
        set => SetArgument("sparse_diskgroup_enabled", value);
    }

    /// <summary>
    /// SSH public keys to be stored with cluster.
    /// </summary>
    public TerraformList<string>? SshPublicKeys
    {
        get => GetArgument<TerraformList<string>>("ssh_public_keys");
        set => SetArgument("ssh_public_keys", value);
    }

    /// <summary>
    /// State of the cluster. 
    ///  Possible values:
    ///  STATE_UNSPECIFIED
    /// PROVISIONING
    /// AVAILABLE
    /// UPDATING
    /// TERMINATING
    /// TERMINATED
    /// FAILED
    /// MAINTENANCE_IN_PROGRESS
    /// </summary>
    public TerraformValue<string> State
        => AsReference("state");

    /// <summary>
    /// The storage allocation for the disk group, in gigabytes (GB).
    /// </summary>
    public TerraformValue<double> StorageSizeGb
        => AsReference("storage_size_gb");

    /// <summary>
    /// Operating system version of the image.
    /// </summary>
    public TerraformValue<string> SystemVersion
        => AsReference("system_version");

    /// <summary>
    /// DiagnosticsDataCollectionOptions block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DiagnosticsDataCollectionOptions block(s) allowed")]
    public TerraformList<GoogleOracleDatabaseCloudVmClusterPropertiesBlockDiagnosticsDataCollectionOptionsBlock>? DiagnosticsDataCollectionOptions
    {
        get => GetArgument<TerraformList<GoogleOracleDatabaseCloudVmClusterPropertiesBlockDiagnosticsDataCollectionOptionsBlock>>("diagnostics_data_collection_options");
        set => SetArgument("diagnostics_data_collection_options", value);
    }

    /// <summary>
    /// TimeZone block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TimeZone block(s) allowed")]
    public TerraformList<GoogleOracleDatabaseCloudVmClusterPropertiesBlockTimeZoneBlock>? TimeZone
    {
        get => GetArgument<TerraformList<GoogleOracleDatabaseCloudVmClusterPropertiesBlockTimeZoneBlock>>("time_zone");
        set => SetArgument("time_zone", value);
    }

}

/// <summary>
/// Block type for diagnostics_data_collection_options in GoogleOracleDatabaseCloudVmClusterPropertiesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleOracleDatabaseCloudVmClusterPropertiesBlockDiagnosticsDataCollectionOptionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "diagnostics_data_collection_options";

    /// <summary>
    /// Indicates whether diagnostic collection is enabled for the VM cluster
    /// </summary>
    public TerraformValue<bool>? DiagnosticsEventsEnabled
    {
        get => GetArgument<TerraformValue<bool>>("diagnostics_events_enabled");
        set => SetArgument("diagnostics_events_enabled", value);
    }

    /// <summary>
    /// Indicates whether health monitoring is enabled for the VM cluster
    /// </summary>
    public TerraformValue<bool>? HealthMonitoringEnabled
    {
        get => GetArgument<TerraformValue<bool>>("health_monitoring_enabled");
        set => SetArgument("health_monitoring_enabled", value);
    }

    /// <summary>
    /// Indicates whether incident logs and trace collection are enabled for the VM
    /// cluster
    /// </summary>
    public TerraformValue<bool>? IncidentLogsEnabled
    {
        get => GetArgument<TerraformValue<bool>>("incident_logs_enabled");
        set => SetArgument("incident_logs_enabled", value);
    }

}

/// <summary>
/// Block type for time_zone in GoogleOracleDatabaseCloudVmClusterPropertiesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleOracleDatabaseCloudVmClusterPropertiesBlockTimeZoneBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "time_zone";

    /// <summary>
    /// IANA Time Zone Database time zone, e.g. &amp;quot;America/New_York&amp;quot;.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleOracleDatabaseCloudVmCluster.
/// Nesting mode: single
/// </summary>
public class GoogleOracleDatabaseCloudVmClusterTimeoutsBlock : TerraformBlock
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
/// Represents a google_oracle_database_cloud_vm_cluster Terraform resource.
/// Manages a google_oracle_database_cloud_vm_cluster resource.
/// </summary>
public partial class GoogleOracleDatabaseCloudVmCluster(string name) : TerraformResource("google_oracle_database_cloud_vm_cluster", name)
{
    /// <summary>
    /// The name of the backup OdbSubnet associated with the VM Cluster.
    /// Format:
    /// projects/{project}/locations/{location}/odbNetworks/{odb_network}/odbSubnets/{odb_subnet}
    /// </summary>
    public TerraformValue<string>? BackupOdbSubnet
    {
        get => GetArgument<TerraformValue<string>>("backup_odb_subnet");
        set => SetArgument("backup_odb_subnet", value);
    }

    /// <summary>
    /// CIDR range of the backup subnet.
    /// </summary>
    public TerraformValue<string>? BackupSubnetCidr
    {
        get => GetArgument<TerraformValue<string>>("backup_subnet_cidr");
        set => SetArgument("backup_subnet_cidr", value);
    }

    /// <summary>
    /// Network settings. CIDR to use for cluster IP allocation.
    /// </summary>
    public TerraformValue<string>? Cidr
    {
        get => GetArgument<TerraformValue<string>>("cidr");
        set => SetArgument("cidr", value);
    }

    /// <summary>
    /// The ID of the VM Cluster to create. This value is restricted
    /// to (^[a-z]([a-z0-9-]{0,61}[a-z0-9])?$) and must be a maximum of 63
    /// characters in length. The value must start with a letter and end with
    /// a letter or a number.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CloudVmClusterId is required")]
    public required TerraformValue<string> CloudVmClusterId
    {
        get => GetArgument<TerraformValue<string>>("cloud_vm_cluster_id");
        set => SetArgument("cloud_vm_cluster_id", value);
    }

    /// <summary>
    /// Whether Terraform will be prevented from destroying the cluster. Deleting this cluster via terraform destroy or terraform apply will only succeed if this field is false in the Terraform state.
    /// </summary>
    public TerraformValue<bool>? DeletionProtection
    {
        get => GetArgument<TerraformValue<bool>>("deletion_protection");
        set => SetArgument("deletion_protection", value);
    }

    /// <summary>
    /// User friendly name for this resource.
    /// </summary>
    public TerraformValue<string>? DisplayName
    {
        get => GetArgument<TerraformValue<string>>("display_name");
        set => SetArgument("display_name", value);
    }

    /// <summary>
    /// The name of the Exadata Infrastructure resource on which VM cluster
    /// resource is created, in the following format:
    /// projects/{project}/locations/{region}/cloudExadataInfrastuctures/{cloud_extradata_infrastructure}
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ExadataInfrastructure is required")]
    public required TerraformValue<string> ExadataInfrastructure
    {
        get => GetArgument<TerraformValue<string>>("exadata_infrastructure");
        set => SetArgument("exadata_infrastructure", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Labels or tags associated with the VM Cluster. 
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
    /// Resource ID segment making up resource &#39;name&#39;. See documentation for resource type &#39;oracledatabase.googleapis.com/DbNode&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The name of the VPC network.
    /// Format: projects/{project}/global/networks/{network}
    /// </summary>
    public TerraformValue<string>? Network
    {
        get => GetArgument<TerraformValue<string>>("network");
        set => SetArgument("network", value);
    }

    /// <summary>
    /// The name of the OdbNetwork associated with the VM Cluster.
    /// Format:
    /// projects/{project}/locations/{location}/odbNetworks/{odb_network}
    /// It is optional but if specified, this should match the parent ODBNetwork of
    /// the odb_subnet and backup_odb_subnet.
    /// </summary>
    public TerraformValue<string>? OdbNetwork
    {
        get => GetArgument<TerraformValue<string>>("odb_network");
        set => SetArgument("odb_network", value);
    }

    /// <summary>
    /// The name of the OdbSubnet associated with the VM Cluster for
    /// IP allocation. Format:
    /// projects/{project}/locations/{location}/odbNetworks/{odb_network}/odbSubnets/{odb_subnet}
    /// </summary>
    public TerraformValue<string>? OdbSubnet
    {
        get => GetArgument<TerraformValue<string>>("odb_subnet");
        set => SetArgument("odb_subnet", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string>? Project
    {
        get => GetArgument<TerraformValue<string>>("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The date and time that the VM cluster was created.
    /// </summary>
    public TerraformValue<string> CreateTime
        => AsReference("create_time");

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveLabels
        => AsReference("effective_labels");

    /// <summary>
    /// GCP location where Oracle Exadata is hosted. It is same as GCP Oracle zone
    /// of Exadata infrastructure.
    /// </summary>
    public TerraformValue<string> GcpOracleZone
        => AsReference("gcp_oracle_zone");

    /// <summary>
    /// Identifier. The name of the VM Cluster resource with the format:
    /// projects/{project}/locations/{region}/cloudVmClusters/{cloud_vm_cluster}
    /// </summary>
    public TerraformValue<string> Name
        => AsReference("name");

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformMap<string> TerraformLabels
        => AsReference("terraform_labels");

    /// <summary>
    /// Properties block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Properties block(s) allowed")]
    public TerraformList<GoogleOracleDatabaseCloudVmClusterPropertiesBlock>? Properties
    {
        get => GetArgument<TerraformList<GoogleOracleDatabaseCloudVmClusterPropertiesBlock>>("properties");
        set => SetArgument("properties", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleOracleDatabaseCloudVmClusterTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleOracleDatabaseCloudVmClusterTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
