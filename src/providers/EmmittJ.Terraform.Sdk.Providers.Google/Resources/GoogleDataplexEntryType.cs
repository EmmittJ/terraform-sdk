using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for required_aspects in .
/// Nesting mode: list
/// </summary>
public partial class GoogleDataplexEntryTypeRequiredAspectsBlock : TerraformBlockBase
{
    /// <summary>
    /// Required aspect type for the entry type.
    /// </summary>
    [TerraformProperty("type")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Type { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleDataplexEntryTypeTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_dataplex_entry_type resource.
/// </summary>
public partial class GoogleDataplexEntryType : TerraformResource
{
    public GoogleDataplexEntryType(string name) : base("google_dataplex_entry_type", name)
    {
    }

    /// <summary>
    /// Description of the EntryType.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// User friendly display name.
    /// </summary>
    [TerraformProperty("display_name")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? DisplayName { get; set; }

    /// <summary>
    /// The entry type id of the entry type.
    /// </summary>
    [TerraformProperty("entry_type_id")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? EntryTypeId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// User-defined labels for the EntryType.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformProperty("labels")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Labels { get; set; }

    /// <summary>
    /// The location where entry type will be created in.
    /// </summary>
    [TerraformProperty("location")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Location { get; set; }

    /// <summary>
    /// The platform that Entries of this type belongs to.
    /// </summary>
    [TerraformProperty("platform")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Platform { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Project { get; set; }

    /// <summary>
    /// The system that Entries of this type belongs to.
    /// </summary>
    [TerraformProperty("system")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? System { get; set; }

    /// <summary>
    /// Indicates the class this Entry Type belongs to, for example, TABLE, DATABASE, MODEL.
    /// </summary>
    [TerraformProperty("type_aliases")]
    // Optional argument - source generator will implement get/set
    public TerraformList<string>? TypeAliases { get; set; }

    /// <summary>
    /// Block for required_aspects.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("required_aspects")]
    public TerraformList<TerraformBlock<GoogleDataplexEntryTypeRequiredAspectsBlock>>? RequiredAspects { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<GoogleDataplexEntryTypeTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The time when the EntryType was created.
    /// </summary>
    [TerraformProperty("create_time")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> CreateTime { get; }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformProperty("effective_labels")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformMap<string> EffectiveLabels { get; }

    /// <summary>
    /// The relative resource name of the EntryType, of the form: projects/{project_number}/locations/{location_id}/entryTypes/{entry_type_id}
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Name { get; }

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformProperty("terraform_labels")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformMap<string> TerraformLabels { get; }

    /// <summary>
    /// System generated globally unique ID for the EntryType. This ID will be different if the EntryType is deleted and re-created with the same name.
    /// </summary>
    [TerraformProperty("uid")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Uid { get; }

    /// <summary>
    /// The time when the EntryType was last updated.
    /// </summary>
    [TerraformProperty("update_time")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> UpdateTime { get; }

}
