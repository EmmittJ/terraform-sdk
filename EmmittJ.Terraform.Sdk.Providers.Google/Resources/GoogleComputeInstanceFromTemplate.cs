using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_compute_instance_from_template resource.
/// </summary>
public class GoogleComputeInstanceFromTemplate : TerraformResource
{
    public GoogleComputeInstanceFromTemplate(string name) : base("google_compute_instance_from_template", name)
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
    public bool? AllowStoppingForUpdate
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("allow_stopping_for_update")?.Value;
        set => this.WithProperty("allow_stopping_for_update", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// Whether sending and receiving of packets with non-matching source or destination IPs is allowed.
    /// </summary>
    public bool? CanIpForward
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("can_ip_forward")?.Value;
        set => this.WithProperty("can_ip_forward", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// Whether deletion protection is enabled on this instance.
    /// </summary>
    public bool? DeletionProtection
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("deletion_protection")?.Value;
        set => this.WithProperty("deletion_protection", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// A brief description of the resource.
    /// </summary>
    public string? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description")?.Value;
        set => this.WithProperty("description", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Desired status of the instance. Either &amp;quot;RUNNING&amp;quot;, &amp;quot;SUSPENDED&amp;quot; or &amp;quot;TERMINATED&amp;quot;.
    /// </summary>
    public string? DesiredStatus
    {
        get => GetProperty<TerraformLiteralProperty<string>>("desired_status")?.Value;
        set => this.WithProperty("desired_status", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Whether the instance has virtual displays enabled.
    /// </summary>
    public bool? EnableDisplay
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enable_display")?.Value;
        set => this.WithProperty("enable_display", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// A custom hostname for the instance. Must be a fully qualified DNS name and RFC-1035-valid. Valid format is a series of labels 1-63 characters long matching the regular expression [a-z]([-a-z0-9]*[a-z0-9]), concatenated with periods. The entire hostname must not exceed 253 characters. Changing this forces a new resource to be created.
    /// </summary>
    public string? Hostname
    {
        get => GetProperty<TerraformLiteralProperty<string>>("hostname")?.Value;
        set => this.WithProperty("hostname", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// Action to be taken when a customer&#39;s encryption key is revoked. Supports &amp;quot;STOP&amp;quot; and &amp;quot;NONE&amp;quot;, with &amp;quot;NONE&amp;quot; being the default.
    /// </summary>
    public string? KeyRevocationActionType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("key_revocation_action_type")?.Value;
        set => this.WithProperty("key_revocation_action_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// A set of key/value label pairs assigned to the instance.
    /// 
    /// 				**Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// 				Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public Dictionary<string, string>? Labels
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("labels")?.Value;
        set => this.WithProperty("labels", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The machine type to create.
    /// </summary>
    public string? MachineType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("machine_type")?.Value;
        set => this.WithProperty("machine_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Metadata key/value pairs made available within the instance.
    /// </summary>
    public Dictionary<string, string>? Metadata
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("metadata")?.Value;
        set => this.WithProperty("metadata", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// Metadata startup scripts made available within the instance.
    /// </summary>
    public string? MetadataStartupScript
    {
        get => GetProperty<TerraformLiteralProperty<string>>("metadata_startup_script")?.Value;
        set => this.WithProperty("metadata_startup_script", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The minimum CPU platform specified for the VM instance.
    /// </summary>
    public string? MinCpuPlatform
    {
        get => GetProperty<TerraformLiteralProperty<string>>("min_cpu_platform")?.Value;
        set => this.WithProperty("min_cpu_platform", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// A list of self_links of resource policies to attach to the instance. Currently a max of 1 resource policy is supported.
    /// </summary>
    public List<string>? ResourcePolicies
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("resource_policies")?.Value;
        set => this.WithProperty("resource_policies", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    /// <summary>
    /// Name or self link of an instance template to create the instance based on.
    /// </summary>
    public string? SourceInstanceTemplate
    {
        get => GetProperty<TerraformLiteralProperty<string>>("source_instance_template")?.Value;
        set => this.WithProperty("source_instance_template", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The list of tags attached to the instance.
    /// </summary>
    public HashSet<string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
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
