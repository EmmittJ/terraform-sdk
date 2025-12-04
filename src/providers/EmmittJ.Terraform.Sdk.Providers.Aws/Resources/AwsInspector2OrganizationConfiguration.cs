using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for auto_enable in AwsInspector2OrganizationConfiguration.
/// Nesting mode: list
/// </summary>
public class AwsInspector2OrganizationConfigurationAutoEnableBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "auto_enable";

    /// <summary>
    /// The code_repository attribute.
    /// </summary>
    public TerraformValue<bool>? CodeRepository
    {
        get => GetArgument<TerraformValue<bool>>("code_repository");
        set => SetArgument("code_repository", value);
    }

    /// <summary>
    /// The ec2 attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Ec2 is required")]
    public required TerraformValue<bool> Ec2
    {
        get => GetRequiredArgument<TerraformValue<bool>>("ec2");
        set => SetArgument("ec2", value);
    }

    /// <summary>
    /// The ecr attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Ecr is required")]
    public required TerraformValue<bool> Ecr
    {
        get => GetRequiredArgument<TerraformValue<bool>>("ecr");
        set => SetArgument("ecr", value);
    }

    /// <summary>
    /// The lambda attribute.
    /// </summary>
    public TerraformValue<bool>? Lambda
    {
        get => GetArgument<TerraformValue<bool>>("lambda");
        set => SetArgument("lambda", value);
    }

    /// <summary>
    /// The lambda_code attribute.
    /// </summary>
    public TerraformValue<bool>? LambdaCode
    {
        get => GetArgument<TerraformValue<bool>>("lambda_code");
        set => SetArgument("lambda_code", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsInspector2OrganizationConfiguration.
/// Nesting mode: single
/// </summary>
public class AwsInspector2OrganizationConfigurationTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a aws_inspector2_organization_configuration Terraform resource.
/// Manages a aws_inspector2_organization_configuration resource.
/// </summary>
public partial class AwsInspector2OrganizationConfiguration(string name) : TerraformResource("aws_inspector2_organization_configuration", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
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
    /// The max_account_limit_reached attribute.
    /// </summary>
    public TerraformValue<bool> MaxAccountLimitReached
        => AsReference("max_account_limit_reached");

    /// <summary>
    /// AutoEnable block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AutoEnable is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 AutoEnable block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutoEnable block(s) allowed")]
    public required TerraformList<AwsInspector2OrganizationConfigurationAutoEnableBlock> AutoEnable
    {
        get => GetRequiredArgument<TerraformList<AwsInspector2OrganizationConfigurationAutoEnableBlock>>("auto_enable");
        set => SetArgument("auto_enable", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsInspector2OrganizationConfigurationTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsInspector2OrganizationConfigurationTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
