using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in GoogleApigeeEnvKeystore.
/// Nesting mode: single
/// </summary>
public class GoogleApigeeEnvKeystoreTimeoutsBlock : TerraformBlock
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
/// Represents a google_apigee_env_keystore Terraform resource.
/// Manages a google_apigee_env_keystore resource.
/// </summary>
public partial class GoogleApigeeEnvKeystore(string name) : TerraformResource("google_apigee_env_keystore", name)
{
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
    /// The name of the newly created keystore.
    /// </summary>
    public TerraformValue<string>? Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Aliases in this keystore.
    /// </summary>
    public TerraformList<string> Aliases
        => AsReference("aliases");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleApigeeEnvKeystoreTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleApigeeEnvKeystoreTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
