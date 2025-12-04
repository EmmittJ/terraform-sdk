using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for repositories in GoogleGeminiRepositoryGroup.
/// Nesting mode: list
/// </summary>
public class GoogleGeminiRepositoryGroupRepositoriesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "repositories";

    /// <summary>
    /// Required. The Git branch pattern used for indexing in RE2 syntax.
    /// See https://github.com/google/re2/wiki/syntax for syntax.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BranchPattern is required")]
    public required TerraformValue<string> BranchPattern
    {
        get => GetArgument<TerraformValue<string>>("branch_pattern");
        set => SetArgument("branch_pattern", value);
    }

    /// <summary>
    /// Required. The DeveloperConnect repository full resource name, relative resource name
    /// or resource URL to be indexed.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Resource is required")]
    public required TerraformValue<string> Resource
    {
        get => GetArgument<TerraformValue<string>>("resource");
        set => SetArgument("resource", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleGeminiRepositoryGroup.
/// Nesting mode: single
/// </summary>
public class GoogleGeminiRepositoryGroupTimeoutsBlock : TerraformBlock
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
/// Represents a google_gemini_repository_group Terraform resource.
/// Manages a google_gemini_repository_group resource.
/// </summary>
public partial class GoogleGeminiRepositoryGroup(string name) : TerraformResource("google_gemini_repository_group", name)
{
    /// <summary>
    /// Required. Id of the Code Repository Index.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CodeRepositoryIndex is required")]
    public required TerraformValue<string> CodeRepositoryIndex
    {
        get => GetArgument<TerraformValue<string>>("code_repository_index");
        set => SetArgument("code_repository_index", value);
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
    /// Optional. Labels as key value pairs.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public TerraformMap<string>? Labels
    {
        get => GetArgument<TerraformMap<string>>("labels");
        set => SetArgument("labels", value);
    }

    /// <summary>
    /// The location of the Code Repository Index, for example &#39;us-central1&#39;.
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
    /// Required. Id of the Repository Group.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RepositoryGroupId is required")]
    public required TerraformValue<string> RepositoryGroupId
    {
        get => GetArgument<TerraformValue<string>>("repository_group_id");
        set => SetArgument("repository_group_id", value);
    }

    /// <summary>
    /// Output only. Create time stamp.
    /// </summary>
    public TerraformValue<string> CreateTime
        => AsReference("create_time");

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveLabels
        => AsReference("effective_labels");

    /// <summary>
    /// Immutable. Identifier. Name of Repository Group.
    /// </summary>
    public TerraformValue<string> Name
        => AsReference("name");

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformMap<string> TerraformLabels
        => AsReference("terraform_labels");

    /// <summary>
    /// Output only. Update time stamp.
    /// </summary>
    public TerraformValue<string> UpdateTime
        => AsReference("update_time");

    /// <summary>
    /// Repositories block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Repositories is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Repositories block(s) required")]
    public required TerraformList<GoogleGeminiRepositoryGroupRepositoriesBlock> Repositories
    {
        get => GetRequiredArgument<TerraformList<GoogleGeminiRepositoryGroupRepositoriesBlock>>("repositories");
        set => SetArgument("repositories", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleGeminiRepositoryGroupTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleGeminiRepositoryGroupTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
