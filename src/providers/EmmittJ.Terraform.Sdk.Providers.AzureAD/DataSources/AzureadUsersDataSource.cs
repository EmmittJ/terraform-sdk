using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzureadUsersDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

}

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
        SetOutput("users");
        SetOutput("employee_ids");
        SetOutput("id");
        SetOutput("ignore_missing");
        SetOutput("mail_nicknames");
        SetOutput("mails");
        SetOutput("object_ids");
        SetOutput("return_all");
        SetOutput("user_principal_names");
    }

    /// <summary>
    /// The employee identifier assigned to the user by the organisation
    /// </summary>
    public List<TerraformProperty<string>> EmployeeIds
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("employee_ids");
        set => SetProperty("employee_ids", value);
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
    /// Ignore missing users and return users that were found. The data source will still fail if no users are found
    /// </summary>
    public TerraformProperty<bool> IgnoreMissing
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("ignore_missing");
        set => SetProperty("ignore_missing", value);
    }

    /// <summary>
    /// The email aliases of the users
    /// </summary>
    public List<TerraformProperty<string>> MailNicknames
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("mail_nicknames");
        set => SetProperty("mail_nicknames", value);
    }

    /// <summary>
    /// The SMTP address of the users
    /// </summary>
    public List<TerraformProperty<string>> Mails
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("mails");
        set => SetProperty("mails", value);
    }

    /// <summary>
    /// The object IDs of the users
    /// </summary>
    public List<TerraformProperty<string>> ObjectIds
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("object_ids");
        set => SetProperty("object_ids", value);
    }

    /// <summary>
    /// Fetch all users with no filter and return all that were found. The data source will still fail if no users are found.
    /// </summary>
    public TerraformProperty<bool> ReturnAll
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("return_all");
        set => SetProperty("return_all", value);
    }

    /// <summary>
    /// The user principal names (UPNs) of the users
    /// </summary>
    public List<TerraformProperty<string>> UserPrincipalNames
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("user_principal_names");
        set => SetProperty("user_principal_names", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzureadUsersDataSourceTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// A list of users
    /// </summary>
    public TerraformExpression Users => this["users"];

}
