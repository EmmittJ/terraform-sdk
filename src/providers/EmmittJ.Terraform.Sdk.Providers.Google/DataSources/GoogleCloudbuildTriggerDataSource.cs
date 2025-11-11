using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_cloudbuild_trigger.
/// </summary>
public class GoogleCloudbuildTriggerDataSource : TerraformDataSource
{
    public GoogleCloudbuildTriggerDataSource(string name) : base("google_cloudbuild_trigger", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The [Cloud Build location](https://cloud.google.com/build/docs/locations) for the trigger.
    /// If not specified, &amp;quot;global&amp;quot; is used.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Project { get; set; }

    /// <summary>
    /// The unique identifier for the trigger.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TriggerId is required")]
    [TerraformPropertyName("trigger_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> TriggerId { get; set; }

    /// <summary>
    /// Configuration for manual approval to start a build invocation of this BuildTrigger.
    /// Builds created by this trigger will require approval before they execute.
    /// Any user with a Cloud Build Approver role for the project can approve a build.
    /// </summary>
    [TerraformPropertyName("approval_config")]
    // Output-only attribute - read-only reference
    public TerraformList<object> ApprovalConfig => new TerraformReference(this, "approval_config");

    /// <summary>
    /// BitbucketServerTriggerConfig describes the configuration of a trigger that creates a build whenever a Bitbucket Server event is received.
    /// </summary>
    [TerraformPropertyName("bitbucket_server_trigger_config")]
    // Output-only attribute - read-only reference
    public TerraformList<object> BitbucketServerTriggerConfig => new TerraformReference(this, "bitbucket_server_trigger_config");

    /// <summary>
    /// Contents of the build template. Either a filename or build template must be provided.
    /// </summary>
    [TerraformPropertyName("build")]
    // Output-only attribute - read-only reference
    public TerraformList<object> Build => new TerraformReference(this, "build");

    /// <summary>
    /// Time when the trigger was created.
    /// </summary>
    [TerraformPropertyName("create_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CreateTime => new TerraformReference(this, "create_time");

    /// <summary>
    /// Human-readable description of the trigger.
    /// </summary>
    [TerraformPropertyName("description")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Description => new TerraformReference(this, "description");

    /// <summary>
    /// Configuration for triggers that respond to Developer Connect events.
    /// </summary>
    [TerraformPropertyName("developer_connect_event_config")]
    // Output-only attribute - read-only reference
    public TerraformList<object> DeveloperConnectEventConfig => new TerraformReference(this, "developer_connect_event_config");

    /// <summary>
    /// Whether the trigger is disabled or not. If true, the trigger will never result in a build.
    /// </summary>
    [TerraformPropertyName("disabled")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> Disabled => new TerraformReference(this, "disabled");

    /// <summary>
    /// Path, from the source root, to a file whose contents is used for the template.
    /// Either a filename or build template must be provided. Set this only when using trigger_template or github.
    /// When using Pub/Sub, Webhook or Manual set the file name using git_file_source instead.
    /// </summary>
    [TerraformPropertyName("filename")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Filename => new TerraformReference(this, "filename");

    /// <summary>
    /// A Common Expression Language string. Used only with Pub/Sub and Webhook.
    /// </summary>
    [TerraformPropertyName("filter")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Filter => new TerraformReference(this, "filter");

    /// <summary>
    /// The file source describing the local or remote Build template.
    /// </summary>
    [TerraformPropertyName("git_file_source")]
    // Output-only attribute - read-only reference
    public TerraformList<object> GitFileSource => new TerraformReference(this, "git_file_source");

    /// <summary>
    /// Describes the configuration of a trigger that creates a build whenever a GitHub event is received.
    /// 
    /// One of &#39;trigger_template&#39;, &#39;github&#39;, &#39;pubsub_config&#39; or &#39;webhook_config&#39; must be provided.
    /// </summary>
    [TerraformPropertyName("github")]
    // Output-only attribute - read-only reference
    public TerraformList<object> Github => new TerraformReference(this, "github");

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
    [TerraformPropertyName("ignored_files")]
    // Output-only attribute - read-only reference
    public TerraformList<string> IgnoredFiles => new TerraformReference(this, "ignored_files");

    /// <summary>
    /// Build logs will be sent back to GitHub as part of the checkrun
    /// result.  Values can be INCLUDE_BUILD_LOGS_UNSPECIFIED or
    /// INCLUDE_BUILD_LOGS_WITH_STATUS Possible values: [&amp;quot;INCLUDE_BUILD_LOGS_UNSPECIFIED&amp;quot;, &amp;quot;INCLUDE_BUILD_LOGS_WITH_STATUS&amp;quot;]
    /// </summary>
    [TerraformPropertyName("include_build_logs")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> IncludeBuildLogs => new TerraformReference(this, "include_build_logs");

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
    [TerraformPropertyName("included_files")]
    // Output-only attribute - read-only reference
    public TerraformList<string> IncludedFiles => new TerraformReference(this, "included_files");

    /// <summary>
    /// Name of the trigger. Must be unique within the project.
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Name => new TerraformReference(this, "name");

    /// <summary>
    /// PubsubConfig describes the configuration of a trigger that creates
    /// a build whenever a Pub/Sub message is published.
    /// 
    /// One of &#39;trigger_template&#39;, &#39;github&#39;, &#39;pubsub_config&#39; &#39;webhook_config&#39; or &#39;source_to_build&#39; must be provided.
    /// </summary>
    [TerraformPropertyName("pubsub_config")]
    // Output-only attribute - read-only reference
    public TerraformList<object> PubsubConfig => new TerraformReference(this, "pubsub_config");

    /// <summary>
    /// The configuration of a trigger that creates a build whenever an event from Repo API is received.
    /// </summary>
    [TerraformPropertyName("repository_event_config")]
    // Output-only attribute - read-only reference
    public TerraformList<object> RepositoryEventConfig => new TerraformReference(this, "repository_event_config");

    /// <summary>
    /// The service account used for all user-controlled operations including
    /// triggers.patch, triggers.run, builds.create, and builds.cancel.
    /// 
    /// If no service account is set, then the standard Cloud Build service account
    /// ([PROJECT_NUM]@system.gserviceaccount.com) will be used instead.
    /// 
    /// Format: projects/{PROJECT_ID}/serviceAccounts/{ACCOUNT_ID_OR_EMAIL}
    /// </summary>
    [TerraformPropertyName("service_account")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ServiceAccount => new TerraformReference(this, "service_account");

    /// <summary>
    /// The repo and ref of the repository from which to build.
    /// This field is used only for those triggers that do not respond to SCM events.
    /// Triggers that respond to such events build source at whatever commit caused the event.
    /// This field is currently only used by Webhook, Pub/Sub, Manual, and Cron triggers.
    /// 
    /// One of &#39;trigger_template&#39;, &#39;github&#39;, &#39;pubsub_config&#39; &#39;webhook_config&#39; or &#39;source_to_build&#39; must be provided.
    /// </summary>
    [TerraformPropertyName("source_to_build")]
    // Output-only attribute - read-only reference
    public TerraformList<object> SourceToBuild => new TerraformReference(this, "source_to_build");

    /// <summary>
    /// Substitutions data for Build resource.
    /// </summary>
    [TerraformPropertyName("substitutions")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> Substitutions => new TerraformReference(this, "substitutions");

    /// <summary>
    /// Tags for annotation of a BuildTrigger
    /// </summary>
    [TerraformPropertyName("tags")]
    // Output-only attribute - read-only reference
    public TerraformList<string> Tags => new TerraformReference(this, "tags");

    /// <summary>
    /// Template describing the types of source changes to trigger a build.
    /// 
    /// Branch and tag names in trigger templates are interpreted as regular
    /// expressions. Any branch or tag change that matches that regular
    /// expression will trigger a build.
    /// 
    /// One of &#39;trigger_template&#39;, &#39;github&#39;, &#39;pubsub_config&#39;, &#39;webhook_config&#39; or &#39;source_to_build&#39; must be provided.
    /// </summary>
    [TerraformPropertyName("trigger_template")]
    // Output-only attribute - read-only reference
    public TerraformList<object> TriggerTemplate => new TerraformReference(this, "trigger_template");

    /// <summary>
    /// WebhookConfig describes the configuration of a trigger that creates
    /// a build whenever a webhook is sent to a trigger&#39;s webhook URL.
    /// 
    /// One of &#39;trigger_template&#39;, &#39;github&#39;, &#39;pubsub_config&#39; &#39;webhook_config&#39; or &#39;source_to_build&#39; must be provided.
    /// </summary>
    [TerraformPropertyName("webhook_config")]
    // Output-only attribute - read-only reference
    public TerraformList<object> WebhookConfig => new TerraformReference(this, "webhook_config");

}
