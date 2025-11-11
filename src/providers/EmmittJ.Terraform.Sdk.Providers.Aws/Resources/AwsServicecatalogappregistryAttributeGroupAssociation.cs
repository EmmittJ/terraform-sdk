using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_servicecatalogappregistry_attribute_group_association resource.
/// </summary>
public partial class AwsServicecatalogappregistryAttributeGroupAssociation : TerraformResource
{
    public AwsServicecatalogappregistryAttributeGroupAssociation(string name) : base("aws_servicecatalogappregistry_attribute_group_association", name)
    {
    }

    /// <summary>
    /// ID of the application.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApplicationId is required")]
    [TerraformProperty("application_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ApplicationId { get; set; }

    /// <summary>
    /// ID of the attribute group to associate with the application.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AttributeGroupId is required")]
    [TerraformProperty("attribute_group_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> AttributeGroupId { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

}
