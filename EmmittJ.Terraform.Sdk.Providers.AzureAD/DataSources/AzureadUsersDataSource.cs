using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

/// <summary>
/// Retrieves information about a azuread_users.
/// </summary>
public class AzureadUsersDataSource : TerraformDataSource
{
    public AzureadUsersDataSource(string name) : base("azuread_users", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("users");
    }

    /// <summary>
    /// The employee identifier assigned to the user by the organisation
    /// </summary>
    public List<string>? EmployeeIds
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("employee_ids")?.Value;
        set => this.WithProperty("employee_ids", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
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
    /// Ignore missing users and return users that were found. The data source will still fail if no users are found
    /// </summary>
    public bool? IgnoreMissing
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("ignore_missing")?.Value;
        set => this.WithProperty("ignore_missing", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The email aliases of the users
    /// </summary>
    public List<string>? MailNicknames
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("mail_nicknames")?.Value;
        set => this.WithProperty("mail_nicknames", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    /// <summary>
    /// The SMTP address of the users
    /// </summary>
    public List<string>? Mails
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("mails")?.Value;
        set => this.WithProperty("mails", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    /// <summary>
    /// The object IDs of the users
    /// </summary>
    public List<string>? ObjectIds
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("object_ids")?.Value;
        set => this.WithProperty("object_ids", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    /// <summary>
    /// Fetch all users with no filter and return all that were found. The data source will still fail if no users are found.
    /// </summary>
    public bool? ReturnAll
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("return_all")?.Value;
        set => this.WithProperty("return_all", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The user principal names (UPNs) of the users
    /// </summary>
    public List<string>? UserPrincipalNames
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("user_principal_names")?.Value;
        set => this.WithProperty("user_principal_names", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    /// <summary>
    /// A list of users
    /// </summary>
    public TerraformExpression Users => this["users"];

}
