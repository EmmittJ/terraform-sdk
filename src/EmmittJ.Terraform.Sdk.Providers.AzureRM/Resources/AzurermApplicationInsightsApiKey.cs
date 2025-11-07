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
    public TerraformLiteralProperty<string>? ApplicationInsightsId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("application_insights_id");
        set => this.WithProperty("application_insights_id", value);
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
    /// The read_permissions attribute.
    /// </summary>
    public TerraformLiteralProperty<HashSet<string>>? ReadPermissions
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("read_permissions");
        set => this.WithProperty("read_permissions", value);
    }

    /// <summary>
    /// The write_permissions attribute.
    /// </summary>
    public TerraformLiteralProperty<HashSet<string>>? WritePermissions
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("write_permissions");
        set => this.WithProperty("write_permissions", value);
    }

    /// <summary>
    /// The api_key attribute.
    /// </summary>
    public TerraformExpression ApiKey => this["api_key"];

}
