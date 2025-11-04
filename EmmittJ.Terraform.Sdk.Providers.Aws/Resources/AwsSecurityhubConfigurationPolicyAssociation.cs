using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_securityhub_configuration_policy_association resource.
/// </summary>
public class AwsSecurityhubConfigurationPolicyAssociation : TerraformResource
{
    public AwsSecurityhubConfigurationPolicyAssociation(string name) : base("aws_securityhub_configuration_policy_association", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
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
    /// The universally unique identifier (UUID) of the configuration policy.
    /// </summary>
    public string? PolicyId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("policy_id")?.Value;
        set => this.WithProperty("policy_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The identifier of the target account, organizational unit, or the root to associate with the specified configuration.
    /// </summary>
    public string? TargetId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("target_id")?.Value;
        set => this.WithProperty("target_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
