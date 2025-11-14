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
/// Block type for apns_credential in .
/// Nesting mode: list
/// </summary>
public class AzurermNotificationHubApnsCredentialBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "apns_credential";

    /// <summary>
    /// The application_mode attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApplicationMode is required")]
    [TerraformArgument("application_mode")]
    public required TerraformValue<string> ApplicationMode
    {
        get => new TerraformReference<string>(this, "application_mode");
        set => SetArgument("application_mode", value);
    }

    /// <summary>
    /// The bundle_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BundleId is required")]
    [TerraformArgument("bundle_id")]
    public required TerraformValue<string> BundleId
    {
        get => new TerraformReference<string>(this, "bundle_id");
        set => SetArgument("bundle_id", value);
    }

    /// <summary>
    /// The key_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyId is required")]
    [TerraformArgument("key_id")]
    public required TerraformValue<string> KeyId
    {
        get => new TerraformReference<string>(this, "key_id");
        set => SetArgument("key_id", value);
    }

    /// <summary>
    /// The team_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TeamId is required")]
    [TerraformArgument("team_id")]
    public required TerraformValue<string> TeamId
    {
        get => new TerraformReference<string>(this, "team_id");
        set => SetArgument("team_id", value);
    }

    /// <summary>
    /// The token attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Token is required")]
    [TerraformArgument("token")]
    public required TerraformValue<string> Token
    {
        get => new TerraformReference<string>(this, "token");
        set => SetArgument("token", value);
    }

}

/// <summary>
/// Block type for browser_credential in .
/// Nesting mode: list
/// </summary>
public class AzurermNotificationHubBrowserCredentialBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "browser_credential";

    /// <summary>
    /// The subject attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Subject is required")]
    [TerraformArgument("subject")]
    public required TerraformValue<string> Subject
    {
        get => new TerraformReference<string>(this, "subject");
        set => SetArgument("subject", value);
    }

    /// <summary>
    /// The vapid_private_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VapidPrivateKey is required")]
    [TerraformArgument("vapid_private_key")]
    public required TerraformValue<string> VapidPrivateKey
    {
        get => new TerraformReference<string>(this, "vapid_private_key");
        set => SetArgument("vapid_private_key", value);
    }

    /// <summary>
    /// The vapid_public_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VapidPublicKey is required")]
    [TerraformArgument("vapid_public_key")]
    public required TerraformValue<string> VapidPublicKey
    {
        get => new TerraformReference<string>(this, "vapid_public_key");
        set => SetArgument("vapid_public_key", value);
    }

}

/// <summary>
/// Block type for gcm_credential in .
/// Nesting mode: list
/// </summary>
public class AzurermNotificationHubGcmCredentialBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "gcm_credential";

    /// <summary>
    /// The api_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApiKey is required")]
    [TerraformArgument("api_key")]
    public required TerraformValue<string> ApiKey
    {
        get => new TerraformReference<string>(this, "api_key");
        set => SetArgument("api_key", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermNotificationHubTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_notification_hub resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermNotificationHub : TerraformResource
{
    public AzurermNotificationHub(string name) : base("azurerm_notification_hub", name)
    {
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
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformArgument("location")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
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
    /// The namespace_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NamespaceName is required")]
    [TerraformArgument("namespace_name")]
    public required TerraformValue<string> NamespaceName
    {
        get => new TerraformReference<string>(this, "namespace_name");
        set => SetArgument("namespace_name", value);
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
    /// The tags attribute.
    /// </summary>
    [TerraformArgument("tags")]
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// Block for apns_credential.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ApnsCredential block(s) allowed")]
    [TerraformArgument("apns_credential")]
    public TerraformList<AzurermNotificationHubApnsCredentialBlock> ApnsCredential { get; set; } = new();

    /// <summary>
    /// Block for browser_credential.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BrowserCredential block(s) allowed")]
    [TerraformArgument("browser_credential")]
    public TerraformList<AzurermNotificationHubBrowserCredentialBlock> BrowserCredential { get; set; } = new();

    /// <summary>
    /// Block for gcm_credential.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GcmCredential block(s) allowed")]
    [TerraformArgument("gcm_credential")]
    public TerraformList<AzurermNotificationHubGcmCredentialBlock> GcmCredential { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermNotificationHubTimeoutsBlock Timeouts { get; set; } = new();

}
