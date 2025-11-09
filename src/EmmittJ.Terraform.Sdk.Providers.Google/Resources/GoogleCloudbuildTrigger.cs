using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_cloudbuild_trigger resource.
/// </summary>
public class GoogleCloudbuildTrigger : TerraformResource
{
    public GoogleCloudbuildTrigger(string name) : base("google_cloudbuild_trigger", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("create_time");
        this.DeclareOutput("trigger_id");
    }

    /// <summary>
    /// Human-readable description of the trigger.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// Whether the trigger is disabled or not. If true, the trigger will never result in a build.
    /// </summary>
    public TerraformProperty<bool>? Disabled
    {
        get => GetProperty<TerraformProperty<bool>>("disabled");
        set => this.WithProperty("disabled", value);
    }

    /// <summary>
    /// Path, from the source root, to a file whose contents is used for the template.
    /// Either a filename or build template must be provided. Set this only when using trigger_template or github.
    /// When using Pub/Sub, Webhook or Manual set the file name using git_file_source instead.
    /// </summary>
    public TerraformProperty<string>? Filename
    {
        get => GetProperty<TerraformProperty<string>>("filename");
        set => this.WithProperty("filename", value);
    }

    /// <summary>
    /// A Common Expression Language string. Used only with Pub/Sub and Webhook.
    /// </summary>
    public TerraformProperty<string>? Filter
    {
        get => GetProperty<TerraformProperty<string>>("filter");
        set => this.WithProperty("filter", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
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
    public TerraformProperty<List<string>>? IgnoredFiles
    {
        get => GetProperty<TerraformProperty<List<string>>>("ignored_files");
        set => this.WithProperty("ignored_files", value);
    }

    /// <summary>
    /// Build logs will be sent back to GitHub as part of the checkrun
    /// result.  Values can be INCLUDE_BUILD_LOGS_UNSPECIFIED or
    /// INCLUDE_BUILD_LOGS_WITH_STATUS Possible values: [&amp;quot;INCLUDE_BUILD_LOGS_UNSPECIFIED&amp;quot;, &amp;quot;INCLUDE_BUILD_LOGS_WITH_STATUS&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? IncludeBuildLogs
    {
        get => GetProperty<TerraformProperty<string>>("include_build_logs");
        set => this.WithProperty("include_build_logs", value);
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
    public TerraformProperty<List<string>>? IncludedFiles
    {
        get => GetProperty<TerraformProperty<List<string>>>("included_files");
        set => this.WithProperty("included_files", value);
    }

    /// <summary>
    /// The [Cloud Build location](https://cloud.google.com/build/docs/locations) for the trigger.
    /// If not specified, &amp;quot;global&amp;quot; is used.
    /// </summary>
    public TerraformProperty<string>? Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// Name of the trigger. Must be unique within the project.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string>? Project
    {
        get => GetProperty<TerraformProperty<string>>("project");
        set => this.WithProperty("project", value);
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
    public TerraformProperty<string>? ServiceAccount
    {
        get => GetProperty<TerraformProperty<string>>("service_account");
        set => this.WithProperty("service_account", value);
    }

    /// <summary>
    /// Substitutions data for Build resource.
    /// </summary>
    public TerraformMapProperty<string>? Substitutions
    {
        get => GetProperty<TerraformMapProperty<string>>("substitutions");
        set => this.WithProperty("substitutions", value);
    }

    /// <summary>
    /// Tags for annotation of a BuildTrigger
    /// </summary>
    public TerraformProperty<List<string>>? Tags
    {
        get => GetProperty<TerraformProperty<List<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// Time when the trigger was created.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// The unique identifier for the trigger.
    /// </summary>
    public TerraformExpression TriggerId => this["trigger_id"];

}
