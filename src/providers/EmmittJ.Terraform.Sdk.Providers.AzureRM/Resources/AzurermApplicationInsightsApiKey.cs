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
        SetOutput("api_key");
        SetOutput("application_insights_id");
        SetOutput("id");
        SetOutput("name");
        SetOutput("read_permissions");
        SetOutput("write_permissions");
    }

    /// <summary>
    /// The application_insights_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApplicationInsightsId is required")]
    public required TerraformProperty<string> ApplicationInsightsId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("application_insights_id");
        set => SetProperty("application_insights_id", value);
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The read_permissions attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> ReadPermissions
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("read_permissions");
        set => SetProperty("read_permissions", value);
    }

    /// <summary>
    /// The write_permissions attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> WritePermissions
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("write_permissions");
        set => SetProperty("write_permissions", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermApplicationInsightsApiKeyTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The api_key attribute.
    /// </summary>
    public TerraformExpression ApiKey => this["api_key"];

}
