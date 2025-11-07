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
    public TerraformLiteralProperty<string>? ContactFlowId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("contact_flow_id");
        set => this.WithProperty("contact_flow_id", value);
    }

    /// <summary>
    /// The instance_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? InstanceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("instance_id");
        set => this.WithProperty("instance_id", value);
    }

    /// <summary>
    /// The phone_number_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? PhoneNumberId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("phone_number_id");
        set => this.WithProperty("phone_number_id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformLiteralProperty<string>? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

}
