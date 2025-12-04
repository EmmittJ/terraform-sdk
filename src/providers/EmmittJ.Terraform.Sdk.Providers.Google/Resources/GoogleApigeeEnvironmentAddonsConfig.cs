using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in GoogleApigeeEnvironmentAddonsConfig.
/// Nesting mode: single
/// </summary>
public class GoogleApigeeEnvironmentAddonsConfigTimeoutsBlock : TerraformBlock
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
/// Represents a google_apigee_environment_addons_config Terraform resource.
/// Manages a google_apigee_environment_addons_config resource.
/// </summary>
public partial class GoogleApigeeEnvironmentAddonsConfig(string name) : TerraformResource("google_apigee_environment_addons_config", name)
{
    /// <summary>
    /// Flag to enable/disable Analytics.
    /// </summary>
    public TerraformValue<bool>? AnalyticsEnabled
    {
        get => GetArgument<TerraformValue<bool>>("analytics_enabled");
        set => SetArgument("analytics_enabled", value);
    }

    /// <summary>
    /// The Apigee environment group associated with the Apigee environment,
    /// in the format &#39;organizations/{{org_name}}/environments/{{env_name}}&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EnvId is required")]
    public required TerraformValue<string> EnvId
    {
        get => GetRequiredArgument<TerraformValue<string>>("env_id");
        set => SetArgument("env_id", value);
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
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleApigeeEnvironmentAddonsConfigTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleApigeeEnvironmentAddonsConfigTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
