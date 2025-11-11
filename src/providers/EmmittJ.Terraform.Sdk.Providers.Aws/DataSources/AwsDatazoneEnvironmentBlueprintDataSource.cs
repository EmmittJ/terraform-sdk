using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_datazone_environment_blueprint.
/// </summary>
public partial class AwsDatazoneEnvironmentBlueprintDataSource : TerraformDataSource
{
    public AwsDatazoneEnvironmentBlueprintDataSource(string name) : base("aws_datazone_environment_blueprint", name)
    {
    }

    /// <summary>
    /// The domain_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainId is required")]
    [TerraformProperty("domain_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DomainId { get; set; }

    /// <summary>
    /// The managed attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Managed is required")]
    [TerraformProperty("managed")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<bool> Managed { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The blueprint_provider attribute.
    /// </summary>
    [TerraformProperty("blueprint_provider")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> BlueprintProvider { get; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Description { get; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Id { get; }

}
