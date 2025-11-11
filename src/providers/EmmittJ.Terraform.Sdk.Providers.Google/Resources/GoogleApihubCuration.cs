using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for endpoint in .
/// Nesting mode: list
/// </summary>
public class GoogleApihubCurationEndpointBlock
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleApihubCurationTimeoutsBlock
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
/// Manages a google_apihub_curation resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleApihubCuration : TerraformResource
{
    public GoogleApihubCuration(string name) : base("google_apihub_curation", name)
    {
    }

    /// <summary>
    /// The ID to use for the curation resource, which will become the final
    /// component of the curations&#39;s resource name. This field is optional.
    /// 
    /// * If provided, the same will be used. The service will throw an error if
    /// the specified ID is already used by another curation resource in the API
    /// hub.
    /// * If not provided, a system generated ID will be used.
    /// 
    /// This value should be 4-500 characters, and valid characters
    /// are /a-z[0-9]-_/.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CurationId is required")]
    [TerraformPropertyName("curation_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> CurationId { get; set; }

    /// <summary>
    /// The description of the curation.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The display name of the curation.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    [TerraformPropertyName("display_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> DisplayName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// Resource ID segment making up resource &#39;name&#39;. It identifies the resource within its parent collection as described in https://google.aip.dev/122.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Project { get; set; } = default!;

    /// <summary>
    /// Block for endpoint.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Endpoint is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Endpoint block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Endpoint block(s) allowed")]
    [TerraformPropertyName("endpoint")]
    public TerraformList<TerraformBlock<GoogleApihubCurationEndpointBlock>>? Endpoint { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleApihubCurationTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The time at which the curation was created.
    /// </summary>
    [TerraformPropertyName("create_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CreateTime => new TerraformReference(this, "create_time");

    /// <summary>
    /// The error code of the last execution of the curation. The error code is
    /// populated only when the last execution state is failed.
    /// Possible values:
    /// ERROR_CODE_UNSPECIFIED
    /// INTERNAL_ERROR
    /// UNAUTHORIZED
    /// </summary>
    [TerraformPropertyName("last_execution_error_code")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> LastExecutionErrorCode => new TerraformReference(this, "last_execution_error_code");

    /// <summary>
    /// Error message describing the failure, if any, during the last execution of
    /// the curation.
    /// </summary>
    [TerraformPropertyName("last_execution_error_message")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> LastExecutionErrorMessage => new TerraformReference(this, "last_execution_error_message");

    /// <summary>
    /// The last execution state of the curation.
    /// Possible values:
    /// LAST_EXECUTION_STATE_UNSPECIFIED
    /// SUCCEEDED
    /// FAILED
    /// </summary>
    [TerraformPropertyName("last_execution_state")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> LastExecutionState => new TerraformReference(this, "last_execution_state");

    /// <summary>
    /// Identifier. The name of the curation.
    /// 
    /// Format:
    /// &#39;projects/{project}/locations/{location}/curations/{curation}&#39;
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Name => new TerraformReference(this, "name");

    /// <summary>
    /// The plugin instances and associated actions that are using the curation.
    /// Note: A particular curation could be used by multiple plugin instances or
    /// multiple actions in a plugin instance.
    /// </summary>
    [TerraformPropertyName("plugin_instance_actions")]
    // Output-only attribute - read-only reference
    public TerraformList<object> PluginInstanceActions => new TerraformReference(this, "plugin_instance_actions");

    /// <summary>
    /// The time at which the curation was last updated.
    /// </summary>
    [TerraformPropertyName("update_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> UpdateTime => new TerraformReference(this, "update_time");

}
