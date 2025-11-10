using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_msk_configuration.
/// </summary>
public class AwsMskConfigurationDataSource : TerraformDataSource
{
    public AwsMskConfigurationDataSource(string name) : base("aws_msk_configuration", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Description => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "description");

    /// <summary>
    /// The kafka_versions attribute.
    /// </summary>
    [TerraformPropertyName("kafka_versions")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<string>>> KafkaVersions => new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "kafka_versions");

    /// <summary>
    /// The latest_revision attribute.
    /// </summary>
    [TerraformPropertyName("latest_revision")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> LatestRevision => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "latest_revision");

    /// <summary>
    /// The server_properties attribute.
    /// </summary>
    [TerraformPropertyName("server_properties")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ServerProperties => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "server_properties");

}
