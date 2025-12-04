using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for setting in AwsElasticBeanstalkConfigurationTemplate.
/// Nesting mode: set
/// </summary>
public class AwsElasticBeanstalkConfigurationTemplateSettingBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "setting";

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
    /// The namespace attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NamespaceAttribute is required")]
    public required TerraformValue<string> NamespaceAttribute
    {
        get => GetArgument<TerraformValue<string>>("namespace");
        set => SetArgument("namespace", value);
    }

    /// <summary>
    /// The resource attribute.
    /// </summary>
    public TerraformValue<string>? Resource
    {
        get => GetArgument<TerraformValue<string>>("resource");
        set => SetArgument("resource", value);
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
/// Represents a aws_elastic_beanstalk_configuration_template Terraform resource.
/// Manages a aws_elastic_beanstalk_configuration_template resource.
/// </summary>
public partial class AwsElasticBeanstalkConfigurationTemplate(string name) : TerraformResource("aws_elastic_beanstalk_configuration_template", name)
{
    /// <summary>
    /// The application attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Application is required")]
    public required TerraformValue<string> Application
    {
        get => GetArgument<TerraformValue<string>>("application");
        set => SetArgument("application", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The environment_id attribute.
    /// </summary>
    public TerraformValue<string>? EnvironmentId
    {
        get => GetArgument<TerraformValue<string>>("environment_id");
        set => SetArgument("environment_id", value);
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
    /// The solution_stack_name attribute.
    /// </summary>
    public TerraformValue<string>? SolutionStackName
    {
        get => GetArgument<TerraformValue<string>>("solution_stack_name");
        set => SetArgument("solution_stack_name", value);
    }

    /// <summary>
    /// Setting block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsElasticBeanstalkConfigurationTemplateSettingBlock>? Setting
    {
        get => GetArgument<TerraformSet<AwsElasticBeanstalkConfigurationTemplateSettingBlock>>("setting");
        set => SetArgument("setting", value);
    }

}
