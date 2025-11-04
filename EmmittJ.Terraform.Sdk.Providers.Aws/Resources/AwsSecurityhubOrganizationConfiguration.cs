using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_securityhub_organization_configuration resource.
/// </summary>
public class AwsSecurityhubOrganizationConfiguration : TerraformResource
{
    public AwsSecurityhubOrganizationConfiguration(string name) : base("aws_securityhub_organization_configuration", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The auto_enable attribute.
    /// </summary>
    public bool? AutoEnable
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("auto_enable")?.Value;
        set => this.WithProperty("auto_enable", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The auto_enable_standards attribute.
    /// </summary>
    public string? AutoEnableStandards
    {
        get => GetProperty<TerraformLiteralProperty<string>>("auto_enable_standards")?.Value;
        set => this.WithProperty("auto_enable_standards", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
