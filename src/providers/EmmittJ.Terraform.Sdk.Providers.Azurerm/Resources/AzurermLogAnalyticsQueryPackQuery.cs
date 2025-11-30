using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermLogAnalyticsQueryPackQuery.
/// Nesting mode: single
/// </summary>
public class AzurermLogAnalyticsQueryPackQueryTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_log_analytics_query_pack_query Terraform resource.
/// Manages a azurerm_log_analytics_query_pack_query resource.
/// </summary>
public partial class AzurermLogAnalyticsQueryPackQuery(string name) : TerraformResource("azurerm_log_analytics_query_pack_query", name)
{
    /// <summary>
    /// The additional_settings_json attribute.
    /// </summary>
    public TerraformValue<string>? AdditionalSettingsJson
    {
        get => new TerraformReference<string>(this, "additional_settings_json");
        set => SetArgument("additional_settings_json", value);
    }

    /// <summary>
    /// The body attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Body is required")]
    public required TerraformValue<string> Body
    {
        get => new TerraformReference<string>(this, "body");
        set => SetArgument("body", value);
    }

    /// <summary>
    /// The categories attribute.
    /// </summary>
    public TerraformList<string>? Categories
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "categories").ResolveNodes(ctx));
        set => SetArgument("categories", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformValue<string> DisplayName
    {
        get => new TerraformReference<string>(this, "display_name");
        set => SetArgument("display_name", value);
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
    /// The name attribute.
    /// </summary>
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The query_pack_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "QueryPackId is required")]
    public required TerraformValue<string> QueryPackId
    {
        get => new TerraformReference<string>(this, "query_pack_id");
        set => SetArgument("query_pack_id", value);
    }

    /// <summary>
    /// The resource_types attribute.
    /// </summary>
    public TerraformList<string>? ResourceTypes
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "resource_types").ResolveNodes(ctx));
        set => SetArgument("resource_types", value);
    }

    /// <summary>
    /// The solutions attribute.
    /// </summary>
    public TerraformList<string>? Solutions
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "solutions").ResolveNodes(ctx));
        set => SetArgument("solutions", value);
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
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermLogAnalyticsQueryPackQueryTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermLogAnalyticsQueryPackQueryTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
