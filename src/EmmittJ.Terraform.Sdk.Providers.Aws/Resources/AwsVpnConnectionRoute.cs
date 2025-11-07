using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_vpn_connection_route resource.
/// </summary>
public class AwsVpnConnectionRoute : TerraformResource
{
    public AwsVpnConnectionRoute(string name) : base("aws_vpn_connection_route", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The destination_cidr_block attribute.
    /// </summary>
    public TerraformProperty<string>? DestinationCidrBlock
    {
        get => GetProperty<TerraformProperty<string>>("destination_cidr_block");
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
    /// The vpn_connection_id attribute.
    /// </summary>
    public TerraformProperty<string>? VpnConnectionId
    {
        get => GetProperty<TerraformProperty<string>>("vpn_connection_id");
        set => this.WithProperty("vpn_connection_id", value);
    }

}
