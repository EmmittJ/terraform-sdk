using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for fields in .
/// Nesting mode: set
/// </summary>
public class GoogleDataCatalogTagFieldsBlock : TerraformBlock
{
    /// <summary>
    /// Holds the value for a tag field with boolean type.
    /// </summary>
    public TerraformProperty<bool>? BoolValue
    {
        get => GetProperty<TerraformProperty<bool>>("bool_value");
        set => WithProperty("bool_value", value);
    }

    /// <summary>
    /// The display name of this field
    /// </summary>
    public TerraformProperty<string>? DisplayName
    {
        get => GetProperty<TerraformProperty<string>>("display_name");
        set => WithProperty("display_name", value);
    }

    /// <summary>
    /// Holds the value for a tag field with double type.
    /// </summary>
    public TerraformProperty<double>? DoubleValue
    {
        get => GetProperty<TerraformProperty<double>>("double_value");
        set => WithProperty("double_value", value);
    }

    /// <summary>
    /// The display name of the enum value.
    /// </summary>
    public TerraformProperty<string>? EnumValue
    {
        get => GetProperty<TerraformProperty<string>>("enum_value");
        set => WithProperty("enum_value", value);
    }

    /// <summary>
    /// The field_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FieldName is required")]
    public required TerraformProperty<string> FieldName
    {
        get => GetProperty<TerraformProperty<string>>("field_name");
        set => WithProperty("field_name", value);
    }

    /// <summary>
    /// The order of this field with respect to other fields in this tag. For example, a higher value can indicate
    /// a more important field. The value can be negative. Multiple fields can have the same order, and field orders
    /// within a tag do not have to be sequential.
    /// </summary>
    public TerraformProperty<double>? Order
    {
        get => GetProperty<TerraformProperty<double>>("order");
        set => WithProperty("order", value);
    }

    /// <summary>
    /// Holds the value for a tag field with string type.
    /// </summary>
    public TerraformProperty<string>? StringValue
    {
        get => GetProperty<TerraformProperty<string>>("string_value");
        set => WithProperty("string_value", value);
    }

    /// <summary>
    /// Holds the value for a tag field with timestamp type.
    /// </summary>
    public TerraformProperty<string>? TimestampValue
    {
        get => GetProperty<TerraformProperty<string>>("timestamp_value");
        set => WithProperty("timestamp_value", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleDataCatalogTagTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

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
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("name");
        this.DeclareOutput("template_displayname");
    }

    /// <summary>
    /// Resources like Entry can have schemas associated with them. This scope allows users to attach tags to an
    /// individual column based on that schema.
    /// 
    /// For attaching a tag to a nested column, use &#39;.&#39; to separate the column names. Example:
    /// &#39;outer_column.inner_column&#39;
    /// </summary>
    public TerraformProperty<string>? Column
    {
        get => GetProperty<TerraformProperty<string>>("column");
        set => this.WithProperty("column", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The name of the parent this tag is attached to. This can be the name of an entry or an entry group. If an entry group, the tag will be attached to
    /// all entries in that group.
    /// </summary>
    public TerraformProperty<string>? Parent
    {
        get => GetProperty<TerraformProperty<string>>("parent");
        set => this.WithProperty("parent", value);
    }

    /// <summary>
    /// The resource name of the tag template that this tag uses. Example:
    /// projects/{project_id}/locations/{location}/tagTemplates/{tagTemplateId}
    /// This field cannot be modified after creation.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Template is required")]
    public required TerraformProperty<string> Template
    {
        get => GetProperty<TerraformProperty<string>>("template");
        set => this.WithProperty("template", value);
    }

    /// <summary>
    /// Block for fields.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Fields block(s) required")]
    public HashSet<GoogleDataCatalogTagFieldsBlock>? Fields
    {
        get => GetProperty<HashSet<GoogleDataCatalogTagFieldsBlock>>("fields");
        set => this.WithProperty("fields", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleDataCatalogTagTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleDataCatalogTagTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The resource name of the tag in URL format. Example:
    /// projects/{project_id}/locations/{location}/entrygroups/{entryGroupId}/entries/{entryId}/tags/{tag_id} or
    /// projects/{project_id}/locations/{location}/entrygroups/{entryGroupId}/tags/{tag_id}
    /// where tag_id is a system-generated identifier. Note that this Tag may not actually be stored in the location in this name.
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// The display name of the tag template.
    /// </summary>
    public TerraformExpression TemplateDisplayname => this["template_displayname"];

}
