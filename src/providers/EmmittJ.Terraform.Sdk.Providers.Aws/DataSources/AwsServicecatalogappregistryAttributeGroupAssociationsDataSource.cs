using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_servicecatalogappregistry_attribute_group_associations Terraform data source.
/// Retrieves information about a aws_servicecatalogappregistry_attribute_group_associations.
/// </summary>
public partial class AwsServicecatalogappregistryAttributeGroupAssociationsDataSource(string name) : TerraformDataSource("aws_servicecatalogappregistry_attribute_group_associations", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string>? Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
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
    /// The attribute_group_ids attribute.
    /// </summary>
    public TerraformSet<string> AttributeGroupIds
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "attribute_group_ids").ResolveNodes(ctx));
    }

}
