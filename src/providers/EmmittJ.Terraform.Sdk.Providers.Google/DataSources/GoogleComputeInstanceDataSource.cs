using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_compute_instance.
/// </summary>
public class GoogleComputeInstanceDataSource : TerraformDataSource
{
    public GoogleComputeInstanceDataSource(string name) : base("google_compute_instance", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The name of the instance. One of name or self_link must be provided.
    /// </summary>
    [TerraformPropertyName("name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Name { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs. If self_link is provided, this value is ignored. If neither self_link nor project are provided, the provider project is used.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Project { get; set; }

    /// <summary>
    /// The URI of the created resource.
    /// </summary>
    [TerraformPropertyName("self_link")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? SelfLink { get; set; }

    /// <summary>
    /// The zone of the instance. If self_link is provided, this value is ignored. If neither self_link nor zone are provided, the provider zone is used.
    /// </summary>
    [TerraformPropertyName("zone")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Zone { get; set; }

    /// <summary>
    /// Controls for advanced machine-related behavior features.
    /// </summary>
    [TerraformPropertyName("advanced_machine_features")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> AdvancedMachineFeatures => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "advanced_machine_features");

    /// <summary>
    /// If true, allows Terraform to stop the instance to update its properties. If you try to update a property that requires stopping the instance without setting this field, the update will fail.
    /// </summary>
    [TerraformPropertyName("allow_stopping_for_update")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> AllowStoppingForUpdate => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "allow_stopping_for_update");

    /// <summary>
    /// List of disks attached to the instance
    /// </summary>
    [TerraformPropertyName("attached_disk")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> AttachedDisk => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "attached_disk");

    /// <summary>
    /// The boot disk for the instance.
    /// </summary>
    [TerraformPropertyName("boot_disk")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> BootDisk => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "boot_disk");

    /// <summary>
    /// Whether sending and receiving of packets with non-matching source or destination IPs is allowed.
    /// </summary>
    [TerraformPropertyName("can_ip_forward")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> CanIpForward => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "can_ip_forward");

    /// <summary>
    /// The Confidential VM config being used by the instance.  on_host_maintenance has to be set to TERMINATE or this will fail to create.
    /// </summary>
    [TerraformPropertyName("confidential_instance_config")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> ConfidentialInstanceConfig => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "confidential_instance_config");

    /// <summary>
    /// The CPU platform used by this instance.
    /// </summary>
    [TerraformPropertyName("cpu_platform")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CpuPlatform => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "cpu_platform");

    /// <summary>
    /// Creation timestamp in RFC3339 text format.
    /// </summary>
    [TerraformPropertyName("creation_timestamp")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreationTimestamp => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "creation_timestamp");

    /// <summary>
    /// 
    /// 					Current status of the instance.
    /// 					This could be one of the following values: PROVISIONING, STAGING, RUNNING, STOPPING, SUSPENDING, SUSPENDED, REPAIRING, and TERMINATED.
    /// 					For more information about the status of the instance, see [Instance life cycle](https://cloud.google.com/compute/docs/instances/instance-life-cycle).
    /// </summary>
    [TerraformPropertyName("current_status")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CurrentStatus => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "current_status");

    /// <summary>
    /// Whether deletion protection is enabled on this instance.
    /// </summary>
    [TerraformPropertyName("deletion_protection")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> DeletionProtection => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "deletion_protection");

    /// <summary>
    /// A brief description of the resource.
    /// </summary>
    [TerraformPropertyName("description")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Description => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "description");

    /// <summary>
    /// Desired status of the instance. Either &amp;quot;RUNNING&amp;quot;, &amp;quot;SUSPENDED&amp;quot; or &amp;quot;TERMINATED&amp;quot;.
    /// </summary>
    [TerraformPropertyName("desired_status")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DesiredStatus => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "desired_status");

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformPropertyName("effective_labels")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> EffectiveLabels => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "effective_labels");

    /// <summary>
    /// Whether the instance has virtual displays enabled.
    /// </summary>
    [TerraformPropertyName("enable_display")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> EnableDisplay => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "enable_display");

    /// <summary>
    /// List of the type and count of accelerator cards attached to the instance.
    /// </summary>
    [TerraformPropertyName("guest_accelerator")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> GuestAccelerator => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "guest_accelerator");

    /// <summary>
    /// A custom hostname for the instance. Must be a fully qualified DNS name and RFC-1035-valid. Valid format is a series of labels 1-63 characters long matching the regular expression [a-z]([-a-z0-9]*[a-z0-9]), concatenated with periods. The entire hostname must not exceed 253 characters. Changing this forces a new resource to be created.
    /// </summary>
    [TerraformPropertyName("hostname")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Hostname => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "hostname");

    /// <summary>
    /// Encryption key used to provide data encryption on the given instance.
    /// </summary>
    [TerraformPropertyName("instance_encryption_key")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> InstanceEncryptionKey => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "instance_encryption_key");

    /// <summary>
    /// The server-assigned unique identifier of this instance.
    /// </summary>
    [TerraformPropertyName("instance_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> InstanceId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "instance_id");

    /// <summary>
    /// Action to be taken when a customer&#39;s encryption key is revoked. Supports &amp;quot;STOP&amp;quot; and &amp;quot;NONE&amp;quot;, with &amp;quot;NONE&amp;quot; being the default.
    /// </summary>
    [TerraformPropertyName("key_revocation_action_type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> KeyRevocationActionType => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "key_revocation_action_type");

    /// <summary>
    /// The unique fingerprint of the labels.
    /// </summary>
    [TerraformPropertyName("label_fingerprint")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> LabelFingerprint => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "label_fingerprint");

    /// <summary>
    /// A set of key/value label pairs assigned to the instance.
    /// 
    /// 				**Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// 				Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformPropertyName("labels")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Labels => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "labels");

    /// <summary>
    /// The machine type to create.
    /// </summary>
    [TerraformPropertyName("machine_type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> MachineType => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "machine_type");

    /// <summary>
    /// Metadata key/value pairs made available within the instance.
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
    /// Metadata startup scripts made available within the instance.
    /// </summary>
    [TerraformPropertyName("metadata_startup_script")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> MetadataStartupScript => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "metadata_startup_script");

    /// <summary>
    /// The minimum CPU platform specified for the VM instance.
    /// </summary>
    [TerraformPropertyName("min_cpu_platform")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> MinCpuPlatform => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "min_cpu_platform");

    /// <summary>
    /// The networks attached to the instance.
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
    /// Stores additional params passed with the request, but not persisted as part of resource payload.
    /// </summary>
    [TerraformPropertyName("params")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Params => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "params");

    /// <summary>
    /// Specifies the reservations that this instance can consume from.
    /// </summary>
    [TerraformPropertyName("reservation_affinity")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> ReservationAffinity => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "reservation_affinity");

    /// <summary>
    /// A list of self_links of resource policies to attach to the instance. Currently a max of 1 resource policy is supported.
    /// </summary>
    [TerraformPropertyName("resource_policies")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> ResourcePolicies => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "resource_policies");

    /// <summary>
    /// The scheduling strategy being used by the instance.
    /// </summary>
    [TerraformPropertyName("scheduling")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Scheduling => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "scheduling");

    /// <summary>
    /// The scratch disks attached to the instance.
    /// </summary>
    [TerraformPropertyName("scratch_disk")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> ScratchDisk => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "scratch_disk");

    /// <summary>
    /// The service account to attach to the instance.
    /// </summary>
    [TerraformPropertyName("service_account")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> ServiceAccount => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "service_account");

    /// <summary>
    /// The shielded vm config being used by the instance.
    /// </summary>
    [TerraformPropertyName("shielded_instance_config")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> ShieldedInstanceConfig => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "shielded_instance_config");

    /// <summary>
    /// The list of tags attached to the instance.
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
