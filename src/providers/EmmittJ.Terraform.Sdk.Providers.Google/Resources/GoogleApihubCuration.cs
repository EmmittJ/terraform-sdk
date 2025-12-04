using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for endpoint in GoogleApihubCuration.
/// Nesting mode: list
/// </summary>
public class GoogleApihubCurationEndpointBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "endpoint";

    /// <summary>
    /// ApplicationIntegrationEndpointDetails block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApplicationIntegrationEndpointDetails is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ApplicationIntegrationEndpointDetails block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ApplicationIntegrationEndpointDetails block(s) allowed")]
    public required TerraformList<GoogleApihubCurationEndpointBlockApplicationIntegrationEndpointDetailsBlock> ApplicationIntegrationEndpointDetails
    {
        get => GetRequiredArgument<TerraformList<GoogleApihubCurationEndpointBlockApplicationIntegrationEndpointDetailsBlock>>("application_integration_endpoint_details");
        set => SetArgument("application_integration_endpoint_details", value);
    }

}

/// <summary>
/// Block type for application_integration_endpoint_details in GoogleApihubCurationEndpointBlock.
/// Nesting mode: list
/// </summary>
public class GoogleApihubCurationEndpointBlockApplicationIntegrationEndpointDetailsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "application_integration_endpoint_details";

    /// <summary>
    /// The API trigger ID of the Application Integration workflow.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TriggerId is required")]
    public required TerraformValue<string> TriggerId
    {
        get => GetArgument<TerraformValue<string>>("trigger_id");
        set => SetArgument("trigger_id", value);
    }

    /// <summary>
    /// The endpoint URI should be a valid REST URI for triggering an Application
    /// Integration.
    /// Format:
    /// &#39;https://integrations.googleapis.com/v1/{name=projects/*/locations/*/integrations/*}:execute&#39;
    /// or
    /// &#39;https://{location}-integrations.googleapis.com/v1/{name=projects/*/locations/*/integrations/*}:execute&#39;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Uri is required")]
    public required TerraformValue<string> Uri
    {
        get => GetArgument<TerraformValue<string>>("uri");
        set => SetArgument("uri", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleApihubCuration.
/// Nesting mode: single
/// </summary>
public class GoogleApihubCurationTimeoutsBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a google_apihub_curation Terraform resource.
/// Manages a google_apihub_curation resource.
/// </summary>
public partial class GoogleApihubCuration(string name) : TerraformResource("google_apihub_curation", name)
{
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
    public required TerraformValue<string> CurationId
    {
        get => GetArgument<TerraformValue<string>>("curation_id");
        set => SetArgument("curation_id", value);
    }

    /// <summary>
    /// The description of the curation.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The display name of the curation.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformValue<string> DisplayName
    {
        get => GetArgument<TerraformValue<string>>("display_name");
        set => SetArgument("display_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Resource ID segment making up resource &#39;name&#39;. It identifies the resource within its parent collection as described in https://google.aip.dev/122.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string>? Project
    {
        get => GetArgument<TerraformValue<string>>("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The time at which the curation was created.
    /// </summary>
    public TerraformValue<string> CreateTime
        => AsReference("create_time");

    /// <summary>
    /// The error code of the last execution of the curation. The error code is
    /// populated only when the last execution state is failed.
    /// Possible values:
    /// ERROR_CODE_UNSPECIFIED
    /// INTERNAL_ERROR
    /// UNAUTHORIZED
    /// </summary>
    public TerraformValue<string> LastExecutionErrorCode
        => AsReference("last_execution_error_code");

    /// <summary>
    /// Error message describing the failure, if any, during the last execution of
    /// the curation.
    /// </summary>
    public TerraformValue<string> LastExecutionErrorMessage
        => AsReference("last_execution_error_message");

    /// <summary>
    /// The last execution state of the curation.
    /// Possible values:
    /// LAST_EXECUTION_STATE_UNSPECIFIED
    /// SUCCEEDED
    /// FAILED
    /// </summary>
    public TerraformValue<string> LastExecutionState
        => AsReference("last_execution_state");

    /// <summary>
    /// Identifier. The name of the curation.
    /// 
    /// Format:
    /// &#39;projects/{project}/locations/{location}/curations/{curation}&#39;
    /// </summary>
    public TerraformValue<string> Name
        => AsReference("name");

    /// <summary>
    /// The plugin instances and associated actions that are using the curation.
    /// Note: A particular curation could be used by multiple plugin instances or
    /// multiple actions in a plugin instance.
    /// </summary>
    public TerraformList<TerraformMap<object>> PluginInstanceActions
        => AsReference("plugin_instance_actions");

    /// <summary>
    /// The time at which the curation was last updated.
    /// </summary>
    public TerraformValue<string> UpdateTime
        => AsReference("update_time");

    /// <summary>
    /// Endpoint block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Endpoint is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Endpoint block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Endpoint block(s) allowed")]
    public required TerraformList<GoogleApihubCurationEndpointBlock> Endpoint
    {
        get => GetRequiredArgument<TerraformList<GoogleApihubCurationEndpointBlock>>("endpoint");
        set => SetArgument("endpoint", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleApihubCurationTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleApihubCurationTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
