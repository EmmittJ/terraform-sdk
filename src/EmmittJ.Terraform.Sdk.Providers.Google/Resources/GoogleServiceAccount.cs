using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

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
        this.DeclareOutput("email");
        this.DeclareOutput("member");
        this.DeclareOutput("name");
        this.DeclareOutput("unique_id");
    }

    /// <summary>
    /// The account id that is used to generate the service account email address and a stable unique id. It is unique within a project, must be 6-30 characters long, and match the regular expression [a-z]([-a-z0-9]*[a-z0-9]) to comply with RFC1035. Changing this forces a new service account to be created.
    /// </summary>
    public string? AccountId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("account_id")?.Value;
        set => this.WithProperty("account_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// If set to true, skip service account creation if a service account with the same email already exists.
    /// </summary>
    public bool? CreateIgnoreAlreadyExists
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("create_ignore_already_exists")?.Value;
        set => this.WithProperty("create_ignore_already_exists", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// A text description of the service account. Must be less than or equal to 256 UTF-8 bytes.
    /// </summary>
    public string? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description")?.Value;
        set => this.WithProperty("description", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Whether the service account is disabled. Defaults to false
    /// </summary>
    public bool? Disabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("disabled")?.Value;
        set => this.WithProperty("disabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The display name for the service account. Can be updated without creating a new resource.
    /// </summary>
    public string? DisplayName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("display_name")?.Value;
        set => this.WithProperty("display_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The ID of the project that the service account will be created in. Defaults to the provider project configuration.
    /// </summary>
    public string? Project
    {
        get => GetProperty<TerraformLiteralProperty<string>>("project")?.Value;
        set => this.WithProperty("project", value == null ? null : new TerraformLiteralProperty<string>(value));
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
