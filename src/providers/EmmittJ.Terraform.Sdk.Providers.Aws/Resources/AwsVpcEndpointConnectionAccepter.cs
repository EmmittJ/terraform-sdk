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
        SetOutput("vpc_endpoint_state");
        SetOutput("id");
        SetOutput("region");
        SetOutput("vpc_endpoint_id");
        SetOutput("vpc_endpoint_service_id");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The vpc_endpoint_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VpcEndpointId is required")]
    public required TerraformProperty<string> VpcEndpointId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("vpc_endpoint_id");
        set => SetProperty("vpc_endpoint_id", value);
    }

    /// <summary>
    /// The vpc_endpoint_service_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VpcEndpointServiceId is required")]
    public required TerraformProperty<string> VpcEndpointServiceId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("vpc_endpoint_service_id");
        set => SetProperty("vpc_endpoint_service_id", value);
    }

    /// <summary>
    /// The vpc_endpoint_state attribute.
    /// </summary>
    public TerraformExpression VpcEndpointState => this["vpc_endpoint_state"];

}
