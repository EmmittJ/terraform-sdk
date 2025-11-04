using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_ec2_local_gateway_route_table.
/// </summary>
public class AwsEc2LocalGatewayRouteTableDataSource : TerraformDataSource
{
    public AwsEc2LocalGatewayRouteTableDataSource(string name) : base("aws_ec2_local_gateway_route_table", name)
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
    /// The local_gateway_id attribute.
    /// </summary>
    public string? LocalGatewayId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("local_gateway_id")?.Value;
        set => this.WithProperty("local_gateway_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The local_gateway_route_table_id attribute.
    /// </summary>
    public string? LocalGatewayRouteTableId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("local_gateway_route_table_id")?.Value;
        set => this.WithProperty("local_gateway_route_table_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The outpost_arn attribute.
    /// </summary>
    public string? OutpostArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("outpost_arn")?.Value;
        set => this.WithProperty("outpost_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The state attribute.
    /// </summary>
    public string? State
    {
        get => GetProperty<TerraformLiteralProperty<string>>("state")?.Value;
        set => this.WithProperty("state", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

}
