using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for authentication_mode in AwsElasticacheUserDataSource.
/// Nesting mode: list
/// </summary>
public class AwsElasticacheUserDataSourceAuthenticationModeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "authentication_mode";

    /// <summary>
    /// The password_count attribute.
    /// </summary>
    public TerraformValue<double>? PasswordCount
    {
        get => GetArgument<TerraformValue<double>>("password_count");
        set => SetArgument("password_count", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformValue<string>? Type
    {
        get => GetArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

}


/// <summary>
/// Represents a aws_elasticache_user Terraform data source.
/// Retrieves information about a aws_elasticache_user.
/// </summary>
public partial class AwsElasticacheUserDataSource(string name) : TerraformDataSource("aws_elasticache_user", name)
{
    /// <summary>
    /// The access_string attribute.
    /// </summary>
    public TerraformValue<string>? AccessString
    {
        get => GetArgument<TerraformValue<string>>("access_string");
        set => SetArgument("access_string", value);
    }

    /// <summary>
    /// The engine attribute.
    /// </summary>
    public TerraformValue<string>? Engine
    {
        get => GetArgument<TerraformValue<string>>("engine");
        set => SetArgument("engine", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The no_password_required attribute.
    /// </summary>
    public TerraformValue<bool>? NoPasswordRequired
    {
        get => GetArgument<TerraformValue<bool>>("no_password_required");
        set => SetArgument("no_password_required", value);
    }

    /// <summary>
    /// The passwords attribute.
    /// </summary>
    public TerraformSet<string>? Passwords
    {
        get => GetArgument<TerraformSet<string>>("passwords");
        set => SetArgument("passwords", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? AsReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The user_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserId is required")]
    public required TerraformValue<string> UserId
    {
        get => GetRequiredArgument<TerraformValue<string>>("user_id");
        set => SetArgument("user_id", value);
    }

    /// <summary>
    /// The user_name attribute.
    /// </summary>
    public TerraformValue<string>? UserName
    {
        get => GetArgument<TerraformValue<string>>("user_name");
        set => SetArgument("user_name", value);
    }

    /// <summary>
    /// AuthenticationMode block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsElasticacheUserDataSourceAuthenticationModeBlock>? AuthenticationMode
    {
        get => GetArgument<TerraformList<AwsElasticacheUserDataSourceAuthenticationModeBlock>>("authentication_mode");
        set => SetArgument("authentication_mode", value);
    }

}
