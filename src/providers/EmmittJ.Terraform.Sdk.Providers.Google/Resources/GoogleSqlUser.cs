using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for password_policy in .
/// Nesting mode: list
/// </summary>
public partial class GoogleSqlUserPasswordPolicyBlock : TerraformBlockBase
{
    /// <summary>
    /// Number of failed attempts allowed before the user get locked.
    /// </summary>
    [TerraformProperty("allowed_failed_attempts")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? AllowedFailedAttempts { get; set; }

    /// <summary>
    /// If true, the check that will lock user after too many failed login attempts will be enabled.
    /// </summary>
    [TerraformProperty("enable_failed_attempts_check")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? EnableFailedAttemptsCheck { get; set; }

    /// <summary>
    /// If true, the user must specify the current password before changing the password. This flag is supported only for MySQL.
    /// </summary>
    [TerraformProperty("enable_password_verification")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? EnablePasswordVerification { get; set; }

    /// <summary>
    /// Password expiration duration with one week grace period.
    /// </summary>
    [TerraformProperty("password_expiration_duration")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? PasswordExpirationDuration { get; set; }


}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleSqlUserTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_sql_user resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleSqlUser : TerraformResource
{
    public GoogleSqlUser(string name) : base("google_sql_user", name)
    {
    }

    /// <summary>
    /// The deletion policy for the user. Setting ABANDON allows the resource
    /// 				to be abandoned rather than deleted. This is useful for Postgres, where users cannot be deleted from the API if they
    /// 				have been granted SQL roles. Possible values are: &amp;quot;ABANDON&amp;quot;.
    /// </summary>
    [TerraformProperty("deletion_policy")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? DeletionPolicy { get; set; }

    /// <summary>
    /// The host the user can connect from. This is only supported for MySQL instances. Don&#39;t set this field for PostgreSQL instances. Can be an IP address. Changing this forces a new resource to be created.
    /// </summary>
    [TerraformProperty("host")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Host { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name of the Cloud SQL instance. Changing this forces a new resource to be created.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Instance is required")]
    [TerraformProperty("instance")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Instance { get; set; }

    /// <summary>
    /// The name of the user. Changing this forces a new resource to be created.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The password for the user. Can be updated. For Postgres instances this is a Required field, unless type is set to
    /// 				either CLOUD_IAM_USER or CLOUD_IAM_SERVICE_ACCOUNT.
    /// </summary>
    [TerraformProperty("password")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Password { get; set; }

    /// <summary>
    /// The password for the user. Can be updated. For Postgres instances this is a Required field, unless type is set to
    /// 				either CLOUD_IAM_USER or CLOUD_IAM_SERVICE_ACCOUNT.
    /// </summary>
    [TerraformProperty("password_wo")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? PasswordWo { get; set; }

    /// <summary>
    /// The version of the password_wo.
    /// </summary>
    [TerraformProperty("password_wo_version")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? PasswordWoVersion { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs. If it is not provided, the provider project is used.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Project { get; set; }

    /// <summary>
    /// The user type. It determines the method to authenticate the user during login.
    /// 				The default is the database&#39;s built-in user type.
    /// </summary>
    [TerraformProperty("type")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Type { get; set; }

    /// <summary>
    /// Block for password_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PasswordPolicy block(s) allowed")]
    [TerraformProperty("password_policy")]
    public TerraformList<TerraformBlock<GoogleSqlUserPasswordPolicyBlock>>? PasswordPolicy { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<GoogleSqlUserTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The sql_server_user_details attribute.
    /// </summary>
    [TerraformProperty("sql_server_user_details")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> SqlServerUserDetails { get; }

}
