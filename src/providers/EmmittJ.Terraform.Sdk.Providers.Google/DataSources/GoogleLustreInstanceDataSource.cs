using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_lustre_instance.
/// </summary>
public partial class GoogleLustreInstanceDataSource : TerraformDataSource
{
    public GoogleLustreInstanceDataSource(string name) : base("google_lustre_instance", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name of the Managed Lustre instance.
    /// 
    /// * Must contain only lowercase letters, numbers, and hyphens.
    /// * Must start with a letter.
    /// * Must be between 1-63 characters.
    /// * Must end with a number or a letter.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceId is required")]
    [TerraformProperty("instance_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> InstanceId { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Project { get; set; }

    /// <summary>
    /// Zone of Lustre instance
    /// </summary>
    [TerraformProperty("zone")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Zone { get; set; }

    /// <summary>
    /// The storage capacity of the instance in gibibytes (GiB). Allowed values
    /// are from &#39;18000&#39; to &#39;954000&#39;, in increments of 9000.
    /// </summary>
    [TerraformProperty("capacity_gib")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> CapacityGib { get; }

    /// <summary>
    /// Timestamp when the instance was created.
    /// </summary>
    [TerraformProperty("create_time")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> CreateTime { get; }

    /// <summary>
    /// A user-readable description of the instance.
    /// </summary>
    [TerraformProperty("description")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Description { get; }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformProperty("effective_labels")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformMap<string> EffectiveLabels { get; }

    /// <summary>
    /// The filesystem name for this instance. This name is used by client-side
    /// tools, including when mounting the instance. Must be eight characters or
    /// less and can only contain letters and numbers.
    /// </summary>
    [TerraformProperty("filesystem")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Filesystem { get; }

    /// <summary>
    /// Indicates whether you want to enable support for GKE clients. By default,
    /// GKE clients are not supported.
    /// </summary>
    [TerraformProperty("gke_support_enabled")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> GkeSupportEnabled { get; }

    /// <summary>
    /// Labels as key value pairs.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformProperty("labels")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformMap<string> Labels { get; }

    /// <summary>
    /// Resource ID segment making up resource &#39;name&#39;. It identifies the resource within its parent collection as described in https://google.aip.dev/122.
    /// </summary>
    [TerraformProperty("location")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Location { get; }

    /// <summary>
    /// Mount point of the instance in the format &#39;IP_ADDRESS@tcp:/FILESYSTEM&#39;.
    /// </summary>
    [TerraformProperty("mount_point")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> MountPoint { get; }

    /// <summary>
    /// Identifier. The name of the instance.
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Name { get; }

    /// <summary>
    /// The full name of the VPC network to which the instance is connected.
    /// Must be in the format
    /// &#39;projects/{project_id}/global/networks/{network_name}&#39;.
    /// </summary>
    [TerraformProperty("network")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Network { get; }

    /// <summary>
    /// The throughput of the instance in MB/s/TiB.
    /// Valid values are 125, 250, 500, 1000.
    /// </summary>
    [TerraformProperty("per_unit_storage_throughput")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> PerUnitStorageThroughput { get; }

    /// <summary>
    /// The state of the instance.
    /// Possible values:
    /// STATE_UNSPECIFIED
    /// ACTIVE
    /// CREATING
    /// DELETING
    /// UPGRADING
    /// REPAIRING
    /// STOPPED
    /// </summary>
    [TerraformProperty("state")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> State { get; }

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformProperty("terraform_labels")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformMap<string> TerraformLabels { get; }

    /// <summary>
    /// Timestamp when the instance was last updated.
    /// </summary>
    [TerraformProperty("update_time")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> UpdateTime { get; }

}
