using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for client_connection_config in GoogleAlloydbInstance.
/// Nesting mode: list
/// </summary>
public class GoogleAlloydbInstanceClientConnectionConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "client_connection_config";

    /// <summary>
    /// Configuration to enforce connectors only (ex: AuthProxy) connections to the database.
    /// </summary>
    public TerraformValue<bool>? RequireConnectors
    {
        get => GetArgument<TerraformValue<bool>>("require_connectors");
        set => SetArgument("require_connectors", value);
    }

    /// <summary>
    /// SslConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SslConfig block(s) allowed")]
    public TerraformList<GoogleAlloydbInstanceClientConnectionConfigBlockSslConfigBlock>? SslConfig
    {
        get => GetArgument<TerraformList<GoogleAlloydbInstanceClientConnectionConfigBlockSslConfigBlock>>("ssl_config");
        set => SetArgument("ssl_config", value);
    }

}

/// <summary>
/// Block type for ssl_config in GoogleAlloydbInstanceClientConnectionConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleAlloydbInstanceClientConnectionConfigBlockSslConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ssl_config";

    /// <summary>
    /// SSL mode. Specifies client-server SSL/TLS connection behavior. Possible values: [&amp;quot;ENCRYPTED_ONLY&amp;quot;, &amp;quot;ALLOW_UNENCRYPTED_AND_ENCRYPTED&amp;quot;]
    /// </summary>
    public TerraformValue<string>? SslMode
    {
        get => GetArgument<TerraformValue<string>>("ssl_mode");
        set => SetArgument("ssl_mode", value);
    }

}


/// <summary>
/// Block type for machine_config in GoogleAlloydbInstance.
/// Nesting mode: list
/// </summary>
public class GoogleAlloydbInstanceMachineConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "machine_config";

    /// <summary>
    /// The number of CPU&#39;s in the VM instance.
    /// </summary>
    public TerraformValue<double>? CpuCount
    {
        get => GetArgument<TerraformValue<double>>("cpu_count");
        set => SetArgument("cpu_count", value);
    }

    /// <summary>
    /// Machine type of the VM instance.
    /// E.g. &amp;quot;n2-highmem-4&amp;quot;, &amp;quot;n2-highmem-8&amp;quot;, &amp;quot;c4a-highmem-4-lssd&amp;quot;.
    /// &#39;cpu_count&#39; must match the number of vCPUs in the machine type.
    /// </summary>
    public TerraformValue<string>? MachineType
    {
        get => GetArgument<TerraformValue<string>>("machine_type");
        set => SetArgument("machine_type", value);
    }

}


/// <summary>
/// Block type for network_config in GoogleAlloydbInstance.
/// Nesting mode: list
/// </summary>
public class GoogleAlloydbInstanceNetworkConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "network_config";

    /// <summary>
    /// Name of the allocated IP range for the private IP AlloyDB instance, for example: &amp;quot;google-managed-services-default&amp;quot;.
    /// If set, the instance IPs will be created from this allocated range and will override the IP range used by the parent cluster.
    /// The range name must comply with RFC 1035. Specifically, the name must be 1-63 characters long and match the regular expression [a-z]([-a-z0-9]*[a-z0-9])?.
    /// </summary>
    public TerraformValue<string>? AllocatedIpRangeOverride
    {
        get => GetArgument<TerraformValue<string>>("allocated_ip_range_override");
        set => SetArgument("allocated_ip_range_override", value);
    }

    /// <summary>
    /// Enabling outbound public ip for the instance.
    /// </summary>
    public TerraformValue<bool>? EnableOutboundPublicIp
    {
        get => GetArgument<TerraformValue<bool>>("enable_outbound_public_ip");
        set => SetArgument("enable_outbound_public_ip", value);
    }

    /// <summary>
    /// Enabling public ip for the instance. If a user wishes to disable this,
    /// please also clear the list of the authorized external networks set on
    /// the same instance.
    /// </summary>
    public TerraformValue<bool>? EnablePublicIp
    {
        get => GetArgument<TerraformValue<bool>>("enable_public_ip");
        set => SetArgument("enable_public_ip", value);
    }

    /// <summary>
    /// AuthorizedExternalNetworks block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleAlloydbInstanceNetworkConfigBlockAuthorizedExternalNetworksBlock>? AuthorizedExternalNetworks
    {
        get => GetArgument<TerraformList<GoogleAlloydbInstanceNetworkConfigBlockAuthorizedExternalNetworksBlock>>("authorized_external_networks");
        set => SetArgument("authorized_external_networks", value);
    }

}

/// <summary>
/// Block type for authorized_external_networks in GoogleAlloydbInstanceNetworkConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleAlloydbInstanceNetworkConfigBlockAuthorizedExternalNetworksBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "authorized_external_networks";

    /// <summary>
    /// CIDR range for one authorized network of the instance.
    /// </summary>
    public TerraformValue<string>? CidrRange
    {
        get => GetArgument<TerraformValue<string>>("cidr_range");
        set => SetArgument("cidr_range", value);
    }

}


/// <summary>
/// Block type for psc_instance_config in GoogleAlloydbInstance.
/// Nesting mode: list
/// </summary>
public class GoogleAlloydbInstancePscInstanceConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "psc_instance_config";

    /// <summary>
    /// List of consumer projects that are allowed to create PSC endpoints to service-attachments to this instance.
    /// These should be specified as project numbers only.
    /// </summary>
    public TerraformList<string>? AllowedConsumerProjects
    {
        get => GetArgument<TerraformList<string>>("allowed_consumer_projects");
        set => SetArgument("allowed_consumer_projects", value);
    }

    /// <summary>
    /// The DNS name of the instance for PSC connectivity.
    /// Name convention: &amp;lt;uid&amp;gt;.&amp;lt;uid&amp;gt;.&amp;lt;region&amp;gt;.alloydb-psc.goog
    /// </summary>
    public TerraformValue<string> PscDnsName
        => AsReference("psc_dns_name");

    /// <summary>
    /// The service attachment created when Private Service Connect (PSC) is enabled for the instance.
    /// The name of the resource will be in the format of
    /// &#39;projects/&amp;lt;alloydb-tenant-project-number&amp;gt;/regions/&amp;lt;region-name&amp;gt;/serviceAttachments/&amp;lt;service-attachment-name&amp;gt;&#39;
    /// </summary>
    public TerraformValue<string> ServiceAttachmentLink
        => AsReference("service_attachment_link");

    /// <summary>
    /// PscAutoConnections block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleAlloydbInstancePscInstanceConfigBlockPscAutoConnectionsBlock>? PscAutoConnections
    {
        get => GetArgument<TerraformList<GoogleAlloydbInstancePscInstanceConfigBlockPscAutoConnectionsBlock>>("psc_auto_connections");
        set => SetArgument("psc_auto_connections", value);
    }

    /// <summary>
    /// PscInterfaceConfigs block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleAlloydbInstancePscInstanceConfigBlockPscInterfaceConfigsBlock>? PscInterfaceConfigs
    {
        get => GetArgument<TerraformList<GoogleAlloydbInstancePscInstanceConfigBlockPscInterfaceConfigsBlock>>("psc_interface_configs");
        set => SetArgument("psc_interface_configs", value);
    }

}

/// <summary>
/// Block type for psc_auto_connections in GoogleAlloydbInstancePscInstanceConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleAlloydbInstancePscInstanceConfigBlockPscAutoConnectionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "psc_auto_connections";

    /// <summary>
    /// The consumer network for the PSC service automation, example:
    /// &amp;quot;projects/vpc-host-project/global/networks/default&amp;quot;.
    /// The consumer network might be hosted a different project than the
    /// consumer project. The API expects the consumer project specified to be
    /// the project ID (and not the project number)
    /// </summary>
    public TerraformValue<string>? ConsumerNetwork
    {
        get => GetArgument<TerraformValue<string>>("consumer_network");
        set => SetArgument("consumer_network", value);
    }

    /// <summary>
    /// The status of the service connection policy.
    /// </summary>
    public TerraformValue<string> ConsumerNetworkStatus
        => AsReference("consumer_network_status");

    /// <summary>
    /// The consumer project to which the PSC service automation endpoint will
    /// be created. The API expects the consumer project to be the project ID(
    /// and not the project number).
    /// </summary>
    public TerraformValue<string>? ConsumerProject
    {
        get => GetArgument<TerraformValue<string>>("consumer_project");
        set => SetArgument("consumer_project", value);
    }

    /// <summary>
    /// The IP address of the PSC service automation endpoint.
    /// </summary>
    public TerraformValue<string> IpAddress
        => AsReference("ip_address");

    /// <summary>
    /// The status of the PSC service automation connection.
    /// </summary>
    public TerraformValue<string> Status
        => AsReference("status");

}

/// <summary>
/// Block type for psc_interface_configs in GoogleAlloydbInstancePscInstanceConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleAlloydbInstancePscInstanceConfigBlockPscInterfaceConfigsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "psc_interface_configs";

    /// <summary>
    /// The network attachment resource created in the consumer project to which the PSC interface will be linked.
    /// This is of the format: &amp;quot;projects/${CONSUMER_PROJECT}/regions/${REGION}/networkAttachments/${NETWORK_ATTACHMENT_NAME}&amp;quot;.
    /// The network attachment must be in the same region as the instance.
    /// </summary>
    public TerraformValue<string>? NetworkAttachmentResource
    {
        get => GetArgument<TerraformValue<string>>("network_attachment_resource");
        set => SetArgument("network_attachment_resource", value);
    }

}


/// <summary>
/// Block type for query_insights_config in GoogleAlloydbInstance.
/// Nesting mode: list
/// </summary>
public class GoogleAlloydbInstanceQueryInsightsConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "query_insights_config";

    /// <summary>
    /// Number of query execution plans captured by Insights per minute for all queries combined. The default value is 5. Any integer between 0 and 20 is considered valid.
    /// </summary>
    public TerraformValue<double>? QueryPlansPerMinute
    {
        get => GetArgument<TerraformValue<double>>("query_plans_per_minute");
        set => SetArgument("query_plans_per_minute", value);
    }

    /// <summary>
    /// Query string length. The default value is 1024. Any integer between 256 and 4500 is considered valid.
    /// </summary>
    public TerraformValue<double>? QueryStringLength
    {
        get => GetArgument<TerraformValue<double>>("query_string_length");
        set => SetArgument("query_string_length", value);
    }

    /// <summary>
    /// Record application tags for an instance. This flag is turned &amp;quot;on&amp;quot; by default.
    /// </summary>
    public TerraformValue<bool>? RecordApplicationTags
    {
        get => GetArgument<TerraformValue<bool>>("record_application_tags");
        set => SetArgument("record_application_tags", value);
    }

    /// <summary>
    /// Record client address for an instance. Client address is PII information. This flag is turned &amp;quot;on&amp;quot; by default.
    /// </summary>
    public TerraformValue<bool>? RecordClientAddress
    {
        get => GetArgument<TerraformValue<bool>>("record_client_address");
        set => SetArgument("record_client_address", value);
    }

}


/// <summary>
/// Block type for read_pool_config in GoogleAlloydbInstance.
/// Nesting mode: list
/// </summary>
public class GoogleAlloydbInstanceReadPoolConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "read_pool_config";

    /// <summary>
    /// Read capacity, i.e. number of nodes in a read pool instance.
    /// </summary>
    public TerraformValue<double>? NodeCount
    {
        get => GetArgument<TerraformValue<double>>("node_count");
        set => SetArgument("node_count", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleAlloydbInstance.
/// Nesting mode: single
/// </summary>
public class GoogleAlloydbInstanceTimeoutsBlock : TerraformBlock
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
/// Represents a google_alloydb_instance Terraform resource.
/// Manages a google_alloydb_instance resource.
/// </summary>
public partial class GoogleAlloydbInstance(string name) : TerraformResource("google_alloydb_instance", name)
{
    /// <summary>
    /// &#39;Specifies whether an instance needs to spin up. Once the instance is
    /// active, the activation policy can be updated to the &#39;NEVER&#39; to stop the
    /// instance. Likewise, the activation policy can be updated to &#39;ALWAYS&#39; to
    /// start the instance.
    /// There are restrictions around when an instance can/cannot be activated (for
    /// example, a read pool instance should be stopped before stopping primary
    /// etc.). Please refer to the API documentation for more details.
    /// Possible values are: &#39;ACTIVATION_POLICY_UNSPECIFIED&#39;, &#39;ALWAYS&#39;, &#39;NEVER&#39;.&#39; Possible values: [&amp;quot;ACTIVATION_POLICY_UNSPECIFIED&amp;quot;, &amp;quot;ALWAYS&amp;quot;, &amp;quot;NEVER&amp;quot;]
    /// </summary>
    public TerraformValue<string>? ActivationPolicy
    {
        get => GetArgument<TerraformValue<string>>("activation_policy");
        set => SetArgument("activation_policy", value);
    }

    /// <summary>
    /// Annotations to allow client tools to store small amount of arbitrary data. This is distinct from labels.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the annotations present in your configuration.
    /// Please refer to the field &#39;effective_annotations&#39; for all of the annotations present on the resource.
    /// </summary>
    public TerraformMap<string>? Annotations
    {
        get => GetArgument<TerraformMap<string>>("annotations");
        set => SetArgument("annotations", value);
    }

    /// <summary>
    /// &#39;Availability type of an Instance. Defaults to REGIONAL for both primary and read instances.
    /// Note that primary and read instances can have different availability types.
    /// Primary instances can be either ZONAL or REGIONAL. Read Pool instances can also be either ZONAL or REGIONAL.
    /// Read pools of size 1 can only have zonal availability. Read pools with a node count of 2 or more
    /// can have regional availability (nodes are present in 2 or more zones in a region).
    /// Possible values are: &#39;AVAILABILITY_TYPE_UNSPECIFIED&#39;, &#39;ZONAL&#39;, &#39;REGIONAL&#39;.&#39; Possible values: [&amp;quot;AVAILABILITY_TYPE_UNSPECIFIED&amp;quot;, &amp;quot;ZONAL&amp;quot;, &amp;quot;REGIONAL&amp;quot;]
    /// </summary>
    public TerraformValue<string>? AvailabilityType
    {
        get => GetArgument<TerraformValue<string>>("availability_type");
        set => SetArgument("availability_type", value);
    }

    /// <summary>
    /// Identifies the alloydb cluster. Must be in the format
    /// &#39;projects/{project}/locations/{location}/clusters/{cluster_id}&#39;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Cluster is required")]
    public required TerraformValue<string> Cluster
    {
        get => GetArgument<TerraformValue<string>>("cluster");
        set => SetArgument("cluster", value);
    }

    /// <summary>
    /// Database flags. Set at instance level. * They are copied from primary instance on read instance creation. * Read instances can set new or override existing flags that are relevant for reads, e.g. for enabling columnar cache on a read instance. Flags set on read instance may or may not be present on primary.
    /// </summary>
    public TerraformMap<string>? DatabaseFlags
    {
        get => GetArgument<TerraformMap<string>>("database_flags");
        set => SetArgument("database_flags", value);
    }

    /// <summary>
    /// User-settable and human-readable display name for the Instance.
    /// </summary>
    public TerraformValue<string>? DisplayName
    {
        get => GetArgument<TerraformValue<string>>("display_name");
        set => SetArgument("display_name", value);
    }

    /// <summary>
    /// The Compute Engine zone that the instance should serve from, per https://cloud.google.com/compute/docs/regions-zones This can ONLY be specified for ZONAL instances. If present for a REGIONAL instance, an error will be thrown. If this is absent for a ZONAL instance, instance is created in a random zone with available capacity.
    /// </summary>
    public TerraformValue<string>? GceZone
    {
        get => GetArgument<TerraformValue<string>>("gce_zone");
        set => SetArgument("gce_zone", value);
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
    /// The ID of the alloydb instance.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceId is required")]
    public required TerraformValue<string> InstanceId
    {
        get => GetArgument<TerraformValue<string>>("instance_id");
        set => SetArgument("instance_id", value);
    }

    /// <summary>
    /// The type of the instance.
    /// If the instance type is READ_POOL, provide the associated PRIMARY/SECONDARY instance in the &#39;depends_on&#39; meta-data attribute.
    /// If the instance type is SECONDARY, point to the cluster_type of the associated secondary cluster instead of mentioning SECONDARY.
    /// Example: {instance_type = google_alloydb_cluster.&amp;lt;secondary_cluster_name&amp;gt;.cluster_type} instead of {instance_type = SECONDARY}
    /// If the instance type is SECONDARY, the terraform delete instance operation does not delete the secondary instance but abandons it instead.
    /// Use deletion_policy = &amp;quot;FORCE&amp;quot; in the associated secondary cluster and delete the cluster forcefully to delete the secondary cluster as well its associated secondary instance.
    /// Users can undo the delete secondary instance action by importing the deleted secondary instance by calling terraform import. Possible values: [&amp;quot;PRIMARY&amp;quot;, &amp;quot;READ_POOL&amp;quot;, &amp;quot;SECONDARY&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceType is required")]
    public required TerraformValue<string> InstanceType
    {
        get => GetArgument<TerraformValue<string>>("instance_type");
        set => SetArgument("instance_type", value);
    }

    /// <summary>
    /// User-defined labels for the alloydb instance.
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
    /// Time the Instance was created in UTC.
    /// </summary>
    public TerraformValue<string> CreateTime
        => AsReference("create_time");

    /// <summary>
    /// All of annotations (key/value pairs) present on the resource in GCP, including the annotations configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveAnnotations
        => AsReference("effective_annotations");

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveLabels
        => AsReference("effective_labels");

    /// <summary>
    /// The IP address for the Instance. This is the connection endpoint for an end-user application.
    /// </summary>
    public TerraformValue<string> IpAddress
        => AsReference("ip_address");

    /// <summary>
    /// The name of the instance resource.
    /// </summary>
    public TerraformValue<string> Name
        => AsReference("name");

    /// <summary>
    /// The outbound public IP addresses for the instance. This is available ONLY when
    /// networkConfig.enableOutboundPublicIp is set to true. These IP addresses are used
    /// for outbound connections.
    /// </summary>
    public TerraformList<string> OutboundPublicIpAddresses
        => AsReference("outbound_public_ip_addresses");

    /// <summary>
    /// The public IP addresses for the Instance. This is available ONLY when
    /// networkConfig.enablePublicIp is set to true. This is the connection
    /// endpoint for an end-user application.
    /// </summary>
    public TerraformValue<string> PublicIpAddress
        => AsReference("public_ip_address");

    /// <summary>
    /// Set to true if the current state of Instance does not match the user&#39;s intended state, and the service is actively updating the resource to reconcile them. This can happen due to user-triggered updates or system actions like failover or maintenance.
    /// </summary>
    public TerraformValue<bool> Reconciling
        => AsReference("reconciling");

    /// <summary>
    /// The current state of the alloydb instance.
    /// </summary>
    public TerraformValue<string> State
        => AsReference("state");

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformMap<string> TerraformLabels
        => AsReference("terraform_labels");

    /// <summary>
    /// The system-generated UID of the resource.
    /// </summary>
    public TerraformValue<string> Uid
        => AsReference("uid");

    /// <summary>
    /// Time the Instance was updated in UTC.
    /// </summary>
    public TerraformValue<string> UpdateTime
        => AsReference("update_time");

    /// <summary>
    /// ClientConnectionConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ClientConnectionConfig block(s) allowed")]
    public TerraformList<GoogleAlloydbInstanceClientConnectionConfigBlock>? ClientConnectionConfig
    {
        get => GetArgument<TerraformList<GoogleAlloydbInstanceClientConnectionConfigBlock>>("client_connection_config");
        set => SetArgument("client_connection_config", value);
    }

    /// <summary>
    /// MachineConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MachineConfig block(s) allowed")]
    public TerraformList<GoogleAlloydbInstanceMachineConfigBlock>? MachineConfig
    {
        get => GetArgument<TerraformList<GoogleAlloydbInstanceMachineConfigBlock>>("machine_config");
        set => SetArgument("machine_config", value);
    }

    /// <summary>
    /// NetworkConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NetworkConfig block(s) allowed")]
    public TerraformList<GoogleAlloydbInstanceNetworkConfigBlock>? NetworkConfig
    {
        get => GetArgument<TerraformList<GoogleAlloydbInstanceNetworkConfigBlock>>("network_config");
        set => SetArgument("network_config", value);
    }

    /// <summary>
    /// PscInstanceConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PscInstanceConfig block(s) allowed")]
    public TerraformList<GoogleAlloydbInstancePscInstanceConfigBlock>? PscInstanceConfig
    {
        get => GetArgument<TerraformList<GoogleAlloydbInstancePscInstanceConfigBlock>>("psc_instance_config");
        set => SetArgument("psc_instance_config", value);
    }

    /// <summary>
    /// QueryInsightsConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 QueryInsightsConfig block(s) allowed")]
    public TerraformList<GoogleAlloydbInstanceQueryInsightsConfigBlock>? QueryInsightsConfig
    {
        get => GetArgument<TerraformList<GoogleAlloydbInstanceQueryInsightsConfigBlock>>("query_insights_config");
        set => SetArgument("query_insights_config", value);
    }

    /// <summary>
    /// ReadPoolConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ReadPoolConfig block(s) allowed")]
    public TerraformList<GoogleAlloydbInstanceReadPoolConfigBlock>? ReadPoolConfig
    {
        get => GetArgument<TerraformList<GoogleAlloydbInstanceReadPoolConfigBlock>>("read_pool_config");
        set => SetArgument("read_pool_config", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleAlloydbInstanceTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleAlloydbInstanceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
