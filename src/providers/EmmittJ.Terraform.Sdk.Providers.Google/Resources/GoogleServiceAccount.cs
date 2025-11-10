using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleServiceAccountTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

}

/// <summary>
/// Manages a google_service_account resource.
/// </summary>
public class GoogleServiceAccount : TerraformResource
{
    public GoogleServiceAccount(string name) : base("google_service_account", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("email");
        SetOutput("member");
        SetOutput("name");
        SetOutput("unique_id");
        SetOutput("account_id");
        SetOutput("create_ignore_already_exists");
        SetOutput("description");
        SetOutput("disabled");
        SetOutput("display_name");
        SetOutput("id");
        SetOutput("project");
    }

    /// <summary>
    /// The account id that is used to generate the service account email address and a stable unique id. It is unique within a project, must be 6-30 characters long, and match the regular expression [a-z]([-a-z0-9]*[a-z0-9]) to comply with RFC1035. Changing this forces a new service account to be created.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccountId is required")]
    public required TerraformProperty<string> AccountId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("account_id");
        set => SetProperty("account_id", value);
    }

    /// <summary>
    /// If set to true, skip service account creation if a service account with the same email already exists.
    /// </summary>
    public TerraformProperty<bool> CreateIgnoreAlreadyExists
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("create_ignore_already_exists");
        set => SetProperty("create_ignore_already_exists", value);
    }

    /// <summary>
    /// A text description of the service account. Must be less than or equal to 256 UTF-8 bytes.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
    }

    /// <summary>
    /// Whether the service account is disabled. Defaults to false
    /// </summary>
    public TerraformProperty<bool> Disabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("disabled");
        set => SetProperty("disabled", value);
    }

    /// <summary>
    /// The display name for the service account. Can be updated without creating a new resource.
    /// </summary>
    public TerraformProperty<string> DisplayName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("display_name");
        set => SetProperty("display_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The ID of the project that the service account will be created in. Defaults to the provider project configuration.
    /// </summary>
    public TerraformProperty<string> Project
    {
        get => GetRequiredOutput<TerraformProperty<string>>("project");
        set => SetProperty("project", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleServiceAccountTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The e-mail address of the service account. This value should be referenced from any google_iam_policy data sources that would grant the service account privileges.
    /// </summary>
    public TerraformExpression Email => this["email"];

    /// <summary>
    /// The Identity of the service account in the form &#39;serviceAccount:{email}&#39;. This value is often used to refer to the service account in order to grant IAM permissions.
    /// </summary>
    public TerraformExpression Member => this["member"];

    /// <summary>
    /// The fully-qualified name of the service account.
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// The unique id of the service account.
    /// </summary>
    public TerraformExpression UniqueId => this["unique_id"];

}
