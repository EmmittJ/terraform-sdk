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
public class AzurermApiManagementAuthorizationServerTimeoutsBlock : TerraformBlock
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
/// Block type for token_body_parameter in .
/// Nesting mode: list
/// </summary>
public class AzurermApiManagementAuthorizationServerTokenBodyParameterBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "token_body_parameter";

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    [TerraformArgument("value")]
    public required TerraformValue<string> Value
    {
        get => new TerraformReference<string>(this, "value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Manages a azurerm_api_management_authorization_server resource.
/// </summary>
public class AzurermApiManagementAuthorizationServer : TerraformResource
{
    public AzurermApiManagementAuthorizationServer(string name) : base("azurerm_api_management_authorization_server", name)
    {
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
    /// The authorization_endpoint attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AuthorizationEndpoint is required")]
    [TerraformArgument("authorization_endpoint")]
    public required TerraformValue<string> AuthorizationEndpoint
    {
        get => new TerraformReference<string>(this, "authorization_endpoint");
        set => SetArgument("authorization_endpoint", value);
    }

    /// <summary>
    /// The authorization_methods attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AuthorizationMethods is required")]
    [TerraformArgument("authorization_methods")]
    public required TerraformSet<string> AuthorizationMethods
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "authorization_methods").ResolveNodes(ctx));
        set => SetArgument("authorization_methods", value);
    }

    /// <summary>
    /// The bearer_token_sending_methods attribute.
    /// </summary>
    [TerraformArgument("bearer_token_sending_methods")]
    public TerraformSet<string>? BearerTokenSendingMethods
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "bearer_token_sending_methods").ResolveNodes(ctx));
        set => SetArgument("bearer_token_sending_methods", value);
    }

    /// <summary>
    /// The client_authentication_method attribute.
    /// </summary>
    [TerraformArgument("client_authentication_method")]
    public TerraformSet<string>? ClientAuthenticationMethod
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "client_authentication_method").ResolveNodes(ctx));
        set => SetArgument("client_authentication_method", value);
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
    /// The client_registration_endpoint attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientRegistrationEndpoint is required")]
    [TerraformArgument("client_registration_endpoint")]
    public required TerraformValue<string> ClientRegistrationEndpoint
    {
        get => new TerraformReference<string>(this, "client_registration_endpoint");
        set => SetArgument("client_registration_endpoint", value);
    }

    /// <summary>
    /// The client_secret attribute.
    /// </summary>
    [TerraformArgument("client_secret")]
    public TerraformValue<string>? ClientSecret
    {
        get => new TerraformReference<string>(this, "client_secret");
        set => SetArgument("client_secret", value);
    }

    /// <summary>
    /// The default_scope attribute.
    /// </summary>
    [TerraformArgument("default_scope")]
    public TerraformValue<string>? DefaultScope
    {
        get => new TerraformReference<string>(this, "default_scope");
        set => SetArgument("default_scope", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformArgument("description")]
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    [TerraformArgument("display_name")]
    public required TerraformValue<string> DisplayName
    {
        get => new TerraformReference<string>(this, "display_name");
        set => SetArgument("display_name", value);
    }

    /// <summary>
    /// The grant_types attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GrantTypes is required")]
    [TerraformArgument("grant_types")]
    public required TerraformSet<string> GrantTypes
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "grant_types").ResolveNodes(ctx));
        set => SetArgument("grant_types", value);
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
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
    /// The resource_owner_password attribute.
    /// </summary>
    [TerraformArgument("resource_owner_password")]
    public TerraformValue<string>? ResourceOwnerPassword
    {
        get => new TerraformReference<string>(this, "resource_owner_password");
        set => SetArgument("resource_owner_password", value);
    }

    /// <summary>
    /// The resource_owner_username attribute.
    /// </summary>
    [TerraformArgument("resource_owner_username")]
    public TerraformValue<string>? ResourceOwnerUsername
    {
        get => new TerraformReference<string>(this, "resource_owner_username");
        set => SetArgument("resource_owner_username", value);
    }

    /// <summary>
    /// The support_state attribute.
    /// </summary>
    [TerraformArgument("support_state")]
    public TerraformValue<bool>? SupportState
    {
        get => new TerraformReference<bool>(this, "support_state");
        set => SetArgument("support_state", value);
    }

    /// <summary>
    /// The token_endpoint attribute.
    /// </summary>
    [TerraformArgument("token_endpoint")]
    public TerraformValue<string>? TokenEndpoint
    {
        get => new TerraformReference<string>(this, "token_endpoint");
        set => SetArgument("token_endpoint", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermApiManagementAuthorizationServerTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// Block for token_body_parameter.
    /// Nesting mode: list
    /// </summary>
    [TerraformArgument("token_body_parameter")]
    public TerraformList<AzurermApiManagementAuthorizationServerTokenBodyParameterBlock> TokenBodyParameter { get; set; } = new();

}
