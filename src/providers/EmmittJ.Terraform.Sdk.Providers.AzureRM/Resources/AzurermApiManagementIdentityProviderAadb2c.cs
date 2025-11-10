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
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
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
        SetOutput("allowed_tenant");
        SetOutput("api_management_name");
        SetOutput("authority");
        SetOutput("client_id");
        SetOutput("client_library");
        SetOutput("client_secret");
        SetOutput("id");
        SetOutput("password_reset_policy");
        SetOutput("profile_editing_policy");
        SetOutput("resource_group_name");
        SetOutput("signin_policy");
        SetOutput("signin_tenant");
        SetOutput("signup_policy");
    }

    /// <summary>
    /// The allowed_tenant attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AllowedTenant is required")]
    public required TerraformProperty<string> AllowedTenant
    {
        get => GetRequiredOutput<TerraformProperty<string>>("allowed_tenant");
        set => SetProperty("allowed_tenant", value);
    }

    /// <summary>
    /// The api_management_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApiManagementName is required")]
    public required TerraformProperty<string> ApiManagementName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("api_management_name");
        set => SetProperty("api_management_name", value);
    }

    /// <summary>
    /// The authority attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Authority is required")]
    public required TerraformProperty<string> Authority
    {
        get => GetRequiredOutput<TerraformProperty<string>>("authority");
        set => SetProperty("authority", value);
    }

    /// <summary>
    /// The client_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientId is required")]
    public required TerraformProperty<string> ClientId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("client_id");
        set => SetProperty("client_id", value);
    }

    /// <summary>
    /// The client_library attribute.
    /// </summary>
    public TerraformProperty<string> ClientLibrary
    {
        get => GetRequiredOutput<TerraformProperty<string>>("client_library");
        set => SetProperty("client_library", value);
    }

    /// <summary>
    /// The client_secret attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientSecret is required")]
    public required TerraformProperty<string> ClientSecret
    {
        get => GetRequiredOutput<TerraformProperty<string>>("client_secret");
        set => SetProperty("client_secret", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The password_reset_policy attribute.
    /// </summary>
    public TerraformProperty<string> PasswordResetPolicy
    {
        get => GetRequiredOutput<TerraformProperty<string>>("password_reset_policy");
        set => SetProperty("password_reset_policy", value);
    }

    /// <summary>
    /// The profile_editing_policy attribute.
    /// </summary>
    public TerraformProperty<string> ProfileEditingPolicy
    {
        get => GetRequiredOutput<TerraformProperty<string>>("profile_editing_policy");
        set => SetProperty("profile_editing_policy", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("resource_group_name");
        set => SetProperty("resource_group_name", value);
    }

    /// <summary>
    /// The signin_policy attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SigninPolicy is required")]
    public required TerraformProperty<string> SigninPolicy
    {
        get => GetRequiredOutput<TerraformProperty<string>>("signin_policy");
        set => SetProperty("signin_policy", value);
    }

    /// <summary>
    /// The signin_tenant attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SigninTenant is required")]
    public required TerraformProperty<string> SigninTenant
    {
        get => GetRequiredOutput<TerraformProperty<string>>("signin_tenant");
        set => SetProperty("signin_tenant", value);
    }

    /// <summary>
    /// The signup_policy attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SignupPolicy is required")]
    public required TerraformProperty<string> SignupPolicy
    {
        get => GetRequiredOutput<TerraformProperty<string>>("signup_policy");
        set => SetProperty("signup_policy", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermApiManagementIdentityProviderAadb2cTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
