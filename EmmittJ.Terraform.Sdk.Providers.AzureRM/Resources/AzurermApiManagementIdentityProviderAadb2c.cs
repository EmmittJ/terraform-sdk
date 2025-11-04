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
    public string? AllowedTenant
    {
        get => GetProperty<TerraformLiteralProperty<string>>("allowed_tenant")?.Value;
        set => this.WithProperty("allowed_tenant", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The authority attribute.
    /// </summary>
    public string? Authority
    {
        get => GetProperty<TerraformLiteralProperty<string>>("authority")?.Value;
        set => this.WithProperty("authority", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The password_reset_policy attribute.
    /// </summary>
    public string? PasswordResetPolicy
    {
        get => GetProperty<TerraformLiteralProperty<string>>("password_reset_policy")?.Value;
        set => this.WithProperty("password_reset_policy", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The profile_editing_policy attribute.
    /// </summary>
    public string? ProfileEditingPolicy
    {
        get => GetProperty<TerraformLiteralProperty<string>>("profile_editing_policy")?.Value;
        set => this.WithProperty("profile_editing_policy", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The signin_policy attribute.
    /// </summary>
    public string? SigninPolicy
    {
        get => GetProperty<TerraformLiteralProperty<string>>("signin_policy")?.Value;
        set => this.WithProperty("signin_policy", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The signin_tenant attribute.
    /// </summary>
    public string? SigninTenant
    {
        get => GetProperty<TerraformLiteralProperty<string>>("signin_tenant")?.Value;
        set => this.WithProperty("signin_tenant", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The signup_policy attribute.
    /// </summary>
    public string? SignupPolicy
    {
        get => GetProperty<TerraformLiteralProperty<string>>("signup_policy")?.Value;
        set => this.WithProperty("signup_policy", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
