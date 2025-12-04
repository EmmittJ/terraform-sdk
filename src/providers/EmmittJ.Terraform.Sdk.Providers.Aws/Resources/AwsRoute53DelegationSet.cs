using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_route53_delegation_set Terraform resource.
/// Manages a aws_route53_delegation_set resource.
/// </summary>
public partial class AwsRoute53DelegationSet(string name) : TerraformResource("aws_route53_delegation_set", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The reference_name attribute.
    /// </summary>
    public TerraformValue<string>? ReferenceName
    {
        get => GetArgument<TerraformValue<string>>("reference_name");
        set => SetArgument("reference_name", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The name_servers attribute.
    /// </summary>
    public TerraformList<string> NameServers
        => AsReference("name_servers");

}
