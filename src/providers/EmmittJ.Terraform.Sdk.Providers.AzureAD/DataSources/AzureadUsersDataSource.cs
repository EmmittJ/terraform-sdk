using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzureadUsersDataSourceTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azuread_users.
/// </summary>
public partial class AzureadUsersDataSource : TerraformDataSource
{
    public AzureadUsersDataSource(string name) : base("azuread_users", name)
    {
    }

    /// <summary>
    /// The employee identifier assigned to the user by the organisation
    /// </summary>
    [TerraformProperty("employee_ids")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformList<string> EmployeeIds { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Ignore missing users and return users that were found. The data source will still fail if no users are found
    /// </summary>
    [TerraformProperty("ignore_missing")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? IgnoreMissing { get; set; }

    /// <summary>
    /// The email aliases of the users
    /// </summary>
    [TerraformProperty("mail_nicknames")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformList<string> MailNicknames { get; set; }

    /// <summary>
    /// The SMTP address of the users
    /// </summary>
    [TerraformProperty("mails")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformList<string> Mails { get; set; }

    /// <summary>
    /// The object IDs of the users
    /// </summary>
    [TerraformProperty("object_ids")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformList<string> ObjectIds { get; set; }

    /// <summary>
    /// Fetch all users with no filter and return all that were found. The data source will still fail if no users are found.
    /// </summary>
    [TerraformProperty("return_all")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? ReturnAll { get; set; }

    /// <summary>
    /// The user principal names (UPNs) of the users
    /// </summary>
    [TerraformProperty("user_principal_names")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformList<string> UserPrincipalNames { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AzureadUsersDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// A list of users
    /// </summary>
    [TerraformProperty("users")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> Users { get; }

}
