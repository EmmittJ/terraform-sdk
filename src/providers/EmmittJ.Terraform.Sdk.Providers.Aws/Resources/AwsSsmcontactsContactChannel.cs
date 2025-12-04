using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for delivery_address in AwsSsmcontactsContactChannel.
/// Nesting mode: list
/// </summary>
public class AwsSsmcontactsContactChannelDeliveryAddressBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "delivery_address";

    /// <summary>
    /// The simple_address attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SimpleAddress is required")]
    public required TerraformValue<string> SimpleAddress
    {
        get => GetRequiredArgument<TerraformValue<string>>("simple_address");
        set => SetArgument("simple_address", value);
    }

}


/// <summary>
/// Represents a aws_ssmcontacts_contact_channel Terraform resource.
/// Manages a aws_ssmcontacts_contact_channel resource.
/// </summary>
public partial class AwsSsmcontactsContactChannel(string name) : TerraformResource("aws_ssmcontacts_contact_channel", name)
{
    /// <summary>
    /// The contact_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContactId is required")]
    public required TerraformValue<string> ContactId
    {
        get => GetRequiredArgument<TerraformValue<string>>("contact_id");
        set => SetArgument("contact_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
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
        get => GetArgument<TerraformValue<string>>("region") ?? AsReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => GetRequiredArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// The activation_status attribute.
    /// </summary>
    public TerraformValue<string> ActivationStatus
        => AsReference("activation_status");

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// DeliveryAddress block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DeliveryAddress is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 DeliveryAddress block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DeliveryAddress block(s) allowed")]
    public required TerraformList<AwsSsmcontactsContactChannelDeliveryAddressBlock> DeliveryAddress
    {
        get => GetRequiredArgument<TerraformList<AwsSsmcontactsContactChannelDeliveryAddressBlock>>("delivery_address");
        set => SetArgument("delivery_address", value);
    }

}
