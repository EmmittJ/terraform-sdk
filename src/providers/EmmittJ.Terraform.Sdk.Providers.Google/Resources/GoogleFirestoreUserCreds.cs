using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleFirestoreUserCredsTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

}

/// <summary>
/// Manages a google_firestore_user_creds resource.
/// </summary>
public class GoogleFirestoreUserCreds : TerraformResource
{
    public GoogleFirestoreUserCreds(string name) : base("google_firestore_user_creds", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("create_time");
        SetOutput("resource_identity");
        SetOutput("secure_password");
        SetOutput("state");
        SetOutput("update_time");
        SetOutput("database");
        SetOutput("id");
        SetOutput("name");
        SetOutput("project");
    }

    /// <summary>
    /// The Firestore database ID.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Database is required")]
    public required TerraformProperty<string> Database
    {
        get => GetRequiredOutput<TerraformProperty<string>>("database");
        set => SetProperty("database", value);
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
    /// The ID to use for the user creds, which will become the final component
    /// of the user cred&#39;s resource name.
    /// 
    /// This value should be 4-63 characters. Valid characters are /[a-z][0-9]-/
    /// with first character a letter and the last a letter or a number. Must not
    /// be UUID-like /[0-9a-f]{8}(-[0-9a-f]{4}){3}-[0-9a-f]{12}/.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The project attribute.
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
    public GoogleFirestoreUserCredsTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The timestamp at which these user creds were created.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// Describes the Resource Identity principal.
    /// </summary>
    public TerraformExpression ResourceIdentity => this["resource_identity"];

    /// <summary>
    /// The plaintext server-generated password for the user creds.
    /// </summary>
    public TerraformExpression SecurePassword => this["secure_password"];

    /// <summary>
    /// The state of the user creds.
    /// </summary>
    public TerraformExpression State => this["state"];

    /// <summary>
    /// The timestamp at which these user creds were updated.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

}
