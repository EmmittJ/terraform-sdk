using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermApiManagementIdentityProviderAad.
/// Nesting mode: single
/// </summary>
public class AzurermApiManagementIdentityProviderAadTimeoutsBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a azurerm_api_management_identity_provider_aad Terraform resource.
/// Manages a azurerm_api_management_identity_provider_aad resource.
/// </summary>
public partial class AzurermApiManagementIdentityProviderAad(string name) : TerraformResource("azurerm_api_management_identity_provider_aad", name)
{
    /// <summary>
    /// The allowed_tenants attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AllowedTenants is required")]
    public TerraformList<string>? AllowedTenants
    {
        get => GetArgument<TerraformList<string>>("allowed_tenants");
        set => SetArgument("allowed_tenants", value);
    }

    /// <summary>
    /// The api_management_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApiManagementName is required")]
    public required TerraformValue<string> ApiManagementName
    {
        get => GetArgument<TerraformValue<string>>("api_management_name");
        set => SetArgument("api_management_name", value);
    }

    /// <summary>
    /// The client_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientId is required")]
    public required TerraformValue<string> ClientId
    {
        get => GetArgument<TerraformValue<string>>("client_id");
        set => SetArgument("client_id", value);
    }

    /// <summary>
    /// The client_library attribute.
    /// </summary>
    public TerraformValue<string>? ClientLibrary
    {
        get => GetArgument<TerraformValue<string>>("client_library");
        set => SetArgument("client_library", value);
    }

    /// <summary>
    /// The client_secret attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientSecret is required")]
    public required TerraformValue<string> ClientSecret
    {
        get => GetArgument<TerraformValue<string>>("client_secret");
        set => SetArgument("client_secret", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => GetArgument<TerraformValue<string>>("resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The signin_tenant attribute.
    /// </summary>
    public TerraformValue<string>? SigninTenant
    {
        get => GetArgument<TerraformValue<string>>("signin_tenant");
        set => SetArgument("signin_tenant", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermApiManagementIdentityProviderAadTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermApiManagementIdentityProviderAadTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
