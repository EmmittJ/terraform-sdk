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
        SetOutput("associations");
        SetOutput("region");
        SetOutput("vpc_endpoint_id");
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
    /// The vpc_endpoint_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VpcEndpointId is required")]
    public required TerraformProperty<string> VpcEndpointId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("vpc_endpoint_id");
        set => SetProperty("vpc_endpoint_id", value);
    }

    /// <summary>
    /// The associations attribute.
    /// </summary>
    public TerraformExpression Associations => this["associations"];

}
