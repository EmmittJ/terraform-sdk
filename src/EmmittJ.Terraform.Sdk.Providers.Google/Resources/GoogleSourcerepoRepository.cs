using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for pubsub_configs in .
/// Nesting mode: set
/// </summary>
public class GoogleSourcerepoRepositoryPubsubConfigsBlock : TerraformBlock
{
    /// <summary>
    /// The format of the Cloud Pub/Sub messages.
    /// - PROTOBUF: The message payload is a serialized protocol buffer of SourceRepoEvent.
    /// - JSON: The message payload is a JSON string of SourceRepoEvent. Possible values: [&amp;quot;PROTOBUF&amp;quot;, &amp;quot;JSON&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MessageFormat is required")]
    public required TerraformProperty<string> MessageFormat
    {
        get => GetProperty<TerraformProperty<string>>("message_format");
        set => WithProperty("message_format", value);
    }

    /// <summary>
    /// Email address of the service account used for publishing Cloud Pub/Sub messages.
    /// This service account needs to be in the same project as the PubsubConfig. When added,
    /// the caller needs to have iam.serviceAccounts.actAs permission on this service account.
    /// If unspecified, it defaults to the compute engine default service account.
    /// </summary>
    public TerraformProperty<string>? ServiceAccountEmail
    {
        get => GetProperty<TerraformProperty<string>>("service_account_email");
        set => WithProperty("service_account_email", value);
    }

    /// <summary>
    /// The topic attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Topic is required")]
    public required TerraformProperty<string> Topic
    {
        get => GetProperty<TerraformProperty<string>>("topic");
        set => WithProperty("topic", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleSourcerepoRepositoryTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a google_sourcerepo_repository resource.
/// </summary>
public class GoogleSourcerepoRepository : TerraformResource
{
    public GoogleSourcerepoRepository(string name) : base("google_sourcerepo_repository", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("size");
        this.DeclareOutput("url");
    }

    /// <summary>
    /// If set to true, skip repository creation if a repository with the same name already exists.
    /// </summary>
    public TerraformProperty<bool>? CreateIgnoreAlreadyExists
    {
        get => GetProperty<TerraformProperty<bool>>("create_ignore_already_exists");
        set => this.WithProperty("create_ignore_already_exists", value);
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
    /// Resource name of the repository, of the form &#39;{{repo}}&#39;.
    /// The repo name may contain slashes. eg, &#39;name/with/slash&#39;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
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
    /// Block for pubsub_configs.
    /// Nesting mode: set
    /// </summary>
    public HashSet<GoogleSourcerepoRepositoryPubsubConfigsBlock>? PubsubConfigs
    {
        get => GetProperty<HashSet<GoogleSourcerepoRepositoryPubsubConfigsBlock>>("pubsub_configs");
        set => this.WithProperty("pubsub_configs", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleSourcerepoRepositoryTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleSourcerepoRepositoryTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The disk usage of the repo, in bytes.
    /// </summary>
    public TerraformExpression Size => this["size"];

    /// <summary>
    /// URL to clone the repository from Google Cloud Source Repositories.
    /// </summary>
    public TerraformExpression Url => this["url"];

}
