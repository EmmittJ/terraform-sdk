using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for source in GoogleFirebaseAppHostingBuild.
/// Nesting mode: list
/// </summary>
public class GoogleFirebaseAppHostingBuildSourceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "source";

    /// <summary>
    /// Codebase block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Codebase block(s) allowed")]
    public TerraformList<GoogleFirebaseAppHostingBuildSourceBlockCodebaseBlock>? Codebase
    {
        get => GetArgument<TerraformList<GoogleFirebaseAppHostingBuildSourceBlockCodebaseBlock>>("codebase");
        set => SetArgument("codebase", value);
    }

    /// <summary>
    /// Container block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Container block(s) allowed")]
    public TerraformList<GoogleFirebaseAppHostingBuildSourceBlockContainerBlock>? Container
    {
        get => GetArgument<TerraformList<GoogleFirebaseAppHostingBuildSourceBlockContainerBlock>>("container");
        set => SetArgument("container", value);
    }

}

/// <summary>
/// Block type for codebase in GoogleFirebaseAppHostingBuildSourceBlock.
/// Nesting mode: list
/// </summary>
public class GoogleFirebaseAppHostingBuildSourceBlockCodebaseBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "codebase";

    /// <summary>
    /// Version control metadata for a user associated with a resolved codebase.
    /// Currently assumes a Git user.
    /// </summary>
    public TerraformList<TerraformMap<object>> Author
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "author").ResolveNodes(ctx));
    }

    /// <summary>
    /// The branch in the codebase to build from, using the latest commit.
    /// </summary>
    public TerraformValue<string>? Branch
    {
        get => new TerraformReference<string>(this, "branch");
        set => SetArgument("branch", value);
    }

    /// <summary>
    /// The commit in the codebase to build from.
    /// </summary>
    public TerraformValue<string>? Commit
    {
        get => new TerraformReference<string>(this, "commit");
        set => SetArgument("commit", value);
    }

    /// <summary>
    /// The message of a codebase change.
    /// </summary>
    public TerraformValue<string> CommitMessage
    {
        get => new TerraformReference<string>(this, "commit_message");
    }

    /// <summary>
    /// The time the change was made.
    /// </summary>
    public TerraformValue<string> CommitTime
    {
        get => new TerraformReference<string>(this, "commit_time");
    }

    /// <summary>
    /// The human-friendly name to use for this Codebase when displaying a build.
    /// We use the first eight characters of the SHA-1 hash for GitHub.com.
    /// </summary>
    public TerraformValue<string> DisplayName
    {
        get => new TerraformReference<string>(this, "display_name");
    }

    /// <summary>
    /// The full SHA-1 hash of a Git commit, if available.
    /// </summary>
    public TerraformValue<string> Hash
    {
        get => new TerraformReference<string>(this, "hash");
    }

    /// <summary>
    /// A URI linking to the codebase on an hosting provider&#39;s website. May
    /// not be valid if the commit has been rebased or force-pushed out of
    /// existence in the linked repository.
    /// </summary>
    public TerraformValue<string> Uri
    {
        get => new TerraformReference<string>(this, "uri");
    }

}

/// <summary>
/// Block type for container in GoogleFirebaseAppHostingBuildSourceBlock.
/// Nesting mode: list
/// </summary>
public class GoogleFirebaseAppHostingBuildSourceBlockContainerBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "container";

    /// <summary>
    /// A URI representing a container for the backend to use.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Image is required")]
    public required TerraformValue<string> Image
    {
        get => new TerraformReference<string>(this, "image");
        set => SetArgument("image", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleFirebaseAppHostingBuild.
/// Nesting mode: single
/// </summary>
public class GoogleFirebaseAppHostingBuildTimeoutsBlock : TerraformBlock
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

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a google_firebase_app_hosting_build Terraform resource.
/// Manages a google_firebase_app_hosting_build resource.
/// </summary>
public partial class GoogleFirebaseAppHostingBuild(string name) : TerraformResource("google_firebase_app_hosting_build", name)
{
    /// <summary>
    /// Unstructured key value map that may be set by external tools to
    /// store and arbitrary metadata. They are not queryable and should be
    /// preserved when modifying objects.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the annotations present in your configuration.
    /// Please refer to the field &#39;effective_annotations&#39; for all of the annotations present on the resource.
    /// </summary>
    public TerraformMap<string>? Annotations
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "annotations").ResolveNodes(ctx));
        set => SetArgument("annotations", value);
    }

    /// <summary>
    /// The ID of the Backend that this Build applies to
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Backend is required")]
    public required TerraformValue<string> Backend
    {
        get => new TerraformReference<string>(this, "backend");
        set => SetArgument("backend", value);
    }

    /// <summary>
    /// The user-specified ID of the build being created.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BuildId is required")]
    public required TerraformValue<string> BuildId
    {
        get => new TerraformReference<string>(this, "build_id");
        set => SetArgument("build_id", value);
    }

    /// <summary>
    /// Human-readable name. 63 character limit.
    /// </summary>
    public TerraformValue<string>? DisplayName
    {
        get => new TerraformReference<string>(this, "display_name");
        set => SetArgument("display_name", value);
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
    /// Unstructured key value map that can be used to organize and categorize
    /// objects.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public TerraformMap<string>? Labels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "labels").ResolveNodes(ctx));
        set => SetArgument("labels", value);
    }

    /// <summary>
    /// The location of the Backend that this Build applies to
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => new TerraformReference<string>(this, "project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The location of the [Cloud Build
    /// logs](https://cloud.google.com/build/docs/view-build-results) for the build
    /// process.
    /// </summary>
    public TerraformValue<string> BuildLogsUri
    {
        get => new TerraformReference<string>(this, "build_logs_uri");
    }

    /// <summary>
    /// Time at which the build was created.
    /// </summary>
    public TerraformValue<string> CreateTime
    {
        get => new TerraformReference<string>(this, "create_time");
    }

    /// <summary>
    /// All of annotations (key/value pairs) present on the resource in GCP, including the annotations configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveAnnotations
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "effective_annotations").ResolveNodes(ctx));
    }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveLabels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "effective_labels").ResolveNodes(ctx));
    }

    /// <summary>
    /// The environment name of the backend when this build was created.
    /// </summary>
    public TerraformValue<string> Environment
    {
        get => new TerraformReference<string>(this, "environment");
    }

    /// <summary>
    /// The &#39;Status&#39; type defines a logical error model that is suitable for
    /// different programming environments, including REST APIs and RPC APIs. It is
    /// used by [gRPC](https://github.com/grpc). Each &#39;Status&#39; message contains
    /// three pieces of data: error code, error message, and error details.
    /// 
    /// You can find out more about this error model and how to work with it in the
    /// [API Design Guide](https://cloud.google.com/apis/design/errors).
    /// </summary>
    public TerraformList<TerraformMap<object>> Error
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "error").ResolveNodes(ctx));
    }

    /// <summary>
    /// The source of the error for the build, if in a &#39;FAILED&#39; state.
    /// Possible values:
    /// CLOUD_BUILD
    /// CLOUD_RUN
    /// </summary>
    public TerraformValue<string> ErrorSource
    {
        get => new TerraformReference<string>(this, "error_source");
    }

    /// <summary>
    /// Server-computed checksum based on other values; may be sent
    /// on update or delete to ensure operation is done on expected resource.
    /// </summary>
    public TerraformValue<string> Etag
    {
        get => new TerraformReference<string>(this, "etag");
    }

    /// <summary>
    /// The Artifact Registry
    /// [container
    /// image](https://cloud.google.com/artifact-registry/docs/reference/rest/v1/projects.locations.repositories.dockerImages)
    /// URI, used by the Cloud Run
    /// [&#39;revision&#39;](https://cloud.google.com/run/docs/reference/rest/v2/projects.locations.services.revisions)
    /// for this build.
    /// </summary>
    public TerraformValue<string> Image
    {
        get => new TerraformReference<string>(this, "image");
    }

    /// <summary>
    /// Identifier. The resource name of the build.
    /// 
    /// Format:
    /// 
    /// &#39;projects/{project}/locations/{locationId}/backends/{backendId}/builds/{buildId}&#39;.
    /// </summary>
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
    }

    /// <summary>
    /// The state of the build.
    /// Possible values:
    /// BUILDING
    /// BUILT
    /// DEPLOYING
    /// READY
    /// FAILED
    /// </summary>
    public TerraformValue<string> State
    {
        get => new TerraformReference<string>(this, "state");
    }

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformMap<string> TerraformLabels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "terraform_labels").ResolveNodes(ctx));
    }

    /// <summary>
    /// System-assigned, unique identifier.
    /// </summary>
    public TerraformValue<string> Uid
    {
        get => new TerraformReference<string>(this, "uid");
    }

    /// <summary>
    /// Time at which the build was last updated.
    /// </summary>
    public TerraformValue<string> UpdateTime
    {
        get => new TerraformReference<string>(this, "update_time");
    }

    /// <summary>
    /// Source block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Source is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Source block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Source block(s) allowed")]
    public required TerraformList<GoogleFirebaseAppHostingBuildSourceBlock> Source
    {
        get => GetRequiredArgument<TerraformList<GoogleFirebaseAppHostingBuildSourceBlock>>("source");
        set => SetArgument("source", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleFirebaseAppHostingBuildTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleFirebaseAppHostingBuildTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
