using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_ssoadmin_application.
/// </summary>
public class AwsSsoadminApplicationDataSource : TerraformDataSource
{
    public AwsSsoadminApplicationDataSource(string name) : base("aws_ssoadmin_application", name)
    {
    }

    /// <summary>
    /// The application_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApplicationArn is required")]
    [TerraformPropertyName("application_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ApplicationArn { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The application_account attribute.
    /// </summary>
    [TerraformPropertyName("application_account")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ApplicationAccount => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "application_account");

    /// <summary>
    /// The application_provider_arn attribute.
    /// </summary>
    [TerraformPropertyName("application_provider_arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ApplicationProviderArn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "application_provider_arn");

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Description => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "description");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Id => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The instance_arn attribute.
    /// </summary>
    [TerraformPropertyName("instance_arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> InstanceArn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "instance_arn");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Name => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name");

    /// <summary>
    /// The portal_options attribute.
    /// </summary>
    [TerraformPropertyName("portal_options")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> PortalOptions => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "portal_options");

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformPropertyName("status")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Status => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "status");

}
