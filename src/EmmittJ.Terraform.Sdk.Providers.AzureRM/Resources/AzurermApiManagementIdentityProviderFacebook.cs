using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_api_management_identity_provider_facebook resource.
/// </summary>
public class AzurermApiManagementIdentityProviderFacebook : TerraformResource
{
    public AzurermApiManagementIdentityProviderFacebook(string name) : base("azurerm_api_management_identity_provider_facebook", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
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
    /// The app_id attribute.
    /// </summary>
    public string? AppId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("app_id")?.Value;
        set => this.WithProperty("app_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The app_secret attribute.
    /// </summary>
    public string? AppSecret
    {
        get => GetProperty<TerraformLiteralProperty<string>>("app_secret")?.Value;
        set => this.WithProperty("app_secret", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The resource_group_name attribute.
    /// </summary>
    public string? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name")?.Value;
        set => this.WithProperty("resource_group_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
