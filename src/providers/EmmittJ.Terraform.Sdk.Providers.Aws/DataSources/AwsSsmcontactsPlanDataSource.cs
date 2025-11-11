using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_ssmcontacts_plan.
/// </summary>
public partial class AwsSsmcontactsPlanDataSource : TerraformDataSource
{
    public AwsSsmcontactsPlanDataSource(string name) : base("aws_ssmcontacts_plan", name)
    {
    }

    /// <summary>
    /// The contact_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContactId is required")]
    [TerraformProperty("contact_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ContactId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The stage attribute.
    /// </summary>
    [TerraformProperty("stage")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> Stage { get; }

}
