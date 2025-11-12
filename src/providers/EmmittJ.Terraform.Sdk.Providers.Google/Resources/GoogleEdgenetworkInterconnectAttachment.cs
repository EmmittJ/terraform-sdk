using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleEdgenetworkInterconnectAttachmentTimeoutsBlock() : TerraformBlock("timeouts")
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
/// Manages a google_edgenetwork_interconnect_attachment resource.
/// </summary>
public partial class GoogleEdgenetworkInterconnectAttachment : TerraformResource
{
    public GoogleEdgenetworkInterconnectAttachment(string name) : base("google_edgenetwork_interconnect_attachment", name)
    {
    }

    /// <summary>
    /// A free-text description of the resource. Max length 1024 characters.
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
    /// The ID of the underlying interconnect that this attachment&#39;s traffic will traverse through.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Interconnect is required")]
    [TerraformProperty("interconnect")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Interconnect { get; set; }

    /// <summary>
    /// A unique ID that identifies this interconnect attachment.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InterconnectAttachmentId is required")]
    [TerraformProperty("interconnect_attachment_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> InterconnectAttachmentId { get; set; }

    /// <summary>
    /// Labels associated with this resource.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformProperty("labels")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Labels { get; set; }

    /// <summary>
    /// The Google Cloud region to which the target Distributed Cloud Edge zone belongs.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Location { get; set; }

    /// <summary>
    /// IP (L3) MTU value of the virtual edge cloud. Default value is &#39;1500&#39;. Possible values are: &#39;1500&#39;, &#39;9000&#39;.
    /// </summary>
    [TerraformProperty("mtu")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? Mtu { get; set; }

    /// <summary>
    /// The ID of the network to which this interconnect attachment belongs.
    /// Must be of the form: &#39;projects/{{project}}/locations/{{location}}/zones/{{zone}}/networks/{{network_id}}&#39;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Network is required")]
    [TerraformProperty("network")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Network { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Project { get; set; }

    /// <summary>
    /// VLAN ID provided by user. Must be site-wise unique.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VlanId is required")]
    [TerraformProperty("vlan_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> VlanId { get; set; }

    /// <summary>
    /// The name of the target Distributed Cloud Edge zone.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Zone is required")]
    [TerraformProperty("zone")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Zone { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public GoogleEdgenetworkInterconnectAttachmentTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The time when the resource was created.
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine
    /// fractional digits. Examples: &#39;2014-10-02T15:01:23Z&#39; and &#39;2014-10-02T15:01:23.045123456Z&#39;.
    /// </summary>
    [TerraformProperty("create_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CreateTime { get; }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformProperty("effective_labels")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> EffectiveLabels { get; }

    /// <summary>
    /// The canonical name of this resource, with format
    /// &#39;projects/{{project}}/locations/{{location}}/zones/{{zone}}/interconnectAttachments/{{interconnect_attachment_id}}&#39;
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Name { get; }

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformProperty("terraform_labels")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> TerraformLabels { get; }

    /// <summary>
    /// The time when the resource was last updated.
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine
    /// fractional digits. Examples: &#39;2014-10-02T15:01:23Z&#39; and &#39;2014-10-02T15:01:23.045123456Z&#39;.
    /// </summary>
    [TerraformProperty("update_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> UpdateTime { get; }

}
