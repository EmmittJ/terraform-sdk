using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for endpoint in .
/// Nesting mode: list
/// </summary>
public class GoogleApihubCurationEndpointBlock : TerraformBlock
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleApihubCurationTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Manages a google_apihub_curation resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleApihubCuration : TerraformResource
{
    public GoogleApihubCuration(string name) : base("google_apihub_curation", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("create_time");
        SetOutput("last_execution_error_code");
        SetOutput("last_execution_error_message");
        SetOutput("last_execution_state");
        SetOutput("name");
        SetOutput("plugin_instance_actions");
        SetOutput("update_time");
        SetOutput("curation_id");
        SetOutput("description");
        SetOutput("display_name");
        SetOutput("id");
        SetOutput("location");
        SetOutput("project");
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
    public required TerraformProperty<string> CurationId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("curation_id");
        set => SetProperty("curation_id", value);
    }

    /// <summary>
    /// The description of the curation.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
    }

    /// <summary>
    /// The display name of the curation.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformProperty<string> DisplayName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("display_name");
        set => SetProperty("display_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// Resource ID segment making up resource &#39;name&#39;. It identifies the resource within its parent collection as described in https://google.aip.dev/122.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string> Project
    {
        get => GetRequiredOutput<TerraformProperty<string>>("project");
        set => SetProperty("project", value);
    }

    /// <summary>
    /// Block for endpoint.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Endpoint is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Endpoint block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Endpoint block(s) allowed")]
    public List<GoogleApihubCurationEndpointBlock>? Endpoint
    {
        set => SetProperty("endpoint", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleApihubCurationTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The time at which the curation was created.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// The error code of the last execution of the curation. The error code is
    /// populated only when the last execution state is failed.
    /// Possible values:
    /// ERROR_CODE_UNSPECIFIED
    /// INTERNAL_ERROR
    /// UNAUTHORIZED
    /// </summary>
    public TerraformExpression LastExecutionErrorCode => this["last_execution_error_code"];

    /// <summary>
    /// Error message describing the failure, if any, during the last execution of
    /// the curation.
    /// </summary>
    public TerraformExpression LastExecutionErrorMessage => this["last_execution_error_message"];

    /// <summary>
    /// The last execution state of the curation.
    /// Possible values:
    /// LAST_EXECUTION_STATE_UNSPECIFIED
    /// SUCCEEDED
    /// FAILED
    /// </summary>
    public TerraformExpression LastExecutionState => this["last_execution_state"];

    /// <summary>
    /// Identifier. The name of the curation.
    /// 
    /// Format:
    /// &#39;projects/{project}/locations/{location}/curations/{curation}&#39;
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// The plugin instances and associated actions that are using the curation.
    /// Note: A particular curation could be used by multiple plugin instances or
    /// multiple actions in a plugin instance.
    /// </summary>
    public TerraformExpression PluginInstanceActions => this["plugin_instance_actions"];

    /// <summary>
    /// The time at which the curation was last updated.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

}
