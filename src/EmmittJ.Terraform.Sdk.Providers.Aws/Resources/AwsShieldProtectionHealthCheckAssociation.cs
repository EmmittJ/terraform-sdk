using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_shield_protection_health_check_association resource.
/// </summary>
public class AwsShieldProtectionHealthCheckAssociation : TerraformResource
{
    public AwsShieldProtectionHealthCheckAssociation(string name) : base("aws_shield_protection_health_check_association", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The health_check_arn attribute.
    /// </summary>
    public string? HealthCheckArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("health_check_arn")?.Value;
        set => this.WithProperty("health_check_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The shield_protection_id attribute.
    /// </summary>
    public string? ShieldProtectionId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("shield_protection_id")?.Value;
        set => this.WithProperty("shield_protection_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
