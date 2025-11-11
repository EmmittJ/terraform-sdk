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
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The name of the instance. One of name or self_link must be provided.
    /// </summary>
    [TerraformPropertyName("name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Name { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs. If self_link is provided, this value is ignored. If neither self_link nor project are provided, the provider project is used.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Project { get; set; }

    /// <summary>
    /// The URI of the created resource.
    /// </summary>
    [TerraformPropertyName("self_link")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? SelfLink { get; set; }

    /// <summary>
    /// The zone of the instance. If self_link is provided, this value is ignored. If neither self_link nor zone are provided, the provider zone is used.
    /// </summary>
    [TerraformPropertyName("zone")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Zone { get; set; }

    /// <summary>
    /// Controls for advanced machine-related behavior features.
    /// </summary>
    [TerraformPropertyName("advanced_machine_features")]
    // Output-only attribute - read-only reference
    public TerraformList<object> AdvancedMachineFeatures => new TerraformReference(this, "advanced_machine_features");

    /// <summary>
    /// If true, allows Terraform to stop the instance to update its properties. If you try to update a property that requires stopping the instance without setting this field, the update will fail.
    /// </summary>
    [TerraformPropertyName("allow_stopping_for_update")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> AllowStoppingForUpdate => new TerraformReference(this, "allow_stopping_for_update");

    /// <summary>
    /// List of disks attached to the instance
    /// </summary>
    [TerraformPropertyName("attached_disk")]
    // Output-only attribute - read-only reference
    public TerraformList<object> AttachedDisk => new TerraformReference(this, "attached_disk");

    /// <summary>
    /// The boot disk for the instance.
    /// </summary>
    [TerraformPropertyName("boot_disk")]
    // Output-only attribute - read-only reference
    public TerraformList<object> BootDisk => new TerraformReference(this, "boot_disk");

    /// <summary>
    /// Whether sending and receiving of packets with non-matching source or destination IPs is allowed.
    /// </summary>
    [TerraformPropertyName("can_ip_forward")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> CanIpForward => new TerraformReference(this, "can_ip_forward");

    /// <summary>
    /// The Confidential VM config being used by the instance.  on_host_maintenance has to be set to TERMINATE or this will fail to create.
    /// </summary>
    [TerraformPropertyName("confidential_instance_config")]
    // Output-only attribute - read-only reference
    public TerraformList<object> ConfidentialInstanceConfig => new TerraformReference(this, "confidential_instance_config");

    /// <summary>
    /// The CPU platform used by this instance.
    /// </summary>
    [TerraformPropertyName("cpu_platform")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CpuPlatform => new TerraformReference(this, "cpu_platform");

    /// <summary>
    /// Creation timestamp in RFC3339 text format.
    /// </summary>
    [TerraformPropertyName("creation_timestamp")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CreationTimestamp => new TerraformReference(this, "creation_timestamp");

    /// <summary>
    /// 
    /// 					Current status of the instance.
    /// 					This could be one of the following values: PROVISIONING, STAGING, RUNNING, STOPPING, SUSPENDING, SUSPENDED, REPAIRING, and TERMINATED.
    /// 					For more information about the status of the instance, see [Instance life cycle](https://cloud.google.com/compute/docs/instances/instance-life-cycle).
    /// </summary>
    [TerraformPropertyName("current_status")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CurrentStatus => new TerraformReference(this, "current_status");

    /// <summary>
    /// Whether deletion protection is enabled on this instance.
    /// </summary>
    [TerraformPropertyName("deletion_protection")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> DeletionProtection => new TerraformReference(this, "deletion_protection");

    /// <summary>
    /// A brief description of the resource.
    /// </summary>
    [TerraformPropertyName("description")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Description => new TerraformReference(this, "description");

    /// <summary>
    /// Desired status of the instance. Either &amp;quot;RUNNING&amp;quot;, &amp;quot;SUSPENDED&amp;quot; or &amp;quot;TERMINATED&amp;quot;.
    /// </summary>
    [TerraformPropertyName("desired_status")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DesiredStatus => new TerraformReference(this, "desired_status");

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformPropertyName("effective_labels")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> EffectiveLabels => new TerraformReference(this, "effective_labels");

    /// <summary>
    /// Whether the instance has virtual displays enabled.
    /// </summary>
    [TerraformPropertyName("enable_display")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> EnableDisplay => new TerraformReference(this, "enable_display");

    /// <summary>
    /// List of the type and count of accelerator cards attached to the instance.
    /// </summary>
    [TerraformPropertyName("guest_accelerator")]
    // Output-only attribute - read-only reference
    public TerraformList<object> GuestAccelerator => new TerraformReference(this, "guest_accelerator");

    /// <summary>
    /// A custom hostname for the instance. Must be a fully qualified DNS name and RFC-1035-valid. Valid format is a series of labels 1-63 characters long matching the regular expression [a-z]([-a-z0-9]*[a-z0-9]), concatenated with periods. The entire hostname must not exceed 253 characters. Changing this forces a new resource to be created.
    /// </summary>
    [TerraformPropertyName("hostname")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Hostname => new TerraformReference(this, "hostname");

    /// <summary>
    /// Encryption key used to provide data encryption on the given instance.
    /// </summary>
    [TerraformPropertyName("instance_encryption_key")]
    // Output-only attribute - read-only reference
    public TerraformList<object> InstanceEncryptionKey => new TerraformReference(this, "instance_encryption_key");

    /// <summary>
    /// The server-assigned unique identifier of this instance.
    /// </summary>
    [TerraformPropertyName("instance_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> InstanceId => new TerraformReference(this, "instance_id");

    /// <summary>
    /// Action to be taken when a customer&#39;s encryption key is revoked. Supports &amp;quot;STOP&amp;quot; and &amp;quot;NONE&amp;quot;, with &amp;quot;NONE&amp;quot; being the default.
    /// </summary>
    [TerraformPropertyName("key_revocation_action_type")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> KeyRevocationActionType => new TerraformReference(this, "key_revocation_action_type");

    /// <summary>
    /// The unique fingerprint of the labels.
    /// </summary>
    [TerraformPropertyName("label_fingerprint")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> LabelFingerprint => new TerraformReference(this, "label_fingerprint");

    /// <summary>
    /// A set of key/value label pairs assigned to the instance.
    /// 
    /// 				**Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// 				Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformPropertyName("labels")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> Labels => new TerraformReference(this, "labels");

    /// <summary>
    /// The machine type to create.
    /// </summary>
    [TerraformPropertyName("machine_type")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> MachineType => new TerraformReference(this, "machine_type");

    /// <summary>
    /// Metadata key/value pairs made available within the instance.
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
    /// Metadata startup scripts made available within the instance.
    /// </summary>
    [TerraformPropertyName("metadata_startup_script")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> MetadataStartupScript => new TerraformReference(this, "metadata_startup_script");

    /// <summary>
    /// The minimum CPU platform specified for the VM instance.
    /// </summary>
    [TerraformPropertyName("min_cpu_platform")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> MinCpuPlatform => new TerraformReference(this, "min_cpu_platform");

    /// <summary>
    /// The networks attached to the instance.
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
    /// Stores additional params passed with the request, but not persisted as part of resource payload.
    /// </summary>
    [TerraformPropertyName("params")]
    // Output-only attribute - read-only reference
    public TerraformList<object> Params => new TerraformReference(this, "params");

    /// <summary>
    /// Specifies the reservations that this instance can consume from.
    /// </summary>
    [TerraformPropertyName("reservation_affinity")]
    // Output-only attribute - read-only reference
    public TerraformList<object> ReservationAffinity => new TerraformReference(this, "reservation_affinity");

    /// <summary>
    /// A list of self_links of resource policies to attach to the instance. Currently a max of 1 resource policy is supported.
    /// </summary>
    [TerraformPropertyName("resource_policies")]
    // Output-only attribute - read-only reference
    public TerraformList<string> ResourcePolicies => new TerraformReference(this, "resource_policies");

    /// <summary>
    /// The scheduling strategy being used by the instance.
    /// </summary>
    [TerraformPropertyName("scheduling")]
    // Output-only attribute - read-only reference
    public TerraformList<object> Scheduling => new TerraformReference(this, "scheduling");

    /// <summary>
    /// The scratch disks attached to the instance.
    /// </summary>
    [TerraformPropertyName("scratch_disk")]
    // Output-only attribute - read-only reference
    public TerraformList<object> ScratchDisk => new TerraformReference(this, "scratch_disk");

    /// <summary>
    /// The service account to attach to the instance.
    /// </summary>
    [TerraformPropertyName("service_account")]
    // Output-only attribute - read-only reference
    public TerraformList<object> ServiceAccount => new TerraformReference(this, "service_account");

    /// <summary>
    /// The shielded vm config being used by the instance.
    /// </summary>
    [TerraformPropertyName("shielded_instance_config")]
    // Output-only attribute - read-only reference
    public TerraformList<object> ShieldedInstanceConfig => new TerraformReference(this, "shielded_instance_config");

    /// <summary>
    /// The list of tags attached to the instance.
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
