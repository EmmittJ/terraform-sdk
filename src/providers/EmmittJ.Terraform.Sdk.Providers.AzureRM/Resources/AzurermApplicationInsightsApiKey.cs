using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermApplicationInsightsApiKeyTimeoutsBlock : TerraformBlock
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

}

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
        this.WithOutput("api_key");
    }

    /// <summary>
    /// The application_insights_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApplicationInsightsId is required")]
    public required TerraformProperty<string> ApplicationInsightsId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("application_insights_id");
        set => this.WithProperty("application_insights_id", value);
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The read_permissions attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? ReadPermissions
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("read_permissions");
        set => this.WithProperty("read_permissions", value);
    }

    /// <summary>
    /// The write_permissions attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? WritePermissions
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("write_permissions");
        set => this.WithProperty("write_permissions", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermApplicationInsightsApiKeyTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermApplicationInsightsApiKeyTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The api_key attribute.
    /// </summary>
    public TerraformExpression ApiKey => this["api_key"];

}
