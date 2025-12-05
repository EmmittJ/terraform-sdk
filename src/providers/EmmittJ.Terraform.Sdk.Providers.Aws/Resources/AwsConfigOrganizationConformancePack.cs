using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for input_parameter in AwsConfigOrganizationConformancePack.
/// Nesting mode: set
/// </summary>
public class AwsConfigOrganizationConformancePackInputParameterBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "input_parameter";

    /// <summary>
    /// The parameter_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ParameterName is required")]
    public required TerraformValue<string> ParameterName
    {
        get => GetRequiredArgument<TerraformValue<string>>("parameter_name");
        set => SetArgument("parameter_name", value);
    }

    /// <summary>
    /// The parameter_value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ParameterValue is required")]
    public required TerraformValue<string> ParameterValue
    {
        get => GetRequiredArgument<TerraformValue<string>>("parameter_value");
        set => SetArgument("parameter_value", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsConfigOrganizationConformancePack.
/// Nesting mode: single
/// </summary>
public class AwsConfigOrganizationConformancePackTimeoutsBlock : TerraformBlock
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
/// Represents a aws_config_organization_conformance_pack Terraform resource.
/// Manages a aws_config_organization_conformance_pack resource.
/// </summary>
public partial class AwsConfigOrganizationConformancePack(string name) : TerraformResource("aws_config_organization_conformance_pack", name)
{
    /// <summary>
    /// The delivery_s3_bucket attribute.
    /// </summary>
    public TerraformValue<string>? DeliveryS3Bucket
    {
        get => GetArgument<TerraformValue<string>>("delivery_s3_bucket");
        set => SetArgument("delivery_s3_bucket", value);
    }

    /// <summary>
    /// The delivery_s3_key_prefix attribute.
    /// </summary>
    public TerraformValue<string>? DeliveryS3KeyPrefix
    {
        get => GetArgument<TerraformValue<string>>("delivery_s3_key_prefix");
        set => SetArgument("delivery_s3_key_prefix", value);
    }

    /// <summary>
    /// The excluded_accounts attribute.
    /// </summary>
    public TerraformSet<string>? ExcludedAccounts
    {
        get => GetArgument<TerraformSet<string>>("excluded_accounts");
        set => SetArgument("excluded_accounts", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? CreateReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The template_body attribute.
    /// </summary>
    public TerraformValue<string>? TemplateBody
    {
        get => GetArgument<TerraformValue<string>>("template_body");
        set => SetArgument("template_body", value);
    }

    /// <summary>
    /// The template_s3_uri attribute.
    /// </summary>
    public TerraformValue<string>? TemplateS3Uri
    {
        get => GetArgument<TerraformValue<string>>("template_s3_uri");
        set => SetArgument("template_s3_uri", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => CreateReference("arn");

    /// <summary>
    /// InputParameter block (nesting mode: set).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(60, ErrorMessage = "Maximum 60 InputParameter block(s) allowed")]
    public TerraformSet<AwsConfigOrganizationConformancePackInputParameterBlock>? InputParameter
    {
        get => GetArgument<TerraformSet<AwsConfigOrganizationConformancePackInputParameterBlock>>("input_parameter");
        set => SetArgument("input_parameter", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsConfigOrganizationConformancePackTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsConfigOrganizationConformancePackTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
