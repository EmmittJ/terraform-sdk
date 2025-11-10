using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermApiManagementSubscriptionDataSourceTimeoutsBlock : TerraformBlock
{
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
/// Retrieves information about a azurerm_api_management_subscription.
/// </summary>
public class AzurermApiManagementSubscriptionDataSource : TerraformDataSource
{
    public AzurermApiManagementSubscriptionDataSource(string name) : base("azurerm_api_management_subscription", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("allow_tracing");
        this.DeclareOutput("api_id");
        this.DeclareOutput("display_name");
        this.DeclareOutput("primary_key");
        this.DeclareOutput("product_id");
        this.DeclareOutput("secondary_key");
        this.DeclareOutput("state");
        this.DeclareOutput("user_id");
    }

    /// <summary>
    /// The api_management_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApiManagementId is required")]
    public required TerraformProperty<string> ApiManagementId
    {
        get => GetProperty<TerraformProperty<string>>("api_management_id");
        set => this.WithProperty("api_management_id", value);
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
    /// The subscription_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubscriptionId is required")]
    public required TerraformProperty<string> SubscriptionId
    {
        get => GetProperty<TerraformProperty<string>>("subscription_id");
        set => this.WithProperty("subscription_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermApiManagementSubscriptionDataSourceTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermApiManagementSubscriptionDataSourceTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The allow_tracing attribute.
    /// </summary>
    public TerraformExpression AllowTracing => this["allow_tracing"];

    /// <summary>
    /// The api_id attribute.
    /// </summary>
    public TerraformExpression ApiId => this["api_id"];

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    public TerraformExpression DisplayName => this["display_name"];

    /// <summary>
    /// The primary_key attribute.
    /// </summary>
    public TerraformExpression PrimaryKey => this["primary_key"];

    /// <summary>
    /// The product_id attribute.
    /// </summary>
    public TerraformExpression ProductId => this["product_id"];

    /// <summary>
    /// The secondary_key attribute.
    /// </summary>
    public TerraformExpression SecondaryKey => this["secondary_key"];

    /// <summary>
    /// The state attribute.
    /// </summary>
    public TerraformExpression State => this["state"];

    /// <summary>
    /// The user_id attribute.
    /// </summary>
    public TerraformExpression UserId => this["user_id"];

}
