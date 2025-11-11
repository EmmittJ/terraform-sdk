using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_quicksight_role_custom_permission resource.
/// </summary>
public partial class AwsQuicksightRoleCustomPermission : TerraformResource
{
    public AwsQuicksightRoleCustomPermission(string name) : base("aws_quicksight_role_custom_permission", name)
    {
    }

    /// <summary>
    /// The aws_account_id attribute.
    /// </summary>
    [TerraformProperty("aws_account_id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> AwsAccountId { get; set; }

    /// <summary>
    /// The custom_permissions_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CustomPermissionsName is required")]
    [TerraformProperty("custom_permissions_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> CustomPermissionsName { get; set; }

    /// <summary>
    /// The namespace attribute.
    /// </summary>
    [TerraformProperty("namespace")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Namespace { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The role attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Role is required")]
    [TerraformProperty("role")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Role { get; set; }

}
