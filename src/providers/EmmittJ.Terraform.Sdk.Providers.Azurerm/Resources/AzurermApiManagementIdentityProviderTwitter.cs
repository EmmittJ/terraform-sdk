using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermApiManagementIdentityProviderTwitter.
/// Nesting mode: single
/// </summary>
public class AzurermApiManagementIdentityProviderTwitterTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_api_management_identity_provider_twitter Terraform resource.
/// Manages a azurerm_api_management_identity_provider_twitter resource.
/// </summary>
public partial class AzurermApiManagementIdentityProviderTwitter(string name) : TerraformResource("azurerm_api_management_identity_provider_twitter", name)
{
    /// <summary>
    /// The api_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApiKey is required")]
    public required TerraformValue<string> ApiKey
    {
        get => new TerraformReference<string>(this, "api_key");
        set => SetArgument("api_key", value);
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
    /// The api_secret_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApiSecretKey is required")]
    public required TerraformValue<string> ApiSecretKey
    {
        get => new TerraformReference<string>(this, "api_secret_key");
        set => SetArgument("api_secret_key", value);
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
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermApiManagementIdentityProviderTwitterTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermApiManagementIdentityProviderTwitterTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
