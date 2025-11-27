using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in GoogleApigeeEnvironmentKeyvaluemapsEntries.
/// Nesting mode: single
/// </summary>
public class GoogleApigeeEnvironmentKeyvaluemapsEntriesTimeoutsBlock : TerraformBlock
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
/// Represents a google_apigee_environment_keyvaluemaps_entries Terraform resource.
/// Manages a google_apigee_environment_keyvaluemaps_entries resource.
/// </summary>
public partial class GoogleApigeeEnvironmentKeyvaluemapsEntries(string name) : TerraformResource("google_apigee_environment_keyvaluemaps_entries", name)
{
    /// <summary>
    /// The Apigee environment keyvalumaps Id associated with the Apigee environment,
    /// in the format &#39;organizations/{{org_name}}/environments/{{env_name}}/keyvaluemaps/{{keyvaluemap_name}}&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EnvKeyvaluemapId is required")]
    public required TerraformValue<string> EnvKeyvaluemapId
    {
        get => new TerraformReference<string>(this, "env_keyvaluemap_id");
        set => SetArgument("env_keyvaluemap_id", value);
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
    /// Required. Resource URI that can be used to identify the scope of the key value map entries.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Required. Data or payload that is being retrieved and associated with the unique key.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => new TerraformReference<string>(this, "value");
        set => SetArgument("value", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleApigeeEnvironmentKeyvaluemapsEntriesTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleApigeeEnvironmentKeyvaluemapsEntriesTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
