using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in AwsEc2ClientVpnAuthorizationRule.
/// Nesting mode: single
/// </summary>
public class AwsEc2ClientVpnAuthorizationRuleTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

}


/// <summary>
/// Represents a aws_ec2_client_vpn_authorization_rule Terraform resource.
/// Manages a aws_ec2_client_vpn_authorization_rule resource.
/// </summary>
public partial class AwsEc2ClientVpnAuthorizationRule(string name) : TerraformResource("aws_ec2_client_vpn_authorization_rule", name)
{
    /// <summary>
    /// The access_group_id attribute.
    /// </summary>
    public TerraformValue<string>? AccessGroupId
    {
        get => GetArgument<TerraformValue<string>>("access_group_id");
        set => SetArgument("access_group_id", value);
    }

    /// <summary>
    /// The authorize_all_groups attribute.
    /// </summary>
    public TerraformValue<bool>? AuthorizeAllGroups
    {
        get => GetArgument<TerraformValue<bool>>("authorize_all_groups");
        set => SetArgument("authorize_all_groups", value);
    }

    /// <summary>
    /// The client_vpn_endpoint_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientVpnEndpointId is required")]
    public required TerraformValue<string> ClientVpnEndpointId
    {
        get => GetRequiredArgument<TerraformValue<string>>("client_vpn_endpoint_id");
        set => SetArgument("client_vpn_endpoint_id", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? CreateReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The target_network_cidr attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetNetworkCidr is required")]
    public required TerraformValue<string> TargetNetworkCidr
    {
        get => GetRequiredArgument<TerraformValue<string>>("target_network_cidr");
        set => SetArgument("target_network_cidr", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsEc2ClientVpnAuthorizationRuleTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsEc2ClientVpnAuthorizationRuleTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
