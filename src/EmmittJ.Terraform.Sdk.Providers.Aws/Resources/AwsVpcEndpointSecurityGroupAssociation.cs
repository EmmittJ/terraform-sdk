using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_vpc_endpoint_security_group_association resource.
/// </summary>
public class AwsVpcEndpointSecurityGroupAssociation : TerraformResource
{
    public AwsVpcEndpointSecurityGroupAssociation(string name) : base("aws_vpc_endpoint_security_group_association", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
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
    /// The replace_default_association attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? ReplaceDefaultAssociation
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("replace_default_association");
        set => this.WithProperty("replace_default_association", value);
    }

    /// <summary>
    /// The security_group_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SecurityGroupId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("security_group_id");
        set => this.WithProperty("security_group_id", value);
    }

    /// <summary>
    /// The vpc_endpoint_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? VpcEndpointId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("vpc_endpoint_id");
        set => this.WithProperty("vpc_endpoint_id", value);
    }

}
