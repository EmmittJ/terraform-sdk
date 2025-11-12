using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzureadApplicationIdentifierUriTimeoutsBlock() : TerraformBlock("timeouts")
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

}

/// <summary>
/// Manages a azuread_application_identifier_uri resource.
/// </summary>
public partial class AzureadApplicationIdentifierUri : TerraformResource
{
    public AzureadApplicationIdentifierUri(string name) : base("azuread_application_identifier_uri", name)
    {
    }

    /// <summary>
    /// The resource ID of the application to which the identifier URI should be added
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApplicationId is required")]
    [TerraformProperty("application_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ApplicationId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The user-defined URI or URI-like string that uniquely identifies an application within its Azure AD tenant, or within a verified custom domain if the application is multi-tenant
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IdentifierUri is required")]
    [TerraformProperty("identifier_uri")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> IdentifierUri { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzureadApplicationIdentifierUriTimeoutsBlock Timeouts { get; set; } = new();

}
