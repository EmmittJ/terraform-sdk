using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_servicecatalogappregistry_attribute_group_associations.
/// </summary>
public class AwsServicecatalogappregistryAttributeGroupAssociationsDataSource : TerraformDataSource
{
    public AwsServicecatalogappregistryAttributeGroupAssociationsDataSource(string name) : base("aws_servicecatalogappregistry_attribute_group_associations", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The attribute_group_ids attribute.
    /// </summary>
    [TerraformPropertyName("attribute_group_ids")]
    // Output-only attribute - read-only reference
    public TerraformSet<string> AttributeGroupIds => new TerraformReference(this, "attribute_group_ids");

}
