using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for scope in .
/// Nesting mode: list
/// </summary>
public class AwsS3controlDirectoryBucketAccessPointScopeScopeBlock : ITerraformBlock
{
    /// <summary>
    /// The permissions attribute.
    /// </summary>
    [TerraformPropertyName("permissions")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? Permissions { get; set; }

    /// <summary>
    /// The prefixes attribute.
    /// </summary>
    [TerraformPropertyName("prefixes")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? Prefixes { get; set; }

}

/// <summary>
/// Manages a aws_s3control_directory_bucket_access_point_scope resource.
/// </summary>
public class AwsS3controlDirectoryBucketAccessPointScope : TerraformResource
{
    public AwsS3controlDirectoryBucketAccessPointScope(string name) : base("aws_s3control_directory_bucket_access_point_scope", name)
    {
    }

    /// <summary>
    /// The account_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccountId is required")]
    [TerraformPropertyName("account_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> AccountId { get; set; }

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
    /// Block for scope.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("scope")]
    public TerraformList<TerraformBlock<AwsS3controlDirectoryBucketAccessPointScopeScopeBlock>>? Scope { get; set; } = new();

}
