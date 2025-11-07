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
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
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
    /// The vpc_endpoint_id attribute.
    /// </summary>
    public TerraformProperty<string>? VpcEndpointId
    {
        get => GetProperty<TerraformProperty<string>>("vpc_endpoint_id");
        set => this.WithProperty("vpc_endpoint_id", value);
    }

    /// <summary>
    /// The vpc_endpoint_service_id attribute.
    /// </summary>
    public TerraformProperty<string>? VpcEndpointServiceId
    {
        get => GetProperty<TerraformProperty<string>>("vpc_endpoint_service_id");
        set => this.WithProperty("vpc_endpoint_service_id", value);
    }

    /// <summary>
    /// The vpc_endpoint_state attribute.
    /// </summary>
    public TerraformExpression VpcEndpointState => this["vpc_endpoint_state"];

}
