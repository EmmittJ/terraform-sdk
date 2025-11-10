using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzureadUsersDataSourceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

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
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<List<TerraformProperty<string>>> EmployeeIds { get; set; } = new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "employee_ids");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// Ignore missing users and return users that were found. The data source will still fail if no users are found
    /// </summary>
    [TerraformPropertyName("ignore_missing")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? IgnoreMissing { get; set; }

    /// <summary>
    /// The email aliases of the users
    /// </summary>
    [TerraformPropertyName("mail_nicknames")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<List<TerraformProperty<string>>> MailNicknames { get; set; } = new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "mail_nicknames");

    /// <summary>
    /// The SMTP address of the users
    /// </summary>
    [TerraformPropertyName("mails")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<List<TerraformProperty<string>>> Mails { get; set; } = new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "mails");

    /// <summary>
    /// The object IDs of the users
    /// </summary>
    [TerraformPropertyName("object_ids")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<List<TerraformProperty<string>>> ObjectIds { get; set; } = new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "object_ids");

    /// <summary>
    /// Fetch all users with no filter and return all that were found. The data source will still fail if no users are found.
    /// </summary>
    [TerraformPropertyName("return_all")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? ReturnAll { get; set; }

    /// <summary>
    /// The user principal names (UPNs) of the users
    /// </summary>
    [TerraformPropertyName("user_principal_names")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<List<TerraformProperty<string>>> UserPrincipalNames { get; set; } = new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "user_principal_names");

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzureadUsersDataSourceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// A list of users
    /// </summary>
    [TerraformPropertyName("users")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Users => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "users");

}
