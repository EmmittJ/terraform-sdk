using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_network_interface_sg_attachment resource.
/// </summary>
public class AwsNetworkInterfaceSgAttachment : TerraformResource
{
    public AwsNetworkInterfaceSgAttachment(string name) : base("aws_network_interface_sg_attachment", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The network_interface_id attribute.
    /// </summary>
    public string? NetworkInterfaceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("network_interface_id")?.Value;
        set => this.WithProperty("network_interface_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The security_group_id attribute.
    /// </summary>
    public string? SecurityGroupId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("security_group_id")?.Value;
        set => this.WithProperty("security_group_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
