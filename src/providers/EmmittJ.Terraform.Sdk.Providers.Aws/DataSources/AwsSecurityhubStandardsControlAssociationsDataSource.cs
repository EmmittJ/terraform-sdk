using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_securityhub_standards_control_associations.
/// </summary>
public partial class AwsSecurityhubStandardsControlAssociationsDataSource : TerraformDataSource
{
    public AwsSecurityhubStandardsControlAssociationsDataSource(string name) : base("aws_securityhub_standards_control_associations", name)
    {
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The security_control_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecurityControlId is required")]
    [TerraformProperty("security_control_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> SecurityControlId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Id { get; }

    /// <summary>
    /// The standards_control_associations attribute.
    /// </summary>
    [TerraformProperty("standards_control_associations")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> StandardsControlAssociations { get; }

}
