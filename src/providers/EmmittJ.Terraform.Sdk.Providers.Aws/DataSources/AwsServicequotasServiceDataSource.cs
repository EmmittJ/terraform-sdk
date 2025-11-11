using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_servicequotas_service.
/// </summary>
public partial class AwsServicequotasServiceDataSource : TerraformDataSource
{
    public AwsServicequotasServiceDataSource(string name) : base("aws_servicequotas_service", name)
    {
    }

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
    /// The service_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceName is required")]
    [TerraformProperty("service_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ServiceName { get; set; }

    /// <summary>
    /// The service_code attribute.
    /// </summary>
    [TerraformProperty("service_code")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ServiceCode { get; }

}
