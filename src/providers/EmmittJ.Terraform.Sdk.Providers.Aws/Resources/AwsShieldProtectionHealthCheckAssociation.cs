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
    public required TerraformProperty<TerraformProperty<string>> HealthCheckArn { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The shield_protection_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ShieldProtectionId is required")]
    [TerraformPropertyName("shield_protection_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ShieldProtectionId { get; set; }

}
