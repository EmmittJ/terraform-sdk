using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_static_web_app_function_app_registration resource.
/// </summary>
public class AzurermStaticWebAppFunctionAppRegistration : TerraformResource
{
    public AzurermStaticWebAppFunctionAppRegistration(string name) : base("azurerm_static_web_app_function_app_registration", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The function_app_id attribute.
    /// </summary>
    public string? FunctionAppId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("function_app_id")?.Value;
        set => this.WithProperty("function_app_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The static_web_app_id attribute.
    /// </summary>
    public string? StaticWebAppId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("static_web_app_id")?.Value;
        set => this.WithProperty("static_web_app_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
