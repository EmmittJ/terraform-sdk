using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_vpc_route_server_vpc_association resource.
/// </summary>
public class AwsVpcRouteServerVpcAssociation : TerraformResource
{
    public AwsVpcRouteServerVpcAssociation(string name) : base("aws_vpc_route_server_vpc_association", name)
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
    /// The vpc_id attribute.
    /// </summary>
    public string? VpcId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("vpc_id")?.Value;
        set => this.WithProperty("vpc_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
