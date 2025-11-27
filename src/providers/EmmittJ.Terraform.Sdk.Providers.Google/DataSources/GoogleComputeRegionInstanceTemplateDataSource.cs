using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Represents a google_compute_region_instance_template Terraform data source.
/// Retrieves information about a google_compute_region_instance_template.
/// </summary>
public partial class GoogleComputeRegionInstanceTemplateDataSource(string name) : TerraformDataSource("google_compute_region_instance_template", name)
{
    /// <summary>
    /// The filter attribute.
    /// </summary>
    public TerraformValue<string>? Filter
    {
        get => new TerraformReference<string>(this, "filter");
        set => SetArgument("filter", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The most_recent attribute.
    /// </summary>
    public TerraformValue<bool>? MostRecent
    {
        get => new TerraformReference<bool>(this, "most_recent");
        set => SetArgument("most_recent", value);
    }

    /// <summary>
    /// The name of the instance template. If you leave this blank, Terraform will auto-generate a unique name.
    /// </summary>
    public TerraformValue<string>? Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The ID of the project in which the resource belongs. If it is not provided, the provider project is used.
    /// </summary>
    public TerraformValue<string>? Project
    {
        get => new TerraformReference<string>(this, "project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The region in which the instance template is located. If it is not provided, the provider region is used.
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// Controls for advanced machine-related behavior features.
    /// </summary>
    public TerraformList<TerraformMap<object>> AdvancedMachineFeatures
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "advanced_machine_features").ResolveNodes(ctx));
    }

    /// <summary>
    /// Whether to allow sending and receiving of packets with non-matching source or destination IPs. This defaults to false.
    /// </summary>
    public TerraformValue<bool> CanIpForward
    {
        get => new TerraformReference<bool>(this, "can_ip_forward");
    }

    /// <summary>
    /// The Confidential VM config being used by the instance. on_host_maintenance has to be set to TERMINATE or this will fail to create.
    /// </summary>
    public TerraformList<TerraformMap<object>> ConfidentialInstanceConfig
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "confidential_instance_config").ResolveNodes(ctx));
    }

    /// <summary>
    /// The time at which the instance was created in RFC 3339 format.
    /// </summary>
    public TerraformValue<string> CreationTimestamp
    {
        get => new TerraformReference<string>(this, "creation_timestamp");
    }

    /// <summary>
    /// A brief description of this resource.
    /// </summary>
    public TerraformValue<string> Description
    {
        get => new TerraformReference<string>(this, "description");
    }

    /// <summary>
    /// Disks to attach to instances created from this template. This can be specified multiple times for multiple disks.
    /// </summary>
    public TerraformList<TerraformMap<object>> Disk
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "disk").ResolveNodes(ctx));
    }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveLabels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "effective_labels").ResolveNodes(ctx));
    }

    /// <summary>
    /// List of the type and count of accelerator cards attached to the instance.
    /// </summary>
    public TerraformList<TerraformMap<object>> GuestAccelerator
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "guest_accelerator").ResolveNodes(ctx));
    }

    /// <summary>
    /// A description of the instance.
    /// </summary>
    public TerraformValue<string> InstanceDescription
    {
        get => new TerraformReference<string>(this, "instance_description");
    }

    /// <summary>
    /// Action to be taken when a customer&#39;s encryption key is revoked. Supports &amp;quot;STOP&amp;quot; and &amp;quot;NONE&amp;quot;, with &amp;quot;NONE&amp;quot; being the default.
    /// </summary>
    public TerraformValue<string> KeyRevocationActionType
    {
        get => new TerraformReference<string>(this, "key_revocation_action_type");
    }

    /// <summary>
    /// A set of key/value label pairs to assign to instances created from this template,
    /// 
    /// 				**Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// 				Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public TerraformMap<string> Labels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "labels").ResolveNodes(ctx));
    }

    /// <summary>
    /// The machine type to create. To create a machine with a custom type (such as extended memory), format the value like custom-VCPUS-MEM_IN_MB like custom-6-20480 for 6 vCPU and 20GB of RAM.
    /// </summary>
    public TerraformValue<string> MachineType
    {
        get => new TerraformReference<string>(this, "machine_type");
    }

    /// <summary>
    /// Metadata key/value pairs to make available from within instances created from this template.
    /// </summary>
    public TerraformMap<string> Metadata
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "metadata").ResolveNodes(ctx));
    }

    /// <summary>
    /// The unique fingerprint of the metadata.
    /// </summary>
    public TerraformValue<string> MetadataFingerprint
    {
        get => new TerraformReference<string>(this, "metadata_fingerprint");
    }

    /// <summary>
    /// An alternative to using the startup-script metadata key, mostly to match the compute_instance resource. This replaces the startup-script metadata key on the created instance and thus the two mechanisms are not allowed to be used simultaneously.
    /// </summary>
    public TerraformValue<string> MetadataStartupScript
    {
        get => new TerraformReference<string>(this, "metadata_startup_script");
    }

    /// <summary>
    /// Specifies a minimum CPU platform. Applicable values are the friendly names of CPU platforms, such as Intel Haswell or Intel Skylake.
    /// </summary>
    public TerraformValue<string> MinCpuPlatform
    {
        get => new TerraformReference<string>(this, "min_cpu_platform");
    }

    /// <summary>
    /// Creates a unique name beginning with the specified prefix. Conflicts with name.
    /// </summary>
    public TerraformValue<string> NamePrefix
    {
        get => new TerraformReference<string>(this, "name_prefix");
    }

    /// <summary>
    /// Networks to attach to instances created from this template. This can be specified multiple times for multiple networks.
    /// </summary>
    public TerraformList<TerraformMap<object>> NetworkInterface
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "network_interface").ResolveNodes(ctx));
    }

    /// <summary>
    /// Configures network performance settings for the instance. If not specified, the instance will be created with its default network performance configuration.
    /// </summary>
    public TerraformList<TerraformMap<object>> NetworkPerformanceConfig
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "network_performance_config").ResolveNodes(ctx));
    }

    /// <summary>
    /// The ID of the template in numeric format.
    /// </summary>
    public TerraformValue<string> NumericId
    {
        get => new TerraformReference<string>(this, "numeric_id");
    }

    /// <summary>
    /// Specifies the reservations that this instance can consume from.
    /// </summary>
    public TerraformList<TerraformMap<object>> ReservationAffinity
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "reservation_affinity").ResolveNodes(ctx));
    }

    /// <summary>
    /// A map of resource manager tags.
    /// 				Resource manager tag keys and values have the same definition as resource manager tags. Keys must be in the format tagKeys/{tag_key_id}, and values are in the format tagValues/456. The field is ignored (both PUT &amp;amp; PATCH) when empty.
    /// </summary>
    public TerraformMap<string> ResourceManagerTags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "resource_manager_tags").ResolveNodes(ctx));
    }

    /// <summary>
    /// A list of self_links of resource policies to attach to the instance. Currently a max of 1 resource policy is supported.
    /// </summary>
    public TerraformList<string> ResourcePolicies
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "resource_policies").ResolveNodes(ctx));
    }

    /// <summary>
    /// The scheduling strategy to use.
    /// </summary>
    public TerraformList<TerraformMap<object>> Scheduling
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "scheduling").ResolveNodes(ctx));
    }

    /// <summary>
    /// The URI of the created resource.
    /// </summary>
    public TerraformValue<string> SelfLink
    {
        get => new TerraformReference<string>(this, "self_link");
    }

    /// <summary>
    /// Service account to attach to the instance.
    /// </summary>
    public TerraformList<TerraformMap<object>> ServiceAccount
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "service_account").ResolveNodes(ctx));
    }

    /// <summary>
    /// Enable Shielded VM on this instance. Shielded VM provides verifiable integrity to prevent against malware and rootkits. Defaults to disabled. Note: shielded_instance_config can only be used with boot images with shielded vm support.
    /// </summary>
    public TerraformList<TerraformMap<object>> ShieldedInstanceConfig
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "shielded_instance_config").ResolveNodes(ctx));
    }

    /// <summary>
    /// Tags to attach to the instance.
    /// </summary>
    public TerraformSet<string> Tags
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "tags").ResolveNodes(ctx));
    }

    /// <summary>
    /// The unique fingerprint of the tags.
    /// </summary>
    public TerraformValue<string> TagsFingerprint
    {
        get => new TerraformReference<string>(this, "tags_fingerprint");
    }

    /// <summary>
    /// The combination of labels configured directly on the resource and default labels configured on the provider.
    /// </summary>
    public TerraformMap<string> TerraformLabels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "terraform_labels").ResolveNodes(ctx));
    }

}
