using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azuread;

/// <summary>
/// Block type for timeouts in AzureadUsersDataSource.
/// Nesting mode: single
/// </summary>
public class AzureadUsersDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

}


/// <summary>
/// Represents a azuread_users Terraform data source.
/// Retrieves information about a azuread_users.
/// </summary>
public partial class AzureadUsersDataSource(string name) : TerraformDataSource("azuread_users", name)
{
    /// <summary>
    /// The employee identifier assigned to the user by the organisation
    /// </summary>
    public TerraformList<string> EmployeeIds
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "employee_ids").ResolveNodes(ctx));
        set => SetArgument("employee_ids", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Ignore missing users and return users that were found. The data source will still fail if no users are found
    /// </summary>
    public TerraformValue<bool>? IgnoreMissing
    {
        get => new TerraformReference<bool>(this, "ignore_missing");
        set => SetArgument("ignore_missing", value);
    }

    /// <summary>
    /// The email aliases of the users
    /// </summary>
    public TerraformList<string> MailNicknames
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "mail_nicknames").ResolveNodes(ctx));
        set => SetArgument("mail_nicknames", value);
    }

    /// <summary>
    /// The SMTP address of the users
    /// </summary>
    public TerraformList<string> Mails
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "mails").ResolveNodes(ctx));
        set => SetArgument("mails", value);
    }

    /// <summary>
    /// The object IDs of the users
    /// </summary>
    public TerraformList<string> ObjectIds
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "object_ids").ResolveNodes(ctx));
        set => SetArgument("object_ids", value);
    }

    /// <summary>
    /// Fetch all users with no filter and return all that were found. The data source will still fail if no users are found.
    /// </summary>
    public TerraformValue<bool>? ReturnAll
    {
        get => new TerraformReference<bool>(this, "return_all");
        set => SetArgument("return_all", value);
    }

    /// <summary>
    /// The user principal names (UPNs) of the users
    /// </summary>
    public TerraformList<string> UserPrincipalNames
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "user_principal_names").ResolveNodes(ctx));
        set => SetArgument("user_principal_names", value);
    }

    /// <summary>
    /// A list of users
    /// </summary>
    public TerraformList<TerraformMap<object>> Users
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "users").ResolveNodes(ctx));
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzureadUsersDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzureadUsersDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
