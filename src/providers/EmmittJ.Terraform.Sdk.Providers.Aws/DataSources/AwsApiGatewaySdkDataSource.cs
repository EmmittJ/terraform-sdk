using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_api_gateway_sdk.
/// </summary>
public class AwsApiGatewaySdkDataSource : TerraformDataSource
{
    public AwsApiGatewaySdkDataSource(string name) : base("aws_api_gateway_sdk", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The parameters attribute.
    /// </summary>
    [TerraformPropertyName("parameters")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Parameters { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The rest_api_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RestApiId is required")]
    [TerraformPropertyName("rest_api_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> RestApiId { get; set; }

    /// <summary>
    /// The sdk_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SdkType is required")]
    [TerraformPropertyName("sdk_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> SdkType { get; set; }

    /// <summary>
    /// The stage_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StageName is required")]
    [TerraformPropertyName("stage_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> StageName { get; set; }

    /// <summary>
    /// The body attribute.
    /// </summary>
    [TerraformPropertyName("body")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Body => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "body");

    /// <summary>
    /// The content_disposition attribute.
    /// </summary>
    [TerraformPropertyName("content_disposition")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ContentDisposition => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "content_disposition");

    /// <summary>
    /// The content_type attribute.
    /// </summary>
    [TerraformPropertyName("content_type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ContentType => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "content_type");

}
