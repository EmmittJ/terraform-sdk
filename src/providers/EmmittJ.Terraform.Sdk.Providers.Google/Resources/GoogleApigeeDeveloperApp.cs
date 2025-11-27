using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for attributes in GoogleApigeeDeveloperApp.
/// Nesting mode: list
/// </summary>
public class GoogleApigeeDeveloperAppAttributesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "attributes";

    /// <summary>
    /// Key of the attribute
    /// </summary>
    public TerraformValue<string>? Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Value of the attribute
    /// </summary>
    public TerraformValue<string>? Value
    {
        get => new TerraformReference<string>(this, "value");
        set => SetArgument("value", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleApigeeDeveloperApp.
/// Nesting mode: single
/// </summary>
public class GoogleApigeeDeveloperAppTimeoutsBlock : TerraformBlock
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
/// Represents a google_apigee_developer_app Terraform resource.
/// Manages a google_apigee_developer_app resource.
/// </summary>
public partial class GoogleApigeeDeveloperApp(string name) : TerraformResource("google_apigee_developer_app", name)
{
    /// <summary>
    /// List of API products associated with the developer app.
    /// </summary>
    public TerraformSet<string>? ApiProducts
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "api_products").ResolveNodes(ctx));
        set => SetArgument("api_products", value);
    }

    /// <summary>
    /// Developer app family.
    /// </summary>
    public TerraformValue<string> AppFamily
    {
        get => new TerraformReference<string>(this, "app_family");
        set => SetArgument("app_family", value);
    }

    /// <summary>
    /// Callback URL used by OAuth 2.0 authorization servers to communicate
    /// authorization codes back to developer apps.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CallbackUrl is required")]
    public required TerraformValue<string> CallbackUrl
    {
        get => new TerraformReference<string>(this, "callback_url");
        set => SetArgument("callback_url", value);
    }

    /// <summary>
    /// Email address of the developer.
    /// This value is used to uniquely identify the developer in Apigee hybrid.
    /// Note that the email address has to be in lowercase only.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DeveloperEmail is required")]
    public required TerraformValue<string> DeveloperEmail
    {
        get => new TerraformReference<string>(this, "developer_email");
        set => SetArgument("developer_email", value);
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
    /// Expiration time, in milliseconds, for the consumer key that is generated
    /// for the developer app. If not set or left to the default value of -1,
    /// the API key never expires. The expiration time can&#39;t be updated after it is set.
    /// </summary>
    public TerraformValue<string>? KeyExpiresIn
    {
        get => new TerraformReference<string>(this, "key_expires_in");
        set => SetArgument("key_expires_in", value);
    }

    /// <summary>
    /// Name of the developer app.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The Apigee Organization associated with the Apigee instance,
    /// in the format &#39;organizations/{{org_name}}&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OrgId is required")]
    public required TerraformValue<string> OrgId
    {
        get => new TerraformReference<string>(this, "org_id");
        set => SetArgument("org_id", value);
    }

    /// <summary>
    /// Scopes to apply to the developer app.
    /// The specified scopes must already exist for the API product that
    /// you associate with the developer app.
    /// </summary>
    public TerraformSet<string>? Scopes
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "scopes").ResolveNodes(ctx));
        set => SetArgument("scopes", value);
    }

    /// <summary>
    /// Status of the credential. Valid values include approved or revoked.
    /// </summary>
    public TerraformValue<string> Status
    {
        get => new TerraformReference<string>(this, "status");
        set => SetArgument("status", value);
    }

    /// <summary>
    /// ID of the developer app. This ID is not user specified but is
    /// automatically generated on app creation. appId is a UUID.
    /// </summary>
    public TerraformValue<string> AppId
    {
        get => new TerraformReference<string>(this, "app_id");
    }

    /// <summary>
    /// Time at which the developer was created in milliseconds since epoch.
    /// </summary>
    public TerraformValue<string> CreatedAt
    {
        get => new TerraformReference<string>(this, "created_at");
    }

    /// <summary>
    /// Output only. Set of credentials for the developer app consisting of
    /// the consumer key/secret pairs associated with the API products.
    /// </summary>
    public TerraformList<TerraformMap<object>> Credentials
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "credentials").ResolveNodes(ctx));
    }

    /// <summary>
    /// ID of the developer.
    /// </summary>
    public TerraformValue<string> DeveloperId
    {
        get => new TerraformReference<string>(this, "developer_id");
    }

    /// <summary>
    /// Time at which the developer was last modified in milliseconds since epoch.
    /// </summary>
    public TerraformValue<string> LastModifiedAt
    {
        get => new TerraformReference<string>(this, "last_modified_at");
    }

    /// <summary>
    /// Attributes block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleApigeeDeveloperAppAttributesBlock>? Attributes
    {
        get => GetArgument<TerraformList<GoogleApigeeDeveloperAppAttributesBlock>>("attributes");
        set => SetArgument("attributes", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleApigeeDeveloperAppTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleApigeeDeveloperAppTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
