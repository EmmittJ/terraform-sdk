using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_vpc_endpoint_security_group_association Terraform resource.
/// Manages a aws_vpc_endpoint_security_group_association resource.
/// </summary>
public partial class AwsVpcEndpointSecurityGroupAssociation(string name) : TerraformResource("aws_vpc_endpoint_security_group_association", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The replace_default_association attribute.
    /// </summary>
    public TerraformValue<bool>? ReplaceDefaultAssociation
    {
        get => new TerraformReference<bool>(this, "replace_default_association");
        set => SetArgument("replace_default_association", value);
    }

    /// <summary>
    /// The security_group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecurityGroupId is required")]
    public required TerraformValue<string> SecurityGroupId
    {
        get => new TerraformReference<string>(this, "security_group_id");
        set => SetArgument("security_group_id", value);
    }

    /// <summary>
    /// The vpc_endpoint_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VpcEndpointId is required")]
    public required TerraformValue<string> VpcEndpointId
    {
        get => new TerraformReference<string>(this, "vpc_endpoint_id");
        set => SetArgument("vpc_endpoint_id", value);
    }

}
