using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsEc2ClientVpnRouteTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

}

/// <summary>
/// Manages a aws_ec2_client_vpn_route resource.
/// </summary>
public class AwsEc2ClientVpnRoute : TerraformResource
{
    public AwsEc2ClientVpnRoute(string name) : base("aws_ec2_client_vpn_route", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("origin");
        SetOutput("type");
        SetOutput("client_vpn_endpoint_id");
        SetOutput("description");
        SetOutput("destination_cidr_block");
        SetOutput("id");
        SetOutput("region");
        SetOutput("target_vpc_subnet_id");
    }

    /// <summary>
    /// The client_vpn_endpoint_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientVpnEndpointId is required")]
    public required TerraformProperty<string> ClientVpnEndpointId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("client_vpn_endpoint_id");
        set => SetProperty("client_vpn_endpoint_id", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The target_vpc_subnet_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetVpcSubnetId is required")]
    public required TerraformProperty<string> TargetVpcSubnetId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("target_vpc_subnet_id");
        set => SetProperty("target_vpc_subnet_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsEc2ClientVpnRouteTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The origin attribute.
    /// </summary>
    public TerraformExpression Origin => this["origin"];

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformExpression Type => this["type"];

}
