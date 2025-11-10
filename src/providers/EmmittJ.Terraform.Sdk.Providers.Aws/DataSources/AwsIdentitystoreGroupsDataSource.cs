using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_identitystore_groups.
/// </summary>
public class AwsIdentitystoreGroupsDataSource : TerraformDataSource
{
    public AwsIdentitystoreGroupsDataSource(string name) : base("aws_identitystore_groups", name)
    {
    }

    /// <summary>
    /// The identity_store_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IdentityStoreId is required")]
    [TerraformPropertyName("identity_store_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> IdentityStoreId { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The groups attribute.
    /// </summary>
    [TerraformPropertyName("groups")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Groups => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "groups");

}
