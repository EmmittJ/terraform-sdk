using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for endpoint in .
/// Nesting mode: list
/// </summary>
public class GoogleApihubCurationEndpointBlock : ITerraformBlock
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleApihubCurationTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

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
    public required TerraformProperty<TerraformProperty<string>> CurationId { get; set; }

    /// <summary>
    /// The description of the curation.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Description { get; set; }

    /// <summary>
    /// The display name of the curation.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    [TerraformPropertyName("display_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> DisplayName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// Resource ID segment making up resource &#39;name&#39;. It identifies the resource within its parent collection as described in https://google.aip.dev/122.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Location { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Project { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "project");

    /// <summary>
    /// Block for endpoint.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Endpoint is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Endpoint block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Endpoint block(s) allowed")]
    [TerraformPropertyName("endpoint")]
    public TerraformList<TerraformBlock<GoogleApihubCurationEndpointBlock>>? Endpoint { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleApihubCurationTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The time at which the curation was created.
    /// </summary>
    [TerraformPropertyName("create_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreateTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "create_time");

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
    public TerraformProperty<TerraformProperty<string>> LastExecutionErrorCode => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "last_execution_error_code");

    /// <summary>
    /// Error message describing the failure, if any, during the last execution of
    /// the curation.
    /// </summary>
    [TerraformPropertyName("last_execution_error_message")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> LastExecutionErrorMessage => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "last_execution_error_message");

    /// <summary>
    /// The last execution state of the curation.
    /// Possible values:
    /// LAST_EXECUTION_STATE_UNSPECIFIED
    /// SUCCEEDED
    /// FAILED
    /// </summary>
    [TerraformPropertyName("last_execution_state")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> LastExecutionState => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "last_execution_state");

    /// <summary>
    /// Identifier. The name of the curation.
    /// 
    /// Format:
    /// &#39;projects/{project}/locations/{location}/curations/{curation}&#39;
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Name => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name");

    /// <summary>
    /// The plugin instances and associated actions that are using the curation.
    /// Note: A particular curation could be used by multiple plugin instances or
    /// multiple actions in a plugin instance.
    /// </summary>
    [TerraformPropertyName("plugin_instance_actions")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> PluginInstanceActions => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "plugin_instance_actions");

    /// <summary>
    /// The time at which the curation was last updated.
    /// </summary>
    [TerraformPropertyName("update_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> UpdateTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "update_time");

}
