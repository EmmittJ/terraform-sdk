using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_api_management_identity_provider_aad resource.
/// </summary>
public class AzurermApiManagementIdentityProviderAad : TerraformResource
{
    public AzurermApiManagementIdentityProviderAad(string name) : base("azurerm_api_management_identity_provider_aad", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The allowed_tenants attribute.
    /// </summary>
    public TerraformProperty<List<string>>? AllowedTenants
    {
        get => GetProperty<TerraformProperty<List<string>>>("allowed_tenants");
        set => this.WithProperty("allowed_tenants", value);
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
    /// The client_id attribute.
    /// </summary>
    public TerraformProperty<string>? ClientId
    {
        get => GetProperty<TerraformProperty<string>>("client_id");
        set => this.WithProperty("client_id", value);
    }

    /// <summary>
    /// The client_library attribute.
    /// </summary>
    public TerraformProperty<string>? ClientLibrary
    {
        get => GetProperty<TerraformProperty<string>>("client_library");
        set => this.WithProperty("client_library", value);
    }

    /// <summary>
    /// The client_secret attribute.
    /// </summary>
    public TerraformProperty<string>? ClientSecret
    {
        get => GetProperty<TerraformProperty<string>>("client_secret");
        set => this.WithProperty("client_secret", value);
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

    /// <summary>
    /// The signin_tenant attribute.
    /// </summary>
    public TerraformProperty<string>? SigninTenant
    {
        get => GetProperty<TerraformProperty<string>>("signin_tenant");
        set => this.WithProperty("signin_tenant", value);
    }

}
