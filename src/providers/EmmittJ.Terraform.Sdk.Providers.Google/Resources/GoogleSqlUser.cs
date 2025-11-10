using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for password_policy in .
/// Nesting mode: list
/// </summary>
public class GoogleSqlUserPasswordPolicyBlock : ITerraformBlock
{
    /// <summary>
    /// Number of failed attempts allowed before the user get locked.
    /// </summary>
    [TerraformPropertyName("allowed_failed_attempts")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? AllowedFailedAttempts { get; set; }

    /// <summary>
    /// If true, the check that will lock user after too many failed login attempts will be enabled.
    /// </summary>
    [TerraformPropertyName("enable_failed_attempts_check")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? EnableFailedAttemptsCheck { get; set; }

    /// <summary>
    /// If true, the user must specify the current password before changing the password. This flag is supported only for MySQL.
    /// </summary>
    [TerraformPropertyName("enable_password_verification")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? EnablePasswordVerification { get; set; }

    /// <summary>
    /// Password expiration duration with one week grace period.
    /// </summary>
    [TerraformPropertyName("password_expiration_duration")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? PasswordExpirationDuration { get; set; }

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformPropertyName("status")]
    // Computed attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Status => new TerraformReferenceProperty<List<TerraformProperty<object>>>("", "status");

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleSqlUserTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Manages a google_sql_user resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleSqlUser : TerraformResource
{
    public GoogleSqlUser(string name) : base("google_sql_user", name)
    {
    }

    /// <summary>
    /// The deletion policy for the user. Setting ABANDON allows the resource
    /// 				to be abandoned rather than deleted. This is useful for Postgres, where users cannot be deleted from the API if they
    /// 				have been granted SQL roles. Possible values are: &amp;quot;ABANDON&amp;quot;.
    /// </summary>
    [TerraformPropertyName("deletion_policy")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DeletionPolicy { get; set; }

    /// <summary>
    /// The host the user can connect from. This is only supported for MySQL instances. Don&#39;t set this field for PostgreSQL instances. Can be an IP address. Changing this forces a new resource to be created.
    /// </summary>
    [TerraformPropertyName("host")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Host { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "host");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The name of the Cloud SQL instance. Changing this forces a new resource to be created.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Instance is required")]
    [TerraformPropertyName("instance")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Instance { get; set; }

    /// <summary>
    /// The name of the user. Changing this forces a new resource to be created.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The password for the user. Can be updated. For Postgres instances this is a Required field, unless type is set to
    /// 				either CLOUD_IAM_USER or CLOUD_IAM_SERVICE_ACCOUNT.
    /// </summary>
    [TerraformPropertyName("password")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Password { get; set; }

    /// <summary>
    /// The password for the user. Can be updated. For Postgres instances this is a Required field, unless type is set to
    /// 				either CLOUD_IAM_USER or CLOUD_IAM_SERVICE_ACCOUNT.
    /// </summary>
    [TerraformPropertyName("password_wo")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? PasswordWo { get; set; }

    /// <summary>
    /// The version of the password_wo.
    /// </summary>
    [TerraformPropertyName("password_wo_version")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? PasswordWoVersion { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs. If it is not provided, the provider project is used.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Project { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "project");

    /// <summary>
    /// The user type. It determines the method to authenticate the user during login.
    /// 				The default is the database&#39;s built-in user type.
    /// </summary>
    [TerraformPropertyName("type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Type { get; set; }

    /// <summary>
    /// Block for password_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PasswordPolicy block(s) allowed")]
    [TerraformPropertyName("password_policy")]
    public TerraformList<TerraformBlock<GoogleSqlUserPasswordPolicyBlock>>? PasswordPolicy { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleSqlUserTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The sql_server_user_details attribute.
    /// </summary>
    [TerraformPropertyName("sql_server_user_details")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> SqlServerUserDetails => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "sql_server_user_details");

}
