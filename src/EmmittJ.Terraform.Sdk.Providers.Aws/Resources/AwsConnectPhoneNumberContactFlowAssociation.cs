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
    }

    /// <summary>
    /// The contact_flow_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContactFlowId is required")]
    public required TerraformProperty<string> ContactFlowId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("contact_flow_id");
        set => this.WithProperty("contact_flow_id", value);
    }

    /// <summary>
    /// The instance_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceId is required")]
    public required TerraformProperty<string> InstanceId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("instance_id");
        set => this.WithProperty("instance_id", value);
    }

    /// <summary>
    /// The phone_number_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PhoneNumberId is required")]
    public required TerraformProperty<string> PhoneNumberId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("phone_number_id");
        set => this.WithProperty("phone_number_id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

}
