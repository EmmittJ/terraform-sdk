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
    public TerraformLiteralProperty<List<string>>? EmployeeIds
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("employee_ids");
        set => this.WithProperty("employee_ids", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// Ignore missing users and return users that were found. The data source will still fail if no users are found
    /// </summary>
    public TerraformLiteralProperty<bool>? IgnoreMissing
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("ignore_missing");
        set => this.WithProperty("ignore_missing", value);
    }

    /// <summary>
    /// The email aliases of the users
    /// </summary>
    public TerraformLiteralProperty<List<string>>? MailNicknames
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("mail_nicknames");
        set => this.WithProperty("mail_nicknames", value);
    }

    /// <summary>
    /// The SMTP address of the users
    /// </summary>
    public TerraformLiteralProperty<List<string>>? Mails
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("mails");
        set => this.WithProperty("mails", value);
    }

    /// <summary>
    /// The object IDs of the users
    /// </summary>
    public TerraformLiteralProperty<List<string>>? ObjectIds
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("object_ids");
        set => this.WithProperty("object_ids", value);
    }

    /// <summary>
    /// Fetch all users with no filter and return all that were found. The data source will still fail if no users are found.
    /// </summary>
    public TerraformLiteralProperty<bool>? ReturnAll
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("return_all");
        set => this.WithProperty("return_all", value);
    }

    /// <summary>
    /// The user principal names (UPNs) of the users
    /// </summary>
    public TerraformLiteralProperty<List<string>>? UserPrincipalNames
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("user_principal_names");
        set => this.WithProperty("user_principal_names", value);
    }

    /// <summary>
    /// A list of users
    /// </summary>
    public TerraformExpression Users => this["users"];

}
