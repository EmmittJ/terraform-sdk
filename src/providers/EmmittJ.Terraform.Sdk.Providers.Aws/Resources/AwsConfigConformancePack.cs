using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for input_parameter in AwsConfigConformancePack.
/// Nesting mode: set
/// </summary>
public class AwsConfigConformancePackInputParameterBlock : TerraformBlock
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
        get => new TerraformReference<string>(this, "parameter_name");
        set => SetArgument("parameter_name", value);
    }

    /// <summary>
    /// The parameter_value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ParameterValue is required")]
    public required TerraformValue<string> ParameterValue
    {
        get => new TerraformReference<string>(this, "parameter_value");
        set => SetArgument("parameter_value", value);
    }

}


/// <summary>
/// Represents a aws_config_conformance_pack Terraform resource.
/// Manages a aws_config_conformance_pack resource.
/// </summary>
public partial class AwsConfigConformancePack(string name) : TerraformResource("aws_config_conformance_pack", name)
{
    /// <summary>
    /// The delivery_s3_bucket attribute.
    /// </summary>
    public TerraformValue<string>? DeliveryS3Bucket
    {
        get => new TerraformReference<string>(this, "delivery_s3_bucket");
        set => SetArgument("delivery_s3_bucket", value);
    }

    /// <summary>
    /// The delivery_s3_key_prefix attribute.
    /// </summary>
    public TerraformValue<string>? DeliveryS3KeyPrefix
    {
        get => new TerraformReference<string>(this, "delivery_s3_key_prefix");
        set => SetArgument("delivery_s3_key_prefix", value);
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
    /// The template_body attribute.
    /// </summary>
    public TerraformValue<string>? TemplateBody
    {
        get => new TerraformReference<string>(this, "template_body");
        set => SetArgument("template_body", value);
    }

    /// <summary>
    /// The template_s3_uri attribute.
    /// </summary>
    public TerraformValue<string>? TemplateS3Uri
    {
        get => new TerraformReference<string>(this, "template_s3_uri");
        set => SetArgument("template_s3_uri", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// InputParameter block (nesting mode: set).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(60, ErrorMessage = "Maximum 60 InputParameter block(s) allowed")]
    public TerraformSet<AwsConfigConformancePackInputParameterBlock>? InputParameter
    {
        get => GetArgument<TerraformSet<AwsConfigConformancePackInputParameterBlock>>("input_parameter");
        set => SetArgument("input_parameter", value);
    }

}
