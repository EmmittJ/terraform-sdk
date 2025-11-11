using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermApiManagementIdentityProviderAadb2cTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_api_management_identity_provider_aadb2c resource.
/// </summary>
public partial class AzurermApiManagementIdentityProviderAadb2c : TerraformResource
{
    public AzurermApiManagementIdentityProviderAadb2c(string name) : base("azurerm_api_management_identity_provider_aadb2c", name)
    {
    }

    /// <summary>
    /// The allowed_tenant attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AllowedTenant is required")]
    [TerraformProperty("allowed_tenant")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> AllowedTenant { get; set; }

    /// <summary>
    /// The api_management_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApiManagementName is required")]
    [TerraformProperty("api_management_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ApiManagementName { get; set; }

    /// <summary>
    /// The authority attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Authority is required")]
    [TerraformProperty("authority")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Authority { get; set; }

    /// <summary>
    /// The client_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientId is required")]
    [TerraformProperty("client_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ClientId { get; set; }

    /// <summary>
    /// The client_library attribute.
    /// </summary>
    [TerraformProperty("client_library")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ClientLibrary { get; set; }

    /// <summary>
    /// The client_secret attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientSecret is required")]
    [TerraformProperty("client_secret")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ClientSecret { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The password_reset_policy attribute.
    /// </summary>
    [TerraformProperty("password_reset_policy")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? PasswordResetPolicy { get; set; }

    /// <summary>
    /// The profile_editing_policy attribute.
    /// </summary>
    [TerraformProperty("profile_editing_policy")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ProfileEditingPolicy { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The signin_policy attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SigninPolicy is required")]
    [TerraformProperty("signin_policy")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> SigninPolicy { get; set; }

    /// <summary>
    /// The signin_tenant attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SigninTenant is required")]
    [TerraformProperty("signin_tenant")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> SigninTenant { get; set; }

    /// <summary>
    /// The signup_policy attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SignupPolicy is required")]
    [TerraformProperty("signup_policy")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> SignupPolicy { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AzurermApiManagementIdentityProviderAadb2cTimeoutsBlock>? Timeouts { get; set; }

}
