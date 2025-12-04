using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in GoogleLoggingLogScope.
/// Nesting mode: single
/// </summary>
public class GoogleLoggingLogScopeTimeoutsBlock : TerraformBlock
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
/// Represents a google_logging_log_scope Terraform resource.
/// Manages a google_logging_log_scope resource.
/// </summary>
public partial class GoogleLoggingLogScope(string name) : TerraformResource("google_logging_log_scope", name)
{
    /// <summary>
    /// Describes this log scopes.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The location of the resource. The only supported location is global so far.
    /// </summary>
    public TerraformValue<string> Location
    {
        get => GetArgument<TerraformValue<string>>("location") ?? AsReference("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The resource name of the log scope. For example: \&#39;projects/my-project/locations/global/logScopes/my-log-scope\&#39;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The parent of the resource.
    /// </summary>
    public TerraformValue<string> Parent
    {
        get => GetArgument<TerraformValue<string>>("parent") ?? AsReference("parent");
        set => SetArgument("parent", value);
    }

    /// <summary>
    /// Names of one or more parent resources : *  \&#39;projects/[PROJECT_ID]\&#39; May alternatively be one or more views : * \&#39;projects/[PROJECT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]/views/[VIEW_ID]\&#39; A log scope can include a maximum of 50 projects and a maximum of 100 resources in total.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceNames is required")]
    public TerraformList<string>? ResourceNames
    {
        get => GetArgument<TerraformList<string>>("resource_names");
        set => SetArgument("resource_names", value);
    }

    /// <summary>
    /// Output only. The creation timestamp of the log scopes.
    /// </summary>
    public TerraformValue<string> CreateTime
        => AsReference("create_time");

    /// <summary>
    /// Output only. The last update timestamp of the log scopes.
    /// </summary>
    public TerraformValue<string> UpdateTime
        => AsReference("update_time");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleLoggingLogScopeTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleLoggingLogScopeTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
