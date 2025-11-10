using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for fields in .
/// Nesting mode: set
/// </summary>
public class GoogleDataCatalogTagFieldsBlock : ITerraformBlock
{
    /// <summary>
    /// Holds the value for a tag field with boolean type.
    /// </summary>
    [TerraformPropertyName("bool_value")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? BoolValue { get; set; }

    /// <summary>
    /// The display name of this field
    /// </summary>
    [TerraformPropertyName("display_name")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DisplayName => new TerraformReferenceProperty<TerraformProperty<string>>("", "display_name");

    /// <summary>
    /// Holds the value for a tag field with double type.
    /// </summary>
    [TerraformPropertyName("double_value")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? DoubleValue { get; set; }

    /// <summary>
    /// The display name of the enum value.
    /// </summary>
    [TerraformPropertyName("enum_value")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? EnumValue { get; set; }

    /// <summary>
    /// The field_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FieldName is required")]
    [TerraformPropertyName("field_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> FieldName { get; set; }

    /// <summary>
    /// The order of this field with respect to other fields in this tag. For example, a higher value can indicate
    /// a more important field. The value can be negative. Multiple fields can have the same order, and field orders
    /// within a tag do not have to be sequential.
    /// </summary>
    [TerraformPropertyName("order")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> Order => new TerraformReferenceProperty<TerraformProperty<double>>("", "order");

    /// <summary>
    /// Holds the value for a tag field with string type.
    /// </summary>
    [TerraformPropertyName("string_value")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? StringValue { get; set; }

    /// <summary>
    /// Holds the value for a tag field with timestamp type.
    /// </summary>
    [TerraformPropertyName("timestamp_value")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? TimestampValue { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleDataCatalogTagTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

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
    public TerraformProperty<TerraformProperty<string>>? Column { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The name of the parent this tag is attached to. This can be the name of an entry or an entry group. If an entry group, the tag will be attached to
    /// all entries in that group.
    /// </summary>
    [TerraformPropertyName("parent")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Parent { get; set; }

    /// <summary>
    /// The resource name of the tag template that this tag uses. Example:
    /// projects/{project_id}/locations/{location}/tagTemplates/{tagTemplateId}
    /// This field cannot be modified after creation.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Template is required")]
    [TerraformPropertyName("template")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Template { get; set; }

    /// <summary>
    /// Block for fields.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Fields is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Fields block(s) required")]
    [TerraformPropertyName("fields")]
    public TerraformSet<TerraformBlock<GoogleDataCatalogTagFieldsBlock>>? Fields { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleDataCatalogTagTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The resource name of the tag in URL format. Example:
    /// projects/{project_id}/locations/{location}/entrygroups/{entryGroupId}/entries/{entryId}/tags/{tag_id} or
    /// projects/{project_id}/locations/{location}/entrygroups/{entryGroupId}/tags/{tag_id}
    /// where tag_id is a system-generated identifier. Note that this Tag may not actually be stored in the location in this name.
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Name => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name");

    /// <summary>
    /// The display name of the tag template.
    /// </summary>
    [TerraformPropertyName("template_displayname")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> TemplateDisplayname => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "template_displayname");

}
