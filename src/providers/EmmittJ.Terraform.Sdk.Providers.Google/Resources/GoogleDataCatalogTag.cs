using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for fields in .
/// Nesting mode: set
/// </summary>
public partial class GoogleDataCatalogTagFieldsBlock() : TerraformBlock("fields")
{
    /// <summary>
    /// Holds the value for a tag field with boolean type.
    /// </summary>
    [TerraformProperty("bool_value")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? BoolValue { get; set; }


    /// <summary>
    /// Holds the value for a tag field with double type.
    /// </summary>
    [TerraformProperty("double_value")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? DoubleValue { get; set; }

    /// <summary>
    /// The display name of the enum value.
    /// </summary>
    [TerraformProperty("enum_value")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? EnumValue { get; set; }

    /// <summary>
    /// The field_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FieldName is required")]
    [TerraformProperty("field_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> FieldName { get; set; }


    /// <summary>
    /// Holds the value for a tag field with string type.
    /// </summary>
    [TerraformProperty("string_value")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? StringValue { get; set; }

    /// <summary>
    /// Holds the value for a tag field with timestamp type.
    /// </summary>
    [TerraformProperty("timestamp_value")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? TimestampValue { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleDataCatalogTagTimeoutsBlock() : TerraformBlock("timeouts")
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
/// Manages a google_data_catalog_tag resource.
/// </summary>
[Obsolete("This resource is deprecated.")]
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleDataCatalogTag : TerraformResource
{
    public GoogleDataCatalogTag(string name) : base("google_data_catalog_tag", name)
    {
    }

    /// <summary>
    /// Resources like Entry can have schemas associated with them. This scope allows users to attach tags to an
    /// individual column based on that schema.
    /// 
    /// For attaching a tag to a nested column, use &#39;.&#39; to separate the column names. Example:
    /// &#39;outer_column.inner_column&#39;
    /// </summary>
    [TerraformProperty("column")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Column { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name of the parent this tag is attached to. This can be the name of an entry or an entry group. If an entry group, the tag will be attached to
    /// all entries in that group.
    /// </summary>
    [TerraformProperty("parent")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Parent { get; set; }

    /// <summary>
    /// The resource name of the tag template that this tag uses. Example:
    /// projects/{project_id}/locations/{location}/tagTemplates/{tagTemplateId}
    /// This field cannot be modified after creation.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Template is required")]
    [TerraformProperty("template")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Template { get; set; }

    /// <summary>
    /// Block for fields.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Fields is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Fields block(s) required")]
    [TerraformProperty("fields")]
    public required TerraformSet<GoogleDataCatalogTagFieldsBlock> Fields { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public GoogleDataCatalogTagTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The resource name of the tag in URL format. Example:
    /// projects/{project_id}/locations/{location}/entrygroups/{entryGroupId}/entries/{entryId}/tags/{tag_id} or
    /// projects/{project_id}/locations/{location}/entrygroups/{entryGroupId}/tags/{tag_id}
    /// where tag_id is a system-generated identifier. Note that this Tag may not actually be stored in the location in this name.
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Name { get; }

    /// <summary>
    /// The display name of the tag template.
    /// </summary>
    [TerraformProperty("template_displayname")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> TemplateDisplayname { get; }

}
