using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_identitystore_group_memberships.
/// </summary>
public partial class AwsIdentitystoreGroupMembershipsDataSource : TerraformDataSource
{
    public AwsIdentitystoreGroupMembershipsDataSource(string name) : base("aws_identitystore_group_memberships", name)
    {
    }

    /// <summary>
    /// The group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GroupId is required")]
    [TerraformProperty("group_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> GroupId { get; set; }

    /// <summary>
    /// The identity_store_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IdentityStoreId is required")]
    [TerraformProperty("identity_store_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> IdentityStoreId { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The group_memberships attribute.
    /// </summary>
    [TerraformProperty("group_memberships")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> GroupMemberships { get; }

}
