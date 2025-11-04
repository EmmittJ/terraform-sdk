using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Retrieves information about a azurerm_api_management_api.
/// </summary>
public class AzurermApiManagementApiDataSource : TerraformDataSource
{
    public AzurermApiManagementApiDataSource(string name) : base("azurerm_api_management_api", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("description");
        this.DeclareOutput("display_name");
        this.DeclareOutput("is_current");
        this.DeclareOutput("is_online");
        this.DeclareOutput("path");
        this.DeclareOutput("protocols");
        this.DeclareOutput("service_url");
        this.DeclareOutput("soap_pass_through");
        this.DeclareOutput("subscription_key_parameter_names");
        this.DeclareOutput("subscription_required");
        this.DeclareOutput("version");
        this.DeclareOutput("version_set_id");
    }

    /// <summary>
    /// The api_management_name attribute.
    /// </summary>
    public string? ApiManagementName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("api_management_name")?.Value;
        set => this.WithProperty("api_management_name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The resource_group_name attribute.
    /// </summary>
    public string? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name")?.Value;
        set => this.WithProperty("resource_group_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The revision attribute.
    /// </summary>
    public string? Revision
    {
        get => GetProperty<TerraformLiteralProperty<string>>("revision")?.Value;
        set => this.WithProperty("revision", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformExpression Description => this["description"];

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    public TerraformExpression DisplayName => this["display_name"];

    /// <summary>
    /// The is_current attribute.
    /// </summary>
    public TerraformExpression IsCurrent => this["is_current"];

    /// <summary>
    /// The is_online attribute.
    /// </summary>
    public TerraformExpression IsOnline => this["is_online"];

    /// <summary>
    /// The path attribute.
    /// </summary>
    public TerraformExpression Path => this["path"];

    /// <summary>
    /// The protocols attribute.
    /// </summary>
    public TerraformExpression Protocols => this["protocols"];

    /// <summary>
    /// The service_url attribute.
    /// </summary>
    public TerraformExpression ServiceUrl => this["service_url"];

    /// <summary>
    /// The soap_pass_through attribute.
    /// </summary>
    public TerraformExpression SoapPassThrough => this["soap_pass_through"];

    /// <summary>
    /// The subscription_key_parameter_names attribute.
    /// </summary>
    public TerraformExpression SubscriptionKeyParameterNames => this["subscription_key_parameter_names"];

    /// <summary>
    /// The subscription_required attribute.
    /// </summary>
    public TerraformExpression SubscriptionRequired => this["subscription_required"];

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformExpression Version => this["version"];

    /// <summary>
    /// The version_set_id attribute.
    /// </summary>
    public TerraformExpression VersionSetId => this["version_set_id"];

}
