using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_vpc_peering_connection_options resource.
/// </summary>
public class AwsVpcPeeringConnectionOptions : TerraformResource
{
    public AwsVpcPeeringConnectionOptions(string name) : base("aws_vpc_peering_connection_options", name)
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
    /// The vpc_peering_connection_id attribute.
    /// </summary>
    public string? VpcPeeringConnectionId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("vpc_peering_connection_id")?.Value;
        set => this.WithProperty("vpc_peering_connection_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
