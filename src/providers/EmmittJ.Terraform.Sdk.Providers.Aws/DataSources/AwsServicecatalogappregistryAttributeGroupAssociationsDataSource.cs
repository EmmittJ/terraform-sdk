using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_servicecatalogappregistry_attribute_group_associations.
/// </summary>
public class AwsServicecatalogappregistryAttributeGroupAssociationsDataSource : TerraformDataSource
{
    public AwsServicecatalogappregistryAttributeGroupAssociationsDataSource(string name) : base("aws_servicecatalogappregistry_attribute_group_associations", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("attribute_group_ids");
        SetOutput("id");
        SetOutput("name");
        SetOutput("region");
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
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
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
    /// The attribute_group_ids attribute.
    /// </summary>
    public TerraformExpression AttributeGroupIds => this["attribute_group_ids"];

}
