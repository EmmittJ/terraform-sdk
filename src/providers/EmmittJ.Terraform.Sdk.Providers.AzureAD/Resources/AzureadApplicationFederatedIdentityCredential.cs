using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzureadApplicationFederatedIdentityCredentialTimeoutsBlock : TerraformBlockBase
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
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azuread_application_federated_identity_credential resource.
/// </summary>
public partial class AzureadApplicationFederatedIdentityCredential : TerraformResource
{
    public AzureadApplicationFederatedIdentityCredential(string name) : base("azuread_application_federated_identity_credential", name)
    {
    }

    /// <summary>
    /// The resource ID of the application for which this federated identity credential should be created
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApplicationId is required")]
    [TerraformProperty("application_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ApplicationId { get; set; }

    /// <summary>
    /// List of audiences that can appear in the external token. This specifies what should be accepted in the `aud` claim of incoming tokens.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Audiences is required")]
    [TerraformProperty("audiences")]
    // Required argument - source generator will implement get/set
    public partial TerraformList<string>? Audiences { get; set; }

    /// <summary>
    /// A description for the federated identity credential
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// A unique display name for the federated identity credential
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    [TerraformProperty("display_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DisplayName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The URL of the external identity provider, which must match the issuer claim of the external token being exchanged. The combination of the values of issuer and subject must be unique on the app.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Issuer is required")]
    [TerraformProperty("issuer")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Issuer { get; set; }

    /// <summary>
    /// The identifier of the external software workload within the external identity provider. The combination of issuer and subject must be unique on the app.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Subject is required")]
    [TerraformProperty("subject")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Subject { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AzureadApplicationFederatedIdentityCredentialTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// A UUID used to uniquely identify this federated identity credential
    /// </summary>
    [TerraformProperty("credential_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CredentialId { get; }

}
