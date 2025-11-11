using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzureadUsersDataSourceTimeoutsBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azuread_users.
/// </summary>
public class AzureadUsersDataSource : TerraformDataSource
{
    public AzureadUsersDataSource(string name) : base("azuread_users", name)
    {
    }

    /// <summary>
    /// The employee identifier assigned to the user by the organisation
    /// </summary>
    [TerraformPropertyName("employee_ids")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformList<string> EmployeeIds { get; set; } = default!;

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// Ignore missing users and return users that were found. The data source will still fail if no users are found
    /// </summary>
    [TerraformPropertyName("ignore_missing")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? IgnoreMissing { get; set; }

    /// <summary>
    /// The email aliases of the users
    /// </summary>
    [TerraformPropertyName("mail_nicknames")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformList<string> MailNicknames { get; set; } = default!;

    /// <summary>
    /// The SMTP address of the users
    /// </summary>
    [TerraformPropertyName("mails")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformList<string> Mails { get; set; } = default!;

    /// <summary>
    /// The object IDs of the users
    /// </summary>
    [TerraformPropertyName("object_ids")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformList<string> ObjectIds { get; set; } = default!;

    /// <summary>
    /// Fetch all users with no filter and return all that were found. The data source will still fail if no users are found.
    /// </summary>
    [TerraformPropertyName("return_all")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? ReturnAll { get; set; }

    /// <summary>
    /// The user principal names (UPNs) of the users
    /// </summary>
    [TerraformPropertyName("user_principal_names")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformList<string> UserPrincipalNames { get; set; } = default!;

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzureadUsersDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// A list of users
    /// </summary>
    [TerraformPropertyName("users")]
    // Output-only attribute - read-only reference
    public TerraformList<object> Users => new TerraformReference(this, "users");

}
