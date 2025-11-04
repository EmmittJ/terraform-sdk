using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_application_insights_analytics_item resource.
/// </summary>
public class AzurermApplicationInsightsAnalyticsItem : TerraformResource
{
    public AzurermApplicationInsightsAnalyticsItem(string name) : base("azurerm_application_insights_analytics_item", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("time_created");
        this.DeclareOutput("time_modified");
        this.DeclareOutput("version");
    }

    /// <summary>
    /// The application_insights_id attribute.
    /// </summary>
    public string? ApplicationInsightsId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("application_insights_id")?.Value;
        set => this.WithProperty("application_insights_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The content attribute.
    /// </summary>
    public string? Content
    {
        get => GetProperty<TerraformLiteralProperty<string>>("content")?.Value;
        set => this.WithProperty("content", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The function_alias attribute.
    /// </summary>
    public string? FunctionAlias
    {
        get => GetProperty<TerraformLiteralProperty<string>>("function_alias")?.Value;
        set => this.WithProperty("function_alias", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The scope attribute.
    /// </summary>
    public string? Scope
    {
        get => GetProperty<TerraformLiteralProperty<string>>("scope")?.Value;
        set => this.WithProperty("scope", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public string? Type
    {
        get => GetProperty<TerraformLiteralProperty<string>>("type")?.Value;
        set => this.WithProperty("type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The time_created attribute.
    /// </summary>
    public TerraformExpression TimeCreated => this["time_created"];

    /// <summary>
    /// The time_modified attribute.
    /// </summary>
    public TerraformExpression TimeModified => this["time_modified"];

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformExpression Version => this["version"];

}
