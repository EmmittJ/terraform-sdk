using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleIamOauthClientCredentialTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_iam_oauth_client_credential resource.
/// </summary>
public partial class GoogleIamOauthClientCredential : TerraformResource
{
    public GoogleIamOauthClientCredential(string name) : base("google_iam_oauth_client_credential", name)
    {
    }

    /// <summary>
    /// Whether the OauthClientCredential is disabled. You cannot use a
    /// disabled OauthClientCredential.
    /// </summary>
    [TerraformProperty("disabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? Disabled { get; set; }

    /// <summary>
    /// A user-specified display name of the OauthClientCredential.
    /// 
    /// Cannot exceed 32 characters.
    /// </summary>
    [TerraformProperty("display_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DisplayName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Resource ID segment making up resource &#39;name&#39;. It identifies the resource within its parent collection as described in https://google.aip.dev/122.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Location { get; set; }

    /// <summary>
    /// Required. The ID to use for the OauthClientCredential, which becomes the
    /// final component of the resource name. This value should be 4-32 characters,
    /// and may contain the characters [a-z0-9-]. The prefix &#39;gcp-&#39; is
    /// reserved for use by Google, and may not be specified.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OauthClientCredentialId is required")]
    [TerraformProperty("oauth_client_credential_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> OauthClientCredentialId { get; set; }

    /// <summary>
    /// Resource ID segment making up resource &#39;name&#39;. It identifies the resource within its parent collection as described in https://google.aip.dev/122.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Oauthclient is required")]
    [TerraformProperty("oauthclient")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Oauthclient { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Project { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public GoogleIamOauthClientCredentialTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The system-generated OAuth client secret.
    /// 
    /// The client secret must be stored securely. If the client secret is
    /// leaked, you must delete and re-create the client credential. To learn
    /// more, see [OAuth client and credential security risks and
    /// mitigations](https://cloud.google.com/iam/docs/workforce-oauth-app#security)
    /// </summary>
    [TerraformProperty("client_secret")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ClientSecret { get; }

    /// <summary>
    /// Immutable. Identifier. The resource name of the OauthClientCredential.
    /// 
    /// Format:
    /// &#39;projects/{project}/locations/{location}/oauthClients/{oauth_client}/credentials/{credential}&#39;
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Name { get; }

}
