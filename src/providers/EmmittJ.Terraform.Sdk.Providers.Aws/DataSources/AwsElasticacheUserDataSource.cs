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
        set => SetProperty("password_count", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformProperty<string>? Type
    {
        set => SetProperty("type", value);
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
        SetOutput("access_string");
        SetOutput("engine");
        SetOutput("id");
        SetOutput("no_password_required");
        SetOutput("passwords");
        SetOutput("region");
        SetOutput("user_id");
        SetOutput("user_name");
    }

    /// <summary>
    /// The access_string attribute.
    /// </summary>
    public TerraformProperty<string> AccessString
    {
        get => GetRequiredOutput<TerraformProperty<string>>("access_string");
        set => SetProperty("access_string", value);
    }

    /// <summary>
    /// The engine attribute.
    /// </summary>
    public TerraformProperty<string> Engine
    {
        get => GetRequiredOutput<TerraformProperty<string>>("engine");
        set => SetProperty("engine", value);
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
    /// The no_password_required attribute.
    /// </summary>
    public TerraformProperty<bool> NoPasswordRequired
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("no_password_required");
        set => SetProperty("no_password_required", value);
    }

    /// <summary>
    /// The passwords attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> Passwords
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("passwords");
        set => SetProperty("passwords", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The user_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserId is required")]
    public required TerraformProperty<string> UserId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("user_id");
        set => SetProperty("user_id", value);
    }

    /// <summary>
    /// The user_name attribute.
    /// </summary>
    public TerraformProperty<string> UserName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("user_name");
        set => SetProperty("user_name", value);
    }

    /// <summary>
    /// Block for authentication_mode.
    /// Nesting mode: list
    /// </summary>
    public List<AwsElasticacheUserDataSourceAuthenticationModeBlock>? AuthenticationMode
    {
        set => SetProperty("authentication_mode", value);
    }

}
