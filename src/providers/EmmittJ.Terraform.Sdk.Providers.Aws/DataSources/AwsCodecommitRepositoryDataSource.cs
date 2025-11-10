using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_codecommit_repository.
/// </summary>
public class AwsCodecommitRepositoryDataSource : TerraformDataSource
{
    public AwsCodecommitRepositoryDataSource(string name) : base("aws_codecommit_repository", name)
    {
    }

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
    /// The repository_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RepositoryName is required")]
    [TerraformPropertyName("repository_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> RepositoryName { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The clone_url_http attribute.
    /// </summary>
    [TerraformPropertyName("clone_url_http")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CloneUrlHttp => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "clone_url_http");

    /// <summary>
    /// The clone_url_ssh attribute.
    /// </summary>
    [TerraformPropertyName("clone_url_ssh")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CloneUrlSsh => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "clone_url_ssh");

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    [TerraformPropertyName("kms_key_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> KmsKeyId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "kms_key_id");

    /// <summary>
    /// The repository_id attribute.
    /// </summary>
    [TerraformPropertyName("repository_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> RepositoryId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "repository_id");

}
