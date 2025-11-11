using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_compute_region_instance_template.
/// </summary>
public class GoogleComputeRegionInstanceTemplateDataSource : TerraformDataSource
{
    public GoogleComputeRegionInstanceTemplateDataSource(string name) : base("google_compute_region_instance_template", name)
    {
    }

    /// <summary>
    /// The filter attribute.
    /// </summary>
    [TerraformPropertyName("filter")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Filter { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The most_recent attribute.
    /// </summary>
    [TerraformPropertyName("most_recent")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? MostRecent { get; set; }

    /// <summary>
    /// The name of the instance template. If you leave this blank, Terraform will auto-generate a unique name.
    /// </summary>
    [TerraformPropertyName("name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Name { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs. If it is not provided, the provider project is used.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Project { get; set; }

    /// <summary>
    /// The region in which the instance template is located. If it is not provided, the provider region is used.
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Region { get; set; }

    /// <summary>
    /// Controls for advanced machine-related behavior features.
    /// </summary>
    [TerraformPropertyName("advanced_machine_features")]
    // Output-only attribute - read-only reference
    public TerraformList<object> AdvancedMachineFeatures => new TerraformReference(this, "advanced_machine_features");

    /// <summary>
    /// Whether to allow sending and receiving of packets with non-matching source or destination IPs. This defaults to false.
    /// </summary>
    [TerraformPropertyName("can_ip_forward")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> CanIpForward => new TerraformReference(this, "can_ip_forward");

    /// <summary>
    /// The Confidential VM config being used by the instance. on_host_maintenance has to be set to TERMINATE or this will fail to create.
    /// </summary>
    [TerraformPropertyName("confidential_instance_config")]
    // Output-only attribute - read-only reference
    public TerraformList<object> ConfidentialInstanceConfig => new TerraformReference(this, "confidential_instance_config");

    /// <summary>
    /// The time at which the instance was created in RFC 3339 format.
    /// </summary>
    [TerraformPropertyName("creation_timestamp")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CreationTimestamp => new TerraformReference(this, "creation_timestamp");

    /// <summary>
    /// A brief description of this resource.
    /// </summary>
    [TerraformPropertyName("description")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Description => new TerraformReference(this, "description");

    /// <summary>
    /// Disks to attach to instances created from this template. This can be specified multiple times for multiple disks.
    /// </summary>
    [TerraformPropertyName("disk")]
    // Output-only attribute - read-only reference
    public TerraformList<object> Disk => new TerraformReference(this, "disk");

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformPropertyName("effective_labels")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> EffectiveLabels => new TerraformReference(this, "effective_labels");

    /// <summary>
    /// List of the type and count of accelerator cards attached to the instance.
    /// </summary>
    [TerraformPropertyName("guest_accelerator")]
    // Output-only attribute - read-only reference
    public TerraformList<object> GuestAccelerator => new TerraformReference(this, "guest_accelerator");

    /// <summary>
    /// A description of the instance.
    /// </summary>
    [TerraformPropertyName("instance_description")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> InstanceDescription => new TerraformReference(this, "instance_description");

    /// <summary>
    /// Action to be taken when a customer&#39;s encryption key is revoked. Supports &amp;quot;STOP&amp;quot; and &amp;quot;NONE&amp;quot;, with &amp;quot;NONE&amp;quot; being the default.
    /// </summary>
    [TerraformPropertyName("key_revocation_action_type")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> KeyRevocationActionType => new TerraformReference(this, "key_revocation_action_type");

    /// <summary>
    /// A set of key/value label pairs to assign to instances created from this template,
    /// 
    /// 				**Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// 				Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformPropertyName("labels")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> Labels => new TerraformReference(this, "labels");

    /// <summary>
    /// The machine type to create. To create a machine with a custom type (such as extended memory), format the value like custom-VCPUS-MEM_IN_MB like custom-6-20480 for 6 vCPU and 20GB of RAM.
    /// </summary>
    [TerraformPropertyName("machine_type")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> MachineType => new TerraformReference(this, "machine_type");

    /// <summary>
    /// Metadata key/value pairs to make available from within instances created from this template.
    /// </summary>
    [TerraformPropertyName("metadata")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> Metadata => new TerraformReference(this, "metadata");

    /// <summary>
    /// The unique fingerprint of the metadata.
    /// </summary>
    [TerraformPropertyName("metadata_fingerprint")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> MetadataFingerprint => new TerraformReference(this, "metadata_fingerprint");

    /// <summary>
    /// An alternative to using the startup-script metadata key, mostly to match the compute_instance resource. This replaces the startup-script metadata key on the created instance and thus the two mechanisms are not allowed to be used simultaneously.
    /// </summary>
    [TerraformPropertyName("metadata_startup_script")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> MetadataStartupScript => new TerraformReference(this, "metadata_startup_script");

    /// <summary>
    /// Specifies a minimum CPU platform. Applicable values are the friendly names of CPU platforms, such as Intel Haswell or Intel Skylake.
    /// </summary>
    [TerraformPropertyName("min_cpu_platform")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> MinCpuPlatform => new TerraformReference(this, "min_cpu_platform");

    /// <summary>
    /// Creates a unique name beginning with the specified prefix. Conflicts with name.
    /// </summary>
    [TerraformPropertyName("name_prefix")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> NamePrefix => new TerraformReference(this, "name_prefix");

    /// <summary>
    /// Networks to attach to instances created from this template. This can be specified multiple times for multiple networks.
    /// </summary>
    [TerraformPropertyName("network_interface")]
    // Output-only attribute - read-only reference
    public TerraformList<object> NetworkInterface => new TerraformReference(this, "network_interface");

    /// <summary>
    /// Configures network performance settings for the instance. If not specified, the instance will be created with its default network performance configuration.
    /// </summary>
    [TerraformPropertyName("network_performance_config")]
    // Output-only attribute - read-only reference
    public TerraformList<object> NetworkPerformanceConfig => new TerraformReference(this, "network_performance_config");

    /// <summary>
    /// The ID of the template in numeric format.
    /// </summary>
    [TerraformPropertyName("numeric_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> NumericId => new TerraformReference(this, "numeric_id");

    /// <summary>
    /// Specifies the reservations that this instance can consume from.
    /// </summary>
    [TerraformPropertyName("reservation_affinity")]
    // Output-only attribute - read-only reference
    public TerraformList<object> ReservationAffinity => new TerraformReference(this, "reservation_affinity");

    /// <summary>
    /// A map of resource manager tags.
    /// 				Resource manager tag keys and values have the same definition as resource manager tags. Keys must be in the format tagKeys/{tag_key_id}, and values are in the format tagValues/456. The field is ignored (both PUT &amp;amp; PATCH) when empty.
    /// </summary>
    [TerraformPropertyName("resource_manager_tags")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> ResourceManagerTags => new TerraformReference(this, "resource_manager_tags");

    /// <summary>
    /// A list of self_links of resource policies to attach to the instance. Currently a max of 1 resource policy is supported.
    /// </summary>
    [TerraformPropertyName("resource_policies")]
    // Output-only attribute - read-only reference
    public TerraformList<string> ResourcePolicies => new TerraformReference(this, "resource_policies");

    /// <summary>
    /// The scheduling strategy to use.
    /// </summary>
    [TerraformPropertyName("scheduling")]
    // Output-only attribute - read-only reference
    public TerraformList<object> Scheduling => new TerraformReference(this, "scheduling");

    /// <summary>
    /// The URI of the created resource.
    /// </summary>
    [TerraformPropertyName("self_link")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SelfLink => new TerraformReference(this, "self_link");

    /// <summary>
    /// Service account to attach to the instance.
    /// </summary>
    [TerraformPropertyName("service_account")]
    // Output-only attribute - read-only reference
    public TerraformList<object> ServiceAccount => new TerraformReference(this, "service_account");

    /// <summary>
    /// Enable Shielded VM on this instance. Shielded VM provides verifiable integrity to prevent against malware and rootkits. Defaults to disabled. Note: shielded_instance_config can only be used with boot images with shielded vm support.
    /// </summary>
    [TerraformPropertyName("shielded_instance_config")]
    // Output-only attribute - read-only reference
    public TerraformList<object> ShieldedInstanceConfig => new TerraformReference(this, "shielded_instance_config");

    /// <summary>
    /// Tags to attach to the instance.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Output-only attribute - read-only reference
    public TerraformSet<string> Tags => new TerraformReference(this, "tags");

    /// <summary>
    /// The unique fingerprint of the tags.
    /// </summary>
    [TerraformPropertyName("tags_fingerprint")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> TagsFingerprint => new TerraformReference(this, "tags_fingerprint");

    /// <summary>
    /// The combination of labels configured directly on the resource and default labels configured on the provider.
    /// </summary>
    [TerraformPropertyName("terraform_labels")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> TerraformLabels => new TerraformReference(this, "terraform_labels");

}
