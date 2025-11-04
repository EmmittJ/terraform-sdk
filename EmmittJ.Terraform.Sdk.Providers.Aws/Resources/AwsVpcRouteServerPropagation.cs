using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_vpc_route_server_propagation resource.
/// </summary>
public class AwsVpcRouteServerPropagation : TerraformResource
{
    public AwsVpcRouteServerPropagation(string name) : base("aws_vpc_route_server_propagation", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The route_server_id attribute.
    /// </summary>
    public string? RouteServerId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("route_server_id")?.Value;
        set => this.WithProperty("route_server_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The route_table_id attribute.
    /// </summary>
    public string? RouteTableId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("route_table_id")?.Value;
        set => this.WithProperty("route_table_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
