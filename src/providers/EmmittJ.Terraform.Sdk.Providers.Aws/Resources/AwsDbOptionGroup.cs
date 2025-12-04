using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for option in AwsDbOptionGroup.
/// Nesting mode: set
/// </summary>
public class AwsDbOptionGroupOptionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "option";

    /// <summary>
    /// The db_security_group_memberships attribute.
    /// </summary>
    public TerraformSet<string>? DbSecurityGroupMemberships
    {
        get => GetArgument<TerraformSet<string>>("db_security_group_memberships");
        set => SetArgument("db_security_group_memberships", value);
    }

    /// <summary>
    /// The option_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OptionName is required")]
    public required TerraformValue<string> OptionName
    {
        get => GetArgument<TerraformValue<string>>("option_name");
        set => SetArgument("option_name", value);
    }

    /// <summary>
    /// The port attribute.
    /// </summary>
    public TerraformValue<double>? Port
    {
        get => GetArgument<TerraformValue<double>>("port");
        set => SetArgument("port", value);
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformValue<string>? Version
    {
        get => GetArgument<TerraformValue<string>>("version");
        set => SetArgument("version", value);
    }

    /// <summary>
    /// The vpc_security_group_memberships attribute.
    /// </summary>
    public TerraformSet<string>? VpcSecurityGroupMemberships
    {
        get => GetArgument<TerraformSet<string>>("vpc_security_group_memberships");
        set => SetArgument("vpc_security_group_memberships", value);
    }

    /// <summary>
    /// OptionSettings block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsDbOptionGroupOptionBlockOptionSettingsBlock>? OptionSettings
    {
        get => GetArgument<TerraformSet<AwsDbOptionGroupOptionBlockOptionSettingsBlock>>("option_settings");
        set => SetArgument("option_settings", value);
    }

}

/// <summary>
/// Block type for option_settings in AwsDbOptionGroupOptionBlock.
/// Nesting mode: set
/// </summary>
public class AwsDbOptionGroupOptionBlockOptionSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "option_settings";

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsDbOptionGroup.
/// Nesting mode: single
/// </summary>
public class AwsDbOptionGroupTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

}


/// <summary>
/// Represents a aws_db_option_group Terraform resource.
/// Manages a aws_db_option_group resource.
/// </summary>
public partial class AwsDbOptionGroup(string name) : TerraformResource("aws_db_option_group", name)
{
    /// <summary>
    /// The engine_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EngineName is required")]
    public required TerraformValue<string> EngineName
    {
        get => GetArgument<TerraformValue<string>>("engine_name");
        set => SetArgument("engine_name", value);
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
    /// The major_engine_version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MajorEngineVersion is required")]
    public required TerraformValue<string> MajorEngineVersion
    {
        get => GetArgument<TerraformValue<string>>("major_engine_version");
        set => SetArgument("major_engine_version", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string>? Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The name_prefix attribute.
    /// </summary>
    public TerraformValue<string>? NamePrefix
    {
        get => GetArgument<TerraformValue<string>>("name_prefix");
        set => SetArgument("name_prefix", value);
    }

    /// <summary>
    /// The option_group_description attribute.
    /// </summary>
    public TerraformValue<string>? OptionGroupDescription
    {
        get => GetArgument<TerraformValue<string>>("option_group_description");
        set => SetArgument("option_group_description", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The skip_destroy attribute.
    /// </summary>
    public TerraformValue<bool>? SkipDestroy
    {
        get => GetArgument<TerraformValue<bool>>("skip_destroy");
        set => SetArgument("skip_destroy", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string>? TagsAll
    {
        get => GetArgument<TerraformMap<string>>("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// Option block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsDbOptionGroupOptionBlock>? Option
    {
        get => GetArgument<TerraformSet<AwsDbOptionGroupOptionBlock>>("option");
        set => SetArgument("option", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsDbOptionGroupTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsDbOptionGroupTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
