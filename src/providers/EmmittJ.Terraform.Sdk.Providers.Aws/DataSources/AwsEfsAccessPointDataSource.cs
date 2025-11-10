using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_efs_access_point.
/// </summary>
public class AwsEfsAccessPointDataSource : TerraformDataSource
{
    public AwsEfsAccessPointDataSource(string name) : base("aws_efs_access_point", name)
    {
    }

    /// <summary>
    /// The access_point_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccessPointId is required")]
    [TerraformPropertyName("access_point_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> AccessPointId { get; set; }

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
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Tags { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags");

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The file_system_arn attribute.
    /// </summary>
    [TerraformPropertyName("file_system_arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> FileSystemArn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "file_system_arn");

    /// <summary>
    /// The file_system_id attribute.
    /// </summary>
    [TerraformPropertyName("file_system_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> FileSystemId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "file_system_id");

    /// <summary>
    /// The owner_id attribute.
    /// </summary>
    [TerraformPropertyName("owner_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> OwnerId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "owner_id");

    /// <summary>
    /// The posix_user attribute.
    /// </summary>
    [TerraformPropertyName("posix_user")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> PosixUser => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "posix_user");

    /// <summary>
    /// The root_directory attribute.
    /// </summary>
    [TerraformPropertyName("root_directory")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> RootDirectory => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "root_directory");

}
