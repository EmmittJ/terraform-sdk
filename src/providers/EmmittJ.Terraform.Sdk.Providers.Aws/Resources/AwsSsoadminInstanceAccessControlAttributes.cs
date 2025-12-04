using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for attribute in AwsSsoadminInstanceAccessControlAttributes.
/// Nesting mode: set
/// </summary>
public class AwsSsoadminInstanceAccessControlAttributesAttributeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "attribute";

    /// <summary>
    /// The key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    public required TerraformValue<string> Key
    {
        get => GetRequiredArgument<TerraformValue<string>>("key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// Value block (nesting mode: set).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Value block(s) required")]
    public required TerraformSet<AwsSsoadminInstanceAccessControlAttributesAttributeBlockValueBlock> Value
    {
        get => GetRequiredArgument<TerraformSet<AwsSsoadminInstanceAccessControlAttributesAttributeBlockValueBlock>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for value in AwsSsoadminInstanceAccessControlAttributesAttributeBlock.
/// Nesting mode: set
/// </summary>
public class AwsSsoadminInstanceAccessControlAttributesAttributeBlockValueBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "value";

    /// <summary>
    /// The source attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Source is required")]
    public required TerraformSet<string> Source
    {
        get => GetRequiredArgument<TerraformSet<string>>("source");
        set => SetArgument("source", value);
    }

}


/// <summary>
/// Represents a aws_ssoadmin_instance_access_control_attributes Terraform resource.
/// Manages a aws_ssoadmin_instance_access_control_attributes resource.
/// </summary>
public partial class AwsSsoadminInstanceAccessControlAttributes(string name) : TerraformResource("aws_ssoadmin_instance_access_control_attributes", name)
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
    /// The instance_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceArn is required")]
    public required TerraformValue<string> InstanceArn
    {
        get => GetRequiredArgument<TerraformValue<string>>("instance_arn");
        set => SetArgument("instance_arn", value);
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
    /// The status attribute.
    /// </summary>
    public TerraformValue<string> Status
        => AsReference("status");

    /// <summary>
    /// The status_reason attribute.
    /// </summary>
    public TerraformValue<string> StatusReason
        => AsReference("status_reason");

    /// <summary>
    /// Attribute block (nesting mode: set).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Attribute is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Attribute block(s) required")]
    public required TerraformSet<AwsSsoadminInstanceAccessControlAttributesAttributeBlock> Attribute
    {
        get => GetRequiredArgument<TerraformSet<AwsSsoadminInstanceAccessControlAttributesAttributeBlock>>("attribute");
        set => SetArgument("attribute", value);
    }

}
