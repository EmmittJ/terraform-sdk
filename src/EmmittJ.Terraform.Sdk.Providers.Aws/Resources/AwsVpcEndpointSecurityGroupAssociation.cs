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
    /// The replace_default_association attribute.
    /// </summary>
    public TerraformProperty<bool>? ReplaceDefaultAssociation
    {
        get => GetProperty<TerraformProperty<bool>>("replace_default_association");
        set => this.WithProperty("replace_default_association", value);
    }

    /// <summary>
    /// The security_group_id attribute.
    /// </summary>
    public TerraformProperty<string>? SecurityGroupId
    {
        get => GetProperty<TerraformProperty<string>>("security_group_id");
        set => this.WithProperty("security_group_id", value);
    }

    /// <summary>
    /// The vpc_endpoint_id attribute.
    /// </summary>
    public TerraformProperty<string>? VpcEndpointId
    {
        get => GetProperty<TerraformProperty<string>>("vpc_endpoint_id");
        set => this.WithProperty("vpc_endpoint_id", value);
    }

}
