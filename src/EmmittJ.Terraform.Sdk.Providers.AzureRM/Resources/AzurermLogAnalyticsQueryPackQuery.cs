using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermLogAnalyticsQueryPackQueryTimeoutsBlock : TerraformBlock
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
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
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
/// Manages a azurerm_log_analytics_query_pack_query resource.
/// </summary>
public class AzurermLogAnalyticsQueryPackQuery : TerraformResource
{
    public AzurermLogAnalyticsQueryPackQuery(string name) : base("azurerm_log_analytics_query_pack_query", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The additional_settings_json attribute.
    /// </summary>
    public TerraformProperty<string>? AdditionalSettingsJson
    {
        get => GetProperty<TerraformProperty<string>>("additional_settings_json");
        set => this.WithProperty("additional_settings_json", value);
    }

    /// <summary>
    /// The body attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Body is required")]
    public required TerraformProperty<string> Body
    {
        get => GetProperty<TerraformProperty<string>>("body");
        set => this.WithProperty("body", value);
    }

    /// <summary>
    /// The categories attribute.
    /// </summary>
    public List<TerraformProperty<string>>? Categories
    {
        get => GetProperty<List<TerraformProperty<string>>>("categories");
        set => this.WithProperty("categories", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformProperty<string> DisplayName
    {
        get => GetProperty<TerraformProperty<string>>("display_name");
        set => this.WithProperty("display_name", value);
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
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The query_pack_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "QueryPackId is required")]
    public required TerraformProperty<string> QueryPackId
    {
        get => GetProperty<TerraformProperty<string>>("query_pack_id");
        set => this.WithProperty("query_pack_id", value);
    }

    /// <summary>
    /// The resource_types attribute.
    /// </summary>
    public List<TerraformProperty<string>>? ResourceTypes
    {
        get => GetProperty<List<TerraformProperty<string>>>("resource_types");
        set => this.WithProperty("resource_types", value);
    }

    /// <summary>
    /// The solutions attribute.
    /// </summary>
    public List<TerraformProperty<string>>? Solutions
    {
        get => GetProperty<List<TerraformProperty<string>>>("solutions");
        set => this.WithProperty("solutions", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermLogAnalyticsQueryPackQueryTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermLogAnalyticsQueryPackQueryTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
