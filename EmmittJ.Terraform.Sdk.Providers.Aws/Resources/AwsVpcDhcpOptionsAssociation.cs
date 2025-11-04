using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_vpc_dhcp_options_association resource.
/// </summary>
public class AwsVpcDhcpOptionsAssociation : TerraformResource
{
    public AwsVpcDhcpOptionsAssociation(string name) : base("aws_vpc_dhcp_options_association", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The dhcp_options_id attribute.
    /// </summary>
    public string? DhcpOptionsId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("dhcp_options_id")?.Value;
        set => this.WithProperty("dhcp_options_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The vpc_id attribute.
    /// </summary>
    public string? VpcId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("vpc_id")?.Value;
        set => this.WithProperty("vpc_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
