using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_ssmcontacts_plan.
/// </summary>
public class AwsSsmcontactsPlanDataSource : TerraformDataSource
{
    public AwsSsmcontactsPlanDataSource(string name) : base("aws_ssmcontacts_plan", name)
    {
    }

    /// <summary>
    /// The contact_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContactId is required")]
    [TerraformPropertyName("contact_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ContactId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The stage attribute.
    /// </summary>
    [TerraformPropertyName("stage")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Stage => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "stage");

}
