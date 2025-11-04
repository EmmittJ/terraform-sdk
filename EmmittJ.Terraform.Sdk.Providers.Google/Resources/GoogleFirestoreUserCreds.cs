using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

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
        this.DeclareOutput("create_time");
        this.DeclareOutput("resource_identity");
        this.DeclareOutput("secure_password");
        this.DeclareOutput("state");
        this.DeclareOutput("update_time");
    }

    /// <summary>
    /// The Firestore database ID.
    /// </summary>
    public string? Database
    {
        get => GetProperty<TerraformLiteralProperty<string>>("database")?.Value;
        set => this.WithProperty("database", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The ID to use for the user creds, which will become the final component
    /// of the user cred&#39;s resource name.
    /// 
    /// This value should be 4-63 characters. Valid characters are /[a-z][0-9]-/
    /// with first character a letter and the last a letter or a number. Must not
    /// be UUID-like /[0-9a-f]{8}(-[0-9a-f]{4}){3}-[0-9a-f]{12}/.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public string? Project
    {
        get => GetProperty<TerraformLiteralProperty<string>>("project")?.Value;
        set => this.WithProperty("project", value == null ? null : new TerraformLiteralProperty<string>(value));
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
