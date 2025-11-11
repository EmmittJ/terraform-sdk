using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_compute_instance.
/// </summary>
public partial class GoogleComputeInstanceDataSource : TerraformDataSource
{
    public GoogleComputeInstanceDataSource(string name) : base("google_compute_instance", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name of the instance. One of name or self_link must be provided.
    /// </summary>
    [TerraformProperty("name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Name { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs. If self_link is provided, this value is ignored. If neither self_link nor project are provided, the provider project is used.
    /// </summary>
    [TerraformProperty("project")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Project { get; set; }

    /// <summary>
    /// The URI of the created resource.
    /// </summary>
    [TerraformProperty("self_link")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SelfLink { get; set; }

    /// <summary>
    /// The zone of the instance. If self_link is provided, this value is ignored. If neither self_link nor zone are provided, the provider zone is used.
    /// </summary>
    [TerraformProperty("zone")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Zone { get; set; }

    /// <summary>
    /// Controls for advanced machine-related behavior features.
    /// </summary>
    [TerraformProperty("advanced_machine_features")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> AdvancedMachineFeatures { get; }

    /// <summary>
    /// If true, allows Terraform to stop the instance to update its properties. If you try to update a property that requires stopping the instance without setting this field, the update will fail.
    /// </summary>
    [TerraformProperty("allow_stopping_for_update")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> AllowStoppingForUpdate { get; }

    /// <summary>
    /// List of disks attached to the instance
    /// </summary>
    [TerraformProperty("attached_disk")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> AttachedDisk { get; }

    /// <summary>
    /// The boot disk for the instance.
    /// </summary>
    [TerraformProperty("boot_disk")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> BootDisk { get; }

    /// <summary>
    /// Whether sending and receiving of packets with non-matching source or destination IPs is allowed.
    /// </summary>
    [TerraformProperty("can_ip_forward")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> CanIpForward { get; }

    /// <summary>
    /// The Confidential VM config being used by the instance.  on_host_maintenance has to be set to TERMINATE or this will fail to create.
    /// </summary>
    [TerraformProperty("confidential_instance_config")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> ConfidentialInstanceConfig { get; }

    /// <summary>
    /// The CPU platform used by this instance.
    /// </summary>
    [TerraformProperty("cpu_platform")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CpuPlatform { get; }

    /// <summary>
    /// Creation timestamp in RFC3339 text format.
    /// </summary>
    [TerraformProperty("creation_timestamp")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CreationTimestamp { get; }

    /// <summary>
    /// 
    /// 					Current status of the instance.
    /// 					This could be one of the following values: PROVISIONING, STAGING, RUNNING, STOPPING, SUSPENDING, SUSPENDED, REPAIRING, and TERMINATED.
    /// 					For more information about the status of the instance, see [Instance life cycle](https://cloud.google.com/compute/docs/instances/instance-life-cycle).
    /// </summary>
    [TerraformProperty("current_status")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CurrentStatus { get; }

    /// <summary>
    /// Whether deletion protection is enabled on this instance.
    /// </summary>
    [TerraformProperty("deletion_protection")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> DeletionProtection { get; }

    /// <summary>
    /// A brief description of the resource.
    /// </summary>
    [TerraformProperty("description")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Description { get; }

    /// <summary>
    /// Desired status of the instance. Either &amp;quot;RUNNING&amp;quot;, &amp;quot;SUSPENDED&amp;quot; or &amp;quot;TERMINATED&amp;quot;.
    /// </summary>
    [TerraformProperty("desired_status")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DesiredStatus { get; }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformProperty("effective_labels")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> EffectiveLabels { get; }

    /// <summary>
    /// Whether the instance has virtual displays enabled.
    /// </summary>
    [TerraformProperty("enable_display")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> EnableDisplay { get; }

    /// <summary>
    /// List of the type and count of accelerator cards attached to the instance.
    /// </summary>
    [TerraformProperty("guest_accelerator")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> GuestAccelerator { get; }

    /// <summary>
    /// A custom hostname for the instance. Must be a fully qualified DNS name and RFC-1035-valid. Valid format is a series of labels 1-63 characters long matching the regular expression [a-z]([-a-z0-9]*[a-z0-9]), concatenated with periods. The entire hostname must not exceed 253 characters. Changing this forces a new resource to be created.
    /// </summary>
    [TerraformProperty("hostname")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Hostname { get; }

    /// <summary>
    /// Encryption key used to provide data encryption on the given instance.
    /// </summary>
    [TerraformProperty("instance_encryption_key")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> InstanceEncryptionKey { get; }

    /// <summary>
    /// The server-assigned unique identifier of this instance.
    /// </summary>
    [TerraformProperty("instance_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> InstanceId { get; }

    /// <summary>
    /// Action to be taken when a customer&#39;s encryption key is revoked. Supports &amp;quot;STOP&amp;quot; and &amp;quot;NONE&amp;quot;, with &amp;quot;NONE&amp;quot; being the default.
    /// </summary>
    [TerraformProperty("key_revocation_action_type")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> KeyRevocationActionType { get; }

    /// <summary>
    /// The unique fingerprint of the labels.
    /// </summary>
    [TerraformProperty("label_fingerprint")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> LabelFingerprint { get; }

    /// <summary>
    /// A set of key/value label pairs assigned to the instance.
    /// 
    /// 				**Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// 				Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformProperty("labels")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> Labels { get; }

    /// <summary>
    /// The machine type to create.
    /// </summary>
    [TerraformProperty("machine_type")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> MachineType { get; }

    /// <summary>
    /// Metadata key/value pairs made available within the instance.
    /// </summary>
    [TerraformProperty("metadata")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> Metadata { get; }

    /// <summary>
    /// The unique fingerprint of the metadata.
    /// </summary>
    [TerraformProperty("metadata_fingerprint")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> MetadataFingerprint { get; }

    /// <summary>
    /// Metadata startup scripts made available within the instance.
    /// </summary>
    [TerraformProperty("metadata_startup_script")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> MetadataStartupScript { get; }

    /// <summary>
    /// The minimum CPU platform specified for the VM instance.
    /// </summary>
    [TerraformProperty("min_cpu_platform")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> MinCpuPlatform { get; }

    /// <summary>
    /// The networks attached to the instance.
    /// </summary>
    [TerraformProperty("network_interface")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> NetworkInterface { get; }

    /// <summary>
    /// Configures network performance settings for the instance. If not specified, the instance will be created with its default network performance configuration.
    /// </summary>
    [TerraformProperty("network_performance_config")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> NetworkPerformanceConfig { get; }

    /// <summary>
    /// Stores additional params passed with the request, but not persisted as part of resource payload.
    /// </summary>
    [TerraformProperty("params")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> Params { get; }

    /// <summary>
    /// Specifies the reservations that this instance can consume from.
    /// </summary>
    [TerraformProperty("reservation_affinity")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> ReservationAffinity { get; }

    /// <summary>
    /// A list of self_links of resource policies to attach to the instance. Currently a max of 1 resource policy is supported.
    /// </summary>
    [TerraformProperty("resource_policies")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<string> ResourcePolicies { get; }

    /// <summary>
    /// The scheduling strategy being used by the instance.
    /// </summary>
    [TerraformProperty("scheduling")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> Scheduling { get; }

    /// <summary>
    /// The scratch disks attached to the instance.
    /// </summary>
    [TerraformProperty("scratch_disk")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> ScratchDisk { get; }

    /// <summary>
    /// The service account to attach to the instance.
    /// </summary>
    [TerraformProperty("service_account")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> ServiceAccount { get; }

    /// <summary>
    /// The shielded vm config being used by the instance.
    /// </summary>
    [TerraformProperty("shielded_instance_config")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> ShieldedInstanceConfig { get; }

    /// <summary>
    /// The list of tags attached to the instance.
    /// </summary>
    [TerraformProperty("tags")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformSet<string> Tags { get; }

    /// <summary>
    /// The unique fingerprint of the tags.
    /// </summary>
    [TerraformProperty("tags_fingerprint")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> TagsFingerprint { get; }

    /// <summary>
    /// The combination of labels configured directly on the resource and default labels configured on the provider.
    /// </summary>
    [TerraformProperty("terraform_labels")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> TerraformLabels { get; }

}
