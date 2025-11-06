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
    public List<string>? AllowedTenants
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("allowed_tenants")?.Value;
        set => this.WithProperty("allowed_tenants", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
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
    /// The client_id attribute.
    /// </summary>
    public string? ClientId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("client_id")?.Value;
        set => this.WithProperty("client_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The client_library attribute.
    /// </summary>
    public string? ClientLibrary
    {
        get => GetProperty<TerraformLiteralProperty<string>>("client_library")?.Value;
        set => this.WithProperty("client_library", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The client_secret attribute.
    /// </summary>
    public string? ClientSecret
    {
        get => GetProperty<TerraformLiteralProperty<string>>("client_secret")?.Value;
        set => this.WithProperty("client_secret", value == null ? null : new TerraformLiteralProperty<string>(value));
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

    /// <summary>
    /// The signin_tenant attribute.
    /// </summary>
    public string? SigninTenant
    {
        get => GetProperty<TerraformLiteralProperty<string>>("signin_tenant")?.Value;
        set => this.WithProperty("signin_tenant", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
