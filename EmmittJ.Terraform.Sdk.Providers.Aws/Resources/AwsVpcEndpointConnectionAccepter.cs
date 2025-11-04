using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_vpc_endpoint_connection_accepter resource.
/// </summary>
public class AwsVpcEndpointConnectionAccepter : TerraformResource
{
    public AwsVpcEndpointConnectionAccepter(string name) : base("aws_vpc_endpoint_connection_accepter", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("vpc_endpoint_state");
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
    /// The vpc_endpoint_id attribute.
    /// </summary>
    public string? VpcEndpointId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("vpc_endpoint_id")?.Value;
        set => this.WithProperty("vpc_endpoint_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The vpc_endpoint_service_id attribute.
    /// </summary>
    public string? VpcEndpointServiceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("vpc_endpoint_service_id")?.Value;
        set => this.WithProperty("vpc_endpoint_service_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The vpc_endpoint_state attribute.
    /// </summary>
    public TerraformExpression VpcEndpointState => this["vpc_endpoint_state"];

}
