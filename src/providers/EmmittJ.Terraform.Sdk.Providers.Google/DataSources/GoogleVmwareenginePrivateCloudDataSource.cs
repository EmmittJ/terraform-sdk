using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_vmwareengine_private_cloud.
/// </summary>
public class GoogleVmwareenginePrivateCloudDataSource : TerraformDataSource
{
    public GoogleVmwareenginePrivateCloudDataSource(string name) : base("google_vmwareengine_private_cloud", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The location where the PrivateCloud should reside.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Location { get; set; }

    /// <summary>
    /// The ID of the PrivateCloud.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Project { get; set; }

    /// <summary>
    /// Creation time of this resource.
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine fractional digits.
    /// Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    [TerraformPropertyName("create_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreateTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "create_time");

    /// <summary>
    /// Time when the resource was scheduled for deletion.
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine fractional digits.
    /// Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    [TerraformPropertyName("delete_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DeleteTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "delete_time");

    /// <summary>
    /// The number of hours to delay this request. You can set this value to an hour between 0 to 8, where setting it to 0 starts the deletion request immediately. If no value is set, a default value is set at the API Level.
    /// </summary>
    [TerraformPropertyName("deletion_delay_hours")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> DeletionDelayHours => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "deletion_delay_hours");

    /// <summary>
    /// User-provided description for this private cloud.
    /// </summary>
    [TerraformPropertyName("description")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Description => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "description");

    /// <summary>
    /// Time when the resource will be irreversibly deleted.
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine fractional digits.
    /// Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    [TerraformPropertyName("expire_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ExpireTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "expire_time");

    /// <summary>
    /// Details about a HCX Cloud Manager appliance.
    /// </summary>
    [TerraformPropertyName("hcx")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Hcx => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "hcx");

    /// <summary>
    /// The management cluster for this private cloud. This used for creating and managing the default cluster.
    /// </summary>
    [TerraformPropertyName("management_cluster")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> ManagementCluster => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "management_cluster");

    /// <summary>
    /// Network configuration in the consumer project with which the peering has to be done.
    /// </summary>
    [TerraformPropertyName("network_config")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> NetworkConfig => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "network_config");

    /// <summary>
    /// Details about a NSX Manager appliance.
    /// </summary>
    [TerraformPropertyName("nsx")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Nsx => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "nsx");

    /// <summary>
    /// While set true, deletion_delay_hours value will be sent in the request even for zero value of the field. This field is only useful for setting 0 value to the deletion_delay_hours field. It can be used both alone and together with deletion_delay_hours.
    /// </summary>
    [TerraformPropertyName("send_deletion_delay_hours_if_zero")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> SendDeletionDelayHoursIfZero => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "send_deletion_delay_hours_if_zero");

    /// <summary>
    /// State of the resource. New values may be added to this enum when appropriate.
    /// </summary>
    [TerraformPropertyName("state")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> State => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "state");

    /// <summary>
    /// Initial type of the private cloud. Possible values: [&amp;quot;STANDARD&amp;quot;, &amp;quot;TIME_LIMITED&amp;quot;, &amp;quot;STRETCHED&amp;quot;]
    /// </summary>
    [TerraformPropertyName("type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Type => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "type");

    /// <summary>
    /// System-generated unique identifier for the resource.
    /// </summary>
    [TerraformPropertyName("uid")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Uid => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "uid");

    /// <summary>
    /// Last update time of this resource.
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine fractional digits.
    /// Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    [TerraformPropertyName("update_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> UpdateTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "update_time");

    /// <summary>
    /// Details about a vCenter Server management appliance.
    /// </summary>
    [TerraformPropertyName("vcenter")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Vcenter => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "vcenter");

}
