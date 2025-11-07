using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_api_management_identity_provider_aadb2c resource.
/// </summary>
public class AzurermApiManagementIdentityProviderAadb2c : TerraformResource
{
    public AzurermApiManagementIdentityProviderAadb2c(string name) : base("azurerm_api_management_identity_provider_aadb2c", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The allowed_tenant attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? AllowedTenant
    {
        get => GetProperty<TerraformLiteralProperty<string>>("allowed_tenant");
        set => this.WithProperty("allowed_tenant", value);
    }

    /// <summary>
    /// The api_management_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ApiManagementName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("api_management_name");
        set => this.WithProperty("api_management_name", value);
    }

    /// <summary>
    /// The authority attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Authority
    {
        get => GetProperty<TerraformLiteralProperty<string>>("authority");
        set => this.WithProperty("authority", value);
    }

    /// <summary>
    /// The client_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ClientId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("client_id");
        set => this.WithProperty("client_id", value);
    }

    /// <summary>
    /// The client_library attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ClientLibrary
    {
        get => GetProperty<TerraformLiteralProperty<string>>("client_library");
        set => this.WithProperty("client_library", value);
    }

    /// <summary>
    /// The client_secret attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ClientSecret
    {
        get => GetProperty<TerraformLiteralProperty<string>>("client_secret");
        set => this.WithProperty("client_secret", value);
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
    /// The password_reset_policy attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? PasswordResetPolicy
    {
        get => GetProperty<TerraformLiteralProperty<string>>("password_reset_policy");
        set => this.WithProperty("password_reset_policy", value);
    }

    /// <summary>
    /// The profile_editing_policy attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ProfileEditingPolicy
    {
        get => GetProperty<TerraformLiteralProperty<string>>("profile_editing_policy");
        set => this.WithProperty("profile_editing_policy", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The signin_policy attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SigninPolicy
    {
        get => GetProperty<TerraformLiteralProperty<string>>("signin_policy");
        set => this.WithProperty("signin_policy", value);
    }

    /// <summary>
    /// The signin_tenant attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SigninTenant
    {
        get => GetProperty<TerraformLiteralProperty<string>>("signin_tenant");
        set => this.WithProperty("signin_tenant", value);
    }

    /// <summary>
    /// The signup_policy attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SignupPolicy
    {
        get => GetProperty<TerraformLiteralProperty<string>>("signup_policy");
        set => this.WithProperty("signup_policy", value);
    }

}
