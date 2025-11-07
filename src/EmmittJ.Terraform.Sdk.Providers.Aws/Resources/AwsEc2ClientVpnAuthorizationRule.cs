using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_ec2_client_vpn_authorization_rule resource.
/// </summary>
public class AwsEc2ClientVpnAuthorizationRule : TerraformResource
{
    public AwsEc2ClientVpnAuthorizationRule(string name) : base("aws_ec2_client_vpn_authorization_rule", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The access_group_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? AccessGroupId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("access_group_id");
        set => this.WithProperty("access_group_id", value);
    }

    /// <summary>
    /// The authorize_all_groups attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? AuthorizeAllGroups
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("authorize_all_groups");
        set => this.WithProperty("authorize_all_groups", value);
    }

    /// <summary>
    /// The client_vpn_endpoint_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ClientVpnEndpointId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("client_vpn_endpoint_id");
        set => this.WithProperty("client_vpn_endpoint_id", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformLiteralProperty<string>? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The target_network_cidr attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? TargetNetworkCidr
    {
        get => GetProperty<TerraformLiteralProperty<string>>("target_network_cidr");
        set => this.WithProperty("target_network_cidr", value);
    }

}
