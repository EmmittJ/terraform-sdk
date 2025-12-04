using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for apns_credential in AzurermNotificationHub.
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
    public required TerraformValue<string> ApplicationMode
    {
        get => GetRequiredArgument<TerraformValue<string>>("application_mode");
        set => SetArgument("application_mode", value);
    }

    /// <summary>
    /// The bundle_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BundleId is required")]
    public required TerraformValue<string> BundleId
    {
        get => GetRequiredArgument<TerraformValue<string>>("bundle_id");
        set => SetArgument("bundle_id", value);
    }

    /// <summary>
    /// The key_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyId is required")]
    public required TerraformValue<string> KeyId
    {
        get => GetRequiredArgument<TerraformValue<string>>("key_id");
        set => SetArgument("key_id", value);
    }

    /// <summary>
    /// The team_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TeamId is required")]
    public required TerraformValue<string> TeamId
    {
        get => GetRequiredArgument<TerraformValue<string>>("team_id");
        set => SetArgument("team_id", value);
    }

    /// <summary>
    /// The token attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Token is required")]
    public required TerraformValue<string> Token
    {
        get => GetRequiredArgument<TerraformValue<string>>("token");
        set => SetArgument("token", value);
    }

}


/// <summary>
/// Block type for browser_credential in AzurermNotificationHub.
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
    public required TerraformValue<string> Subject
    {
        get => GetRequiredArgument<TerraformValue<string>>("subject");
        set => SetArgument("subject", value);
    }

    /// <summary>
    /// The vapid_private_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VapidPrivateKey is required")]
    public required TerraformValue<string> VapidPrivateKey
    {
        get => GetRequiredArgument<TerraformValue<string>>("vapid_private_key");
        set => SetArgument("vapid_private_key", value);
    }

    /// <summary>
    /// The vapid_public_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VapidPublicKey is required")]
    public required TerraformValue<string> VapidPublicKey
    {
        get => GetRequiredArgument<TerraformValue<string>>("vapid_public_key");
        set => SetArgument("vapid_public_key", value);
    }

}


/// <summary>
/// Block type for gcm_credential in AzurermNotificationHub.
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
    public required TerraformValue<string> ApiKey
    {
        get => GetRequiredArgument<TerraformValue<string>>("api_key");
        set => SetArgument("api_key", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermNotificationHub.
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
/// Represents a azurerm_notification_hub Terraform resource.
/// Manages a azurerm_notification_hub resource.
/// </summary>
public partial class AzurermNotificationHub(string name) : TerraformResource("azurerm_notification_hub", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetRequiredArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The namespace_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NamespaceName is required")]
    public required TerraformValue<string> NamespaceName
    {
        get => GetRequiredArgument<TerraformValue<string>>("namespace_name");
        set => SetArgument("namespace_name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => GetRequiredArgument<TerraformValue<string>>("resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// ApnsCredential block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ApnsCredential block(s) allowed")]
    public TerraformList<AzurermNotificationHubApnsCredentialBlock>? ApnsCredential
    {
        get => GetArgument<TerraformList<AzurermNotificationHubApnsCredentialBlock>>("apns_credential");
        set => SetArgument("apns_credential", value);
    }

    /// <summary>
    /// BrowserCredential block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BrowserCredential block(s) allowed")]
    public TerraformList<AzurermNotificationHubBrowserCredentialBlock>? BrowserCredential
    {
        get => GetArgument<TerraformList<AzurermNotificationHubBrowserCredentialBlock>>("browser_credential");
        set => SetArgument("browser_credential", value);
    }

    /// <summary>
    /// GcmCredential block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GcmCredential block(s) allowed")]
    public TerraformList<AzurermNotificationHubGcmCredentialBlock>? GcmCredential
    {
        get => GetArgument<TerraformList<AzurermNotificationHubGcmCredentialBlock>>("gcm_credential");
        set => SetArgument("gcm_credential", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermNotificationHubTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermNotificationHubTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
