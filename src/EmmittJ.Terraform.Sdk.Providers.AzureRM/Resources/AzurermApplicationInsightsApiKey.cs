using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_application_insights_api_key resource.
/// </summary>
public class AzurermApplicationInsightsApiKey : TerraformResource
{
    public AzurermApplicationInsightsApiKey(string name) : base("azurerm_application_insights_api_key", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("api_key");
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
    /// The read_permissions attribute.
    /// </summary>
    public HashSet<string>? ReadPermissions
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("read_permissions")?.Value;
        set => this.WithProperty("read_permissions", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The write_permissions attribute.
    /// </summary>
    public HashSet<string>? WritePermissions
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("write_permissions")?.Value;
        set => this.WithProperty("write_permissions", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The api_key attribute.
    /// </summary>
    public TerraformExpression ApiKey => this["api_key"];

}
