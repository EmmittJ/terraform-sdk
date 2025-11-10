using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_ec2_local_gateway_route resource.
/// </summary>
public class AwsEc2LocalGatewayRoute : TerraformResource
{
    public AwsEc2LocalGatewayRoute(string name) : base("aws_ec2_local_gateway_route", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("destination_cidr_block");
        SetOutput("id");
        SetOutput("local_gateway_route_table_id");
        SetOutput("local_gateway_virtual_interface_group_id");
        SetOutput("region");
    }

    /// <summary>
    /// The destination_cidr_block attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DestinationCidrBlock is required")]
    public required TerraformProperty<string> DestinationCidrBlock
    {
        get => GetRequiredOutput<TerraformProperty<string>>("destination_cidr_block");
        set => SetProperty("destination_cidr_block", value);
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
    /// The local_gateway_route_table_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LocalGatewayRouteTableId is required")]
    public required TerraformProperty<string> LocalGatewayRouteTableId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("local_gateway_route_table_id");
        set => SetProperty("local_gateway_route_table_id", value);
    }

    /// <summary>
    /// The local_gateway_virtual_interface_group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LocalGatewayVirtualInterfaceGroupId is required")]
    public required TerraformProperty<string> LocalGatewayVirtualInterfaceGroupId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("local_gateway_virtual_interface_group_id");
        set => SetProperty("local_gateway_virtual_interface_group_id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

}
