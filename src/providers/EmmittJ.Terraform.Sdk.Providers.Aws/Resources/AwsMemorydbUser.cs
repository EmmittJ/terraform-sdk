using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for authentication_mode in AwsMemorydbUser.
/// Nesting mode: list
/// </summary>
public class AwsMemorydbUserAuthenticationModeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "authentication_mode";

    /// <summary>
    /// The password_count attribute.
    /// </summary>
    public TerraformValue<double> PasswordCount
    {
        get => new TerraformReference<double>(this, "password_count");
    }

    /// <summary>
    /// The passwords attribute.
    /// </summary>
    public TerraformSet<string>? Passwords
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "passwords").ResolveNodes(ctx));
        set => SetArgument("passwords", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

}


/// <summary>
/// Represents a aws_memorydb_user Terraform resource.
/// Manages a aws_memorydb_user resource.
/// </summary>
public partial class AwsMemorydbUser(string name) : TerraformResource("aws_memorydb_user", name)
{
    /// <summary>
    /// The access_string attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccessString is required")]
    public required TerraformValue<string> AccessString
    {
        get => new TerraformReference<string>(this, "access_string");
        set => SetArgument("access_string", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags_all").ResolveNodes(ctx));
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The user_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserName is required")]
    public required TerraformValue<string> UserName
    {
        get => new TerraformReference<string>(this, "user_name");
        set => SetArgument("user_name", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The minimum_engine_version attribute.
    /// </summary>
    public TerraformValue<string> MinimumEngineVersion
    {
        get => new TerraformReference<string>(this, "minimum_engine_version");
    }

    /// <summary>
    /// AuthenticationMode block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AuthenticationMode is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 AuthenticationMode block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AuthenticationMode block(s) allowed")]
    public required TerraformList<AwsMemorydbUserAuthenticationModeBlock> AuthenticationMode
    {
        get => GetRequiredArgument<TerraformList<AwsMemorydbUserAuthenticationModeBlock>>("authentication_mode");
        set => SetArgument("authentication_mode", value);
    }

}
