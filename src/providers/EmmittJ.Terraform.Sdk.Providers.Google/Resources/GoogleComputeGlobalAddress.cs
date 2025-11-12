using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleComputeGlobalAddressTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_compute_global_address resource.
/// </summary>
public partial class GoogleComputeGlobalAddress : TerraformResource
{
    public GoogleComputeGlobalAddress(string name) : base("google_compute_global_address", name)
    {
    }

    /// <summary>
    /// The IP address or beginning of the address range represented by this
    /// resource. This can be supplied as an input to reserve a specific
    /// address or omitted to allow GCP to choose a valid one for you.
    /// </summary>
    [TerraformProperty("address")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Address { get; set; }

    /// <summary>
    /// The type of the address to reserve.
    /// 
    /// * EXTERNAL indicates public/external single IP address.
    /// * INTERNAL indicates internal IP ranges belonging to some network. Default value: &amp;quot;EXTERNAL&amp;quot; Possible values: [&amp;quot;EXTERNAL&amp;quot;, &amp;quot;INTERNAL&amp;quot;]
    /// </summary>
    [TerraformProperty("address_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? AddressType { get; set; }

    /// <summary>
    /// An optional description of this resource.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The IP Version that will be used by this address. The default value is &#39;IPV4&#39;. Possible values: [&amp;quot;IPV4&amp;quot;, &amp;quot;IPV6&amp;quot;]
    /// </summary>
    [TerraformProperty("ip_version")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? IpVersion { get; set; }

    /// <summary>
    /// Labels to apply to this address.  A list of key-&amp;gt;value pairs.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformProperty("labels")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Labels { get; set; }

    /// <summary>
    /// Name of the resource. Provided by the client when the resource is
    /// created. The name must be 1-63 characters long, and comply with
    /// RFC1035.  Specifically, the name must be 1-63 characters long and
    /// match the regular expression &#39;[a-z]([-a-z0-9]*[a-z0-9])?&#39; which means
    /// the first character must be a lowercase letter, and all following
    /// characters must be a dash, lowercase letter, or digit, except the last
    /// character, which cannot be a dash.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The URL of the network in which to reserve the IP range. The IP range
    /// must be in RFC1918 space. The network cannot be deleted if there are
    /// any reserved IP ranges referring to it.
    /// 
    /// This should only be set when using an Internal address.
    /// </summary>
    [TerraformProperty("network")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Network { get; set; }

    /// <summary>
    /// The prefix length of the IP range. If not present, it means the
    /// address field is a single IP address.
    /// 
    /// This field is not applicable to addresses with addressType=INTERNAL
    /// when purpose=PRIVATE_SERVICE_CONNECT
    /// </summary>
    [TerraformProperty("prefix_length")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> PrefixLength { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Project { get; set; }

    /// <summary>
    /// The purpose of the resource. Possible values include:
    /// 
    /// * VPC_PEERING - for peer networks
    /// 
    /// * PRIVATE_SERVICE_CONNECT - for ([Beta](https://terraform.io/docs/providers/google/guides/provider_versions.html) only) Private Service Connect networks
    /// </summary>
    [TerraformProperty("purpose")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Purpose { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public GoogleComputeGlobalAddressTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// Creation timestamp in RFC3339 text format.
    /// </summary>
    [TerraformProperty("creation_timestamp")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CreationTimestamp { get; }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformProperty("effective_labels")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> EffectiveLabels { get; }

    /// <summary>
    /// The fingerprint used for optimistic locking of this resource.  Used
    /// internally during updates.
    /// </summary>
    [TerraformProperty("label_fingerprint")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> LabelFingerprint { get; }

    /// <summary>
    /// The self_link attribute.
    /// </summary>
    [TerraformProperty("self_link")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SelfLink { get; }

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformProperty("terraform_labels")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> TerraformLabels { get; }

}
