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
    public TerraformProperty<string>? AccessGroupId
    {
        get => GetProperty<TerraformProperty<string>>("access_group_id");
        set => this.WithProperty("access_group_id", value);
    }

    /// <summary>
    /// The authorize_all_groups attribute.
    /// </summary>
    public TerraformProperty<bool>? AuthorizeAllGroups
    {
        get => GetProperty<TerraformProperty<bool>>("authorize_all_groups");
        set => this.WithProperty("authorize_all_groups", value);
    }

    /// <summary>
    /// The client_vpn_endpoint_id attribute.
    /// </summary>
    public TerraformProperty<string>? ClientVpnEndpointId
    {
        get => GetProperty<TerraformProperty<string>>("client_vpn_endpoint_id");
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
    /// The target_network_cidr attribute.
    /// </summary>
    public TerraformProperty<string>? TargetNetworkCidr
    {
        get => GetProperty<TerraformProperty<string>>("target_network_cidr");
        set => this.WithProperty("target_network_cidr", value);
    }

}
