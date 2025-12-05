using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Represents a google_compute_instance_template Terraform data source.
/// Retrieves information about a google_compute_instance_template.
/// </summary>
public partial class GoogleComputeInstanceTemplateDataSource(string name) : TerraformDataSource("google_compute_instance_template", name)
{
    /// <summary>
    /// The filter attribute.
    /// </summary>
    public TerraformValue<string>? Filter
    {
        get => GetArgument<TerraformValue<string>>("filter");
        set => SetArgument("filter", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The most_recent attribute.
    /// </summary>
    public TerraformValue<bool>? MostRecent
    {
        get => GetArgument<TerraformValue<bool>>("most_recent");
        set => SetArgument("most_recent", value);
    }

    /// <summary>
    /// The name of the instance template. If you leave this blank, Terraform will auto-generate a unique name.
    /// </summary>
    public TerraformValue<string>? Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The ID of the project in which the resource belongs. If it is not provided, the provider project is used.
    /// </summary>
    public TerraformValue<string>? Project
    {
        get => GetArgument<TerraformValue<string>>("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The self_link_unique attribute.
    /// </summary>
    public TerraformValue<string>? SelfLinkUnique
    {
        get => GetArgument<TerraformValue<string>>("self_link_unique");
        set => SetArgument("self_link_unique", value);
    }

    /// <summary>
    /// Controls for advanced machine-related behavior features.
    /// </summary>
    public TerraformList<TerraformMap<object>> AdvancedMachineFeatures
        => CreateReference("advanced_machine_features");

    /// <summary>
    /// Whether to allow sending and receiving of packets with non-matching source or destination IPs. This defaults to false.
    /// </summary>
    public TerraformValue<bool> CanIpForward
        => CreateReference("can_ip_forward");

    /// <summary>
    /// The Confidential VM config being used by the instance. on_host_maintenance has to be set to TERMINATE or this will fail to create.
    /// </summary>
    public TerraformList<TerraformMap<object>> ConfidentialInstanceConfig
        => CreateReference("confidential_instance_config");

    /// <summary>
    /// Creation timestamp in RFC3339 text format.
    /// </summary>
    public TerraformValue<string> CreationTimestamp
        => CreateReference("creation_timestamp");

    /// <summary>
    /// A brief description of this resource.
    /// </summary>
    public TerraformValue<string> Description
        => CreateReference("description");

    /// <summary>
    /// Disks to attach to instances created from this template. This can be specified multiple times for multiple disks.
    /// </summary>
    public TerraformList<TerraformMap<object>> Disk
        => CreateReference("disk");

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveLabels
        => CreateReference("effective_labels");

    /// <summary>
    /// List of the type and count of accelerator cards attached to the instance.
    /// </summary>
    public TerraformList<TerraformMap<object>> GuestAccelerator
        => CreateReference("guest_accelerator");

    /// <summary>
    /// A description of the instance.
    /// </summary>
    public TerraformValue<string> InstanceDescription
        => CreateReference("instance_description");

    /// <summary>
    /// Action to be taken when a customer&#39;s encryption key is revoked. Supports &amp;quot;STOP&amp;quot; and &amp;quot;NONE&amp;quot;, with &amp;quot;NONE&amp;quot; being the default.
    /// </summary>
    public TerraformValue<string> KeyRevocationActionType
        => CreateReference("key_revocation_action_type");

    /// <summary>
    /// A set of key/value label pairs to assign to instances created from this template.
    /// 
    /// 				**Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// 				Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public TerraformMap<string> Labels
        => CreateReference("labels");

    /// <summary>
    /// The machine type to create. To create a machine with a custom type (such as extended memory), format the value like custom-VCPUS-MEM_IN_MB like custom-6-20480 for 6 vCPU and 20GB of RAM.
    /// </summary>
    public TerraformValue<string> MachineType
        => CreateReference("machine_type");

    /// <summary>
    /// Metadata key/value pairs to make available from within instances created from this template.
    /// </summary>
    public TerraformMap<string> Metadata
        => CreateReference("metadata");

    /// <summary>
    /// The unique fingerprint of the metadata.
    /// </summary>
    public TerraformValue<string> MetadataFingerprint
        => CreateReference("metadata_fingerprint");

    /// <summary>
    /// An alternative to using the startup-script metadata key, mostly to match the compute_instance resource. This replaces the startup-script metadata key on the created instance and thus the two mechanisms are not allowed to be used simultaneously.
    /// </summary>
    public TerraformValue<string> MetadataStartupScript
        => CreateReference("metadata_startup_script");

    /// <summary>
    /// Specifies a minimum CPU platform. Applicable values are the friendly names of CPU platforms, such as Intel Haswell or Intel Skylake.
    /// </summary>
    public TerraformValue<string> MinCpuPlatform
        => CreateReference("min_cpu_platform");

    /// <summary>
    /// Creates a unique name beginning with the specified prefix. Conflicts with name. Max length is 54 characters. Prefixes with lengths longer than 37 characters will use a shortened UUID that will be more prone to collisions.
    /// </summary>
    public TerraformValue<string> NamePrefix
        => CreateReference("name_prefix");

    /// <summary>
    /// Networks to attach to instances created from this template. This can be specified multiple times for multiple networks.
    /// </summary>
    public TerraformList<TerraformMap<object>> NetworkInterface
        => CreateReference("network_interface");

    /// <summary>
    /// Configures network performance settings for the instance. If not specified, the instance will be created with its default network performance configuration.
    /// </summary>
    public TerraformList<TerraformMap<object>> NetworkPerformanceConfig
        => CreateReference("network_performance_config");

    /// <summary>
    /// The ID of the template in numeric format.
    /// </summary>
    public TerraformValue<string> NumericId
        => CreateReference("numeric_id");

    /// <summary>
    /// An instance template is a global resource that is not bound to a zone or a region. However, you can still specify some regional resources in an instance template, which restricts the template to the region where that resource resides. For example, a custom subnetwork resource is tied to a specific region. Defaults to the region of the Provider if no value is given.
    /// </summary>
    public TerraformValue<string> Region
        => CreateReference("region");

    /// <summary>
    /// Specifies the reservations that this instance can consume from.
    /// </summary>
    public TerraformList<TerraformMap<object>> ReservationAffinity
        => CreateReference("reservation_affinity");

    /// <summary>
    /// A map of resource manager tags.
    /// 				Resource manager tag keys and values have the same definition as resource manager tags.
    /// 				Keys must be in the format tagKeys/{tag_key_id}, and values are in the format tagValues/456.
    /// 				The field is ignored (both PUT &amp;amp; PATCH) when empty.
    /// </summary>
    public TerraformMap<string> ResourceManagerTags
        => CreateReference("resource_manager_tags");

    /// <summary>
    /// A list of self_links of resource policies to attach to the instance. Currently a max of 1 resource policy is supported.
    /// </summary>
    public TerraformList<string> ResourcePolicies
        => CreateReference("resource_policies");

    /// <summary>
    /// The scheduling strategy to use.
    /// </summary>
    public TerraformList<TerraformMap<object>> Scheduling
        => CreateReference("scheduling");

    /// <summary>
    /// The URI of the created resource.
    /// </summary>
    public TerraformValue<string> SelfLink
        => CreateReference("self_link");

    /// <summary>
    /// Service account to attach to the instance.
    /// </summary>
    public TerraformList<TerraformMap<object>> ServiceAccount
        => CreateReference("service_account");

    /// <summary>
    /// Enable Shielded VM on this instance. Shielded VM provides verifiable integrity to prevent against malware and rootkits. Defaults to disabled. Note: shielded_instance_config can only be used with boot images with shielded vm support.
    /// </summary>
    public TerraformList<TerraformMap<object>> ShieldedInstanceConfig
        => CreateReference("shielded_instance_config");

    /// <summary>
    /// Tags to attach to the instance.
    /// </summary>
    public TerraformSet<string> Tags
        => CreateReference("tags");

    /// <summary>
    /// The unique fingerprint of the tags.
    /// </summary>
    public TerraformValue<string> TagsFingerprint
        => CreateReference("tags_fingerprint");

    /// <summary>
    /// The combination of labels configured directly on the resource and default labels configured on the provider.
    /// </summary>
    public TerraformMap<string> TerraformLabels
        => CreateReference("terraform_labels");

}
