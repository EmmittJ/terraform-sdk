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
    public TerraformProperty<string>? AwsAccountId
    {
        get => GetProperty<TerraformProperty<string>>("aws_account_id");
        set => this.WithProperty("aws_account_id", value);
    }

    /// <summary>
    /// The default_namespace attribute.
    /// </summary>
    public TerraformProperty<string>? DefaultNamespace
    {
        get => GetProperty<TerraformProperty<string>>("default_namespace");
        set => this.WithProperty("default_namespace", value);
    }

    /// <summary>
    /// The termination_protection_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? TerminationProtectionEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("termination_protection_enabled");
        set => this.WithProperty("termination_protection_enabled", value);
    }

}
