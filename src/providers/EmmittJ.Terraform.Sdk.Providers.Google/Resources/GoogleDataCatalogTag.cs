using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for fields in GoogleDataCatalogTag.
/// Nesting mode: set
/// </summary>
public class GoogleDataCatalogTagFieldsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "fields";

    /// <summary>
    /// Holds the value for a tag field with boolean type.
    /// </summary>
    public TerraformValue<bool>? BoolValue
    {
        get => GetArgument<TerraformValue<bool>>("bool_value");
        set => SetArgument("bool_value", value);
    }

    /// <summary>
    /// The display name of this field
    /// </summary>
    public TerraformValue<string> DisplayName
        => AsReference("display_name");

    /// <summary>
    /// Holds the value for a tag field with double type.
    /// </summary>
    public TerraformValue<double>? DoubleValue
    {
        get => GetArgument<TerraformValue<double>>("double_value");
        set => SetArgument("double_value", value);
    }

    /// <summary>
    /// The display name of the enum value.
    /// </summary>
    public TerraformValue<string>? EnumValue
    {
        get => GetArgument<TerraformValue<string>>("enum_value");
        set => SetArgument("enum_value", value);
    }

    /// <summary>
    /// The field_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FieldName is required")]
    public required TerraformValue<string> FieldName
    {
        get => GetRequiredArgument<TerraformValue<string>>("field_name");
        set => SetArgument("field_name", value);
    }

    /// <summary>
    /// The order of this field with respect to other fields in this tag. For example, a higher value can indicate
    /// a more important field. The value can be negative. Multiple fields can have the same order, and field orders
    /// within a tag do not have to be sequential.
    /// </summary>
    public TerraformValue<double> Order
        => AsReference("order");

    /// <summary>
    /// Holds the value for a tag field with string type.
    /// </summary>
    public TerraformValue<string>? StringValue
    {
        get => GetArgument<TerraformValue<string>>("string_value");
        set => SetArgument("string_value", value);
    }

    /// <summary>
    /// Holds the value for a tag field with timestamp type.
    /// </summary>
    public TerraformValue<string>? TimestampValue
    {
        get => GetArgument<TerraformValue<string>>("timestamp_value");
        set => SetArgument("timestamp_value", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleDataCatalogTag.
/// Nesting mode: single
/// </summary>
public class GoogleDataCatalogTagTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a google_data_catalog_tag Terraform resource.
/// Manages a google_data_catalog_tag resource.
/// </summary>
[Obsolete("This resource is deprecated.")]
public partial class GoogleDataCatalogTag(string name) : TerraformResource("google_data_catalog_tag", name)
{
    /// <summary>
    /// Resources like Entry can have schemas associated with them. This scope allows users to attach tags to an
    /// individual column based on that schema.
    /// 
    /// For attaching a tag to a nested column, use &#39;.&#39; to separate the column names. Example:
    /// &#39;outer_column.inner_column&#39;
    /// </summary>
    public TerraformValue<string>? Column
    {
        get => GetArgument<TerraformValue<string>>("column");
        set => SetArgument("column", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name of the parent this tag is attached to. This can be the name of an entry or an entry group. If an entry group, the tag will be attached to
    /// all entries in that group.
    /// </summary>
    public TerraformValue<string>? Parent
    {
        get => GetArgument<TerraformValue<string>>("parent");
        set => SetArgument("parent", value);
    }

    /// <summary>
    /// The resource name of the tag template that this tag uses. Example:
    /// projects/{project_id}/locations/{location}/tagTemplates/{tagTemplateId}
    /// This field cannot be modified after creation.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Template is required")]
    public required TerraformValue<string> Template
    {
        get => GetRequiredArgument<TerraformValue<string>>("template");
        set => SetArgument("template", value);
    }

    /// <summary>
    /// The resource name of the tag in URL format. Example:
    /// projects/{project_id}/locations/{location}/entrygroups/{entryGroupId}/entries/{entryId}/tags/{tag_id} or
    /// projects/{project_id}/locations/{location}/entrygroups/{entryGroupId}/tags/{tag_id}
    /// where tag_id is a system-generated identifier. Note that this Tag may not actually be stored in the location in this name.
    /// </summary>
    public TerraformValue<string> Name
        => AsReference("name");

    /// <summary>
    /// The display name of the tag template.
    /// </summary>
    public TerraformValue<string> TemplateDisplayname
        => AsReference("template_displayname");

    /// <summary>
    /// Fields block (nesting mode: set).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Fields is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Fields block(s) required")]
    public required TerraformSet<GoogleDataCatalogTagFieldsBlock> Fields
    {
        get => GetRequiredArgument<TerraformSet<GoogleDataCatalogTagFieldsBlock>>("fields");
        set => SetArgument("fields", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleDataCatalogTagTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleDataCatalogTagTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
