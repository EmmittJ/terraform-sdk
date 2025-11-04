using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_eip_association resource.
/// </summary>
public class AwsEipAssociation : TerraformResource
{
    public AwsEipAssociation(string name) : base("aws_eip_association", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The allocation_id attribute.
    /// </summary>
    public string? AllocationId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("allocation_id")?.Value;
        set => this.WithProperty("allocation_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The allow_reassociation attribute.
    /// </summary>
    public bool? AllowReassociation
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("allow_reassociation")?.Value;
        set => this.WithProperty("allow_reassociation", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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
    /// The instance_id attribute.
    /// </summary>
    public string? InstanceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("instance_id")?.Value;
        set => this.WithProperty("instance_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The private_ip_address attribute.
    /// </summary>
    public string? PrivateIpAddress
    {
        get => GetProperty<TerraformLiteralProperty<string>>("private_ip_address")?.Value;
        set => this.WithProperty("private_ip_address", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The public_ip attribute.
    /// </summary>
    public string? PublicIp
    {
        get => GetProperty<TerraformLiteralProperty<string>>("public_ip")?.Value;
        set => this.WithProperty("public_ip", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
