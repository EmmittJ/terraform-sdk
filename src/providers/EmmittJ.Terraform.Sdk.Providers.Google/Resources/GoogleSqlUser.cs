using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for password_policy in .
/// Nesting mode: list
/// </summary>
public class GoogleSqlUserPasswordPolicyBlock : TerraformBlock
{
    /// <summary>
    /// Number of failed attempts allowed before the user get locked.
    /// </summary>
    public TerraformProperty<double>? AllowedFailedAttempts
    {
        set => SetProperty("allowed_failed_attempts", value);
    }

    /// <summary>
    /// If true, the check that will lock user after too many failed login attempts will be enabled.
    /// </summary>
    public TerraformProperty<bool>? EnableFailedAttemptsCheck
    {
        set => SetProperty("enable_failed_attempts_check", value);
    }

    /// <summary>
    /// If true, the user must specify the current password before changing the password. This flag is supported only for MySQL.
    /// </summary>
    public TerraformProperty<bool>? EnablePasswordVerification
    {
        set => SetProperty("enable_password_verification", value);
    }

    /// <summary>
    /// Password expiration duration with one week grace period.
    /// </summary>
    public TerraformProperty<string>? PasswordExpirationDuration
    {
        set => SetProperty("password_expiration_duration", value);
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public List<TerraformProperty<object>>? Status
    {
        set => SetProperty("status", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleSqlUserTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Manages a google_sql_user resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleSqlUser : TerraformResource
{
    public GoogleSqlUser(string name) : base("google_sql_user", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("sql_server_user_details");
        SetOutput("deletion_policy");
        SetOutput("host");
        SetOutput("id");
        SetOutput("instance");
        SetOutput("name");
        SetOutput("password");
        SetOutput("password_wo");
        SetOutput("password_wo_version");
        SetOutput("project");
        SetOutput("type");
    }

    /// <summary>
    /// The deletion policy for the user. Setting ABANDON allows the resource
    /// 				to be abandoned rather than deleted. This is useful for Postgres, where users cannot be deleted from the API if they
    /// 				have been granted SQL roles. Possible values are: &amp;quot;ABANDON&amp;quot;.
    /// </summary>
    public TerraformProperty<string> DeletionPolicy
    {
        get => GetRequiredOutput<TerraformProperty<string>>("deletion_policy");
        set => SetProperty("deletion_policy", value);
    }

    /// <summary>
    /// The host the user can connect from. This is only supported for MySQL instances. Don&#39;t set this field for PostgreSQL instances. Can be an IP address. Changing this forces a new resource to be created.
    /// </summary>
    public TerraformProperty<string> Host
    {
        get => GetRequiredOutput<TerraformProperty<string>>("host");
        set => SetProperty("host", value);
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
    /// The name of the Cloud SQL instance. Changing this forces a new resource to be created.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Instance is required")]
    public required TerraformProperty<string> Instance
    {
        get => GetRequiredOutput<TerraformProperty<string>>("instance");
        set => SetProperty("instance", value);
    }

    /// <summary>
    /// The name of the user. Changing this forces a new resource to be created.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The password for the user. Can be updated. For Postgres instances this is a Required field, unless type is set to
    /// 				either CLOUD_IAM_USER or CLOUD_IAM_SERVICE_ACCOUNT.
    /// </summary>
    public TerraformProperty<string> Password
    {
        get => GetRequiredOutput<TerraformProperty<string>>("password");
        set => SetProperty("password", value);
    }

    /// <summary>
    /// The password for the user. Can be updated. For Postgres instances this is a Required field, unless type is set to
    /// 				either CLOUD_IAM_USER or CLOUD_IAM_SERVICE_ACCOUNT.
    /// </summary>
    public TerraformProperty<string> PasswordWo
    {
        get => GetRequiredOutput<TerraformProperty<string>>("password_wo");
        set => SetProperty("password_wo", value);
    }

    /// <summary>
    /// The version of the password_wo.
    /// </summary>
    public TerraformProperty<double> PasswordWoVersion
    {
        get => GetRequiredOutput<TerraformProperty<double>>("password_wo_version");
        set => SetProperty("password_wo_version", value);
    }

    /// <summary>
    /// The ID of the project in which the resource belongs. If it is not provided, the provider project is used.
    /// </summary>
    public TerraformProperty<string> Project
    {
        get => GetRequiredOutput<TerraformProperty<string>>("project");
        set => SetProperty("project", value);
    }

    /// <summary>
    /// The user type. It determines the method to authenticate the user during login.
    /// 				The default is the database&#39;s built-in user type.
    /// </summary>
    public TerraformProperty<string> Type
    {
        get => GetRequiredOutput<TerraformProperty<string>>("type");
        set => SetProperty("type", value);
    }

    /// <summary>
    /// Block for password_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PasswordPolicy block(s) allowed")]
    public List<GoogleSqlUserPasswordPolicyBlock>? PasswordPolicy
    {
        set => SetProperty("password_policy", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleSqlUserTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The sql_server_user_details attribute.
    /// </summary>
    public TerraformExpression SqlServerUserDetails => this["sql_server_user_details"];

}
