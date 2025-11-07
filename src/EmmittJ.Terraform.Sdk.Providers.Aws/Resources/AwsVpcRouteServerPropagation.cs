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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The route_server_id attribute.
    /// </summary>
    public TerraformProperty<string>? RouteServerId
    {
        get => GetProperty<TerraformProperty<string>>("route_server_id");
        set => this.WithProperty("route_server_id", value);
    }

    /// <summary>
    /// The route_table_id attribute.
    /// </summary>
    public TerraformProperty<string>? RouteTableId
    {
        get => GetProperty<TerraformProperty<string>>("route_table_id");
        set => this.WithProperty("route_table_id", value);
    }

}
