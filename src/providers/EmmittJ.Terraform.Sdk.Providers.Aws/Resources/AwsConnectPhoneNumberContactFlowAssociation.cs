using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_connect_phone_number_contact_flow_association Terraform resource.
/// Manages a aws_connect_phone_number_contact_flow_association resource.
/// </summary>
public partial class AwsConnectPhoneNumberContactFlowAssociation(string name) : TerraformResource("aws_connect_phone_number_contact_flow_association", name)
{
    /// <summary>
    /// The contact_flow_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContactFlowId is required")]
    public required TerraformValue<string> ContactFlowId
    {
        get => GetRequiredArgument<TerraformValue<string>>("contact_flow_id");
        set => SetArgument("contact_flow_id", value);
    }

    /// <summary>
    /// The instance_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceId is required")]
    public required TerraformValue<string> InstanceId
    {
        get => GetRequiredArgument<TerraformValue<string>>("instance_id");
        set => SetArgument("instance_id", value);
    }

    /// <summary>
    /// The phone_number_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PhoneNumberId is required")]
    public required TerraformValue<string> PhoneNumberId
    {
        get => GetRequiredArgument<TerraformValue<string>>("phone_number_id");
        set => SetArgument("phone_number_id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? AsReference("region");
        set => SetArgument("region", value);
    }

}
