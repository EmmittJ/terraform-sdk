using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for authentication_mode in .
/// Nesting mode: list
/// </summary>
public class AwsElasticacheUserDataSourceAuthenticationModeBlock : TerraformBlock
{
    /// <summary>
    /// The password_count attribute.
    /// </summary>
    public TerraformProperty<double>? PasswordCount
    {
        get => GetProperty<TerraformProperty<double>>("password_count");
        set => WithProperty("password_count", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformProperty<string>? Type
    {
        get => GetProperty<TerraformProperty<string>>("type");
        set => WithProperty("type", value);
    }

}

/// <summary>
/// Retrieves information about a aws_elasticache_user.
/// </summary>
public class AwsElasticacheUserDataSource : TerraformDataSource
{
    public AwsElasticacheUserDataSource(string name) : base("aws_elasticache_user", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The access_string attribute.
    /// </summary>
    public TerraformProperty<string>? AccessString
    {
        get => GetProperty<TerraformProperty<string>>("access_string");
        set => this.WithProperty("access_string", value);
    }

    /// <summary>
    /// The engine attribute.
    /// </summary>
    public TerraformProperty<string>? Engine
    {
        get => GetProperty<TerraformProperty<string>>("engine");
        set => this.WithProperty("engine", value);
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
    /// The no_password_required attribute.
    /// </summary>
    public TerraformProperty<bool>? NoPasswordRequired
    {
        get => GetProperty<TerraformProperty<bool>>("no_password_required");
        set => this.WithProperty("no_password_required", value);
    }

    /// <summary>
    /// The passwords attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? Passwords
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("passwords");
        set => this.WithProperty("passwords", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The user_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserId is required")]
    public required TerraformProperty<string> UserId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("user_id");
        set => this.WithProperty("user_id", value);
    }

    /// <summary>
    /// The user_name attribute.
    /// </summary>
    public TerraformProperty<string>? UserName
    {
        get => GetProperty<TerraformProperty<string>>("user_name");
        set => this.WithProperty("user_name", value);
    }

    /// <summary>
    /// Block for authentication_mode.
    /// Nesting mode: list
    /// </summary>
    public List<AwsElasticacheUserDataSourceAuthenticationModeBlock>? AuthenticationMode
    {
        get => GetProperty<List<AwsElasticacheUserDataSourceAuthenticationModeBlock>>("authentication_mode");
        set => this.WithProperty("authentication_mode", value);
    }

}
