using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_vpc_security_group_vpc_association resource.
/// </summary>
public class AwsVpcSecurityGroupVpcAssociation : TerraformResource
{
    public AwsVpcSecurityGroupVpcAssociation(string name) : base("aws_vpc_security_group_vpc_association", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("state");
    }

    /// <summary>
    /// The security_group_id attribute.
    /// </summary>
    public string? SecurityGroupId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("security_group_id")?.Value;
        set => this.WithProperty("security_group_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    public string? VpcId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("vpc_id")?.Value;
        set => this.WithProperty("vpc_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The state attribute.
    /// </summary>
    public TerraformExpression State => this["state"];

}
