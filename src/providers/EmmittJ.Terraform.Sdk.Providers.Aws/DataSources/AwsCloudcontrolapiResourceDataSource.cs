using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_cloudcontrolapi_resource.
/// </summary>
public class AwsCloudcontrolapiResourceDataSource : TerraformDataSource
{
    public AwsCloudcontrolapiResourceDataSource(string name) : base("aws_cloudcontrolapi_resource", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Identifier is required")]
    [TerraformPropertyName("identifier")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Identifier { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [TerraformPropertyName("role_arn")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? RoleArn { get; set; }

    /// <summary>
    /// The type_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TypeName is required")]
    [TerraformPropertyName("type_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> TypeName { get; set; }

    /// <summary>
    /// The type_version_id attribute.
    /// </summary>
    [TerraformPropertyName("type_version_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? TypeVersionId { get; set; }

    /// <summary>
    /// The properties attribute.
    /// </summary>
    [TerraformPropertyName("properties")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Properties => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "properties");

}
