using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_cloudbuild_trigger.
/// </summary>
public partial class GoogleCloudbuildTriggerDataSource : TerraformDataSource
{
    public GoogleCloudbuildTriggerDataSource(string name) : base("google_cloudbuild_trigger", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The [Cloud Build location](https://cloud.google.com/build/docs/locations) for the trigger.
    /// If not specified, &amp;quot;global&amp;quot; is used.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Project { get; set; }

    /// <summary>
    /// The unique identifier for the trigger.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TriggerId is required")]
    [TerraformProperty("trigger_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> TriggerId { get; set; }

    /// <summary>
    /// Configuration for manual approval to start a build invocation of this BuildTrigger.
    /// Builds created by this trigger will require approval before they execute.
    /// Any user with a Cloud Build Approver role for the project can approve a build.
    /// </summary>
    [TerraformProperty("approval_config")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> ApprovalConfig { get; }

    /// <summary>
    /// BitbucketServerTriggerConfig describes the configuration of a trigger that creates a build whenever a Bitbucket Server event is received.
    /// </summary>
    [TerraformProperty("bitbucket_server_trigger_config")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> BitbucketServerTriggerConfig { get; }

    /// <summary>
    /// Contents of the build template. Either a filename or build template must be provided.
    /// </summary>
    [TerraformProperty("build")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> Build { get; }

    /// <summary>
    /// Time when the trigger was created.
    /// </summary>
    [TerraformProperty("create_time")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> CreateTime { get; }

    /// <summary>
    /// Human-readable description of the trigger.
    /// </summary>
    [TerraformProperty("description")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Description { get; }

    /// <summary>
    /// Configuration for triggers that respond to Developer Connect events.
    /// </summary>
    [TerraformProperty("developer_connect_event_config")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> DeveloperConnectEventConfig { get; }

    /// <summary>
    /// Whether the trigger is disabled or not. If true, the trigger will never result in a build.
    /// </summary>
    [TerraformProperty("disabled")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> Disabled { get; }

    /// <summary>
    /// Path, from the source root, to a file whose contents is used for the template.
    /// Either a filename or build template must be provided. Set this only when using trigger_template or github.
    /// When using Pub/Sub, Webhook or Manual set the file name using git_file_source instead.
    /// </summary>
    [TerraformProperty("filename")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Filename { get; }

    /// <summary>
    /// A Common Expression Language string. Used only with Pub/Sub and Webhook.
    /// </summary>
    [TerraformProperty("filter")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Filter { get; }

    /// <summary>
    /// The file source describing the local or remote Build template.
    /// </summary>
    [TerraformProperty("git_file_source")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> GitFileSource { get; }

    /// <summary>
    /// Describes the configuration of a trigger that creates a build whenever a GitHub event is received.
    /// 
    /// One of &#39;trigger_template&#39;, &#39;github&#39;, &#39;pubsub_config&#39; or &#39;webhook_config&#39; must be provided.
    /// </summary>
    [TerraformProperty("github")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> Github { get; }

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
    [TerraformProperty("ignored_files")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<string> IgnoredFiles { get; }

    /// <summary>
    /// Build logs will be sent back to GitHub as part of the checkrun
    /// result.  Values can be INCLUDE_BUILD_LOGS_UNSPECIFIED or
    /// INCLUDE_BUILD_LOGS_WITH_STATUS Possible values: [&amp;quot;INCLUDE_BUILD_LOGS_UNSPECIFIED&amp;quot;, &amp;quot;INCLUDE_BUILD_LOGS_WITH_STATUS&amp;quot;]
    /// </summary>
    [TerraformProperty("include_build_logs")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> IncludeBuildLogs { get; }

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
    [TerraformProperty("included_files")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<string> IncludedFiles { get; }

    /// <summary>
    /// Name of the trigger. Must be unique within the project.
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Name { get; }

    /// <summary>
    /// PubsubConfig describes the configuration of a trigger that creates
    /// a build whenever a Pub/Sub message is published.
    /// 
    /// One of &#39;trigger_template&#39;, &#39;github&#39;, &#39;pubsub_config&#39; &#39;webhook_config&#39; or &#39;source_to_build&#39; must be provided.
    /// </summary>
    [TerraformProperty("pubsub_config")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> PubsubConfig { get; }

    /// <summary>
    /// The configuration of a trigger that creates a build whenever an event from Repo API is received.
    /// </summary>
    [TerraformProperty("repository_event_config")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> RepositoryEventConfig { get; }

    /// <summary>
    /// The service account used for all user-controlled operations including
    /// triggers.patch, triggers.run, builds.create, and builds.cancel.
    /// 
    /// If no service account is set, then the standard Cloud Build service account
    /// ([PROJECT_NUM]@system.gserviceaccount.com) will be used instead.
    /// 
    /// Format: projects/{PROJECT_ID}/serviceAccounts/{ACCOUNT_ID_OR_EMAIL}
    /// </summary>
    [TerraformProperty("service_account")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ServiceAccount { get; }

    /// <summary>
    /// The repo and ref of the repository from which to build.
    /// This field is used only for those triggers that do not respond to SCM events.
    /// Triggers that respond to such events build source at whatever commit caused the event.
    /// This field is currently only used by Webhook, Pub/Sub, Manual, and Cron triggers.
    /// 
    /// One of &#39;trigger_template&#39;, &#39;github&#39;, &#39;pubsub_config&#39; &#39;webhook_config&#39; or &#39;source_to_build&#39; must be provided.
    /// </summary>
    [TerraformProperty("source_to_build")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> SourceToBuild { get; }

    /// <summary>
    /// Substitutions data for Build resource.
    /// </summary>
    [TerraformProperty("substitutions")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformMap<string> Substitutions { get; }

    /// <summary>
    /// Tags for annotation of a BuildTrigger
    /// </summary>
    [TerraformProperty("tags")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<string> Tags { get; }

    /// <summary>
    /// Template describing the types of source changes to trigger a build.
    /// 
    /// Branch and tag names in trigger templates are interpreted as regular
    /// expressions. Any branch or tag change that matches that regular
    /// expression will trigger a build.
    /// 
    /// One of &#39;trigger_template&#39;, &#39;github&#39;, &#39;pubsub_config&#39;, &#39;webhook_config&#39; or &#39;source_to_build&#39; must be provided.
    /// </summary>
    [TerraformProperty("trigger_template")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> TriggerTemplate { get; }

    /// <summary>
    /// WebhookConfig describes the configuration of a trigger that creates
    /// a build whenever a webhook is sent to a trigger&#39;s webhook URL.
    /// 
    /// One of &#39;trigger_template&#39;, &#39;github&#39;, &#39;pubsub_config&#39; &#39;webhook_config&#39; or &#39;source_to_build&#39; must be provided.
    /// </summary>
    [TerraformProperty("webhook_config")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> WebhookConfig { get; }

}
