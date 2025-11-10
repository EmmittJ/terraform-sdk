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
    public TerraformProperty<TerraformProperty<string>>? Filter { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The most_recent attribute.
    /// </summary>
    [TerraformPropertyName("most_recent")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? MostRecent { get; set; }

    /// <summary>
    /// The name of the instance template. If you leave this blank, Terraform will auto-generate a unique name.
    /// </summary>
    [TerraformPropertyName("name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Name { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs. If it is not provided, the provider project is used.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Project { get; set; }

    /// <summary>
    /// The region in which the instance template is located. If it is not provided, the provider region is used.
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Region { get; set; }

    /// <summary>
    /// Controls for advanced machine-related behavior features.
    /// </summary>
    [TerraformPropertyName("advanced_machine_features")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> AdvancedMachineFeatures => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "advanced_machine_features");

    /// <summary>
    /// Whether to allow sending and receiving of packets with non-matching source or destination IPs. This defaults to false.
    /// </summary>
    [TerraformPropertyName("can_ip_forward")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> CanIpForward => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "can_ip_forward");

    /// <summary>
    /// The Confidential VM config being used by the instance. on_host_maintenance has to be set to TERMINATE or this will fail to create.
    /// </summary>
    [TerraformPropertyName("confidential_instance_config")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> ConfidentialInstanceConfig => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "confidential_instance_config");

    /// <summary>
    /// The time at which the instance was created in RFC 3339 format.
    /// </summary>
    [TerraformPropertyName("creation_timestamp")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreationTimestamp => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "creation_timestamp");

    /// <summary>
    /// A brief description of this resource.
    /// </summary>
    [TerraformPropertyName("description")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Description => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "description");

    /// <summary>
    /// Disks to attach to instances created from this template. This can be specified multiple times for multiple disks.
    /// </summary>
    [TerraformPropertyName("disk")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Disk => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "disk");

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformPropertyName("effective_labels")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> EffectiveLabels => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "effective_labels");

    /// <summary>
    /// List of the type and count of accelerator cards attached to the instance.
    /// </summary>
    [TerraformPropertyName("guest_accelerator")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> GuestAccelerator => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "guest_accelerator");

    /// <summary>
    /// A description of the instance.
    /// </summary>
    [TerraformPropertyName("instance_description")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> InstanceDescription => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "instance_description");

    /// <summary>
    /// Action to be taken when a customer&#39;s encryption key is revoked. Supports &amp;quot;STOP&amp;quot; and &amp;quot;NONE&amp;quot;, with &amp;quot;NONE&amp;quot; being the default.
    /// </summary>
    [TerraformPropertyName("key_revocation_action_type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> KeyRevocationActionType => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "key_revocation_action_type");

    /// <summary>
    /// A set of key/value label pairs to assign to instances created from this template,
    /// 
    /// 				**Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// 				Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformPropertyName("labels")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Labels => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "labels");

    /// <summary>
    /// The machine type to create. To create a machine with a custom type (such as extended memory), format the value like custom-VCPUS-MEM_IN_MB like custom-6-20480 for 6 vCPU and 20GB of RAM.
    /// </summary>
    [TerraformPropertyName("machine_type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> MachineType => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "machine_type");

    /// <summary>
    /// Metadata key/value pairs to make available from within instances created from this template.
    /// </summary>
    [TerraformPropertyName("metadata")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Metadata => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "metadata");

    /// <summary>
    /// The unique fingerprint of the metadata.
    /// </summary>
    [TerraformPropertyName("metadata_fingerprint")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> MetadataFingerprint => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "metadata_fingerprint");

    /// <summary>
    /// An alternative to using the startup-script metadata key, mostly to match the compute_instance resource. This replaces the startup-script metadata key on the created instance and thus the two mechanisms are not allowed to be used simultaneously.
    /// </summary>
    [TerraformPropertyName("metadata_startup_script")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> MetadataStartupScript => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "metadata_startup_script");

    /// <summary>
    /// Specifies a minimum CPU platform. Applicable values are the friendly names of CPU platforms, such as Intel Haswell or Intel Skylake.
    /// </summary>
    [TerraformPropertyName("min_cpu_platform")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> MinCpuPlatform => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "min_cpu_platform");

    /// <summary>
    /// Creates a unique name beginning with the specified prefix. Conflicts with name.
    /// </summary>
    [TerraformPropertyName("name_prefix")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> NamePrefix => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name_prefix");

    /// <summary>
    /// Networks to attach to instances created from this template. This can be specified multiple times for multiple networks.
    /// </summary>
    [TerraformPropertyName("network_interface")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> NetworkInterface => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "network_interface");

    /// <summary>
    /// Configures network performance settings for the instance. If not specified, the instance will be created with its default network performance configuration.
    /// </summary>
    [TerraformPropertyName("network_performance_config")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> NetworkPerformanceConfig => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "network_performance_config");

    /// <summary>
    /// The ID of the template in numeric format.
    /// </summary>
    [TerraformPropertyName("numeric_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> NumericId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "numeric_id");

    /// <summary>
    /// Specifies the reservations that this instance can consume from.
    /// </summary>
    [TerraformPropertyName("reservation_affinity")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> ReservationAffinity => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "reservation_affinity");

    /// <summary>
    /// A map of resource manager tags.
    /// 				Resource manager tag keys and values have the same definition as resource manager tags. Keys must be in the format tagKeys/{tag_key_id}, and values are in the format tagValues/456. The field is ignored (both PUT &amp;amp; PATCH) when empty.
    /// </summary>
    [TerraformPropertyName("resource_manager_tags")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> ResourceManagerTags => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "resource_manager_tags");

    /// <summary>
    /// A list of self_links of resource policies to attach to the instance. Currently a max of 1 resource policy is supported.
    /// </summary>
    [TerraformPropertyName("resource_policies")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> ResourcePolicies => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "resource_policies");

    /// <summary>
    /// The scheduling strategy to use.
    /// </summary>
    [TerraformPropertyName("scheduling")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Scheduling => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "scheduling");

    /// <summary>
    /// The URI of the created resource.
    /// </summary>
    [TerraformPropertyName("self_link")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SelfLink => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "self_link");

    /// <summary>
    /// Service account to attach to the instance.
    /// </summary>
    [TerraformPropertyName("service_account")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> ServiceAccount => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "service_account");

    /// <summary>
    /// Enable Shielded VM on this instance. Shielded VM provides verifiable integrity to prevent against malware and rootkits. Defaults to disabled. Note: shielded_instance_config can only be used with boot images with shielded vm support.
    /// </summary>
    [TerraformPropertyName("shielded_instance_config")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> ShieldedInstanceConfig => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "shielded_instance_config");

    /// <summary>
    /// Tags to attach to the instance.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<string>>> Tags => new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "tags");

    /// <summary>
    /// The unique fingerprint of the tags.
    /// </summary>
    [TerraformPropertyName("tags_fingerprint")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> TagsFingerprint => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "tags_fingerprint");

    /// <summary>
    /// The combination of labels configured directly on the resource and default labels configured on the provider.
    /// </summary>
    [TerraformPropertyName("terraform_labels")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TerraformLabels => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "terraform_labels");

}
