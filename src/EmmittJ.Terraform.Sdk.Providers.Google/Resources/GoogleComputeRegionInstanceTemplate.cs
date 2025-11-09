using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_compute_region_instance_template resource.
/// </summary>
public class GoogleComputeRegionInstanceTemplate : TerraformResource
{
    public GoogleComputeRegionInstanceTemplate(string name) : base("google_compute_region_instance_template", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("creation_timestamp");
        this.DeclareOutput("effective_labels");
        this.DeclareOutput("metadata_fingerprint");
        this.DeclareOutput("numeric_id");
        this.DeclareOutput("self_link");
        this.DeclareOutput("tags_fingerprint");
        this.DeclareOutput("terraform_labels");
    }

    /// <summary>
    /// Whether to allow sending and receiving of packets with non-matching source or destination IPs. This defaults to false.
    /// </summary>
    public TerraformProperty<bool>? CanIpForward
    {
        get => GetProperty<TerraformProperty<bool>>("can_ip_forward");
        set => this.WithProperty("can_ip_forward", value);
    }

    /// <summary>
    /// A brief description of this resource.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
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
    /// A description of the instance.
    /// </summary>
    public TerraformProperty<string>? InstanceDescription
    {
        get => GetProperty<TerraformProperty<string>>("instance_description");
        set => this.WithProperty("instance_description", value);
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
    /// A set of key/value label pairs to assign to instances created from this template,
    /// 
    /// 				**Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// 				Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public TerraformMapProperty<string>? Labels
    {
        get => GetProperty<TerraformMapProperty<string>>("labels");
        set => this.WithProperty("labels", value);
    }

    /// <summary>
    /// The machine type to create. To create a machine with a custom type (such as extended memory), format the value like custom-VCPUS-MEM_IN_MB like custom-6-20480 for 6 vCPU and 20GB of RAM.
    /// </summary>
    public TerraformProperty<string>? MachineType
    {
        get => GetProperty<TerraformProperty<string>>("machine_type");
        set => this.WithProperty("machine_type", value);
    }

    /// <summary>
    /// Metadata key/value pairs to make available from within instances created from this template.
    /// </summary>
    public TerraformMapProperty<string>? Metadata
    {
        get => GetProperty<TerraformMapProperty<string>>("metadata");
        set => this.WithProperty("metadata", value);
    }

    /// <summary>
    /// An alternative to using the startup-script metadata key, mostly to match the compute_instance resource. This replaces the startup-script metadata key on the created instance and thus the two mechanisms are not allowed to be used simultaneously.
    /// </summary>
    public TerraformProperty<string>? MetadataStartupScript
    {
        get => GetProperty<TerraformProperty<string>>("metadata_startup_script");
        set => this.WithProperty("metadata_startup_script", value);
    }

    /// <summary>
    /// Specifies a minimum CPU platform. Applicable values are the friendly names of CPU platforms, such as Intel Haswell or Intel Skylake.
    /// </summary>
    public TerraformProperty<string>? MinCpuPlatform
    {
        get => GetProperty<TerraformProperty<string>>("min_cpu_platform");
        set => this.WithProperty("min_cpu_platform", value);
    }

    /// <summary>
    /// The name of the instance template. If you leave this blank, Terraform will auto-generate a unique name.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// Creates a unique name beginning with the specified prefix. Conflicts with name.
    /// </summary>
    public TerraformProperty<string>? NamePrefix
    {
        get => GetProperty<TerraformProperty<string>>("name_prefix");
        set => this.WithProperty("name_prefix", value);
    }

    /// <summary>
    /// The ID of the project in which the resource belongs. If it is not provided, the provider project is used.
    /// </summary>
    public TerraformProperty<string>? Project
    {
        get => GetProperty<TerraformProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// The region in which the instance template is located. If it is not provided, the provider region is used.
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// A map of resource manager tags.
    /// 				Resource manager tag keys and values have the same definition as resource manager tags. Keys must be in the format tagKeys/{tag_key_id}, and values are in the format tagValues/456. The field is ignored (both PUT &amp;amp; PATCH) when empty.
    /// </summary>
    public TerraformMapProperty<string>? ResourceManagerTags
    {
        get => GetProperty<TerraformMapProperty<string>>("resource_manager_tags");
        set => this.WithProperty("resource_manager_tags", value);
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
    /// Tags to attach to the instance.
    /// </summary>
    public TerraformProperty<HashSet<string>>? Tags
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The time at which the instance was created in RFC 3339 format.
    /// </summary>
    public TerraformExpression CreationTimestamp => this["creation_timestamp"];

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveLabels => this["effective_labels"];

    /// <summary>
    /// The unique fingerprint of the metadata.
    /// </summary>
    public TerraformExpression MetadataFingerprint => this["metadata_fingerprint"];

    /// <summary>
    /// The ID of the template in numeric format.
    /// </summary>
    public TerraformExpression NumericId => this["numeric_id"];

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
