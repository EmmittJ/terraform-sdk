using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_macie2_organization_configuration resource.
/// </summary>
public class AwsMacie2OrganizationConfiguration : TerraformResource
{
    public AwsMacie2OrganizationConfiguration(string name) : base("aws_macie2_organization_configuration", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// Whether to enable Amazon Macie automatically for accounts that are added to the organization in AWS Organizations
    /// </summary>
    public bool? AutoEnable
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("auto_enable")?.Value;
        set => this.WithProperty("auto_enable", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

}
