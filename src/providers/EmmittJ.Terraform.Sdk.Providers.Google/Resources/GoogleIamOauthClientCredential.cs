using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in GoogleIamOauthClientCredential.
/// Nesting mode: single
/// </summary>
public class GoogleIamOauthClientCredentialTimeoutsBlock : TerraformBlock
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
/// Represents a google_iam_oauth_client_credential Terraform resource.
/// Manages a google_iam_oauth_client_credential resource.
/// </summary>
public partial class GoogleIamOauthClientCredential(string name) : TerraformResource("google_iam_oauth_client_credential", name)
{
    /// <summary>
    /// Whether the OauthClientCredential is disabled. You cannot use a
    /// disabled OauthClientCredential.
    /// </summary>
    public TerraformValue<bool>? Disabled
    {
        get => new TerraformReference<bool>(this, "disabled");
        set => SetArgument("disabled", value);
    }

    /// <summary>
    /// A user-specified display name of the OauthClientCredential.
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
    /// Required. The ID to use for the OauthClientCredential, which becomes the
    /// final component of the resource name. This value should be 4-32 characters,
    /// and may contain the characters [a-z0-9-]. The prefix &#39;gcp-&#39; is
    /// reserved for use by Google, and may not be specified.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OauthClientCredentialId is required")]
    public required TerraformValue<string> OauthClientCredentialId
    {
        get => new TerraformReference<string>(this, "oauth_client_credential_id");
        set => SetArgument("oauth_client_credential_id", value);
    }

    /// <summary>
    /// Resource ID segment making up resource &#39;name&#39;. It identifies the resource within its parent collection as described in https://google.aip.dev/122.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Oauthclient is required")]
    public required TerraformValue<string> Oauthclient
    {
        get => new TerraformReference<string>(this, "oauthclient");
        set => SetArgument("oauthclient", value);
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
    /// The system-generated OAuth client secret.
    /// 
    /// The client secret must be stored securely. If the client secret is
    /// leaked, you must delete and re-create the client credential. To learn
    /// more, see [OAuth client and credential security risks and
    /// mitigations](https://cloud.google.com/iam/docs/workforce-oauth-app#security)
    /// </summary>
    public TerraformValue<string> ClientSecret
    {
        get => new TerraformReference<string>(this, "client_secret");
    }

    /// <summary>
    /// Immutable. Identifier. The resource name of the OauthClientCredential.
    /// 
    /// Format:
    /// &#39;projects/{project}/locations/{location}/oauthClients/{oauth_client}/credentials/{credential}&#39;
    /// </summary>
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleIamOauthClientCredentialTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleIamOauthClientCredentialTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
