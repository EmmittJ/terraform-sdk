using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_shield_protection_health_check_association resource.
/// </summary>
public class AwsShieldProtectionHealthCheckAssociation : TerraformResource
{
    public AwsShieldProtectionHealthCheckAssociation(string name) : base("aws_shield_protection_health_check_association", name)
    {
    }

    /// <summary>
    /// The health_check_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HealthCheckArn is required")]
    [TerraformPropertyName("health_check_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> HealthCheckArn { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The shield_protection_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ShieldProtectionId is required")]
    [TerraformPropertyName("shield_protection_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ShieldProtectionId { get; set; }

}
