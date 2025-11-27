using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in GoogleIamOauthClient.
/// Nesting mode: single
/// </summary>
public class GoogleIamOauthClientTimeoutsBlock : TerraformBlock
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
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a google_iam_oauth_client Terraform resource.
/// Manages a google_iam_oauth_client resource.
/// </summary>
public partial class GoogleIamOauthClient(string name) : TerraformResource("google_iam_oauth_client", name)
{
    /// <summary>
    /// Required. The list of OAuth grant types is allowed for the OauthClient.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AllowedGrantTypes is required")]
    public TerraformList<string>? AllowedGrantTypes
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "allowed_grant_types").ResolveNodes(ctx));
        set => SetArgument("allowed_grant_types", value);
    }

    /// <summary>
    /// Required. The list of redirect uris that is allowed to redirect back
    /// when authorization process is completed.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AllowedRedirectUris is required")]
    public TerraformList<string>? AllowedRedirectUris
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "allowed_redirect_uris").ResolveNodes(ctx));
        set => SetArgument("allowed_redirect_uris", value);
    }

    /// <summary>
    /// Required. The list of scopes that the OauthClient is allowed to request during
    /// OAuth flows.
    /// 
    /// The following scopes are supported:
    /// 
    /// * &#39;https://www.googleapis.com/auth/cloud-platform&#39;: See, edit, configure,
    /// and delete your Google Cloud data and see the email address for your Google
    /// Account.
    /// * &#39;openid&#39;: The OAuth client can associate you with your personal
    /// information on Google Cloud.
    /// * &#39;email&#39;: The OAuth client can read a federated identity&#39;s email address.
    /// * &#39;groups&#39;: The OAuth client can read a federated identity&#39;s groups.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AllowedScopes is required")]
    public TerraformList<string>? AllowedScopes
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "allowed_scopes").ResolveNodes(ctx));
        set => SetArgument("allowed_scopes", value);
    }

    /// <summary>
    /// Immutable. The type of OauthClient. Either public or private.
    /// For private clients, the client secret can be managed using the dedicated
    /// OauthClientCredential resource.
    /// Possible values:
    /// CLIENT_TYPE_UNSPECIFIED
    /// PUBLIC_CLIENT
    /// CONFIDENTIAL_CLIENT
    /// </summary>
    public TerraformValue<string>? ClientType
    {
        get => new TerraformReference<string>(this, "client_type");
        set => SetArgument("client_type", value);
    }

    /// <summary>
    /// A user-specified description of the OauthClient.
    /// 
    /// Cannot exceed 256 characters.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// Whether the OauthClient is disabled. You cannot use a disabled OAuth
    /// client.
    /// </summary>
    public TerraformValue<bool>? Disabled
    {
        get => new TerraformReference<bool>(this, "disabled");
        set => SetArgument("disabled", value);
    }

    /// <summary>
    /// A user-specified display name of the OauthClient.
    /// 
    /// Cannot exceed 32 characters.
    /// </summary>
    public TerraformValue<string>? DisplayName
    {
        get => new TerraformReference<string>(this, "display_name");
        set => SetArgument("display_name", value);
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
    /// Resource ID segment making up resource &#39;name&#39;. It identifies the resource within its parent collection as described in https://google.aip.dev/122.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// Required. The ID to use for the OauthClient, which becomes the final component of
    /// the resource name. This value should be a string of 6 to 63 lowercase
    /// letters, digits, or hyphens. It must start with a letter, and cannot have a
    /// trailing hyphen. The prefix &#39;gcp-&#39; is reserved for use by Google, and may
    /// not be specified.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OauthClientId is required")]
    public required TerraformValue<string> OauthClientId
    {
        get => new TerraformReference<string>(this, "oauth_client_id");
        set => SetArgument("oauth_client_id", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => new TerraformReference<string>(this, "project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// Output only. The system-generated OauthClient id.
    /// </summary>
    public TerraformValue<string> ClientId
    {
        get => new TerraformReference<string>(this, "client_id");
    }

    /// <summary>
    /// Time after which the OauthClient will be permanently purged and cannot
    /// be recovered.
    /// </summary>
    public TerraformValue<string> ExpireTime
    {
        get => new TerraformReference<string>(this, "expire_time");
    }

    /// <summary>
    /// Immutable. Identifier. The resource name of the OauthClient.
    /// 
    /// Format:&#39;projects/{project}/locations/{location}/oauthClients/{oauth_client}&#39;.
    /// </summary>
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
    }

    /// <summary>
    /// The state of the OauthClient.
    /// Possible values:
    /// STATE_UNSPECIFIED
    /// ACTIVE
    /// DELETED
    /// </summary>
    public TerraformValue<string> State
    {
        get => new TerraformReference<string>(this, "state");
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleIamOauthClientTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleIamOauthClientTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
