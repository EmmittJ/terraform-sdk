using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for authentication_credentials in .
/// Nesting mode: list
/// </summary>
public class AzurermContainerRegistryCredentialSetAuthenticationCredentialsBlock : TerraformBlock
{
    /// <summary>
    /// The password_secret_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PasswordSecretId is required")]
    public required TerraformProperty<string> PasswordSecretId
    {
        get => GetProperty<TerraformProperty<string>>("password_secret_id");
        set => WithProperty("password_secret_id", value);
    }

    /// <summary>
    /// The username_secret_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UsernameSecretId is required")]
    public required TerraformProperty<string> UsernameSecretId
    {
        get => GetProperty<TerraformProperty<string>>("username_secret_id");
        set => WithProperty("username_secret_id", value);
    }

}

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public class AzurermContainerRegistryCredentialSetIdentityBlock : TerraformBlock
{
    /// <summary>
    /// The principal_id attribute.
    /// </summary>
    public TerraformProperty<string>? PrincipalId
    {
        get => GetProperty<TerraformProperty<string>>("principal_id");
        set => WithProperty("principal_id", value);
    }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    public TerraformProperty<string>? TenantId
    {
        get => GetProperty<TerraformProperty<string>>("tenant_id");
        set => WithProperty("tenant_id", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        get => GetProperty<TerraformProperty<string>>("type");
        set => WithProperty("type", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermContainerRegistryCredentialSetTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_container_registry_credential_set resource.
/// </summary>
public class AzurermContainerRegistryCredentialSet : TerraformResource
{
    public AzurermContainerRegistryCredentialSet(string name) : base("azurerm_container_registry_credential_set", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The container_registry_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContainerRegistryId is required")]
    public required TerraformProperty<string> ContainerRegistryId
    {
        get => GetProperty<TerraformProperty<string>>("container_registry_id");
        set => this.WithProperty("container_registry_id", value);
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
    /// The login_server attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LoginServer is required")]
    public required TerraformProperty<string> LoginServer
    {
        get => GetProperty<TerraformProperty<string>>("login_server");
        set => this.WithProperty("login_server", value);
    }

    /// <summary>
    /// The name of the credential set.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// Block for authentication_credentials.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 AuthenticationCredentials block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AuthenticationCredentials block(s) allowed")]
    public List<AzurermContainerRegistryCredentialSetAuthenticationCredentialsBlock>? AuthenticationCredentials
    {
        get => GetProperty<List<AzurermContainerRegistryCredentialSetAuthenticationCredentialsBlock>>("authentication_credentials");
        set => this.WithProperty("authentication_credentials", value);
    }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Identity block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    public List<AzurermContainerRegistryCredentialSetIdentityBlock>? Identity
    {
        get => GetProperty<List<AzurermContainerRegistryCredentialSetIdentityBlock>>("identity");
        set => this.WithProperty("identity", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermContainerRegistryCredentialSetTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermContainerRegistryCredentialSetTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
