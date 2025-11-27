using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for alloydb in GoogleDatabaseMigrationServiceConnectionProfile.
/// Nesting mode: list
/// </summary>
public class GoogleDatabaseMigrationServiceConnectionProfileAlloydbBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "alloydb";

    /// <summary>
    /// Required. The AlloyDB cluster ID that this connection profile is associated with.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterId is required")]
    public required TerraformValue<string> ClusterId
    {
        get => new TerraformReference<string>(this, "cluster_id");
        set => SetArgument("cluster_id", value);
    }

    /// <summary>
    /// Settings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Settings block(s) allowed")]
    public TerraformList<GoogleDatabaseMigrationServiceConnectionProfileAlloydbBlockSettingsBlock>? Settings
    {
        get => GetArgument<TerraformList<GoogleDatabaseMigrationServiceConnectionProfileAlloydbBlockSettingsBlock>>("settings");
        set => SetArgument("settings", value);
    }

}

/// <summary>
/// Block type for settings in GoogleDatabaseMigrationServiceConnectionProfileAlloydbBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDatabaseMigrationServiceConnectionProfileAlloydbBlockSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "settings";

    /// <summary>
    /// Labels for the AlloyDB cluster created by DMS.
    /// </summary>
    public TerraformMap<string>? Labels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "labels").ResolveNodes(ctx));
        set => SetArgument("labels", value);
    }

    /// <summary>
    /// Required. The resource link for the VPC network in which cluster resources are created and from which they are accessible via Private IP. The network must belong to the same project as the cluster.
    /// It is specified in the form: &#39;projects/{project_number}/global/networks/{network_id}&#39;. This is required to create a cluster.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VpcNetwork is required")]
    public required TerraformValue<string> VpcNetwork
    {
        get => new TerraformReference<string>(this, "vpc_network");
        set => SetArgument("vpc_network", value);
    }

    /// <summary>
    /// InitialUser block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InitialUser is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 InitialUser block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InitialUser block(s) allowed")]
    public required TerraformList<GoogleDatabaseMigrationServiceConnectionProfileAlloydbBlockSettingsBlockInitialUserBlock> InitialUser
    {
        get => GetRequiredArgument<TerraformList<GoogleDatabaseMigrationServiceConnectionProfileAlloydbBlockSettingsBlockInitialUserBlock>>("initial_user");
        set => SetArgument("initial_user", value);
    }

    /// <summary>
    /// PrimaryInstanceSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PrimaryInstanceSettings block(s) allowed")]
    public TerraformList<GoogleDatabaseMigrationServiceConnectionProfileAlloydbBlockSettingsBlockPrimaryInstanceSettingsBlock>? PrimaryInstanceSettings
    {
        get => GetArgument<TerraformList<GoogleDatabaseMigrationServiceConnectionProfileAlloydbBlockSettingsBlockPrimaryInstanceSettingsBlock>>("primary_instance_settings");
        set => SetArgument("primary_instance_settings", value);
    }

}

/// <summary>
/// Block type for initial_user in GoogleDatabaseMigrationServiceConnectionProfileAlloydbBlockSettingsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDatabaseMigrationServiceConnectionProfileAlloydbBlockSettingsBlockInitialUserBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "initial_user";

    /// <summary>
    /// The initial password for the user.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Password is required")]
    public required TerraformValue<string> Password
    {
        get => new TerraformReference<string>(this, "password");
        set => SetArgument("password", value);
    }

    /// <summary>
    /// Output only. Indicates if the initialUser.password field has been set.
    /// </summary>
    public TerraformValue<bool> PasswordSet
    {
        get => new TerraformReference<bool>(this, "password_set");
    }

    /// <summary>
    /// The database username.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "User is required")]
    public required TerraformValue<string> User
    {
        get => new TerraformReference<string>(this, "user");
        set => SetArgument("user", value);
    }

}

/// <summary>
/// Block type for primary_instance_settings in GoogleDatabaseMigrationServiceConnectionProfileAlloydbBlockSettingsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDatabaseMigrationServiceConnectionProfileAlloydbBlockSettingsBlockPrimaryInstanceSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "primary_instance_settings";

    /// <summary>
    /// Database flags to pass to AlloyDB when DMS is creating the AlloyDB cluster and instances. See the AlloyDB documentation for how these can be used.
    /// </summary>
    public TerraformMap<string>? DatabaseFlags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "database_flags").ResolveNodes(ctx));
        set => SetArgument("database_flags", value);
    }

    /// <summary>
    /// The database username.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    public required TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Labels for the AlloyDB primary instance created by DMS.
    /// </summary>
    public TerraformMap<string>? Labels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "labels").ResolveNodes(ctx));
        set => SetArgument("labels", value);
    }

    /// <summary>
    /// Output only. The private IP address for the Instance. This is the connection endpoint for an end-user application.
    /// </summary>
    public TerraformValue<string> PrivateIp
    {
        get => new TerraformReference<string>(this, "private_ip");
    }

    /// <summary>
    /// MachineConfig block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MachineConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 MachineConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MachineConfig block(s) allowed")]
    public required TerraformList<GoogleDatabaseMigrationServiceConnectionProfileAlloydbBlockSettingsBlockPrimaryInstanceSettingsBlockMachineConfigBlock> MachineConfig
    {
        get => GetRequiredArgument<TerraformList<GoogleDatabaseMigrationServiceConnectionProfileAlloydbBlockSettingsBlockPrimaryInstanceSettingsBlockMachineConfigBlock>>("machine_config");
        set => SetArgument("machine_config", value);
    }

}

/// <summary>
/// Block type for machine_config in GoogleDatabaseMigrationServiceConnectionProfileAlloydbBlockSettingsBlockPrimaryInstanceSettingsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDatabaseMigrationServiceConnectionProfileAlloydbBlockSettingsBlockPrimaryInstanceSettingsBlockMachineConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "machine_config";

    /// <summary>
    /// The number of CPU&#39;s in the VM instance.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CpuCount is required")]
    public required TerraformValue<double> CpuCount
    {
        get => new TerraformReference<double>(this, "cpu_count");
        set => SetArgument("cpu_count", value);
    }

}


/// <summary>
/// Block type for cloudsql in GoogleDatabaseMigrationServiceConnectionProfile.
/// Nesting mode: list
/// </summary>
public class GoogleDatabaseMigrationServiceConnectionProfileCloudsqlBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "cloudsql";

    /// <summary>
    /// Output only. The Cloud SQL instance ID that this connection profile is associated with.
    /// </summary>
    public TerraformValue<string> CloudSqlId
    {
        get => new TerraformReference<string>(this, "cloud_sql_id");
    }

    /// <summary>
    /// Output only. The Cloud SQL database instance&#39;s private IP.
    /// </summary>
    public TerraformValue<string> PrivateIp
    {
        get => new TerraformReference<string>(this, "private_ip");
    }

    /// <summary>
    /// Output only. The Cloud SQL database instance&#39;s public IP.
    /// </summary>
    public TerraformValue<string> PublicIp
    {
        get => new TerraformReference<string>(this, "public_ip");
    }

    /// <summary>
    /// Settings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Settings block(s) allowed")]
    public TerraformList<GoogleDatabaseMigrationServiceConnectionProfileCloudsqlBlockSettingsBlock>? Settings
    {
        get => GetArgument<TerraformList<GoogleDatabaseMigrationServiceConnectionProfileCloudsqlBlockSettingsBlock>>("settings");
        set => SetArgument("settings", value);
    }

}

/// <summary>
/// Block type for settings in GoogleDatabaseMigrationServiceConnectionProfileCloudsqlBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDatabaseMigrationServiceConnectionProfileCloudsqlBlockSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "settings";

    /// <summary>
    /// The activation policy specifies when the instance is activated; it is applicable only when the instance state is &#39;RUNNABLE&#39;. Possible values: [&amp;quot;ALWAYS&amp;quot;, &amp;quot;NEVER&amp;quot;]
    /// </summary>
    public TerraformValue<string>? ActivationPolicy
    {
        get => new TerraformReference<string>(this, "activation_policy");
        set => SetArgument("activation_policy", value);
    }

    /// <summary>
    /// If you enable this setting, Cloud SQL checks your available storage every 30 seconds. If the available storage falls below a threshold size, Cloud SQL automatically adds additional storage capacity.
    /// If the available storage repeatedly falls below the threshold size, Cloud SQL continues to add storage until it reaches the maximum of 30 TB.
    /// </summary>
    public TerraformValue<bool>? AutoStorageIncrease
    {
        get => new TerraformReference<bool>(this, "auto_storage_increase");
        set => SetArgument("auto_storage_increase", value);
    }

    /// <summary>
    /// The KMS key name used for the csql instance.
    /// </summary>
    public TerraformValue<string>? CmekKeyName
    {
        get => new TerraformReference<string>(this, "cmek_key_name");
        set => SetArgument("cmek_key_name", value);
    }

    /// <summary>
    /// The Cloud SQL default instance level collation.
    /// </summary>
    public TerraformValue<string>? Collation
    {
        get => new TerraformReference<string>(this, "collation");
        set => SetArgument("collation", value);
    }

    /// <summary>
    /// The storage capacity available to the database, in GB. The minimum (and default) size is 10GB.
    /// </summary>
    public TerraformValue<string>? DataDiskSizeGb
    {
        get => new TerraformReference<string>(this, "data_disk_size_gb");
        set => SetArgument("data_disk_size_gb", value);
    }

    /// <summary>
    /// The type of storage. Possible values: [&amp;quot;PD_SSD&amp;quot;, &amp;quot;PD_HDD&amp;quot;]
    /// </summary>
    public TerraformValue<string>? DataDiskType
    {
        get => new TerraformReference<string>(this, "data_disk_type");
        set => SetArgument("data_disk_type", value);
    }

    /// <summary>
    /// The database flags passed to the Cloud SQL instance at startup.
    /// </summary>
    public TerraformMap<string>? DatabaseFlags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "database_flags").ResolveNodes(ctx));
        set => SetArgument("database_flags", value);
    }

    /// <summary>
    /// The database engine type and version.
    /// Currently supported values located at https://cloud.google.com/database-migration/docs/reference/rest/v1/projects.locations.connectionProfiles#sqldatabaseversion
    /// </summary>
    public TerraformValue<string>? DatabaseVersion
    {
        get => new TerraformReference<string>(this, "database_version");
        set => SetArgument("database_version", value);
    }

    /// <summary>
    /// The edition of the given Cloud SQL instance. Possible values: [&amp;quot;ENTERPRISE&amp;quot;, &amp;quot;ENTERPRISE_PLUS&amp;quot;]
    /// </summary>
    public TerraformValue<string>? Edition
    {
        get => new TerraformReference<string>(this, "edition");
        set => SetArgument("edition", value);
    }

    /// <summary>
    /// Input only. Initial root password.
    /// </summary>
    public TerraformValue<string>? RootPassword
    {
        get => new TerraformReference<string>(this, "root_password");
        set => SetArgument("root_password", value);
    }

    /// <summary>
    /// Output only. Indicates If this connection profile root password is stored.
    /// </summary>
    public TerraformValue<bool> RootPasswordSet
    {
        get => new TerraformReference<bool>(this, "root_password_set");
    }

    /// <summary>
    /// The Database Migration Service source connection profile ID, in the format: projects/my_project_name/locations/us-central1/connectionProfiles/connection_profile_ID
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceId is required")]
    public required TerraformValue<string> SourceId
    {
        get => new TerraformReference<string>(this, "source_id");
        set => SetArgument("source_id", value);
    }

    /// <summary>
    /// The maximum size to which storage capacity can be automatically increased. The default value is 0, which specifies that there is no limit.
    /// </summary>
    public TerraformValue<string>? StorageAutoResizeLimit
    {
        get => new TerraformReference<string>(this, "storage_auto_resize_limit");
        set => SetArgument("storage_auto_resize_limit", value);
    }

    /// <summary>
    /// The tier (or machine type) for this instance, for example: db-n1-standard-1 (MySQL instances) or db-custom-1-3840 (PostgreSQL instances).
    /// For more information, see https://cloud.google.com/sql/docs/mysql/instance-settings
    /// </summary>
    public TerraformValue<string>? Tier
    {
        get => new TerraformReference<string>(this, "tier");
        set => SetArgument("tier", value);
    }

    /// <summary>
    /// The resource labels for a Cloud SQL instance to use to annotate any related underlying resources such as Compute Engine VMs.
    /// </summary>
    public TerraformMap<string>? UserLabels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "user_labels").ResolveNodes(ctx));
        set => SetArgument("user_labels", value);
    }

    /// <summary>
    /// The Google Cloud Platform zone where your Cloud SQL datdabse instance is located.
    /// </summary>
    public TerraformValue<string>? Zone
    {
        get => new TerraformReference<string>(this, "zone");
        set => SetArgument("zone", value);
    }

    /// <summary>
    /// IpConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IpConfig block(s) allowed")]
    public TerraformList<GoogleDatabaseMigrationServiceConnectionProfileCloudsqlBlockSettingsBlockIpConfigBlock>? IpConfig
    {
        get => GetArgument<TerraformList<GoogleDatabaseMigrationServiceConnectionProfileCloudsqlBlockSettingsBlockIpConfigBlock>>("ip_config");
        set => SetArgument("ip_config", value);
    }

}

/// <summary>
/// Block type for ip_config in GoogleDatabaseMigrationServiceConnectionProfileCloudsqlBlockSettingsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDatabaseMigrationServiceConnectionProfileCloudsqlBlockSettingsBlockIpConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ip_config";

    /// <summary>
    /// Whether the instance should be assigned an IPv4 address or not.
    /// </summary>
    public TerraformValue<bool>? EnableIpv4
    {
        get => new TerraformReference<bool>(this, "enable_ipv4");
        set => SetArgument("enable_ipv4", value);
    }

    /// <summary>
    /// The resource link for the VPC network from which the Cloud SQL instance is accessible for private IP. For example, projects/myProject/global/networks/default.
    /// This setting can be updated, but it cannot be removed after it is set.
    /// </summary>
    public TerraformValue<string>? PrivateNetwork
    {
        get => new TerraformReference<string>(this, "private_network");
        set => SetArgument("private_network", value);
    }

    /// <summary>
    /// Whether SSL connections over IP should be enforced or not.
    /// </summary>
    public TerraformValue<bool>? RequireSsl
    {
        get => new TerraformReference<bool>(this, "require_ssl");
        set => SetArgument("require_ssl", value);
    }

    /// <summary>
    /// AuthorizedNetworks block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleDatabaseMigrationServiceConnectionProfileCloudsqlBlockSettingsBlockIpConfigBlockAuthorizedNetworksBlock>? AuthorizedNetworks
    {
        get => GetArgument<TerraformList<GoogleDatabaseMigrationServiceConnectionProfileCloudsqlBlockSettingsBlockIpConfigBlockAuthorizedNetworksBlock>>("authorized_networks");
        set => SetArgument("authorized_networks", value);
    }

}

/// <summary>
/// Block type for authorized_networks in GoogleDatabaseMigrationServiceConnectionProfileCloudsqlBlockSettingsBlockIpConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDatabaseMigrationServiceConnectionProfileCloudsqlBlockSettingsBlockIpConfigBlockAuthorizedNetworksBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "authorized_networks";

    /// <summary>
    /// The time when this access control entry expires in RFC 3339 format.
    /// </summary>
    public TerraformValue<string>? ExpireTime
    {
        get => new TerraformReference<string>(this, "expire_time");
        set => SetArgument("expire_time", value);
    }

    /// <summary>
    /// A label to identify this entry.
    /// </summary>
    public TerraformValue<string>? Label
    {
        get => new TerraformReference<string>(this, "label");
        set => SetArgument("label", value);
    }

    /// <summary>
    /// Input only. The time-to-leave of this access control entry.
    /// </summary>
    public TerraformValue<string>? Ttl
    {
        get => new TerraformReference<string>(this, "ttl");
        set => SetArgument("ttl", value);
    }

    /// <summary>
    /// The allowlisted value for the access control list.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => new TerraformReference<string>(this, "value");
        set => SetArgument("value", value);
    }

}


/// <summary>
/// Block type for mysql in GoogleDatabaseMigrationServiceConnectionProfile.
/// Nesting mode: list
/// </summary>
public class GoogleDatabaseMigrationServiceConnectionProfileMysqlBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "mysql";

    /// <summary>
    /// If the source is a Cloud SQL database, use this field to provide the Cloud SQL instance ID of the source.
    /// </summary>
    public TerraformValue<string>? CloudSqlId
    {
        get => new TerraformReference<string>(this, "cloud_sql_id");
        set => SetArgument("cloud_sql_id", value);
    }

    /// <summary>
    /// The IP or hostname of the source MySQL database.
    /// </summary>
    public TerraformValue<string>? Host
    {
        get => new TerraformReference<string>(this, "host");
        set => SetArgument("host", value);
    }

    /// <summary>
    /// Input only. The password for the user that Database Migration Service will be using to connect to the database.
    /// This field is not returned on request, and the value is encrypted when stored in Database Migration Service.
    /// </summary>
    public TerraformValue<string>? Password
    {
        get => new TerraformReference<string>(this, "password");
        set => SetArgument("password", value);
    }

    /// <summary>
    /// Output only. Indicates If this connection profile password is stored.
    /// </summary>
    public TerraformValue<bool> PasswordSet
    {
        get => new TerraformReference<bool>(this, "password_set");
    }

    /// <summary>
    /// The network port of the source MySQL database.
    /// </summary>
    public TerraformValue<double>? Port
    {
        get => new TerraformReference<double>(this, "port");
        set => SetArgument("port", value);
    }

    /// <summary>
    /// The username that Database Migration Service will use to connect to the database. The value is encrypted when stored in Database Migration Service.
    /// </summary>
    public TerraformValue<string>? Username
    {
        get => new TerraformReference<string>(this, "username");
        set => SetArgument("username", value);
    }

    /// <summary>
    /// Ssl block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Ssl block(s) allowed")]
    public TerraformList<GoogleDatabaseMigrationServiceConnectionProfileMysqlBlockSslBlock>? Ssl
    {
        get => GetArgument<TerraformList<GoogleDatabaseMigrationServiceConnectionProfileMysqlBlockSslBlock>>("ssl");
        set => SetArgument("ssl", value);
    }

}

/// <summary>
/// Block type for ssl in GoogleDatabaseMigrationServiceConnectionProfileMysqlBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDatabaseMigrationServiceConnectionProfileMysqlBlockSslBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ssl";

    /// <summary>
    /// Input only. The x509 PEM-encoded certificate of the CA that signed the source database server&#39;s certificate.
    /// The replica will use this certificate to verify it&#39;s connecting to the right host.
    /// </summary>
    public TerraformValue<string>? CaCertificate
    {
        get => new TerraformReference<string>(this, "ca_certificate");
        set => SetArgument("ca_certificate", value);
    }

    /// <summary>
    /// Input only. The x509 PEM-encoded certificate that will be used by the replica to authenticate against the source database server.
    /// If this field is used then the &#39;clientKey&#39; field is mandatory
    /// </summary>
    public TerraformValue<string>? ClientCertificate
    {
        get => new TerraformReference<string>(this, "client_certificate");
        set => SetArgument("client_certificate", value);
    }

    /// <summary>
    /// Input only. The unencrypted PKCS#1 or PKCS#8 PEM-encoded private key associated with the Client Certificate.
    /// If this field is used then the &#39;clientCertificate&#39; field is mandatory.
    /// </summary>
    public TerraformValue<string>? ClientKey
    {
        get => new TerraformReference<string>(this, "client_key");
        set => SetArgument("client_key", value);
    }

    /// <summary>
    /// The current connection profile state. Possible values: [&amp;quot;SERVER_ONLY&amp;quot;, &amp;quot;SERVER_CLIENT&amp;quot;, &amp;quot;REQUIRED&amp;quot;, &amp;quot;NONE&amp;quot;]
    /// </summary>
    public TerraformValue<string>? Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

}


/// <summary>
/// Block type for oracle in GoogleDatabaseMigrationServiceConnectionProfile.
/// Nesting mode: list
/// </summary>
public class GoogleDatabaseMigrationServiceConnectionProfileOracleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "oracle";

    /// <summary>
    /// Required. Database service for the Oracle connection.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DatabaseService is required")]
    public required TerraformValue<string> DatabaseService
    {
        get => new TerraformReference<string>(this, "database_service");
        set => SetArgument("database_service", value);
    }

    /// <summary>
    /// Required. The IP or hostname of the source Oracle database.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Host is required")]
    public required TerraformValue<string> Host
    {
        get => new TerraformReference<string>(this, "host");
        set => SetArgument("host", value);
    }

    /// <summary>
    /// Required. Input only. The password for the user that Database Migration Service will be using to connect to the database.
    /// This field is not returned on request, and the value is encrypted when stored in Database Migration Service.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Password is required")]
    public required TerraformValue<string> Password
    {
        get => new TerraformReference<string>(this, "password");
        set => SetArgument("password", value);
    }

    /// <summary>
    /// Output only. Indicates If this connection profile password is stored.
    /// </summary>
    public TerraformValue<bool> PasswordSet
    {
        get => new TerraformReference<bool>(this, "password_set");
    }

    /// <summary>
    /// Required. The network port of the source Oracle database.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Port is required")]
    public required TerraformValue<double> Port
    {
        get => new TerraformReference<double>(this, "port");
        set => SetArgument("port", value);
    }

    /// <summary>
    /// Required. The username that Database Migration Service will use to connect to the database. The value is encrypted when stored in Database Migration Service.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Username is required")]
    public required TerraformValue<string> Username
    {
        get => new TerraformReference<string>(this, "username");
        set => SetArgument("username", value);
    }

    /// <summary>
    /// ForwardSshConnectivity block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ForwardSshConnectivity block(s) allowed")]
    public TerraformList<GoogleDatabaseMigrationServiceConnectionProfileOracleBlockForwardSshConnectivityBlock>? ForwardSshConnectivity
    {
        get => GetArgument<TerraformList<GoogleDatabaseMigrationServiceConnectionProfileOracleBlockForwardSshConnectivityBlock>>("forward_ssh_connectivity");
        set => SetArgument("forward_ssh_connectivity", value);
    }

    /// <summary>
    /// PrivateConnectivity block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PrivateConnectivity block(s) allowed")]
    public TerraformList<GoogleDatabaseMigrationServiceConnectionProfileOracleBlockPrivateConnectivityBlock>? PrivateConnectivity
    {
        get => GetArgument<TerraformList<GoogleDatabaseMigrationServiceConnectionProfileOracleBlockPrivateConnectivityBlock>>("private_connectivity");
        set => SetArgument("private_connectivity", value);
    }

    /// <summary>
    /// Ssl block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Ssl block(s) allowed")]
    public TerraformList<GoogleDatabaseMigrationServiceConnectionProfileOracleBlockSslBlock>? Ssl
    {
        get => GetArgument<TerraformList<GoogleDatabaseMigrationServiceConnectionProfileOracleBlockSslBlock>>("ssl");
        set => SetArgument("ssl", value);
    }

    /// <summary>
    /// StaticServiceIpConnectivity block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StaticServiceIpConnectivity block(s) allowed")]
    public TerraformList<GoogleDatabaseMigrationServiceConnectionProfileOracleBlockStaticServiceIpConnectivityBlock>? StaticServiceIpConnectivity
    {
        get => GetArgument<TerraformList<GoogleDatabaseMigrationServiceConnectionProfileOracleBlockStaticServiceIpConnectivityBlock>>("static_service_ip_connectivity");
        set => SetArgument("static_service_ip_connectivity", value);
    }

}

/// <summary>
/// Block type for forward_ssh_connectivity in GoogleDatabaseMigrationServiceConnectionProfileOracleBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDatabaseMigrationServiceConnectionProfileOracleBlockForwardSshConnectivityBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "forward_ssh_connectivity";

    /// <summary>
    /// Required. Hostname for the SSH tunnel.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Hostname is required")]
    public required TerraformValue<string> Hostname
    {
        get => new TerraformReference<string>(this, "hostname");
        set => SetArgument("hostname", value);
    }

    /// <summary>
    /// Input only. SSH password. Only one of &#39;password&#39; and &#39;private_key&#39; can be configured.
    /// </summary>
    public TerraformValue<string>? Password
    {
        get => new TerraformReference<string>(this, "password");
        set => SetArgument("password", value);
    }

    /// <summary>
    /// Port for the SSH tunnel, default value is 22.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Port is required")]
    public required TerraformValue<double> Port
    {
        get => new TerraformReference<double>(this, "port");
        set => SetArgument("port", value);
    }

    /// <summary>
    /// Input only. SSH private key. Only one of &#39;password&#39; and &#39;private_key&#39; can be configured.
    /// </summary>
    public TerraformValue<string>? PrivateKey
    {
        get => new TerraformReference<string>(this, "private_key");
        set => SetArgument("private_key", value);
    }

    /// <summary>
    /// Required. Username for the SSH tunnel.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Username is required")]
    public required TerraformValue<string> Username
    {
        get => new TerraformReference<string>(this, "username");
        set => SetArgument("username", value);
    }

}

/// <summary>
/// Block type for private_connectivity in GoogleDatabaseMigrationServiceConnectionProfileOracleBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDatabaseMigrationServiceConnectionProfileOracleBlockPrivateConnectivityBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "private_connectivity";

    /// <summary>
    /// Required. The resource name (URI) of the private connection.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrivateConnection is required")]
    public required TerraformValue<string> PrivateConnection
    {
        get => new TerraformReference<string>(this, "private_connection");
        set => SetArgument("private_connection", value);
    }

}

/// <summary>
/// Block type for ssl in GoogleDatabaseMigrationServiceConnectionProfileOracleBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDatabaseMigrationServiceConnectionProfileOracleBlockSslBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ssl";

    /// <summary>
    /// Input only. The x509 PEM-encoded certificate of the CA that signed the source database server&#39;s certificate.
    /// The replica will use this certificate to verify it&#39;s connecting to the right host.
    /// </summary>
    public TerraformValue<string>? CaCertificate
    {
        get => new TerraformReference<string>(this, "ca_certificate");
        set => SetArgument("ca_certificate", value);
    }

    /// <summary>
    /// Input only. The x509 PEM-encoded certificate that will be used by the replica to authenticate against the source database server.
    /// If this field is used then the &#39;clientKey&#39; field is mandatory
    /// </summary>
    public TerraformValue<string>? ClientCertificate
    {
        get => new TerraformReference<string>(this, "client_certificate");
        set => SetArgument("client_certificate", value);
    }

    /// <summary>
    /// Input only. The unencrypted PKCS#1 or PKCS#8 PEM-encoded private key associated with the Client Certificate.
    /// If this field is used then the &#39;clientCertificate&#39; field is mandatory.
    /// </summary>
    public TerraformValue<string>? ClientKey
    {
        get => new TerraformReference<string>(this, "client_key");
        set => SetArgument("client_key", value);
    }

    /// <summary>
    /// The current connection profile state.
    /// </summary>
    public TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
    }

}

/// <summary>
/// Block type for static_service_ip_connectivity in GoogleDatabaseMigrationServiceConnectionProfileOracleBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDatabaseMigrationServiceConnectionProfileOracleBlockStaticServiceIpConnectivityBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "static_service_ip_connectivity";

}


/// <summary>
/// Block type for postgresql in GoogleDatabaseMigrationServiceConnectionProfile.
/// Nesting mode: list
/// </summary>
public class GoogleDatabaseMigrationServiceConnectionProfilePostgresqlBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "postgresql";

    /// <summary>
    /// If the connected database is an AlloyDB instance, use this field to provide the AlloyDB cluster ID.
    /// </summary>
    public TerraformValue<string>? AlloydbClusterId
    {
        get => new TerraformReference<string>(this, "alloydb_cluster_id");
        set => SetArgument("alloydb_cluster_id", value);
    }

    /// <summary>
    /// If the source is a Cloud SQL database, use this field to provide the Cloud SQL instance ID of the source.
    /// </summary>
    public TerraformValue<string>? CloudSqlId
    {
        get => new TerraformReference<string>(this, "cloud_sql_id");
        set => SetArgument("cloud_sql_id", value);
    }

    /// <summary>
    /// The IP or hostname of the source MySQL database.
    /// </summary>
    public TerraformValue<string>? Host
    {
        get => new TerraformReference<string>(this, "host");
        set => SetArgument("host", value);
    }

    /// <summary>
    /// Output only. If the source is a Cloud SQL database, this field indicates the network architecture it&#39;s associated with.
    /// </summary>
    public TerraformValue<string> NetworkArchitecture
    {
        get => new TerraformReference<string>(this, "network_architecture");
    }

    /// <summary>
    /// Input only. The password for the user that Database Migration Service will be using to connect to the database.
    /// This field is not returned on request, and the value is encrypted when stored in Database Migration Service.
    /// </summary>
    public TerraformValue<string>? Password
    {
        get => new TerraformReference<string>(this, "password");
        set => SetArgument("password", value);
    }

    /// <summary>
    /// Output only. Indicates If this connection profile password is stored.
    /// </summary>
    public TerraformValue<bool> PasswordSet
    {
        get => new TerraformReference<bool>(this, "password_set");
    }

    /// <summary>
    /// The network port of the source MySQL database.
    /// </summary>
    public TerraformValue<double>? Port
    {
        get => new TerraformReference<double>(this, "port");
        set => SetArgument("port", value);
    }

    /// <summary>
    /// The username that Database Migration Service will use to connect to the database. The value is encrypted when stored in Database Migration Service.
    /// </summary>
    public TerraformValue<string>? Username
    {
        get => new TerraformReference<string>(this, "username");
        set => SetArgument("username", value);
    }

    /// <summary>
    /// Ssl block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Ssl block(s) allowed")]
    public TerraformList<GoogleDatabaseMigrationServiceConnectionProfilePostgresqlBlockSslBlock>? Ssl
    {
        get => GetArgument<TerraformList<GoogleDatabaseMigrationServiceConnectionProfilePostgresqlBlockSslBlock>>("ssl");
        set => SetArgument("ssl", value);
    }

}

/// <summary>
/// Block type for ssl in GoogleDatabaseMigrationServiceConnectionProfilePostgresqlBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDatabaseMigrationServiceConnectionProfilePostgresqlBlockSslBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ssl";

    /// <summary>
    /// Input only. The x509 PEM-encoded certificate of the CA that signed the source database server&#39;s certificate.
    /// The replica will use this certificate to verify it&#39;s connecting to the right host.
    /// </summary>
    public TerraformValue<string>? CaCertificate
    {
        get => new TerraformReference<string>(this, "ca_certificate");
        set => SetArgument("ca_certificate", value);
    }

    /// <summary>
    /// Input only. The x509 PEM-encoded certificate that will be used by the replica to authenticate against the source database server.
    /// If this field is used then the &#39;clientKey&#39; field is mandatory
    /// </summary>
    public TerraformValue<string>? ClientCertificate
    {
        get => new TerraformReference<string>(this, "client_certificate");
        set => SetArgument("client_certificate", value);
    }

    /// <summary>
    /// Input only. The unencrypted PKCS#1 or PKCS#8 PEM-encoded private key associated with the Client Certificate.
    /// If this field is used then the &#39;clientCertificate&#39; field is mandatory.
    /// </summary>
    public TerraformValue<string>? ClientKey
    {
        get => new TerraformReference<string>(this, "client_key");
        set => SetArgument("client_key", value);
    }

    /// <summary>
    /// The current connection profile state. Possible values: [&amp;quot;SERVER_ONLY&amp;quot;, &amp;quot;SERVER_CLIENT&amp;quot;, &amp;quot;REQUIRED&amp;quot;, &amp;quot;NONE&amp;quot;]
    /// </summary>
    public TerraformValue<string>? Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleDatabaseMigrationServiceConnectionProfile.
/// Nesting mode: single
/// </summary>
public class GoogleDatabaseMigrationServiceConnectionProfileTimeoutsBlock : TerraformBlock
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
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a google_database_migration_service_connection_profile Terraform resource.
/// Manages a google_database_migration_service_connection_profile resource.
/// </summary>
public partial class GoogleDatabaseMigrationServiceConnectionProfile(string name) : TerraformResource("google_database_migration_service_connection_profile", name)
{
    /// <summary>
    /// The ID of the connection profile.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConnectionProfileId is required")]
    public required TerraformValue<string> ConnectionProfileId
    {
        get => new TerraformReference<string>(this, "connection_profile_id");
        set => SetArgument("connection_profile_id", value);
    }

    /// <summary>
    /// The connection profile display name.
    /// </summary>
    public TerraformValue<string>? DisplayName
    {
        get => new TerraformReference<string>(this, "display_name");
        set => SetArgument("display_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The resource labels for connection profile to use to annotate any related underlying resources such as Compute Engine VMs.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public TerraformMap<string>? Labels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "labels").ResolveNodes(ctx));
        set => SetArgument("labels", value);
    }

    /// <summary>
    /// The location where the connection profile should reside.
    /// </summary>
    public TerraformValue<string>? Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => new TerraformReference<string>(this, "project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// Output only. The timestamp when the resource was created. A timestamp in RFC3339 UTC &#39;Zulu&#39; format, accurate to nanoseconds. Example: &#39;2014-10-02T15:01:23.045123456Z&#39;.
    /// </summary>
    public TerraformValue<string> CreateTime
    {
        get => new TerraformReference<string>(this, "create_time");
    }

    /// <summary>
    /// The database provider.
    /// </summary>
    public TerraformValue<string> Dbprovider
    {
        get => new TerraformReference<string>(this, "dbprovider");
    }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveLabels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "effective_labels").ResolveNodes(ctx));
    }

    /// <summary>
    /// Output only. The error details in case of state FAILED.
    /// </summary>
    public TerraformList<TerraformMap<object>> Error
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "error").ResolveNodes(ctx));
    }

    /// <summary>
    /// The name of this connection profile resource in the form of projects/{project}/locations/{location}/connectionProfiles/{connectionProfile}.
    /// </summary>
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
    }

    /// <summary>
    /// The current connection profile state.
    /// </summary>
    public TerraformValue<string> State
    {
        get => new TerraformReference<string>(this, "state");
    }

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformMap<string> TerraformLabels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "terraform_labels").ResolveNodes(ctx));
    }

    /// <summary>
    /// Alloydb block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Alloydb block(s) allowed")]
    public TerraformList<GoogleDatabaseMigrationServiceConnectionProfileAlloydbBlock>? Alloydb
    {
        get => GetArgument<TerraformList<GoogleDatabaseMigrationServiceConnectionProfileAlloydbBlock>>("alloydb");
        set => SetArgument("alloydb", value);
    }

    /// <summary>
    /// Cloudsql block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Cloudsql block(s) allowed")]
    public TerraformList<GoogleDatabaseMigrationServiceConnectionProfileCloudsqlBlock>? Cloudsql
    {
        get => GetArgument<TerraformList<GoogleDatabaseMigrationServiceConnectionProfileCloudsqlBlock>>("cloudsql");
        set => SetArgument("cloudsql", value);
    }

    /// <summary>
    /// Mysql block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Mysql block(s) allowed")]
    public TerraformList<GoogleDatabaseMigrationServiceConnectionProfileMysqlBlock>? Mysql
    {
        get => GetArgument<TerraformList<GoogleDatabaseMigrationServiceConnectionProfileMysqlBlock>>("mysql");
        set => SetArgument("mysql", value);
    }

    /// <summary>
    /// Oracle block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Oracle block(s) allowed")]
    public TerraformList<GoogleDatabaseMigrationServiceConnectionProfileOracleBlock>? Oracle
    {
        get => GetArgument<TerraformList<GoogleDatabaseMigrationServiceConnectionProfileOracleBlock>>("oracle");
        set => SetArgument("oracle", value);
    }

    /// <summary>
    /// Postgresql block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Postgresql block(s) allowed")]
    public TerraformList<GoogleDatabaseMigrationServiceConnectionProfilePostgresqlBlock>? Postgresql
    {
        get => GetArgument<TerraformList<GoogleDatabaseMigrationServiceConnectionProfilePostgresqlBlock>>("postgresql");
        set => SetArgument("postgresql", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleDatabaseMigrationServiceConnectionProfileTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleDatabaseMigrationServiceConnectionProfileTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
