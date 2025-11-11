using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_alloydb_instance.
/// </summary>
public partial class GoogleAlloydbInstanceDataSource : TerraformDataSource
{
    public GoogleAlloydbInstanceDataSource(string name) : base("google_alloydb_instance", name)
    {
    }

    /// <summary>
    /// The ID of the alloydb cluster that the instance belongs to.&#39;alloydb_cluster_id&#39;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterId is required")]
    [TerraformProperty("cluster_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ClusterId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The ID of the alloydb instance.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceId is required")]
    [TerraformProperty("instance_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> InstanceId { get; set; }

    /// <summary>
    /// The canonical ID for the location. For example: &amp;quot;us-east1&amp;quot;.
    /// </summary>
    [TerraformProperty("location")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Location { get; set; }

    /// <summary>
    /// Project ID of the project.
    /// </summary>
    [TerraformProperty("project")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Project { get; set; }

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
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ActivationPolicy { get; }

    /// <summary>
    /// Annotations to allow client tools to store small amount of arbitrary data. This is distinct from labels.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the annotations present in your configuration.
    /// Please refer to the field &#39;effective_annotations&#39; for all of the annotations present on the resource.
    /// </summary>
    [TerraformProperty("annotations")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformMap<string> Annotations { get; }

    /// <summary>
    /// &#39;Availability type of an Instance. Defaults to REGIONAL for both primary and read instances.
    /// Note that primary and read instances can have different availability types.
    /// Primary instances can be either ZONAL or REGIONAL. Read Pool instances can also be either ZONAL or REGIONAL.
    /// Read pools of size 1 can only have zonal availability. Read pools with a node count of 2 or more
    /// can have regional availability (nodes are present in 2 or more zones in a region).
    /// Possible values are: &#39;AVAILABILITY_TYPE_UNSPECIFIED&#39;, &#39;ZONAL&#39;, &#39;REGIONAL&#39;.&#39; Possible values: [&amp;quot;AVAILABILITY_TYPE_UNSPECIFIED&amp;quot;, &amp;quot;ZONAL&amp;quot;, &amp;quot;REGIONAL&amp;quot;]
    /// </summary>
    [TerraformProperty("availability_type")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> AvailabilityType { get; }

    /// <summary>
    /// Client connection specific configurations.
    /// </summary>
    [TerraformProperty("client_connection_config")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> ClientConnectionConfig { get; }

    /// <summary>
    /// Identifies the alloydb cluster. Must be in the format
    /// &#39;projects/{project}/locations/{location}/clusters/{cluster_id}&#39;
    /// </summary>
    [TerraformProperty("cluster")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Cluster { get; }

    /// <summary>
    /// Time the Instance was created in UTC.
    /// </summary>
    [TerraformProperty("create_time")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> CreateTime { get; }

    /// <summary>
    /// Database flags. Set at instance level. * They are copied from primary instance on read instance creation. * Read instances can set new or override existing flags that are relevant for reads, e.g. for enabling columnar cache on a read instance. Flags set on read instance may or may not be present on primary.
    /// </summary>
    [TerraformProperty("database_flags")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformMap<string> DatabaseFlags { get; }

    /// <summary>
    /// User-settable and human-readable display name for the Instance.
    /// </summary>
    [TerraformProperty("display_name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> DisplayName { get; }

    /// <summary>
    /// All of annotations (key/value pairs) present on the resource in GCP, including the annotations configured through Terraform, other clients and services.
    /// </summary>
    [TerraformProperty("effective_annotations")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformMap<string> EffectiveAnnotations { get; }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformProperty("effective_labels")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformMap<string> EffectiveLabels { get; }

    /// <summary>
    /// The Compute Engine zone that the instance should serve from, per https://cloud.google.com/compute/docs/regions-zones This can ONLY be specified for ZONAL instances. If present for a REGIONAL instance, an error will be thrown. If this is absent for a ZONAL instance, instance is created in a random zone with available capacity.
    /// </summary>
    [TerraformProperty("gce_zone")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> GceZone { get; }

    /// <summary>
    /// The type of the instance.
    /// If the instance type is READ_POOL, provide the associated PRIMARY/SECONDARY instance in the &#39;depends_on&#39; meta-data attribute.
    /// If the instance type is SECONDARY, point to the cluster_type of the associated secondary cluster instead of mentioning SECONDARY.
    /// Example: {instance_type = google_alloydb_cluster.&amp;lt;secondary_cluster_name&amp;gt;.cluster_type} instead of {instance_type = SECONDARY}
    /// If the instance type is SECONDARY, the terraform delete instance operation does not delete the secondary instance but abandons it instead.
    /// Use deletion_policy = &amp;quot;FORCE&amp;quot; in the associated secondary cluster and delete the cluster forcefully to delete the secondary cluster as well its associated secondary instance.
    /// Users can undo the delete secondary instance action by importing the deleted secondary instance by calling terraform import. Possible values: [&amp;quot;PRIMARY&amp;quot;, &amp;quot;READ_POOL&amp;quot;, &amp;quot;SECONDARY&amp;quot;]
    /// </summary>
    [TerraformProperty("instance_type")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> InstanceType { get; }

    /// <summary>
    /// The IP address for the Instance. This is the connection endpoint for an end-user application.
    /// </summary>
    [TerraformProperty("ip_address")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> IpAddress { get; }

    /// <summary>
    /// User-defined labels for the alloydb instance.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformProperty("labels")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformMap<string> Labels { get; }

    /// <summary>
    /// Configurations for the machines that host the underlying database engine.
    /// </summary>
    [TerraformProperty("machine_config")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> MachineConfig { get; }

    /// <summary>
    /// The name of the instance resource.
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Name { get; }

    /// <summary>
    /// Instance level network configuration.
    /// </summary>
    [TerraformProperty("network_config")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> NetworkConfig { get; }

    /// <summary>
    /// The outbound public IP addresses for the instance. This is available ONLY when
    /// networkConfig.enableOutboundPublicIp is set to true. These IP addresses are used
    /// for outbound connections.
    /// </summary>
    [TerraformProperty("outbound_public_ip_addresses")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<string> OutboundPublicIpAddresses { get; }

    /// <summary>
    /// Configuration for Private Service Connect (PSC) for the instance.
    /// </summary>
    [TerraformProperty("psc_instance_config")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> PscInstanceConfig { get; }

    /// <summary>
    /// The public IP addresses for the Instance. This is available ONLY when
    /// networkConfig.enablePublicIp is set to true. This is the connection
    /// endpoint for an end-user application.
    /// </summary>
    [TerraformProperty("public_ip_address")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> PublicIpAddress { get; }

    /// <summary>
    /// Configuration for query insights.
    /// </summary>
    [TerraformProperty("query_insights_config")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> QueryInsightsConfig { get; }

    /// <summary>
    /// Read pool specific config. If the instance type is READ_POOL, this configuration must be provided.
    /// </summary>
    [TerraformProperty("read_pool_config")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> ReadPoolConfig { get; }

    /// <summary>
    /// Set to true if the current state of Instance does not match the user&#39;s intended state, and the service is actively updating the resource to reconcile them. This can happen due to user-triggered updates or system actions like failover or maintenance.
    /// </summary>
    [TerraformProperty("reconciling")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> Reconciling { get; }

    /// <summary>
    /// The current state of the alloydb instance.
    /// </summary>
    [TerraformProperty("state")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> State { get; }

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformProperty("terraform_labels")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformMap<string> TerraformLabels { get; }

    /// <summary>
    /// The system-generated UID of the resource.
    /// </summary>
    [TerraformProperty("uid")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Uid { get; }

    /// <summary>
    /// Time the Instance was updated in UTC.
    /// </summary>
    [TerraformProperty("update_time")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> UpdateTime { get; }

}
