using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_compute_instance.
/// </summary>
public class GoogleComputeInstanceDataSource : TerraformDataSource
{
    public GoogleComputeInstanceDataSource(string name) : base("google_compute_instance", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("advanced_machine_features");
        this.DeclareOutput("allow_stopping_for_update");
        this.DeclareOutput("attached_disk");
        this.DeclareOutput("boot_disk");
        this.DeclareOutput("can_ip_forward");
        this.DeclareOutput("confidential_instance_config");
        this.DeclareOutput("cpu_platform");
        this.DeclareOutput("creation_timestamp");
        this.DeclareOutput("current_status");
        this.DeclareOutput("deletion_protection");
        this.DeclareOutput("description");
        this.DeclareOutput("desired_status");
        this.DeclareOutput("effective_labels");
        this.DeclareOutput("enable_display");
        this.DeclareOutput("guest_accelerator");
        this.DeclareOutput("hostname");
        this.DeclareOutput("instance_encryption_key");
        this.DeclareOutput("instance_id");
        this.DeclareOutput("key_revocation_action_type");
        this.DeclareOutput("label_fingerprint");
        this.DeclareOutput("labels");
        this.DeclareOutput("machine_type");
        this.DeclareOutput("metadata");
        this.DeclareOutput("metadata_fingerprint");
        this.DeclareOutput("metadata_startup_script");
        this.DeclareOutput("min_cpu_platform");
        this.DeclareOutput("network_interface");
        this.DeclareOutput("network_performance_config");
        this.DeclareOutput("params");
        this.DeclareOutput("reservation_affinity");
        this.DeclareOutput("resource_policies");
        this.DeclareOutput("scheduling");
        this.DeclareOutput("scratch_disk");
        this.DeclareOutput("service_account");
        this.DeclareOutput("shielded_instance_config");
        this.DeclareOutput("tags");
        this.DeclareOutput("tags_fingerprint");
        this.DeclareOutput("terraform_labels");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name of the instance. One of name or self_link must be provided.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The ID of the project in which the resource belongs. If self_link is provided, this value is ignored. If neither self_link nor project are provided, the provider project is used.
    /// </summary>
    public string? Project
    {
        get => GetProperty<TerraformLiteralProperty<string>>("project")?.Value;
        set => this.WithProperty("project", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The URI of the created resource.
    /// </summary>
    public string? SelfLink
    {
        get => GetProperty<TerraformLiteralProperty<string>>("self_link")?.Value;
        set => this.WithProperty("self_link", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The zone of the instance. If self_link is provided, this value is ignored. If neither self_link nor zone are provided, the provider zone is used.
    /// </summary>
    public string? Zone
    {
        get => GetProperty<TerraformLiteralProperty<string>>("zone")?.Value;
        set => this.WithProperty("zone", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Controls for advanced machine-related behavior features.
    /// </summary>
    public TerraformExpression AdvancedMachineFeatures => this["advanced_machine_features"];

    /// <summary>
    /// If true, allows Terraform to stop the instance to update its properties. If you try to update a property that requires stopping the instance without setting this field, the update will fail.
    /// </summary>
    public TerraformExpression AllowStoppingForUpdate => this["allow_stopping_for_update"];

    /// <summary>
    /// List of disks attached to the instance
    /// </summary>
    public TerraformExpression AttachedDisk => this["attached_disk"];

    /// <summary>
    /// The boot disk for the instance.
    /// </summary>
    public TerraformExpression BootDisk => this["boot_disk"];

    /// <summary>
    /// Whether sending and receiving of packets with non-matching source or destination IPs is allowed.
    /// </summary>
    public TerraformExpression CanIpForward => this["can_ip_forward"];

    /// <summary>
    /// The Confidential VM config being used by the instance.  on_host_maintenance has to be set to TERMINATE or this will fail to create.
    /// </summary>
    public TerraformExpression ConfidentialInstanceConfig => this["confidential_instance_config"];

    /// <summary>
    /// The CPU platform used by this instance.
    /// </summary>
    public TerraformExpression CpuPlatform => this["cpu_platform"];

    /// <summary>
    /// Creation timestamp in RFC3339 text format.
    /// </summary>
    public TerraformExpression CreationTimestamp => this["creation_timestamp"];

    /// <summary>
    /// 
    /// 					Current status of the instance.
    /// 					This could be one of the following values: PROVISIONING, STAGING, RUNNING, STOPPING, SUSPENDING, SUSPENDED, REPAIRING, and TERMINATED.
    /// 					For more information about the status of the instance, see [Instance life cycle](https://cloud.google.com/compute/docs/instances/instance-life-cycle).
    /// </summary>
    public TerraformExpression CurrentStatus => this["current_status"];

    /// <summary>
    /// Whether deletion protection is enabled on this instance.
    /// </summary>
    public TerraformExpression DeletionProtection => this["deletion_protection"];

    /// <summary>
    /// A brief description of the resource.
    /// </summary>
    public TerraformExpression Description => this["description"];

    /// <summary>
    /// Desired status of the instance. Either &amp;quot;RUNNING&amp;quot;, &amp;quot;SUSPENDED&amp;quot; or &amp;quot;TERMINATED&amp;quot;.
    /// </summary>
    public TerraformExpression DesiredStatus => this["desired_status"];

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveLabels => this["effective_labels"];

    /// <summary>
    /// Whether the instance has virtual displays enabled.
    /// </summary>
    public TerraformExpression EnableDisplay => this["enable_display"];

    /// <summary>
    /// List of the type and count of accelerator cards attached to the instance.
    /// </summary>
    public TerraformExpression GuestAccelerator => this["guest_accelerator"];

    /// <summary>
    /// A custom hostname for the instance. Must be a fully qualified DNS name and RFC-1035-valid. Valid format is a series of labels 1-63 characters long matching the regular expression [a-z]([-a-z0-9]*[a-z0-9]), concatenated with periods. The entire hostname must not exceed 253 characters. Changing this forces a new resource to be created.
    /// </summary>
    public TerraformExpression Hostname => this["hostname"];

    /// <summary>
    /// Encryption key used to provide data encryption on the given instance.
    /// </summary>
    public TerraformExpression InstanceEncryptionKey => this["instance_encryption_key"];

    /// <summary>
    /// The server-assigned unique identifier of this instance.
    /// </summary>
    public TerraformExpression InstanceId => this["instance_id"];

    /// <summary>
    /// Action to be taken when a customer&#39;s encryption key is revoked. Supports &amp;quot;STOP&amp;quot; and &amp;quot;NONE&amp;quot;, with &amp;quot;NONE&amp;quot; being the default.
    /// </summary>
    public TerraformExpression KeyRevocationActionType => this["key_revocation_action_type"];

    /// <summary>
    /// The unique fingerprint of the labels.
    /// </summary>
    public TerraformExpression LabelFingerprint => this["label_fingerprint"];

    /// <summary>
    /// A set of key/value label pairs assigned to the instance.
    /// 
    /// 				**Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// 				Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public TerraformExpression Labels => this["labels"];

    /// <summary>
    /// The machine type to create.
    /// </summary>
    public TerraformExpression MachineType => this["machine_type"];

    /// <summary>
    /// Metadata key/value pairs made available within the instance.
    /// </summary>
    public TerraformExpression Metadata => this["metadata"];

    /// <summary>
    /// The unique fingerprint of the metadata.
    /// </summary>
    public TerraformExpression MetadataFingerprint => this["metadata_fingerprint"];

    /// <summary>
    /// Metadata startup scripts made available within the instance.
    /// </summary>
    public TerraformExpression MetadataStartupScript => this["metadata_startup_script"];

    /// <summary>
    /// The minimum CPU platform specified for the VM instance.
    /// </summary>
    public TerraformExpression MinCpuPlatform => this["min_cpu_platform"];

    /// <summary>
    /// The networks attached to the instance.
    /// </summary>
    public TerraformExpression NetworkInterface => this["network_interface"];

    /// <summary>
    /// Configures network performance settings for the instance. If not specified, the instance will be created with its default network performance configuration.
    /// </summary>
    public TerraformExpression NetworkPerformanceConfig => this["network_performance_config"];

    /// <summary>
    /// Stores additional params passed with the request, but not persisted as part of resource payload.
    /// </summary>
    public TerraformExpression Params => this["params"];

    /// <summary>
    /// Specifies the reservations that this instance can consume from.
    /// </summary>
    public TerraformExpression ReservationAffinity => this["reservation_affinity"];

    /// <summary>
    /// A list of self_links of resource policies to attach to the instance. Currently a max of 1 resource policy is supported.
    /// </summary>
    public TerraformExpression ResourcePolicies => this["resource_policies"];

    /// <summary>
    /// The scheduling strategy being used by the instance.
    /// </summary>
    public TerraformExpression Scheduling => this["scheduling"];

    /// <summary>
    /// The scratch disks attached to the instance.
    /// </summary>
    public TerraformExpression ScratchDisk => this["scratch_disk"];

    /// <summary>
    /// The service account to attach to the instance.
    /// </summary>
    public TerraformExpression ServiceAccount => this["service_account"];

    /// <summary>
    /// The shielded vm config being used by the instance.
    /// </summary>
    public TerraformExpression ShieldedInstanceConfig => this["shielded_instance_config"];

    /// <summary>
    /// The list of tags attached to the instance.
    /// </summary>
    public TerraformExpression Tags => this["tags"];

    /// <summary>
    /// The unique fingerprint of the tags.
    /// </summary>
    public TerraformExpression TagsFingerprint => this["tags_fingerprint"];

    /// <summary>
    /// The combination of labels configured directly on the resource and default labels configured on the provider.
    /// </summary>
    public TerraformExpression TerraformLabels => this["terraform_labels"];

}
