using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for authentication_mode in .
/// Nesting mode: list
/// </summary>
public class AwsElasticacheUserAuthenticationModeBlock : TerraformBlock
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
    /// The passwords attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? Passwords
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("passwords");
        set => WithProperty("passwords", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        get => GetProperty<TerraformProperty<string>>("type");
        set => WithProperty("type", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsElasticacheUserTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a aws_elasticache_user resource.
/// </summary>
public class AwsElasticacheUser : TerraformResource
{
    public AwsElasticacheUser(string name) : base("aws_elasticache_user", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
    }

    /// <summary>
    /// The access_string attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccessString is required")]
    public required TerraformProperty<string> AccessString
    {
        get => GetProperty<TerraformProperty<string>>("access_string");
        set => this.WithProperty("access_string", value);
    }

    /// <summary>
    /// The engine attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Engine is required")]
    public required TerraformProperty<string> Engine
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
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? TagsAll
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The user_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserId is required")]
    public required TerraformProperty<string> UserId
    {
        get => GetProperty<TerraformProperty<string>>("user_id");
        set => this.WithProperty("user_id", value);
    }

    /// <summary>
    /// The user_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserName is required")]
    public required TerraformProperty<string> UserName
    {
        get => GetProperty<TerraformProperty<string>>("user_name");
        set => this.WithProperty("user_name", value);
    }

    /// <summary>
    /// Block for authentication_mode.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AuthenticationMode block(s) allowed")]
    public List<AwsElasticacheUserAuthenticationModeBlock>? AuthenticationMode
    {
        get => GetProperty<List<AwsElasticacheUserAuthenticationModeBlock>>("authentication_mode");
        set => this.WithProperty("authentication_mode", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsElasticacheUserTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsElasticacheUserTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
