using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for password_policy in GoogleSqlUser.
/// Nesting mode: list
/// </summary>
public class GoogleSqlUserPasswordPolicyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "password_policy";

    /// <summary>
    /// Number of failed attempts allowed before the user get locked.
    /// </summary>
    public TerraformValue<double>? AllowedFailedAttempts
    {
        get => GetArgument<TerraformValue<double>>("allowed_failed_attempts");
        set => SetArgument("allowed_failed_attempts", value);
    }

    /// <summary>
    /// If true, the check that will lock user after too many failed login attempts will be enabled.
    /// </summary>
    public TerraformValue<bool>? EnableFailedAttemptsCheck
    {
        get => GetArgument<TerraformValue<bool>>("enable_failed_attempts_check");
        set => SetArgument("enable_failed_attempts_check", value);
    }

    /// <summary>
    /// If true, the user must specify the current password before changing the password. This flag is supported only for MySQL.
    /// </summary>
    public TerraformValue<bool>? EnablePasswordVerification
    {
        get => GetArgument<TerraformValue<bool>>("enable_password_verification");
        set => SetArgument("enable_password_verification", value);
    }

    /// <summary>
    /// Password expiration duration with one week grace period.
    /// </summary>
    public TerraformValue<string>? PasswordExpirationDuration
    {
        get => GetArgument<TerraformValue<string>>("password_expiration_duration");
        set => SetArgument("password_expiration_duration", value);
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Status
        => AsReference("status");

}


/// <summary>
/// Block type for timeouts in GoogleSqlUser.
/// Nesting mode: single
/// </summary>
public class GoogleSqlUserTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a google_sql_user Terraform resource.
/// Manages a google_sql_user resource.
/// </summary>
public partial class GoogleSqlUser(string name) : TerraformResource("google_sql_user", name)
{
    /// <summary>
    /// The deletion policy for the user. Setting ABANDON allows the resource
    /// 				to be abandoned rather than deleted. This is useful for Postgres, where users cannot be deleted from the API if they
    /// 				have been granted SQL roles. Possible values are: &amp;quot;ABANDON&amp;quot;.
    /// </summary>
    public TerraformValue<string>? DeletionPolicy
    {
        get => GetArgument<TerraformValue<string>>("deletion_policy");
        set => SetArgument("deletion_policy", value);
    }

    /// <summary>
    /// The host the user can connect from. This is only supported for MySQL instances. Don&#39;t set this field for PostgreSQL instances. Can be an IP address. Changing this forces a new resource to be created.
    /// </summary>
    public TerraformValue<string>? Host
    {
        get => GetArgument<TerraformValue<string>>("host");
        set => SetArgument("host", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name of the Cloud SQL instance. Changing this forces a new resource to be created.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Instance is required")]
    public required TerraformValue<string> Instance
    {
        get => GetArgument<TerraformValue<string>>("instance");
        set => SetArgument("instance", value);
    }

    /// <summary>
    /// The name of the user. Changing this forces a new resource to be created.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The password for the user. Can be updated. For Postgres instances this is a Required field, unless type is set to
    /// 				either CLOUD_IAM_USER or CLOUD_IAM_SERVICE_ACCOUNT.
    /// </summary>
    public TerraformValue<string>? Password
    {
        get => GetArgument<TerraformValue<string>>("password");
        set => SetArgument("password", value);
    }

    /// <summary>
    /// The password for the user. Can be updated. For Postgres instances this is a Required field, unless type is set to
    /// 				either CLOUD_IAM_USER or CLOUD_IAM_SERVICE_ACCOUNT.
    /// </summary>
    public TerraformValue<string>? PasswordWo
    {
        get => GetArgument<TerraformValue<string>>("password_wo");
        set => SetArgument("password_wo", value);
    }

    /// <summary>
    /// The version of the password_wo.
    /// </summary>
    public TerraformValue<double>? PasswordWoVersion
    {
        get => GetArgument<TerraformValue<double>>("password_wo_version");
        set => SetArgument("password_wo_version", value);
    }

    /// <summary>
    /// The ID of the project in which the resource belongs. If it is not provided, the provider project is used.
    /// </summary>
    public TerraformValue<string>? Project
    {
        get => GetArgument<TerraformValue<string>>("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The user type. It determines the method to authenticate the user during login.
    /// 				The default is the database&#39;s built-in user type.
    /// </summary>
    public TerraformValue<string>? Type
    {
        get => GetArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// The sql_server_user_details attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> SqlServerUserDetails
        => AsReference("sql_server_user_details");

    /// <summary>
    /// PasswordPolicy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PasswordPolicy block(s) allowed")]
    public TerraformList<GoogleSqlUserPasswordPolicyBlock>? PasswordPolicy
    {
        get => GetArgument<TerraformList<GoogleSqlUserPasswordPolicyBlock>>("password_policy");
        set => SetArgument("password_policy", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleSqlUserTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleSqlUserTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
