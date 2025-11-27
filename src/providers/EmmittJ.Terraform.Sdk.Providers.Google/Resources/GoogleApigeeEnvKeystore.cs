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
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
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
        get => new TerraformReference<string>(this, "env_id");
        set => SetArgument("env_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name of the newly created keystore.
    /// </summary>
    public TerraformValue<string>? Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Aliases in this keystore.
    /// </summary>
    public TerraformList<string> Aliases
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "aliases").ResolveNodes(ctx));
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleApigeeEnvKeystoreTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleApigeeEnvKeystoreTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
