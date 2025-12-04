using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for configuration_policy in AwsSecurityhubConfigurationPolicy.
/// Nesting mode: list
/// </summary>
public class AwsSecurityhubConfigurationPolicyConfigurationPolicyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "configuration_policy";

    /// <summary>
    /// The enabled_standard_arns attribute.
    /// </summary>
    public TerraformSet<string>? EnabledStandardArns
    {
        get => GetArgument<TerraformSet<string>>("enabled_standard_arns");
        set => SetArgument("enabled_standard_arns", value);
    }

    /// <summary>
    /// The service_enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceEnabled is required")]
    public required TerraformValue<bool> ServiceEnabled
    {
        get => GetArgument<TerraformValue<bool>>("service_enabled");
        set => SetArgument("service_enabled", value);
    }

    /// <summary>
    /// SecurityControlsConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SecurityControlsConfiguration block(s) allowed")]
    public TerraformList<AwsSecurityhubConfigurationPolicyConfigurationPolicyBlockSecurityControlsConfigurationBlock>? SecurityControlsConfiguration
    {
        get => GetArgument<TerraformList<AwsSecurityhubConfigurationPolicyConfigurationPolicyBlockSecurityControlsConfigurationBlock>>("security_controls_configuration");
        set => SetArgument("security_controls_configuration", value);
    }

}

/// <summary>
/// Block type for security_controls_configuration in AwsSecurityhubConfigurationPolicyConfigurationPolicyBlock.
/// Nesting mode: list
/// </summary>
public class AwsSecurityhubConfigurationPolicyConfigurationPolicyBlockSecurityControlsConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "security_controls_configuration";

    /// <summary>
    /// The disabled_control_identifiers attribute.
    /// </summary>
    public TerraformSet<string>? DisabledControlIdentifiers
    {
        get => GetArgument<TerraformSet<string>>("disabled_control_identifiers");
        set => SetArgument("disabled_control_identifiers", value);
    }

    /// <summary>
    /// The enabled_control_identifiers attribute.
    /// </summary>
    public TerraformSet<string>? EnabledControlIdentifiers
    {
        get => GetArgument<TerraformSet<string>>("enabled_control_identifiers");
        set => SetArgument("enabled_control_identifiers", value);
    }

    /// <summary>
    /// SecurityControlCustomParameter block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsSecurityhubConfigurationPolicyConfigurationPolicyBlockSecurityControlsConfigurationBlockSecurityControlCustomParameterBlock>? SecurityControlCustomParameter
    {
        get => GetArgument<TerraformList<AwsSecurityhubConfigurationPolicyConfigurationPolicyBlockSecurityControlsConfigurationBlockSecurityControlCustomParameterBlock>>("security_control_custom_parameter");
        set => SetArgument("security_control_custom_parameter", value);
    }

}

/// <summary>
/// Block type for security_control_custom_parameter in AwsSecurityhubConfigurationPolicyConfigurationPolicyBlockSecurityControlsConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsSecurityhubConfigurationPolicyConfigurationPolicyBlockSecurityControlsConfigurationBlockSecurityControlCustomParameterBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "security_control_custom_parameter";

    /// <summary>
    /// The security_control_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecurityControlId is required")]
    public required TerraformValue<string> SecurityControlId
    {
        get => GetArgument<TerraformValue<string>>("security_control_id");
        set => SetArgument("security_control_id", value);
    }

    /// <summary>
    /// Parameter block (nesting mode: set).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Parameter is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Parameter block(s) required")]
    public required TerraformSet<AwsSecurityhubConfigurationPolicyConfigurationPolicyBlockSecurityControlsConfigurationBlockSecurityControlCustomParameterBlockParameterBlock> Parameter
    {
        get => GetRequiredArgument<TerraformSet<AwsSecurityhubConfigurationPolicyConfigurationPolicyBlockSecurityControlsConfigurationBlockSecurityControlCustomParameterBlockParameterBlock>>("parameter");
        set => SetArgument("parameter", value);
    }

}

/// <summary>
/// Block type for parameter in AwsSecurityhubConfigurationPolicyConfigurationPolicyBlockSecurityControlsConfigurationBlockSecurityControlCustomParameterBlock.
/// Nesting mode: set
/// </summary>
public class AwsSecurityhubConfigurationPolicyConfigurationPolicyBlockSecurityControlsConfigurationBlockSecurityControlCustomParameterBlockParameterBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "parameter";

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
    /// The value_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ValueType is required")]
    public required TerraformValue<string> ValueType
    {
        get => GetArgument<TerraformValue<string>>("value_type");
        set => SetArgument("value_type", value);
    }

    /// <summary>
    /// BoolAttribute block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BoolAttribute block(s) allowed")]
    public TerraformList<AwsSecurityhubConfigurationPolicyConfigurationPolicyBlockSecurityControlsConfigurationBlockSecurityControlCustomParameterBlockParameterBlockBoolAttributeBlock>? BoolAttribute
    {
        get => GetArgument<TerraformList<AwsSecurityhubConfigurationPolicyConfigurationPolicyBlockSecurityControlsConfigurationBlockSecurityControlCustomParameterBlockParameterBlockBoolAttributeBlock>>("bool");
        set => SetArgument("bool", value);
    }

    /// <summary>
    /// DoubleAttribute block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DoubleAttribute block(s) allowed")]
    public TerraformList<AwsSecurityhubConfigurationPolicyConfigurationPolicyBlockSecurityControlsConfigurationBlockSecurityControlCustomParameterBlockParameterBlockDoubleAttributeBlock>? DoubleAttribute
    {
        get => GetArgument<TerraformList<AwsSecurityhubConfigurationPolicyConfigurationPolicyBlockSecurityControlsConfigurationBlockSecurityControlCustomParameterBlockParameterBlockDoubleAttributeBlock>>("double");
        set => SetArgument("double", value);
    }

    /// <summary>
    /// EnumAttribute block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EnumAttribute block(s) allowed")]
    public TerraformList<AwsSecurityhubConfigurationPolicyConfigurationPolicyBlockSecurityControlsConfigurationBlockSecurityControlCustomParameterBlockParameterBlockEnumAttributeBlock>? EnumAttribute
    {
        get => GetArgument<TerraformList<AwsSecurityhubConfigurationPolicyConfigurationPolicyBlockSecurityControlsConfigurationBlockSecurityControlCustomParameterBlockParameterBlockEnumAttributeBlock>>("enum");
        set => SetArgument("enum", value);
    }

    /// <summary>
    /// EnumList block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EnumList block(s) allowed")]
    public TerraformList<AwsSecurityhubConfigurationPolicyConfigurationPolicyBlockSecurityControlsConfigurationBlockSecurityControlCustomParameterBlockParameterBlockEnumListBlock>? EnumList
    {
        get => GetArgument<TerraformList<AwsSecurityhubConfigurationPolicyConfigurationPolicyBlockSecurityControlsConfigurationBlockSecurityControlCustomParameterBlockParameterBlockEnumListBlock>>("enum_list");
        set => SetArgument("enum_list", value);
    }

    /// <summary>
    /// IntAttribute block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IntAttribute block(s) allowed")]
    public TerraformList<AwsSecurityhubConfigurationPolicyConfigurationPolicyBlockSecurityControlsConfigurationBlockSecurityControlCustomParameterBlockParameterBlockIntAttributeBlock>? IntAttribute
    {
        get => GetArgument<TerraformList<AwsSecurityhubConfigurationPolicyConfigurationPolicyBlockSecurityControlsConfigurationBlockSecurityControlCustomParameterBlockParameterBlockIntAttributeBlock>>("int");
        set => SetArgument("int", value);
    }

    /// <summary>
    /// IntList block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IntList block(s) allowed")]
    public TerraformList<AwsSecurityhubConfigurationPolicyConfigurationPolicyBlockSecurityControlsConfigurationBlockSecurityControlCustomParameterBlockParameterBlockIntListBlock>? IntList
    {
        get => GetArgument<TerraformList<AwsSecurityhubConfigurationPolicyConfigurationPolicyBlockSecurityControlsConfigurationBlockSecurityControlCustomParameterBlockParameterBlockIntListBlock>>("int_list");
        set => SetArgument("int_list", value);
    }

    /// <summary>
    /// StringAttribute block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StringAttribute block(s) allowed")]
    public TerraformList<AwsSecurityhubConfigurationPolicyConfigurationPolicyBlockSecurityControlsConfigurationBlockSecurityControlCustomParameterBlockParameterBlockStringAttributeBlock>? StringAttribute
    {
        get => GetArgument<TerraformList<AwsSecurityhubConfigurationPolicyConfigurationPolicyBlockSecurityControlsConfigurationBlockSecurityControlCustomParameterBlockParameterBlockStringAttributeBlock>>("string");
        set => SetArgument("string", value);
    }

    /// <summary>
    /// StringList block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StringList block(s) allowed")]
    public TerraformList<AwsSecurityhubConfigurationPolicyConfigurationPolicyBlockSecurityControlsConfigurationBlockSecurityControlCustomParameterBlockParameterBlockStringListBlock>? StringList
    {
        get => GetArgument<TerraformList<AwsSecurityhubConfigurationPolicyConfigurationPolicyBlockSecurityControlsConfigurationBlockSecurityControlCustomParameterBlockParameterBlockStringListBlock>>("string_list");
        set => SetArgument("string_list", value);
    }

}

/// <summary>
/// Block type for bool in AwsSecurityhubConfigurationPolicyConfigurationPolicyBlockSecurityControlsConfigurationBlockSecurityControlCustomParameterBlockParameterBlock.
/// Nesting mode: list
/// </summary>
public class AwsSecurityhubConfigurationPolicyConfigurationPolicyBlockSecurityControlsConfigurationBlockSecurityControlCustomParameterBlockParameterBlockBoolAttributeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "bool";

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<bool> Value
    {
        get => GetArgument<TerraformValue<bool>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for double in AwsSecurityhubConfigurationPolicyConfigurationPolicyBlockSecurityControlsConfigurationBlockSecurityControlCustomParameterBlockParameterBlock.
/// Nesting mode: list
/// </summary>
public class AwsSecurityhubConfigurationPolicyConfigurationPolicyBlockSecurityControlsConfigurationBlockSecurityControlCustomParameterBlockParameterBlockDoubleAttributeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "double";

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<double> Value
    {
        get => GetArgument<TerraformValue<double>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for enum in AwsSecurityhubConfigurationPolicyConfigurationPolicyBlockSecurityControlsConfigurationBlockSecurityControlCustomParameterBlockParameterBlock.
/// Nesting mode: list
/// </summary>
public class AwsSecurityhubConfigurationPolicyConfigurationPolicyBlockSecurityControlsConfigurationBlockSecurityControlCustomParameterBlockParameterBlockEnumAttributeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "enum";

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
/// Block type for enum_list in AwsSecurityhubConfigurationPolicyConfigurationPolicyBlockSecurityControlsConfigurationBlockSecurityControlCustomParameterBlockParameterBlock.
/// Nesting mode: list
/// </summary>
public class AwsSecurityhubConfigurationPolicyConfigurationPolicyBlockSecurityControlsConfigurationBlockSecurityControlCustomParameterBlockParameterBlockEnumListBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "enum_list";

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public TerraformList<string>? Value
    {
        get => GetArgument<TerraformList<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for int in AwsSecurityhubConfigurationPolicyConfigurationPolicyBlockSecurityControlsConfigurationBlockSecurityControlCustomParameterBlockParameterBlock.
/// Nesting mode: list
/// </summary>
public class AwsSecurityhubConfigurationPolicyConfigurationPolicyBlockSecurityControlsConfigurationBlockSecurityControlCustomParameterBlockParameterBlockIntAttributeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "int";

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<double> Value
    {
        get => GetArgument<TerraformValue<double>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for int_list in AwsSecurityhubConfigurationPolicyConfigurationPolicyBlockSecurityControlsConfigurationBlockSecurityControlCustomParameterBlockParameterBlock.
/// Nesting mode: list
/// </summary>
public class AwsSecurityhubConfigurationPolicyConfigurationPolicyBlockSecurityControlsConfigurationBlockSecurityControlCustomParameterBlockParameterBlockIntListBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "int_list";

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public TerraformList<double>? Value
    {
        get => GetArgument<TerraformList<double>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for string in AwsSecurityhubConfigurationPolicyConfigurationPolicyBlockSecurityControlsConfigurationBlockSecurityControlCustomParameterBlockParameterBlock.
/// Nesting mode: list
/// </summary>
public class AwsSecurityhubConfigurationPolicyConfigurationPolicyBlockSecurityControlsConfigurationBlockSecurityControlCustomParameterBlockParameterBlockStringAttributeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "string";

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
/// Block type for string_list in AwsSecurityhubConfigurationPolicyConfigurationPolicyBlockSecurityControlsConfigurationBlockSecurityControlCustomParameterBlockParameterBlock.
/// Nesting mode: list
/// </summary>
public class AwsSecurityhubConfigurationPolicyConfigurationPolicyBlockSecurityControlsConfigurationBlockSecurityControlCustomParameterBlockParameterBlockStringListBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "string_list";

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public TerraformList<string>? Value
    {
        get => GetArgument<TerraformList<string>>("value");
        set => SetArgument("value", value);
    }

}


/// <summary>
/// Represents a aws_securityhub_configuration_policy Terraform resource.
/// Manages a aws_securityhub_configuration_policy resource.
/// </summary>
public partial class AwsSecurityhubConfigurationPolicy(string name) : TerraformResource("aws_securityhub_configuration_policy", name)
{
    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
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
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// ConfigurationPolicy block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConfigurationPolicy is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ConfigurationPolicy block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ConfigurationPolicy block(s) allowed")]
    public required TerraformList<AwsSecurityhubConfigurationPolicyConfigurationPolicyBlock> ConfigurationPolicy
    {
        get => GetRequiredArgument<TerraformList<AwsSecurityhubConfigurationPolicyConfigurationPolicyBlock>>("configuration_policy");
        set => SetArgument("configuration_policy", value);
    }

}
