using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for scope in .
/// Nesting mode: list
/// </summary>
public partial class AwsS3controlDirectoryBucketAccessPointScopeScopeBlock : TerraformBlockBase
{
    /// <summary>
    /// The permissions attribute.
    /// </summary>
    [TerraformProperty("permissions")]
    // Optional argument - source generator will implement get/set
    public TerraformList<string>? Permissions { get; set; }

    /// <summary>
    /// The prefixes attribute.
    /// </summary>
    [TerraformProperty("prefixes")]
    // Optional argument - source generator will implement get/set
    public TerraformList<string>? Prefixes { get; set; }

}

/// <summary>
/// Manages a aws_s3control_directory_bucket_access_point_scope resource.
/// </summary>
public partial class AwsS3controlDirectoryBucketAccessPointScope : TerraformResource
{
    public AwsS3controlDirectoryBucketAccessPointScope(string name) : base("aws_s3control_directory_bucket_access_point_scope", name)
    {
    }

    /// <summary>
    /// The account_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccountId is required")]
    [TerraformProperty("account_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> AccountId { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// Block for scope.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("scope")]
    public TerraformList<TerraformBlock<AwsS3controlDirectoryBucketAccessPointScopeScopeBlock>>? Scope { get; set; }

}
