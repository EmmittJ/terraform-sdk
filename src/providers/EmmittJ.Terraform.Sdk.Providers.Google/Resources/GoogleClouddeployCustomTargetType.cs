using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for custom_actions in GoogleClouddeployCustomTargetType.
/// Nesting mode: list
/// </summary>
public class GoogleClouddeployCustomTargetTypeCustomActionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "custom_actions";

    /// <summary>
    /// The Skaffold custom action responsible for deploy operations.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DeployAction is required")]
    public required TerraformValue<string> DeployAction
    {
        get => GetArgument<TerraformValue<string>>("deploy_action");
        set => SetArgument("deploy_action", value);
    }

    /// <summary>
    /// The Skaffold custom action responsible for render operations. If not provided then Cloud Deploy will perform the render operations via &#39;skaffold render&#39;.
    /// </summary>
    public TerraformValue<string>? RenderAction
    {
        get => GetArgument<TerraformValue<string>>("render_action");
        set => SetArgument("render_action", value);
    }

    /// <summary>
    /// IncludeSkaffoldModules block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleClouddeployCustomTargetTypeCustomActionsBlockIncludeSkaffoldModulesBlock>? IncludeSkaffoldModules
    {
        get => GetArgument<TerraformList<GoogleClouddeployCustomTargetTypeCustomActionsBlockIncludeSkaffoldModulesBlock>>("include_skaffold_modules");
        set => SetArgument("include_skaffold_modules", value);
    }

}

/// <summary>
/// Block type for include_skaffold_modules in GoogleClouddeployCustomTargetTypeCustomActionsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleClouddeployCustomTargetTypeCustomActionsBlockIncludeSkaffoldModulesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "include_skaffold_modules";

    /// <summary>
    /// The Skaffold Config modules to use from the specified source.
    /// </summary>
    public TerraformList<string>? Configs
    {
        get => GetArgument<TerraformList<string>>("configs");
        set => SetArgument("configs", value);
    }

    /// <summary>
    /// Git block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Git block(s) allowed")]
    public TerraformList<GoogleClouddeployCustomTargetTypeCustomActionsBlockIncludeSkaffoldModulesBlockGitBlock>? Git
    {
        get => GetArgument<TerraformList<GoogleClouddeployCustomTargetTypeCustomActionsBlockIncludeSkaffoldModulesBlockGitBlock>>("git");
        set => SetArgument("git", value);
    }

    /// <summary>
    /// GoogleCloudBuildRepo block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GoogleCloudBuildRepo block(s) allowed")]
    public TerraformList<GoogleClouddeployCustomTargetTypeCustomActionsBlockIncludeSkaffoldModulesBlockGoogleCloudBuildRepoBlock>? GoogleCloudBuildRepo
    {
        get => GetArgument<TerraformList<GoogleClouddeployCustomTargetTypeCustomActionsBlockIncludeSkaffoldModulesBlockGoogleCloudBuildRepoBlock>>("google_cloud_build_repo");
        set => SetArgument("google_cloud_build_repo", value);
    }

    /// <summary>
    /// GoogleCloudStorage block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GoogleCloudStorage block(s) allowed")]
    public TerraformList<GoogleClouddeployCustomTargetTypeCustomActionsBlockIncludeSkaffoldModulesBlockGoogleCloudStorageBlock>? GoogleCloudStorage
    {
        get => GetArgument<TerraformList<GoogleClouddeployCustomTargetTypeCustomActionsBlockIncludeSkaffoldModulesBlockGoogleCloudStorageBlock>>("google_cloud_storage");
        set => SetArgument("google_cloud_storage", value);
    }

}

/// <summary>
/// Block type for git in GoogleClouddeployCustomTargetTypeCustomActionsBlockIncludeSkaffoldModulesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleClouddeployCustomTargetTypeCustomActionsBlockIncludeSkaffoldModulesBlockGitBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "git";

    /// <summary>
    /// Relative path from the repository root to the Skaffold file.
    /// </summary>
    public TerraformValue<string>? Path
    {
        get => GetArgument<TerraformValue<string>>("path");
        set => SetArgument("path", value);
    }

    /// <summary>
    /// Git ref the package should be cloned from.
    /// </summary>
    public TerraformValue<string>? RefAttribute
    {
        get => GetArgument<TerraformValue<string>>("ref");
        set => SetArgument("ref", value);
    }

    /// <summary>
    /// Git repository the package should be cloned from.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Repo is required")]
    public required TerraformValue<string> Repo
    {
        get => GetArgument<TerraformValue<string>>("repo");
        set => SetArgument("repo", value);
    }

}

/// <summary>
/// Block type for google_cloud_build_repo in GoogleClouddeployCustomTargetTypeCustomActionsBlockIncludeSkaffoldModulesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleClouddeployCustomTargetTypeCustomActionsBlockIncludeSkaffoldModulesBlockGoogleCloudBuildRepoBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "google_cloud_build_repo";

    /// <summary>
    /// Relative path from the repository root to the Skaffold file.
    /// </summary>
    public TerraformValue<string>? Path
    {
        get => GetArgument<TerraformValue<string>>("path");
        set => SetArgument("path", value);
    }

    /// <summary>
    /// Branch or tag to use when cloning the repository.
    /// </summary>
    public TerraformValue<string>? RefAttribute
    {
        get => GetArgument<TerraformValue<string>>("ref");
        set => SetArgument("ref", value);
    }

    /// <summary>
    /// Cloud Build 2nd gen repository in the format of &#39;projects/&amp;lt;project&amp;gt;/locations/&amp;lt;location&amp;gt;/connections/&amp;lt;connection&amp;gt;/repositories/&amp;lt;repository&amp;gt;&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Repository is required")]
    public required TerraformValue<string> Repository
    {
        get => GetArgument<TerraformValue<string>>("repository");
        set => SetArgument("repository", value);
    }

}

/// <summary>
/// Block type for google_cloud_storage in GoogleClouddeployCustomTargetTypeCustomActionsBlockIncludeSkaffoldModulesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleClouddeployCustomTargetTypeCustomActionsBlockIncludeSkaffoldModulesBlockGoogleCloudStorageBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "google_cloud_storage";

    /// <summary>
    /// Relative path from the source to the Skaffold file.
    /// </summary>
    public TerraformValue<string>? Path
    {
        get => GetArgument<TerraformValue<string>>("path");
        set => SetArgument("path", value);
    }

    /// <summary>
    /// Cloud Storage source paths to copy recursively. For example, providing &#39;gs://my-bucket/dir/configs/*&#39; will result in Skaffold copying all files within the &#39;dir/configs&#39; directory in the bucket &#39;my-bucket&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Source is required")]
    public required TerraformValue<string> Source
    {
        get => GetArgument<TerraformValue<string>>("source");
        set => SetArgument("source", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleClouddeployCustomTargetType.
/// Nesting mode: single
/// </summary>
public class GoogleClouddeployCustomTargetTypeTimeoutsBlock : TerraformBlock
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
/// Represents a google_clouddeploy_custom_target_type Terraform resource.
/// Manages a google_clouddeploy_custom_target_type resource.
/// </summary>
public partial class GoogleClouddeployCustomTargetType(string name) : TerraformResource("google_clouddeploy_custom_target_type", name)
{
    /// <summary>
    /// User annotations. These attributes can only be set and used by the user, and not by Cloud Deploy. See https://google.aip.dev/128#annotations for more details such as format and size limitations.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the annotations present in your configuration.
    /// Please refer to the field &#39;effective_annotations&#39; for all of the annotations present on the resource.
    /// </summary>
    public TerraformMap<string>? Annotations
    {
        get => GetArgument<TerraformMap<string>>("annotations");
        set => SetArgument("annotations", value);
    }

    /// <summary>
    /// Description of the &#39;CustomTargetType&#39;. Max length is 255 characters.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
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
    /// Labels are attributes that can be set and used by both the user and by Cloud Deploy. Labels must meet the following constraints: * Keys and values can contain only lowercase letters, numeric characters, underscores, and dashes. * All characters must use UTF-8 encoding, and international characters are allowed. * Keys must start with a lowercase letter or international character. * Each resource is limited to a maximum of 64 labels. Both keys and values are additionally constrained to be &amp;lt;= 128 bytes.
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
    /// The location of the source.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// Name of the &#39;CustomTargetType&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
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
    /// Time at which the &#39;CustomTargetType&#39; was created.
    /// </summary>
    public TerraformValue<string> CreateTime
        => AsReference("create_time");

    /// <summary>
    /// Resource id of the &#39;CustomTargetType&#39;.
    /// </summary>
    public TerraformValue<string> CustomTargetTypeId
        => AsReference("custom_target_type_id");

    /// <summary>
    /// All of annotations (key/value pairs) present on the resource in GCP, including the annotations configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveAnnotations
        => AsReference("effective_annotations");

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveLabels
        => AsReference("effective_labels");

    /// <summary>
    /// The weak etag of the &#39;CustomTargetType&#39; resource. This checksum is computed by the server based on the value of other fields, and may be sent on update and delete requests to ensure the client has an up-to-date value before proceeding.
    /// </summary>
    public TerraformValue<string> Etag
        => AsReference("etag");

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformMap<string> TerraformLabels
        => AsReference("terraform_labels");

    /// <summary>
    /// Unique identifier of the &#39;CustomTargetType&#39;.
    /// </summary>
    public TerraformValue<string> Uid
        => AsReference("uid");

    /// <summary>
    /// Time at which the &#39;CustomTargetType&#39; was updated.
    /// </summary>
    public TerraformValue<string> UpdateTime
        => AsReference("update_time");

    /// <summary>
    /// CustomActions block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CustomActions block(s) allowed")]
    public TerraformList<GoogleClouddeployCustomTargetTypeCustomActionsBlock>? CustomActions
    {
        get => GetArgument<TerraformList<GoogleClouddeployCustomTargetTypeCustomActionsBlock>>("custom_actions");
        set => SetArgument("custom_actions", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleClouddeployCustomTargetTypeTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleClouddeployCustomTargetTypeTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
