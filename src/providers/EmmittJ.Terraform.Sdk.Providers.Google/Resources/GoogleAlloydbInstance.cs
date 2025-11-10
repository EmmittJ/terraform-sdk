using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for client_connection_config in .
/// Nesting mode: list
/// </summary>
public class GoogleAlloydbInstanceClientConnectionConfigBlock : ITerraformBlock
{
    /// <summary>
    /// Configuration to enforce connectors only (ex: AuthProxy) connections to the database.
    /// </summary>
    [TerraformPropertyName("require_connectors")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? RequireConnectors { get; set; }

}

/// <summary>
/// Block type for machine_config in .
/// Nesting mode: list
/// </summary>
public class GoogleAlloydbInstanceMachineConfigBlock : ITerraformBlock
{
    /// <summary>
    /// The number of CPU&#39;s in the VM instance.
    /// </summary>
    [TerraformPropertyName("cpu_count")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> CpuCount { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>("", "cpu_count");

    /// <summary>
    /// Machine type of the VM instance.
    /// E.g. &amp;quot;n2-highmem-4&amp;quot;, &amp;quot;n2-highmem-8&amp;quot;, &amp;quot;c4a-highmem-4-lssd&amp;quot;.
    /// &#39;cpu_count&#39; must match the number of vCPUs in the machine type.
    /// </summary>
    [TerraformPropertyName("machine_type")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> MachineType { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "machine_type");

}

/// <summary>
/// Block type for network_config in .
/// Nesting mode: list
/// </summary>
public class GoogleAlloydbInstanceNetworkConfigBlock : ITerraformBlock
{
    /// <summary>
    /// Name of the allocated IP range for the private IP AlloyDB instance, for example: &amp;quot;google-managed-services-default&amp;quot;.
    /// If set, the instance IPs will be created from this allocated range and will override the IP range used by the parent cluster.
    /// The range name must comply with RFC 1035. Specifically, the name must be 1-63 characters long and match the regular expression [a-z]([-a-z0-9]*[a-z0-9])?.
    /// </summary>
    [TerraformPropertyName("allocated_ip_range_override")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? AllocatedIpRangeOverride { get; set; }

    /// <summary>
    /// Enabling outbound public ip for the instance.
    /// </summary>
    [TerraformPropertyName("enable_outbound_public_ip")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? EnableOutboundPublicIp { get; set; }

    /// <summary>
    /// Enabling public ip for the instance. If a user wishes to disable this,
    /// please also clear the list of the authorized external networks set on
    /// the same instance.
    /// </summary>
    [TerraformPropertyName("enable_public_ip")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? EnablePublicIp { get; set; }

}

/// <summary>
/// Block type for psc_instance_config in .
/// Nesting mode: list
/// </summary>
public class GoogleAlloydbInstancePscInstanceConfigBlock : ITerraformBlock
{
    /// <summary>
    /// List of consumer projects that are allowed to create PSC endpoints to service-attachments to this instance.
    /// These should be specified as project numbers only.
    /// </summary>
    [TerraformPropertyName("allowed_consumer_projects")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? AllowedConsumerProjects { get; set; }

    /// <summary>
    /// The DNS name of the instance for PSC connectivity.
    /// Name convention: &amp;lt;uid&amp;gt;.&amp;lt;uid&amp;gt;.&amp;lt;region&amp;gt;.alloydb-psc.goog
    /// </summary>
    [TerraformPropertyName("psc_dns_name")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PscDnsName => new TerraformReferenceProperty<TerraformProperty<string>>("", "psc_dns_name");

    /// <summary>
    /// The service attachment created when Private Service Connect (PSC) is enabled for the instance.
    /// The name of the resource will be in the format of
    /// &#39;projects/&amp;lt;alloydb-tenant-project-number&amp;gt;/regions/&amp;lt;region-name&amp;gt;/serviceAttachments/&amp;lt;service-attachment-name&amp;gt;&#39;
    /// </summary>
    [TerraformPropertyName("service_attachment_link")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ServiceAttachmentLink => new TerraformReferenceProperty<TerraformProperty<string>>("", "service_attachment_link");

}

/// <summary>
/// Block type for query_insights_config in .
/// Nesting mode: list
/// </summary>
public class GoogleAlloydbInstanceQueryInsightsConfigBlock : ITerraformBlock
{
    /// <summary>
    /// Number of query execution plans captured by Insights per minute for all queries combined. The default value is 5. Any integer between 0 and 20 is considered valid.
    /// </summary>
    [TerraformPropertyName("query_plans_per_minute")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? QueryPlansPerMinute { get; set; }

    /// <summary>
    /// Query string length. The default value is 1024. Any integer between 256 and 4500 is considered valid.
    /// </summary>
    [TerraformPropertyName("query_string_length")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? QueryStringLength { get; set; }

    /// <summary>
    /// Record application tags for an instance. This flag is turned &amp;quot;on&amp;quot; by default.
    /// </summary>
    [TerraformPropertyName("record_application_tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? RecordApplicationTags { get; set; }

    /// <summary>
    /// Record client address for an instance. Client address is PII information. This flag is turned &amp;quot;on&amp;quot; by default.
    /// </summary>
    [TerraformPropertyName("record_client_address")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? RecordClientAddress { get; set; }

}

/// <summary>
/// Block type for read_pool_config in .
/// Nesting mode: list
/// </summary>
public class GoogleAlloydbInstanceReadPoolConfigBlock : ITerraformBlock
{
    /// <summary>
    /// Read capacity, i.e. number of nodes in a read pool instance.
    /// </summary>
    [TerraformPropertyName("node_count")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? NodeCount { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleAlloydbInstanceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Manages a google_alloydb_instance resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleAlloydbInstance : TerraformResource
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
    [TerraformPropertyName("activation_policy")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> ActivationPolicy { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "activation_policy");

    /// <summary>
    /// Annotations to allow client tools to store small amount of arbitrary data. This is distinct from labels.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the annotations present in your configuration.
    /// Please refer to the field &#39;effective_annotations&#39; for all of the annotations present on the resource.
    /// </summary>
    [TerraformPropertyName("annotations")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Annotations { get; set; }

    /// <summary>
    /// &#39;Availability type of an Instance. Defaults to REGIONAL for both primary and read instances.
    /// Note that primary and read instances can have different availability types.
    /// Primary instances can be either ZONAL or REGIONAL. Read Pool instances can also be either ZONAL or REGIONAL.
    /// Read pools of size 1 can only have zonal availability. Read pools with a node count of 2 or more
    /// can have regional availability (nodes are present in 2 or more zones in a region).
    /// Possible values are: &#39;AVAILABILITY_TYPE_UNSPECIFIED&#39;, &#39;ZONAL&#39;, &#39;REGIONAL&#39;.&#39; Possible values: [&amp;quot;AVAILABILITY_TYPE_UNSPECIFIED&amp;quot;, &amp;quot;ZONAL&amp;quot;, &amp;quot;REGIONAL&amp;quot;]
    /// </summary>
    [TerraformPropertyName("availability_type")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> AvailabilityType { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "availability_type");

    /// <summary>
    /// Identifies the alloydb cluster. Must be in the format
    /// &#39;projects/{project}/locations/{location}/clusters/{cluster_id}&#39;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Cluster is required")]
    [TerraformPropertyName("cluster")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Cluster { get; set; }

    /// <summary>
    /// Database flags. Set at instance level. * They are copied from primary instance on read instance creation. * Read instances can set new or override existing flags that are relevant for reads, e.g. for enabling columnar cache on a read instance. Flags set on read instance may or may not be present on primary.
    /// </summary>
    [TerraformPropertyName("database_flags")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> DatabaseFlags { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "database_flags");

    /// <summary>
    /// User-settable and human-readable display name for the Instance.
    /// </summary>
    [TerraformPropertyName("display_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DisplayName { get; set; }

    /// <summary>
    /// The Compute Engine zone that the instance should serve from, per https://cloud.google.com/compute/docs/regions-zones This can ONLY be specified for ZONAL instances. If present for a REGIONAL instance, an error will be thrown. If this is absent for a ZONAL instance, instance is created in a random zone with available capacity.
    /// </summary>
    [TerraformPropertyName("gce_zone")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? GceZone { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The ID of the alloydb instance.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceId is required")]
    [TerraformPropertyName("instance_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> InstanceId { get; set; }

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
    [TerraformPropertyName("instance_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> InstanceType { get; set; }

    /// <summary>
    /// User-defined labels for the alloydb instance.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformPropertyName("labels")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Labels { get; set; }

    /// <summary>
    /// Block for client_connection_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ClientConnectionConfig block(s) allowed")]
    [TerraformPropertyName("client_connection_config")]
    public TerraformList<TerraformBlock<GoogleAlloydbInstanceClientConnectionConfigBlock>>? ClientConnectionConfig { get; set; } = new();

    /// <summary>
    /// Block for machine_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MachineConfig block(s) allowed")]
    [TerraformPropertyName("machine_config")]
    public TerraformList<TerraformBlock<GoogleAlloydbInstanceMachineConfigBlock>>? MachineConfig { get; set; } = new();

    /// <summary>
    /// Block for network_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NetworkConfig block(s) allowed")]
    [TerraformPropertyName("network_config")]
    public TerraformList<TerraformBlock<GoogleAlloydbInstanceNetworkConfigBlock>>? NetworkConfig { get; set; } = new();

    /// <summary>
    /// Block for psc_instance_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PscInstanceConfig block(s) allowed")]
    [TerraformPropertyName("psc_instance_config")]
    public TerraformList<TerraformBlock<GoogleAlloydbInstancePscInstanceConfigBlock>>? PscInstanceConfig { get; set; } = new();

    /// <summary>
    /// Block for query_insights_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 QueryInsightsConfig block(s) allowed")]
    [TerraformPropertyName("query_insights_config")]
    public TerraformList<TerraformBlock<GoogleAlloydbInstanceQueryInsightsConfigBlock>>? QueryInsightsConfig { get; set; } = new();

    /// <summary>
    /// Block for read_pool_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ReadPoolConfig block(s) allowed")]
    [TerraformPropertyName("read_pool_config")]
    public TerraformList<TerraformBlock<GoogleAlloydbInstanceReadPoolConfigBlock>>? ReadPoolConfig { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleAlloydbInstanceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// Time the Instance was created in UTC.
    /// </summary>
    [TerraformPropertyName("create_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreateTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "create_time");

    /// <summary>
    /// All of annotations (key/value pairs) present on the resource in GCP, including the annotations configured through Terraform, other clients and services.
    /// </summary>
    [TerraformPropertyName("effective_annotations")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> EffectiveAnnotations => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "effective_annotations");

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformPropertyName("effective_labels")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> EffectiveLabels => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "effective_labels");

    /// <summary>
    /// The IP address for the Instance. This is the connection endpoint for an end-user application.
    /// </summary>
    [TerraformPropertyName("ip_address")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> IpAddress => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "ip_address");

    /// <summary>
    /// The name of the instance resource.
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Name => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name");

    /// <summary>
    /// The outbound public IP addresses for the instance. This is available ONLY when
    /// networkConfig.enableOutboundPublicIp is set to true. These IP addresses are used
    /// for outbound connections.
    /// </summary>
    [TerraformPropertyName("outbound_public_ip_addresses")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> OutboundPublicIpAddresses => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "outbound_public_ip_addresses");

    /// <summary>
    /// The public IP addresses for the Instance. This is available ONLY when
    /// networkConfig.enablePublicIp is set to true. This is the connection
    /// endpoint for an end-user application.
    /// </summary>
    [TerraformPropertyName("public_ip_address")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PublicIpAddress => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "public_ip_address");

    /// <summary>
    /// Set to true if the current state of Instance does not match the user&#39;s intended state, and the service is actively updating the resource to reconcile them. This can happen due to user-triggered updates or system actions like failover or maintenance.
    /// </summary>
    [TerraformPropertyName("reconciling")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> Reconciling => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "reconciling");

    /// <summary>
    /// The current state of the alloydb instance.
    /// </summary>
    [TerraformPropertyName("state")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> State => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "state");

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformPropertyName("terraform_labels")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TerraformLabels => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "terraform_labels");

    /// <summary>
    /// The system-generated UID of the resource.
    /// </summary>
    [TerraformPropertyName("uid")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Uid => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "uid");

    /// <summary>
    /// Time the Instance was updated in UTC.
    /// </summary>
    [TerraformPropertyName("update_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> UpdateTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "update_time");

}
