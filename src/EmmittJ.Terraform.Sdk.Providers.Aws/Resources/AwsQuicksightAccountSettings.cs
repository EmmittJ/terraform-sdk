using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_quicksight_account_settings resource.
/// </summary>
public class AwsQuicksightAccountSettings : TerraformResource
{
    public AwsQuicksightAccountSettings(string name) : base("aws_quicksight_account_settings", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The aws_account_id attribute.
    /// </summary>
    public string? AwsAccountId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("aws_account_id")?.Value;
        set => this.WithProperty("aws_account_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The default_namespace attribute.
    /// </summary>
    public string? DefaultNamespace
    {
        get => GetProperty<TerraformLiteralProperty<string>>("default_namespace")?.Value;
        set => this.WithProperty("default_namespace", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The termination_protection_enabled attribute.
    /// </summary>
    public bool? TerminationProtectionEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("termination_protection_enabled")?.Value;
        set => this.WithProperty("termination_protection_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

}
