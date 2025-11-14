using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

// Resources, Data Sources, Ephemeral Resources, Blocks: Getter ALWAYS returns a reference
// This is the key to natural Terraform syntax
// When you access rg.Name, you get azurerm_resource_group.rg.name (a reference)
// The value that was SET is only used during serialization

// Providers: Getter returns stored value
// Providers are not referenced in HCL
// Use required getter if property is required or non-nullable

/// <summary>
/// Block type for timeouts in .
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
    [TerraformArgument("create")]
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformArgument("delete")]
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformArgument("update")]
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}

/// <summary>
/// Manages a azurerm_api_management_identity_provider_aadb2c resource.
/// </summary>
public class AzurermApiManagementIdentityProviderAadb2c : TerraformResource
{
    public AzurermApiManagementIdentityProviderAadb2c(string name) : base("azurerm_api_management_identity_provider_aadb2c", name)
    {
    }

    /// <summary>
    /// The allowed_tenant attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AllowedTenant is required")]
    [TerraformArgument("allowed_tenant")]
    public required TerraformValue<string> AllowedTenant
    {
        get => new TerraformReference<string>(this, "allowed_tenant");
        set => SetArgument("allowed_tenant", value);
    }

    /// <summary>
    /// The api_management_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApiManagementName is required")]
    [TerraformArgument("api_management_name")]
    public required TerraformValue<string> ApiManagementName
    {
        get => new TerraformReference<string>(this, "api_management_name");
        set => SetArgument("api_management_name", value);
    }

    /// <summary>
    /// The authority attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Authority is required")]
    [TerraformArgument("authority")]
    public required TerraformValue<string> Authority
    {
        get => new TerraformReference<string>(this, "authority");
        set => SetArgument("authority", value);
    }

    /// <summary>
    /// The client_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientId is required")]
    [TerraformArgument("client_id")]
    public required TerraformValue<string> ClientId
    {
        get => new TerraformReference<string>(this, "client_id");
        set => SetArgument("client_id", value);
    }

    /// <summary>
    /// The client_library attribute.
    /// </summary>
    [TerraformArgument("client_library")]
    public TerraformValue<string>? ClientLibrary
    {
        get => new TerraformReference<string>(this, "client_library");
        set => SetArgument("client_library", value);
    }

    /// <summary>
    /// The client_secret attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientSecret is required")]
    [TerraformArgument("client_secret")]
    public required TerraformValue<string> ClientSecret
    {
        get => new TerraformReference<string>(this, "client_secret");
        set => SetArgument("client_secret", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformArgument("id")]
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The password_reset_policy attribute.
    /// </summary>
    [TerraformArgument("password_reset_policy")]
    public TerraformValue<string>? PasswordResetPolicy
    {
        get => new TerraformReference<string>(this, "password_reset_policy");
        set => SetArgument("password_reset_policy", value);
    }

    /// <summary>
    /// The profile_editing_policy attribute.
    /// </summary>
    [TerraformArgument("profile_editing_policy")]
    public TerraformValue<string>? ProfileEditingPolicy
    {
        get => new TerraformReference<string>(this, "profile_editing_policy");
        set => SetArgument("profile_editing_policy", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformArgument("resource_group_name")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The signin_policy attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SigninPolicy is required")]
    [TerraformArgument("signin_policy")]
    public required TerraformValue<string> SigninPolicy
    {
        get => new TerraformReference<string>(this, "signin_policy");
        set => SetArgument("signin_policy", value);
    }

    /// <summary>
    /// The signin_tenant attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SigninTenant is required")]
    [TerraformArgument("signin_tenant")]
    public required TerraformValue<string> SigninTenant
    {
        get => new TerraformReference<string>(this, "signin_tenant");
        set => SetArgument("signin_tenant", value);
    }

    /// <summary>
    /// The signup_policy attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SignupPolicy is required")]
    [TerraformArgument("signup_policy")]
    public required TerraformValue<string> SignupPolicy
    {
        get => new TerraformReference<string>(this, "signup_policy");
        set => SetArgument("signup_policy", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermApiManagementIdentityProviderAadb2cTimeoutsBlock Timeouts { get; set; } = new();

}
