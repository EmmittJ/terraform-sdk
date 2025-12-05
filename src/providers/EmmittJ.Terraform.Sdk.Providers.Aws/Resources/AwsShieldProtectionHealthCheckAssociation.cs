using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_shield_protection_health_check_association Terraform resource.
/// Manages a aws_shield_protection_health_check_association resource.
/// </summary>
public partial class AwsShieldProtectionHealthCheckAssociation(string name) : TerraformResource("aws_shield_protection_health_check_association", name)
{
    /// <summary>
    /// The health_check_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HealthCheckArn is required")]
    public required TerraformValue<string> HealthCheckArn
    {
        get => GetRequiredArgument<TerraformValue<string>>("health_check_arn");
        set => SetArgument("health_check_arn", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The shield_protection_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ShieldProtectionId is required")]
    public required TerraformValue<string> ShieldProtectionId
    {
        get => GetRequiredArgument<TerraformValue<string>>("shield_protection_id");
        set => SetArgument("shield_protection_id", value);
    }

}
