using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in GoogleApigeeEnvReferences.
/// Nesting mode: single
/// </summary>
public class GoogleApigeeEnvReferencesTimeoutsBlock : TerraformBlock
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
/// Represents a google_apigee_env_references Terraform resource.
/// Manages a google_apigee_env_references resource.
/// </summary>
public partial class GoogleApigeeEnvReferences(string name) : TerraformResource("google_apigee_env_references", name)
{
    /// <summary>
    /// Optional. A human-readable description of this reference.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

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
    /// Required. The resource id of this reference. Values must match the regular expression [\w\s-.]+.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Required. The id of the resource to which this reference refers. Must be the id of a resource that exists in the parent environment and is of the given resourceType.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Refers is required")]
    public required TerraformValue<string> Refers
    {
        get => GetArgument<TerraformValue<string>>("refers");
        set => SetArgument("refers", value);
    }

    /// <summary>
    /// The type of resource referred to by this reference. Valid values are &#39;KeyStore&#39; or &#39;TrustStore&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceTypeAttribute is required")]
    public required TerraformValue<string> ResourceTypeAttribute
    {
        get => GetArgument<TerraformValue<string>>("resource_type");
        set => SetArgument("resource_type", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleApigeeEnvReferencesTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleApigeeEnvReferencesTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
