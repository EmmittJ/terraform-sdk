using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_ssoadmin_application_providers.
/// </summary>
public class AwsSsoadminApplicationProvidersDataSource : TerraformDataSource
{
    public AwsSsoadminApplicationProvidersDataSource(string name) : base("aws_ssoadmin_application_providers", name)
    {
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The application_providers attribute.
    /// </summary>
    [TerraformPropertyName("application_providers")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> ApplicationProviders => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "application_providers");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Id => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

}
