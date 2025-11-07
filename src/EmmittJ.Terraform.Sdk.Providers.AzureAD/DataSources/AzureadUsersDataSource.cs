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
    public TerraformProperty<List<string>>? EmployeeIds
    {
        get => GetProperty<TerraformProperty<List<string>>>("employee_ids");
        set => this.WithProperty("employee_ids", value);
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
    /// Ignore missing users and return users that were found. The data source will still fail if no users are found
    /// </summary>
    public TerraformProperty<bool>? IgnoreMissing
    {
        get => GetProperty<TerraformProperty<bool>>("ignore_missing");
        set => this.WithProperty("ignore_missing", value);
    }

    /// <summary>
    /// The email aliases of the users
    /// </summary>
    public TerraformProperty<List<string>>? MailNicknames
    {
        get => GetProperty<TerraformProperty<List<string>>>("mail_nicknames");
        set => this.WithProperty("mail_nicknames", value);
    }

    /// <summary>
    /// The SMTP address of the users
    /// </summary>
    public TerraformProperty<List<string>>? Mails
    {
        get => GetProperty<TerraformProperty<List<string>>>("mails");
        set => this.WithProperty("mails", value);
    }

    /// <summary>
    /// The object IDs of the users
    /// </summary>
    public TerraformProperty<List<string>>? ObjectIds
    {
        get => GetProperty<TerraformProperty<List<string>>>("object_ids");
        set => this.WithProperty("object_ids", value);
    }

    /// <summary>
    /// Fetch all users with no filter and return all that were found. The data source will still fail if no users are found.
    /// </summary>
    public TerraformProperty<bool>? ReturnAll
    {
        get => GetProperty<TerraformProperty<bool>>("return_all");
        set => this.WithProperty("return_all", value);
    }

    /// <summary>
    /// The user principal names (UPNs) of the users
    /// </summary>
    public TerraformProperty<List<string>>? UserPrincipalNames
    {
        get => GetProperty<TerraformProperty<List<string>>>("user_principal_names");
        set => this.WithProperty("user_principal_names", value);
    }

    /// <summary>
    /// A list of users
    /// </summary>
    public TerraformExpression Users => this["users"];

}
