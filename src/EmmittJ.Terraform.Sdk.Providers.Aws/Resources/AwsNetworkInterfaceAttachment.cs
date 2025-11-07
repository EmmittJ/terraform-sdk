using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_network_interface_attachment resource.
/// </summary>
public class AwsNetworkInterfaceAttachment : TerraformResource
{
    public AwsNetworkInterfaceAttachment(string name) : base("aws_network_interface_attachment", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("attachment_id");
        this.DeclareOutput("status");
    }

    /// <summary>
    /// The device_index attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? DeviceIndex
    {
        get => GetProperty<TerraformLiteralProperty<double>>("device_index");
        set => this.WithProperty("device_index", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
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
    /// The network_card_index attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? NetworkCardIndex
    {
        get => GetProperty<TerraformLiteralProperty<double>>("network_card_index");
        set => this.WithProperty("network_card_index", value);
    }

    /// <summary>
    /// The network_interface_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? NetworkInterfaceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("network_interface_id");
        set => this.WithProperty("network_interface_id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformLiteralProperty<string>? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The attachment_id attribute.
    /// </summary>
    public TerraformExpression AttachmentId => this["attachment_id"];

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformExpression Status => this["status"];

}
