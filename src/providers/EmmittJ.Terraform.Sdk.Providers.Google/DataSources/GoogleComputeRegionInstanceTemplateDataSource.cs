using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_compute_region_instance_template.
/// </summary>
public class GoogleComputeRegionInstanceTemplateDataSource : TerraformDataSource
{
    public GoogleComputeRegionInstanceTemplateDataSource(string name) : base("google_compute_region_instance_template", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("advanced_machine_features");
        SetOutput("can_ip_forward");
        SetOutput("confidential_instance_config");
        SetOutput("creation_timestamp");
        SetOutput("description");
        SetOutput("disk");
        SetOutput("effective_labels");
        SetOutput("guest_accelerator");
        SetOutput("instance_description");
        SetOutput("key_revocation_action_type");
        SetOutput("labels");
        SetOutput("machine_type");
        SetOutput("metadata");
        SetOutput("metadata_fingerprint");
        SetOutput("metadata_startup_script");
        SetOutput("min_cpu_platform");
        SetOutput("name_prefix");
        SetOutput("network_interface");
        SetOutput("network_performance_config");
        SetOutput("numeric_id");
        SetOutput("reservation_affinity");
        SetOutput("resource_manager_tags");
        SetOutput("resource_policies");
        SetOutput("scheduling");
        SetOutput("self_link");
        SetOutput("service_account");
        SetOutput("shielded_instance_config");
        SetOutput("tags");
        SetOutput("tags_fingerprint");
        SetOutput("terraform_labels");
        SetOutput("filter");
        SetOutput("id");
        SetOutput("most_recent");
        SetOutput("name");
        SetOutput("project");
        SetOutput("region");
    }

    /// <summary>
    /// The filter attribute.
    /// </summary>
    public TerraformProperty<string> Filter
    {
        get => GetRequiredOutput<TerraformProperty<string>>("filter");
        set => SetProperty("filter", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The most_recent attribute.
    /// </summary>
    public TerraformProperty<bool> MostRecent
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("most_recent");
        set => SetProperty("most_recent", value);
    }

    /// <summary>
    /// The name of the instance template. If you leave this blank, Terraform will auto-generate a unique name.
    /// </summary>
    public TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The ID of the project in which the resource belongs. If it is not provided, the provider project is used.
    /// </summary>
    public TerraformProperty<string> Project
    {
        get => GetRequiredOutput<TerraformProperty<string>>("project");
        set => SetProperty("project", value);
    }

    /// <summary>
    /// The region in which the instance template is located. If it is not provided, the provider region is used.
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// Controls for advanced machine-related behavior features.
    /// </summary>
    public TerraformExpression AdvancedMachineFeatures => this["advanced_machine_features"];

    /// <summary>
    /// Whether to allow sending and receiving of packets with non-matching source or destination IPs. This defaults to false.
    /// </summary>
    public TerraformExpression CanIpForward => this["can_ip_forward"];

    /// <summary>
    /// The Confidential VM config being used by the instance. on_host_maintenance has to be set to TERMINATE or this will fail to create.
    /// </summary>
    public TerraformExpression ConfidentialInstanceConfig => this["confidential_instance_config"];

    /// <summary>
    /// The time at which the instance was created in RFC 3339 format.
    /// </summary>
    public TerraformExpression CreationTimestamp => this["creation_timestamp"];

    /// <summary>
    /// A brief description of this resource.
    /// </summary>
    public TerraformExpression Description => this["description"];

    /// <summary>
    /// Disks to attach to instances created from this template. This can be specified multiple times for multiple disks.
    /// </summary>
    public TerraformExpression Disk => this["disk"];

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveLabels => this["effective_labels"];

    /// <summary>
    /// List of the type and count of accelerator cards attached to the instance.
    /// </summary>
    public TerraformExpression GuestAccelerator => this["guest_accelerator"];

    /// <summary>
    /// A description of the instance.
    /// </summary>
    public TerraformExpression InstanceDescription => this["instance_description"];

    /// <summary>
    /// Action to be taken when a customer&#39;s encryption key is revoked. Supports &amp;quot;STOP&amp;quot; and &amp;quot;NONE&amp;quot;, with &amp;quot;NONE&amp;quot; being the default.
    /// </summary>
    public TerraformExpression KeyRevocationActionType => this["key_revocation_action_type"];

    /// <summary>
    /// A set of key/value label pairs to assign to instances created from this template,
    /// 
    /// 				**Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// 				Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public TerraformExpression Labels => this["labels"];

    /// <summary>
    /// The machine type to create. To create a machine with a custom type (such as extended memory), format the value like custom-VCPUS-MEM_IN_MB like custom-6-20480 for 6 vCPU and 20GB of RAM.
    /// </summary>
    public TerraformExpression MachineType => this["machine_type"];

    /// <summary>
    /// Metadata key/value pairs to make available from within instances created from this template.
    /// </summary>
    public TerraformExpression Metadata => this["metadata"];

    /// <summary>
    /// The unique fingerprint of the metadata.
    /// </summary>
    public TerraformExpression MetadataFingerprint => this["metadata_fingerprint"];

    /// <summary>
    /// An alternative to using the startup-script metadata key, mostly to match the compute_instance resource. This replaces the startup-script metadata key on the created instance and thus the two mechanisms are not allowed to be used simultaneously.
    /// </summary>
    public TerraformExpression MetadataStartupScript => this["metadata_startup_script"];

    /// <summary>
    /// Specifies a minimum CPU platform. Applicable values are the friendly names of CPU platforms, such as Intel Haswell or Intel Skylake.
    /// </summary>
    public TerraformExpression MinCpuPlatform => this["min_cpu_platform"];

    /// <summary>
    /// Creates a unique name beginning with the specified prefix. Conflicts with name.
    /// </summary>
    public TerraformExpression NamePrefix => this["name_prefix"];

    /// <summary>
    /// Networks to attach to instances created from this template. This can be specified multiple times for multiple networks.
    /// </summary>
    public TerraformExpression NetworkInterface => this["network_interface"];

    /// <summary>
    /// Configures network performance settings for the instance. If not specified, the instance will be created with its default network performance configuration.
    /// </summary>
    public TerraformExpression NetworkPerformanceConfig => this["network_performance_config"];

    /// <summary>
    /// The ID of the template in numeric format.
    /// </summary>
    public TerraformExpression NumericId => this["numeric_id"];

    /// <summary>
    /// Specifies the reservations that this instance can consume from.
    /// </summary>
    public TerraformExpression ReservationAffinity => this["reservation_affinity"];

    /// <summary>
    /// A map of resource manager tags.
    /// 				Resource manager tag keys and values have the same definition as resource manager tags. Keys must be in the format tagKeys/{tag_key_id}, and values are in the format tagValues/456. The field is ignored (both PUT &amp;amp; PATCH) when empty.
    /// </summary>
    public TerraformExpression ResourceManagerTags => this["resource_manager_tags"];

    /// <summary>
    /// A list of self_links of resource policies to attach to the instance. Currently a max of 1 resource policy is supported.
    /// </summary>
    public TerraformExpression ResourcePolicies => this["resource_policies"];

    /// <summary>
    /// The scheduling strategy to use.
    /// </summary>
    public TerraformExpression Scheduling => this["scheduling"];

    /// <summary>
    /// The URI of the created resource.
    /// </summary>
    public TerraformExpression SelfLink => this["self_link"];

    /// <summary>
    /// Service account to attach to the instance.
    /// </summary>
    public TerraformExpression ServiceAccount => this["service_account"];

    /// <summary>
    /// Enable Shielded VM on this instance. Shielded VM provides verifiable integrity to prevent against malware and rootkits. Defaults to disabled. Note: shielded_instance_config can only be used with boot images with shielded vm support.
    /// </summary>
    public TerraformExpression ShieldedInstanceConfig => this["shielded_instance_config"];

    /// <summary>
    /// Tags to attach to the instance.
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
