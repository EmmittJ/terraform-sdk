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
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The [Cloud Build location](https://cloud.google.com/build/docs/locations) for the trigger.
    /// If not specified, &amp;quot;global&amp;quot; is used.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetRequiredArgument<TerraformValue<string>>("location");
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
    /// The unique identifier for the trigger.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TriggerId is required")]
    public required TerraformValue<string> TriggerId
    {
        get => GetRequiredArgument<TerraformValue<string>>("trigger_id");
        set => SetArgument("trigger_id", value);
    }

    /// <summary>
    /// Configuration for manual approval to start a build invocation of this BuildTrigger.
    /// Builds created by this trigger will require approval before they execute.
    /// Any user with a Cloud Build Approver role for the project can approve a build.
    /// </summary>
    public TerraformList<TerraformMap<object>> ApprovalConfig
        => AsReference("approval_config");

    /// <summary>
    /// BitbucketServerTriggerConfig describes the configuration of a trigger that creates a build whenever a Bitbucket Server event is received.
    /// </summary>
    public TerraformList<TerraformMap<object>> BitbucketServerTriggerConfig
        => AsReference("bitbucket_server_trigger_config");

    /// <summary>
    /// Contents of the build template. Either a filename or build template must be provided.
    /// </summary>
    public TerraformList<TerraformMap<object>> Build
        => AsReference("build");

    /// <summary>
    /// Time when the trigger was created.
    /// </summary>
    public TerraformValue<string> CreateTime
        => AsReference("create_time");

    /// <summary>
    /// Human-readable description of the trigger.
    /// </summary>
    public TerraformValue<string> Description
        => AsReference("description");

    /// <summary>
    /// Configuration for triggers that respond to Developer Connect events.
    /// </summary>
    public TerraformList<TerraformMap<object>> DeveloperConnectEventConfig
        => AsReference("developer_connect_event_config");

    /// <summary>
    /// Whether the trigger is disabled or not. If true, the trigger will never result in a build.
    /// </summary>
    public TerraformValue<bool> Disabled
        => AsReference("disabled");

    /// <summary>
    /// Path, from the source root, to a file whose contents is used for the template.
    /// Either a filename or build template must be provided. Set this only when using trigger_template or github.
    /// When using Pub/Sub, Webhook or Manual set the file name using git_file_source instead.
    /// </summary>
    public TerraformValue<string> Filename
        => AsReference("filename");

    /// <summary>
    /// A Common Expression Language string. Used only with Pub/Sub and Webhook.
    /// </summary>
    public TerraformValue<string> Filter
        => AsReference("filter");

    /// <summary>
    /// The file source describing the local or remote Build template.
    /// </summary>
    public TerraformList<TerraformMap<object>> GitFileSource
        => AsReference("git_file_source");

    /// <summary>
    /// Describes the configuration of a trigger that creates a build whenever a GitHub event is received.
    /// 
    /// One of &#39;trigger_template&#39;, &#39;github&#39;, &#39;pubsub_config&#39; or &#39;webhook_config&#39; must be provided.
    /// </summary>
    public TerraformList<TerraformMap<object>> Github
        => AsReference("github");

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
        => AsReference("ignored_files");

    /// <summary>
    /// Build logs will be sent back to GitHub as part of the checkrun
    /// result.  Values can be INCLUDE_BUILD_LOGS_UNSPECIFIED or
    /// INCLUDE_BUILD_LOGS_WITH_STATUS Possible values: [&amp;quot;INCLUDE_BUILD_LOGS_UNSPECIFIED&amp;quot;, &amp;quot;INCLUDE_BUILD_LOGS_WITH_STATUS&amp;quot;]
    /// </summary>
    public TerraformValue<string> IncludeBuildLogs
        => AsReference("include_build_logs");

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
        => AsReference("included_files");

    /// <summary>
    /// Name of the trigger. Must be unique within the project.
    /// </summary>
    public TerraformValue<string> Name
        => AsReference("name");

    /// <summary>
    /// PubsubConfig describes the configuration of a trigger that creates
    /// a build whenever a Pub/Sub message is published.
    /// 
    /// One of &#39;trigger_template&#39;, &#39;github&#39;, &#39;pubsub_config&#39; &#39;webhook_config&#39; or &#39;source_to_build&#39; must be provided.
    /// </summary>
    public TerraformList<TerraformMap<object>> PubsubConfig
        => AsReference("pubsub_config");

    /// <summary>
    /// The configuration of a trigger that creates a build whenever an event from Repo API is received.
    /// </summary>
    public TerraformList<TerraformMap<object>> RepositoryEventConfig
        => AsReference("repository_event_config");

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
        => AsReference("service_account");

    /// <summary>
    /// The repo and ref of the repository from which to build.
    /// This field is used only for those triggers that do not respond to SCM events.
    /// Triggers that respond to such events build source at whatever commit caused the event.
    /// This field is currently only used by Webhook, Pub/Sub, Manual, and Cron triggers.
    /// 
    /// One of &#39;trigger_template&#39;, &#39;github&#39;, &#39;pubsub_config&#39; &#39;webhook_config&#39; or &#39;source_to_build&#39; must be provided.
    /// </summary>
    public TerraformList<TerraformMap<object>> SourceToBuild
        => AsReference("source_to_build");

    /// <summary>
    /// Substitutions data for Build resource.
    /// </summary>
    public TerraformMap<string> Substitutions
        => AsReference("substitutions");

    /// <summary>
    /// Tags for annotation of a BuildTrigger
    /// </summary>
    public TerraformList<string> Tags
        => AsReference("tags");

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
        => AsReference("trigger_template");

    /// <summary>
    /// WebhookConfig describes the configuration of a trigger that creates
    /// a build whenever a webhook is sent to a trigger&#39;s webhook URL.
    /// 
    /// One of &#39;trigger_template&#39;, &#39;github&#39;, &#39;pubsub_config&#39; &#39;webhook_config&#39; or &#39;source_to_build&#39; must be provided.
    /// </summary>
    public TerraformList<TerraformMap<object>> WebhookConfig
        => AsReference("webhook_config");

}
