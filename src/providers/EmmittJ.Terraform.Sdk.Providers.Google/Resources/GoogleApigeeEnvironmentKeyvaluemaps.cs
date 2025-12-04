using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in GoogleApigeeEnvironmentKeyvaluemaps.
/// Nesting mode: single
/// </summary>
public class GoogleApigeeEnvironmentKeyvaluemapsTimeoutsBlock : TerraformBlock
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

}


/// <summary>
/// Represents a google_apigee_environment_keyvaluemaps Terraform resource.
/// Manages a google_apigee_environment_keyvaluemaps resource.
/// </summary>
public partial class GoogleApigeeEnvironmentKeyvaluemaps(string name) : TerraformResource("google_apigee_environment_keyvaluemaps", name)
{
    /// <summary>
    /// The Apigee environment group associated with the Apigee environment,
    /// in the format &#39;organizations/{{org_name}}/environments/{{env_name}}&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EnvId is required")]
    public required TerraformValue<string> EnvId
    {
        get => GetArgument<TerraformValue<string>>("env_id");
        set => SetArgument("env_id", value);
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
    /// Required. ID of the key value map.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleApigeeEnvironmentKeyvaluemapsTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleApigeeEnvironmentKeyvaluemapsTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
