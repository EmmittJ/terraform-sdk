using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_connect_phone_number_contact_flow_association resource.
/// </summary>
public class AwsConnectPhoneNumberContactFlowAssociation : TerraformResource
{
    public AwsConnectPhoneNumberContactFlowAssociation(string name) : base("aws_connect_phone_number_contact_flow_association", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("contact_flow_id");
        SetOutput("instance_id");
        SetOutput("phone_number_id");
        SetOutput("region");
    }

    /// <summary>
    /// The contact_flow_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContactFlowId is required")]
    public required TerraformProperty<string> ContactFlowId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("contact_flow_id");
        set => SetProperty("contact_flow_id", value);
    }

    /// <summary>
    /// The instance_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceId is required")]
    public required TerraformProperty<string> InstanceId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("instance_id");
        set => SetProperty("instance_id", value);
    }

    /// <summary>
    /// The phone_number_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PhoneNumberId is required")]
    public required TerraformProperty<string> PhoneNumberId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("phone_number_id");
        set => SetProperty("phone_number_id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

}
