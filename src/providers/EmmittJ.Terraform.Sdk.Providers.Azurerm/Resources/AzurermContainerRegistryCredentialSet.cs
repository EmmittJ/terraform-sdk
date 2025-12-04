using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for authentication_credentials in AzurermContainerRegistryCredentialSet.
/// Nesting mode: list
/// </summary>
public class AzurermContainerRegistryCredentialSetAuthenticationCredentialsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "authentication_credentials";

    /// <summary>
    /// The password_secret_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PasswordSecretId is required")]
    public required TerraformValue<string> PasswordSecretId
    {
        get => GetArgument<TerraformValue<string>>("password_secret_id");
        set => SetArgument("password_secret_id", value);
    }

    /// <summary>
    /// The username_secret_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UsernameSecretId is required")]
    public required TerraformValue<string> UsernameSecretId
    {
        get => GetArgument<TerraformValue<string>>("username_secret_id");
        set => SetArgument("username_secret_id", value);
    }

}


/// <summary>
/// Block type for identity in AzurermContainerRegistryCredentialSet.
/// Nesting mode: list
/// </summary>
public class AzurermContainerRegistryCredentialSetIdentityBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "identity";

    /// <summary>
    /// The principal_id attribute.
    /// </summary>
    public TerraformValue<string> PrincipalId
        => AsReference("principal_id");

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    public TerraformValue<string> TenantId
        => AsReference("tenant_id");

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => GetArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermContainerRegistryCredentialSet.
/// Nesting mode: single
/// </summary>
public class AzurermContainerRegistryCredentialSetTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_container_registry_credential_set Terraform resource.
/// Manages a azurerm_container_registry_credential_set resource.
/// </summary>
public partial class AzurermContainerRegistryCredentialSet(string name) : TerraformResource("azurerm_container_registry_credential_set", name)
{
    /// <summary>
    /// The container_registry_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContainerRegistryId is required")]
    public required TerraformValue<string> ContainerRegistryId
    {
        get => GetArgument<TerraformValue<string>>("container_registry_id");
        set => SetArgument("container_registry_id", value);
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
    /// The login_server attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LoginServer is required")]
    public required TerraformValue<string> LoginServer
    {
        get => GetArgument<TerraformValue<string>>("login_server");
        set => SetArgument("login_server", value);
    }

    /// <summary>
    /// The name of the credential set.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// AuthenticationCredentials block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AuthenticationCredentials is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 AuthenticationCredentials block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AuthenticationCredentials block(s) allowed")]
    public required TerraformList<AzurermContainerRegistryCredentialSetAuthenticationCredentialsBlock> AuthenticationCredentials
    {
        get => GetRequiredArgument<TerraformList<AzurermContainerRegistryCredentialSetAuthenticationCredentialsBlock>>("authentication_credentials");
        set => SetArgument("authentication_credentials", value);
    }

    /// <summary>
    /// Identity block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Identity is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Identity block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    public required TerraformList<AzurermContainerRegistryCredentialSetIdentityBlock> Identity
    {
        get => GetRequiredArgument<TerraformList<AzurermContainerRegistryCredentialSetIdentityBlock>>("identity");
        set => SetArgument("identity", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermContainerRegistryCredentialSetTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermContainerRegistryCredentialSetTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
