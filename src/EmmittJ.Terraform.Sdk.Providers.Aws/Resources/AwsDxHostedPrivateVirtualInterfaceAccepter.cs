using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_dx_hosted_private_virtual_interface_accepter resource.
/// </summary>
public class AwsDxHostedPrivateVirtualInterfaceAccepter : TerraformResource
{
    public AwsDxHostedPrivateVirtualInterfaceAccepter(string name) : base("aws_dx_hosted_private_virtual_interface_accepter", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
    }

    /// <summary>
    /// The dx_gateway_id attribute.
    /// </summary>
    public TerraformProperty<string>? DxGatewayId
    {
        get => GetProperty<TerraformProperty<string>>("dx_gateway_id");
        set => this.WithProperty("dx_gateway_id", value);
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
    /// The tags attribute.
    /// </summary>
    public TerraformProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformProperty<Dictionary<string, string>>? TagsAll
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The virtual_interface_id attribute.
    /// </summary>
    public TerraformProperty<string>? VirtualInterfaceId
    {
        get => GetProperty<TerraformProperty<string>>("virtual_interface_id");
        set => this.WithProperty("virtual_interface_id", value);
    }

    /// <summary>
    /// The vpn_gateway_id attribute.
    /// </summary>
    public TerraformProperty<string>? VpnGatewayId
    {
        get => GetProperty<TerraformProperty<string>>("vpn_gateway_id");
        set => this.WithProperty("vpn_gateway_id", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
