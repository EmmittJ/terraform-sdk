using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_shield_protection_health_check_association resource.
/// </summary>
public partial class AwsShieldProtectionHealthCheckAssociation : TerraformResource
{
    public AwsShieldProtectionHealthCheckAssociation(string name) : base("aws_shield_protection_health_check_association", name)
    {
    }

    /// <summary>
    /// The health_check_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HealthCheckArn is required")]
    [TerraformProperty("health_check_arn")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> HealthCheckArn { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The shield_protection_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ShieldProtectionId is required")]
    [TerraformProperty("shield_protection_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ShieldProtectionId { get; set; }

}
