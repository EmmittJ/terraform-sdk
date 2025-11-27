using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for parameters in AwsControltowerControl.
/// Nesting mode: set
/// </summary>
public class AwsControltowerControlParametersBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "parameters";

    /// <summary>
    /// The key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    public required TerraformValue<string> Key
    {
        get => new TerraformReference<string>(this, "key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => new TerraformReference<string>(this, "value");
        set => SetArgument("value", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsControltowerControl.
/// Nesting mode: single
/// </summary>
public class AwsControltowerControlTimeoutsBlock : TerraformBlock
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
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a aws_controltower_control Terraform resource.
/// Manages a aws_controltower_control resource.
/// </summary>
public partial class AwsControltowerControl(string name) : TerraformResource("aws_controltower_control", name)
{
    /// <summary>
    /// The control_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ControlIdentifier is required")]
    public required TerraformValue<string> ControlIdentifier
    {
        get => new TerraformReference<string>(this, "control_identifier");
        set => SetArgument("control_identifier", value);
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
    /// The target_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetIdentifier is required")]
    public required TerraformValue<string> TargetIdentifier
    {
        get => new TerraformReference<string>(this, "target_identifier");
        set => SetArgument("target_identifier", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// Parameters block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsControltowerControlParametersBlock>? Parameters
    {
        get => GetArgument<TerraformSet<AwsControltowerControlParametersBlock>>("parameters");
        set => SetArgument("parameters", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsControltowerControlTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsControltowerControlTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
