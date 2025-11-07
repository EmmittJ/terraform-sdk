using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_compute_instance resource.
/// </summary>
public class GoogleComputeInstance : TerraformResource
{
    public GoogleComputeInstance(string name) : base("google_compute_instance", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("cpu_platform");
        this.DeclareOutput("creation_timestamp");
        this.DeclareOutput("current_status");
        this.DeclareOutput("effective_labels");
        this.DeclareOutput("instance_id");
        this.DeclareOutput("label_fingerprint");
        this.DeclareOutput("metadata_fingerprint");
        this.DeclareOutput("self_link");
        this.DeclareOutput("tags_fingerprint");
        this.DeclareOutput("terraform_labels");
    }

    /// <summary>
    /// If true, allows Terraform to stop the instance to update its properties. If you try to update a property that requires stopping the instance without setting this field, the update will fail.
    /// </summary>
    public TerraformProperty<bool>? AllowStoppingForUpdate
    {
        get => GetProperty<TerraformProperty<bool>>("allow_stopping_for_update");
        set => this.WithProperty("allow_stopping_for_update", value);
    }

    /// <summary>
    /// Whether sending and receiving of packets with non-matching source or destination IPs is allowed.
    /// </summary>
    public TerraformProperty<bool>? CanIpForward
    {
        get => GetProperty<TerraformProperty<bool>>("can_ip_forward");
        set => this.WithProperty("can_ip_forward", value);
    }

    /// <summary>
    /// Whether deletion protection is enabled on this instance.
    /// </summary>
    public TerraformProperty<bool>? DeletionProtection
    {
        get => GetProperty<TerraformProperty<bool>>("deletion_protection");
        set => this.WithProperty("deletion_protection", value);
    }

    /// <summary>
    /// A brief description of the resource.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// Desired status of the instance. Either &amp;quot;RUNNING&amp;quot;, &amp;quot;SUSPENDED&amp;quot; or &amp;quot;TERMINATED&amp;quot;.
    /// </summary>
    public TerraformProperty<string>? DesiredStatus
    {
        get => GetProperty<TerraformProperty<string>>("desired_status");
        set => this.WithProperty("desired_status", value);
    }

    /// <summary>
    /// Whether the instance has virtual displays enabled.
    /// </summary>
    public TerraformProperty<bool>? EnableDisplay
    {
        get => GetProperty<TerraformProperty<bool>>("enable_display");
        set => this.WithProperty("enable_display", value);
    }

    /// <summary>
    /// A custom hostname for the instance. Must be a fully qualified DNS name and RFC-1035-valid. Valid format is a series of labels 1-63 characters long matching the regular expression [a-z]([-a-z0-9]*[a-z0-9]), concatenated with periods. The entire hostname must not exceed 253 characters. Changing this forces a new resource to be created.
    /// </summary>
    public TerraformProperty<string>? Hostname
    {
        get => GetProperty<TerraformProperty<string>>("hostname");
        set => this.WithProperty("hostname", value);
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
    /// Action to be taken when a customer&#39;s encryption key is revoked. Supports &amp;quot;STOP&amp;quot; and &amp;quot;NONE&amp;quot;, with &amp;quot;NONE&amp;quot; being the default.
    /// </summary>
    public TerraformProperty<string>? KeyRevocationActionType
    {
        get => GetProperty<TerraformProperty<string>>("key_revocation_action_type");
        set => this.WithProperty("key_revocation_action_type", value);
    }

    /// <summary>
    /// A set of key/value label pairs assigned to the instance.
    /// 
    /// 				**Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// 				Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public TerraformProperty<Dictionary<string, string>>? Labels
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("labels");
        set => this.WithProperty("labels", value);
    }

    /// <summary>
    /// The machine type to create.
    /// </summary>
    public TerraformProperty<string>? MachineType
    {
        get => GetProperty<TerraformProperty<string>>("machine_type");
        set => this.WithProperty("machine_type", value);
    }

    /// <summary>
    /// Metadata key/value pairs made available within the instance.
    /// </summary>
    public TerraformProperty<Dictionary<string, string>>? Metadata
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("metadata");
        set => this.WithProperty("metadata", value);
    }

    /// <summary>
    /// Metadata startup scripts made available within the instance.
    /// </summary>
    public TerraformProperty<string>? MetadataStartupScript
    {
        get => GetProperty<TerraformProperty<string>>("metadata_startup_script");
        set => this.WithProperty("metadata_startup_script", value);
    }

    /// <summary>
    /// The minimum CPU platform specified for the VM instance.
    /// </summary>
    public TerraformProperty<string>? MinCpuPlatform
    {
        get => GetProperty<TerraformProperty<string>>("min_cpu_platform");
        set => this.WithProperty("min_cpu_platform", value);
    }

    /// <summary>
    /// The name of the instance. One of name or self_link must be provided.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The ID of the project in which the resource belongs. If self_link is provided, this value is ignored. If neither self_link nor project are provided, the provider project is used.
    /// </summary>
    public TerraformProperty<string>? Project
    {
        get => GetProperty<TerraformProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// A list of self_links of resource policies to attach to the instance. Currently a max of 1 resource policy is supported.
    /// </summary>
    public TerraformProperty<List<string>>? ResourcePolicies
    {
        get => GetProperty<TerraformProperty<List<string>>>("resource_policies");
        set => this.WithProperty("resource_policies", value);
    }

    /// <summary>
    /// The list of tags attached to the instance.
    /// </summary>
    public TerraformProperty<HashSet<string>>? Tags
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The zone of the instance. If self_link is provided, this value is ignored. If neither self_link nor zone are provided, the provider zone is used.
    /// </summary>
    public TerraformProperty<string>? Zone
    {
        get => GetProperty<TerraformProperty<string>>("zone");
        set => this.WithProperty("zone", value);
    }

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
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveLabels => this["effective_labels"];

    /// <summary>
    /// The server-assigned unique identifier of this instance.
    /// </summary>
    public TerraformExpression InstanceId => this["instance_id"];

    /// <summary>
    /// The unique fingerprint of the labels.
    /// </summary>
    public TerraformExpression LabelFingerprint => this["label_fingerprint"];

    /// <summary>
    /// The unique fingerprint of the metadata.
    /// </summary>
    public TerraformExpression MetadataFingerprint => this["metadata_fingerprint"];

    /// <summary>
    /// The URI of the created resource.
    /// </summary>
    public TerraformExpression SelfLink => this["self_link"];

    /// <summary>
    /// The unique fingerprint of the tags.
    /// </summary>
    public TerraformExpression TagsFingerprint => this["tags_fingerprint"];

    /// <summary>
    /// The combination of labels configured directly on the resource and default labels configured on the provider.
    /// </summary>
    public TerraformExpression TerraformLabels => this["terraform_labels"];

}
