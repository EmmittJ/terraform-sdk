using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_ssoadmin_application_providers.
/// </summary>
public partial class AwsSsoadminApplicationProvidersDataSource : TerraformDataSource
{
    public AwsSsoadminApplicationProvidersDataSource(string name) : base("aws_ssoadmin_application_providers", name)
    {
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The application_providers attribute.
    /// </summary>
    [TerraformProperty("application_providers")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> ApplicationProviders { get; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Id { get; }

}
