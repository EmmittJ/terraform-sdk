using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_iot_registration_code.
/// </summary>
public partial class AwsIotRegistrationCodeDataSource : TerraformDataSource
{
    public AwsIotRegistrationCodeDataSource(string name) : base("aws_iot_registration_code", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The registration_code attribute.
    /// </summary>
    [TerraformProperty("registration_code")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> RegistrationCode { get; }

}
