using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzureadApplicationApiAccessTimeoutsBlock
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
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azuread_application_api_access resource.
/// </summary>
public class AzureadApplicationApiAccess : TerraformResource
{
    public AzureadApplicationApiAccess(string name) : base("azuread_application_api_access", name)
    {
    }

    /// <summary>
    /// The client ID of the API to which access is being granted
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApiClientId is required")]
    [TerraformPropertyName("api_client_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ApiClientId { get; set; }

    /// <summary>
    /// The resource ID of the application to which this API access is granted
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApplicationId is required")]
    [TerraformPropertyName("application_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ApplicationId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// A set of role IDs to be granted to the application, as published by the API
    /// </summary>
    [TerraformPropertyName("role_ids")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? RoleIds { get; set; }

    /// <summary>
    /// A set of scope IDs to be granted to the application, as published by the API
    /// </summary>
    [TerraformPropertyName("scope_ids")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? ScopeIds { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzureadApplicationApiAccessTimeoutsBlock>? Timeouts { get; set; }

}
