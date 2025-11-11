using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for attributes in .
/// Nesting mode: list
/// </summary>
public class GoogleApigeeDeveloperAppAttributesBlock
{
    /// <summary>
    /// Key of the attribute
    /// </summary>
    [TerraformPropertyName("name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Name { get; set; }

    /// <summary>
    /// Value of the attribute
    /// </summary>
    [TerraformPropertyName("value")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Value { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleApigeeDeveloperAppTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_apigee_developer_app resource.
/// </summary>
public class GoogleApigeeDeveloperApp : TerraformResource
{
    public GoogleApigeeDeveloperApp(string name) : base("google_apigee_developer_app", name)
    {
    }

    /// <summary>
    /// List of API products associated with the developer app.
    /// </summary>
    [TerraformPropertyName("api_products")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? ApiProducts { get; set; }

    /// <summary>
    /// Developer app family.
    /// </summary>
    [TerraformPropertyName("app_family")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> AppFamily { get; set; } = default!;

    /// <summary>
    /// Callback URL used by OAuth 2.0 authorization servers to communicate
    /// authorization codes back to developer apps.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CallbackUrl is required")]
    [TerraformPropertyName("callback_url")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> CallbackUrl { get; set; }

    /// <summary>
    /// Email address of the developer.
    /// This value is used to uniquely identify the developer in Apigee hybrid.
    /// Note that the email address has to be in lowercase only.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DeveloperEmail is required")]
    [TerraformPropertyName("developer_email")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> DeveloperEmail { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// Expiration time, in milliseconds, for the consumer key that is generated
    /// for the developer app. If not set or left to the default value of -1,
    /// the API key never expires. The expiration time can&#39;t be updated after it is set.
    /// </summary>
    [TerraformPropertyName("key_expires_in")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? KeyExpiresIn { get; set; }

    /// <summary>
    /// Name of the developer app.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The Apigee Organization associated with the Apigee instance,
    /// in the format &#39;organizations/{{org_name}}&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OrgId is required")]
    [TerraformPropertyName("org_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> OrgId { get; set; }

    /// <summary>
    /// Scopes to apply to the developer app.
    /// The specified scopes must already exist for the API product that
    /// you associate with the developer app.
    /// </summary>
    [TerraformPropertyName("scopes")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? Scopes { get; set; }

    /// <summary>
    /// Status of the credential. Valid values include approved or revoked.
    /// </summary>
    [TerraformPropertyName("status")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Status { get; set; } = default!;

    /// <summary>
    /// Block for attributes.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("attributes")]
    public TerraformList<TerraformBlock<GoogleApigeeDeveloperAppAttributesBlock>>? Attributes { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleApigeeDeveloperAppTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// ID of the developer app. This ID is not user specified but is
    /// automatically generated on app creation. appId is a UUID.
    /// </summary>
    [TerraformPropertyName("app_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> AppId => new TerraformReference(this, "app_id");

    /// <summary>
    /// Time at which the developer was created in milliseconds since epoch.
    /// </summary>
    [TerraformPropertyName("created_at")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CreatedAt => new TerraformReference(this, "created_at");

    /// <summary>
    /// Output only. Set of credentials for the developer app consisting of
    /// the consumer key/secret pairs associated with the API products.
    /// </summary>
    [TerraformPropertyName("credentials")]
    // Output-only attribute - read-only reference
    public TerraformList<object> Credentials => new TerraformReference(this, "credentials");

    /// <summary>
    /// ID of the developer.
    /// </summary>
    [TerraformPropertyName("developer_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DeveloperId => new TerraformReference(this, "developer_id");

    /// <summary>
    /// Time at which the developer was last modified in milliseconds since epoch.
    /// </summary>
    [TerraformPropertyName("last_modified_at")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> LastModifiedAt => new TerraformReference(this, "last_modified_at");

}
