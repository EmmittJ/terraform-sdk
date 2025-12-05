using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for pubsub_configs in GoogleSourcerepoRepository.
/// Nesting mode: set
/// </summary>
public class GoogleSourcerepoRepositoryPubsubConfigsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "pubsub_configs";

    /// <summary>
    /// The format of the Cloud Pub/Sub messages.
    /// - PROTOBUF: The message payload is a serialized protocol buffer of SourceRepoEvent.
    /// - JSON: The message payload is a JSON string of SourceRepoEvent. Possible values: [&amp;quot;PROTOBUF&amp;quot;, &amp;quot;JSON&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MessageFormat is required")]
    public required TerraformValue<string> MessageFormat
    {
        get => GetRequiredArgument<TerraformValue<string>>("message_format");
        set => SetArgument("message_format", value);
    }

    /// <summary>
    /// Email address of the service account used for publishing Cloud Pub/Sub messages.
    /// This service account needs to be in the same project as the PubsubConfig. When added,
    /// the caller needs to have iam.serviceAccounts.actAs permission on this service account.
    /// If unspecified, it defaults to the compute engine default service account.
    /// </summary>
    public TerraformValue<string> ServiceAccountEmail
    {
        get => GetArgument<TerraformValue<string>>("service_account_email") ?? CreateReference("service_account_email");
        set => SetArgument("service_account_email", value);
    }

    /// <summary>
    /// The topic attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Topic is required")]
    public required TerraformValue<string> Topic
    {
        get => GetRequiredArgument<TerraformValue<string>>("topic");
        set => SetArgument("topic", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleSourcerepoRepository.
/// Nesting mode: single
/// </summary>
public class GoogleSourcerepoRepositoryTimeoutsBlock : TerraformBlock
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
/// Represents a google_sourcerepo_repository Terraform resource.
/// Manages a google_sourcerepo_repository resource.
/// </summary>
public partial class GoogleSourcerepoRepository(string name) : TerraformResource("google_sourcerepo_repository", name)
{
    /// <summary>
    /// If set to true, skip repository creation if a repository with the same name already exists.
    /// </summary>
    public TerraformValue<bool>? CreateIgnoreAlreadyExists
    {
        get => GetArgument<TerraformValue<bool>>("create_ignore_already_exists");
        set => SetArgument("create_ignore_already_exists", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Resource name of the repository, of the form &#39;{{repo}}&#39;.
    /// The repo name may contain slashes. eg, &#39;name/with/slash&#39;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => GetArgument<TerraformValue<string>>("project") ?? CreateReference("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The disk usage of the repo, in bytes.
    /// </summary>
    public TerraformValue<double> Size
        => CreateReference("size");

    /// <summary>
    /// URL to clone the repository from Google Cloud Source Repositories.
    /// </summary>
    public TerraformValue<string> Url
        => CreateReference("url");

    /// <summary>
    /// PubsubConfigs block (nesting mode: set).
    /// </summary>
    public TerraformSet<GoogleSourcerepoRepositoryPubsubConfigsBlock>? PubsubConfigs
    {
        get => GetArgument<TerraformSet<GoogleSourcerepoRepositoryPubsubConfigsBlock>>("pubsub_configs");
        set => SetArgument("pubsub_configs", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleSourcerepoRepositoryTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleSourcerepoRepositoryTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
