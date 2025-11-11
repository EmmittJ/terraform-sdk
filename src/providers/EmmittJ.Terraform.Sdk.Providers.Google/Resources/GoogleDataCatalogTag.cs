using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for fields in .
/// Nesting mode: set
/// </summary>
public class GoogleDataCatalogTagFieldsBlock
{
    /// <summary>
    /// Holds the value for a tag field with boolean type.
    /// </summary>
    [TerraformPropertyName("bool_value")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? BoolValue { get; set; }


    /// <summary>
    /// Holds the value for a tag field with double type.
    /// </summary>
    [TerraformPropertyName("double_value")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? DoubleValue { get; set; }

    /// <summary>
    /// The display name of the enum value.
    /// </summary>
    [TerraformPropertyName("enum_value")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? EnumValue { get; set; }

    /// <summary>
    /// The field_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FieldName is required")]
    [TerraformPropertyName("field_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> FieldName { get; set; }


    /// <summary>
    /// Holds the value for a tag field with string type.
    /// </summary>
    [TerraformPropertyName("string_value")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? StringValue { get; set; }

    /// <summary>
    /// Holds the value for a tag field with timestamp type.
    /// </summary>
    [TerraformPropertyName("timestamp_value")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? TimestampValue { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleDataCatalogTagTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_data_catalog_tag resource.
/// </summary>
[Obsolete("This resource is deprecated.")]
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleDataCatalogTag : TerraformResource
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
    [TerraformPropertyName("column")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Column { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The name of the parent this tag is attached to. This can be the name of an entry or an entry group. If an entry group, the tag will be attached to
    /// all entries in that group.
    /// </summary>
    [TerraformPropertyName("parent")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Parent { get; set; }

    /// <summary>
    /// The resource name of the tag template that this tag uses. Example:
    /// projects/{project_id}/locations/{location}/tagTemplates/{tagTemplateId}
    /// This field cannot be modified after creation.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Template is required")]
    [TerraformPropertyName("template")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Template { get; set; }

    /// <summary>
    /// Block for fields.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Fields is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Fields block(s) required")]
    [TerraformPropertyName("fields")]
    public TerraformSet<TerraformBlock<GoogleDataCatalogTagFieldsBlock>>? Fields { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleDataCatalogTagTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The resource name of the tag in URL format. Example:
    /// projects/{project_id}/locations/{location}/entrygroups/{entryGroupId}/entries/{entryId}/tags/{tag_id} or
    /// projects/{project_id}/locations/{location}/entrygroups/{entryGroupId}/tags/{tag_id}
    /// where tag_id is a system-generated identifier. Note that this Tag may not actually be stored in the location in this name.
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Name => new TerraformReference(this, "name");

    /// <summary>
    /// The display name of the tag template.
    /// </summary>
    [TerraformPropertyName("template_displayname")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> TemplateDisplayname => new TerraformReference(this, "template_displayname");

}
