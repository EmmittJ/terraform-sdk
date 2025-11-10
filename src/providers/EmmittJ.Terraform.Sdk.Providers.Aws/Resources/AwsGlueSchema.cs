using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_glue_schema resource.
/// </summary>
public class AwsGlueSchema : TerraformResource
{
    public AwsGlueSchema(string name) : base("aws_glue_schema", name)
    {
    }

    /// <summary>
    /// The compatibility attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Compatibility is required")]
    [TerraformPropertyName("compatibility")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Compatibility { get; set; }

    /// <summary>
    /// The data_format attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataFormat is required")]
    [TerraformPropertyName("data_format")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> DataFormat { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Description { get; set; }

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
    /// The registry_arn attribute.
    /// </summary>
    [TerraformPropertyName("registry_arn")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> RegistryArn { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "registry_arn");

    /// <summary>
    /// The schema_definition attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SchemaDefinition is required")]
    [TerraformPropertyName("schema_definition")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> SchemaDefinition { get; set; }

    /// <summary>
    /// The schema_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SchemaName is required")]
    [TerraformPropertyName("schema_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> SchemaName { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TagsAll { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags_all");

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The latest_schema_version attribute.
    /// </summary>
    [TerraformPropertyName("latest_schema_version")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> LatestSchemaVersion => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "latest_schema_version");

    /// <summary>
    /// The next_schema_version attribute.
    /// </summary>
    [TerraformPropertyName("next_schema_version")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> NextSchemaVersion => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "next_schema_version");

    /// <summary>
    /// The registry_name attribute.
    /// </summary>
    [TerraformPropertyName("registry_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> RegistryName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "registry_name");

    /// <summary>
    /// The schema_checkpoint attribute.
    /// </summary>
    [TerraformPropertyName("schema_checkpoint")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> SchemaCheckpoint => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "schema_checkpoint");

}
