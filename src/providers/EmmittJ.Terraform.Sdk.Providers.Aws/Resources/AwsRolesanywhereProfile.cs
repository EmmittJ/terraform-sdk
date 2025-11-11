using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_rolesanywhere_profile resource.
/// </summary>
public partial class AwsRolesanywhereProfile : TerraformResource
{
    public AwsRolesanywhereProfile(string name) : base("aws_rolesanywhere_profile", name)
    {
    }

    /// <summary>
    /// The duration_seconds attribute.
    /// </summary>
    [TerraformProperty("duration_seconds")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> DurationSeconds { get; set; }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformProperty("enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? Enabled { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The managed_policy_arns attribute.
    /// </summary>
    [TerraformProperty("managed_policy_arns")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? ManagedPolicyArns { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The require_instance_properties attribute.
    /// </summary>
    [TerraformProperty("require_instance_properties")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? RequireInstanceProperties { get; set; }

    /// <summary>
    /// The role_arns attribute.
    /// </summary>
    [TerraformProperty("role_arns")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? RoleArns { get; set; }

    /// <summary>
    /// The session_policy attribute.
    /// </summary>
    [TerraformProperty("session_policy")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SessionPolicy { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformMap<string> TagsAll { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

}
