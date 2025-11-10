using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsEc2ClientVpnAuthorizationRuleTimeoutsBlock : TerraformBlock
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
        SetOutput("access_group_id");
        SetOutput("authorize_all_groups");
        SetOutput("client_vpn_endpoint_id");
        SetOutput("description");
        SetOutput("id");
        SetOutput("region");
        SetOutput("target_network_cidr");
    }

    /// <summary>
    /// The access_group_id attribute.
    /// </summary>
    public TerraformProperty<string> AccessGroupId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("access_group_id");
        set => SetProperty("access_group_id", value);
    }

    /// <summary>
    /// The authorize_all_groups attribute.
    /// </summary>
    public TerraformProperty<bool> AuthorizeAllGroups
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("authorize_all_groups");
        set => SetProperty("authorize_all_groups", value);
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
    /// The target_network_cidr attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetNetworkCidr is required")]
    public required TerraformProperty<string> TargetNetworkCidr
    {
        get => GetRequiredOutput<TerraformProperty<string>>("target_network_cidr");
        set => SetProperty("target_network_cidr", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsEc2ClientVpnAuthorizationRuleTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
