using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_lustre_instance.
/// </summary>
public class GoogleLustreInstanceDataSource : TerraformDataSource
{
    public GoogleLustreInstanceDataSource(string name) : base("google_lustre_instance", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The name of the Managed Lustre instance.
    /// 
    /// * Must contain only lowercase letters, numbers, and hyphens.
    /// * Must start with a letter.
    /// * Must be between 1-63 characters.
    /// * Must end with a number or a letter.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceId is required")]
    [TerraformPropertyName("instance_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> InstanceId { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Project { get; set; }

    /// <summary>
    /// Zone of Lustre instance
    /// </summary>
    [TerraformPropertyName("zone")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Zone { get; set; }

    /// <summary>
    /// The storage capacity of the instance in gibibytes (GiB). Allowed values
    /// are from &#39;18000&#39; to &#39;954000&#39;, in increments of 9000.
    /// </summary>
    [TerraformPropertyName("capacity_gib")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CapacityGib => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "capacity_gib");

    /// <summary>
    /// Timestamp when the instance was created.
    /// </summary>
    [TerraformPropertyName("create_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreateTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "create_time");

    /// <summary>
    /// A user-readable description of the instance.
    /// </summary>
    [TerraformPropertyName("description")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Description => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "description");

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformPropertyName("effective_labels")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> EffectiveLabels => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "effective_labels");

    /// <summary>
    /// The filesystem name for this instance. This name is used by client-side
    /// tools, including when mounting the instance. Must be eight characters or
    /// less and can only contain letters and numbers.
    /// </summary>
    [TerraformPropertyName("filesystem")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Filesystem => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "filesystem");

    /// <summary>
    /// Indicates whether you want to enable support for GKE clients. By default,
    /// GKE clients are not supported.
    /// </summary>
    [TerraformPropertyName("gke_support_enabled")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> GkeSupportEnabled => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "gke_support_enabled");

    /// <summary>
    /// Labels as key value pairs.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformPropertyName("labels")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Labels => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "labels");

    /// <summary>
    /// Resource ID segment making up resource &#39;name&#39;. It identifies the resource within its parent collection as described in https://google.aip.dev/122.
    /// </summary>
    [TerraformPropertyName("location")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Location => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "location");

    /// <summary>
    /// Mount point of the instance in the format &#39;IP_ADDRESS@tcp:/FILESYSTEM&#39;.
    /// </summary>
    [TerraformPropertyName("mount_point")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> MountPoint => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "mount_point");

    /// <summary>
    /// Identifier. The name of the instance.
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Name => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name");

    /// <summary>
    /// The full name of the VPC network to which the instance is connected.
    /// Must be in the format
    /// &#39;projects/{project_id}/global/networks/{network_name}&#39;.
    /// </summary>
    [TerraformPropertyName("network")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Network => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "network");

    /// <summary>
    /// The throughput of the instance in MB/s/TiB.
    /// Valid values are 125, 250, 500, 1000.
    /// </summary>
    [TerraformPropertyName("per_unit_storage_throughput")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PerUnitStorageThroughput => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "per_unit_storage_throughput");

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
    [TerraformPropertyName("state")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> State => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "state");

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformPropertyName("terraform_labels")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TerraformLabels => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "terraform_labels");

    /// <summary>
    /// Timestamp when the instance was last updated.
    /// </summary>
    [TerraformPropertyName("update_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> UpdateTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "update_time");

}
