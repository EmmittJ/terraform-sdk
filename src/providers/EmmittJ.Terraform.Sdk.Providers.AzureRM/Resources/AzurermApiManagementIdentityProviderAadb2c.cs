using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermApiManagementIdentityProviderAadb2c.
/// Nesting mode: single
/// </summary>
public class AzurermApiManagementIdentityProviderAadb2cTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a azurerm_api_management_identity_provider_aadb2c Terraform resource.
/// Manages a azurerm_api_management_identity_provider_aadb2c resource.
/// </summary>
public partial class AzurermApiManagementIdentityProviderAadb2c(string name) : TerraformResource("azurerm_api_management_identity_provider_aadb2c", name)
{
    /// <summary>
    /// The allowed_tenant attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AllowedTenant is required")]
    public required TerraformValue<string> AllowedTenant
    {
        get => new TerraformReference<string>(this, "allowed_tenant");
        set => SetArgument("allowed_tenant", value);
    }

    /// <summary>
    /// The api_management_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApiManagementName is required")]
    public required TerraformValue<string> ApiManagementName
    {
        get => new TerraformReference<string>(this, "api_management_name");
        set => SetArgument("api_management_name", value);
    }

    /// <summary>
    /// The authority attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Authority is required")]
    public required TerraformValue<string> Authority
    {
        get => new TerraformReference<string>(this, "authority");
        set => SetArgument("authority", value);
    }

    /// <summary>
    /// The client_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientId is required")]
    public required TerraformValue<string> ClientId
    {
        get => new TerraformReference<string>(this, "client_id");
        set => SetArgument("client_id", value);
    }

    /// <summary>
    /// The client_library attribute.
    /// </summary>
    public TerraformValue<string>? ClientLibrary
    {
        get => new TerraformReference<string>(this, "client_library");
        set => SetArgument("client_library", value);
    }

    /// <summary>
    /// The client_secret attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientSecret is required")]
    public required TerraformValue<string> ClientSecret
    {
        get => new TerraformReference<string>(this, "client_secret");
        set => SetArgument("client_secret", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The password_reset_policy attribute.
    /// </summary>
    public TerraformValue<string>? PasswordResetPolicy
    {
        get => new TerraformReference<string>(this, "password_reset_policy");
        set => SetArgument("password_reset_policy", value);
    }

    /// <summary>
    /// The profile_editing_policy attribute.
    /// </summary>
    public TerraformValue<string>? ProfileEditingPolicy
    {
        get => new TerraformReference<string>(this, "profile_editing_policy");
        set => SetArgument("profile_editing_policy", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The signin_policy attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SigninPolicy is required")]
    public required TerraformValue<string> SigninPolicy
    {
        get => new TerraformReference<string>(this, "signin_policy");
        set => SetArgument("signin_policy", value);
    }

    /// <summary>
    /// The signin_tenant attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SigninTenant is required")]
    public required TerraformValue<string> SigninTenant
    {
        get => new TerraformReference<string>(this, "signin_tenant");
        set => SetArgument("signin_tenant", value);
    }

    /// <summary>
    /// The signup_policy attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SignupPolicy is required")]
    public required TerraformValue<string> SignupPolicy
    {
        get => new TerraformReference<string>(this, "signup_policy");
        set => SetArgument("signup_policy", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermApiManagementIdentityProviderAadb2cTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermApiManagementIdentityProviderAadb2cTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
