using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_sql_user resource.
/// </summary>
public class GoogleSqlUser : TerraformResource
{
    public GoogleSqlUser(string name) : base("google_sql_user", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("sql_server_user_details");
    }

    /// <summary>
    /// The deletion policy for the user. Setting ABANDON allows the resource
    /// 				to be abandoned rather than deleted. This is useful for Postgres, where users cannot be deleted from the API if they
    /// 				have been granted SQL roles. Possible values are: &amp;quot;ABANDON&amp;quot;.
    /// </summary>
    public TerraformProperty<string>? DeletionPolicy
    {
        get => GetProperty<TerraformProperty<string>>("deletion_policy");
        set => this.WithProperty("deletion_policy", value);
    }

    /// <summary>
    /// The host the user can connect from. This is only supported for MySQL instances. Don&#39;t set this field for PostgreSQL instances. Can be an IP address. Changing this forces a new resource to be created.
    /// </summary>
    public TerraformProperty<string>? Host
    {
        get => GetProperty<TerraformProperty<string>>("host");
        set => this.WithProperty("host", value);
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
    /// The name of the Cloud SQL instance. Changing this forces a new resource to be created.
    /// </summary>
    public TerraformProperty<string>? Instance
    {
        get => GetProperty<TerraformProperty<string>>("instance");
        set => this.WithProperty("instance", value);
    }

    /// <summary>
    /// The name of the user. Changing this forces a new resource to be created.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The password for the user. Can be updated. For Postgres instances this is a Required field, unless type is set to
    /// 				either CLOUD_IAM_USER or CLOUD_IAM_SERVICE_ACCOUNT.
    /// </summary>
    public TerraformProperty<string>? Password
    {
        get => GetProperty<TerraformProperty<string>>("password");
        set => this.WithProperty("password", value);
    }

    /// <summary>
    /// The password for the user. Can be updated. For Postgres instances this is a Required field, unless type is set to
    /// 				either CLOUD_IAM_USER or CLOUD_IAM_SERVICE_ACCOUNT.
    /// </summary>
    public TerraformProperty<string>? PasswordWo
    {
        get => GetProperty<TerraformProperty<string>>("password_wo");
        set => this.WithProperty("password_wo", value);
    }

    /// <summary>
    /// The version of the password_wo.
    /// </summary>
    public TerraformProperty<double>? PasswordWoVersion
    {
        get => GetProperty<TerraformProperty<double>>("password_wo_version");
        set => this.WithProperty("password_wo_version", value);
    }

    /// <summary>
    /// The ID of the project in which the resource belongs. If it is not provided, the provider project is used.
    /// </summary>
    public TerraformProperty<string>? Project
    {
        get => GetProperty<TerraformProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// The user type. It determines the method to authenticate the user during login.
    /// 				The default is the database&#39;s built-in user type.
    /// </summary>
    public TerraformProperty<string>? Type
    {
        get => GetProperty<TerraformProperty<string>>("type");
        set => this.WithProperty("type", value);
    }

    /// <summary>
    /// The sql_server_user_details attribute.
    /// </summary>
    public TerraformExpression SqlServerUserDetails => this["sql_server_user_details"];

}
