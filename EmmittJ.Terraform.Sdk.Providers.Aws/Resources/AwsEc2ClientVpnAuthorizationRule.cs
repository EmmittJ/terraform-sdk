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
    public string? AccessGroupId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("access_group_id")?.Value;
        set => this.WithProperty("access_group_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The authorize_all_groups attribute.
    /// </summary>
    public bool? AuthorizeAllGroups
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("authorize_all_groups")?.Value;
        set => this.WithProperty("authorize_all_groups", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The client_vpn_endpoint_id attribute.
    /// </summary>
    public string? ClientVpnEndpointId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("client_vpn_endpoint_id")?.Value;
        set => this.WithProperty("client_vpn_endpoint_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public string? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description")?.Value;
        set => this.WithProperty("description", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The target_network_cidr attribute.
    /// </summary>
    public string? TargetNetworkCidr
    {
        get => GetProperty<TerraformLiteralProperty<string>>("target_network_cidr")?.Value;
        set => this.WithProperty("target_network_cidr", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
