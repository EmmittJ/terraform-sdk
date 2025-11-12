using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleTagsTagKeyTimeoutsBlock() : TerraformBlock("timeouts")
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
/// Manages a google_tags_tag_key resource.
/// </summary>
public partial class GoogleTagsTagKey : TerraformResource
{
    public GoogleTagsTagKey(string name) : base("google_tags_tag_key", name)
    {
    }

    /// <summary>
    /// User-assigned description of the TagKey. Must not exceed 256 characters.
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
    /// Input only. The resource name of the new TagKey&#39;s parent. Must be of the form organizations/{org_id} or projects/{project_id_or_number}.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Parent is required")]
    [TerraformProperty("parent")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Parent { get; set; }

    /// <summary>
    /// Optional. A purpose cannot be changed once set.
    /// 
    /// A purpose denotes that this Tag is intended for use in policies of a specific policy engine, and will involve that policy engine in management operations involving this Tag. Possible values: [&amp;quot;GCE_FIREWALL&amp;quot;, &amp;quot;DATA_GOVERNANCE&amp;quot;]
    /// </summary>
    [TerraformProperty("purpose")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Purpose { get; set; }

    /// <summary>
    /// Optional. Purpose data cannot be changed once set.
    /// 
    /// Purpose data corresponds to the policy system that the tag is intended for. For example, the GCE_FIREWALL purpose expects data in the following format: &#39;network = &amp;quot;&amp;lt;project-name&amp;gt;/&amp;lt;vpc-name&amp;gt;&amp;quot;&#39;.
    /// </summary>
    [TerraformProperty("purpose_data")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? PurposeData { get; set; }

    /// <summary>
    /// Input only. The user friendly name for a TagKey. The short name should be unique for TagKeys within the same tag namespace.
    /// 
    /// The short name can have a maximum length of 256 characters. The permitted character set for the shortName includes all UTF-8 encoded Unicode characters except single quotes (&#39;), double quotes (&amp;quot;), backslashes (\\), and forward slashes (/).
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ShortName is required")]
    [TerraformProperty("short_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ShortName { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public GoogleTagsTagKeyTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// Output only. Creation time.
    /// 
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine fractional digits. Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    [TerraformProperty("create_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CreateTime { get; }

    /// <summary>
    /// The generated numeric id for the TagKey.
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Name { get; }

    /// <summary>
    /// Output only. Namespaced name of the TagKey.
    /// </summary>
    [TerraformProperty("namespaced_name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> NamespacedName { get; }

    /// <summary>
    /// Output only. Update time.
    /// 
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine fractional digits. Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    [TerraformProperty("update_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> UpdateTime { get; }

}
