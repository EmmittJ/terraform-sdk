using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for fields in GoogleDataCatalogTagTemplate.
/// Nesting mode: set
/// </summary>
public class GoogleDataCatalogTagTemplateFieldsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "fields";

    /// <summary>
    /// A description for this field.
    /// </summary>
    public TerraformValue<string> Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The display name for this field.
    /// </summary>
    public TerraformValue<string> DisplayName
    {
        get => new TerraformReference<string>(this, "display_name");
        set => SetArgument("display_name", value);
    }

    /// <summary>
    /// The field_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FieldId is required")]
    public required TerraformValue<string> FieldId
    {
        get => new TerraformReference<string>(this, "field_id");
        set => SetArgument("field_id", value);
    }

    /// <summary>
    /// Whether this is a required field. Defaults to false.
    /// </summary>
    public TerraformValue<bool> IsRequired
    {
        get => new TerraformReference<bool>(this, "is_required");
        set => SetArgument("is_required", value);
    }

    /// <summary>
    /// The resource name of the tag template field in URL format. Example: projects/{project_id}/locations/{location}/tagTemplates/{tagTemplateId}/fields/{field}
    /// </summary>
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
    }

    /// <summary>
    /// The order of this field with respect to other fields in this tag template.
    /// A higher value indicates a more important field. The value can be negative.
    /// Multiple fields can have the same order, and field orders within a tag do not have to be sequential.
    /// </summary>
    public TerraformValue<double> Order
    {
        get => new TerraformReference<double>(this, "order");
        set => SetArgument("order", value);
    }

    /// <summary>
    /// Type block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Type block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Type block(s) allowed")]
    public required TerraformList<GoogleDataCatalogTagTemplateFieldsBlockTypeBlock> Type
    {
        get => GetRequiredArgument<TerraformList<GoogleDataCatalogTagTemplateFieldsBlockTypeBlock>>("type");
        set => SetArgument("type", value);
    }

}

/// <summary>
/// Block type for type in GoogleDataCatalogTagTemplateFieldsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataCatalogTagTemplateFieldsBlockTypeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "type";

    /// <summary>
    /// Represents primitive types - string, bool etc.
    ///  Exactly one of &#39;primitive_type&#39; or &#39;enum_type&#39; must be set Possible values: [&amp;quot;DOUBLE&amp;quot;, &amp;quot;STRING&amp;quot;, &amp;quot;BOOL&amp;quot;, &amp;quot;TIMESTAMP&amp;quot;]
    /// </summary>
    public TerraformValue<string> PrimitiveType
    {
        get => new TerraformReference<string>(this, "primitive_type");
        set => SetArgument("primitive_type", value);
    }

    /// <summary>
    /// EnumType block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EnumType block(s) allowed")]
    public TerraformList<GoogleDataCatalogTagTemplateFieldsBlockTypeBlockEnumTypeBlock>? EnumType
    {
        get => GetArgument<TerraformList<GoogleDataCatalogTagTemplateFieldsBlockTypeBlockEnumTypeBlock>>("enum_type");
        set => SetArgument("enum_type", value);
    }

}

/// <summary>
/// Block type for enum_type in GoogleDataCatalogTagTemplateFieldsBlockTypeBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataCatalogTagTemplateFieldsBlockTypeBlockEnumTypeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "enum_type";

    /// <summary>
    /// AllowedValues block (nesting mode: set).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AllowedValues is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 AllowedValues block(s) required")]
    public required TerraformSet<GoogleDataCatalogTagTemplateFieldsBlockTypeBlockEnumTypeBlockAllowedValuesBlock> AllowedValues
    {
        get => GetRequiredArgument<TerraformSet<GoogleDataCatalogTagTemplateFieldsBlockTypeBlockEnumTypeBlockAllowedValuesBlock>>("allowed_values");
        set => SetArgument("allowed_values", value);
    }

}

/// <summary>
/// Block type for allowed_values in GoogleDataCatalogTagTemplateFieldsBlockTypeBlockEnumTypeBlock.
/// Nesting mode: set
/// </summary>
public class GoogleDataCatalogTagTemplateFieldsBlockTypeBlockEnumTypeBlockAllowedValuesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "allowed_values";

    /// <summary>
    /// The display name of the enum value.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformValue<string> DisplayName
    {
        get => new TerraformReference<string>(this, "display_name");
        set => SetArgument("display_name", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleDataCatalogTagTemplate.
/// Nesting mode: single
/// </summary>
public class GoogleDataCatalogTagTemplateTimeoutsBlock : TerraformBlock
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
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a google_data_catalog_tag_template Terraform resource.
/// Manages a google_data_catalog_tag_template resource.
/// </summary>
[Obsolete("This resource is deprecated.")]
public partial class GoogleDataCatalogTagTemplate(string name) : TerraformResource("google_data_catalog_tag_template", name)
{
    /// <summary>
    /// The display name for this template.
    /// </summary>
    public TerraformValue<string>? DisplayName
    {
        get => new TerraformReference<string>(this, "display_name");
        set => SetArgument("display_name", value);
    }

    /// <summary>
    /// This confirms the deletion of any possible tags using this template. Must be set to true in order to delete the tag template.
    /// </summary>
    public TerraformValue<bool>? ForceDelete
    {
        get => new TerraformReference<bool>(this, "force_delete");
        set => SetArgument("force_delete", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => new TerraformReference<string>(this, "project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// Template location region.
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The id of the tag template to create.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TagTemplateId is required")]
    public required TerraformValue<string> TagTemplateId
    {
        get => new TerraformReference<string>(this, "tag_template_id");
        set => SetArgument("tag_template_id", value);
    }

    /// <summary>
    /// The resource name of the tag template in URL format. Example: projects/{project_id}/locations/{location}/tagTemplates/{tagTemplateId}
    /// </summary>
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
    }

    /// <summary>
    /// Fields block (nesting mode: set).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Fields is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Fields block(s) required")]
    public required TerraformSet<GoogleDataCatalogTagTemplateFieldsBlock> Fields
    {
        get => GetRequiredArgument<TerraformSet<GoogleDataCatalogTagTemplateFieldsBlock>>("fields");
        set => SetArgument("fields", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleDataCatalogTagTemplateTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleDataCatalogTagTemplateTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
