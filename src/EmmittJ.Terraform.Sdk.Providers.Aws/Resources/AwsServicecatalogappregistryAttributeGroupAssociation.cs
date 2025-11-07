using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_servicecatalogappregistry_attribute_group_association resource.
/// </summary>
public class AwsServicecatalogappregistryAttributeGroupAssociation : TerraformResource
{
    public AwsServicecatalogappregistryAttributeGroupAssociation(string name) : base("aws_servicecatalogappregistry_attribute_group_association", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// ID of the application.
    /// </summary>
    public TerraformProperty<string>? ApplicationId
    {
        get => GetProperty<TerraformProperty<string>>("application_id");
        set => this.WithProperty("application_id", value);
    }

    /// <summary>
    /// ID of the attribute group to associate with the application.
    /// </summary>
    public TerraformProperty<string>? AttributeGroupId
    {
        get => GetProperty<TerraformProperty<string>>("attribute_group_id");
        set => this.WithProperty("attribute_group_id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

}
