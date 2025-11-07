using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_api_management_identity_provider_twitter resource.
/// </summary>
public class AzurermApiManagementIdentityProviderTwitter : TerraformResource
{
    public AzurermApiManagementIdentityProviderTwitter(string name) : base("azurerm_api_management_identity_provider_twitter", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The api_key attribute.
    /// </summary>
    public TerraformProperty<string>? ApiKey
    {
        get => GetProperty<TerraformProperty<string>>("api_key");
        set => this.WithProperty("api_key", value);
    }

    /// <summary>
    /// The api_management_name attribute.
    /// </summary>
    public TerraformProperty<string>? ApiManagementName
    {
        get => GetProperty<TerraformProperty<string>>("api_management_name");
        set => this.WithProperty("api_management_name", value);
    }

    /// <summary>
    /// The api_secret_key attribute.
    /// </summary>
    public TerraformProperty<string>? ApiSecretKey
    {
        get => GetProperty<TerraformProperty<string>>("api_secret_key");
        set => this.WithProperty("api_secret_key", value);
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
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformProperty<string>? ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

}
