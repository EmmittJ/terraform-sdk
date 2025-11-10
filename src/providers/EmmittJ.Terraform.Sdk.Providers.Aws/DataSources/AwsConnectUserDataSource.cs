using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_connect_user.
/// </summary>
public class AwsConnectUserDataSource : TerraformDataSource
{
    public AwsConnectUserDataSource(string name) : base("aws_connect_user", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The instance_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceId is required")]
    [TerraformPropertyName("instance_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> InstanceId { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Name { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name");

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
    /// The user_id attribute.
    /// </summary>
    [TerraformPropertyName("user_id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> UserId { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "user_id");

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The directory_user_id attribute.
    /// </summary>
    [TerraformPropertyName("directory_user_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DirectoryUserId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "directory_user_id");

    /// <summary>
    /// The hierarchy_group_id attribute.
    /// </summary>
    [TerraformPropertyName("hierarchy_group_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> HierarchyGroupId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "hierarchy_group_id");

    /// <summary>
    /// The identity_info attribute.
    /// </summary>
    [TerraformPropertyName("identity_info")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> IdentityInfo => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "identity_info");

    /// <summary>
    /// The phone_config attribute.
    /// </summary>
    [TerraformPropertyName("phone_config")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> PhoneConfig => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "phone_config");

    /// <summary>
    /// The routing_profile_id attribute.
    /// </summary>
    [TerraformPropertyName("routing_profile_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> RoutingProfileId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "routing_profile_id");

    /// <summary>
    /// The security_profile_ids attribute.
    /// </summary>
    [TerraformPropertyName("security_profile_ids")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<string>>> SecurityProfileIds => new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "security_profile_ids");

}
