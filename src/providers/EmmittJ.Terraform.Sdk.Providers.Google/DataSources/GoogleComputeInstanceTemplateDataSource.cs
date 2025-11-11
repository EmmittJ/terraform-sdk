using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_compute_instance_template.
/// </summary>
public partial class GoogleComputeInstanceTemplateDataSource : TerraformDataSource
{
    public GoogleComputeInstanceTemplateDataSource(string name) : base("google_compute_instance_template", name)
    {
    }

    /// <summary>
    /// The filter attribute.
    /// </summary>
    [TerraformProperty("filter")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Filter { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The most_recent attribute.
    /// </summary>
    [TerraformProperty("most_recent")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? MostRecent { get; set; }

    /// <summary>
    /// The name of the instance template. If you leave this blank, Terraform will auto-generate a unique name.
    /// </summary>
    [TerraformProperty("name")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Name { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs. If it is not provided, the provider project is used.
    /// </summary>
    [TerraformProperty("project")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Project { get; set; }

    /// <summary>
    /// The self_link_unique attribute.
    /// </summary>
    [TerraformProperty("self_link_unique")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? SelfLinkUnique { get; set; }

    /// <summary>
    /// Controls for advanced machine-related behavior features.
    /// </summary>
    [TerraformProperty("advanced_machine_features")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> AdvancedMachineFeatures { get; }

    /// <summary>
    /// Whether to allow sending and receiving of packets with non-matching source or destination IPs. This defaults to false.
    /// </summary>
    [TerraformProperty("can_ip_forward")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> CanIpForward { get; }

    /// <summary>
    /// The Confidential VM config being used by the instance. on_host_maintenance has to be set to TERMINATE or this will fail to create.
    /// </summary>
    [TerraformProperty("confidential_instance_config")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> ConfidentialInstanceConfig { get; }

    /// <summary>
    /// Creation timestamp in RFC3339 text format.
    /// </summary>
    [TerraformProperty("creation_timestamp")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> CreationTimestamp { get; }

    /// <summary>
    /// A brief description of this resource.
    /// </summary>
    [TerraformProperty("description")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Description { get; }

    /// <summary>
    /// Disks to attach to instances created from this template. This can be specified multiple times for multiple disks.
    /// </summary>
    [TerraformProperty("disk")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> Disk { get; }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformProperty("effective_labels")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformMap<string> EffectiveLabels { get; }

    /// <summary>
    /// List of the type and count of accelerator cards attached to the instance.
    /// </summary>
    [TerraformProperty("guest_accelerator")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> GuestAccelerator { get; }

    /// <summary>
    /// A description of the instance.
    /// </summary>
    [TerraformProperty("instance_description")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> InstanceDescription { get; }

    /// <summary>
    /// Action to be taken when a customer&#39;s encryption key is revoked. Supports &amp;quot;STOP&amp;quot; and &amp;quot;NONE&amp;quot;, with &amp;quot;NONE&amp;quot; being the default.
    /// </summary>
    [TerraformProperty("key_revocation_action_type")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> KeyRevocationActionType { get; }

    /// <summary>
    /// A set of key/value label pairs to assign to instances created from this template.
    /// 
    /// 				**Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// 				Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformProperty("labels")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformMap<string> Labels { get; }

    /// <summary>
    /// The machine type to create. To create a machine with a custom type (such as extended memory), format the value like custom-VCPUS-MEM_IN_MB like custom-6-20480 for 6 vCPU and 20GB of RAM.
    /// </summary>
    [TerraformProperty("machine_type")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> MachineType { get; }

    /// <summary>
    /// Metadata key/value pairs to make available from within instances created from this template.
    /// </summary>
    [TerraformProperty("metadata")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformMap<string> Metadata { get; }

    /// <summary>
    /// The unique fingerprint of the metadata.
    /// </summary>
    [TerraformProperty("metadata_fingerprint")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> MetadataFingerprint { get; }

    /// <summary>
    /// An alternative to using the startup-script metadata key, mostly to match the compute_instance resource. This replaces the startup-script metadata key on the created instance and thus the two mechanisms are not allowed to be used simultaneously.
    /// </summary>
    [TerraformProperty("metadata_startup_script")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> MetadataStartupScript { get; }

    /// <summary>
    /// Specifies a minimum CPU platform. Applicable values are the friendly names of CPU platforms, such as Intel Haswell or Intel Skylake.
    /// </summary>
    [TerraformProperty("min_cpu_platform")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> MinCpuPlatform { get; }

    /// <summary>
    /// Creates a unique name beginning with the specified prefix. Conflicts with name. Max length is 54 characters. Prefixes with lengths longer than 37 characters will use a shortened UUID that will be more prone to collisions.
    /// </summary>
    [TerraformProperty("name_prefix")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> NamePrefix { get; }

    /// <summary>
    /// Networks to attach to instances created from this template. This can be specified multiple times for multiple networks.
    /// </summary>
    [TerraformProperty("network_interface")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> NetworkInterface { get; }

    /// <summary>
    /// Configures network performance settings for the instance. If not specified, the instance will be created with its default network performance configuration.
    /// </summary>
    [TerraformProperty("network_performance_config")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> NetworkPerformanceConfig { get; }

    /// <summary>
    /// The ID of the template in numeric format.
    /// </summary>
    [TerraformProperty("numeric_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> NumericId { get; }

    /// <summary>
    /// An instance template is a global resource that is not bound to a zone or a region. However, you can still specify some regional resources in an instance template, which restricts the template to the region where that resource resides. For example, a custom subnetwork resource is tied to a specific region. Defaults to the region of the Provider if no value is given.
    /// </summary>
    [TerraformProperty("region")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Region { get; }

    /// <summary>
    /// Specifies the reservations that this instance can consume from.
    /// </summary>
    [TerraformProperty("reservation_affinity")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> ReservationAffinity { get; }

    /// <summary>
    /// A map of resource manager tags.
    /// 				Resource manager tag keys and values have the same definition as resource manager tags.
    /// 				Keys must be in the format tagKeys/{tag_key_id}, and values are in the format tagValues/456.
    /// 				The field is ignored (both PUT &amp;amp; PATCH) when empty.
    /// </summary>
    [TerraformProperty("resource_manager_tags")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformMap<string> ResourceManagerTags { get; }

    /// <summary>
    /// A list of self_links of resource policies to attach to the instance. Currently a max of 1 resource policy is supported.
    /// </summary>
    [TerraformProperty("resource_policies")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<string> ResourcePolicies { get; }

    /// <summary>
    /// The scheduling strategy to use.
    /// </summary>
    [TerraformProperty("scheduling")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> Scheduling { get; }

    /// <summary>
    /// The URI of the created resource.
    /// </summary>
    [TerraformProperty("self_link")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> SelfLink { get; }

    /// <summary>
    /// Service account to attach to the instance.
    /// </summary>
    [TerraformProperty("service_account")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> ServiceAccount { get; }

    /// <summary>
    /// Enable Shielded VM on this instance. Shielded VM provides verifiable integrity to prevent against malware and rootkits. Defaults to disabled. Note: shielded_instance_config can only be used with boot images with shielded vm support.
    /// </summary>
    [TerraformProperty("shielded_instance_config")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> ShieldedInstanceConfig { get; }

    /// <summary>
    /// Tags to attach to the instance.
    /// </summary>
    [TerraformProperty("tags")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformSet<string> Tags { get; }

    /// <summary>
    /// The unique fingerprint of the tags.
    /// </summary>
    [TerraformProperty("tags_fingerprint")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> TagsFingerprint { get; }

    /// <summary>
    /// The combination of labels configured directly on the resource and default labels configured on the provider.
    /// </summary>
    [TerraformProperty("terraform_labels")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformMap<string> TerraformLabels { get; }

}
