using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

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
    public TerraformLiteralProperty<string>? AdditionalSettingsJson
    {
        get => GetProperty<TerraformLiteralProperty<string>>("additional_settings_json");
        set => this.WithProperty("additional_settings_json", value);
    }

    /// <summary>
    /// The body attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Body
    {
        get => GetProperty<TerraformLiteralProperty<string>>("body");
        set => this.WithProperty("body", value);
    }

    /// <summary>
    /// The categories attribute.
    /// </summary>
    public TerraformLiteralProperty<List<string>>? Categories
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("categories");
        set => this.WithProperty("categories", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? DisplayName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("display_name");
        set => this.WithProperty("display_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The query_pack_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? QueryPackId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("query_pack_id");
        set => this.WithProperty("query_pack_id", value);
    }

    /// <summary>
    /// The resource_types attribute.
    /// </summary>
    public TerraformLiteralProperty<List<string>>? ResourceTypes
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("resource_types");
        set => this.WithProperty("resource_types", value);
    }

    /// <summary>
    /// The solutions attribute.
    /// </summary>
    public TerraformLiteralProperty<List<string>>? Solutions
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("solutions");
        set => this.WithProperty("solutions", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

}
