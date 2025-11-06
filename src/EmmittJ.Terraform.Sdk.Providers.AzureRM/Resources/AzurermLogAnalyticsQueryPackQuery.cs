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
    public string? AdditionalSettingsJson
    {
        get => GetProperty<TerraformLiteralProperty<string>>("additional_settings_json")?.Value;
        set => this.WithProperty("additional_settings_json", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The body attribute.
    /// </summary>
    public string? Body
    {
        get => GetProperty<TerraformLiteralProperty<string>>("body")?.Value;
        set => this.WithProperty("body", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The categories attribute.
    /// </summary>
    public List<string>? Categories
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("categories")?.Value;
        set => this.WithProperty("categories", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public string? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description")?.Value;
        set => this.WithProperty("description", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    public string? DisplayName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("display_name")?.Value;
        set => this.WithProperty("display_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The query_pack_id attribute.
    /// </summary>
    public string? QueryPackId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("query_pack_id")?.Value;
        set => this.WithProperty("query_pack_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The resource_types attribute.
    /// </summary>
    public List<string>? ResourceTypes
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("resource_types")?.Value;
        set => this.WithProperty("resource_types", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    /// <summary>
    /// The solutions attribute.
    /// </summary>
    public List<string>? Solutions
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("solutions")?.Value;
        set => this.WithProperty("solutions", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

}
