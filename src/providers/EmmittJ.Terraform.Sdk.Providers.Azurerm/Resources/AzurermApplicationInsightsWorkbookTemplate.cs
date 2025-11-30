using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for galleries in AzurermApplicationInsightsWorkbookTemplate.
/// Nesting mode: list
/// </summary>
public class AzurermApplicationInsightsWorkbookTemplateGalleriesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "galleries";

    /// <summary>
    /// The category attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Category is required")]
    public required TerraformValue<string> Category
    {
        get => new TerraformReference<string>(this, "category");
        set => SetArgument("category", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The order attribute.
    /// </summary>
    public TerraformValue<double>? Order
    {
        get => new TerraformReference<double>(this, "order");
        set => SetArgument("order", value);
    }

    /// <summary>
    /// The resource_type attribute.
    /// </summary>
    public TerraformValue<string>? ResourceTypeAttribute
    {
        get => new TerraformReference<string>(this, "resource_type");
        set => SetArgument("resource_type", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformValue<string>? Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermApplicationInsightsWorkbookTemplate.
/// Nesting mode: single
/// </summary>
public class AzurermApplicationInsightsWorkbookTemplateTimeoutsBlock : TerraformBlock
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
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
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
/// Represents a azurerm_application_insights_workbook_template Terraform resource.
/// Manages a azurerm_application_insights_workbook_template resource.
/// </summary>
public partial class AzurermApplicationInsightsWorkbookTemplate(string name) : TerraformResource("azurerm_application_insights_workbook_template", name)
{
    /// <summary>
    /// The author attribute.
    /// </summary>
    public TerraformValue<string>? Author
    {
        get => new TerraformReference<string>(this, "author");
        set => SetArgument("author", value);
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
    /// The localized attribute.
    /// </summary>
    public TerraformValue<string>? Localized
    {
        get => new TerraformReference<string>(this, "localized");
        set => SetArgument("localized", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The priority attribute.
    /// </summary>
    public TerraformValue<double>? Priority
    {
        get => new TerraformReference<double>(this, "priority");
        set => SetArgument("priority", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The template_data attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TemplateData is required")]
    public required TerraformValue<string> TemplateData
    {
        get => new TerraformReference<string>(this, "template_data");
        set => SetArgument("template_data", value);
    }

    /// <summary>
    /// Galleries block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Galleries is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Galleries block(s) required")]
    public required TerraformList<AzurermApplicationInsightsWorkbookTemplateGalleriesBlock> Galleries
    {
        get => GetRequiredArgument<TerraformList<AzurermApplicationInsightsWorkbookTemplateGalleriesBlock>>("galleries");
        set => SetArgument("galleries", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermApplicationInsightsWorkbookTemplateTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermApplicationInsightsWorkbookTemplateTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
