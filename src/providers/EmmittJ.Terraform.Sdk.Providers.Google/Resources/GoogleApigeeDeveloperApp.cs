using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for attributes in .
/// Nesting mode: list
/// </summary>
public partial class GoogleApigeeDeveloperAppAttributesBlock : TerraformBlockBase
{
    /// <summary>
    /// Key of the attribute
    /// </summary>
    [TerraformProperty("name")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Name { get; set; }

    /// <summary>
    /// Value of the attribute
    /// </summary>
    [TerraformProperty("value")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Value { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleApigeeDeveloperAppTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_apigee_developer_app resource.
/// </summary>
public partial class GoogleApigeeDeveloperApp : TerraformResource
{
    public GoogleApigeeDeveloperApp(string name) : base("google_apigee_developer_app", name)
    {
    }

    /// <summary>
    /// List of API products associated with the developer app.
    /// </summary>
    [TerraformProperty("api_products")]
    // Optional argument - source generator will implement get/set
    public TerraformSet<string>? ApiProducts { get; set; }

    /// <summary>
    /// Developer app family.
    /// </summary>
    [TerraformProperty("app_family")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> AppFamily { get; set; }

    /// <summary>
    /// Callback URL used by OAuth 2.0 authorization servers to communicate
    /// authorization codes back to developer apps.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CallbackUrl is required")]
    [TerraformProperty("callback_url")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> CallbackUrl { get; set; }

    /// <summary>
    /// Email address of the developer.
    /// This value is used to uniquely identify the developer in Apigee hybrid.
    /// Note that the email address has to be in lowercase only.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DeveloperEmail is required")]
    [TerraformProperty("developer_email")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> DeveloperEmail { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Expiration time, in milliseconds, for the consumer key that is generated
    /// for the developer app. If not set or left to the default value of -1,
    /// the API key never expires. The expiration time can&#39;t be updated after it is set.
    /// </summary>
    [TerraformProperty("key_expires_in")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? KeyExpiresIn { get; set; }

    /// <summary>
    /// Name of the developer app.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The Apigee Organization associated with the Apigee instance,
    /// in the format &#39;organizations/{{org_name}}&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OrgId is required")]
    [TerraformProperty("org_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> OrgId { get; set; }

    /// <summary>
    /// Scopes to apply to the developer app.
    /// The specified scopes must already exist for the API product that
    /// you associate with the developer app.
    /// </summary>
    [TerraformProperty("scopes")]
    // Optional argument - source generator will implement get/set
    public TerraformSet<string>? Scopes { get; set; }

    /// <summary>
    /// Status of the credential. Valid values include approved or revoked.
    /// </summary>
    [TerraformProperty("status")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Status { get; set; }

    /// <summary>
    /// Block for attributes.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("attributes")]
    public TerraformList<TerraformBlock<GoogleApigeeDeveloperAppAttributesBlock>>? Attributes { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<GoogleApigeeDeveloperAppTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// ID of the developer app. This ID is not user specified but is
    /// automatically generated on app creation. appId is a UUID.
    /// </summary>
    [TerraformProperty("app_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> AppId { get; }

    /// <summary>
    /// Time at which the developer was created in milliseconds since epoch.
    /// </summary>
    [TerraformProperty("created_at")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> CreatedAt { get; }

    /// <summary>
    /// Output only. Set of credentials for the developer app consisting of
    /// the consumer key/secret pairs associated with the API products.
    /// </summary>
    [TerraformProperty("credentials")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> Credentials { get; }

    /// <summary>
    /// ID of the developer.
    /// </summary>
    [TerraformProperty("developer_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> DeveloperId { get; }

    /// <summary>
    /// Time at which the developer was last modified in milliseconds since epoch.
    /// </summary>
    [TerraformProperty("last_modified_at")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> LastModifiedAt { get; }

}
