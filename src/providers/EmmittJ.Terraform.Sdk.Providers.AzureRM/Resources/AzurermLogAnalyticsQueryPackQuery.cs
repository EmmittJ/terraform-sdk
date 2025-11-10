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
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
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
        SetOutput("additional_settings_json");
        SetOutput("body");
        SetOutput("categories");
        SetOutput("description");
        SetOutput("display_name");
        SetOutput("id");
        SetOutput("name");
        SetOutput("query_pack_id");
        SetOutput("resource_types");
        SetOutput("solutions");
        SetOutput("tags");
    }

    /// <summary>
    /// The additional_settings_json attribute.
    /// </summary>
    public TerraformProperty<string> AdditionalSettingsJson
    {
        get => GetRequiredOutput<TerraformProperty<string>>("additional_settings_json");
        set => SetProperty("additional_settings_json", value);
    }

    /// <summary>
    /// The body attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Body is required")]
    public required TerraformProperty<string> Body
    {
        get => GetRequiredOutput<TerraformProperty<string>>("body");
        set => SetProperty("body", value);
    }

    /// <summary>
    /// The categories attribute.
    /// </summary>
    public List<TerraformProperty<string>> Categories
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("categories");
        set => SetProperty("categories", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformProperty<string> DisplayName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("display_name");
        set => SetProperty("display_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The query_pack_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "QueryPackId is required")]
    public required TerraformProperty<string> QueryPackId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("query_pack_id");
        set => SetProperty("query_pack_id", value);
    }

    /// <summary>
    /// The resource_types attribute.
    /// </summary>
    public List<TerraformProperty<string>> ResourceTypes
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("resource_types");
        set => SetProperty("resource_types", value);
    }

    /// <summary>
    /// The solutions attribute.
    /// </summary>
    public List<TerraformProperty<string>> Solutions
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("solutions");
        set => SetProperty("solutions", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermLogAnalyticsQueryPackQueryTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
