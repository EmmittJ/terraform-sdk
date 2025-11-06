using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_vpc_endpoint_associations.
/// </summary>
public class AwsVpcEndpointAssociationsDataSource : TerraformDataSource
{
    public AwsVpcEndpointAssociationsDataSource(string name) : base("aws_vpc_endpoint_associations", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("associations");
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The vpc_endpoint_id attribute.
    /// </summary>
    public string? VpcEndpointId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("vpc_endpoint_id")?.Value;
        set => this.WithProperty("vpc_endpoint_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The associations attribute.
    /// </summary>
    public TerraformExpression Associations => this["associations"];

}
