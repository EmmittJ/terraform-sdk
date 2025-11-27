using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for action_point in AwsAppconfigExtension.
/// Nesting mode: set
/// </summary>
public class AwsAppconfigExtensionActionPointBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "action_point";

    /// <summary>
    /// The point attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Point is required")]
    public required TerraformValue<string> Point
    {
        get => new TerraformReference<string>(this, "point");
        set => SetArgument("point", value);
    }

    /// <summary>
    /// Action block (nesting mode: set).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Action is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Action block(s) required")]
    public required TerraformSet<AwsAppconfigExtensionActionPointBlockActionBlock> Action
    {
        get => GetRequiredArgument<TerraformSet<AwsAppconfigExtensionActionPointBlockActionBlock>>("action");
        set => SetArgument("action", value);
    }

}

/// <summary>
/// Block type for action in AwsAppconfigExtensionActionPointBlock.
/// Nesting mode: set
/// </summary>
public class AwsAppconfigExtensionActionPointBlockActionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "action";

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    public TerraformValue<string>? RoleArn
    {
        get => new TerraformReference<string>(this, "role_arn");
        set => SetArgument("role_arn", value);
    }

    /// <summary>
    /// The uri attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Uri is required")]
    public required TerraformValue<string> Uri
    {
        get => new TerraformReference<string>(this, "uri");
        set => SetArgument("uri", value);
    }

}


/// <summary>
/// Block type for parameter in AwsAppconfigExtension.
/// Nesting mode: set
/// </summary>
public class AwsAppconfigExtensionParameterBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "parameter";

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The required attribute.
    /// </summary>
    public TerraformValue<bool>? Required
    {
        get => new TerraformReference<bool>(this, "required");
        set => SetArgument("required", value);
    }

}


/// <summary>
/// Represents a aws_appconfig_extension Terraform resource.
/// Manages a aws_appconfig_extension resource.
/// </summary>
public partial class AwsAppconfigExtension(string name) : TerraformResource("aws_appconfig_extension", name)
{
    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string> Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
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
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformValue<double> Version
    {
        get => new TerraformReference<double>(this, "version");
    }

    /// <summary>
    /// ActionPoint block (nesting mode: set).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ActionPoint is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ActionPoint block(s) required")]
    public required TerraformSet<AwsAppconfigExtensionActionPointBlock> ActionPoint
    {
        get => GetRequiredArgument<TerraformSet<AwsAppconfigExtensionActionPointBlock>>("action_point");
        set => SetArgument("action_point", value);
    }

    /// <summary>
    /// Parameter block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsAppconfigExtensionParameterBlock>? Parameter
    {
        get => GetArgument<TerraformSet<AwsAppconfigExtensionParameterBlock>>("parameter");
        set => SetArgument("parameter", value);
    }

}
