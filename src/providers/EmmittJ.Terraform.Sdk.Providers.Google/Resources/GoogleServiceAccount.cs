using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in GoogleServiceAccount.
/// Nesting mode: single
/// </summary>
public class GoogleServiceAccountTimeoutsBlock : TerraformBlock
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

}


/// <summary>
/// Represents a google_service_account Terraform resource.
/// Manages a google_service_account resource.
/// </summary>
public partial class GoogleServiceAccount(string name) : TerraformResource("google_service_account", name)
{
    /// <summary>
    /// The account id that is used to generate the service account email address and a stable unique id. It is unique within a project, must be 6-30 characters long, and match the regular expression [a-z]([-a-z0-9]*[a-z0-9]) to comply with RFC1035. Changing this forces a new service account to be created.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccountId is required")]
    public required TerraformValue<string> AccountId
    {
        get => GetArgument<TerraformValue<string>>("account_id");
        set => SetArgument("account_id", value);
    }

    /// <summary>
    /// If set to true, skip service account creation if a service account with the same email already exists.
    /// </summary>
    public TerraformValue<bool>? CreateIgnoreAlreadyExists
    {
        get => GetArgument<TerraformValue<bool>>("create_ignore_already_exists");
        set => SetArgument("create_ignore_already_exists", value);
    }

    /// <summary>
    /// A text description of the service account. Must be less than or equal to 256 UTF-8 bytes.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// Whether the service account is disabled. Defaults to false
    /// </summary>
    public TerraformValue<bool>? Disabled
    {
        get => GetArgument<TerraformValue<bool>>("disabled");
        set => SetArgument("disabled", value);
    }

    /// <summary>
    /// The display name for the service account. Can be updated without creating a new resource.
    /// </summary>
    public TerraformValue<string>? DisplayName
    {
        get => GetArgument<TerraformValue<string>>("display_name");
        set => SetArgument("display_name", value);
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
    /// The ID of the project that the service account will be created in. Defaults to the provider project configuration.
    /// </summary>
    public TerraformValue<string>? Project
    {
        get => GetArgument<TerraformValue<string>>("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The e-mail address of the service account. This value should be referenced from any google_iam_policy data sources that would grant the service account privileges.
    /// </summary>
    public TerraformValue<string> Email
        => AsReference("email");

    /// <summary>
    /// The Identity of the service account in the form &#39;serviceAccount:{email}&#39;. This value is often used to refer to the service account in order to grant IAM permissions.
    /// </summary>
    public TerraformValue<string> Member
        => AsReference("member");

    /// <summary>
    /// The fully-qualified name of the service account.
    /// </summary>
    public TerraformValue<string> Name
        => AsReference("name");

    /// <summary>
    /// The unique id of the service account.
    /// </summary>
    public TerraformValue<string> UniqueId
        => AsReference("unique_id");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleServiceAccountTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleServiceAccountTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
