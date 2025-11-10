using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermApiManagementIdentityProviderAadb2cTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AllowedTenant is required")]
    public required TerraformProperty<string> AllowedTenant
    {
        get => GetProperty<TerraformProperty<string>>("allowed_tenant");
        set => this.WithProperty("allowed_tenant", value);
    }

    /// <summary>
    /// The api_management_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApiManagementName is required")]
    public required TerraformProperty<string> ApiManagementName
    {
        get => GetProperty<TerraformProperty<string>>("api_management_name");
        set => this.WithProperty("api_management_name", value);
    }

    /// <summary>
    /// The authority attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Authority is required")]
    public required TerraformProperty<string> Authority
    {
        get => GetProperty<TerraformProperty<string>>("authority");
        set => this.WithProperty("authority", value);
    }

    /// <summary>
    /// The client_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientId is required")]
    public required TerraformProperty<string> ClientId
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientSecret is required")]
    public required TerraformProperty<string> ClientSecret
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
    /// The password_reset_policy attribute.
    /// </summary>
    public TerraformProperty<string>? PasswordResetPolicy
    {
        get => GetProperty<TerraformProperty<string>>("password_reset_policy");
        set => this.WithProperty("password_reset_policy", value);
    }

    /// <summary>
    /// The profile_editing_policy attribute.
    /// </summary>
    public TerraformProperty<string>? ProfileEditingPolicy
    {
        get => GetProperty<TerraformProperty<string>>("profile_editing_policy");
        set => this.WithProperty("profile_editing_policy", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The signin_policy attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SigninPolicy is required")]
    public required TerraformProperty<string> SigninPolicy
    {
        get => GetProperty<TerraformProperty<string>>("signin_policy");
        set => this.WithProperty("signin_policy", value);
    }

    /// <summary>
    /// The signin_tenant attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SigninTenant is required")]
    public required TerraformProperty<string> SigninTenant
    {
        get => GetProperty<TerraformProperty<string>>("signin_tenant");
        set => this.WithProperty("signin_tenant", value);
    }

    /// <summary>
    /// The signup_policy attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SignupPolicy is required")]
    public required TerraformProperty<string> SignupPolicy
    {
        get => GetProperty<TerraformProperty<string>>("signup_policy");
        set => this.WithProperty("signup_policy", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermApiManagementIdentityProviderAadb2cTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermApiManagementIdentityProviderAadb2cTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
