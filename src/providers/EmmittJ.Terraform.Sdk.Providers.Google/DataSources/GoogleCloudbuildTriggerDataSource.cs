using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Represents a google_cloudbuild_trigger Terraform data source.
/// Retrieves information about a google_cloudbuild_trigger.
/// </summary>
public partial class GoogleCloudbuildTriggerDataSource(string name) : TerraformDataSource("google_cloudbuild_trigger", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The [Cloud Build location](https://cloud.google.com/build/docs/locations) for the trigger.
    /// If not specified, &amp;quot;global&amp;quot; is used.
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
    public TerraformValue<string>? Project
    {
        get => new TerraformReference<string>(this, "project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The unique identifier for the trigger.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TriggerId is required")]
    public required TerraformValue<string> TriggerId
    {
        get => new TerraformReference<string>(this, "trigger_id");
        set => SetArgument("trigger_id", value);
    }

    /// <summary>
    /// Configuration for manual approval to start a build invocation of this BuildTrigger.
    /// Builds created by this trigger will require approval before they execute.
    /// Any user with a Cloud Build Approver role for the project can approve a build.
    /// </summary>
    public TerraformList<TerraformMap<object>> ApprovalConfig
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "approval_config").ResolveNodes(ctx));
    }

    /// <summary>
    /// BitbucketServerTriggerConfig describes the configuration of a trigger that creates a build whenever a Bitbucket Server event is received.
    /// </summary>
    public TerraformList<TerraformMap<object>> BitbucketServerTriggerConfig
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "bitbucket_server_trigger_config").ResolveNodes(ctx));
    }

    /// <summary>
    /// Contents of the build template. Either a filename or build template must be provided.
    /// </summary>
    public TerraformList<TerraformMap<object>> Build
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "build").ResolveNodes(ctx));
    }

    /// <summary>
    /// Time when the trigger was created.
    /// </summary>
    public TerraformValue<string> CreateTime
    {
        get => new TerraformReference<string>(this, "create_time");
    }

    /// <summary>
    /// Human-readable description of the trigger.
    /// </summary>
    public TerraformValue<string> Description
    {
        get => new TerraformReference<string>(this, "description");
    }

    /// <summary>
    /// Configuration for triggers that respond to Developer Connect events.
    /// </summary>
    public TerraformList<TerraformMap<object>> DeveloperConnectEventConfig
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "developer_connect_event_config").ResolveNodes(ctx));
    }

    /// <summary>
    /// Whether the trigger is disabled or not. If true, the trigger will never result in a build.
    /// </summary>
    public TerraformValue<bool> Disabled
    {
        get => new TerraformReference<bool>(this, "disabled");
    }

    /// <summary>
    /// Path, from the source root, to a file whose contents is used for the template.
    /// Either a filename or build template must be provided. Set this only when using trigger_template or github.
    /// When using Pub/Sub, Webhook or Manual set the file name using git_file_source instead.
    /// </summary>
    public TerraformValue<string> Filename
    {
        get => new TerraformReference<string>(this, "filename");
    }

    /// <summary>
    /// A Common Expression Language string. Used only with Pub/Sub and Webhook.
    /// </summary>
    public TerraformValue<string> Filter
    {
        get => new TerraformReference<string>(this, "filter");
    }

    /// <summary>
    /// The file source describing the local or remote Build template.
    /// </summary>
    public TerraformList<TerraformMap<object>> GitFileSource
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "git_file_source").ResolveNodes(ctx));
    }

    /// <summary>
    /// Describes the configuration of a trigger that creates a build whenever a GitHub event is received.
    /// 
    /// One of &#39;trigger_template&#39;, &#39;github&#39;, &#39;pubsub_config&#39; or &#39;webhook_config&#39; must be provided.
    /// </summary>
    public TerraformList<TerraformMap<object>> Github
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "github").ResolveNodes(ctx));
    }

    /// <summary>
    /// ignoredFiles and includedFiles are file glob matches using https://golang.org/pkg/path/filepath/#Match
    /// extended with support for &#39;**&#39;.
    /// 
    /// If ignoredFiles and changed files are both empty, then they are not
    /// used to determine whether or not to trigger a build.
    /// 
    /// If ignoredFiles is not empty, then we ignore any files that match any
    /// of the ignored_file globs. If the change has no files that are outside
    /// of the ignoredFiles globs, then we do not trigger a build.
    /// </summary>
    public TerraformList<string> IgnoredFiles
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "ignored_files").ResolveNodes(ctx));
    }

    /// <summary>
    /// Build logs will be sent back to GitHub as part of the checkrun
    /// result.  Values can be INCLUDE_BUILD_LOGS_UNSPECIFIED or
    /// INCLUDE_BUILD_LOGS_WITH_STATUS Possible values: [&amp;quot;INCLUDE_BUILD_LOGS_UNSPECIFIED&amp;quot;, &amp;quot;INCLUDE_BUILD_LOGS_WITH_STATUS&amp;quot;]
    /// </summary>
    public TerraformValue<string> IncludeBuildLogs
    {
        get => new TerraformReference<string>(this, "include_build_logs");
    }

    /// <summary>
    /// ignoredFiles and includedFiles are file glob matches using https://golang.org/pkg/path/filepath/#Match
    /// extended with support for &#39;**&#39;.
    /// 
    /// If any of the files altered in the commit pass the ignoredFiles filter
    /// and includedFiles is empty, then as far as this filter is concerned, we
    /// should trigger the build.
    /// 
    /// If any of the files altered in the commit pass the ignoredFiles filter
    /// and includedFiles is not empty, then we make sure that at least one of
    /// those files matches a includedFiles glob. If not, then we do not trigger
    /// a build.
    /// </summary>
    public TerraformList<string> IncludedFiles
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "included_files").ResolveNodes(ctx));
    }

    /// <summary>
    /// Name of the trigger. Must be unique within the project.
    /// </summary>
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
    }

    /// <summary>
    /// PubsubConfig describes the configuration of a trigger that creates
    /// a build whenever a Pub/Sub message is published.
    /// 
    /// One of &#39;trigger_template&#39;, &#39;github&#39;, &#39;pubsub_config&#39; &#39;webhook_config&#39; or &#39;source_to_build&#39; must be provided.
    /// </summary>
    public TerraformList<TerraformMap<object>> PubsubConfig
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "pubsub_config").ResolveNodes(ctx));
    }

    /// <summary>
    /// The configuration of a trigger that creates a build whenever an event from Repo API is received.
    /// </summary>
    public TerraformList<TerraformMap<object>> RepositoryEventConfig
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "repository_event_config").ResolveNodes(ctx));
    }

    /// <summary>
    /// The service account used for all user-controlled operations including
    /// triggers.patch, triggers.run, builds.create, and builds.cancel.
    /// 
    /// If no service account is set, then the standard Cloud Build service account
    /// ([PROJECT_NUM]@system.gserviceaccount.com) will be used instead.
    /// 
    /// Format: projects/{PROJECT_ID}/serviceAccounts/{ACCOUNT_ID_OR_EMAIL}
    /// </summary>
    public TerraformValue<string> ServiceAccount
    {
        get => new TerraformReference<string>(this, "service_account");
    }

    /// <summary>
    /// The repo and ref of the repository from which to build.
    /// This field is used only for those triggers that do not respond to SCM events.
    /// Triggers that respond to such events build source at whatever commit caused the event.
    /// This field is currently only used by Webhook, Pub/Sub, Manual, and Cron triggers.
    /// 
    /// One of &#39;trigger_template&#39;, &#39;github&#39;, &#39;pubsub_config&#39; &#39;webhook_config&#39; or &#39;source_to_build&#39; must be provided.
    /// </summary>
    public TerraformList<TerraformMap<object>> SourceToBuild
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "source_to_build").ResolveNodes(ctx));
    }

    /// <summary>
    /// Substitutions data for Build resource.
    /// </summary>
    public TerraformMap<string> Substitutions
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "substitutions").ResolveNodes(ctx));
    }

    /// <summary>
    /// Tags for annotation of a BuildTrigger
    /// </summary>
    public TerraformList<string> Tags
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "tags").ResolveNodes(ctx));
    }

    /// <summary>
    /// Template describing the types of source changes to trigger a build.
    /// 
    /// Branch and tag names in trigger templates are interpreted as regular
    /// expressions. Any branch or tag change that matches that regular
    /// expression will trigger a build.
    /// 
    /// One of &#39;trigger_template&#39;, &#39;github&#39;, &#39;pubsub_config&#39;, &#39;webhook_config&#39; or &#39;source_to_build&#39; must be provided.
    /// </summary>
    public TerraformList<TerraformMap<object>> TriggerTemplate
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "trigger_template").ResolveNodes(ctx));
    }

    /// <summary>
    /// WebhookConfig describes the configuration of a trigger that creates
    /// a build whenever a webhook is sent to a trigger&#39;s webhook URL.
    /// 
    /// One of &#39;trigger_template&#39;, &#39;github&#39;, &#39;pubsub_config&#39; &#39;webhook_config&#39; or &#39;source_to_build&#39; must be provided.
    /// </summary>
    public TerraformList<TerraformMap<object>> WebhookConfig
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "webhook_config").ResolveNodes(ctx));
    }

}
