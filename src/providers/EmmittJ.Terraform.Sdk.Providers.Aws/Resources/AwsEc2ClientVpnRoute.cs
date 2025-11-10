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
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
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
        this.WithOutputrigin");
        this.WithOutputype");
    }

    /// <summary>
    /// The client_vpn_endpoint_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientVpnEndpointId is required")]
    public required TerraformProperty<string> ClientVpnEndpointId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("client_vpn_endpoint_id");
        set => this.WithProperty("client_vpn_endpoint_id", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The destination_cidr_block attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DestinationCidrBlock is required")]
    public required TerraformProperty<string> DestinationCidrBlock
    {
        get => GetRequiredProperty<TerraformProperty<string>>("destination_cidr_block");
        set => this.WithProperty("destination_cidr_block", value);
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
    /// The target_vpc_subnet_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetVpcSubnetId is required")]
    public required TerraformProperty<string> TargetVpcSubnetId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("target_vpc_subnet_id");
        set => this.WithProperty("target_vpc_subnet_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsEc2ClientVpnRouteTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsEc2ClientVpnRouteTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
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
