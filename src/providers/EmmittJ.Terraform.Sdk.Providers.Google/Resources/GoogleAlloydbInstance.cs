using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for client_connection_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleAlloydbInstanceClientConnectionConfigBlock : TerraformBlockBase
{
    /// <summary>
    /// Configuration to enforce connectors only (ex: AuthProxy) connections to the database.
    /// </summary>
    [TerraformProperty("require_connectors")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? RequireConnectors { get; set; }

}

/// <summary>
/// Block type for machine_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleAlloydbInstanceMachineConfigBlock : TerraformBlockBase
{
    /// <summary>
    /// The number of CPU&#39;s in the VM instance.
    /// </summary>
    [TerraformProperty("cpu_count")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> CpuCount { get; set; }

    /// <summary>
    /// Machine type of the VM instance.
    /// E.g. &amp;quot;n2-highmem-4&amp;quot;, &amp;quot;n2-highmem-8&amp;quot;, &amp;quot;c4a-highmem-4-lssd&amp;quot;.
    /// &#39;cpu_count&#39; must match the number of vCPUs in the machine type.
    /// </summary>
    [TerraformProperty("machine_type")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> MachineType { get; set; }

}

/// <summary>
/// Block type for network_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleAlloydbInstanceNetworkConfigBlock : TerraformBlockBase
{
    /// <summary>
    /// Name of the allocated IP range for the private IP AlloyDB instance, for example: &amp;quot;google-managed-services-default&amp;quot;.
    /// If set, the instance IPs will be created from this allocated range and will override the IP range used by the parent cluster.
    /// The range name must comply with RFC 1035. Specifically, the name must be 1-63 characters long and match the regular expression [a-z]([-a-z0-9]*[a-z0-9])?.
    /// </summary>
    [TerraformProperty("allocated_ip_range_override")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? AllocatedIpRangeOverride { get; set; }

    /// <summary>
    /// Enabling outbound public ip for the instance.
    /// </summary>
    [TerraformProperty("enable_outbound_public_ip")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? EnableOutboundPublicIp { get; set; }

    /// <summary>
    /// Enabling public ip for the instance. If a user wishes to disable this,
    /// please also clear the list of the authorized external networks set on
    /// the same instance.
    /// </summary>
    [TerraformProperty("enable_public_ip")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? EnablePublicIp { get; set; }

}

/// <summary>
/// Block type for psc_instance_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleAlloydbInstancePscInstanceConfigBlock : TerraformBlockBase
{
    /// <summary>
    /// List of consumer projects that are allowed to create PSC endpoints to service-attachments to this instance.
    /// These should be specified as project numbers only.
    /// </summary>
    [TerraformProperty("allowed_consumer_projects")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? AllowedConsumerProjects { get; set; }



}

/// <summary>
/// Block type for query_insights_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleAlloydbInstanceQueryInsightsConfigBlock : TerraformBlockBase
{
    /// <summary>
    /// Number of query execution plans captured by Insights per minute for all queries combined. The default value is 5. Any integer between 0 and 20 is considered valid.
    /// </summary>
    [TerraformProperty("query_plans_per_minute")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? QueryPlansPerMinute { get; set; }

    /// <summary>
    /// Query string length. The default value is 1024. Any integer between 256 and 4500 is considered valid.
    /// </summary>
    [TerraformProperty("query_string_length")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? QueryStringLength { get; set; }

    /// <summary>
    /// Record application tags for an instance. This flag is turned &amp;quot;on&amp;quot; by default.
    /// </summary>
    [TerraformProperty("record_application_tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? RecordApplicationTags { get; set; }

    /// <summary>
    /// Record client address for an instance. Client address is PII information. This flag is turned &amp;quot;on&amp;quot; by default.
    /// </summary>
    [TerraformProperty("record_client_address")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? RecordClientAddress { get; set; }

}

/// <summary>
/// Block type for read_pool_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleAlloydbInstanceReadPoolConfigBlock : TerraformBlockBase
{
    /// <summary>
    /// Read capacity, i.e. number of nodes in a read pool instance.
    /// </summary>
    [TerraformProperty("node_count")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? NodeCount { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleAlloydbInstanceTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_alloydb_instance resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleAlloydbInstance : TerraformResource
{
    public GoogleAlloydbInstance(string name) : base("google_alloydb_instance", name)
    {
    }

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
    [TerraformProperty("activation_policy")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> ActivationPolicy { get; set; }

    /// <summary>
    /// Annotations to allow client tools to store small amount of arbitrary data. This is distinct from labels.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the annotations present in your configuration.
    /// Please refer to the field &#39;effective_annotations&#39; for all of the annotations present on the resource.
    /// </summary>
    [TerraformProperty("annotations")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Annotations { get; set; }

    /// <summary>
    /// &#39;Availability type of an Instance. Defaults to REGIONAL for both primary and read instances.
    /// Note that primary and read instances can have different availability types.
    /// Primary instances can be either ZONAL or REGIONAL. Read Pool instances can also be either ZONAL or REGIONAL.
    /// Read pools of size 1 can only have zonal availability. Read pools with a node count of 2 or more
    /// can have regional availability (nodes are present in 2 or more zones in a region).
    /// Possible values are: &#39;AVAILABILITY_TYPE_UNSPECIFIED&#39;, &#39;ZONAL&#39;, &#39;REGIONAL&#39;.&#39; Possible values: [&amp;quot;AVAILABILITY_TYPE_UNSPECIFIED&amp;quot;, &amp;quot;ZONAL&amp;quot;, &amp;quot;REGIONAL&amp;quot;]
    /// </summary>
    [TerraformProperty("availability_type")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> AvailabilityType { get; set; }

    /// <summary>
    /// Identifies the alloydb cluster. Must be in the format
    /// &#39;projects/{project}/locations/{location}/clusters/{cluster_id}&#39;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Cluster is required")]
    [TerraformProperty("cluster")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Cluster { get; set; }

    /// <summary>
    /// Database flags. Set at instance level. * They are copied from primary instance on read instance creation. * Read instances can set new or override existing flags that are relevant for reads, e.g. for enabling columnar cache on a read instance. Flags set on read instance may or may not be present on primary.
    /// </summary>
    [TerraformProperty("database_flags")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformMap<string> DatabaseFlags { get; set; }

    /// <summary>
    /// User-settable and human-readable display name for the Instance.
    /// </summary>
    [TerraformProperty("display_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DisplayName { get; set; }

    /// <summary>
    /// The Compute Engine zone that the instance should serve from, per https://cloud.google.com/compute/docs/regions-zones This can ONLY be specified for ZONAL instances. If present for a REGIONAL instance, an error will be thrown. If this is absent for a ZONAL instance, instance is created in a random zone with available capacity.
    /// </summary>
    [TerraformProperty("gce_zone")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? GceZone { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The ID of the alloydb instance.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceId is required")]
    [TerraformProperty("instance_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> InstanceId { get; set; }

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
    [TerraformProperty("instance_type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> InstanceType { get; set; }

    /// <summary>
    /// User-defined labels for the alloydb instance.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformProperty("labels")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Labels { get; set; }

    /// <summary>
    /// Block for client_connection_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ClientConnectionConfig block(s) allowed")]
    [TerraformProperty("client_connection_config")]
    public partial TerraformList<TerraformBlock<GoogleAlloydbInstanceClientConnectionConfigBlock>>? ClientConnectionConfig { get; set; }

    /// <summary>
    /// Block for machine_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MachineConfig block(s) allowed")]
    [TerraformProperty("machine_config")]
    public partial TerraformList<TerraformBlock<GoogleAlloydbInstanceMachineConfigBlock>>? MachineConfig { get; set; }

    /// <summary>
    /// Block for network_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NetworkConfig block(s) allowed")]
    [TerraformProperty("network_config")]
    public partial TerraformList<TerraformBlock<GoogleAlloydbInstanceNetworkConfigBlock>>? NetworkConfig { get; set; }

    /// <summary>
    /// Block for psc_instance_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PscInstanceConfig block(s) allowed")]
    [TerraformProperty("psc_instance_config")]
    public partial TerraformList<TerraformBlock<GoogleAlloydbInstancePscInstanceConfigBlock>>? PscInstanceConfig { get; set; }

    /// <summary>
    /// Block for query_insights_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 QueryInsightsConfig block(s) allowed")]
    [TerraformProperty("query_insights_config")]
    public partial TerraformList<TerraformBlock<GoogleAlloydbInstanceQueryInsightsConfigBlock>>? QueryInsightsConfig { get; set; }

    /// <summary>
    /// Block for read_pool_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ReadPoolConfig block(s) allowed")]
    [TerraformProperty("read_pool_config")]
    public partial TerraformList<TerraformBlock<GoogleAlloydbInstanceReadPoolConfigBlock>>? ReadPoolConfig { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<GoogleAlloydbInstanceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Time the Instance was created in UTC.
    /// </summary>
    [TerraformProperty("create_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CreateTime { get; }

    /// <summary>
    /// All of annotations (key/value pairs) present on the resource in GCP, including the annotations configured through Terraform, other clients and services.
    /// </summary>
    [TerraformProperty("effective_annotations")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> EffectiveAnnotations { get; }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformProperty("effective_labels")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> EffectiveLabels { get; }

    /// <summary>
    /// The IP address for the Instance. This is the connection endpoint for an end-user application.
    /// </summary>
    [TerraformProperty("ip_address")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> IpAddress { get; }

    /// <summary>
    /// The name of the instance resource.
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Name { get; }

    /// <summary>
    /// The outbound public IP addresses for the instance. This is available ONLY when
    /// networkConfig.enableOutboundPublicIp is set to true. These IP addresses are used
    /// for outbound connections.
    /// </summary>
    [TerraformProperty("outbound_public_ip_addresses")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<string> OutboundPublicIpAddresses { get; }

    /// <summary>
    /// The public IP addresses for the Instance. This is available ONLY when
    /// networkConfig.enablePublicIp is set to true. This is the connection
    /// endpoint for an end-user application.
    /// </summary>
    [TerraformProperty("public_ip_address")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> PublicIpAddress { get; }

    /// <summary>
    /// Set to true if the current state of Instance does not match the user&#39;s intended state, and the service is actively updating the resource to reconcile them. This can happen due to user-triggered updates or system actions like failover or maintenance.
    /// </summary>
    [TerraformProperty("reconciling")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> Reconciling { get; }

    /// <summary>
    /// The current state of the alloydb instance.
    /// </summary>
    [TerraformProperty("state")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> State { get; }

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformProperty("terraform_labels")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> TerraformLabels { get; }

    /// <summary>
    /// The system-generated UID of the resource.
    /// </summary>
    [TerraformProperty("uid")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Uid { get; }

    /// <summary>
    /// Time the Instance was updated in UTC.
    /// </summary>
    [TerraformProperty("update_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> UpdateTime { get; }

}
