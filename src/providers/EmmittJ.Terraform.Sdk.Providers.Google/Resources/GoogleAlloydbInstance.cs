using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for client_connection_config in .
/// Nesting mode: list
/// </summary>
public class GoogleAlloydbInstanceClientConnectionConfigBlock : TerraformBlock
{
    /// <summary>
    /// Configuration to enforce connectors only (ex: AuthProxy) connections to the database.
    /// </summary>
    public TerraformProperty<bool>? RequireConnectors
    {
        get => GetProperty<TerraformProperty<bool>>("require_connectors");
        set => WithProperty("require_connectors", value);
    }

}

/// <summary>
/// Block type for machine_config in .
/// Nesting mode: list
/// </summary>
public class GoogleAlloydbInstanceMachineConfigBlock : TerraformBlock
{
    /// <summary>
    /// The number of CPU&#39;s in the VM instance.
    /// </summary>
    public TerraformProperty<double>? CpuCount
    {
        get => GetProperty<TerraformProperty<double>>("cpu_count");
        set => WithProperty("cpu_count", value);
    }

    /// <summary>
    /// Machine type of the VM instance.
    /// E.g. &amp;quot;n2-highmem-4&amp;quot;, &amp;quot;n2-highmem-8&amp;quot;, &amp;quot;c4a-highmem-4-lssd&amp;quot;.
    /// &#39;cpu_count&#39; must match the number of vCPUs in the machine type.
    /// </summary>
    public TerraformProperty<string>? MachineType
    {
        get => GetProperty<TerraformProperty<string>>("machine_type");
        set => WithProperty("machine_type", value);
    }

}

/// <summary>
/// Block type for network_config in .
/// Nesting mode: list
/// </summary>
public class GoogleAlloydbInstanceNetworkConfigBlock : TerraformBlock
{
    /// <summary>
    /// Name of the allocated IP range for the private IP AlloyDB instance, for example: &amp;quot;google-managed-services-default&amp;quot;.
    /// If set, the instance IPs will be created from this allocated range and will override the IP range used by the parent cluster.
    /// The range name must comply with RFC 1035. Specifically, the name must be 1-63 characters long and match the regular expression [a-z]([-a-z0-9]*[a-z0-9])?.
    /// </summary>
    public TerraformProperty<string>? AllocatedIpRangeOverride
    {
        get => GetProperty<TerraformProperty<string>>("allocated_ip_range_override");
        set => WithProperty("allocated_ip_range_override", value);
    }

    /// <summary>
    /// Enabling outbound public ip for the instance.
    /// </summary>
    public TerraformProperty<bool>? EnableOutboundPublicIp
    {
        get => GetProperty<TerraformProperty<bool>>("enable_outbound_public_ip");
        set => WithProperty("enable_outbound_public_ip", value);
    }

    /// <summary>
    /// Enabling public ip for the instance. If a user wishes to disable this,
    /// please also clear the list of the authorized external networks set on
    /// the same instance.
    /// </summary>
    public TerraformProperty<bool>? EnablePublicIp
    {
        get => GetProperty<TerraformProperty<bool>>("enable_public_ip");
        set => WithProperty("enable_public_ip", value);
    }

}

/// <summary>
/// Block type for psc_instance_config in .
/// Nesting mode: list
/// </summary>
public class GoogleAlloydbInstancePscInstanceConfigBlock : TerraformBlock
{
    /// <summary>
    /// List of consumer projects that are allowed to create PSC endpoints to service-attachments to this instance.
    /// These should be specified as project numbers only.
    /// </summary>
    public List<TerraformProperty<string>>? AllowedConsumerProjects
    {
        get => GetProperty<List<TerraformProperty<string>>>("allowed_consumer_projects");
        set => WithProperty("allowed_consumer_projects", value);
    }

    /// <summary>
    /// The DNS name of the instance for PSC connectivity.
    /// Name convention: &amp;lt;uid&amp;gt;.&amp;lt;uid&amp;gt;.&amp;lt;region&amp;gt;.alloydb-psc.goog
    /// </summary>
    public TerraformProperty<string>? PscDnsName
    {
        get => GetProperty<TerraformProperty<string>>("psc_dns_name");
        set => WithProperty("psc_dns_name", value);
    }

    /// <summary>
    /// The service attachment created when Private Service Connect (PSC) is enabled for the instance.
    /// The name of the resource will be in the format of
    /// &#39;projects/&amp;lt;alloydb-tenant-project-number&amp;gt;/regions/&amp;lt;region-name&amp;gt;/serviceAttachments/&amp;lt;service-attachment-name&amp;gt;&#39;
    /// </summary>
    public TerraformProperty<string>? ServiceAttachmentLink
    {
        get => GetProperty<TerraformProperty<string>>("service_attachment_link");
        set => WithProperty("service_attachment_link", value);
    }

}

/// <summary>
/// Block type for query_insights_config in .
/// Nesting mode: list
/// </summary>
public class GoogleAlloydbInstanceQueryInsightsConfigBlock : TerraformBlock
{
    /// <summary>
    /// Number of query execution plans captured by Insights per minute for all queries combined. The default value is 5. Any integer between 0 and 20 is considered valid.
    /// </summary>
    public TerraformProperty<double>? QueryPlansPerMinute
    {
        get => GetProperty<TerraformProperty<double>>("query_plans_per_minute");
        set => WithProperty("query_plans_per_minute", value);
    }

    /// <summary>
    /// Query string length. The default value is 1024. Any integer between 256 and 4500 is considered valid.
    /// </summary>
    public TerraformProperty<double>? QueryStringLength
    {
        get => GetProperty<TerraformProperty<double>>("query_string_length");
        set => WithProperty("query_string_length", value);
    }

    /// <summary>
    /// Record application tags for an instance. This flag is turned &amp;quot;on&amp;quot; by default.
    /// </summary>
    public TerraformProperty<bool>? RecordApplicationTags
    {
        get => GetProperty<TerraformProperty<bool>>("record_application_tags");
        set => WithProperty("record_application_tags", value);
    }

    /// <summary>
    /// Record client address for an instance. Client address is PII information. This flag is turned &amp;quot;on&amp;quot; by default.
    /// </summary>
    public TerraformProperty<bool>? RecordClientAddress
    {
        get => GetProperty<TerraformProperty<bool>>("record_client_address");
        set => WithProperty("record_client_address", value);
    }

}

/// <summary>
/// Block type for read_pool_config in .
/// Nesting mode: list
/// </summary>
public class GoogleAlloydbInstanceReadPoolConfigBlock : TerraformBlock
{
    /// <summary>
    /// Read capacity, i.e. number of nodes in a read pool instance.
    /// </summary>
    public TerraformProperty<double>? NodeCount
    {
        get => GetProperty<TerraformProperty<double>>("node_count");
        set => WithProperty("node_count", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleAlloydbInstanceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a google_alloydb_instance resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleAlloydbInstance : TerraformResource
{
    public GoogleAlloydbInstance(string name) : base("google_alloydb_instance", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("create_time");
        this.DeclareOutput("effective_annotations");
        this.DeclareOutput("effective_labels");
        this.DeclareOutput("ip_address");
        this.DeclareOutput("name");
        this.DeclareOutput("outbound_public_ip_addresses");
        this.DeclareOutput("public_ip_address");
        this.DeclareOutput("reconciling");
        this.DeclareOutput("state");
        this.DeclareOutput("terraform_labels");
        this.DeclareOutput("uid");
        this.DeclareOutput("update_time");
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
    public TerraformProperty<string>? ActivationPolicy
    {
        get => GetProperty<TerraformProperty<string>>("activation_policy");
        set => this.WithProperty("activation_policy", value);
    }

    /// <summary>
    /// Annotations to allow client tools to store small amount of arbitrary data. This is distinct from labels.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the annotations present in your configuration.
    /// Please refer to the field &#39;effective_annotations&#39; for all of the annotations present on the resource.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Annotations
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("annotations");
        set => this.WithProperty("annotations", value);
    }

    /// <summary>
    /// &#39;Availability type of an Instance. Defaults to REGIONAL for both primary and read instances.
    /// Note that primary and read instances can have different availability types.
    /// Primary instances can be either ZONAL or REGIONAL. Read Pool instances can also be either ZONAL or REGIONAL.
    /// Read pools of size 1 can only have zonal availability. Read pools with a node count of 2 or more
    /// can have regional availability (nodes are present in 2 or more zones in a region).
    /// Possible values are: &#39;AVAILABILITY_TYPE_UNSPECIFIED&#39;, &#39;ZONAL&#39;, &#39;REGIONAL&#39;.&#39; Possible values: [&amp;quot;AVAILABILITY_TYPE_UNSPECIFIED&amp;quot;, &amp;quot;ZONAL&amp;quot;, &amp;quot;REGIONAL&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? AvailabilityType
    {
        get => GetProperty<TerraformProperty<string>>("availability_type");
        set => this.WithProperty("availability_type", value);
    }

    /// <summary>
    /// Identifies the alloydb cluster. Must be in the format
    /// &#39;projects/{project}/locations/{location}/clusters/{cluster_id}&#39;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Cluster is required")]
    public required TerraformProperty<string> Cluster
    {
        get => GetRequiredProperty<TerraformProperty<string>>("cluster");
        set => this.WithProperty("cluster", value);
    }

    /// <summary>
    /// Database flags. Set at instance level. * They are copied from primary instance on read instance creation. * Read instances can set new or override existing flags that are relevant for reads, e.g. for enabling columnar cache on a read instance. Flags set on read instance may or may not be present on primary.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? DatabaseFlags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("database_flags");
        set => this.WithProperty("database_flags", value);
    }

    /// <summary>
    /// User-settable and human-readable display name for the Instance.
    /// </summary>
    public TerraformProperty<string>? DisplayName
    {
        get => GetProperty<TerraformProperty<string>>("display_name");
        set => this.WithProperty("display_name", value);
    }

    /// <summary>
    /// The Compute Engine zone that the instance should serve from, per https://cloud.google.com/compute/docs/regions-zones This can ONLY be specified for ZONAL instances. If present for a REGIONAL instance, an error will be thrown. If this is absent for a ZONAL instance, instance is created in a random zone with available capacity.
    /// </summary>
    public TerraformProperty<string>? GceZone
    {
        get => GetProperty<TerraformProperty<string>>("gce_zone");
        set => this.WithProperty("gce_zone", value);
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
    /// The ID of the alloydb instance.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceId is required")]
    public required TerraformProperty<string> InstanceId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("instance_id");
        set => this.WithProperty("instance_id", value);
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
    public required TerraformProperty<string> InstanceType
    {
        get => GetRequiredProperty<TerraformProperty<string>>("instance_type");
        set => this.WithProperty("instance_type", value);
    }

    /// <summary>
    /// User-defined labels for the alloydb instance.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Labels
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("labels");
        set => this.WithProperty("labels", value);
    }

    /// <summary>
    /// Block for client_connection_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ClientConnectionConfig block(s) allowed")]
    public List<GoogleAlloydbInstanceClientConnectionConfigBlock>? ClientConnectionConfig
    {
        get => GetProperty<List<GoogleAlloydbInstanceClientConnectionConfigBlock>>("client_connection_config");
        set => this.WithProperty("client_connection_config", value);
    }

    /// <summary>
    /// Block for machine_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MachineConfig block(s) allowed")]
    public List<GoogleAlloydbInstanceMachineConfigBlock>? MachineConfig
    {
        get => GetProperty<List<GoogleAlloydbInstanceMachineConfigBlock>>("machine_config");
        set => this.WithProperty("machine_config", value);
    }

    /// <summary>
    /// Block for network_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NetworkConfig block(s) allowed")]
    public List<GoogleAlloydbInstanceNetworkConfigBlock>? NetworkConfig
    {
        get => GetProperty<List<GoogleAlloydbInstanceNetworkConfigBlock>>("network_config");
        set => this.WithProperty("network_config", value);
    }

    /// <summary>
    /// Block for psc_instance_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PscInstanceConfig block(s) allowed")]
    public List<GoogleAlloydbInstancePscInstanceConfigBlock>? PscInstanceConfig
    {
        get => GetProperty<List<GoogleAlloydbInstancePscInstanceConfigBlock>>("psc_instance_config");
        set => this.WithProperty("psc_instance_config", value);
    }

    /// <summary>
    /// Block for query_insights_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 QueryInsightsConfig block(s) allowed")]
    public List<GoogleAlloydbInstanceQueryInsightsConfigBlock>? QueryInsightsConfig
    {
        get => GetProperty<List<GoogleAlloydbInstanceQueryInsightsConfigBlock>>("query_insights_config");
        set => this.WithProperty("query_insights_config", value);
    }

    /// <summary>
    /// Block for read_pool_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ReadPoolConfig block(s) allowed")]
    public List<GoogleAlloydbInstanceReadPoolConfigBlock>? ReadPoolConfig
    {
        get => GetProperty<List<GoogleAlloydbInstanceReadPoolConfigBlock>>("read_pool_config");
        set => this.WithProperty("read_pool_config", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleAlloydbInstanceTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleAlloydbInstanceTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// Time the Instance was created in UTC.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// All of annotations (key/value pairs) present on the resource in GCP, including the annotations configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveAnnotations => this["effective_annotations"];

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveLabels => this["effective_labels"];

    /// <summary>
    /// The IP address for the Instance. This is the connection endpoint for an end-user application.
    /// </summary>
    public TerraformExpression IpAddress => this["ip_address"];

    /// <summary>
    /// The name of the instance resource.
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// The outbound public IP addresses for the instance. This is available ONLY when
    /// networkConfig.enableOutboundPublicIp is set to true. These IP addresses are used
    /// for outbound connections.
    /// </summary>
    public TerraformExpression OutboundPublicIpAddresses => this["outbound_public_ip_addresses"];

    /// <summary>
    /// The public IP addresses for the Instance. This is available ONLY when
    /// networkConfig.enablePublicIp is set to true. This is the connection
    /// endpoint for an end-user application.
    /// </summary>
    public TerraformExpression PublicIpAddress => this["public_ip_address"];

    /// <summary>
    /// Set to true if the current state of Instance does not match the user&#39;s intended state, and the service is actively updating the resource to reconcile them. This can happen due to user-triggered updates or system actions like failover or maintenance.
    /// </summary>
    public TerraformExpression Reconciling => this["reconciling"];

    /// <summary>
    /// The current state of the alloydb instance.
    /// </summary>
    public TerraformExpression State => this["state"];

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformExpression TerraformLabels => this["terraform_labels"];

    /// <summary>
    /// The system-generated UID of the resource.
    /// </summary>
    public TerraformExpression Uid => this["uid"];

    /// <summary>
    /// Time the Instance was updated in UTC.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

}
