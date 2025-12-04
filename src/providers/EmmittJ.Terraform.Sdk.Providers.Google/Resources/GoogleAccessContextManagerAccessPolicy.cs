using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in GoogleAccessContextManagerAccessPolicy.
/// Nesting mode: single
/// </summary>
public class GoogleAccessContextManagerAccessPolicyTimeoutsBlock : TerraformBlock
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
/// Represents a google_access_context_manager_access_policy Terraform resource.
/// Manages a google_access_context_manager_access_policy resource.
/// </summary>
public partial class GoogleAccessContextManagerAccessPolicy(string name) : TerraformResource("google_access_context_manager_access_policy", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The parent of this AccessPolicy in the Cloud Resource Hierarchy.
    /// Format: &#39;organizations/{{organization_id}}&#39;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Parent is required")]
    public required TerraformValue<string> Parent
    {
        get => GetArgument<TerraformValue<string>>("parent");
        set => SetArgument("parent", value);
    }

    /// <summary>
    /// Folder or project on which this policy is applicable.
    /// Format: &#39;folders/{{folder_id}}&#39; or &#39;projects/{{project_number}}&#39;
    /// </summary>
    public TerraformList<string>? Scopes
    {
        get => GetArgument<TerraformList<string>>("scopes");
        set => SetArgument("scopes", value);
    }

    /// <summary>
    /// Human readable title. Does not affect behavior.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Title is required")]
    public required TerraformValue<string> Title
    {
        get => GetArgument<TerraformValue<string>>("title");
        set => SetArgument("title", value);
    }

    /// <summary>
    /// Time the AccessPolicy was created in UTC.
    /// </summary>
    public TerraformValue<string> CreateTime
        => AsReference("create_time");

    /// <summary>
    /// Resource name of the AccessPolicy. Format: &#39;{{policy_id}}&#39;
    /// </summary>
    public TerraformValue<string> Name
        => AsReference("name");

    /// <summary>
    /// Time the AccessPolicy was updated in UTC.
    /// </summary>
    public TerraformValue<string> UpdateTime
        => AsReference("update_time");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleAccessContextManagerAccessPolicyTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleAccessContextManagerAccessPolicyTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
